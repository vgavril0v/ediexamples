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
    public class Loop_ATV_130
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
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Course Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CRS))]
    public class Loop_CRS_130
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Supplemental Course Data
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CSU CSU { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<LUI> LUI { get; set; }
        /// <summary>
        /// Requirement, Attribute, and Proficiency
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<RAP> RAP { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Loop for Marks Awarded
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_MKS_130> MKSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Degree Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DEG))]
    public class Loop_DEG_130
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
        [ListCount(5)]
        [Pos(2)]
        public virtual List<SUM> SUM { get; set; }
        /// <summary>
        /// Field of Study
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(3)]
        public virtual List<FOS> FOS { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(5)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Health Condition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HC))]
    public class Loop_HC_130
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Health Condition
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HC HC { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N2 N2 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PER PER { get; set; }
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
    }
    
    /// <summary>
    /// Loop for Individual Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_130
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
        /// Employment Position
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<EMS> EMS { get; set; }
        /// <summary>
        /// Individual Name Structure Components
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        /// Loop for Party Location
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<Loop_N3_130> N3Loop { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual NTE NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_130
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
        /// Health Screening
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<HS> HS { get; set; }
        /// <summary>
        /// Immunization Status
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(3)]
        public virtual List<IMM> IMM { get; set; }
        /// <summary>
        /// Loop for Health Condition
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(4)]
        public virtual List<Loop_HC_130> HCLoop { get; set; }
        /// <summary>
        /// Loop for Special Program
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(5)]
        public virtual List<Loop_SP_130> SPLoop { get; set; }
        /// <summary>
        /// Loop for Academic Session Header
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(6)]
        public virtual List<Loop_SES_130> SESLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Marks Awarded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MKS))]
    public class Loop_MKS_130
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marks Awarded
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MKS MKS { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual LUI LUI { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_130
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
        [Pos(2)]
        public virtual N2 N2 { get; set; }
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N3))]
    public class Loop_N3_130
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
    }
    
    /// <summary>
    /// Loop for Program Subject Area and Eligibility
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(OPS))]
    public class Loop_OPS_130
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Program Subject Area and Eligibility
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual OPS OPS { get; set; }
        /// <summary>
        /// Placement Criteria
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<OPX> OPX { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Subtest
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SBT))]
    public class Loop_SBT_130
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
        [ListCount(3)]
        [Pos(2)]
        public virtual List<SRE> SRE { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Academic Session Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SES))]
    public class Loop_SES_130
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
        /// Entry and Exit Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SSE SSE { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
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
        /// Loop for Academic Summary
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<Loop_SUM_130> SUMLoop { get; set; }
        /// <summary>
        /// Loop for Course Record
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(8)]
        public virtual List<Loop_CRS_130> CRSLoop { get; set; }
        /// <summary>
        /// Loop for Degree Record
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_DEG_130> DEGLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Special Program
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SP))]
    public class Loop_SP_130
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special Program
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SP SP { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PER PER { get; set; }
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
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual NTE NTE { get; set; }
        /// <summary>
        /// Loop for Program Subject Area and Eligibility
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<Loop_OPS_130> OPSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Student Academic Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SST))]
    public class Loop_SST_130
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
        [ListCount(1000)]
        [Pos(2)]
        public virtual List<SSE> SSE { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N1 N1 { get; set; }
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
    }
    
    /// <summary>
    /// Loop for Academic Summary
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SUM))]
    public class Loop_SUM_130
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Academic Summary
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SUM SUM { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Test Score Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TST))]
    public class Loop_TST_130
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
        public virtual List<Loop_SBT_130> SBTLoop { get; set; }
    }
    
    /// <summary>
    /// Student Educational Record (Transcript)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "130")]
    public class TS130 : EdiMessage
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
        [ListCount(10)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<LUI> LUI { get; set; }
        /// <summary>
        /// Additional Individual Demographic Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<IND> IND { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Requirement, Attribute, and Proficiency
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<RAP> RAP { get; set; }
        /// <summary>
        /// Previous College
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(10)]
        public virtual List<PCL> PCL { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(11)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(12)]
        public virtual List<Loop_N1_130> N1Loop { get; set; }
        /// <summary>
        /// Loop for Individual Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(15)]
        [Pos(13)]
        public virtual List<Loop_IN1_130> IN1Loop { get; set; }
        /// <summary>
        /// Loop for Student Academic Status
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(14)]
        public virtual List<Loop_SST_130> SSTLoop { get; set; }
        /// <summary>
        /// Loop for Student Activities and Awards
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(15)]
        public virtual List<Loop_ATV_130> ATVLoop { get; set; }
        /// <summary>
        /// Loop for Test Score Record
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_TST_130> TSTLoop { get; set; }
        /// <summary>
        /// Loop for Academic Summary
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(17)]
        public virtual List<Loop_SUM_130> SUMLoop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual Loop_LX_130 LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual SE SE { get; set; }
    }
}
