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
    /// Loop for Line Item Detail - Product
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G68))]
    public class Loop_G68_875
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item Detail - Product
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G68 G68 { get; set; }
        /// <summary>
        /// Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<G69> G69 { get; set; }
        /// <summary>
        /// Line Item Detail - Miscellaneous
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<G70> G70 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<G23> G23 { get; set; }
        /// <summary>
        /// Loop for Allowance or Charge
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(6)]
        public virtual List<Loop_G72_875> G72Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(7)]
        public virtual List<Loop_N1_875_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Subline Item Detail
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(8)]
        public virtual List<Loop_SLN_875> SLNLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Allowance or Charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G72))]
    public class Loop_G72_875
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or Charge
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G72 G72 { get; set; }
        /// <summary>
        /// Allowance or Charge Description
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<G73> G73 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_875
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
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_875_2
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
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
    }
    
    /// <summary>
    /// Loop for Subline Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN))]
    public class Loop_SLN_875
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subline Item Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SLN SLN { get; set; }
        /// <summary>
        /// Allowance or Charge
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<G72> G72 { get; set; }
    }
    
    /// <summary>
    /// Grocery Products Purchase Order
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "875")]
    public class TS875 : EdiMessage
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
        /// Purchase Order Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual G50 G50 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Transportation Instructions
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual G66 G66 { get; set; }
        /// <summary>
        /// Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(8)]
        public virtual List<G23> G23 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_N1_875> N1Loop { get; set; }
        /// <summary>
        /// Loop for Allowance or Charge
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(10)]
        public virtual List<Loop_G72_875> G72Loop { get; set; }
        /// <summary>
        /// Loop for Line Item Detail - Product
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(11)]
        public virtual List<Loop_G68_875> G68Loop { get; set; }
        /// <summary>
        /// Total Purchase Order
        /// </summary>
        [DataMember]
        [Required]
        [Pos(12)]
        public virtual G76 G76 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual SE SE { get; set; }
    }
}
