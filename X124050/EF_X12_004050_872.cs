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
    /// Loop for Change Detail Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CDI))]
    public class Loop_CDI_872
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Change Detail Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CDI CDI { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_LX_872> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_872
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
        [ListCount(5)]
        [Pos(3)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual MSG MSG { get; set; }
        /// <summary>
        /// Quantity and Description
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N10 N10 { get; set; }
        /// <summary>
        /// Borrower Financial Summary
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual BFS BFS { get; set; }
        /// <summary>
        /// Loop for Credit Score Model
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<Loop_SCM_872> SCMLoop { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_NX1_872_2> NX1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Mortgage Characteristics Requested
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LRQ))]
    public class Loop_LRQ_872
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
        /// Loan Specific Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual LN1 LN1 { get; set; }
        /// <summary>
        /// Mortgage Loan Product Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PRD PRD { get; set; }
        /// <summary>
        /// Mortgage Insurance Coverage
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<MIC> MIC { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Property or Housing Expense
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(7)]
        public virtual List<PEX> PEX { get; set; }
        /// <summary>
        /// Real Estate Sales Price Change
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<RES> RES { get; set; }
        /// <summary>
        /// Loop for Change Detail Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_CDI_872> CDILoop { get; set; }
        /// <summary>
        /// Loop for Credit Score Model
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<Loop_SCM_872> SCMLoop { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(11)]
        public virtual List<Loop_NX1_872> NX1Loop { get; set; }
        /// <summary>
        /// Loop for Individual Identification
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(12)]
        public virtual List<Loop_IN1_872> IN1Loop { get; set; }
        /// <summary>
        /// Loop for Real Estate Property Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual Loop_REA_872 REALoop { get; set; }
        /// <summary>
        /// Loop for Mortgage Closing Data
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual Loop_MCD_872 MCDLoop { get; set; }
        /// <summary>
        /// Loop for Multifamily Housing Project
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual Loop_PRJ_872 PRJLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_872
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
        /// Value Description or Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<VDI> VDI { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<AMT> AMT { get; set; }
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
        /// Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Loan Buydown
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual BUY BUY { get; set; }
    }
    
    /// <summary>
    /// Loop for Mortgage Closing Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MCD))]
    public class Loop_MCD_872
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Mortgage Closing Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MCD MCD { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_872
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
        [ListCount(12)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Mortgage Characteristics Requested
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_LRQ_872> LRQLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_872
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
        /// Loop for Property Appraisal Summary
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<Loop_PAS_872> PASLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_872_2
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
    }
    
    /// <summary>
    /// Loop for Property Appraisal Summary
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAS))]
    public class Loop_PAS_872
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Property Appraisal Summary
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAS PAS { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_REF_872> REFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Multifamily Housing Project
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PRJ))]
    public class Loop_PRJ_872
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Multifamily Housing Project
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PRJ PRJ { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Real Estate Property Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REA))]
    public class Loop_REA_872
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
        [ListCount(10)]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_872
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
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
    }
    
    /// <summary>
    /// Loop for Credit Score Model
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCM))]
    public class Loop_SCM_872
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
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP DTP { get; set; }
    }
    
    /// <summary>
    /// Residential Mortgage Insurance Application
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "872")]
    public class TS872 : EdiMessage
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
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_NM1_872> NM1Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
