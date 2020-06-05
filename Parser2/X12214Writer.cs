using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12004050;

namespace Parser2
{
    public static  class X12214Writer
    {

        public static void Write214(string path)
        {
            using (X12Writer writer = new X12Writer(path, false, new X12WriterSettings()))
            {
                writer.Write(BuildIsa("856100001"));
                writer.Write(BuildGs("856100001"));
                writer.Write(BuildShipmentStatus("100001"));
            }
        }

        private static ISA BuildIsa(string controlNumber,
   string senderId = "RECONGROUP",
   string senderQ = "ZZ",
   string receiverId = "6135830003R",
   string receiverQ = "08",
   string ackRequested = "1",
   string testIndicator = "Y")
        {
            return new ISA
            {
                //  Authorization Information Qualifier
                AuthorizationInformationQualifier_1 = "00",
                //  Authorization Information
                AuthorizationInformation_2 = "".PadRight(10),
                //  Security Information Qualifier
                SecurityInformationQualifier_3 = "00",
                //  Security Information
                SecurityInformation_4 = "".PadRight(10),
                //  Interchange ID Qualifier
                SenderIDQualifier_5 = senderQ,
                //  Interchange Sender
                InterchangeSenderID_6 = senderId.PadRight(15),
                //  Interchange ID Qualifier
                ReceiverIDQualifier_7 = receiverQ,
                //  Interchange Receiver
                InterchangeReceiverID_8 = receiverId.PadRight(15),
                //  Date
                InterchangeDate_9 = DateTime.Now.Date.ToString("yyMMdd"),
                //  Time
                InterchangeTime_10 = DateTime.Now.TimeOfDay.ToString("hhmm"),
                //  Standard identifier
                InterchangeControlStandardsIdentifier_11 = "U",
                //  Interchange Version ID
                //  This is the ISA version and not the transaction sets versions
                InterchangeControlVersionNumber_12 = "00406",
                //  Interchange Control Number
                InterchangeControlNumber_13 = controlNumber.PadLeft(9, '0'),
                //  Acknowledgment Requested (0 or 1)
                AcknowledgementRequested_14 = ackRequested,
                //  Test Indicator
                UsageIndicator_15 = testIndicator,
            };
        }

        public static GS BuildGs(string controlNumber,
            string senderId = "RECONGROUP",
            string receiverId = "6135830003R")
        {
            return new GS
            {
                //  Functional ID Code
                CodeIdentifyingInformationType_1 = "QM",
                //  Application Senders Code
                SenderIDCode_2 = senderId,
                //  Application Receivers Code
                ReceiverIDCode_3 = receiverId,
                //  Date
                Date_4 = DateTime.Now.Date.ToString("yyMMdd"),
                //  Time
                Time_5 = DateTime.Now.TimeOfDay.ToString("hhmm"),
                //  Group Control Number
                //  Must be unique to both partners for this interchange
                GroupControlNumber_6 = controlNumber.PadLeft(9, '0'),
                //  Responsible Agency Code
                TransactionTypeCode_7 = "X",
                //  Version/Release/Industry id code
                VersionAndRelease_8 = "004060"
            };
        }

        /// <summary>
        /// Builds Shipment Status.
        /// </summary>
        public static TS214 BuildShipmentStatus(string controlNumber)
        {
           
            var result = new TS214();;

            //  Start Transaction Set 214
            //  Control number = 0006
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "214";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  Reference Number = 123456
            //  Carrier SCAC = BAWC
            //  Route Code = ROUTE1
            result.B10 = new B10();
            result.B10.ReferenceIdentification_01 = "3717776";
            result.B10.StandardCarrierAlphaCode_03 = "GTRG";
            result.B10.ShipmentIdentificationNumber_02 = "3717776";
            // result.B10.ReferenceIdentificationQualifier_05 = "RU";
            // result.B10.ReferenceIdentification_06 = "3717776";

            result.LXLoop = new List<Loop_LX_214>();

         

            result.LXLoop.Add(new Loop_LX_214
            {
                LX = new LX
                {
                    AssignedNumber_01 = "0"
                },
                L11 = new List<L11>
                {
                    new L11
                    {
                        ReferenceIdentification_01 = "OOCL BRUSSELS",
                        ReferenceIdentificationQualifier_02 = "WU"
                    },
                    new L11
                    {
                        ReferenceIdentification_01 = "039E",
                        ReferenceIdentificationQualifier_02 = "V3"
                    },
                    new L11
                    {
                        ReferenceIdentification_01 = "COSU6261495330",
                        ReferenceIdentificationQualifier_02 = "BM"
                    }
                },
                AT7Loop = new List<Loop_AT7_214>
                {
                    new Loop_AT7_214
                    {
                        AT7 = new AT7
                        {
                            ShipmentStatusCode_01 = "I1",
                            Date_05 = "20200511",
                            Time_06 = "1159",
                            TimeCode_07 = "PT"
                        },
                        MS2 = new List<MS2>
                        {
                            new MS2
                            {
                                StandardCarrierAlphaCode_01 = "GTRG",
                                EquipmentNumber_02 = "CBHU6350991",
                                EquipmentDescriptionCode_03 = "CN"
                            }
                        }
                    }
                },
                N1Loop = new List<Loop_N1_214>
                {
                    new Loop_N1_214
                    {
                        N1 = new N1
                        {
                            EntityIdentifierCode_01 = "FA",
                            IdentificationCodeQualifier_03 = "94",
                            IdentificationCode_04 = "1477"
                        }
                    },
                    new Loop_N1_214
                    {
                        N1 = new N1
                        {
                            EntityIdentifierCode_01 = "ZZ",
                            IdentificationCodeQualifier_03 = "94",
                            IdentificationCode_04 = "9999"
                        }
                    }
                }
            });



            return result;
        }
    }
}