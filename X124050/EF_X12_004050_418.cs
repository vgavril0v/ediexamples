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
    public class Loop_LH1_418
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
        public virtual List<Loop_N1_418> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_418
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
        /// Loop for Hazardous Identification Information
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(2)]
        public virtual List<Loop_LH1_418> LH1Loop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_418
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
    /// Loop for Block Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(W1))]
    public class Loop_W1_418
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Block Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual W1 W1 { get; set; }
        /// <summary>
        /// Loop for Equipment Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(400)]
        [Pos(2)]
        public virtual List<Loop_W2_418> W2Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Equipment Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(W2))]
    public class Loop_W2_418
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual W2 W2 { get; set; }
        /// <summary>
        /// Consignee Information
        /// </summary>
        [DataMember]
        [ListCount(7)]
        [Pos(2)]
        public virtual List<W3> W3 { get; set; }
        /// <summary>
        /// Interchange Move Authority
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<IMA> IMA { get; set; }
        /// <summary>
        /// Consignor Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual W4 W4 { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(5)]
        public virtual List<W5> W5 { get; set; }
        /// <summary>
        /// Special Handling Information
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(6)]
        public virtual List<W6> W6 { get; set; }
        /// <summary>
        /// Protective Service Instructions
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<PS> PS { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Loop_LS_418 LSLoop { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Hazardous Classification Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual LH2 LH2 { get; set; }
        /// <summary>
        /// Hazardous Material Identifying Reference Numbers
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual LHR LHR { get; set; }
    }
    
    /// <summary>
    /// Rail Advance Interchange Consist
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "418")]
    public class TS418 : EdiMessage
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
        /// Beginning Segment for Advance Consist and Transportation Automatic Equipment ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BAX BAX { get; set; }
        /// <summary>
        /// Loop for Block Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(30)]
        [Pos(3)]
        public virtual List<Loop_W1_418> W1Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
