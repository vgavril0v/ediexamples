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
    /// Loop for Hazardous Material
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(H1))]
    public class Loop_H1_312
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual H1 H1 { get; set; }
        /// <summary>
        /// Additional Hazardous Material Description
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<H2> H2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Item - Quantity and Weight
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L0))]
    public class Loop_L0_312
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
        [ListCount(999)]
        [Pos(2)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Loop for Rate and Charges
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<Loop_L1_312> L1Loop { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual L7 L7 { get; set; }
        /// <summary>
        /// Loop for Hazardous Material
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<Loop_H1_312> H1Loop { get; set; }
        /// <summary>
        /// Loop for Hazardous Identification Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(6)]
        public virtual List<Loop_LH1_312> LH1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Rate and Charges
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L1))]
    public class Loop_L1_312
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rate and Charges
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L1 L1 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C3 C3 { get; set; }
    }
    
    /// <summary>
    /// Loop for Hazardous Identification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_LH1_312
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Identification Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LH1 LH1 { get; set; }
        /// <summary>
        /// Hazardous Classification Information
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(2)]
        public virtual List<LH2> LH2 { get; set; }
        /// <summary>
        /// Hazardous Material Shipping Name
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<LH3> LH3 { get; set; }
        /// <summary>
        /// Freeform Hazardous Material Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(4)]
        public virtual List<LFH> LFH { get; set; }
        /// <summary>
        /// EPA Required Data
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<LEP> LEP { get; set; }
        /// <summary>
        /// Canadian Dangerous Requirements
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual LH4 LH4 { get; set; }
        /// <summary>
        /// Transborder Hazardous Requirements
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<LHT> LHT { get; set; }
        /// <summary>
        /// Hazardous Material Identifying Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<LHR> LHR { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_312
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
        /// Loop for Equipment Details
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<Loop_N7_312> N7Loop { get; set; }
        /// <summary>
        /// Loop for Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [ListCount(120)]
        [Pos(3)]
        public virtual List<Loop_L0_312> L0Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_312
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
    /// Loop for Equipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N7))]
    public class Loop_N7_312
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Equipment Environment
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N12 N12 { get; set; }
        /// <summary>
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        /// Equipment and Temperature
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual W09 W09 { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual L4 L4 { get; set; }
        /// <summary>
        /// Loop for Hazardous Material
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<Loop_H1_312> H1Loop { get; set; }
        /// <summary>
        /// Loop for Hazardous Identification Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(8)]
        public virtual List<Loop_LH1_312> LH1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Port or Terminal
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(R4))]
    public class Loop_R4_312
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Port or Terminal
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual R4 R4 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Arrival Notice (Ocean)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "312")]
    public class TS312 : EdiMessage
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
        /// Beginning Segment for Carrier's Invoice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B3 B3 { get; set; }
        /// <summary>
        /// Authentication
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<Y6> Y6 { get; set; }
        /// <summary>
        /// Arrival Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual Q3 Q3 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        /// Shipment Type Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual G1 G1 { get; set; }
        /// <summary>
        /// Beyond Routing
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual G2 G2 { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(8)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(9)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Vessel Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(10)]
        public virtual List<V1> V1 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<Loop_N1_312> N1Loop { get; set; }
        /// <summary>
        /// Loop for Port or Terminal
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(12)]
        public virtual List<Loop_R4_312> R4Loop { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(13)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual L5 L5 { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(15)]
        public virtual List<Loop_LX_312> LXLoop { get; set; }
        /// <summary>
        /// Event Detail
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(16)]
        public virtual List<V9> V9 { get; set; }
        /// <summary>
        /// Total Weight and Charges
        /// </summary>
        [DataMember]
        [Required]
        [Pos(17)]
        public virtual L3 L3 { get; set; }
        /// <summary>
        /// Loop for Rate and Charges
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(18)]
        public virtual List<Loop_L1_312> L1Loop { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(19)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual L11 L11 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual SE SE { get; set; }
    }
}
