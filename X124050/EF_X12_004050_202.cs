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
    /// Loop for Amount and Settlement Method
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ASM))]
    public class Loop_ASM_202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Amount and Settlement Method
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ASM ASM { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Conditions Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CRC))]
    public class Loop_CRC_202
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
        /// Individual Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual IN1 IN1 { get; set; }
        /// <summary>
        /// Individual Name Structure Components
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(3)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Income
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<AIN> AIN { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(9)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Loop for Credit Score Model
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_SCM_202> SCMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Delivery Execution Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DEX))]
    public class Loop_DEX_202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery Execution Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DEX DEX { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(15)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CN1 CN1 { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Interest
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<INT> INT { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(6)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Mortgage Pool Program
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual MPP MPP { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(10)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Loop for Amount and Settlement Method
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_ASM_202> ASMLoop { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(12)]
        public virtual List<Loop_NM1_202> NM1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Insurer or Guarantor Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IGI))]
    public class Loop_IGI_202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Insurer or Guarantor Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IGI IGI { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<PCT> PCT { get; set; }
    }
    
    /// <summary>
    /// Loop for Loan Specific Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LN1))]
    public class Loop_LN1_202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loan Specific Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LN1 LN1 { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_202
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(7)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(8)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Loan Underwriting
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual LUC LUC { get; set; }
        /// <summary>
        /// Down Payment Data
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(10)]
        public virtual List<RLD> RLD { get; set; }
        /// <summary>
        /// Interest
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(11)]
        public virtual List<INT> INT { get; set; }
        /// <summary>
        /// Payment Pattern Details
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual PPD PPD { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(13)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Loan Buydown
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual BUY BUY { get; set; }
        /// <summary>
        /// Property or Housing Expense
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(15)]
        public virtual List<PEX> PEX { get; set; }
        /// <summary>
        /// Borrower Education Program
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(16)]
        public virtual List<BEP> BEP { get; set; }
        /// <summary>
        /// Loop for Insurer or Guarantor Information
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<Loop_IGI_202> IGILoop { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<Loop_NX1_202> NX1Loop { get; set; }
        /// <summary>
        /// Loop for Loan Specific Data
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(19)]
        public virtual List<Loop_LN1_202> LN1Loop { get; set; }
        /// <summary>
        /// Loop for Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<Loop_CRC_202> CRCLoop { get; set; }
        /// <summary>
        /// Loop for Period Amount
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(21)]
        public virtual List<Loop_PAM_202> PAMLoop { get; set; }
        /// <summary>
        /// Loop for Underwriting Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(22)]
        public virtual List<Loop_UWI_202> UWILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_202
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Extended Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_202
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
        /// Loop for Delivery Execution Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<Loop_DEX_202> DEXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_202
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
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<Loop_LX_202> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_202
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
        [ListCount(15)]
        [Pos(2)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Real Estate Property Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REA REA { get; set; }
        /// <summary>
        /// Property Description/Legal Description
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<PDS> PDS { get; set; }
    }
    
    /// <summary>
    /// Loop for Period Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAM))]
    public class Loop_PAM_202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAM PAM { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual REF REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Credit Score Model
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCM))]
    public class Loop_SCM_202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Credit Score Model
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SCM SCM { get; set; }
        /// <summary>
        /// Credit Score
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<SCS> SCS { get; set; }
    }
    
    /// <summary>
    /// Loop for Underwriting Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(UWI))]
    public class Loop_UWI_202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Underwriting Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual UWI UWI { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Secondary Mortgage Market Loan Delivery
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "202")]
    public class TS202 : EdiMessage
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
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_N1_202> N1Loop { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual List<Loop_N9_202> N9Loop { get; set; }
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual CTT CTT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
