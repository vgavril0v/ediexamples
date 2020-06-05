using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD97A;
using Parser2.LenovoApi;

namespace Parser2.InventoryReco
{
    public static class InventoryRecoSender
    {
        public static async Task SendInventoryForReceivings(string sourceEdiFolderPath)
        {
            var builder = new InventoryRecoBuilder();

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
                        if (item is TSDESADV)
                        {
                            BuildDesadvData(builder, (TSDESADV) item);
                        }

                        if (item is TSORDERS)
                        {
                            BuildOrderData(builder, (TSORDERS)item);
                        }
                    }
                }
            }

            var res = await LenovoInventoryClient.PostInvetoryData(new InventoryData
            {
                user_name = "gotrg_test",
                data = builder.BuildInventoryData()
            });
        }

        private static void BuildOrderData(InventoryRecoBuilder builder, TSORDERS item)
        {

            var loc = item.FTX?.FirstOrDefault()?.TEXTLITERAL_04?.Freetext_01?.Split(';');
            var plant = (loc != null && loc.Length >= 2) ? loc[1] : null;
            var location = (loc != null && loc.Length >= 2) ? loc[0] : null;

            foreach (var lin in item.LINLoop)
            {
                builder.WithMaterial(lin.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01,
                    plant,
                    location ?? "CA01",
                    lin.QTY.Sum(q => Convert.ToInt32(q.QUANTITYDETAILS_01.Quantity_02)));
            }
        }

        private static void BuildDesadvData(InventoryRecoBuilder builder, TSDESADV item)
        {
            foreach (var cps in item.CPSLoop)
            {
                var loc = cps
                    .LINLoop.FirstOrDefault()?
                    .LOCLoop.FirstOrDefault()?.LOC?.LOCATIONIDENTIFICATION_02
                    ?.Placelocation_04?.Split(' ');

                var plant = loc != null && loc.Length > 0 ? loc[0] : null;
                var location = loc != null && loc.Length > 1 ? loc[1] : null;

                foreach (var lin in cps.LINLoop)
                {

                    builder.WithMaterial(lin.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01, 
                        plant,
                        location ?? "CA01",
                        lin.QTY.Sum(q => Convert.ToInt32(q.QUANTITYDETAILS_01.Quantity_02)));
                }
            }
        }
    }
}