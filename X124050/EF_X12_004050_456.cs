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
    /// Loop for Rail Event Reporting
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ER))]
    public class Loop_ER_456
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rail Event Reporting
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ER ER { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Cross-Reference Equipment
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual NA NA { get; set; }
        /// <summary>
        /// Equipment Status
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ES ES { get; set; }
    }
    
    /// <summary>
    /// Loop for Estimated Time of Arrival and Car Scheduling
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IS1))]
    public class Loop_IS1_456
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Estimated Time of Arrival and Car Scheduling
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IS1 IS1 { get; set; }
        /// <summary>
        /// Interline Service Commitment Detail
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<ISC> ISC { get; set; }
        /// <summary>
        /// Scheduled Events
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<IS2> IS2 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_456
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
        /// Car Service Order
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual H5 H5 { get; set; }
        /// <summary>
        /// Intermodal Chassis Equipment
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual IC IC { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual D9 D9 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(7)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(9)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(10)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(11)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        /// Motor Vehicle Control
        /// </summary>
        [DataMember]
        [ListCount(36)]
        [Pos(12)]
        public virtual List<VC> VC { get; set; }
        /// <summary>
        /// Price Authority Identification
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(13)]
        public virtual List<PI> PI { get; set; }
        /// <summary>
        /// Loop for Stop-off Name
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(14)]
        public virtual List<Loop_S1_456> S1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Stop-off Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(S1))]
    public class Loop_S1_456
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
    /// Railroad Equipment Inquiry or Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "456")]
    public class TS456 : EdiMessage
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
        /// Beginning Segment for Equipment Inquiry or Advice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual EIA EIA { get; set; }
        /// <summary>
        /// Waybill Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N8> N8 { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(4)]
        public virtual List<Loop_LX_456> LXLoop { get; set; }
        /// <summary>
        /// Loop for Estimated Time of Arrival and Car Scheduling
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_IS1_456 IS1Loop { get; set; }
        /// <summary>
        /// Loop for Rail Event Reporting
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<Loop_ER_456> ERLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
