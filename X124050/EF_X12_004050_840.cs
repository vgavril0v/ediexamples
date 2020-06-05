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
    /// Loop for Advertising Demographic Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ADV))]
    public class Loop_ADV_840
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
    /// Loop for Contract and Cost Accounting Standards Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CB1))]
    public class Loop_CB1_840
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contract and Cost Accounting Standards Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CB1 CB1 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Lead Time
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual LDT LDT { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Lead Time
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LDT))]
    public class Loop_LDT_840
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
    public class Loop_LDT_840_2
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
        public virtual Loop_LM_840_2 LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Lead Time
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LDT))]
    public class Loop_LDT_840_3
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
    public class Loop_LM_840
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
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_840_2
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
        public virtual LQ LQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_840
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
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<N4> N4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<SI> SI { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(9)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(10)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(11)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(12)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(13)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Required Response
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(14)]
        public virtual List<RRA> RRA { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_840_2
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
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual G61 G61 { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_840_3
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
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<SI> SI { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        /// Line Item Schedule
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(11)]
        public virtual List<SCH> SCH { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(12)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(13)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(14)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(15)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(16)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Required Response
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(17)]
        public virtual List<RRA> RRA { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual CTP CTP { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(19)]
        public virtual List<PAM> PAM { get; set; }
        /// <summary>
        /// Loop for Lead Time
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<Loop_LDT_840_3> LDTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Extended Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_840
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
    /// Loop for Percent Amounts
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCT))]
    public class Loop_PCT_840
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PCT PCT { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
    }
    
    /// <summary>
    /// Loop for Product/Item Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PID))]
    public class Loop_PID_840
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
    /// Loop for Baseline Item Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PO1))]
    public class Loop_PO1_840
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Baseline Item Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PO1 PO1 { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Maintenance Type
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual G53 G53 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CN1 CN1 { get; set; }
        /// <summary>
        /// Additional Item Detail
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(6)]
        public virtual List<PO3> PO3 { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
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
        /// Restrictions/Conditions
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<CTB> CTB { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(40)]
        [Pos(10)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Loop for Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(11)]
        public virtual List<Loop_PID_840> PIDLoop { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(12)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(13)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<PO4> PO4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(16)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(17)]
        public virtual List<SAC> SAC { get; set; }
        /// <summary>
        /// Conditions of Sale
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(18)]
        public virtual List<IT8> IT8 { get; set; }
        /// <summary>
        /// Sales Requirements
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual List<CSH> CSH { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(20)]
        public virtual List<ITD> ITD { get; set; }
        /// <summary>
        /// Discount Detail
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(21)]
        public virtual List<DIS> DIS { get; set; }
        /// <summary>
        /// Tax Reference
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(22)]
        public virtual List<TAX> TAX { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual List<FOB> FOB { get; set; }
        /// <summary>
        /// Destination Quantity
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(24)]
        public virtual List<SDQ> SDQ { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(25)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Forecast Schedule
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual List<FST> FST { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual TD1 TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(28)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(29)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(30)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(31)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Required Response
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(32)]
        public virtual List<RRA> RRA { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Specification Identifier
        /// </summary>
        [DataMember]
        [Pos(34)]
        public virtual List<SPI> SPI { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(35)]
        public virtual List<Loop_LM_840> LMLoop { get; set; }
        /// <summary>
        /// Loop for Quantity Information
        /// </summary>
        [DataMember]
        [Pos(36)]
        public virtual List<Loop_QTY_840> QTYLoop { get; set; }
        /// <summary>
        /// Loop for Line Item Schedule
        /// </summary>
        [DataMember]
        [ListCount(104)]
        [Pos(37)]
        public virtual List<Loop_SCH_840> SCHLoop { get; set; }
        /// <summary>
        /// Loop for Lead Time
        /// </summary>
        [DataMember]
        [Pos(38)]
        public virtual List<Loop_LDT_840_2> LDTLoop { get; set; }
        /// <summary>
        /// Loop for Subline Item Detail
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(39)]
        public virtual List<Loop_SLN_840> SLNLoop { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(40)]
        public virtual List<Loop_N9_840> N9Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(41)]
        public virtual List<Loop_N1_840_3> N1Loop { get; set; }
        /// <summary>
        /// Loop for Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(42)]
        public virtual List<Loop_PCT_840> PCTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Quantity Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_840
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
    /// Loop for Line Item Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCH))]
    public class Loop_SCH_840
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
    public class Loop_SLN_840
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
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(3)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Advertising Demographic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<ADV> ADV { get; set; }
        /// <summary>
        /// Loop for Quantity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_QTY_840> QTYLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Specification Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SPI))]
    public class Loop_SPI_840
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Specification Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SPI SPI { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<Loop_N1_840_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Contract and Cost Accounting Standards Data
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_CB1_840> CB1Loop { get; set; }
    }
    
    /// <summary>
    /// Request for Quotation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "840")]
    public class TS840 : EdiMessage
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
        /// Beginning Segment for Request for Quotation
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BQT BQT { get; set; }
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
        [ListCount(3)]
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
        [ListCount(25)]
        [Pos(10)]
        public virtual List<CSH> CSH { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(11)]
        public virtual List<SAC> SAC { get; set; }
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(14)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(15)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(16)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(40)]
        [Pos(17)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(18)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(19)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(20)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(21)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(22)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(23)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(24)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Required Response
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(25)]
        public virtual List<RRA> RRA { get; set; }
        /// <summary>
        /// Restrictions/Conditions
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual List<CTB> CTB { get; set; }
        /// <summary>
        /// Loop for Lead Time
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual List<Loop_LDT_840> LDTLoop { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(28)]
        public virtual List<Loop_N9_840> N9Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10000)]
        [Pos(29)]
        public virtual List<Loop_N1_840> N1Loop { get; set; }
        /// <summary>
        /// Loop for Specification Identifier
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual Loop_SPI_840 SPILoop { get; set; }
        /// <summary>
        /// Loop for Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual List<Loop_PCT_840> PCTLoop { get; set; }
        /// <summary>
        /// Loop for Advertising Demographic Information
        /// </summary>
        [DataMember]
        [Pos(32)]
        public virtual List<Loop_ADV_840> ADVLoop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual List<Loop_LM_840> LMLoop { get; set; }
        /// <summary>
        /// Loop for Baseline Item Data
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(100000)]
        [Pos(34)]
        public virtual List<Loop_PO1_840> PO1Loop { get; set; }
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [DataMember]
        [Pos(35)]
        public virtual CTT CTT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(36)]
        public virtual SE SE { get; set; }
    }
}
