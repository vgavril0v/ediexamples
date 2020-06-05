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
    /// Booking Cancellation (Ocean)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "303")]
    public class TS303 : EdiMessage
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
        /// Beginning Segment for Booking or Pick-up/Delivery
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B1 B1 { get; set; }
        /// <summary>
        /// Authentication
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<Y6> Y6 { get; set; }
        /// <summary>
        /// Space Booking Cancellation
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual Y5 Y5 { get; set; }
        /// <summary>
        /// Event Detail
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<V9> V9 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
