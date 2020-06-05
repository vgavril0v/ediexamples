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
    /// Loop for Beginning Vehicle Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(BVA))]
    public class Loop_BVA_126
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Beginning Vehicle Advice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BVA BVA { get; set; }
        /// <summary>
        /// Vessel Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual V1 V1 { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<L7> L7 { get; set; }
        /// <summary>
        /// Loop for Vehicle Advice Detail
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<Loop_VAD_126> VADLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Vehicle Advice Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VAD))]
    public class Loop_VAD_126
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Vehicle Advice Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VAD VAD { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<L7> L7 { get; set; }
    }
    
    /// <summary>
    /// Vehicle Application Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "126")]
    public class TS126 : EdiMessage
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
        /// Loop for Beginning Vehicle Advice
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<Loop_BVA_126> BVALoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SE SE { get; set; }
    }
}
