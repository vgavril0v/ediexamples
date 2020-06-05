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
    /// Loop for Hazardous Material
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(H1))]
    public class Loop_H1_301
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual H1 H1 { get; set; }
        /// <summary>
        /// Additional Hazardous Material Description
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<H2> H2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Hazardous Identification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_LH1_301
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Identification Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LH1 LH1 { get; set; }
        /// <summary>
        /// Hazardous Classification Information
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(2)]
        public virtual List<LH2> LH2 { get; set; }
        /// <summary>
        /// Hazardous Material Shipping Name
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<LH3> LH3 { get; set; }
        /// <summary>
        /// Freeform Hazardous Material Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(4)]
        public virtual List<LFH> LFH { get; set; }
        /// <summary>
        /// EPA Required Data
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<LEP> LEP { get; set; }
        /// <summary>
        /// Canadian Dangerous Requirements
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual LH4 LH4 { get; set; }
        /// <summary>
        /// Transborder Hazardous Requirements
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<LHT> LHT { get; set; }
        /// <summary>
        /// Hazardous Material Identifying Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<LHR> LHR { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_301
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
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// Equipment and Temperature
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual W09 W09 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual L0 L0 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual L5 L5 { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual L4 L4 { get; set; }
        /// <summary>
        /// Rate and Charges
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual L1 L1 { get; set; }
        /// <summary>
        /// Loop for Hazardous Material
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_H1_301> H1Loop { get; set; }
        /// <summary>
        /// Loop for Hazardous Identification Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(10)]
        public virtual List<Loop_LH1_301> LH1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_301
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
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<G61> G61 { get; set; }
    }
    
    /// <summary>
    /// Loop for Port or Terminal
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(R4))]
    public class Loop_R4_301
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Port or Terminal
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual R4 R4 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Container Release
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(Y4))]
    public class Loop_Y4_301
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Container Release
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual Y4 Y4 { get; set; }
        /// <summary>
        /// Equipment and Temperature
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual W09 W09 { get; set; }
    }
    
    /// <summary>
    /// Confirmation (Ocean)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "301")]
    public class TS301 : EdiMessage
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
        /// Beginning Segment for Booking or Pick-up/Delivery
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B1 B1 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Authentication
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<Y6> Y6 { get; set; }
        /// <summary>
        /// Space Confirmation
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual Y3 Y3 { get; set; }
        /// <summary>
        /// Loop for Container Release
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<Loop_Y4_301> Y4Loop { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(7)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Route Information with Preference
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(8)]
        public virtual List<R2A> R2A { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(9)]
        public virtual List<Loop_N1_301> N1Loop { get; set; }
        /// <summary>
        /// Loop for Port or Terminal
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(10)]
        public virtual List<Loop_R4_301> R4Loop { get; set; }
        /// <summary>
        /// Equipment and Temperature
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual W09 W09 { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(12)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Equipment Attributes
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(13)]
        public virtual List<EA> EA { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(14)]
        public virtual List<Loop_LX_301> LXLoop { get; set; }
        /// <summary>
        /// Vessel Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(15)]
        public virtual List<V1> V1 { get; set; }
        /// <summary>
        /// Event Detail
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(16)]
        public virtual List<V9> V9 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual SE SE { get; set; }
    }
}
