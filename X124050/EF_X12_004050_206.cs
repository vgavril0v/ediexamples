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
    /// Loop for Individual Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_206
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IN1 IN1 { get; set; }
        /// <summary>
        /// Individual Name Structure Components
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(2)]
        public virtual List<IN2> IN2 { get; set; }
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
        [Pos(5)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_206
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
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
    public class Loop_N1_206_2
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
        [ListCount(10)]
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
        [Pos(5)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CRC CRC { get; set; }
        /// <summary>
        /// Default Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<DFI> DFI { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Obligation Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<OBI> OBI { get; set; }
        /// <summary>
        /// Income
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<AIN> AIN { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(13)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for Property or Entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_206
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Property or Entity Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NX1 NX1 { get; set; }
        /// <summary>
        /// Location ID Component
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Property Description/Legal Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PDS> PDS { get; set; }
        /// <summary>
        /// Property Metes and Bounds Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<PDE> PDE { get; set; }
        /// <summary>
        /// Real Estate Property Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual REA REA { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Real Estate Condition
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<REC> REC { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(8)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(9)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(11)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(12)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(13)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual CTP CTP { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_N1_206_2> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Characteristic Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SI))]
    public class Loop_SI_206
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SI SI { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Real Estate Loan Type
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual RLT RLT { get; set; }
        /// <summary>
        /// Real Estate Condition
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual REC REC { get; set; }
        /// <summary>
        /// Loan Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual LN LN { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(9)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual CTP CTP { get; set; }
        /// <summary>
        /// Loop for Individual Identification
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_IN1_206> IN1Loop { get; set; }
        /// <summary>
        /// Loop for Property or Entity Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(13)]
        public virtual List<Loop_NX1_206> NX1Loop { get; set; }
    }
    
    /// <summary>
    /// Real Estate Inspection
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "206")]
    public class TS206 : EdiMessage
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
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual MSG MSG { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_N1_206> N1Loop { get; set; }
        /// <summary>
        /// Loop for Service Characteristic Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual List<Loop_SI_206> SILoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
