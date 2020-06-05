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
    /// Loop for Advance Car Disposition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(E6))]
    public class Loop_E6_419
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Advance Car Disposition
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual E6 E6 { get; set; }
        /// <summary>
        /// Consignee Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual W3 W3 { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(3)]
        public virtual List<W5> W5 { get; set; }
    }
    
    /// <summary>
    /// Advance Car Disposition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "419")]
    public class TS419 : EdiMessage
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
        /// Loop for Advance Car Disposition
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(150)]
        [Pos(2)]
        public virtual List<Loop_E6_419> E6Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SE SE { get; set; }
    }
}
