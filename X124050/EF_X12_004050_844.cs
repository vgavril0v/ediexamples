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
    /// Loop for Contract Number Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CON))]
    public class Loop_CON_844
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contract Number Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CON CON { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_N1_844_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Product Adjustment Detail
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(6)]
        public virtual List<Loop_PAD_844> PADLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_844
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
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_844_2
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
        /// Loop for Sales Item Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_SII_844> SIILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Product Adjustment Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAD))]
    public class Loop_PAD_844
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product Adjustment Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAD PAD { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(3)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(40)]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Unit Detail
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<UIT> UIT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Receiving Conditions
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual RCD RCD { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(9)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Product Special Services
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual SSS SSS { get; set; }
    }
    
    /// <summary>
    /// Loop for Sales Item Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SII))]
    public class Loop_SII_844
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sales Item Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SII SII { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N9 N9 { get; set; }
    }
    
    /// <summary>
    /// Product Transfer Account Adjustment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "844")]
    public class TS844 : EdiMessage
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
        /// Beginning Segment for Product Transfer Account Adjustment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BAA BAA { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<NTE> NTE { get; set; }
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(8)]
        public virtual List<Loop_N1_844> N1Loop { get; set; }
        /// <summary>
        /// Loop for Contract Number Detail
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10000)]
        [Pos(9)]
        public virtual List<Loop_CON_844> CONLoop { get; set; }
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [DataMember]
        [Required]
        [Pos(10)]
        public virtual CTT CTT { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(11)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual SE SE { get; set; }
    }
}
