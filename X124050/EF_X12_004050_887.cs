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
    /// Loop for Coupon Special Processing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G14))]
    public class Loop_G14_887
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Coupon Special Processing
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G14 G14 { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N2 N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
    }
    
    /// <summary>
    /// Loop for Coupon Distribution
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G15))]
    public class Loop_G15_887
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Coupon Distribution
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G15 G15 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PCT PCT { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Item Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G28))]
    public class Loop_G28_887
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item Numbers
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G28 G28 { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PCT PCT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Free Goods/Product Condition
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual G51 G51 { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_887
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
        /// Loop for Line Item Numbers
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<Loop_G28_887> G28Loop { get; set; }
    }
    
    /// <summary>
    /// Coupon Notification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "887")]
    public class TS887 : EdiMessage
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
        /// Beginning Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGN BGN { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(7)]
        [Pos(4)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Promotion/Price List Area
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(5)]
        public virtual List<G43> G43 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(8)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Coupon Reporting Specifications
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<G11> G11 { get; set; }
        /// <summary>
        /// Coupon Physical Characteristics
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual G12 G12 { get; set; }
        /// <summary>
        /// Loop for Coupon Special Processing
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(11)]
        public virtual List<Loop_G14_887> G14Loop { get; set; }
        /// <summary>
        /// Loop for Coupon Distribution
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(12)]
        public virtual List<Loop_G15_887> G15Loop { get; set; }
        /// <summary>
        /// Loop for Item Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(13)]
        public virtual List<Loop_LIN_887> LINLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual SE SE { get; set; }
    }
}
