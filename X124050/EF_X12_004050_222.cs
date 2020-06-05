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
    /// Loop for Contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G61))]
    public class Loop_G61_222
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
        public virtual List<Loop_LH1_222> LH1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Lading Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LAD))]
    public class Loop_LAD_222
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lading Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LAD LAD { get; set; }
        /// <summary>
        /// Loop for Contact
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_G61_222 G61Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Hazardous Identification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_LH1_222
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
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_222
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
        [ListCount(5)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Bill of Lading Rates and Charges
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual AT3 AT3 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_222
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
    /// Loop for Equipment Placement Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PLC))]
    public class Loop_PLC_222
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Placement Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PLC PLC { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<N7> N7 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(4)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(6)]
        public virtual List<Loop_LX_222> LXLoop { get; set; }
        /// <summary>
        /// Loop for Stop-off Details
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(7)]
        public virtual List<Loop_S5_222> S5Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Stop-off Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(S5))]
    public class Loop_S5_222
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
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(4)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        /// Pallet Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<PLD> PLD { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual Loop_N1_222 N1Loop { get; set; }
        /// <summary>
        /// Loop for Lading Detail
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<Loop_LAD_222> LADLoop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(9)]
        public virtual List<Loop_LX_222> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Cartage Work Assignment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "222")]
    public class TS222 : EdiMessage
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
        /// Beginning Segment for Cartage Work Assignment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual SCN SCN { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual G62 G62 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_N1_222> N1Loop { get; set; }
        /// <summary>
        /// Loop for Equipment Placement Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(7)]
        public virtual List<Loop_PLC_222> PLCLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
