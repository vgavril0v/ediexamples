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
    public class Loop_ATV_133
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for School Enrollment Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENM))]
    public class Loop_ENM_133
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// School Enrollment Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ENM ENM { get; set; }
        /// <summary>
        /// Field of Study
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FOS FOS { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Field of Study
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FOS))]
    public class Loop_FOS_133
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Field of Study
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FOS FOS { get; set; }
        /// <summary>
        /// Degree Record
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DEG DEG { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<AMT> AMT { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_133
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
        /// School Type
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<SCT> SCT { get; set; }
        /// <summary>
        /// Placement Criteria
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<OPX> OPX { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Degree Record
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<DEG> DEG { get; set; }
        /// <summary>
        /// Institutional Staff Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<ISI> ISI { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<LQ> LQ { get; set; }
        /// <summary>
        /// Educational Fee Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<EDF> EDF { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(10)]
        public virtual List<Loop_N1_133_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_YNQ_133> YNQLoop { get; set; }
        /// <summary>
        /// Loop for Field of Study
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_FOS_133> FOSLoop { get; set; }
        /// <summary>
        /// Loop for Special Program
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_SP_133> SPLoop { get; set; }
        /// <summary>
        /// Loop for School Accreditation and Licensing
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_SLA_133> SLALoop { get; set; }
        /// <summary>
        /// Loop for School Enrollment Data
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_ENM_133> ENMLoop { get; set; }
        /// <summary>
        /// Loop for Student Activities and Awards
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_ATV_133> ATVLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_133
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
    public class Loop_N1_133_2
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
        /// Property Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PPA> PPA { get; set; }
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
    public class Loop_N1_133_3
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
    /// Loop for School Accreditation and Licensing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLA))]
    public class Loop_SLA_133
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// School Accreditation and Licensing
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SLA SLA { get; set; }
        /// <summary>
        /// Field of Study
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<FOS> FOS { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_N1_133_3 N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Special Program
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SP))]
    public class Loop_SP_133
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<NM1> NM1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Yes/No Question
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(YNQ))]
    public class Loop_YNQ_133
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PCT> PCT { get; set; }
    }
    
    /// <summary>
    /// Educational Institution Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "133")]
    public class TS133 : EdiMessage
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
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_N1_133> N1Loop { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual List<Loop_HL_133> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
