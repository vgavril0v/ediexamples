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
    /// Loop for Monetary Amount Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_AMT_190
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
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual LQ LQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Degree Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DEG))]
    public class Loop_DEG_190
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
        [ListCount(2)]
        [Pos(2)]
        public virtual List<FOS> FOS { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Entity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENT))]
    public class Loop_ENT_190
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
        /// Individual Name Structure Components
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DMG DMG { get; set; }
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
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_190
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Academic Session Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SES))]
    public class Loop_SES_190
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
        /// Academic Summary
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(2)]
        public virtual List<SUM> SUM { get; set; }
        /// <summary>
        /// School Enrollment Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ENR ENR { get; set; }
        /// <summary>
        /// Field of Study
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<FOS> FOS { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(5)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Student Enrollment Verification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "190")]
    public class TS190 : EdiMessage
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
        /// School Enrollment Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ENR ENR { get; set; }
        /// <summary>
        /// Educational Record Purpose
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ERP ERP { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Student Academic Status
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SST SST { get; set; }
        /// <summary>
        /// Academic Summary
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(7)]
        public virtual List<SUM> SUM { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_AMT_190> AMTLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(10)]
        public virtual List<Loop_N1_190> N1Loop { get; set; }
        /// <summary>
        /// Loop for Entity
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(11)]
        public virtual List<Loop_ENT_190> ENTLoop { get; set; }
        /// <summary>
        /// Loop for Academic Session Header
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(12)]
        public virtual List<Loop_SES_190> SESLoop { get; set; }
        /// <summary>
        /// Loop for Degree Record
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(13)]
        public virtual List<Loop_DEG_190> DEGLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual SE SE2 { get; set; }
    }
}
