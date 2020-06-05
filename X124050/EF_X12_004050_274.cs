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
    /// Loop for Employment Position
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EMS))]
    public class Loop_EMS_274
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
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_274
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
        [Pos(2)]
        public virtual TRN TRN { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_NM1_274> NM1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Health Care Provider License
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HPL))]
    public class Loop_HPL_274
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Health Care Provider License
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HPL HPL { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Industry Code Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_274
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
        /// Party Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Business Professional Title
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<TPB> TPB { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<YNQ> YNQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_274
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
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Activity or Process Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<API> API { get; set; }
        /// <summary>
        /// Degree Record
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<DEG> DEG { get; set; }
        /// <summary>
        /// Additional Individual Demographic Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual IND IND { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(9)]
        public virtual List<LUI> LUI { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(10)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(12)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Work Schedule
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(13)]
        public virtual List<WS> WS { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(14)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(15)]
        public virtual List<HSD> HSD { get; set; }
        /// <summary>
        /// Basic Claim Information
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(16)]
        public virtual List<BCI> BCI { get; set; }
        /// <summary>
        /// Practice Detail Information
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual PDI PDI { get; set; }
        /// <summary>
        /// Hospital Affiliation Detail
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual HAD HAD { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual List<Loop_NX1_274> NX1Loop { get; set; }
        /// <summary>
        /// Loop for Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<Loop_LQ_274> LQLoop { get; set; }
        /// <summary>
        /// Loop for Health Care Provider License
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(21)]
        public virtual List<Loop_HPL_274> HPLLoop { get; set; }
        /// <summary>
        /// Loop for Reference Information
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual List<Loop_REF_274> REFLoop { get; set; }
        /// <summary>
        /// Loop for Employment Position
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(23)]
        public virtual List<Loop_EMS_274> EMSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_274
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
    /// Loop for Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_274
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
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Healthcare Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "274")]
    public class TS274 : EdiMessage
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual List<Loop_HL_274> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
