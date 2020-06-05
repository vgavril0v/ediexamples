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
    /// Loop for Load and Equipment Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LET))]
    public class Loop_LET_470
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Load and Equipment Type
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LET LET { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(75)]
        [Pos(3)]
        public virtual List<L4> L4 { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// Weight Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual L10 L10 { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<Loop_LX_470> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_470
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
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(3)]
        public virtual List<L5> L5 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_470
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
    /// Railroad Clearance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "470")]
    public class TS470 : EdiMessage
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
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual D9 D9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(7)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(8)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        /// Loop for Load and Equipment Type
        /// </summary>
        [DataMember]
        [ListCount(150)]
        [Pos(9)]
        public virtual List<Loop_LET_470> LETLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public virtual List<Loop_N1_470> N1Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual SE SE { get; set; }
    }
}
