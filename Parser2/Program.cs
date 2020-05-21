using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12005010;
using Parser2;

namespace EdiParser
{
    class Program
    {

        static void Main(string[] args)
        {
            var root = @"C:\work\dev\edi";

            // write goods received
            DespatchAdviceWriter.WriteEdiFactAsnResponse(
                Path.Combine(root, @"sample\lenovo\to_respond"),
                Path.Combine(Path.Combine(root, @"sample\lenovo\response")))
                .Wait();

            return;
         /*   // translate edi fact
            EdiFactTranslator.TranslateEdiFact(Path.Combine(root, @"sample\lenovo"),
                Path.Combine(root, @"sample\lenovo\translated"));

            // write wm asn
            var asn = new AsnWriter();
            asn.WriteAsn(Path.Combine(root, Guid.NewGuid().ToString("D")));*/

            #region wm ack

            /*
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
                                 Debug.WriteLine("Message {0} with control number {1} is valid.", a.ErrorContext.Name, a.ErrorContext.ControlNumber);
                             }

                             a.ErrorContext.Errors.Clear();
                             a.ErrorContext.HasErrors = false;
                         },
                         AckVersion = AckVersion.X12_997,
                         // Turn off AK2 for valid messages to reduce size
                         GenerateForValidMessages = false
                     };


                     //TL_6637eb02-75b4-4b3a-9f32-5b2e7059d920.edi
                     var edi = File.OpenRead(@"C:\work\dev\edi\TL_42e0c5bf-ac84-441c-b9ca-0ccbe6170880.edi");
                     using (var ackMan = new EdiFabric.Plugins.Acknowledgments.X12.AckMan(settings))
                     {
                         using (var ediReader = new X12Reader(edi, mc =>
                         {
                             // return Assembly.GetAssembly(typeof(EdiFabric.Templates.EdifactD96A.ADR));
                             return Assembly.GetAssembly(typeof(EdiFabric.Templates.X12004010.AAA));
                         }))
                         {
                             while (ediReader.Read())
                                 ackMan.Publish(ediReader.Item);
                         }
                     }
                     return;*/

            #endregion

            #region wm staff

            using (var output = File.CreateText(Path.Combine(root, "stores.txt")))
            {
                //*.edi
                Dictionary<string, Loop_N1_816_2> ids = new Dictionary<string, Loop_N1_816_2>();
                foreach (var file in Directory.EnumerateFiles(root, "00000*").Select(f => new FileInfo(f))
                    .OrderBy(f =>
                        f.Name == "000005_X12_005010_816_OUT-7.011390366.523604" ? new DateTime() : f.CreationTimeUtc))
                {

                    // using (EdifactReader reader = new EdifactReader(new FileStream(Path.Combine(root, file), FileMode.Open),
                    using (X12Reader reader = new X12Reader(
                        new FileStream(Path.Combine(root, file.Name), FileMode.Open),
                        mc =>
                        {
                            // return Assembly.GetAssembly(typeof(EdiFabric.Templates.EdifactD96A.ADR));
                            return Assembly.GetExecutingAssembly();
                        }))
                    {
                        var ediItems = reader.ReadToEnd().ToList();

                        if (ediItems.Any(i => i is EdiFabric.Core.Model.Edi.ErrorContexts.ReaderErrorContext))
                        {
                            Console.WriteLine(file + " " + ediItems.First(i =>
                                                  i is EdiFabric.Core.Model.Edi.ErrorContexts.ReaderErrorContext));
                        }


                        foreach (var ediItem in ediItems.Where(i => i is EdiFabric.Templates.X12005010.TS816)
                            .Cast<EdiFabric.Templates.X12005010.TS816>())
                        {
                            foreach (var h in ediItem.HLLoop)
                            {

                                /*WL("id", h.Id.ToString());
                                WL("HierarchicalChildCode_04", h.HL.HierarchicalChildCode_04);
                                WL("HierarchicalIDNumber_01", h.HL.HierarchicalIDNumber_01);
                                WL("HierarchicalLevelCode_03", h.HL.HierarchicalLevelCode_03);
                                WL("HierarchicalParentIDNumber_02", h.HL.HierarchicalParentIDNumber_02);
                                
                                */

                                foreach (var n in h.N1Loop)
                                {

                                    /* WL("EntityIdentifierCode_01", n.N1.EntityIdentifierCode_01);
                                     WL("Id", n.N1.Id.ToString());
                                     WL("IdentificationCodeQualifier_03", n.N1.IdentificationCodeQualifier_03);
                                     WL("IdentificationCode_04", n.N1.IdentificationCode_04);*/
                                    if (!ids.ContainsKey(n.N1.IdentificationCode_04))
                                        ids.Add(n.N1.IdentificationCode_04, n);
                                    else
                                    {
                                        ids[n.N1.IdentificationCode_04] = n;
                                    }

                                    /* WL("Name_02", n.N1.Name_02);

                                     if (n.N3 != null)
                                     {
                                         foreach (var n3 in n.N3)
                                         {
                                             WL("AddressInformation_01", n3.AddressInformation_01);
                                             WL("AddressInformation_02", n3.AddressInformation_02);
                                         }
                                     }

                                     WL("CityName_01", n.N4.CityName_01);
                                     WL("CountryCode_04", n.N4.CountryCode_04);
                                     WL("PostalCode_03", n.N4.PostalCode_03);


                                     if (n.REF != null)
                                     {
                                         foreach (var r in n.REF)
                                         {

                                             WL("ref:Description_03", r.Description_03);
                                             WL("ref:ReferenceIdentificationQualifier_01", r.ReferenceIdentificationQualifier_01);
                                             WL("ref:ReferenceIdentification_02", r.ReferenceIdentification_02);
                                             if (r.ReferenceIdentifier_04 != null)
                                             {
                                                 WL("ref:" + r.ReferenceIdentifier_04.ReferenceIdentificationQualifier_01,
                                                     r.ReferenceIdentifier_04.ReferenceIdentification_02);
                                                 WL("ref:" + r.ReferenceIdentifier_04.ReferenceIdentificationQualifier_03,
                                                     r.ReferenceIdentifier_04.ReferenceIdentification_04);
                                                 WL("ref:" + r.ReferenceIdentifier_04.ReferenceIdentificationQualifier_05,
                                                     r.ReferenceIdentifier_04.ReferenceIdentification_06);
                                             }

                                         }
                                     }

                                     if (n.PER != null)
                                     {
                                         foreach (var per in n.PER)
                                         {
                                             WL("communication:ContactFunctionCode_01", per.ContactFunctionCode_01);
                                             WL("communication:ContactFunctionCode_01", per.ContactInquiryReference_09);
                                             WL("communication:Name_02", per.Name_02);
                                             WL("communication:" + per.CommunicationNumberQualifier_03,
                                                 per.CommunicationNumber_04);
                                             WL("communication:" + per.CommunicationNumberQualifier_05,
                                                 per.CommunicationNumber_06);
                                             WL("communication:" + per.CommunicationNumberQualifier_07,
                                                 per.CommunicationNumber_08);

                                         }
                                     }
                                 }

                                 WL("------ hl ------", "");*/
                                }
                            }

                        }
                    }
                }

                /*  WT(
                          "INSERT INTO table (IdentificationCode, StoreNumber, Phone, CountryCode, StateCode, CityName, PostalCode, AddressLine1, AddressLine2, AddressLine3, StoreName)", true);
                      WT("VALUES");
                      foreach (var id in ids)
                      {
                          var n = id.Value;
                          var sn = n.REF?.FirstOrDefault(r => r.ReferenceIdentificationQualifier_01 == "ST")
                              ?.ReferenceIdentification_02;
                          if (sn == null || n.N3 == null)
                              continue;
                          WT("('" + n.N1.IdentificationCode_04 + "',");
                          WT("'" + sn + "',");
                          WT("'" + n.PER?.FirstOrDefault(r => r.CommunicationNumberQualifier_03 == "TE")?.CommunicationNumber_04 + "',");
                              // WT("'" + n.N3.First().AddressInformation_01 + "',");
                          WT("'" + n.N4.CountryCode_04 + "',");
                          WT("'" + n.N4.StateorProvinceCode_02 + "',");
                          WT("'" + n.N4.CityName_01 + "',");
                          WT("'" + n.N4.PostalCode_03 + "',");
                          WT("'" + n.N3.First().AddressInformation_01 + "',");
                          WT(string.IsNullOrEmpty(n.N3.First().AddressInformation_02) ? "null," : 
                              "'" + n.N3.First().AddressInformation_02 + "',");
                          WT("null,");
                          WT("'" + n.N1.Name_02 + "'),", true);
                          
                         
                      }
                  return;*/

                foreach (var file1 in Directory.EnumerateFiles(root, "*880___111.edi"))
                {

                    // using (EdifactReader reader = new EdifactReader(new FileStream(Path.Combine(root, file), FileMode.Open),
                    using (X12Reader reader = new X12Reader(new FileStream(Path.Combine(root, file1), FileMode.Open),
                        mc =>
                        {
                            // return Assembly.GetAssembly(typeof(EdiFabric.Templates.EdifactD96A.ADR));
                            return Assembly.GetAssembly(typeof(EdiFabric.Templates.X12005010.AAA));
                        }))
                    {
                        var ediItems = reader.ReadToEnd().ToList();

                        if (ediItems.Any(i => i is EdiFabric.Core.Model.Edi.ErrorContexts.ReaderErrorContext))
                        {
                            Console.WriteLine(file1 + " " + ediItems.First(i =>
                                                  i is EdiFabric.Core.Model.Edi.ErrorContexts.ReaderErrorContext));
                        }

                        WT("PO#");
                        WT("date purchased");
                        WT("additional dates");
                        WT("monetary amount");
                        WT("store");
                        WT("line#");
                        WT("item#");
                        WT("upc");
                        WT("model");
                        WT("color");
                        WT("upc");
                        WT("Qty");
                        WT("UnitPrice");
                        WT("other", true);

                        foreach (var ediItem in ediItems.Where(i => i is EdiFabric.Templates.X12005010.TS850))
                        {
                            var po = (EdiFabric.Templates.X12005010.TS850) ediItem;

                            var storeDict = new Dictionary<string, List<(PO1 PO1, string qty)>>();
                            foreach (var line in po.PO1Loop)
                            {

                                foreach (var sdq in line.SDQ)
                                {
                                    //WL("IdentificationCodeQualifier_02", sdq.IdentificationCodeQualifier_02);
                                    WL1(MapLocation(ids, sdq.IdentificationCode_03), line.PO1, sdq.Quantity_04,
                                        storeDict);
                                    WL1(MapLocation(ids, sdq.IdentificationCode_05), line.PO1, sdq.Quantity_06,
                                        storeDict);
                                    WL1(MapLocation(ids, sdq.IdentificationCode_07), line.PO1, sdq.Quantity_08,
                                        storeDict);
                                    WL1(MapLocation(ids, sdq.IdentificationCode_09), line.PO1, sdq.Quantity_10,
                                        storeDict);
                                    WL1(MapLocation(ids, sdq.IdentificationCode_11), line.PO1, sdq.Quantity_12,
                                        storeDict);
                                    WL1(MapLocation(ids, sdq.IdentificationCode_13), line.PO1, sdq.Quantity_14,
                                        storeDict);
                                    WL1(MapLocation(ids, sdq.IdentificationCode_15), line.PO1, sdq.Quantity_16,
                                        storeDict);
                                    WL1(MapLocation(ids, sdq.IdentificationCode_17), line.PO1, sdq.Quantity_18,
                                        storeDict);
                                    WL1(MapLocation(ids, sdq.IdentificationCode_19), line.PO1, sdq.Quantity_20,
                                        storeDict);
                                    WL1(MapLocation(ids, sdq.IdentificationCode_21), line.PO1, sdq.Quantity_22,
                                        storeDict);
                                }


                            }


                            foreach (var store in storeDict)
                            {


                                foreach (var line in store.Value)
                                {
                                    WT(po.BEG.PurchaseOrderNumber_03);
                                    WT(po.BEG.Date_05);
                                    WT(string.Join("; ",
                                        po.DTM.Select(d =>
                                            ParseDateType(d.DateTimeQualifier_01) + " " + d.Date_02 + " " +
                                            d.Time_03)));
                                    WT(po.CTTLoop.AMT.MonetaryAmount_02);
                                    WT(store.Key);
                                    WT(line.PO1.AssignedIdentification_01);
                                    WT(line.PO1.ProductServiceID_07);
                                    WT("'" + line.PO1.ProductServiceID_09);
                                    WT(line.PO1.ProductServiceID_11);
                                    WT(line.PO1.ProductServiceID_13);
                                    WT("'" + line.PO1.ProductServiceID_23);
                                    WT(line.qty);
                                    WT(line.PO1.UnitPrice_04);
                                    WT(string.Join(";", po.REF.Select(r =>
                                        MapRef(r.ReferenceIdentificationQualifier_01) + " = " +
                                        r.ReferenceIdentification_02
                                    )), true);
                                }

                            }


                            /*    foreach (var n1 in po.N1Loop)
                                {
                                    WL("EntityIdentifierCode_01", n1.N1.EntityIdentifierCode_01);
                                    WL("Name_02", n1.N1.Name_02);
                                }*/




                        }


                    }

                }
            }

            #endregion

        }

        static string ParseDateType(string type)
        {
            switch (type)
            {
                case "001": return "Cancel after";
                case "002": return "Effective";
                case "007": return "Requested ship";
                case "010": return "Requested ship";
                case "037": return "Ship not before";
                case "038": return "Ship no later";
                case "063": return "Do not deliver after";
                case "704": return "Delivery Appointment Date and Time";
                default: return type;
            }
        }

        static string MapLocation(Dictionary<string, Loop_N1_816_2> locations, string id)
        {
            if (id == null) return null;
            return id + (locations.TryGetValue(id, out var l)
                       ? " " +
                         (
                             l.N1.Name_02 + (l.N3 != null
                                              ? " " +
                                                string.Join(",",
                                                    l.N3.Select(n3 =>
                                                        n3.AddressInformation_01 + " " + n3.AddressInformation_02))
                                              : "")
                                          + " " +
                                          l.N4.CityName_01 + " " + l.N4.CountryCode_04 + " " + l.N4.PostalCode_03)
                       : "");
        }

        static string MapRef(string r)
        {
            switch (r)
            {
                case "DP": return "department number";
                case "IA": return "internal vendor number";
                case "MR": return "merchandise type code";
                case "PD": return "promotion/deal number";
                default: return r;
            }
        }

        static void WL1(string name, PO1 line, string qty, Dictionary<string, List<(PO1 PO1, string qty)>> dict)
        {
            if (string.IsNullOrEmpty(name)) return;
            
            if(!dict.ContainsKey(name))
                dict.Add(name, new List<(PO1, string)>());
            dict[name].Add((line, qty));
        }

        static void WT(string value, bool endLine = false)
        {
        }
    }

    public class FieldWriter : IDisposable
    {

        private StreamWriter _writer;

        public FieldWriter(StreamWriter writer)
        {
            _writer = writer;
        }

        public void WT(string value, bool endLine = false)
        {
            if (!endLine)
                _writer.Write((value ?? "") + "\t");
            else
                _writer.WriteLine(value ?? "");
        }

        public void WL(string name, string value)
        {
            if (string.IsNullOrEmpty(name)) return;
            // Console.WriteLine(name + "\t" + value);
            _writer.WriteLine(name + "\t" + value);
        }

        public void Dispose()
        {
            _writer.Dispose();
        }
    }

}