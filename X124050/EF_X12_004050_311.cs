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
    public class Loop_ED_311
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
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        /// Cross-Reference Equipment
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual NA NA { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual L4 L4 { get; set; }
        /// <summary>
        /// Beyond Routing
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual G2 G2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Item - Quantity and Weight
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L0))]
    public class Loop_L0_311
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L0 L0 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual L4 L4 { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<X1> X1 { get; set; }
        /// <summary>
        /// Import License
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<X2> X2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_311
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        /// Container Details
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Y2> Y2 { get; set; }
        /// <summary>
        /// Loop for Equipment Description
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(3)]
        public virtual List<Loop_ED_311> EDLoop { get; set; }
        /// <summary>
        /// Loop for Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [ListCount(120)]
        [Pos(4)]
        public virtual List<Loop_L0_311> L0Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_311
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
    }
    
    /// <summary>
    /// Canadian Customs Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "311")]
    public class TS311 : EdiMessage
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
        /// Set Purpose
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B2A B2A { get; set; }
        /// <summary>
        /// Authentication
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<Y6> Y6 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Vessel Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual V1 V1 { get; set; }
        /// <summary>
        /// Vessel Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual V2 V2 { get; set; }
        /// <summary>
        /// Vessel Schedule
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual V3 V3 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(8)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_N1_311> N1Loop { get; set; }
        /// <summary>
        /// Port or Terminal
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<R4> R4 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(11)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(12)]
        public virtual List<Loop_LX_311> LXLoop { get; set; }
        /// <summary>
        /// Total Weight and Charges
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual L3 L3 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(14)]
        public virtual List<K1> K12 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual SE SE { get; set; }
    }
}
