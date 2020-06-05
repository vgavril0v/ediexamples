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
    /// Loop for Electronic Format Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EFI))]
    public class Loop_EFI_240
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Electronic Format Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EFI EFI { get; set; }
        /// <summary>
        /// Binary Data Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BIN BIN { get; set; }
    }
    
    /// <summary>
    /// Loop for Business Instructions and Reference Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L11))]
    public class Loop_L11_240
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L11 L11 { get; set; }
        /// <summary>
        /// Equipment or Container Owner and Type
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<MS2> MS2 { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_LS_240 LSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_240
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
        /// Loop for Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_MAN_240> MANLoop { get; set; }
        /// <summary>
        /// Loop for Electronic Format Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_EFI_240 EFILoop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_240
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
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_N1_240_2 N1Loop { get; set; }
        /// <summary>
        /// Loop for Electronic Format Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_EFI_240 EFILoop { get; set; }
        /// <summary>
        /// Loop for Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_L11_240> L11Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Marks and Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MAN))]
    public class Loop_MAN_240
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MAN MAN { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Shipment Status Details
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<AT7> AT7 { get; set; }
        /// <summary>
        /// Carton (Package) Detail
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<CD3> CD3 { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Lading Exception Code
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Q7> Q7 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_240
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
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
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
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_240_2
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
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
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
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual NTE NTE { get; set; }
    }
    
    /// <summary>
    /// Motor Carrier Package Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "240")]
    public class TS240 : EdiMessage
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
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_N1_240> N1Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_LX_240> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
