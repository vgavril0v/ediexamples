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
    public class Loop_E6_420
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
        /// Blocking and Response Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual E8 E8 { get; set; }
    }
    
    /// <summary>
    /// Car Handling Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "420")]
    public class TS420 : EdiMessage
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
        public virtual List<Loop_E6_420> E6Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SE SE { get; set; }
    }
}
