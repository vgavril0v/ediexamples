using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.X12005010;

namespace Parser2
{
    public class AsnWriter
    {

        public void WriteAsn(string path)
        {
            using (X12Writer writer = new X12Writer(path, false, new X12WriterSettings()))
            {
                writer.Write(BuildIsa("856100001"));
                writer.Write(BuildGs("856100001"));
                writer.Write(BuildShipNotice("100001"));
            }
        }

        static TS856 BuildShipNotice(string controlNumber)
        {
            var result = new TS856();

            //  856 is the Transaction Set Identifier Code for the Advance Ship Notice
            //  0001 is the Transaction Set Control Number
            result.ST = new ST();
            result.ST.TransactionSetIdentifierCode_01 = "856";
            result.ST.TransactionSetControlNumber_02 = controlNumber.PadLeft(9, '0');

            //  00 is the Transaction Set Purpose Code "00" indicates Original.
            //  01140824 is the Shipment Identification Number.
            //  20051015 is the Document Creation Date.
            //  1345 is the Time.
            //  0001 is the Hierarchical Structure. "0001" indicates "Pick and Pack Structure". 
            result.BSN = new BSN();
            result.BSN.TransactionSetPurposeCode_01 = "00";
            result.BSN.ShipmentIdentification_02 = "10286631";
            result.BSN.Date_03 = "20200404";
            result.BSN.Time_04 = "1345";
            result.BSN.HierarchicalStructureCode_05 = "0001";

            //  Repeating HL Loops
            result.HLLoop = new List<Loop_HL_856>();

            //  Begin HL Loop 1
            var hlLoop1 = new Loop_HL_856();

            //  1 is Hierarchical ID Number.
            //  S is the Hierarchical Level Code. “S” indicates "Shipment".
            //  This HL is the first HL used, and has no parent to identify.
            hlLoop1.HL = new HL();
            hlLoop1.HL.HierarchicalIDNumber_01 = "1";
            hlLoop1.HL.HierarchicalLevelCode_03 = "S";

            //  Repeating TD1
            hlLoop1.TD1 = new List<TD1>();

            //  CTN25 is Packaging Code. “CTN” indicates “Carton”, and “25” indicates “Corrugated or Solid”.
            //  2 is the Lading Quantity.
            //  G is the Weight Qualifier. “G” indicates "Gross Weight".
            //  45582 is the Weight (Gross).
            //  LB is the Unit or Basis for Measurement Code. “LB” indicates “Pound”.
            //  1000 is the Volume (Gross).
            //  CF is the Unit or Basis for Measurement Code. “CF” indicates “Cubic Feet”. 
            var td11 = new TD1();
            td11.PackagingCode_01 = "CTN25";
            td11.LadingQuantity_02 = "1";
            td11.WeightQualifier_06 = "G";
            td11.Weight_07 = "3";//??
            td11.UnitorBasisforMeasurementCode_08 = "LB";
           // td11.Volume_09 = "1000";
           // td11.UnitorBasisforMeasurementCode_10 = "CF";
            hlLoop1.TD1.Add(td11);

            //  Repeating TD5
            hlLoop1.TD5 = new List<TD5>();

            //  B is the Routing Sequence Code. “B” indicates "Origin/Delivery Carrier (Any Mode)".
            //  2 is the Identification Code Qualifier. “2” indicates “Standard Carrier Alpha Code(SCAC)”.
            //  JBHT is the Identification Code(SCAC).Indicates the carrier JB Hunt.
            //  M is the Transportation Method / Type Code. “M” indicates “Motor(Common Carrier)”. 
            var td51 = new TD5();
            td51.RoutingSequenceCode_01 = "B";
            td51.IdentificationCodeQualifier_02 = "2";
            td51.IdentificationCode_03 = "FDEG";
            td51.TransportationMethodTypeCode_04 = "M";
            hlLoop1.TD5.Add(td51);

            //  Repeating TD3
            hlLoop1.TD3Loop = new List<Loop_TD3_856>();

            //  TL is the Equipment Description Code. “TL” indicates Trailer.
            //  ABCD is the Equipment Initial
            //  07213567 is the Equipment Number
            //  30394938483234 is the Seal Number.This is a unique number on seal used to close a shipment. 
          /*  var td31 = new TD3();
            td31.EquipmentDescriptionCode_01 = "TL";
            td31.EquipmentInitial_02 = "ABCD";
            td31.EquipmentNumber_03 = "07213567";
            td31.SealNumber_09 = "30394938483234";
            hlLoop1.TD3.Add(td31);*/

            //  Repeating REF
            hlLoop1.REF = new List<REF>();

          /*  //  BM is the Reference Identification Qualifier. “BM” indicates “Bill of Lading Number”.
            //  01140824 is the Reference Identification
            var ref1 = new REF();
            ref1.ReferenceIdentificationQualifier_01 = "BM";
            ref1.ReferenceIdentification_02 = "01140824";
            hlLoop1.REF.Add(ref1);*/

            //  CN is the Reference Identification Qualifier “CN” indicates the Carrier PRO Tracking Number.
            //  082131 is the Reference Identification
            var ref2 = new REF();
            ref2.ReferenceIdentificationQualifier_01 = "CN";
            ref2.ReferenceIdentification_02 = "770156950710";
            hlLoop1.REF.Add(ref2);

           /* //  CR is the Reference Identification Qualifier “CR” indicates the Customer Reference Number(Wal - Mart Load Number).
            //  01082131 is the Reference Identification
            var ref3 = new REF();
            ref3.ReferenceIdentificationQualifier_01 = "CR";
            ref3.ReferenceIdentification_02 = "01082131";
            hlLoop1.REF.Add(ref3);*/

            //  Repeating DTM
            hlLoop1.DTM = new List<DTM>();

            //  011 is the Date/Time Qualifier “011” indicates the “Date Shipped”
            //  20051015 is the Date (Shipped)
            var dtm1 = new DTM();
            dtm1.DateTimeQualifier_01 = "011";
            dtm1.Date_02 = "20200404";
            hlLoop1.DTM.Add(dtm1);

            //  Repeating N1 Loops
            hlLoop1.N1Loop = new List<Loop_N1_856>();

            //  Begin N1 Loop 1
            var n1Loop1 = new Loop_N1_856();

            //  ST is the Entity Identifier Code. “ST” indicates “Ship To”.
            //  WAL - MART DC 6094J - JIT is the Name (Ship To).
            //  UL is the Identification Code Qualifier. “UL” indicates
            //  “Global Location Number(GLN)”.
            //  0078742035260 is the Identification Code(GLN).
            n1Loop1.N1 = new N1();
            n1Loop1.N1.EntityIdentifierCode_01 = "ST";
            n1Loop1.N1.Name_02 = "WAL-MART SUPERCENTER 5260";
            n1Loop1.N1.IdentificationCodeQualifier_03 = "UL";
            n1Loop1.N1.IdentificationCode_04 = "0078742050027";

            //  End N1 Loop 1
            hlLoop1.N1Loop.Add(n1Loop1);

            //  Begin N1 Loop 2
            var n1Loop2 = new Loop_N1_856();

            //  SF is the Entity Identifier Code (Ship From)
            //  SUPPLIER NAME is the Name. 
            n1Loop2.N1 = new N1();
            n1Loop2.N1.EntityIdentifierCode_01 = "SF";
            n1Loop2.N1.Name_02 = "RECONGROUP";

            //  End N1 Loop 2
            hlLoop1.N1Loop.Add(n1Loop2);

            //  End HL Loop 1
            result.HLLoop.Add(hlLoop1);

            //  Begin HL Loop 2
            var hlLoop2 = new Loop_HL_856();

            //  2 is the Hierarchical ID Number.
            //  1 is the Hierarchical Parent ID Number. (Shipment)
            //  O is the Hierarchical Level Code. “O” indicates “Order”
            hlLoop2.HL = new HL();
            hlLoop2.HL.HierarchicalIDNumber_01 = "2";
            hlLoop2.HL.HierarchicalParentIDNumber_02 = "1";
            hlLoop2.HL.HierarchicalLevelCode_03 = "O";

            //  9988776655 the Purchase Order Number.
            //  20051015 is the Date (Purchase Order Date). 
            hlLoop2.PRF = new PRF();
            hlLoop2.PRF.PurchaseOrderNumber_01 = "3066040668";
            hlLoop2.PRF.Date_04 = "20200310";

            //  Repeating REF
            hlLoop2.REF = new List<REF>();

            //  IA is the Reference Identification Qualifier. “IA” indicates
            //  “Internal Vendor Number”.
            //  211555050 is the Reference Identification
            var ref4 = new REF();
            ref4.ReferenceIdentificationQualifier_01 = "IA";
            ref4.ReferenceIdentification_02 = "009167870";
            hlLoop2.REF.Add(ref4);

            //  DP is the Reference Identification Qualifier. “DP” indicates
            //  “Department Number”.
            //  00005 is the Reference Identification(Wal - Mart Department
            //  Number).
            var ref5 = new REF();
            ref5.ReferenceIdentificationQualifier_01 = "DP";
            ref5.ReferenceIdentification_02 = "00087";
            hlLoop2.REF.Add(ref5);

            //  MR is the Reference Identification Qualifier. “MR” indicates
            //  “Merchandise Type Code”.
            //  0073 is the Reference Identification
            var ref6 = new REF();
            ref6.ReferenceIdentificationQualifier_01 = "MR";
            ref6.ReferenceIdentification_02 = "0007";
            hlLoop2.REF.Add(ref6);

          /*  //  IV is the Reference Identification Qualifier. “IV” indicates
            //  “Seller’s Invoice Number”.
            //  01140824 is the Reference Identification
            var ref7 = new REF();
            ref7.ReferenceIdentificationQualifier_01 = "IV";
            ref7.ReferenceIdentification_02 = "01140824";
            hlLoop2.REF.Add(ref7);*/

            //  Repeating N1 Loops
            hlLoop2.N1Loop = new List<Loop_N1_856>();

            //  Begin N1 Loop 1
            var n1Loop3 = new Loop_N1_856();

            //  BY is the Entity Identifier Code. “BY” indicates “Buying
            //  Party(Purchaser)”.
            //  WAL - MART STORES, INC. is the Name.
            //  UL is the Identification Code Qualifier. “UL” indicates
            //  “Global Location Number(GLN)”.
            //  0078742000992 is the Identification Code(GLN).
            n1Loop3.N1 = new N1();
            n1Loop3.N1.EntityIdentifierCode_01 = "BY";
            n1Loop3.N1.Name_02 = "WAL-MART SUPERCENTER 5260";
            n1Loop3.N1.IdentificationCodeQualifier_03 = "UL";
            n1Loop3.N1.IdentificationCode_04 = "0078742050027";

            //  End N1 Loop 1
            hlLoop2.N1Loop.Add(n1Loop3);

            //  End HL Loop 2
            result.HLLoop.Add(hlLoop2);

            //  Begin HL Loop 3
            var hlLoop3 = new Loop_HL_856();

            //  3 is the Hierarchical ID Number.
            //  2 is the Hierarchical Parent ID Number. (Order)
            //  P is the Hierarchical Level Code. “P” indicates “Pack”. 
            hlLoop3.HL = new HL();
            hlLoop3.HL.HierarchicalIDNumber_01 = "3";
            hlLoop3.HL.HierarchicalParentIDNumber_02 = "2";
            hlLoop3.HL.HierarchicalLevelCode_03 = "P";

            //  Repeating MAN
            hlLoop3.MAN = new List<MAN>();

            //  GM is the Marks and Numbers Qualifier. “GM” indicates
            //  “EAN.UCC Serial Shipping Container Code(SSCC) and
            //  Application Identifier.”
            //  00000010012345614785 is the Marks and Numbers(SCC-18). 
            var man1 = new MAN();
            man1.MarksandNumbersQualifier_01 = "GM";
            man1.MarksandNumbers_02 = "00000091670124582779";//ASN !!
            hlLoop3.MAN.Add(man1);

            //  End HL Loop 3
            result.HLLoop.Add(hlLoop3);

            //  Begin HL Loop 4
            var hlLoop4 = new Loop_HL_856();

            //  4 is the Hierarchical ID Number.
            //  3 is the Hierarchical Parent ID Number. (Pack)
            //  I is the Hierarchical Level Code. “I” indicates “Item”
            hlLoop4.HL = new HL();
            hlLoop4.HL.HierarchicalIDNumber_01 = "4";
            hlLoop4.HL.HierarchicalParentIDNumber_02 = "3";
            hlLoop4.HL.HierarchicalLevelCode_03 = "I";

            //  UP is the Product/Service ID Qualifier. “UP” indicates “UCC12"
            //  008815509183 is the Product / Service ID
            hlLoop4.LIN = new LIN();
            hlLoop4.LIN.ProductServiceIDQualifier_02 = "UP";
            hlLoop4.LIN.ProductServiceID_03 = "190403545724";

            //  4 is the Number of Units Shipped.
            //  EA is the Unit or Basis for Measurement Code. “EA” indicates
            //  “Each”. 

            hlLoop4.SN1 = new SN1();
            hlLoop4.SN1.NumberofUnitsShipped_02 = "1";
            hlLoop4.SN1.UnitorBasisforMeasurementCode_03 = "EA";

            //  End HL Loop 4
            result.HLLoop.Add(hlLoop4);

            //  Begin HL Loop 5
            var hlLoop5 = new Loop_HL_856();

            //  5 is the Hierarchical ID Number.
            //  3 is the Hierarchical Parent ID Number. (Pack)
            //  I is the Hierarchical Level Code. “I” indicates “Item”. 
            hlLoop5.HL = new HL();
            hlLoop5.HL.HierarchicalIDNumber_01 = "5";
            hlLoop5.HL.HierarchicalParentIDNumber_02 = "3";
            hlLoop5.HL.HierarchicalLevelCode_03 = "I";

            //  UP is the Product/Service ID Qualifier. “UP” indicates “UCC
            //  -12”.
            //  008815547321 is the Product / Service ID.
            hlLoop5.LIN = new LIN();
            hlLoop5.LIN.ProductServiceIDQualifier_02 = "UP";
            hlLoop5.LIN.ProductServiceID_03 = "190403893498";

            //  9 is the Number of Units Shipped.
            //  EA is the Unit or Basis for Measurement Code. “EA”
            //  indicates “Each”.

            hlLoop5.SN1 = new SN1();
            hlLoop5.SN1.NumberofUnitsShipped_02 = "1";
            hlLoop5.SN1.UnitorBasisforMeasurementCode_03 = "EA";

            //  End HL Loop 5
            result.HLLoop.Add(hlLoop5);

            

            //  5 is the Number of Line Items (number of HL segments in the
            //  document). 
            result.CTT = new CTT();
            result.CTT.NumberofLineItems_01 = "5";

            return result;
        }


        private static ISA BuildIsa(string controlNumber,
           string senderId = "RECONGROUP",
           string senderQ = "ZZ",
           string receiverId = "925485US00",
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
                InterchangeControlVersionNumber_12 = "00204",
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
            string receiverId = "925485US00")
        {
            return new GS
            {
                //  Functional ID Code
                CodeIdentifyingInformationType_1 = "IN",
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
                VersionAndRelease_8 = "005010"
            };
        }
    }
}
