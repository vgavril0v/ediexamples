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
    /// Associated Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "102")]
    public class TS102 : EdiMessage
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
        /// Object Reference Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual ORI ORI { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Associated Object Type Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<OOI> OOI { get; set; }
        /// <summary>
        /// Binary Data Structure
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual BDS BDS { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
