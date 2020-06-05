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
    /// Loop for Line Item - Quantity and Weight
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L0))]
    public class Loop_L0_410
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
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Rate and Charges
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<L1> L1 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Price Authority Identification
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(5)]
        public virtual List<PI> PI { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_410
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
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(15)]
        [Pos(2)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Loop for Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(25)]
        [Pos(3)]
        public virtual List<Loop_L0_410> L0Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_410
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Billing Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(6)]
        public virtual List<BL> BL { get; set; }
    }
    
    /// <summary>
    /// Loop for Equipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N7))]
    public class Loop_N7_410
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
        /// Motor Vehicle Control
        /// </summary>
        [DataMember]
        [ListCount(36)]
        [Pos(2)]
        public virtual List<VC> VC { get; set; }
        /// <summary>
        /// Scale Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual G4 G4 { get; set; }
        /// <summary>
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        /// Equipment Ordered
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N5 N5 { get; set; }
        /// <summary>
        /// Intermodal Chassis Equipment
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual IC IC { get; set; }
        /// <summary>
        /// Intermodal Movement Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual IM IM { get; set; }
        /// <summary>
        /// In-bond Identifying Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual M12 M12 { get; set; }
        /// <summary>
        /// Canadian Grain Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(9)]
        public virtual List<GA> GA { get; set; }
    }
    
    /// <summary>
    /// Loop for Stop-off Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(S1))]
    public class Loop_S1_410
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stop-off Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual S1 S1 { get; set; }
        /// <summary>
        /// Stop-off Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual S2 S2 { get; set; }
        /// <summary>
        /// Stop-off Station
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual S9 S9 { get; set; }
    }
    
    /// <summary>
    /// Loop for Transit Inbound Origin
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(T1))]
    public class Loop_T1_410
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transit Inbound Origin
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual T1 T1 { get; set; }
        /// <summary>
        /// Transit Inbound Lading
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(2)]
        public virtual List<T2> T2 { get; set; }
        /// <summary>
        /// Transit Inbound Route
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(3)]
        public virtual List<T3> T3 { get; set; }
        /// <summary>
        /// Transit Inbound Rates
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual T6 T6 { get; set; }
        /// <summary>
        /// Free-form Transit Data
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(5)]
        public virtual List<T8> T8 { get; set; }
    }
    
    /// <summary>
    /// Rail Carrier Freight Details and Invoice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "410")]
    public class TS410 : EdiMessage
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
        public virtual B3B B3B { get; set; }
        /// <summary>
        /// Alternate Amount Due
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C4 C4 { get; set; }
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
        [ListCount(2)]
        [Pos(5)]
        public virtual List<CM> CM { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(500)]
        [Pos(7)]
        public virtual List<Loop_N7_410> N7Loop { get; set; }
        /// <summary>
        /// Waybill Reference
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(499)]
        [Pos(8)]
        public virtual List<N8> N8 { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Required]
        [Pos(10)]
        public virtual D9 D9 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(11)]
        public virtual List<Loop_N1_410> N1Loop { get; set; }
        /// <summary>
        /// Loop for Stop-off Name
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(12)]
        public virtual List<Loop_S1_410> S1Loop { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(13)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        /// Route Code Identification
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual R9 R9 { get; set; }
        /// <summary>
        /// Protective Service Instructions
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(15)]
        public virtual List<PS> PS { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(25)]
        [Pos(16)]
        public virtual List<Loop_LX_410> LXLoop { get; set; }
        /// <summary>
        /// Loop for Transit Inbound Origin
        /// </summary>
        [DataMember]
        [ListCount(64)]
        [Pos(17)]
        public virtual List<Loop_T1_410> T1Loop { get; set; }
        /// <summary>
        /// Total Weight and Charges
        /// </summary>
        [DataMember]
        [Required]
        [Pos(18)]
        public virtual L3 L3 { get; set; }
        /// <summary>
        /// Customs Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(19)]
        public virtual List<X7> X7 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual SE SE { get; set; }
    }
}
