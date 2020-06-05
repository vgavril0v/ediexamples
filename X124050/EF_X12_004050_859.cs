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
    public class Loop_H1_859
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
        [ListCount(2)]
        [Pos(2)]
        public virtual List<H2> H2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Item - Quantity and Weight
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L0))]
    public class Loop_L0_859
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
        /// Rate and Charges
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<L1> L1 { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<MEA> MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_859
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
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Loop_N1_859> N1Loop { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Loop for Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<Loop_L0_859> L0Loop { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<L7> L7 { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SL1 SL1 { get; set; }
        /// <summary>
        /// Route Information (Air)
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual R1 R1 { get; set; }
        /// <summary>
        /// Mixed Hazardous Commodities
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual LH LH { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(10)]
        public virtual List<X1> X1 { get; set; }
        /// <summary>
        /// Import License
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual X2 X2 { get; set; }
        /// <summary>
        /// Pick-up
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual P1 P1 { get; set; }
        /// <summary>
        /// Proof of Delivery
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual POD POD { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(15)]
        public virtual List<ITA> ITA { get; set; }
        /// <summary>
        /// Line Item Subtotal
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual L8 L8 { get; set; }
        /// <summary>
        /// Event Detail
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual V9 V9 { get; set; }
        /// <summary>
        /// Delivery Date Information
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual P2 P2 { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(19)]
        public virtual List<N7> N7 { get; set; }
        /// <summary>
        /// Loop for Hazardous Material
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(20)]
        public virtual List<Loop_H1_859> H1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_859
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
    }
    
    /// <summary>
    /// Loop for Equipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N7))]
    public class Loop_N7_859
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
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        /// Equipment Ordered
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N5 N5 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Intermodal Chassis Equipment
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual IC IC { get; set; }
        /// <summary>
        /// Motor Vehicle Control
        /// </summary>
        [DataMember]
        [ListCount(36)]
        [Pos(6)]
        public virtual List<VC> VC { get; set; }
        /// <summary>
        /// Scale Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual G4 G4 { get; set; }
        /// <summary>
        /// Canadian Grain Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(8)]
        public virtual List<GA> GA { get; set; }
    }
    
    /// <summary>
    /// Loop for Stop-off Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(S5))]
    public class Loop_S5_859
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stop-off Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual S5 S5 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Special Services
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(4)]
        public virtual List<H6> H6 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_N1_859> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Freight Invoice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "859")]
    public class TS859 : EdiMessage
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
        /// Invoice Type
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual B3A B3A { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Cargo Manifest
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CM CM { get; set; }
        /// <summary>
        /// Authentication
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(6)]
        public virtual List<Y6> Y6 { get; set; }
        /// <summary>
        /// Cargo Booking Priority
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Y7 Y7 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ITD ITD { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(11)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Cross-Reference Equipment
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(12)]
        public virtual List<NA> NA { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual D9 D9 { get; set; }
        /// <summary>
        /// Route Information (Air)
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual R1 R1 { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(16)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(17)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Protective Service Instructions
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(18)]
        public virtual List<PS> PS { get; set; }
        /// <summary>
        /// Special Services
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(19)]
        public virtual List<H6> H6 { get; set; }
        /// <summary>
        /// Insurance
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual M1 M1 { get; set; }
        /// <summary>
        /// Sales/Delivery Terms
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual M2 M2 { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(22)]
        public virtual List<L7> L7 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(23)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Pro Forma - B13 Information
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual XH XH { get; set; }
        /// <summary>
        /// Pick-up
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual P1 P1 { get; set; }
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual ITA ITA { get; set; }
        /// <summary>
        /// Waybill Reference
        /// </summary>
        [DataMember]
        [ListCount(499)]
        [Pos(27)]
        public virtual List<N8> N8 { get; set; }
        /// <summary>
        /// Route Code Identification
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual R9 R9 { get; set; }
        /// <summary>
        /// Loop for Hazardous Material
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(29)]
        public virtual List<Loop_H1_859> H1Loop { get; set; }
        /// <summary>
        /// Loop for Equipment Details
        /// </summary>
        [DataMember]
        [ListCount(600)]
        [Pos(30)]
        public virtual List<Loop_N7_859> N7Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(31)]
        public virtual List<Loop_N1_859> N1Loop { get; set; }
        /// <summary>
        /// Loop for Stop-off Details
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(32)]
        public virtual List<Loop_S5_859> S5Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(33)]
        public virtual List<Loop_LX_859> LXLoop { get; set; }
        /// <summary>
        /// Total Weight and Charges
        /// </summary>
        [DataMember]
        [Pos(34)]
        public virtual L3 L3 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(35)]
        public virtual SE SE { get; set; }
    }
}
