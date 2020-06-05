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
    /// Loop for Credentials and Qualifications
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CQ))]
    public class Loop_CQ_132
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Credentials and Qualifications
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CQ CQ { get; set; }
        /// <summary>
        /// Field of Study
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<FOS> FOS { get; set; }
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
        [ListCount(10)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Institutional Staff Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<ISI> ISI { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Loop for Degree Record
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<Loop_DEG_132> DEGLoop { get; set; }
        /// <summary>
        /// Loop for Course Record
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_CRS_132> CRSLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_N1_132_2> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Course Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CRS))]
    public class Loop_CRS_132
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Course Record
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CRS CRS { get; set; }
        /// <summary>
        /// Supplemental Course Data
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CSU CSU { get; set; }
    }
    
    /// <summary>
    /// Loop for Degree Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DEG))]
    public class Loop_DEG_132
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Degree Record
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DEG DEG { get; set; }
        /// <summary>
        /// Field of Study
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<FOS> FOS { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for Employment Position
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EMS))]
    public class Loop_EMS_132
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Employment Position
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        /// Institutional Staff Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<ISI> ISI { get; set; }
        /// <summary>
        /// Employment Status Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ESI ESI { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<LQ> LQ { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Employee Leave Summary
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(9)]
        public virtual List<ELV> ELV { get; set; }
        /// <summary>
        /// Income
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(10)]
        public virtual List<AIN> AIN { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual CN1 CN1 { get; set; }
        /// <summary>
        /// Contract Number Detail
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual CON CON { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_N9_132> N9Loop { get; set; }
        /// <summary>
        /// Loop for Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_PCT_132> PCTLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual Loop_N1_132_3 N1Loop { get; set; }
        /// <summary>
        /// Loop for Academic Session Header
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_SES_132> SESLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_132
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<LUI> LUI { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual List<Loop_NM1_132> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Credentials and Qualifications
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_CQ_132> CQLoop { get; set; }
        /// <summary>
        /// Loop for Employment Position
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_EMS_132> EMSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_132
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
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Communication Contact Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_132_2
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
        /// Communication Contact Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_132_3
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
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N4 N4 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N3))]
    public class Loop_N3_132
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
        [Pos(3)]
        public virtual List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for Extended Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_132
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
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_132
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
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Loop for Party Location
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<Loop_N3_132> N3Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Percent Amounts
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCT))]
    public class Loop_PCT_132
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
    }
    
    /// <summary>
    /// Loop for Academic Session Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SES))]
    public class Loop_SES_132
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Academic Session Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SES SES { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Loop for Workload Detail
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_WLD_132> WLDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Workload Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(WLD))]
    public class Loop_WLD_132
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Workload Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual WLD WLD { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<YNQ> YNQ { get; set; }
    }
    
    /// <summary>
    /// Human Resource Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "132")]
    public class TS132 : EdiMessage
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
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_N1_132> N1Loop { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_HL_132> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
