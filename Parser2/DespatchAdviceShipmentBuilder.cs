using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Templates.EdifactD97A;

namespace Parser2
{
    public static class DespatchAdviceShipmentBuilder
    {


        public static async Task<TSDESADV> BuildDespatchAdvice(string controlNumber, TSORDERS ord, IEnumerable<string> serialNumbers)
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

            result.BGM = new BGM
            {
                DOCUMENTMESSAGENAME_01 = new C002 {Documentmessagenamecoded_01 = "630"},
                DOCUMENTMESSAGEIDENTIFICATION_02 = new C106
                {
                    Documentmessagenumber_01 = RandomStringGenerator.RandomString(10)
                },//BOL here
                Messagefunctioncoded_03 = "8"
            };

            result.DTM = new List<DTM>
            {
                new DTM
                {
                    DATETIMEPERIOD_01 = new C507
                    {
                        Datetimeperiodqualifier_01 = "111",
                        Datetimeperiod_02 = DateTime.UtcNow.ToString("yyMMddHHmmss"),
                        Datetimeperiodformatqualifier_03 = "202"
                    }
                }
            };

            var orderMaterialNumbers = ord.LINLoop.Select(
                    ln => ln.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01
                )
                .Distinct()
                .ToArray();

            var loc = ord.FTX?.FirstOrDefault()?.TEXTLITERAL_04?.Freetext_01?.Split(';');
            var plant = (loc != null && loc.Length >= 2) ? loc[1] : null;
            var location = (loc != null && loc.Length >= 2) ? loc[0] : null;

            var materials = await LenovoApi.LenovoCatalogClient.GetLenovoMaterials(
                orderMaterialNumbers,
                plant);

            if (materials.Count != orderMaterialNumbers.Length)
            {
                throw new Exception("Materials not found");
            }

            var weight = ord.LINLoop.Sum(ln =>
            {
                var material = materials[ln.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01];
                var qty = ln.QTY.Sum(q => Convert.ToInt32(q.QUANTITYDETAILS_01.Quantity_02));
                return material.material.grossWeight * qty;
            });

            materials.Sum(m => m.Value.material.grossWeight);
            var weightUnit = materials
                .Select(m => m.Value.material.weightUnit)
                .Distinct()
                .ToArray();
            if (weightUnit.Length > 1)
            {
                throw new Exception("Different weight unit");
            }

            var volume = ord.LINLoop.Sum(ln =>
            {
                var material = materials[ln.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01];
                var qty = ln.QTY.Sum(q => Convert.ToInt32(q.QUANTITYDETAILS_01.Quantity_02));
                return material.material.volume * qty;
            });

            var volumeUnit = materials
                .Select(m => m.Value.material.volumeUnit)
                .Distinct()
                .ToArray();
            if (volumeUnit.Length > 1)
            {
                throw new Exception("Different volume unit");
            }

            result.MEA = new List<MEA>
            {
                new MEA
                {
                    Measurementpurposequalifier_01 = "AAI",
                    MEASUREMENTDETAILS_02 = new C502
                    {
                        Propertymeasuredcoded_01 = "AAD"
                    },
                    VALUERANGE_03 = new C174
                    {
                        Measurementvalue_02 = weight.ToString(),
                        Measureunitqualifier_01 = weightUnit[0]
                    }
                },
                new MEA
                {
                    Measurementpurposequalifier_01 = "VOL",
                    MEASUREMENTDETAILS_02 = new C502
                    {
                        Propertymeasuredcoded_01 = "AAW"
                    },
                    VALUERANGE_03 = new C174
                    {
                        Measurementvalue_02 = volume.ToString(),
                        Measureunitqualifier_01 = volumeUnit[0]
                    }
                }
            };

            result.RFFLoop = new List<Loop_RFF_DESADV>
            {
                new Loop_RFF_DESADV
                {
                    RFF = new RFF
                    {
                        REFERENCE_01 = new C506
                        {
                            Referencequalifier_01 = "SI",
                            Referencenumber_02 = "CMV" + RandomStringGenerator.RandomString(7)
                        }
                    }
                },
                new Loop_RFF_DESADV
                {
                    RFF = new RFF
                    {
                        REFERENCE_01 = new C506
                        {
                            Referencequalifier_01 = "AAQ",
                            Referencenumber_02 = "TRL" + RandomStringGenerator.RandomString(7)
                        }
                    }
                },
                new Loop_RFF_DESADV
                {
                    RFF = new RFF
                    {
                        REFERENCE_01 = new C506
                        {
                            Referencequalifier_01 = "ZZZ",
                            Referencenumber_02 = "1"
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
                        Hierarchicalidnumber_01 = "1"
                    },
                    PACLoop = new List<Loop_PAC_DESADV>
                    {
                        new Loop_PAC_DESADV
                        {
                            PAC = new PAC
                            {
                                Numberofpackages_01 = "1"
                            },
                            MEA = new List<MEA>
                            {
                                new MEA
                                {
                                    Measurementpurposequalifier_01 = "AAI",
                                    MEASUREMENTDETAILS_02 = new C502
                                    {
                                        Propertymeasuredcoded_01 = "AAD"
                                    },
                                    VALUERANGE_03 = new C174
                                    {
                                        Measurementvalue_02 = weight.ToString(),
                                        Measureunitqualifier_01 = weightUnit[0]
                                    }
                                },
                                new MEA
                                {
                                    Measurementpurposequalifier_01 = "VOL",
                                    MEASUREMENTDETAILS_02 = new C502
                                    {
                                        Propertymeasuredcoded_01 = "AAW"
                                    },
                                    VALUERANGE_03 = new C174
                                    {
                                        Measurementvalue_02 = volume.ToString(),
                                        Measureunitqualifier_01 = volumeUnit[0]
                                    }
                                }
                            },
                            PCILoop = new List<Loop_PCI_DESADV>
                            {
                                new Loop_PCI_DESADV
                                {
                                    PCI = new PCI
                                    {
                                        Markinginstructionscoded_01 = "ZZZ"
                                    },
                                    RFF = new RFF
                                        {
                                            REFERENCE_01 = new C506
                                            {
                                                Referencequalifier_01 = "ACH",
                                                Referencenumber_02 = RandomStringGenerator.RandomString(15)
                                            }
                                    }
                                }
                            }
                        }
                    },
                    LINLoop = ord.LINLoop.Select(ln =>
                    {
                        return new Loop_LIN_DESADV
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
                                    Quantityqualifier_01 = "12",
                                    Quantity_02 = q.QUANTITYDETAILS_01.Quantity_02
                                }
                            }).ToList(),
                            ALI = new List<ALI>
                            {
                                new ALI {Countryoforigincoded_01 = "US"}
                            },

                            RFFLoop = new List<Loop_RFF_DESADV_2>
                            {
                                new Loop_RFF_DESADV_2
                                {
                                    RFF = new RFF
                                    {
                                        REFERENCE_01 = new C506
                                        {
                                            Referencequalifier_01 = "AAJ",
                                            Referencenumber_02 = ord.RFFLoop.FirstOrDefault(r =>
                                                    r.RFF.REFERENCE_01.Referencequalifier_01 == "AAJ")?.RFF.REFERENCE_01
                                                .Referencenumber_02
                                        }
                                    }
                                },
                                new Loop_RFF_DESADV_2
                                {
                                    RFF = new RFF
                                    {
                                        REFERENCE_01 = new C506
                                        {
                                            Referencequalifier_01 = "ZZZ",
                                            Referencenumber_02 = ord.UNH.MessageReferenceNumber_01
                                        }
                                    }
                                }
                            },
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

                        };
                    }).ToList()
                }
            };

            return result;
        }



    }

    public static class RandomStringGenerator
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }


}