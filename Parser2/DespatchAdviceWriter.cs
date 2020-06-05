using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.EdifactD97A;

namespace Parser2
{
    public static class DespatchAdviceWriter
    {
        public static async Task WriteEdiFactAsnResponse(string sourceEdiFolderPath, string responseFolderPath)
        {
            foreach (var file in Directory.EnumerateFiles(sourceEdiFolderPath).Select(f => new FileInfo(f)))
            {
                if (file.Name.EndsWith("_sn"))
                    continue;

                var ediFilePath = Path.Combine(sourceEdiFolderPath, file.Name);
                using (EdifactReader reader =
                    new EdifactReader(new FileStream(ediFilePath, FileMode.Open)))
                {
                    var ediItems = reader.ReadToEnd().ToList();
                    foreach (var item in ediItems.Where(item => item is TSDESADV || item is TSORDERS))
                    {
                        await WriteEdiFactAsnResponse(item, ReadSerialNumbers(ediFilePath),
                            Path.Combine(responseFolderPath, Path.GetFileNameWithoutExtension(file.Name) + "_desadv.txt"));
                    }
                }
            }
        }

        private static IEnumerable<string> ReadSerialNumbers(string ediFilePath)
        {
            var snFilePath = ediFilePath + "_sn";
            if (!File.Exists(ediFilePath + "_sn"))
            {
                return new string[0];
            }

            return File.ReadAllLines(snFilePath)
                .Where(ln => !string.IsNullOrWhiteSpace(ln))
                .Select(ln => ln.Trim());
        }

        private static async Task WriteEdiFactAsnResponse(IEdiItem ediItem,
            IEnumerable<string> serialNumbers,
            string responseFilePath)
        {
            var controlNumber = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds().ToString();
            var transaction = ediItem is TSORDERS item ?
                (await BuildDespatchAdviceForOrder(item, serialNumbers, controlNumber)) :
                DespatchAdviceGRBuilder.BuildDespatchAdvice(controlNumber, (TSDESADV)ediItem);

            using (var stream = File.Create(responseFilePath))
            {
                using (var writer = new EdifactWriter(stream, new EdifactWriterSettings{Encoding = Encoding.Default}))
                {
                    writer.Write(Separators.Edifact.ToUna());
                    writer.Write(EDIFactSegmentBuilders.BuildUnb(controlNumber));
                    writer.Write(transaction);
                }
            }
        }

        private static async Task<TSDESADV> BuildDespatchAdviceForOrder(TSORDERS ediItem, IEnumerable<string> serialNumbers, string controlNumber)
        {
            switch (ediItem.BGM.Messagefunctioncoded_03)
            {
                case "9":
                case "4":
                    return await DespatchAdviceShipmentBuilder.BuildDespatchAdvice(controlNumber, ediItem, serialNumbers);
                case "38":
                    return DespatchAdviceGRBuilder.BuildDespatchAdvice(controlNumber, ediItem, serialNumbers);
            }

            throw new ArgumentException("Unknown order type " + ediItem.BGM.Messagefunctioncoded_03);
        }
    }
}