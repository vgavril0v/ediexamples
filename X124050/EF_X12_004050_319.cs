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
    /// Terminal Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "319")]
    public class TS319 : EdiMessage
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
        /// Beginning Segment for Cargo Terminal Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BA2 BA2 { get; set; }
        /// <summary>
        /// Cargo Detail
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(3)]
        public virtual List<CD1> CD1 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
