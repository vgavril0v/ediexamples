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
    /// Loop for Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(F11))]
    public class Loop_F11_926
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual F11 F11 { get; set; }
        /// <summary>
        /// Line Item Reject
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<F14> F14 { get; set; }
        /// <summary>
        /// Trace
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TRN TRN { get; set; }
        /// <summary>
        /// Payment Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual F13 F13 { get; set; }
    }
    
    /// <summary>
    /// Claim Status Report and Tracer Reply
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "926")]
    public class TS926 : EdiMessage
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
        /// Loop for Status
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(500)]
        [Pos(2)]
        public virtual List<Loop_F11_926> F11Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SE SE { get; set; }
    }
}
