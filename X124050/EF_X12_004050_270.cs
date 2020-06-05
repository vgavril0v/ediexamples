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
    /// Loop for Eligibility or Benefit Inquiry
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EQ))]
    public class Loop_EQ_270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Eligibility or Benefit Inquiry
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EQ EQ { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Vehicle Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual VEH VEH { get; set; }
        /// <summary>
        /// Property Description - Real
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PDR PDR { get; set; }
        /// <summary>
        /// Property Description - Personal
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PDP PDP { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(8)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_270
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
        /// Trace
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<TRN> TRN { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_NM1_270> NM1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_270
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
        [ListCount(9)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N2 N2 { get; set; }
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PRV PRV { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Insured Benefit
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual INS INS { get; set; }
        /// <summary>
        /// Health Care Information Codes
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual HI HI { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(11)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Military Personnel Information
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(12)]
        public virtual List<MPI> MPI { get; set; }
        /// <summary>
        /// Loop for Eligibility or Benefit Inquiry
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(13)]
        public virtual List<Loop_EQ_270> EQLoop { get; set; }
    }
    
    /// <summary>
    /// Eligibility, Coverage or Benefit Inquiry
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "270")]
    public class TS270 : EdiMessage
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
        /// Beginning of Hierarchical Transaction
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BHT BHT { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_HL_270> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
