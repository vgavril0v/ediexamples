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
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_163
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
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Loop for Order Information Detail
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<Loop_OID_163> OIDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Order Information Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(OID))]
    public class Loop_OID_163
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
    /// Loop for Stop-off Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(S5))]
    public class Loop_S5_163
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stop-off Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual S5 S5 { get; set; }
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
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Special Services
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<H6> H6 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Loop for Order Information Detail
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_OID_163> OIDLoop { get; set; }
    }
    
    /// <summary>
    /// Transportation Appointment Schedule Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "163")]
    public class TS163 : EdiMessage
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
        /// Beginning Segment for Appointment Schedule
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B13 B13 { get; set; }
        /// <summary>
        /// Set Purpose
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual B2A B2A { get; set; }
        /// <summary>
        /// Special Services
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<H6> H6 { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<N7> N7 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(7)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Total Shipment Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual G05 G05 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(10)]
        public virtual List<Loop_N1_163> N1Loop { get; set; }
        /// <summary>
        /// Loop for Stop-off Details
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(11)]
        public virtual List<Loop_S5_163> S5Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual SE SE { get; set; }
    }
}
