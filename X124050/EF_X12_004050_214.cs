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
    /// Loop for Shipment Status Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AT7))]
    public class Loop_AT7_214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment Status Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AT7 AT7 { get; set; }
        /// <summary>
        /// Equipment, Shipment, or Real Property Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MS1 MS1 { get; set; }
        /// <summary>
        /// Equipment or Container Owner and Type
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<MS2> MS2 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual K1 K1 { get; set; }
        /// <summary>
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual M7 M7 { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_214
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
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Lading Exception Code
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<Q7> Q7 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        /// Shipment Weight, Packaging and Quantity Data
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<AT8> AT8 { get; set; }
        /// <summary>
        /// Loop for Shipment Status Details
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<Loop_AT7_214> AT7Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<Loop_N1_214> N1Loop { get; set; }
        /// <summary>
        /// Loop for Order Information Detail
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(10)]
        public virtual List<Loop_OID_214> OIDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_214
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
        public virtual G62 G62 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<L11> L11 { get; set; }
    }
    
    /// <summary>
    /// Loop for Order Information Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(OID))]
    public class Loop_OID_214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Order Information Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual OID OID { get; set; }
        /// <summary>
        /// Destination Quantity
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<SDQ> SDQ { get; set; }
    }
    
    /// <summary>
    /// Transportation Carrier Shipment Status Message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "214")]
    public class TS214 : EdiMessage
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
        /// Beginning Segment for Transportation Carrier Shipment Status Message
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B10 B10 { get; set; }
        /// <summary>
        /// Interline Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(3)]
        public virtual List<MS3> MS3 { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999999)]
        [Pos(4)]
        public virtual List<Loop_LX_214> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
