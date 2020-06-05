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
    /// Loop for Account Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ACT))]
    public class Loop_ACT_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Account Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ACT ACT { get; set; }
        /// <summary>
        /// Action or Status Indicator
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ASI ASI { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<LUI> LUI { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Basic Baseline Item Data
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual BLI BLI { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Payment Details
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<PDL> PDL { get; set; }
        /// <summary>
        /// Informational Values
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<AM1> AM1 { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_LQ_267> LQLoop { get; set; }
        /// <summary>
        /// Loop for Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_SI_267> SILoop { get; set; }
        /// <summary>
        /// Loop for Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<Loop_PID_267> PIDLoop { get; set; }
        /// <summary>
        /// Loop for Entity
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<Loop_ENT_267> ENTLoop { get; set; }
        /// <summary>
        /// Loop for Paperwork
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual List<Loop_PWK_267> PWKLoop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<Loop_LX_267> LXLoop { get; set; }
        /// <summary>
        /// Loop for Administrative Message
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual List<Loop_K2_267> K2Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Informational Values
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AM1))]
    public class Loop_AM1_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Informational Values
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AM1 AM1 { get; set; }
        /// <summary>
        /// Loop for Investment Vehicle Selection
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_INV_267_3> INVLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Monetary Amount Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_AMT_267
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
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
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
        /// Item Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Informational Values
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_AM1_267> AM1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Beneficiary or Owner Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(BEN))]
    public class Loop_BEN_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Beneficiary or Owner Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BEN BEN { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual LUI LUI { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Electronic Format Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EFI))]
    public class Loop_EFI_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Electronic Format Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EFI EFI { get; set; }
        /// <summary>
        /// Binary Data Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BIN BIN { get; set; }
    }
    
    /// <summary>
    /// Loop for Entity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENT))]
    public class Loop_ENT_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Entity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ENT ENT { get; set; }
        /// <summary>
        /// Property or Entity Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<NX1> NX1 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Additional Demographic Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DMA DMA { get; set; }
        /// <summary>
        /// Additional Individual Demographic Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual IND IND { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual LUI LUI { get; set; }
        /// <summary>
        /// Entity Relationship
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ERI ERI { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Informational Values
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<AM1> AM1 { get; set; }
        /// <summary>
        /// Rate Amounts or Percents
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<RPA> RPA { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<Loop_NM1_267_2> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<Loop_LQ_267_2> LQLoop { get; set; }
        /// <summary>
        /// Loop for Beneficiary or Owner Information
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual List<Loop_BEN_267> BENLoop { get; set; }
        /// <summary>
        /// Loop for Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<Loop_PID_267_2> PIDLoop { get; set; }
        /// <summary>
        /// Loop for Underwriting Category
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual List<Loop_UC_267> UCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_267
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
        /// Underwriting Question
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual UQS UQS { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Communication Contact Information
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Informational Values
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<AM1> AM1 { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Employment Class
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual EC EC { get; set; }
        /// <summary>
        /// Employment Position
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        /// Employer
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual EMP EMP { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Source of Income
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<SOI> SOI { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(19)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Asset Liability
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual List<ASL> ASL { get; set; }
        /// <summary>
        /// Type of Activity
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual List<TOA> TOA { get; set; }
        /// <summary>
        /// Vehicle Use Information
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual List<TOV> TOV { get; set; }
        /// <summary>
        /// Vehicle Information
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual List<VEH> VEH { get; set; }
        /// <summary>
        /// Case Description
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual List<CDS> CDS { get; set; }
        /// <summary>
        /// Administration of Justice Event Description
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual List<CED> CED { get; set; }
        /// <summary>
        /// Substance Use
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual List<SIN> SIN { get; set; }
        /// <summary>
        /// Underwriting Considerations
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual List<UCS> UCS { get; set; }
        /// <summary>
        /// Family History
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual List<FH> FH { get; set; }
        /// <summary>
        /// Status of Product or Activity
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual SPA SPA { get; set; }
        /// <summary>
        /// Military Personnel Information
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual MPI MPI { get; set; }
    }
    
    /// <summary>
    /// Loop for Investment Vehicle Selection
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(INV))]
    public class Loop_INV_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Investment Vehicle Selection
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual INV INV { get; set; }
        /// <summary>
        /// Informational Values
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AM1> AM1 { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Rate Amounts or Percents
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<RPA> RPA { get; set; }
    }
    
    /// <summary>
    /// Loop for Investment Vehicle Selection
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(INV))]
    public class Loop_INV_267_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Investment Vehicle Selection
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual INV INV { get; set; }
        /// <summary>
        /// Informational Values
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AM1> AM1 { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Rate Amounts or Percents
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<RPA> RPA { get; set; }
    }
    
    /// <summary>
    /// Loop for Investment Vehicle Selection
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(INV))]
    public class Loop_INV_267_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Investment Vehicle Selection
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual INV INV { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Rate Amounts or Percents
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<RPA> RPA { get; set; }
    }
    
    /// <summary>
    /// Loop for Administrative Message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(K2))]
    public class Loop_K2_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Administrative Message
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual K2 K2 { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual NM1 NM1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Industry Code Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LQ LQ { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<N4> N4 { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<LUI> LUI { get; set; }
    }
    
    /// <summary>
    /// Loop for Industry Code Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_267_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LQ LQ { get; set; }
        /// <summary>
        /// Status of Product or Activity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SPA SPA { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_NM1_267_3> NM1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LS LS { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_AMT_267> AMTLoop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        /// Loop for Payment Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_PDL_267_2> PDLLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_267
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
        [ListCount(3)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for Account Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual List<Loop_ACT_267> ACTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N3))]
    public class Loop_N3_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Communication Contact Information
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual QTY QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_267
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
        [ListCount(3)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_267_2
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
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Informational Values
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<AM1> AM1 { get; set; }
        /// <summary>
        /// Loop for Party Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_N3_267> N3Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_267_3
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
        [ListCount(3)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Communication Contact Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual LUI LUI { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Payment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PDL))]
    public class Loop_PDL_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PDL PDL { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Payment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PDL))]
    public class Loop_PDL_267_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PDL PDL { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_LS_267 LSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Product/Item Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PID))]
    public class Loop_PID_267
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
        /// Basic Baseline Item Data
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual BLI BLI { get; set; }
        /// <summary>
        /// Status of Product or Activity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SPA SPA { get; set; }
        /// <summary>
        /// Underwriting Status
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual UD UD { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Informational Values
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<AM1> AM1 { get; set; }
        /// <summary>
        /// Payment Details
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<PDL> PDL { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Investment Vehicle Selection
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_INV_267> INVLoop { get; set; }
        /// <summary>
        /// Loop for Beneficiary or Owner Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_BEN_267> BENLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Product/Item Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PID))]
    public class Loop_PID_267_2
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
        /// Basic Baseline Item Data
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<BLI> BLI { get; set; }
        /// <summary>
        /// Status of Product or Activity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SPA SPA { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Payment Details
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_PDL_267> PDLLoop { get; set; }
        /// <summary>
        /// Loop for Investment Vehicle Selection
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_INV_267_2> INVLoop { get; set; }
        /// <summary>
        /// Loop for Beneficiary or Owner Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_BEN_267> BENLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Paperwork
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PWK))]
    public class Loop_PWK_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PWK PWK { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Status of Product or Activity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SPA SPA { get; set; }
        /// <summary>
        /// Loop for Electronic Format Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_EFI_267> EFILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Characteristic Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SI))]
    public class Loop_SI_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SI SI { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Underwriting Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(UC))]
    public class Loop_UC_267
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Underwriting Category
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual UC UC { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_HL_267> HLLoop { get; set; }
    }
    
    /// <summary>
    /// Individual Life, Annuity and Disability Application
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "267")]
    public class TS267 : EdiMessage
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
        /// Beginning Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGN BGN { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_NM1_267> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual List<Loop_N1_267> N1Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
