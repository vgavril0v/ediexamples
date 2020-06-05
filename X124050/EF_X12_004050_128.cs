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
    /// Dealer Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "128")]
    public class TS128 : EdiMessage
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
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Dealer Effectivity
        /// </summary>
        [DataMember]
        [ListCount(7)]
        [Pos(6)]
        public virtual List<DN> DN { get; set; }
        /// <summary>
        /// Route Code Identification
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(7)]
        public virtual List<R9> R9 { get; set; }
        /// <summary>
        /// Dealer Hours
        /// </summary>
        [DataMember]
        [ListCount(28)]
        [Pos(8)]
        public virtual List<DH> DH { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual K1 K1 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual SE SE { get; set; }
    }
}
