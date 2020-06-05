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
    /// Loop for Item Detail Dimensions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ID1))]
    public class Loop_ID1_896
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Detail Dimensions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ID1 ID1 { get; set; }
        /// <summary>
        /// Item Image Detail
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ID2 ID2 { get; set; }
        /// <summary>
        /// Dimensions Detail
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(3)]
        public virtual List<ID3> ID3 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_896
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
        [Pos(3)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
    }
    
    /// <summary>
    /// Product Dimension Maintenance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "896")]
    public class TS896 : EdiMessage
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
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Loop_N1_896> N1Loop { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Promotion/Price List Area
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(7)]
        public virtual List<G43> G43 { get; set; }
        /// <summary>
        /// Loop for Item Detail Dimensions
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(8)]
        public virtual List<Loop_ID1_896> ID1Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SE SE { get; set; }
    }
}
