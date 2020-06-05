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
    /// Loop for Patron
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PT))]
    public class Loop_PT_490
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patron
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PT PT { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Rate Group Definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "490")]
    public class TS490 : EdiMessage
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
        /// Rate Request Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual REN REN { get; set; }
        /// <summary>
        /// Docket Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual DK DK { get; set; }
        /// <summary>
        /// Group Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual GH GH { get; set; }
        /// <summary>
        /// Price Authority Identification
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(5)]
        public virtual List<PI> PI { get; set; }
        /// <summary>
        /// Term Text
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(6)]
        public virtual List<TT> TT { get; set; }
        /// <summary>
        /// Geography
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(7)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        /// Shipment Conditions
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(8)]
        public virtual List<CD> CD { get; set; }
        /// <summary>
        /// Product (Commodity)
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(9)]
        public virtual List<PR> PR { get; set; }
        /// <summary>
        /// Loop for Patron
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(10)]
        public virtual List<Loop_PT_490> PTLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual SE SE { get; set; }
    }
}
