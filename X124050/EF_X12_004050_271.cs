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
    /// Loop for Eligibility or Benefit Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EB))]
    public class Loop_EB_271
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Eligibility or Benefit Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EB EB { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<HSD> HSD { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<AAA> AAA { get; set; }
        /// <summary>
        /// Vehicle Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual VEH VEH { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PID PID { get; set; }
        /// <summary>
        /// Property Description - Real
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual PDR PDR { get; set; }
        /// <summary>
        /// Property Description - Personal
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual PDP PDP { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Equipment Characteristics
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual EM EM { get; set; }
        /// <summary>
        /// Safety Data
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual SD1 SD1 { get; set; }
        /// <summary>
        /// Packaging Description
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual PKD PKD { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(14)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Information
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_III_271> IIILoop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual Loop_LS_271 LSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_271
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
        /// Request Validation
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<AAA> AAA { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_NM1_271> NM1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(III))]
    public class Loop_III_271
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual III III { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Loop for Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_LQ_271> LQLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Industry Code Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_271
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
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<PCT> PCT { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_271
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
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_NM1_271_2> NM1Loop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_271
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
        /// Request Validation
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<AAA> AAA { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual PRV PRV { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Insured Benefit
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual INS INS { get; set; }
        /// <summary>
        /// Health Care Information Codes
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual HI HI { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(12)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(13)]
        public virtual List<LUI> LUI { get; set; }
        /// <summary>
        /// Military Personnel Information
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(14)]
        public virtual List<MPI> MPI { get; set; }
        /// <summary>
        /// Loop for Eligibility or Benefit Information
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_EB_271> EBLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_271_2
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
        [ListCount(3)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PRV PRV { get; set; }
    }
    
    /// <summary>
    /// Eligibility, Coverage or Benefit Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "271")]
    public class TS271 : EdiMessage
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
        public virtual List<Loop_HL_271> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
