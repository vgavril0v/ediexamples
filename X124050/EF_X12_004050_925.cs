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
    /// Loop for Identification of Claim (Tracer)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(F10))]
    public class Loop_F10_925
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Identification of Claim (Tracer)
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual F10 F10 { get; set; }
        /// <summary>
        /// Identification of Shipment
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual F02 F02 { get; set; }
    }
    
    /// <summary>
    /// Claim Tracer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "925")]
    public class TS925 : EdiMessage
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
        /// Loop for Identification of Claim (Tracer)
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<Loop_F10_925> F10Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SE SE { get; set; }
    }
}
