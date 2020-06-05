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
    /// Loop for Transaction Set Grouping
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(E10))]
    public class Loop_E10_868
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Grouping
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual E10 E10 { get; set; }
        /// <summary>
        /// Segment Order in Transaction Set
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(2)]
        public virtual List<E13> E13 { get; set; }
    }
    
    /// <summary>
    /// Loop for Segment Header Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(E20))]
    public class Loop_E20_868
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Segment Header Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual E20 E20 { get; set; }
        /// <summary>
        /// Data Element Relationships in a Segment or Composite
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<E22> E22 { get; set; }
        /// <summary>
        /// Data Element Sequence in a Segment or Composite
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(3)]
        public virtual List<E24> E24 { get; set; }
    }
    
    /// <summary>
    /// Loop for Data Element Attributes
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(E30))]
    public class Loop_E30_868
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Data Element Attributes
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual E30 E30 { get; set; }
        /// <summary>
        /// Appendix Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<DAI> DAI { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Loop for Code List Values for a Data Element
        /// </summary>
        [DataMember]
        [ListCount(100000)]
        [Pos(4)]
        public virtual List<Loop_E34_868> E34Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Code List Values for a Data Element
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(E34))]
    public class Loop_E34_868
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code List Values for a Data Element
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual E34 E34 { get; set; }
        /// <summary>
        /// Explanation
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<DDI> DDI { get; set; }
        /// <summary>
        /// Appendix Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DAI> DAI { get; set; }
    }
    
    /// <summary>
    /// Loop for EDI Standards Note Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(E40))]
    public class Loop_E40_868
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// EDI Standards Note Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual E40 E40 { get; set; }
        /// <summary>
        /// Data Maintenance Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<DMI> DMI { get; set; }
        /// <summary>
        /// Explanation
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(3)]
        public virtual List<DDI> DDI { get; set; }
    }
    
    /// <summary>
    /// Loop for Composite Header Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(E41))]
    public class Loop_E41_868
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Composite Header Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual E41 E41 { get; set; }
        /// <summary>
        /// Data Element Relationships in a Segment or Composite
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<E22> E22 { get; set; }
        /// <summary>
        /// Data Element Sequence in a Segment or Composite
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(3)]
        public virtual List<E24> E24 { get; set; }
    }
    
    /// <summary>
    /// Electronic Form Structure
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "868")]
    public class TS868 : EdiMessage
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
        /// Electronic Form Main Heading
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual E01 E01 { get; set; }
        /// <summary>
        /// Data Maintenance Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(3)]
        public virtual List<DMI> DMI { get; set; }
        /// <summary>
        /// Interchange Order of Segments
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(4)]
        public virtual List<E03> E03 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(5)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Transaction Set Grouping
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(6)]
        public virtual List<Loop_E10_868> E10Loop { get; set; }
        /// <summary>
        /// Loop for Segment Header Information
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(7)]
        public virtual List<Loop_E20_868> E20Loop { get; set; }
        /// <summary>
        /// Loop for Composite Header Information
        /// </summary>
        [DataMember]
        [ListCount(2000)]
        [Pos(8)]
        public virtual List<Loop_E41_868> E41Loop { get; set; }
        /// <summary>
        /// Loop for Data Element Attributes
        /// </summary>
        [DataMember]
        [ListCount(2000)]
        [Pos(9)]
        public virtual List<Loop_E30_868> E30Loop { get; set; }
        /// <summary>
        /// Loop for EDI Standards Note Reference
        /// </summary>
        [DataMember]
        [ListCount(10000)]
        [Pos(10)]
        public virtual List<Loop_E40_868> E40Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual SE SE { get; set; }
    }
}
