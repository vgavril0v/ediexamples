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
    /// File Transfer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "996")]
    public class TS996 : EdiMessage
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
        /// Beginning Segment for File Transfer Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGF BGF { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<K3> K3 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
