namespace EdiFabric.Templates.X12004050
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Loop for Line Item Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ACK))]
    public class Loop_ACK_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item Acknowledgment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ACK ACK { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Advertising Demographic Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ADV))]
    public class Loop_ADV_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Advertising Demographic Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ADV ADV { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Monetary Amount Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_AMT_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PCT> PCT { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Totals
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTT))]
    public class Loop_CTT_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CTT CTT { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
    }
    
    /// <summary>
    /// Loop for Lead Time
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LDT))]
    public class Loop_LDT_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lead Time
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LDT LDT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Lead Time
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LDT))]
    public class Loop_LDT_865_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lead Time
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LDT LDT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_LM_865> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Lead Time
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LDT))]
    public class Loop_LDT_865_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lead Time
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LDT LDT { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Individual Name Structure Components
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Location ID Component
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(7)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<SI> SI { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(11)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(12)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(13)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(14)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(15)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_865_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Individual Name Structure Components
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Location ID Component
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(8)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(9)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<SI> SI { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        /// Line Item Schedule
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(13)]
        public virtual List<SCH> SCH { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(14)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(15)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(16)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(17)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(18)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Loop for Lead Time
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual List<Loop_LDT_865_3> LDTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_865_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Individual Name Structure Components
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Location ID Component
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(7)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(8)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<SI> SI { get; set; }
    }
    
    /// <summary>
    /// Loop for Extended Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N9 N9 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Electronic Format Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<EFI> EFI { get; set; }
    }
    
    /// <summary>
    /// Loop for Extended Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_865_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N9 N9 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Pricing Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PD))]
    public class Loop_PD_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pricing Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PD PD { get; set; }
        /// <summary>
        /// Pricing Data Detail
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PDD> PDD { get; set; }
    }
    
    /// <summary>
    /// Loop for Product/Item Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PID))]
    public class Loop_PID_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PID PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Item Change
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(POC))]
    public class Loop_POC_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item Change
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual POC POC { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<SI> SI { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Additional Item Detail
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(5)]
        public virtual List<PO3> PO3 { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<CTP> CTP { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<PAM> PAM { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(40)]
        [Pos(8)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Loop for Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(9)]
        public virtual List<Loop_PID_865> PIDLoop { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(10)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(11)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<PO4> PO4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(14)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Loop for Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(15)]
        public virtual List<Loop_SAC_865> SACLoop { get; set; }
        /// <summary>
        /// Conditions of Sale
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual IT8 IT8 { get; set; }
        /// <summary>
        /// Sales Requirements
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<CSH> CSH { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(18)]
        public virtual List<ITD> ITD { get; set; }
        /// <summary>
        /// Discount Detail
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(19)]
        public virtual List<DIS> DIS { get; set; }
        /// <summary>
        /// Installment Information
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual INC INC { get; set; }
        /// <summary>
        /// Tax Reference
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual List<TAX> TAX { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual List<FOB> FOB { get; set; }
        /// <summary>
        /// Destination Quantity
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(23)]
        public virtual List<SDQ> SDQ { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(24)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual TD1 TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(26)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(27)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(28)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual List<TXI> TXI { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Loop for Line Item Acknowledgment
        /// </summary>
        [DataMember]
        [ListCount(104)]
        [Pos(31)]
        public virtual List<Loop_ACK_865> ACKLoop { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(32)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Specification Identifier
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual List<SPI> SPI { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(34)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Restrictions/Conditions
        /// </summary>
        [DataMember]
        [Pos(35)]
        public virtual List<CTB> CTB { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(36)]
        public virtual List<Loop_LM_865> LMLoop { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(37)]
        public virtual List<Loop_AMT_865> AMTLoop { get; set; }
        /// <summary>
        /// Loop for Quantity Information
        /// </summary>
        [DataMember]
        [Pos(38)]
        public virtual List<Loop_QTY_865> QTYLoop { get; set; }
        /// <summary>
        /// Loop for Line Item Schedule
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(39)]
        public virtual List<Loop_SCH_865> SCHLoop { get; set; }
        /// <summary>
        /// Loop for Lead Time
        /// </summary>
        [DataMember]
        [Pos(40)]
        public virtual List<Loop_LDT_865_2> LDTLoop { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(41)]
        public virtual List<Loop_N9_865> N9Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(42)]
        public virtual List<Loop_N1_865_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Subline Item Detail
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(43)]
        public virtual List<Loop_SLN_865> SLNLoop { get; set; }
        /// <summary>
        /// Loop for Pricing Data
        /// </summary>
        [DataMember]
        [Pos(44)]
        public virtual List<Loop_PD_865> PDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Quantity Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<SI> SI { get; set; }
    }
    
    /// <summary>
    /// Loop for Service, Promotion, Allowance, or Charge Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SAC))]
    public class Loop_SAC_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SAC SAC { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Item Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCH))]
    public class Loop_SCH_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item Schedule
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SCH SCH { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(3)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(4)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Subline Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN))]
    public class Loop_SLN_865
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subline Item Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SLN SLN { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<SI> SI { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(4)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Additional Item Detail
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(5)]
        public virtual List<PO3> PO3 { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(7)]
        public virtual List<CTP> CTP { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<PAM> PAM { get; set; }
        /// <summary>
        /// Line Item Acknowledgment
        /// </summary>
        [DataMember]
        [ListCount(104)]
        [Pos(9)]
        public virtual List<ACK> ACK { get; set; }
        /// <summary>
        /// Loop for Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<Loop_SAC_865> SACLoop { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        /// Tax Reference
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(13)]
        public virtual List<TAX> TAX { get; set; }
        /// <summary>
        /// Advertising Demographic Information
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<ADV> ADV { get; set; }
        /// <summary>
        /// Loop for Quantity Information
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_QTY_865> QTYLoop { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_N9_865_2> N9Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(17)]
        public virtual List<Loop_N1_865_3> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Purchase Order Change Acknowledgment/Request - Seller Initiated
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "865")]
    public class TS865 : EdiMessage
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        /// Beginning Segment for Purchase Order Change Acknowledgment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BCA BCA { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Tax Reference
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<TAX> TAX { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<FOB> FOB { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<CTP> CTP { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<PAM> PAM { get; set; }
        /// <summary>
        /// Sales Requirements
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual CSH CSH { get; set; }
        /// <summary>
        /// Loop for Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(11)]
        public virtual List<Loop_SAC_865> SACLoop { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(12)]
        public virtual List<ITD> ITD { get; set; }
        /// <summary>
        /// Discount Detail
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(13)]
        public virtual List<DIS> DIS { get; set; }
        /// <summary>
        /// Installment Information
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual INC INC { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(15)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(16)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<SI> SI { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(18)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(40)]
        [Pos(19)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(20)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(21)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(22)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(23)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(24)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(25)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(27)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual List<TXI> TXI { get; set; }
        /// <summary>
        /// Restrictions/Conditions
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual List<CTB> CTB { get; set; }
        /// <summary>
        /// Maintenance Type
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual List<G53> G53 { get; set; }
        /// <summary>
        /// Loop for Lead Time
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual List<Loop_LDT_865> LDTLoop { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(32)]
        public virtual List<Loop_N9_865> N9Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(33)]
        public virtual List<Loop_N1_865> N1Loop { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(34)]
        public virtual List<Loop_AMT_865> AMTLoop { get; set; }
        /// <summary>
        /// Loop for Advertising Demographic Information
        /// </summary>
        [DataMember]
        [Pos(35)]
        public virtual List<Loop_ADV_865> ADVLoop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(36)]
        public virtual List<Loop_LM_865> LMLoop { get; set; }
        /// <summary>
        /// Loop for Line Item Change
        /// </summary>
        [DataMember]
        [Pos(37)]
        public virtual List<Loop_POC_865> POCLoop { get; set; }
        /// <summary>
        /// Loop for Transaction Totals
        /// </summary>
        [DataMember]
        [Pos(38)]
        public virtual Loop_CTT_865 CTTLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(39)]
        public virtual SE SE { get; set; }
    }
}
