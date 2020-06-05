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
    /// Loop for Forecast Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FST))]
    public class Loop_FST_862
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Forecast Schedule
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FST FST { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Destination Quantity
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<SDQ> SDQ { get; set; }
        /// <summary>
        /// Loop for Just-In-Time Schedule
        /// </summary>
        [DataMember]
        [ListCount(96)]
        [Pos(4)]
        public virtual List<Loop_JIT_862> JITLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Just-In-Time Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(JIT))]
    public class Loop_JIT_862
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Just-In-Time Schedule
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual JIT JIT { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_862
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Unit Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual UIT UIT { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<PO4> PO4 { get; set; }
        /// <summary>
        /// Part Release Status
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PRS PRS { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(7)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SDP SDP { get; set; }
        /// <summary>
        /// Loop for Forecast Schedule
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(10)]
        public virtual List<Loop_FST_862> FSTLoop { get; set; }
        /// <summary>
        /// Loop for Shipped/Received Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<Loop_SHP_862> SHPLoop { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual TD1 TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual TD3 TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual TD5 TD5 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_862
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
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual FOB FOB { get; set; }
    }
    
    /// <summary>
    /// Loop for Shipped/Received Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SHP))]
    public class Loop_SHP_862
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipped/Received Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SHP SHP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Shipping Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "862")]
    public class TS862 : EdiMessage
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
        /// Beginning Segment for Shipping Schedule/Production Sequence
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BSS BSS { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(4)]
        public virtual List<Loop_N1_862> N1Loop { get; set; }
        /// <summary>
        /// Loop for Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10000)]
        [Pos(5)]
        public virtual List<Loop_LIN_862> LINLoop { get; set; }
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CTT CTT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
