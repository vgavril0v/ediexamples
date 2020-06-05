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
    /// Loop for Student Activities and Awards
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ATV))]
    public class Loop_ATV_138
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Student Activities and Awards
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ATV ATV { get; set; }
        /// <summary>
        /// Employment Position
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Degree Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DEG))]
    public class Loop_DEG_138
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
        [ListCount(5)]
        [Pos(2)]
        public virtual List<FOS> FOS { get; set; }
    }
    
    /// <summary>
    /// Loop for Degree Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DEG))]
    public class Loop_DEG_138_2
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
        /// Academic Summary
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SUM SUM { get; set; }
        /// <summary>
        /// Field of Study
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(3)]
        public virtual List<FOS> FOS { get; set; }
    }
    
    /// <summary>
    /// Loop for Employment Position
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EMS))]
    public class Loop_EMS_138
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
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_138
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IN1 IN1 { get; set; }
        /// <summary>
        /// Individual Name Structure Components
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Entry and Exit Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SSE SSE { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Additional Individual Demographic Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual IND IND { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<LUI> LUI { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Communication Contact Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        /// Request for Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<RQS> RQS { get; set; }
        /// <summary>
        /// Statistical Category Analysis
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<SCA> SCA { get; set; }
        /// <summary>
        /// Loop for Employment Position
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(13)]
        public virtual List<Loop_EMS_138> EMSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_138
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
        /// Party Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PER PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_138_2
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
        /// Party Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Communication Contact Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for Previous College
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCL))]
    public class Loop_PCL_138
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Previous College
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PCL PCL { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Entry and Exit Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SSE SSE { get; set; }
        /// <summary>
        /// Field of Study
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<FOS> FOS { get; set; }
        /// <summary>
        /// Loop for Degree Record
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<Loop_DEG_138_2> DEGLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Requirement, Attribute, and Proficiency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RAP))]
    public class Loop_RAP_138
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Requirement, Attribute, and Proficiency
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RAP RAP { get; set; }
        /// <summary>
        /// Employment Position
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual EMS EMS { get; set; }
    }
    
    /// <summary>
    /// Loop for Subtest
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SBT))]
    public class Loop_SBT_138
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subtest
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SBT SBT { get; set; }
        /// <summary>
        /// Test Scores
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<SRE> SRE { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Requirement, Attribute, and Proficiency
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_RAP_138> RAPLoop { get; set; }
        /// <summary>
        /// Loop for Statistical Category Analysis
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_SCA_138> SCALoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_N1_138 N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Statistical Category Analysis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCA))]
    public class Loop_SCA_138
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Statistical Category Analysis
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SCA SCA { get; set; }
        /// <summary>
        /// Field of Study
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FOS FOS { get; set; }
    }
    
    /// <summary>
    /// Loop for Student Academic Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SST))]
    public class Loop_SST_138
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Student Academic Status
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SST SST { get; set; }
        /// <summary>
        /// Entry and Exit Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SSE SSE { get; set; }
        /// <summary>
        /// Academic Summary
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SUM SUM { get; set; }
        /// <summary>
        /// Field of Study
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<FOS> FOS { get; set; }
        /// <summary>
        /// Request for Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<RQS> RQS { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_N1_138_2 N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Test Score Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TST))]
    public class Loop_TST_138
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Test Score Record
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TST TST { get; set; }
        /// <summary>
        /// Loop for Subtest
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_SBT_138> SBTLoop { get; set; }
    }
    
    /// <summary>
    /// Educational Testing and Prospect Request and Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "138")]
    public class TS138 : EdiMessage
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
        /// Educational Record Purpose
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual ERP ERP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<Loop_N1_138> N1Loop { get; set; }
        /// <summary>
        /// Loop for Individual Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<Loop_IN1_138> IN1Loop { get; set; }
        /// <summary>
        /// Loop for Test Score Record
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_TST_138> TSTLoop { get; set; }
        /// <summary>
        /// Loop for Degree Record
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<Loop_DEG_138> DEGLoop { get; set; }
        /// <summary>
        /// Loop for Student Academic Status
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_SST_138> SSTLoop { get; set; }
        /// <summary>
        /// Loop for Previous College
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(10)]
        public virtual List<Loop_PCL_138> PCLLoop { get; set; }
        /// <summary>
        /// Loop for Student Activities and Awards
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_ATV_138> ATVLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual SE SE { get; set; }
    }
}
