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
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_944
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
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MAN MAN { get; set; }
        /// <summary>
        /// Pallet Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PAL> PAL { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Item Detail For Stock Receipt
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(5)]
        public virtual List<Loop_W07_944> W07Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_944
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Detail For Stock Receipt
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(W07))]
    public class Loop_W07_944
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Detail For Stock Receipt
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual W07 W07 { get; set; }
        /// <summary>
        /// Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<G69> G69 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Line Item Detail - Packing
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<W20> W20 { get; set; }
        /// <summary>
        /// Loop for Item Detail Exception
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(5)]
        public virtual List<Loop_W13_944> W13Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Detail Exception
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(W13))]
    public class Loop_W13_944
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Detail Exception
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual W13 W13 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
    }
    
    /// <summary>
    /// Warehouse Stock Transfer Receipt Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "944")]
    public class TS944 : EdiMessage
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
        /// Warehouse Receipt Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual W17 W17 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<Loop_N1_944> N1Loop { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(7)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Receipt Carrier Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual W08 W08 { get; set; }
        /// <summary>
        /// Probe Temperatures
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<W18> W18 { get; set; }
        /// <summary>
        /// Pallet Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(10)]
        public virtual List<G08> G08 { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(11)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(12)]
        public virtual List<Loop_LX_944> LXLoop { get; set; }
        /// <summary>
        /// Total Receipt Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(13)]
        public virtual W14 W14 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual SE SE { get; set; }
    }
}
