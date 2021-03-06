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
    /// Loop for Monetary Amount Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_AMT_284
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_284
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
        /// Paperwork
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PWK PWK { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Commodity
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual TC2 TC2 { get; set; }
        /// <summary>
        /// Hazardous Material
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual H1 H1 { get; set; }
        /// <summary>
        /// Hazardous Classification Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual LH2 LH2 { get; set; }
        /// <summary>
        /// Hazardous Material Shipping Name
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual LH3 LH3 { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Loop for Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_LQ_284> LQLoop { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_NM1_284_2> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Text
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_MTX_284> MTXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Event Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIE))]
    public class Loop_LIE_284
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
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MEA MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for Industry Code Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_284
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
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Location Description
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual LOD LOD { get; set; }
        /// <summary>
        /// Test Scores
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SRE SRE { get; set; }
        /// <summary>
        /// Vehicle Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual VEH VEH { get; set; }
        /// <summary>
        /// Dynamic Vehicle Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<DVI> DVI { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_AMT_284> AMTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MTX))]
    public class Loop_MTX_284
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MTX MTX { get; set; }
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
    public class Loop_NM1_284
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
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_284_2
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
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Employment Position
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<DMG> DMG { get; set; }
        /// <summary>
        /// Additional Demographic Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual DMA DMA { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Loop for Individual or Event Location
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_LIE_284> LIELoop { get; set; }
    }
    
    /// <summary>
    /// Commercial Vehicle Safety Reports
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "284")]
    public class TS284 : EdiMessage
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
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_NM1_284> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_HL_284> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
