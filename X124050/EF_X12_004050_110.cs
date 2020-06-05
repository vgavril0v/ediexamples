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
    /// Loop for Rate and Charges
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L1))]
    public class Loop_L1_110
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
    /// Loop for Description, Marks and Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L5))]
    public class Loop_L5_110
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L5 L5 { get; set; }
        /// <summary>
        /// Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual L0 L0 { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(3)]
        public virtual List<L4> L4 { get; set; }
        /// <summary>
        /// Weight Information
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(4)]
        public virtual List<L10> L10 { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SL1 SL1 { get; set; }
        /// <summary>
        /// Loop for Rate and Charges
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(6)]
        public virtual List<Loop_L1_110> L1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_110
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
        [ListCount(2)]
        [Pos(2)]
        public virtual List<Loop_N1_110> N1Loop { get; set; }
        /// <summary>
        /// Pick-up
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual P1 P1 { get; set; }
        /// <summary>
        /// Route Information (Air)
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual R1 R1 { get; set; }
        /// <summary>
        /// Proof of Delivery
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual POD POD { get; set; }
        /// <summary>
        /// Event Detail
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual V9 V9 { get; set; }
        /// <summary>
        /// Remittance Advice
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<RMT> RMT { get; set; }
        /// <summary>
        /// Statement Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual G47 G47 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [Pos(10)]
        public virtual List<Loop_L5_110> L5Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_110
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
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PER PER { get; set; }
    }
    
    /// <summary>
    /// Air Freight Details and Invoice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "110")]
    public class TS110 : EdiMessage
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
        /// Bank ID
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C2 C2 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual ITD ITD { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<Loop_N1_110> N1Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual List<Loop_LX_110> LXLoop { get; set; }
        /// <summary>
        /// Total Weight and Charges
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual L3 L3 { get; set; }
        /// <summary>
        /// Ancillary Charges
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ACS ACS { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(11)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual SE SE { get; set; }
    }
}
