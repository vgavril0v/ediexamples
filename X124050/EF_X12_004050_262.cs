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
    public class Loop_III_262
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
        /// Message Text
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_262
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
        [Required]
        [ListCount(10)]
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
        [Pos(5)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<Loop_YNQ_262> YNQLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Existing Real Estate Loan Specific Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LN2))]
    public class Loop_LN2_262
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Existing Real Estate Loan Specific Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LN2 LN2 { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Industry Code Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_262
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(7)]
        [Pos(5)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Income
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(8)]
        public virtual List<AIN> AIN { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<III> III { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_262
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
        /// Informational Values
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AM1> AM1 { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Specification Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<SPI> SPI { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual List<Loop_NX1_262> NX1Loop { get; set; }
        /// <summary>
        /// Loop for Individual Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_IN1_262> IN1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MEA))]
    public class Loop_MEA_262
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MEA MEA { get; set; }
        /// <summary>
        /// Activity or Process Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual API API { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_262
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
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_262
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
        /// Location ID Component
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Property Description/Legal Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PDS> PDS { get; set; }
        /// <summary>
        /// Property Metes and Bounds Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<PDE> PDE { get; set; }
        /// <summary>
        /// Real Estate Property Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REA REA { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(7)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(8)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(43)]
        [Pos(9)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(12)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Real Estate Condition
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual REC REC { get; set; }
        /// <summary>
        /// Loop for Measurements
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_MEA_262> MEALoop { get; set; }
        /// <summary>
        /// Loop for Information
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_III_262> IIILoop { get; set; }
        /// <summary>
        /// Loop for Property or Housing Expense
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_PEX_262> PEXLoop { get; set; }
        /// <summary>
        /// Loop for Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<Loop_LQ_262> LQLoop { get; set; }
        /// <summary>
        /// Loop for Real Estate Transaction
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<Loop_RET_262> RETLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Housing Expense
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PEX))]
    public class Loop_PEX_262
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Property or Housing Expense
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PEX PEX { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<III> III { get; set; }
    }
    
    /// <summary>
    /// Loop for Real Estate Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RET))]
    public class Loop_RET_262
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Real Estate Transaction
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RET RET { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Property Transaction Financials
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<PTF> PTF { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_NM1_262> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Existing Real Estate Loan Specific Data
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_LN2_262> LN2Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Yes/No Question
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(YNQ))]
    public class Loop_YNQ_262
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Loop for Information
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(4)]
        public virtual List<Loop_III_262> IIILoop { get; set; }
    }
    
    /// <summary>
    /// Real Estate Information Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "262")]
    public class TS262 : EdiMessage
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
        /// Trace
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TRN TRN { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<Loop_NM1_262> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual List<Loop_LX_262> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
