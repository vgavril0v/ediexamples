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
    /// Loop for Line Item Detail - Promotion
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G45))]
    public class Loop_G45_889
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item Detail - Promotion
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G45 G45 { get; set; }
        /// <summary>
        /// Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<G69> G69 { get; set; }
        /// <summary>
        /// Promotion/Price List Area
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<G43> G43 { get; set; }
        /// <summary>
        /// Free Goods/Product Condition
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<G51> G51 { get; set; }
        /// <summary>
        /// Terms of Sale
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual G23 G23 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual G22 G22 { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for Promotion Conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G94))]
    public class Loop_G94_889
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Promotion Conditions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G94 G94 { get; set; }
        /// <summary>
        /// Performance Requirements
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<G95> G95 { get; set; }
    }
    
    /// <summary>
    /// Loop for Promotion Conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G94))]
    public class Loop_G94_889_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Promotion Conditions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G94 G94 { get; set; }
        /// <summary>
        /// Loop for Performance Requirements
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<Loop_G95_889> G95Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Performance Requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G95))]
    public class Loop_G95_889
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Performance Requirements
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G95 G95 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_889
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
        /// Promotion Allowance/Charge
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<G46> G46 { get; set; }
        /// <summary>
        /// Free Goods/Product Condition
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual G51 G51 { get; set; }
        /// <summary>
        /// Loop for Promotion Conditions
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<Loop_G94_889_2> G94Loop { get; set; }
        /// <summary>
        /// Loop for Line Item Detail - Promotion
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(5)]
        public virtual List<Loop_G45_889> G45Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_889
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
        /// Date/Time
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<G62> G62 { get; set; }
    }
    
    /// <summary>
    /// Promotion Announcement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "889")]
    public class TS889 : EdiMessage
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
        /// Promotion Announcement Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual G42 G42 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(50)]
        [Pos(5)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(300)]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Promotion/Price List Area
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(7)]
        public virtual List<G43> G43 { get; set; }
        /// <summary>
        /// Terms of Sale
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual G23 G23 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual List<Loop_N1_889> N1Loop { get; set; }
        /// <summary>
        /// Loop for Promotion Conditions
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(10)]
        public virtual List<Loop_G94_889> G94Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(11)]
        public virtual List<Loop_LX_889> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual SE SE { get; set; }
    }
}
