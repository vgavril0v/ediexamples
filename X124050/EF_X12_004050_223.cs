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
    /// Loop for Consolidated Shipment Invoice Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CSD))]
    public class Loop_CSD_223
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Consolidated Shipment Invoice Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CSD CSD { get; set; }
        /// <summary>
        /// Loop for Order Information Detail
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<Loop_OID_223> OIDLoop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<Loop_LX_223> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Consolidated Shipment Invoice Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CSD))]
    public class Loop_CSD_223_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Consolidated Shipment Invoice Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CSD CSD { get; set; }
        /// <summary>
        /// Shipment Weight, Packaging and Quantity Data
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AT8 AT8 { get; set; }
        /// <summary>
        /// Rate and Charges
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<L1> L1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_223
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LS LS { get; set; }
        /// <summary>
        /// Loop for Consolidated Shipment Invoice Data
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<Loop_CSD_223_2> CSDLoop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_223
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
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_LS_223 LSLoop { get; set; }
        /// <summary>
        /// Loop for Order Information Detail
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(8)]
        public virtual List<Loop_OID_223> OIDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_223
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
        [ListCount(5)]
        [Pos(5)]
        public virtual List<L11> L11 { get; set; }
    }
    
    /// <summary>
    /// Loop for Equipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N7))]
    public class Loop_N7_223
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<M7> M7 { get; set; }
    }
    
    /// <summary>
    /// Loop for Order Information Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(OID))]
    public class Loop_OID_223
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
    /// Consolidators Freight Bill and Invoice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "223")]
    public class TS223 : EdiMessage
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
        [Pos(2)]
        public virtual B10 B10 { get; set; }
        /// <summary>
        /// Invoice Type
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual B3A B3A { get; set; }
        /// <summary>
        /// Set Purpose
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual B2A B2A { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<Loop_N1_223> N1Loop { get; set; }
        /// <summary>
        /// Loop for Equipment Details
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<Loop_N7_223> N7Loop { get; set; }
        /// <summary>
        /// Loop for Consolidated Shipment Invoice Data
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(7)]
        public virtual List<Loop_CSD_223> CSDLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
