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
    /// Loop for Equipment Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ED))]
    public class Loop_ED_451
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ED ED { get; set; }
        /// <summary>
        /// Rail Event Reporting
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<ER> ER { get; set; }
        /// <summary>
        /// Cross-Reference Equipment
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual NA NA { get; set; }
        /// <summary>
        /// Intermodal Chassis Equipment
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<IC> IC { get; set; }
        /// <summary>
        /// Car Location Routing Request
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<CLR> CLR { get; set; }
        /// <summary>
        /// Equipment Status
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual ES ES { get; set; }
    }
    
    /// <summary>
    /// Railroad Event Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "451")]
    public class TS451 : EdiMessage
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
        /// Rail Event Reporting
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<ER> ER { get; set; }
        /// <summary>
        /// Loop for Equipment Description
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(3)]
        public virtual List<Loop_ED_451> EDLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
