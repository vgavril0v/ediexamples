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
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_943
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N2 N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Detail Total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(W04))]
    public class Loop_W04_943
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Detail Total
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual W04 W04 { get; set; }
        /// <summary>
        /// Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<G69> G69 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Line Item Detail - Packing
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<W20> W20 { get; set; }
    }
    
    /// <summary>
    /// Warehouse Stock Transfer Shipment Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "943")]
    public class TS943 : EdiMessage
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
        /// Warehouse Shipment Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual W06 W06 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<Loop_N1_943> N1Loop { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(7)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Carrier Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual W27 W27 { get; set; }
        /// <summary>
        /// Consolidation Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual W28 W28 { get; set; }
        /// <summary>
        /// Warehouse Additional Carrier Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual W10 W10 { get; set; }
        /// <summary>
        /// Loop for Item Detail Total
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(11)]
        public virtual List<Loop_W04_943> W04Loop { get; set; }
        /// <summary>
        /// Total Shipment Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(12)]
        public virtual W03 W03 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual SE SE { get; set; }
    }
}
