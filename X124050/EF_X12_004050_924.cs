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
    /// Loss or Damage Claim - Motor Vehicle
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "924")]
    public class TS924 : EdiMessage
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
        /// Identification of Claim (Claimant Originated)
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual F01 F01 { get; set; }
        /// <summary>
        /// Identification (Automotive)
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual F6X F6X { get; set; }
        /// <summary>
        /// Identification of Shipment
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual F02 F02 { get; set; }
        /// <summary>
        /// Basic Claim Information - Automotive
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual F12 F12 { get; set; }
        /// <summary>
        /// Auto Claim Detail
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<F07> F07 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
