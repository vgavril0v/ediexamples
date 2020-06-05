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
    /// Loop for Contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G61))]
    public class Loop_G61_196
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G61 G61 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_196
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HL HL { get; set; }
        /// <summary>
        /// Contractor Report Type
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CRT CRT { get; set; }
        /// <summary>
        /// Breakdown Structure Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual BSD BSD { get; set; }
        /// <summary>
        /// Cost Line Item
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CLI CLI { get; set; }
        /// <summary>
        /// Calendar
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CAL CAL { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Rate Amounts or Percents
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<RPA> RPA { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Pricing Data
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_PD_196> PDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_196
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
        /// Loop for Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_G61_196> G61Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Pricing Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PD))]
    public class Loop_PD_196
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pricing Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PD PD { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Pricing Data Detail
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PDD> PDD { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Contractor Cost Data Reporting
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "196")]
    public class TS196 : EdiMessage
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
        /// Beginning Segment for Contractor Cost Data Reporting
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BCM BCM { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual List<Loop_N1_196> N1Loop { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual List<Loop_HL_196> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
