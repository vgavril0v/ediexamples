using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Ack;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD97A;
using EdiParser;

namespace Parser2
{
    public class EdiFactTranslator
    {
        public static void TranslateEdiFact(string ediSourcePath, string translatedFolderPath, string fileNameFilter = null, bool withAcknowlegment = false)
        {
            var settings = new EdiFabric.Plugins.Acknowledgments.Edifact.Model.AckSettings
            {
                AckHandler = (s, a) =>
                {

                    var contrl = a.Message as EdiFabric.Core.Model.Edi.Edifact.TSCONTRL;

                    // ts997.AK1.FunctionalIdentifierCode_01 = "A";
                    /* ts997.AK9.FunctionalGroupAcknowriter.WLedgeCode_01 = "A";
                     ts997.AK9.NumberofAcceptedTransactionSets_04 = ts997.AK9.NumberofReceivedTransactionSets_03;
                     foreach (var aa in ts997.AK2Loop1)
                     {
                         aa.AK5.TransactionSetAcknowriter.WLedgmentCode_01 = "A";
                         aa.AK3Loop1 = null;
                     }*/

                    if (contrl != null && a.AckType == AckType.Functional)
                    {
                        //  Inspect the acknowriter.WLedgment
                        var ackCode = contrl.UCI.Actioncoded_04;

                        var ack = AckBuilders.BuildAck(a.InterchangeHeader, a.GroupHeader, contrl);
                        using (var file = File.CreateText(Path.Combine(translatedFolderPath, 
                            Guid.NewGuid().ToString().Replace("-", "").ToLower() + ".txt")))
                        {
                            file.Write(ack);
                        }
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
                //AckVersion = AckVersion.X12_997,
                // Turn off AK2 for valid messages to reduce size
                GenerateForValidMessages = false
            };

            foreach (var fileName in Directory.EnumerateFiles(ediSourcePath, fileNameFilter ?? "*"))
            {

                    using (var ackMan = new EdiFabric.Plugins.Acknowledgments.Edifact.AckMan(settings))
                    {
                        using (EdifactReader reader = new EdifactReader(new FileStream(fileName, FileMode.Open)))
                        {
                            var ediItems = reader.ReadToEnd().ToList();
                            Console.WriteLine(Path.GetFileName(fileName));
                            foreach (var ediItem in ediItems)
                            {
                                /*
                                 *.Where(i =>
                                !(i is EdiFabric.Core.Model.Edi.Edifact.UNB) &&
                                !(i is EdiFabric.Core.Model.Edi.Edifact.UNG) &&
                                !(i is EdiFabric.Core.Model.Edi.Edifact.UNE) &&
                                !(i is EdiFabric.Core.Model.Edi.Edifact.UNZ)
                            )
                                 */
                                if(withAcknowlegment)
                                    ackMan.Publish(ediItem);

                                var resultFileName = Path.Combine(translatedFolderPath,
                                    Path.GetFileNameWithoutExtension(fileName) + ".txt");
                                if (ediItem is TSDESADV)
                                {
                                    var asn = (TSDESADV)ediItem;
                                    using (var writer = new FieldWriter(File.CreateText(resultFileName)))
                                    {
                                        WriteLenovoAsn(asn, writer);
                                    }
                                }

                                if (ediItem is TSORDERS)
                                {
                                    var order = (TSORDERS)ediItem;
                                    using (var writer = new FieldWriter(File.CreateText(resultFileName)))
                                    {
                                        WriteLenovoOrder(order, writer);
                                    }
                                }
                            }
                        }
                    }

                
            }


        }

        private static Dictionary<string, string> MapLenovoDate = new Dictionary<string, string>
        {
            { "137", "document date"},
            { "4", "Lenovo Delivery creation date"},
            { "132", "Arrival date, estimated"},
            { "2", "Customer Requested Delivery date"},
        };

        private static void WriteLenovoOrder(TSORDERS order, FieldWriter writer)
        {
            writer.WL("MessageReferenceNumber_01", order.UNH.MessageReferenceNumber_01);
            foreach (var dtm in order.DTM)
            {
                writer.WL(MapLenovoDate.TryGetValue(dtm.DATETIMEPERIOD_01.Datetimeperiodqualifier_01, out var d) ? d :
                        dtm.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 + " search here http://www.stylusstudio.com/edifact/D97A/2380.htm"
                    , dtm.DATETIMEPERIOD_01.Datetimeperiod_02);

            }

            writer.WL(" ", "");
            if (order.FTX != null)
            {
                foreach (var ftx in order.FTX)
                {
                    writer.WL("delivery instruction", ftx.TEXTLITERAL_04.Freetext_01);
                }
            }
            writer.WL(" ", "");
            foreach (var rff in order.RFFLoop)
            {
                writer.WL(
                    MapLenovoRff.TryGetValue(rff.RFF.REFERENCE_01.Referencequalifier_01, out var rffn) ? rffn :
                        rff.RFF.REFERENCE_01.Referencequalifier_01 + " search here http://www.stylusstudio.com/edifact/D97A/1153.htm"
                    , rff.RFF.REFERENCE_01.Referencenumber_02);
            }
            writer.WL(" ", "");

            foreach (var nad in order.NADLoop)
            {
                writer.WL(MapLenovoParty.TryGetValue(nad.NAD.Partyqualifier_01, out var d) ? d :
                        nad.NAD.Partyqualifier_01 + " search here http://www.stylusstudio.com/edifact/D97A/2380.htm"
                    , nad.NAD.PARTYIDENTIFICATIONDETAILS_02?.Partyididentification_01);

                writer.WL("Nameandaddressline_01", nad.NAD.NAMEANDADDRESS_03?.Nameandaddressline_01);
                writer.WL("Nameandaddressline_02", nad.NAD.NAMEANDADDRESS_03?.Nameandaddressline_02);
                writer.WL("Nameandaddressline_03", nad.NAD.NAMEANDADDRESS_03?.Nameandaddressline_03);

                writer.WL("Streetandnumberpobox_01", nad.NAD.STREET_05?.Streetandnumberpobox_01);
                writer.WL("Streetandnumberpobox_02", nad.NAD.STREET_05?.Streetandnumberpobox_02);
                writer.WL("Streetandnumberpobox_03", nad.NAD.STREET_05?.Streetandnumberpobox_03);

                writer.WL("Cityname_06", nad.NAD.Cityname_06);
                writer.WL("Postcodeidentification_08", nad.NAD.Postcodeidentification_08);
                writer.WL("Countrycoded_09", nad.NAD.Countrycoded_09);
                writer.WL(" ", "");
            }

            foreach (var tdt in order.TDTLoop)
            {
                writer.WL("Carrieridentification_01", tdt.TDT.CARRIER_05?.Carrieridentification_01);
                writer.WL("Carriername_04", tdt.TDT.CARRIER_05?.Carriername_04);
                writer.WL("Idofmeansoftransportidentification_01", tdt.TDT.TRANSPORTIDENTIFICATION_08?.Idofmeansoftransportidentification_01);
            }

            writer.WL("------ lines -----", "");
            foreach (var lin in order.LINLoop)
            {
                writer.WL("Lineitemnumber_01", lin.LIN.Lineitemnumber_01);
                writer.WL("item type", lin.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01);
                foreach (var qty in lin.QTY)
                {
                    writer.WL("despatch quantity", qty.QUANTITYDETAILS_01.Quantity_02);
                }

                foreach (var loc in lin.LOCLoop)
                {
                    writer.WL("Storage Location", loc.LOC.LOCATIONIDENTIFICATION_02.Placelocation_04);
                }

                if (lin.GIN != null)
                {
                    foreach (var gin in lin.GIN)
                    {
                        writer.WL("serial number", gin.IDENTITYNUMBERRANGE_02.Identitynumber_01);
                    }
                }

                if (lin.GIR != null)
                {
                    foreach (var gir in lin.GIR)
                    {
                        writer.WL("package", gir.IDENTIFICATIONNUMBER_02.Identitynumber_01);
                    }
                }
                writer.WL(" ", "");
            }
        }

        private static void WriteLenovoAsn(TSDESADV asn, FieldWriter writer)
        {
            writer.WL("MessageReferenceNumber_01", asn.UNH.MessageReferenceNumber_01);
            foreach (var dtm in asn.DTM)
            {
                writer.WL(MapLenovoDate.TryGetValue(dtm.DATETIMEPERIOD_01.Datetimeperiodqualifier_01, out var d) ? d :
                        dtm.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 + " search here http://www.stylusstudio.com/edifact/D97A/2380.htm"
                    , dtm.DATETIMEPERIOD_01.Datetimeperiod_02);

            }
            foreach (var rff in asn.RFFLoop)
            {
                writer.WL(
                    MapLenovoRff.TryGetValue(rff.RFF.REFERENCE_01.Referencequalifier_01, out var rffn) ? rffn :
                        rff.RFF.REFERENCE_01.Referencequalifier_01 + " search here http://www.stylusstudio.com/edifact/D97A/1153.htm"
                    , rff.RFF.REFERENCE_01.Referencenumber_02);
            }

            foreach (var nad in asn.NADLoop)
            {
                writer.WL(MapLenovoParty.TryGetValue(nad.NAD.Partyqualifier_01, out var d) ? d :
                        nad.NAD.Partyqualifier_01 + " search here http://www.stylusstudio.com/edifact/D97A/2380.htm"
                    , nad.NAD.PARTYNAME_04.Partyname_01);

            }

            foreach (var csp in asn.CPSLoop)
            {
                foreach (var pac in csp.PACLoop)
                {
                    foreach (var pci in pac.PCILoop)
                    {
                        writer.WL("MARKS & LABELS", pci.PCI.MARKSLABELS_02.Shippingmarks_01);
                    }
                }

                writer.WL("------ lines -----", "");
                foreach (var lin in csp.LINLoop)
                {
                    writer.WL("Lineitemnumber_01", lin.LIN.Lineitemnumber_01);
                    writer.WL("item type", lin.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01);
                    foreach (var qty in lin.QTY)
                    {
                        writer.WL("despatch quantity", qty.QUANTITYDETAILS_01.Quantity_02);
                    }

                    foreach (var loc in lin.LOCLoop)
                    {
                        writer.WL("LOCATION IDENTIFICATION/place location", loc.LOC.LOCATIONIDENTIFICATION_02.Placelocation_04);
                    }

                    foreach (var pci in lin.PCILoop)
                    {
                        if (pci.PCI.MARKSLABELS_02 != null)
                            writer.WL("MARKS & LABELS", pci.PCI.MARKSLABELS_02.Shippingmarks_01);
                    }
                }
            }



        }

        private static Dictionary<string, string> MapLenovoRff = new Dictionary<string, string>
        {
            { "FC", "Fiscal number"},
            { "ON", "Order number"},
            { "ABO", "Originator's reference"},
            { "AAJ", "Delivery order number"},
            { "ZZZ", "RMA number"},
            { "CO", "Buyers order number"},
            { "AOB", "Direct delivery indicator"},
            { "PP", "Purchase order change number. Reference number assigned by a buyer for a revision of a purchase order."}
        };

        private static Dictionary<string, string> MapLenovoParty = new Dictionary<string, string>
        {
            { "SU", "Supplier"},
            { "SF", "Ship from"},
            { "SO", "Sold to"},
            { "ST", "Ship to party"},
        };
    }
}