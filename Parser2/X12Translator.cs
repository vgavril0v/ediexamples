using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Ack;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Plugins.Acknowledgments.X12.Model;
using EdiFabric.Templates.EdifactD97A;
using EdiFabric.Templates.X12005040;
using EdiParser;

namespace Parser2
{
    public class X12Translator
    {
        public static void TranslateX12(string ediSourcePath, string translatedFolderPath,
            Assembly templateAssembly,
            string fileNameFilter = null,
            bool withAcknowlegment = false)
        {
            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    var tsTa1 = a.Message as TSTA1;
                    var ts997 = a.Message as TS997;

                    // ts997.AK1.FunctionalIdentifierCode_01 = "A";
                    ts997.AK9.FunctionalGroupAcknowledgeCode_01 = "A";
                    ts997.AK9.NumberofAcceptedTransactionSets_04 = ts997.AK9.NumberofReceivedTransactionSets_03;
                    foreach (var aa in ts997.AK2Loop1)
                    {
                        aa.AK5.TransactionSetAcknowledgmentCode_01 = "A";
                        aa.AK3Loop1 = null;
                    }

                    if (tsTa1 != null)
                    {
                        // a.Message is TA1 
                    }

                    if (ts997 != null)
                    {
                        //  Inspect the acknowledgment
                        var ackCode = ts997.AK9.FunctionalGroupAcknowledgeCode_01;

                        var ack = AckBuilders.BuildAck(a.InterchangeHeader, a.GroupHeader, ts997, AckVersion.X12_997);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (!a.ErrorContext.HasErrors)
                    {
                        // do something with the message a.Message
                        Debug.WriteLine("Message {0} with control number {1} is valid.", a.ErrorContext.Name,
                            a.ErrorContext.ControlNumber);
                    }

                    a.ErrorContext.Errors.Clear();
                    a.ErrorContext.HasErrors = false;
                },
                AckVersion = AckVersion.X12_997,
                // Turn off AK2 for valid messages to reduce size
                GenerateForValidMessages = false
            };

            foreach (var fileName in Directory.EnumerateFiles(ediSourcePath, fileNameFilter ?? "*"))
            {

                var ackMan = withAcknowlegment ? new EdiFabric.Plugins.Acknowledgments.X12.AckMan(settings) : null;
                try
                {
                    using (X12Reader reader = new X12Reader(new FileStream(fileName, FileMode.Open), mc =>
                    {
                        // return Assembly.GetAssembly(typeof(EdiFabric.Templates.EdifactD96A.ADR));
                        return templateAssembly;
                    }))
                    {
                        var ediItems = reader.ReadToEnd().ToList();
                        Console.WriteLine(Path.GetFileName(fileName));
                        foreach (var ediItem in ediItems)
                        {
                            if (withAcknowlegment)
                                ackMan.Publish(ediItem);

                            var resultFileName = Path.Combine(translatedFolderPath,
                                Path.GetFileNameWithoutExtension(fileName) + ".txt");
                            if (ediItem is TS856)
                            {
                                var asn = (TS856) ediItem;
                                using (var writer = new FieldWriter(File.CreateText(resultFileName)))
                                {
                                    WriteLowesAsn(asn, writer);
                                }
                            }

                        }
                    }
                }
                finally
                {
                    ackMan?.Dispose();
                }


            }


        }

        private static void WriteLowesAsn(TS856 asn, FieldWriter writer)
        {



        }
    }
}