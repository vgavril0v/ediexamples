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
    /// Loop for Date/Time
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G62))]
    public class Loop_G62_120
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G62 G62 { get; set; }
        /// <summary>
        /// Loop for Motor Vehicle Control
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<Loop_VC_120> VCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Motor Vehicle Control
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VC))]
    public class Loop_VC_120
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Motor Vehicle Control
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VC VC { get; set; }
        /// <summary>
        /// Vehicle Detail
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual VC1 VC1 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual REF REF { get; set; }
    }
    
    /// <summary>
    /// Vehicle Shipping Order
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "120")]
    public class TS120 : EdiMessage
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
        /// Beginning Segment for Vehicle Shipping Order
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BVP BVP { get; set; }
        /// <summary>
        /// Loop for Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<Loop_G62_120> G62Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
