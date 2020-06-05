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
    public class Loop_VC_121
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Delivery Logistics
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DEL DEL { get; set; }
        /// <summary>
        /// Charge
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CGS CGS { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REF REF { get; set; }
    }
    
    /// <summary>
    /// Vehicle Service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "121")]
    public class TS121 : EdiMessage
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
        /// Beginning Segment for Vehicle Service
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BVS BVS { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// Vessel Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual V1 V1 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Loop for Motor Vehicle Control
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(6)]
        public virtual List<Loop_VC_121> VCLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
