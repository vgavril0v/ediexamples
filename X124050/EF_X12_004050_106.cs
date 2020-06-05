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
    /// Loop for Rate Request Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CA1))]
    public class Loop_CA1_106
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rate Request Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CA1 CA1 { get; set; }
        /// <summary>
        /// Geography
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        /// Product (Commodity)
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<PR> PR { get; set; }
        /// <summary>
        /// Lane Commitments
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual LC1 LC1 { get; set; }
        /// <summary>
        /// Service Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SV SV { get; set; }
        /// <summary>
        /// Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        /// Tariff Accessorial Charges
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(7)]
        public virtual List<MCT> MCT { get; set; }
        /// <summary>
        /// Loop for Equipment or Container Owner and Type
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Loop_MS2_106 MS2Loop { get; set; }
        /// <summary>
        /// Loop for Freight Rate
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(9)]
        public virtual List<Loop_RTT_106> RTTLoop { get; set; }
        /// <summary>
        /// Loop for Tariff Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual Loop_TF_106_2 TFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_106
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
        /// Geography
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        /// Product (Commodity)
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<PR> PR { get; set; }
        /// <summary>
        /// Tariff Restrictions
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual TFR TFR { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        /// Loop for Equipment or Container Owner and Type
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_MS2_106 MS2Loop { get; set; }
        /// <summary>
        /// Loop for Tariff Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Loop_TF_106_2 TFLoop { get; set; }
        /// <summary>
        /// Loop for Rate Request Identifier
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_CA1_106> CA1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Equipment or Container Owner and Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MS2))]
    public class Loop_MS2_106
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment or Container Owner and Type
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MS2 MS2 { get; set; }
        /// <summary>
        /// Trailer or Container Dimension and Weight
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AT9 AT9 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_106
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
    /// Loop for Freight Rate
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RTT))]
    public class Loop_RTT_106
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Freight Rate
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RTT RTT { get; set; }
        /// <summary>
        /// Tariff Restrictions
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<TFR> TFR { get; set; }
    }
    
    /// <summary>
    /// Loop for Tariff Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TF))]
    public class Loop_TF_106
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tariff Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TF TF { get; set; }
        /// <summary>
        /// Tariff Section
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual TS TS { get; set; }
    }
    
    /// <summary>
    /// Loop for Tariff Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TF))]
    public class Loop_TF_106_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tariff Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TF TF { get; set; }
        /// <summary>
        /// Tariff Section
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual TS TS { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<G62> G62 { get; set; }
    }
    
    /// <summary>
    /// Motor Carrier Rate Proposal
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "106")]
    public class TS106 : EdiMessage
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
        /// Transportation Carrier Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual BLR BLR { get; set; }
        /// <summary>
        /// Tariff Restrictions
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual TFR TFR { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(7)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        /// Product (Commodity)
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<PR> PR { get; set; }
        /// <summary>
        /// Lane Commitments
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual LC1 LC1 { get; set; }
        /// <summary>
        /// Mileage Source
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual MI1 MI1 { get; set; }
        /// <summary>
        /// Tariff Accessorial Charges
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(11)]
        public virtual List<MCT> MCT { get; set; }
        /// <summary>
        /// Loop for Equipment or Container Owner and Type
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual Loop_MS2_106 MS2Loop { get; set; }
        /// <summary>
        /// Loop for Tariff Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual Loop_TF_106 TFLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(14)]
        public virtual List<Loop_N1_106> N1Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<Loop_LX_106> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual SE SE { get; set; }
    }
}
