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
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_285
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
        public virtual LQ LQ { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Additional Demographic Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DMA DMA { get; set; }
        /// <summary>
        /// Dynamic Vehicle Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<DVI> DVI { get; set; }
        /// <summary>
        /// Vehicle Detail
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual VC1 VC1 { get; set; }
        /// <summary>
        /// Vehicle Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual VEH VEH { get; set; }
        /// <summary>
        /// Equipment Environment
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual N12 N12 { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_NM1_285> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual Loop_LS_285 LSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_285_2
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
        public virtual LQ LQ { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PCT PCT { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Supplier Rating
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SPR SPR { get; set; }
        /// <summary>
        /// Test Scores
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SRE SRE { get; set; }
        /// <summary>
        /// Statistics
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<STA> STA { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual MEA MEA { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Commodity
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_TC2_285> TC2Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_285
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
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_LM_285_2> LMLoop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Geographic Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N4))]
    public class Loop_N4_285
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_285
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
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_285
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
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_LM_285> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Commodity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TC2))]
    public class Loop_TC2_285
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Commodity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TC2 TC2 { get; set; }
        /// <summary>
        /// Hazardous Material
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual H1 H1 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Loop for Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_N4_285> N4Loop { get; set; }
    }
    
    /// <summary>
    /// Commercial Vehicle Safety and Credentials Information Exchange
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "285")]
    public class TS285 : EdiMessage
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
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<NM1> NM1 { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_NX1_285> NX1Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
