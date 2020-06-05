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
    /// Loop for Bill of Lading Line Item Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AT1))]
    public class Loop_AT1_211
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Bill of Lading Line Item Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AT1 AT1 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Bill of Lading Rates and Charges
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AT3 AT3 { get; set; }
        /// <summary>
        /// Bill of Lading Description
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<AT4> AT4 { get; set; }
        /// <summary>
        /// Loop for Bill of Lading Line Item Detail
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_AT2_211 AT2Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(6)]
        public virtual List<Loop_LX_211> LXLoop { get; set; }
        /// <summary>
        /// Loop for Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<Loop_G61_211> G61Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Bill of Lading Line Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AT2))]
    public class Loop_AT2_211
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Bill of Lading Line Item Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AT2 AT2 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(2)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Order Information Detail
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(3)]
        public virtual List<OID> OID { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual L4 L4 { get; set; }
    }
    
    /// <summary>
    /// Loop for Contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G61))]
    public class Loop_G61_211
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
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Hazardous Certification
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(3)]
        public virtual List<LH6> LH6 { get; set; }
        /// <summary>
        /// Loop for Hazardous Identification Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(25)]
        [Pos(4)]
        public virtual List<Loop_LH1_211> LH1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Hazardous Identification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_LH1_211
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
        [ListCount(20)]
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
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<L11> L11 { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_211
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
        [ListCount(999999)]
        [Pos(2)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Order Information Detail
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(3)]
        public virtual List<OID> OID { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_211
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
    /// Motor Carrier Bill of Lading
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "211")]
    public class TS211 : EdiMessage
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
        /// Beginning Segment for the Motor Carrier Bill of Lading
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BOL BOL { get; set; }
        /// <summary>
        /// Set Purpose
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual B2A B2A { get; set; }
        /// <summary>
        /// Interline Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(4)]
        public virtual List<MS3> MS3 { get; set; }
        /// <summary>
        /// Equipment or Container Owner and Type
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual MS2 MS2 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(6)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(7)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(8)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<Loop_N1_211> N1Loop { get; set; }
        /// <summary>
        /// Loop for Bill of Lading Line Item Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(11)]
        public virtual List<Loop_AT1_211> AT1Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual SE SE { get; set; }
    }
}
