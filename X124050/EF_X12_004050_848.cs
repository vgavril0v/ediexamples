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
    /// Loop for Characteristic/Class ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CID))]
    public class Loop_CID_848
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Characteristic/Class ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CID CID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_848
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Loop for Material Safety Data Sheet Section Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_MSS_848> MSSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_848
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
        /// Characteristic/Class ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CID CID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Statistics
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual STA STA { get; set; }
        /// <summary>
        /// Test Method
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual TMD TMD { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Safety Data
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_SD1_848> SD1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Material Safety Data Sheet Section Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MSS))]
    public class Loop_MSS_848
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Material Safety Data Sheet Section Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MSS MSS { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Safety Data
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_SD1_848> SD1Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_LX_848> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_848
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
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Safety Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SD1))]
    public class Loop_SD1_848
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Safety Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SD1 SD1 { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Characteristic/Class ID
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_CID_848> CIDLoop { get; set; }
    }
    
    /// <summary>
    /// Material Safety Data Sheet
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "848")]
    public class TS848 : EdiMessage
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
        /// Beginning Segment For Material Safety Data Sheet
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BMS BMS { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_N1_848> N1Loop { get; set; }
        /// <summary>
        /// Loop for Item Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_LIN_848> LINLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
