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
    /// Loop for Docket Sub-level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SC))]
    public class Loop_SC_492
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Docket Sub-level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SC SC { get; set; }
        /// <summary>
        /// Demurrage/Detention/ Storage Rate
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DM DM { get; set; }
    }
    
    /// <summary>
    /// Miscellaneous Rates
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "492")]
    public class TS492 : EdiMessage
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
        /// External Reference Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual PRI PRI { get; set; }
        /// <summary>
        /// Demurrage/Detention/ Storage Rate
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DM DM { get; set; }
        /// <summary>
        /// Loop for Docket Sub-level
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<Loop_SC_492> SCLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
