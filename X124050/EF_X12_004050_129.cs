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
    /// Loop for Rate Destination
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RT))]
    public class Loop_RT_129
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rate Destination
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RT RT { get; set; }
        /// <summary>
        /// Rate Detail
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<RT1> RT1 { get; set; }
    }
    
    /// <summary>
    /// Vehicle Carrier Rate Update
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "129")]
    public class TS129 : EdiMessage
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
        /// Rate Origin
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual VR VR { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Loop for Rate Destination
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<Loop_RT_129> RTLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
