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
    /// Loop for Identification of Shipment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(F02))]
    public class Loop_F02_920
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Identification of Shipment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual F02 F02 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Allowance/Charge (Claim)
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual F05 F05 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(5)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Lading Exception Code
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<Q7> Q7 { get; set; }
        /// <summary>
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        /// Loop for Detail - Supporting Evidence for Claim
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(8)]
        public virtual List<Loop_F09_920> F09Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Detail - Supporting Evidence for Claim
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(F09))]
    public class Loop_F09_920
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Detail - Supporting Evidence for Claim
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual F09 F09 { get; set; }
        /// <summary>
        /// Weight/Volume Loss
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual F04 F04 { get; set; }
        /// <summary>
        /// Allowance/Charge (Claim)
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<F05> F05 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_920
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
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<G61> G61 { get; set; }
    }
    
    /// <summary>
    /// Loss or Damage Claim - General Commodities
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "920")]
    public class TS920 : EdiMessage
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
        /// Identification of Claim (Claimant Originated)
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual F01 F01 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<CUR> CUR { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<Loop_N1_920> N1Loop { get; set; }
        /// <summary>
        /// Loop for Identification of Shipment
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(6)]
        public virtual List<Loop_F02_920> F02Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
