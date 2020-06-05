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
    public class Loop_AIN_200
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
        public virtual YNQ YNQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Monetary Amount Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_AMT_200
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
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Credit Counseling Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CCI))]
    public class Loop_CCI_200
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Credit Counseling Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CCI CCI { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(3)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_200
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
        [ListCount(10)]
        [Pos(2)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Quantity and Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N10 N10 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(8)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Credit Inquiry Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(INQ))]
    public class Loop_INQ_200
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
        /// Trade Line Bureau Identifier
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<TBI> TBI { get; set; }
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
        [ListCount(2)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(10)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_200
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
        /// Loop for Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<Loop_NTE_200> NTELoop { get; set; }
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
    public class Loop_LS_200_2
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
        /// Loop for Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_REF_200> REFLoop { get; set; }
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
    public class Loop_LX_200
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
        [Pos(2)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Loop for Individual Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(15)]
        [Pos(3)]
        public virtual List<Loop_IN1_200> IN1Loop { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<Loop_NX1_200> NX1Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<Loop_N1_200_2> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_200
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
        [ListCount(3)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
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
    public class Loop_N1_200_2
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
        [ListCount(4)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(9)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Source of Income
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public virtual List<Loop_SOI_200> SOILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_200_3
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
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_200_4
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
        [ListCount(2)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Employment Position
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(8)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Loop for Note/Special Instruction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NTE))]
    public class Loop_NTE_200
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NTE NTE { get; set; }
        /// <summary>
        /// Trade Line Bureau Identifier
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<TBI> TBI { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_200
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
        [ListCount(10)]
        [Pos(2)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Quantity and Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N10 N10 { get; set; }
        /// <summary>
        /// Applicant Residence Specifics
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ARS ARS { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(7)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_200_2
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
        [ListCount(10)]
        [Pos(2)]
        public virtual List<NX2> NX2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_200
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
        /// Survey Question Response
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<G32> G32 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual NTE NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Public Record or Obligation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RO))]
    public class Loop_RO_200
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Public Record or Obligation
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RO RO { get; set; }
        /// <summary>
        /// Case Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CDS CDS { get; set; }
        /// <summary>
        /// Trade Line Bureau Identifier
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<TBI> TBI { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(7)]
        public virtual List<Loop_AMT_200> AMTLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<Loop_N1_200_3> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Credit Score Model
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCM))]
    public class Loop_SCM_200
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
    /// Loop for Source of Income
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SOI))]
    public class Loop_SOI_200
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Source of Income
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SOI SOI { get; set; }
        /// <summary>
        /// Employment Position
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Quantity and Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N10 N10 { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        /// Loop for Income
        /// </summary>
        [DataMember]
        [ListCount(7)]
        [Pos(6)]
        public virtual List<Loop_AIN_200> AINLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Tradeline
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TLN))]
    public class Loop_TLN_200
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tradeline
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TLN TLN { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(7)]
        [Pos(8)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Trade Line Bureau Identifier
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<TBI> TBI { get; set; }
        /// <summary>
        /// Payment Pattern Details
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(10)]
        public virtual List<PPD> PPD { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(11)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(13)]
        public virtual List<Loop_AMT_200> AMTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Credit File Variation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VAR))]
    public class Loop_VAR_200
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Credit File Variation
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VAR VAR { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Individual Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual IN1 IN1 { get; set; }
        /// <summary>
        /// Individual Name Structure Components
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Quantity and Description
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N10 N10 { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<Loop_NX1_200_2> NX1Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_N1_200_4> N1Loop { get; set; }
        /// <summary>
        /// Loop for Credit Score Model
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_SCM_200> SCMLoop { get; set; }
    }
    
    /// <summary>
    /// Mortgage Credit Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "200")]
    public class TS200 : EdiMessage
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
        /// Credit Report Order Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual CRO CRO { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<AAA> AAA { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual NX1 NX1 { get; set; }
        /// <summary>
        /// Location ID Component
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(10)]
        public virtual List<Loop_N1_200> N1Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(11)]
        public virtual List<Loop_LX_200> LXLoop { get; set; }
        /// <summary>
        /// Loop for Tradeline
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(12)]
        public virtual List<Loop_TLN_200> TLNLoop { get; set; }
        /// <summary>
        /// Loop for Public Record or Obligation
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(13)]
        public virtual List<Loop_RO_200> ROLoop { get; set; }
        /// <summary>
        /// Loop for Credit Counseling Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(14)]
        public virtual List<Loop_CCI_200> CCILoop { get; set; }
        /// <summary>
        /// Loop for Credit Inquiry Details
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(15)]
        public virtual List<Loop_INQ_200> INQLoop { get; set; }
        /// <summary>
        /// Loop for Credit File Variation
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(16)]
        public virtual List<Loop_VAR_200> VARLoop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual Loop_LS_200 LSLoop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual Loop_LS_200_2 LSLoop2 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual SE SE { get; set; }
    }
}
