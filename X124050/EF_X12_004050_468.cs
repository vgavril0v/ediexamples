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
    /// Loop for Journal Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(JL))]
    public class Loop_JL_468
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Journal Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual JL JL { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Rate Docket Journal Log
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "468")]
    public class TS468 : EdiMessage
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
        /// Docket Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual DK DK { get; set; }
        /// <summary>
        /// Loop for Journal Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(7)]
        [Pos(3)]
        public virtual List<Loop_JL_468> JLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
