using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Templates.EdifactD97A;

namespace Parser2
{
    public static class DespatchAdviceGRBuilder
    {
        public static string LoadToString(this Stream stream)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        public static TSDESADV BuildDespatchAdvice(string controlNumber, TSORDERS adv, IEnumerable<string> serialNumbers)
        {
            var serialNumberQueue = new Queue<string>(serialNumbers);

            var result = new TSDESADV();

            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "DESADV";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "97A";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentmessagenamecoded_01 = "631";
            result.BGM.Messagefunctioncoded_03 = "6";

            result.RFFLoop = new List<Loop_RFF_DESADV>
            {
                new Loop_RFF_DESADV
                {
                    RFF = new RFF
                    {
                        REFERENCE_01 = new C506
                        {
                            Referencequalifier_01 = "ALQ",
                            Referencenumber_02 = adv.RFFLoop
                                .First(r => r.RFF.REFERENCE_01.Referencequalifier_01 == "AAJ")
                                .RFF.REFERENCE_01.Referencenumber_02
                        }
                    },
                    DTM = new DTM
                    {
                        DATETIMEPERIOD_01 = new C507
                        {
                            Datetimeperiodqualifier_01 = "3",
                            Datetimeperiod_02 = DateTime.Now.Date.ToString("yyyyMMdd")
                        }
                    }
                },

            };

            var loc = adv.FTX?.FirstOrDefault()?.TEXTLITERAL_04?.Freetext_01?.Split(';');
            var plant = (loc != null && loc.Length >= 2) ? loc[1] : null;
            var location = (loc != null && loc.Length >= 2) ? loc[0] : null;

            result.NADLoop = new List<Loop_NAD_DESADV>
            {
                new Loop_NAD_DESADV
                {
                    NAD = new NAD
                    {
                        Partyqualifier_01 = "WH",
                        PARTYIDENTIFICATIONDETAILS_02 = new C082
                        {
                            Partyididentification_01 = "recon group" //TODO: what is a correct one?
                        }
                    },
                    LOC = new List<LOC>
                    {
                        new LOC
                        {
                            Placelocationqualifier_01 = "4",
                            LOCATIONIDENTIFICATION_02 = new C517
                            {
                                Placelocation_04 = plant,
                                Placelocationidentification_01 = location
                            }
                        }
                    }

                }
            };


            result.CPSLoop = new List<Loop_CPS_DESADV>
            {

                new Loop_CPS_DESADV
                {
                    CPS = new CPS
                    {
                        Hierarchicalidnumber_01 = "1",
                        //  Packaginglevelcoded_03 = "1"
                    },
                    LINLoop = adv.LINLoop.Select(ln =>

                        new Loop_LIN_DESADV
                        {
                            LIN = new LIN
                            {
                                Lineitemnumber_01 = ln.LIN.Lineitemnumber_01,
                                ITEMNUMBERIDENTIFICATION_03 = new C212
                                {
                                    Itemnumber_01 = ln.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01,
                                    Itemnumbertypecoded_02 = "VN"
                                }
                            },
                            QTY = ln.QTY.Select(q => new QTY
                            {
                                QUANTITYDETAILS_01 = new C186
                                {
                                    Quantityqualifier_01 = "21",
                                    Quantity_02 = q.QUANTITYDETAILS_01.Quantity_02,
                                    Measureunitqualifier_03 = "12"
                                }
                            }).ToList(),
                            ALI = new List<ALI>
                            {
                                new ALI {Countryoforigincoded_01 = "US"}
                            },
                            GIN = new List<GIN>
                            {
                                new GIN
                                {
                                    Identitynumberqualifier_01 = "ML",
                                    IDENTITYNUMBERRANGE_02 = new C208
                                    {
                                        Identitynumber_01 = "DUMMYPALLETID"
                                    }
                                },
                            },
                          /*  LOCLoop = ln.LOCLoop?.Select(lc => new Loop_LOC_DESADV_2
                            {
                                LOC = new LOC
                                {
                                    Placelocationqualifier_01 = "4",
                                    LOCATIONIDENTIFICATION_02 = new C517
                                    {
                                        Placelocation_04 = plant,
                                        Placelocationidentification_01 =
                                            string.IsNullOrEmpty(lc.LOC?.LOCATIONIDENTIFICATION_02?.Placelocation_04)
                                                ? location
                                                : lc.LOC.LOCATIONIDENTIFICATION_02.Placelocation_04
                                    }
                                }
                            }).ToList(),*/
                            PCILoop = Enumerable.Range(1,
                                ln.QTY.Sum(q => Convert.ToInt32(
                                    q.QUANTITYDETAILS_01.Quantity_02))
                            ).Select(i => new Loop_PCI_DESADV_2
                            {
                                PCI = new PCI
                                {
                                    Markinginstructionscoded_01 = "ZZZ",
                                    MARKSLABELS_02 = new C210
                                    {
                                        Shippingmarks_01 = serialNumberQueue.Dequeue()
                                    }
                                }
                            }).ToList()
                        }

                    ).ToList()
                }
            };

            return result;
        }

        public static TSDESADV BuildDespatchAdvice(string controlNumber, TSDESADV adv)
        {
            var result = new TSDESADV();

            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "DESADV";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "97A";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentmessagenamecoded_01 = "631";
            result.BGM.Messagefunctioncoded_03 = "6";

            result.RFFLoop = new List<Loop_RFF_DESADV>
            {
                new Loop_RFF_DESADV
                {
                    RFF = new RFF
                    {
                        REFERENCE_01 = new C506
                        {
                            Referencequalifier_01 = "ON",
                            Referencenumber_02 = adv.RFFLoop
                                .First(r => r.RFF.REFERENCE_01.Referencequalifier_01 == "ON")
                                .RFF.REFERENCE_01.Referencenumber_02
                        }
                    },
                    DTM = new DTM
                    {
                        DATETIMEPERIOD_01 = new C507
                        {
                            Datetimeperiodqualifier_01 = "3",
                            Datetimeperiod_02 = DateTime.Now.Date.ToString("yyyyMMdd")
                        }
                    }
                },
                /*new Loop_RFF_DESADV
                {
                    RFF = new RFF
                    {
                        REFERENCE_01 = new C506
                        {
                            Referencequalifier_01 = "ALQ",
                            Referencenumber_02 = "7514553241"
                        }
                    }
                },*/ //TODO where is "ALQ" Return Delivery number

                /*new Loop_RFF_DESADV
                {
                    RFF = new RFF
                    {
                        REFERENCE_01 = new C506
                        {
                            Referencequalifier_01 = "AMU",
                            Referencenumber_02 = "7514553241"
                        }
                    }
                }*/ //TODO where is 'AMU'  Integrated logistic support cross reference number


            };

            var loc = adv.CPSLoop.FirstOrDefault()?
                .LINLoop.FirstOrDefault()?
                .LOCLoop.FirstOrDefault()?.LOC?.LOCATIONIDENTIFICATION_02
                ?.Placelocation_04?.Split(' ');
            var plant = loc != null && loc.Length > 0 ? loc[0] : null;
            var location = loc != null && loc.Length > 1 ? loc[1] : null;

            result.NADLoop = new List<Loop_NAD_DESADV>
            {
                new Loop_NAD_DESADV
                {
                    NAD = new NAD
                    {
                        Partyqualifier_01 = "WH",
                        PARTYIDENTIFICATIONDETAILS_02 = new C082
                        {
                            Partyididentification_01 = "recon group" //TODO: what is a correct one?
                        }
                    },
                    LOC = new List<LOC>
                    {
                        new LOC
                        {
                            Placelocationqualifier_01 = "4",
                            LOCATIONIDENTIFICATION_02 = plant == null
                                ? null
                                : new C517
                                {
                                    Placelocation_04 = plant,
                                    Placelocationidentification_01 = location ?? "CA01" // TODO Warning, should be mapped from condition
                                }
                        }
                    }

                }
            };


            result.CPSLoop = adv.CPSLoop.Select(
                cps => new Loop_CPS_DESADV
                {
                    CPS = new CPS
                    {
                        Hierarchicalidnumber_01 = "1",
                        //  Packaginglevelcoded_03 = "1"
                    },
                    LINLoop = cps.LINLoop.Select(ln =>

                        new Loop_LIN_DESADV
                        {
                            LIN = new LIN
                            {
                                Lineitemnumber_01 = ln.LIN.Lineitemnumber_01,
                                ITEMNUMBERIDENTIFICATION_03 = new C212
                                {
                                    Itemnumber_01 = ln.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01,
                                    Itemnumbertypecoded_02 = "VN"
                                }
                            },
                            QTY = ln.QTY.Select(q => new QTY
                            {
                                QUANTITYDETAILS_01 = new C186
                                {
                                    Quantityqualifier_01 = "21",
                                    Quantity_02 = q.QUANTITYDETAILS_01.Quantity_02,
                                    Measureunitqualifier_03 = "12"
                                }
                            }).ToList(),
                            ALI = new List<ALI>
                            {
                                new ALI {Countryoforigincoded_01 = "US"}
                            },
                            GIN = new List<GIN>
                            {
                                new GIN
                                {
                                    Identitynumberqualifier_01 = "ML",
                                    IDENTITYNUMBERRANGE_02 = new C208
                                    {
                                        Identitynumber_01 = "DUMMYPALLETID"
                                    }
                                },
                            },
                           /* LOCLoop = ln.LOCLoop?.Select(lc => new Loop_LOC_DESADV_2
                            {
                                LOC = new LOC
                                {
                                    LOCATIONIDENTIFICATION_02 = new C517
                                    {
                                        Placelocation_04 = lc.LOC.LOCATIONIDENTIFICATION_02.Placelocation_04
                                    }
                                }
                            }).ToList(),*/
                            PCILoop = ln.PCILoop
                                .Where(pci => pci.PCI?.MARKSLABELS_02 != null)
                                .Select(pci => new Loop_PCI_DESADV_2
                                {
                                    PCI = new PCI
                                    {
                                        Markinginstructionscoded_01 = "ZZZ",
                                        MARKSLABELS_02 = new C210
                                        {
                                            Shippingmarks_01 = pci.PCI.MARKSLABELS_02.Shippingmarks_01
                                        }
                                    }
                                }).ToList()
                        }

                    ).ToList()
                }

            ).ToList();

            return result;
        }
    }
}