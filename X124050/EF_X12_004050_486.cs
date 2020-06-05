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
    /// Rate Docket Expiration
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "486")]
    public class TS486 : EdiMessage
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
        /// Rate Request Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual REN REN { get; set; }
        /// <summary>
        /// Docket Range
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual DR DR { get; set; }
        /// <summary>
        /// Price Authority Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PI PI { get; set; }
        /// <summary>
        /// Status Action
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual SA SA { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
