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
    /// Multilevel Railcar Load Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "125")]
    public class TS125 : EdiMessage
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
        /// Beginning Segment for Multilevel Railcar Load Details Transaction
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BMM BMM { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual G62 G62 { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// Motor Vehicle Control
        /// </summary>
        [DataMember]
        [ListCount(21)]
        [Pos(5)]
        public virtual List<VC> VC { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
