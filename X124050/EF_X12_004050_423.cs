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
    /// Loop for Hazardous Identification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_LH1_423
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
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<Loop_N1_423_2> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_423
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
        /// Placement/Pull Data
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual XD XD { get; set; }
        /// <summary>
        /// Loop for Equipment Details
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(3)]
        public virtual List<Loop_N7_423> N7Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_423
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
        [Pos(3)]
        public virtual N3 N3 { get; set; }
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
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_423_2
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
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Equipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N7))]
    public class Loop_N7_423
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
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Placement/Pull Data
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual XD XD { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual R2 R2 { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual D9 D9 { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(11)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Hazardous Classification Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(12)]
        public virtual List<LH2> LH2 { get; set; }
        /// <summary>
        /// Hazardous Certification
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(13)]
        public virtual List<LH6> LH6 { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(14)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(15)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Hazardous Identification Information
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(16)]
        public virtual List<Loop_LH1_423> LH1Loop { get; set; }
    }
    
    /// <summary>
    /// Rail Industrial Switch List
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "423")]
    public class TS423 : EdiMessage
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual LQ LQ { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_N1_423> N1Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [ListCount(150)]
        [Pos(7)]
        public virtual List<Loop_LX_423> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
