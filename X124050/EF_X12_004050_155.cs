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
    /// Loop for Activity or Process Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(API))]
    public class Loop_API_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Activity or Process Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual API API { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Case Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CDS CDS { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Legal Claims
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<BBC> BBC { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Asset Ownership
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<ASO> ASO { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_LM_155_2> LMLoop { get; set; }
        /// <summary>
        /// Loop for Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_CRC_155> CRCLoop { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_NM1_155_3> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Administration of Justice Event Description
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_CED_155> CEDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Administration of Justice Event Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CED))]
    public class Loop_CED_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Administration of Justice Event Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CED CED { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_LM_155_3> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Conditions Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CRC))]
    public class Loop_CRC_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CRC CRC { get; set; }
        /// <summary>
        /// Amount with Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AWD> AWD { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_155
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
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual LUI LUI { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_NM1_155> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_NX1_155> NX1Loop { get; set; }
        /// <summary>
        /// Loop for Information Request
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_INR_155> INRLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_155
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
        [Pos(2)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        /// Business Professional Title
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<TPB> TPB { get; set; }
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
        /// Location ID Component
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<NX2> NX2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Credit Inquiry Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(INQ))]
    public class Loop_INQ_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Credit Inquiry Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual INQ INQ { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Historical Payment Terms
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PYT> PYT { get; set; }
        /// <summary>
        /// Payment Manner and Percentage
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PYM> PYM { get; set; }
        /// <summary>
        /// Amount with Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<AWD> AWD { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Account Description
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<ACD> ACD { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Supplier Rating
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<SPR> SPR { get; set; }
        /// <summary>
        /// Asset Ownership
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<ASO> ASO { get; set; }
    }
    
    /// <summary>
    /// Loop for Information Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(INR))]
    public class Loop_INR_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Request
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual INR INR { get; set; }
        /// <summary>
        /// Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NX1 NX1 { get; set; }
        /// <summary>
        /// Information Type and Comment Results
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<ITC> ITC { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Asset Ownership
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<ASO> ASO { get; set; }
        /// <summary>
        /// Supplier Rating
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<SPR> SPR { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Employment Position
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        /// Territory
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<TER> TER { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Action or Status Indicator
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual ASI ASI { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Loop for Credit Inquiry Details
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<Loop_INQ_155> INQLoop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<Loop_LX_155> LXLoop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual List<Loop_LM_155> LMLoop { get; set; }
        /// <summary>
        /// Loop for Request Information
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<Loop_REQ_155_2> REQLoop { get; set; }
        /// <summary>
        /// Loop for Activity or Process Information
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual List<Loop_API_155> APILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_LX_155_2> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_155_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<III> III { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_155_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_155
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
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual NX1 NX1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Business Professional Title
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(5)]
        public virtual List<TPB> TPB { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Location ID Component
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Communication Contact Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Amount with Description
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<AWD> AWD { get; set; }
        /// <summary>
        /// Asset Ownership
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<ASO> ASO { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_155_2
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
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<LQ> LQ { get; set; }
        /// <summary>
        /// Amount with Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<AWD> AWD { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_NM1_155_2> NM1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_155
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
        /// Location ID Component
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_155
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
        /// Business Professional Title
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<TPB> TPB { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_155_2
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
        /// Business Professional Title
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(3)]
        public virtual List<TPB> TPB { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_155_3
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
        /// Business Professional Title
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(3)]
        public virtual List<TPB> TPB { get; set; }
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
        /// Location ID Component
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Communication Contact Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Information Type and Comment Results
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ITC ITC { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Amount with Description
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<AWD> AWD { get; set; }
        /// <summary>
        /// Loop for Individual Identification
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_IN1_155> IN1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_155
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
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Location ID Component
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Communication Contact Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Loop for Request Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_REQ_155> REQLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Request Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REQ))]
    public class Loop_REQ_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Request Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REQ REQ { get; set; }
        /// <summary>
        /// Location Description
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<LOD> LOD { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Facility Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<FDA> FDA { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Amount with Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<AWD> AWD { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(11)]
        public virtual List<N2> N2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Request Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REQ))]
    public class Loop_REQ_155_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Request Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REQ REQ { get; set; }
        /// <summary>
        /// Amount with Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AWD> AWD { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    /// <summary>
    /// Business Credit Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "155")]
    public class TS155 : EdiMessage
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
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<Loop_N1_155> N1Loop { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_HL_155> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
