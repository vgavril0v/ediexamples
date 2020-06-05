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
    /// Loop for Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(III))]
    public class Loop_III_272
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
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Loop for Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_LQ_272_2> LQLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Administrative Message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(K2))]
    public class Loop_K2_272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Administrative Message
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual K2 K2 { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Individual or Event Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual LIE LIE { get; set; }
    }
    
    /// <summary>
    /// Loop for Loss Information Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LID))]
    public class Loop_LID_272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loss Information Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LID LID { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Basic Claim Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual BCI BCI { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<SI> SI { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Loop for Individual or Event Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<Loop_LIE_272> LIELoop { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_N9_272> N9Loop { get; set; }
        /// <summary>
        /// Loop for Paperwork
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_PWK_272> PWKLoop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual Loop_LS_272 LSLoop { get; set; }
        /// <summary>
        /// Loop for Reference Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_REF_272> REFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Event Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIE))]
    public class Loop_LIE_272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual or Event Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIE LIE { get; set; }
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
    }
    
    /// <summary>
    /// Loop for Individual or Event Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIE))]
    public class Loop_LIE_272_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual or Event Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIE LIE { get; set; }
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
    /// Loop for Industry Code Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_272
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
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_LS_272_3 LSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Industry Code Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_272_2
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
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_272
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
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Loop_NM1_272_2> NM1Loop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_272_2
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
        /// Loop for Administrative Message
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_K2_272> K2Loop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_272_3
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
        /// Loop for Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_LQ_272_2> LQLoop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_272_4
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
        public virtual List<Loop_NM1_272_3> NM1Loop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_272
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
        /// Property Description - Real
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PDR PDR { get; set; }
        /// <summary>
        /// Property Description - Personal
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PDP PDP { get; set; }
        /// <summary>
        /// Administrative Message
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual K2 K2 { get; set; }
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
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Individual or Event Location
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual LIE LIE { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Equipment Characteristics
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual EM EM { get; set; }
        /// <summary>
        /// Safety Data
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual SD1 SD1 { get; set; }
        /// <summary>
        /// Packaging Description
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual PKD PKD { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual K1 K1 { get; set; }
        /// <summary>
        /// Vessel Identification
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual V1 V1 { get; set; }
        /// <summary>
        /// Route Information (Air)
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual R1 R1 { get; set; }
        /// <summary>
        /// Port or Terminal
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(16)]
        public virtual List<R4> R4 { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual Loop_LS_272_2 LSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Extended Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_272
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
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_272
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
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_272_2
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
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Loop for Individual or Event Location
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_LIE_272 LIELoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_272_3
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
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Individual Characteristics
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual ICH ICH { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        /// Basic Claim Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual BCI BCI { get; set; }
        /// <summary>
        /// Loop for Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_III_272> IIILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_272
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
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N2> N2 { get; set; }
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
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Individual Characteristics
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual ICH ICH { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        /// Basic Claim Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual BCI BCI { get; set; }
        /// <summary>
        /// Loop for Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_LQ_272> LQLoop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual Loop_LS_272_4 LSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Previous Incident
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PIN))]
    public class Loop_PIN_272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Previous Incident
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PIN PIN { get; set; }
        /// <summary>
        /// Basic Claim Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BCI BCI { get; set; }
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
        /// Loop for Paperwork
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_PWK_272> PWKLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Paperwork
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PWK))]
    public class Loop_PWK_272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PWK PWK { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PER PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_272
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
        /// Loop for Vehicle Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_VEH_272 VEHLoop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_LX_272> LXLoop { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_NX1_272> NX1Loop { get; set; }
        /// <summary>
        /// Loop for Previous Incident
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_PIN_272> PINLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Vehicle Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VEH))]
    public class Loop_VEH_272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Vehicle Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VEH VEH { get; set; }
        /// <summary>
        /// Vehicle Attribute
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<VAT> VAT { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Dynamic Vehicle Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DVI DVI { get; set; }
        /// <summary>
        /// Vehicle Recovery
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual VRC VRC { get; set; }
        /// <summary>
        /// Damage Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<DAM> DAM { get; set; }
        /// <summary>
        /// Loop for Individual or Event Location
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_LIE_272_2> LIELoop { get; set; }
    }
    
    /// <summary>
    /// Property and Casualty Loss Notification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "272")]
    public class TS272 : EdiMessage
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
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_N9_272> N9Loop { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(5)]
        public virtual List<Loop_NM1_272> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Loss Information Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual List<Loop_LID_272> LIDLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
