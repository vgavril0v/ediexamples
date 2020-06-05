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
    /// Rate Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "466")]
    public class TS466 : EdiMessage
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
        /// Docket Header
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DK DK { get; set; }
        /// <summary>
        /// Price Request Parameter List 1
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PR1 PR1 { get; set; }
        /// <summary>
        /// Price Request Parameter List 2
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PR2 PR2 { get; set; }
        /// <summary>
        /// Price Authority Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PI PI { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
