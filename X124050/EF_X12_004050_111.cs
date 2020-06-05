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
    /// Loop for Informational Values
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AM1))]
    public class Loop_AM1_111
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
        /// Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Status of Product or Activity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<SPA> SPA { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Rate Amounts or Percents
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<RPA> RPA { get; set; }
        /// <summary>
        /// Balance Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<BLN> BLN { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_111
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
        /// Action or Status Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<ASI> ASI { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<LQ> LQ { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual LUI LUI { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<N4> N4 { get; set; }
        /// <summary>
        /// Basic Baseline Item Data
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual BLI BLI { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Underwriting Condition
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<UDA> UDA { get; set; }
        /// <summary>
        /// Status of Product or Activity
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<SPA> SPA { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Balance Information
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<BLN> BLN { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Rate Amounts or Percents
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<RPA> RPA { get; set; }
        /// <summary>
        /// Loop for Payment Details
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<Loop_PDL_111> PDLLoop { get; set; }
        /// <summary>
        /// Loop for Information
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual List<Loop_III_111> IIILoop { get; set; }
        /// <summary>
        /// Loop for Informational Values
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<Loop_AM1_111> AM1Loop { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual List<Loop_NM1_111_2> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual List<Loop_NX1_111> NX1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(III))]
    public class Loop_III_111
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
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N3))]
    public class Loop_N3_111
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
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_111
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
    public class Loop_NM1_111_2
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
        /// Communication Contact Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        /// Loop for Party Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_N3_111> N3Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_111
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Property or Entity Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NX1 NX1 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Beneficiary or Owner Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual BEN BEN { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Informational Values
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<AM1> AM1 { get; set; }
        /// <summary>
        /// Individual Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<IN1> IN1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Payment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PDL))]
    public class Loop_PDL_111
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
    /// Individual Insurance Policy and Client Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "111")]
    public class TS111 : EdiMessage
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
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_NM1_111> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_HL_111> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
