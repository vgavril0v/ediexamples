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
    /// Loop for Entity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENT))]
    public class Loop_ENT_880
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Entity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ENT ENT { get; set; }
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
        [Pos(3)]
        public virtual N3 N3 { get; set; }
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
        [ListCount(5)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_REF_880> REFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Detail - Invoice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G17))]
    public class Loop_G17_880
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Detail - Invoice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G17 G17 { get; set; }
        /// <summary>
        /// Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<G69> G69 { get; set; }
        /// <summary>
        /// Line Item Detail - Quantity/Unit of Measure/Price Differences
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<G19> G19 { get; set; }
        /// <summary>
        /// Item Packing Detail
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual G20 G20 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<G23> G23 { get; set; }
        /// <summary>
        /// F.O.B. Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual G25 G25 { get; set; }
        /// <summary>
        /// Loop for Allowance or Charge
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(8)]
        public virtual List<Loop_G72_880> G72Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Detail - Invoice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G17))]
    public class Loop_G17_880_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Detail - Invoice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G17 G17 { get; set; }
        /// <summary>
        /// Line Item Detail - Quantity/Unit of Measure/Price Differences
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<G19> G19 { get; set; }
    }
    
    /// <summary>
    /// Loop for Allowance or Charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G72))]
    public class Loop_G72_880
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
    public class Loop_N1_880
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
    /// Loop for Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_880
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Allowance or Charge
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual G72 G72 { get; set; }
        /// <summary>
        /// Loop for Item Detail - Invoice
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_G17_880_2> G17Loop { get; set; }
    }
    
    /// <summary>
    /// Grocery Products Invoice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "880")]
    public class TS880 : EdiMessage
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
        /// Invoice Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual G01 G01 { get; set; }
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
        [ListCount(3)]
        [Pos(4)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(5)]
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
        /// Carrier Detail
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<G27> G27 { get; set; }
        /// <summary>
        /// Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(8)]
        public virtual List<G23> G23 { get; set; }
        /// <summary>
        /// F.O.B. Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual G25 G25 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<Loop_N1_880> N1Loop { get; set; }
        /// <summary>
        /// Loop for Allowance or Charge
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(11)]
        public virtual List<Loop_G72_880> G72Loop { get; set; }
        /// <summary>
        /// Loop for Item Detail - Invoice
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(12)]
        public virtual List<Loop_G17_880> G17Loop { get; set; }
        /// <summary>
        /// Loop for Entity
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(13)]
        public virtual List<Loop_ENT_880> ENTLoop { get; set; }
        /// <summary>
        /// Total Invoice Quantity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(14)]
        public virtual G31 G31 { get; set; }
        /// <summary>
        /// Total Dollars Summary
        /// </summary>
        [DataMember]
        [Required]
        [Pos(15)]
        public virtual G33 G33 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual SE SE { get; set; }
    }
}
