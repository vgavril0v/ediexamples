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
    /// Shipment Weights
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "440")]
    public class TS440 : EdiMessage
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
        /// Beginning Segment for Weight Message Set
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BW BW { get; set; }
        /// <summary>
        /// Scale Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual G4 G4 { get; set; }
        /// <summary>
        /// Scale Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(255)]
        [Pos(4)]
        public virtual List<G5> G5 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
