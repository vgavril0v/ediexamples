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
    public class Loop_ACT_186
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
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<Loop_LX_186> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Beginning of Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(BOR))]
    public class Loop_BOR_186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Beginning of Report
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BOR BOR { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_NM1_186_3> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Specimen Kit Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_SPK_186> SPKLoop { get; set; }
        /// <summary>
        /// Loop for Laboratory Test Results
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_LTR_186> LTRLoop { get; set; }
        /// <summary>
        /// Loop for Underwriting Category
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_UC_186> UCLoop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Loop_LS_186 LSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Electronic Format Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EFI))]
    public class Loop_EFI_186
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
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_186
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
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Additional Demographic Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual DMA DMA { get; set; }
        /// <summary>
        /// Informational Values
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual AM1 AM1 { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Employment Class
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual EC EC { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Individual Identification
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual IN1 IN1 { get; set; }
        /// <summary>
        /// Employment Position
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        /// Asset Liability
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual List<ASL> ASL { get; set; }
        /// <summary>
        /// Type of Activity
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual TOA TOA { get; set; }
        /// <summary>
        /// Vehicle Use Information
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual TOV TOV { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Substance Use
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual SIN SIN { get; set; }
        /// <summary>
        /// Underwriting Considerations
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual UCS UCS { get; set; }
        /// <summary>
        /// Family History
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual FH FH { get; set; }
        /// <summary>
        /// Underwriting Status
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual UD UD { get; set; }
        /// <summary>
        /// Case Description
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual CDS CDS { get; set; }
        /// <summary>
        /// Administration of Justice Event Description
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual CED CED { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        /// Military Personnel Information
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual MPI MPI { get; set; }
        /// <summary>
        /// Loop for Electronic Format Identification
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual List<Loop_EFI_186> EFILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_186
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
        /// Loop for Underwriting Status
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_UD_186> UDLoop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Laboratory Test Results
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LTR))]
    public class Loop_LTR_186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Laboratory Test Results
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LTR LTR { get; set; }
        /// <summary>
        /// Multi-Valued Characteristics
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<CD2> CD2 { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<NM1> NM1 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_186
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
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<Loop_NM1_186_2> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Beginning of Report
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_BOR_186> BORLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_186
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
    public class Loop_NM1_186_2
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Informational Values
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<AM1> AM1 { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual PWK PWK { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Additional Demographic Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual DMA DMA { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_186_3
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Additional Demographic Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DMA DMA { get; set; }
        /// <summary>
        /// Relationship
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual REL REL { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_186_4
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
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N4 N4 { get; set; }
    }
    
    /// <summary>
    /// Loop for Specimen Kit Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SPK))]
    public class Loop_SPK_186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Specimen Kit Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SPK SPK { get; set; }
        /// <summary>
        /// Multi-Valued Characteristics
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<CD2> CD2 { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_NM1_186_4> NM1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Underwriting Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(UC))]
    public class Loop_UC_186
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
        public virtual List<Loop_HL_186> HLLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Underwriting Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(UD))]
    public class Loop_UD_186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Underwriting Status
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual UD UD { get; set; }
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
        /// Relationship
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REL REL { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Loop for Electronic Format Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_EFI_186> EFILoop { get; set; }
    }
    
    /// <summary>
    /// Insurance Underwriting Requirements Reporting
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "186")]
    public class TS186 : EdiMessage
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
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Laboratory Test Results
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<LTR> LTR { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<Loop_NM1_186> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Account Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual List<Loop_ACT_186> ACTLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
