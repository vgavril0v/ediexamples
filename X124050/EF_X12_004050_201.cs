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
    /// Loop for Income
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AIN))]
    public class Loop_AIN_201
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Income
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AIN AIN { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<YNQ> YNQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Monetary Amount Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_AMT_201
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
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MSG MSG { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PCT> PCT { get; set; }
    }
    
    /// <summary>
    /// Loop for Monetary Amount Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_AMT_201_2
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
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MSG MSG { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual YNQ YNQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Consumer Credit Account
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CDA))]
    public class Loop_CDA_201
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Consumer Credit Account
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CDA CDA { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<CRC> CRC { get; set; }
    }
    
    /// <summary>
    /// Loop for Financial Asset Account
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FAA))]
    public class Loop_FAA_201
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Financial Asset Account
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FAA FAA { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual MSG MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_201
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
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(19)]
        [Pos(3)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Quantity and Description
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual N10 N10 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual MSG MSG { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// First Time Home Buyer
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual FTH FTH { get; set; }
        /// <summary>
        /// Personal Property Description
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(13)]
        public virtual List<PPY> PPY { get; set; }
        /// <summary>
        /// Loop for Income
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_AIN_201> AINLoop { get; set; }
        /// <summary>
        /// Loop for Property or Housing Expense
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(15)]
        public virtual List<Loop_PEX_201> PEXLoop { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(16)]
        public virtual List<Loop_NX1_201_2> NX1Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(17)]
        public virtual List<Loop_N1_201_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Real Estate Property Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(18)]
        public virtual List<Loop_REA_201> REALoop { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(19)]
        public virtual List<Loop_NM1_201> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Consumer Credit Account
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(20)]
        public virtual List<Loop_CDA_201> CDALoop { get; set; }
        /// <summary>
        /// Loop for Financial Asset Account
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(21)]
        public virtual List<Loop_FAA_201> FAALoop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual Loop_LS_201 LSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Mortgage Characteristics Requested
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LRQ))]
    public class Loop_LRQ_201
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Mortgage Characteristics Requested
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LRQ LRQ { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Real Estate Sales Price Change
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<RES> RES { get; set; }
        /// <summary>
        /// Mortgage Closing Data
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual MCD MCD { get; set; }
        /// <summary>
        /// Status of Mortgage
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual SOM SOM { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Borrower Education Program
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual BEP BEP { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(14)]
        public virtual List<Loop_NX1_201> NX1Loop { get; set; }
        /// <summary>
        /// Loop for Property or Housing Expense
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(15)]
        public virtual List<Loop_PEX_201> PEXLoop { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_AMT_201> AMTLoop { get; set; }
        /// <summary>
        /// Loop for Individual Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(15)]
        [Pos(17)]
        public virtual List<Loop_IN1_201> IN1Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(18)]
        public virtual List<Loop_LX_201> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_201
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
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Loop_AMT_201_2> AMTLoop { get; set; }
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
    public class Loop_LX_201
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
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual DTP DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_201
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_201_2
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        /// Employment Position
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual AMT AMT { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_201
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
        /// Account Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<ACT> ACT { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_201
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
        [ListCount(30)]
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
        [ListCount(10)]
        [Pos(4)]
        public virtual List<PDS> PDS { get; set; }
        /// <summary>
        /// Property Metes and Bounds Description
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(5)]
        public virtual List<PDE> PDE { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<YNQ> YNQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_201_2
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
        [ListCount(30)]
        [Pos(2)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Quantity and Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N10 N10 { get; set; }
        /// <summary>
        /// Applicant Residence Specifics
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ARS ARS { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Housing Expense
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PEX))]
    public class Loop_PEX_201
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
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MSG MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Real Estate Property Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REA))]
    public class Loop_REA_201
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Real Estate Property Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REA REA { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(6)]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Property or Entity Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual NX1 NX1 { get; set; }
        /// <summary>
        /// Location ID Component
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(30)]
        [Pos(4)]
        public virtual List<NX2> NX2 { get; set; }
    }
    
    /// <summary>
    /// Residential Loan Application
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "201")]
    public class TS201 : EdiMessage
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
        [ListCount(5)]
        [Pos(3)]
        public virtual List<Loop_N1_201> N1Loop { get; set; }
        /// <summary>
        /// Loop for Mortgage Characteristics Requested
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_LRQ_201> LRQLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
