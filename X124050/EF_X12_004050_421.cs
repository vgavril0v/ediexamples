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
    public class Loop_LH1_421
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
        public virtual List<Loop_N1_421> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_421
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
        public virtual List<Loop_LH1_421> LH1Loop { get; set; }
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
    public class Loop_N1_421
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
    /// Loop for Stop-off Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(S1))]
    public class Loop_S1_421
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stop-off Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual S1 S1 { get; set; }
        /// <summary>
        /// Stop-off Station
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual S9 S9 { get; set; }
    }
    
    /// <summary>
    /// Estimated Time of Arrival and Car Scheduling
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "421")]
    public class TS421 : EdiMessage
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
        /// Estimated Time of Arrival and Car Scheduling
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual IS1 IS1 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Interline Service Commitment Detail
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<ISC> ISC { get; set; }
        /// <summary>
        /// Waybill Reference
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N8 N8 { get; set; }
        /// <summary>
        /// Scheduled Events
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual List<IS2> IS2 { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual D9 D9 { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(10)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(11)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(12)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Car Service Order
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual H5 H5 { get; set; }
        /// <summary>
        /// Intermodal Chassis Equipment
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual IC IC { get; set; }
        /// <summary>
        /// Interchange Move Authority
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual IMA IMA { get; set; }
        /// <summary>
        /// Protective Service Instructions
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual PS PS { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(17)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Additional Reference Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(18)]
        public virtual List<N8A> N8A { get; set; }
        /// <summary>
        /// Loop for Stop-off Name
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(19)]
        public virtual List<Loop_S1_421> S1Loop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual Loop_LS_421 LSLoop { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(21)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual SE SE { get; set; }
    }
}
