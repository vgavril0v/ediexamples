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
    /// Loop for Empty Car Disposition - Pended Destination Consignee
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(E1))]
    public class Loop_E1_858
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Empty Car Disposition - Pended Destination Consignee
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual E1 E1 { get; set; }
        /// <summary>
        /// Empty Car Disposition - Pended Destination City
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual E4 E4 { get; set; }
        /// <summary>
        /// Empty Car Disposition - Pended Destination Route
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(3)]
        public virtual List<E5> E5 { get; set; }
        /// <summary>
        /// Price Authority Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PI PI { get; set; }
    }
    
    /// <summary>
    /// Loop for Type of Financial Accounting Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FA1))]
    public class Loop_FA1_858
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Type of Financial Accounting Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FA1 FA1 { get; set; }
        /// <summary>
        /// Accounting Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<FA2> FA2 { get; set; }
        /// <summary>
        /// Weight Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual L10 L10 { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_858
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HL HL { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// Cross-Reference Equipment
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual NA NA { get; set; }
        /// <summary>
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        /// Equipment Ordered
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N5 N5 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Intermodal Chassis Equipment
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual IC IC { get; set; }
        /// <summary>
        /// Motor Vehicle Control
        /// </summary>
        [DataMember]
        [ListCount(36)]
        [Pos(8)]
        public virtual List<VC> VC { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<L7> L7 { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual SL1 SL1 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual H3 H3 { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(13)]
        public virtual List<X1> X1 { get; set; }
        /// <summary>
        /// Import License
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual X2 X2 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(15)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(16)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Hazardous Classification Information
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(17)]
        public virtual List<LH2> LH2 { get; set; }
        /// <summary>
        /// Hazardous Material Identifying Reference Numbers
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual LHR LHR { get; set; }
        /// <summary>
        /// Hazardous Certification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(19)]
        public virtual List<LH6> LH6 { get; set; }
        /// <summary>
        /// Cargo Booking Priority
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(20)]
        public virtual List<Y7> Y7 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(21)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(22)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Load Planning
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual LP LP { get; set; }
        /// <summary>
        /// Vehicle Axle Measurements
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(24)]
        public virtual List<AXL> AXL { get; set; }
        /// <summary>
        /// Loop for Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(25)]
        public virtual List<Loop_L0_858> L0Loop { get; set; }
        /// <summary>
        /// Loop for Hazardous Identification Information
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(26)]
        public virtual List<Loop_LH1_858> LH1Loop { get; set; }
        /// <summary>
        /// Loop for Type of Financial Accounting Data
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual List<Loop_FA1_858> FA1Loop { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(28)]
        public virtual List<Loop_NM1_858> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(29)]
        public virtual List<Loop_N1_858_3> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Item - Quantity and Weight
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L0))]
    public class Loop_L0_858
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L0 L0 { get; set; }
        /// <summary>
        /// Rate and Charges
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<L1> L1 { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<MEA> MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for Hazardous Identification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_LH1_858
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Identification Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LH1 LH1 { get; set; }
        /// <summary>
        /// Hazardous Classification Information
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(2)]
        public virtual List<LH2> LH2 { get; set; }
        /// <summary>
        /// Hazardous Material Shipping Name
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(3)]
        public virtual List<LH3> LH3 { get; set; }
        /// <summary>
        /// Freeform Hazardous Material Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<LFH> LFH { get; set; }
        /// <summary>
        /// EPA Required Data
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<LEP> LEP { get; set; }
        /// <summary>
        /// Canadian Dangerous Requirements
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual LH4 LH4 { get; set; }
        /// <summary>
        /// Transborder Hazardous Requirements
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<LHT> LHT { get; set; }
        /// <summary>
        /// Hazardous Material Identifying Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<LHR> LHR { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Empty Equipment Hazardous Material Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual LHE LHE { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_858
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
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<H3> H3 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_858_2
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
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_858_3
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
    }
    
    /// <summary>
    /// Loop for Equipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N7))]
    public class Loop_N7_858
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// Equipment Characteristics
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual EM EM { get; set; }
        /// <summary>
        /// Cross-Reference Equipment
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(3)]
        public virtual List<NA> NA { get; set; }
        /// <summary>
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        /// Equipment Ordered
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N5 N5 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Intermodal Chassis Equipment
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual IC IC { get; set; }
        /// <summary>
        /// Motor Vehicle Control
        /// </summary>
        [DataMember]
        [ListCount(36)]
        [Pos(9)]
        public virtual List<VC> VC { get; set; }
        /// <summary>
        /// Canadian Grain Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(10)]
        public virtual List<GA> GA { get; set; }
        /// <summary>
        /// Loop for Empty Car Disposition - Pended Destination Consignee
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(11)]
        public virtual List<Loop_E1_858> E1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_858
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
    }
    
    /// <summary>
    /// Loop for Stop-off Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(S5))]
    public class Loop_S5_858
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stop-off Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual S5 S5 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Special Services
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(4)]
        public virtual List<H6> H6 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_N1_858_2> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Shipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "858")]
    public class TS858 : EdiMessage
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
        /// Beginning Segment for Data Correction or Change
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ZC1 ZC1 { get; set; }
        /// <summary>
        /// General Shipment Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual BX BX { get; set; }
        /// <summary>
        /// Rail Shipment Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual BNX BNX { get; set; }
        /// <summary>
        /// Release
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual M3 M3 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(6)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Cargo Manifest
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<CM> CM { get; set; }
        /// <summary>
        /// Authentication
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(8)]
        public virtual List<Y6> Y6 { get; set; }
        /// <summary>
        /// Cargo Booking Priority
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Y7 Y7 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual ITD ITD { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(13)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Cross-Reference Equipment
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(14)]
        public virtual List<NA> NA { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual D9 D9 { get; set; }
        /// <summary>
        /// Route Information (Air)
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual R1 R1 { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(18)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        /// Route Information - Motor
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(19)]
        public virtual List<R3> R3 { get; set; }
        /// <summary>
        /// Port or Terminal
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(20)]
        public virtual List<R4> R4 { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(21)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(22)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Protective Service Instructions
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(23)]
        public virtual List<PS> PS { get; set; }
        /// <summary>
        /// Special Services
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(24)]
        public virtual List<H6> H6 { get; set; }
        /// <summary>
        /// Cargo Location Reference
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual V4 V4 { get; set; }
        /// <summary>
        /// Vessel Identification
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual V5 V5 { get; set; }
        /// <summary>
        /// Loop for Empty Car Disposition - Pended Destination Consignee
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(27)]
        public virtual List<Loop_E1_858> E1Loop { get; set; }
        /// <summary>
        /// Insurance
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual M1 M1 { get; set; }
        /// <summary>
        /// Sales/Delivery Terms
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual M2 M2 { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(30)]
        public virtual List<L7> L7 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(31)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Pro Forma - B13 Information
        /// </summary>
        [DataMember]
        [Pos(32)]
        public virtual XH XH { get; set; }
        /// <summary>
        /// Loop for Equipment Details
        /// </summary>
        [DataMember]
        [ListCount(600)]
        [Pos(33)]
        public virtual List<Loop_N7_858> N7Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(34)]
        public virtual List<Loop_N1_858> N1Loop { get; set; }
        /// <summary>
        /// Loop for Stop-off Details
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(35)]
        public virtual List<Loop_S5_858> S5Loop { get; set; }
        /// <summary>
        /// Loop for Type of Financial Accounting Data
        /// </summary>
        [DataMember]
        [Pos(36)]
        public virtual List<Loop_FA1_858> FA1Loop { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(37)]
        public virtual List<Loop_HL_858> HLLoop { get; set; }
        /// <summary>
        /// Total Weight and Charges
        /// </summary>
        [DataMember]
        [Pos(38)]
        public virtual L3 L3 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(39)]
        public virtual SE SE { get; set; }
    }
}
