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
    /// Loop for Motor Vehicle Control
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VC))]
    public class Loop_VC_928
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
        /// Inspection Detail Segment
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<ID> ID { get; set; }
    }
    
    /// <summary>
    /// Automotive Inspection Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "928")]
    public class TS928 : EdiMessage
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
        /// Beginning Segment for Automotive Inspection
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BIX BIX { get; set; }
        /// <summary>
        /// Transport Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TI TI { get; set; }
        /// <summary>
        /// Loop for Motor Vehicle Control
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(36)]
        [Pos(4)]
        public virtual List<Loop_VC_928> VCLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
