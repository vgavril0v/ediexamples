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
    /// Loop for Entity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENT))]
    public class Loop_ENT_191
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
        [ListCount(3)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Additional Demographic Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual DMA DMA { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(8)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// School Enrollment Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ENR ENR { get; set; }
        /// <summary>
        /// Loop for Individual Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<Loop_IN1_191> IN1Loop { get; set; }
        /// <summary>
        /// Loop for Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(100)]
        [Pos(12)]
        public virtual List<Loop_REF_191> REFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_191
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
        [ListCount(5)]
        [Pos(2)]
        public virtual List<IN2> IN2 { get; set; }
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
        [ListCount(2)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<YNQ> YNQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_191_2
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
        [ListCount(5)]
        [Pos(2)]
        public virtual List<IN2> IN2 { get; set; }
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
        [ListCount(2)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<YNQ> YNQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_191
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Specific Loan Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SLI SLI { get; set; }
        /// <summary>
        /// Guarantee Result Detail
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual GR GR { get; set; }
        /// <summary>
        /// Delayed Repayment
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(4)]
        public virtual List<DEF> DEF { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(5)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Disbursement Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<DB> DB { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(7)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(8)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Loop for Individual Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_IN1_191_2> IN1Loop { get; set; }
    }
    
    /// <summary>
    /// Student Loan Pre-Claims and Claims
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "191")]
    public class TS191 : EdiMessage
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
        /// Loop for Entity
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<Loop_ENT_191> ENTLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
