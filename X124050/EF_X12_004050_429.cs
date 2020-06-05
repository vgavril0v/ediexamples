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
    /// Loop for Employing Carrier Response
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RU2))]
    public class Loop_RU2_429
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Employing Carrier Response
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RU2 RU2 { get; set; }
        /// <summary>
        /// Employing Carrier Claim Profile
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RU3 RU3 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Railroad Retirement Activity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "429")]
    public class TS429 : EdiMessage
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
        /// Retirement Board Detail
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<RU1> RU1 { get; set; }
        /// <summary>
        /// Loop for Employing Carrier Response
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(3)]
        public virtual List<Loop_RU2_429> RU2Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
