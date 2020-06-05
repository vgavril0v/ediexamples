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
    /// Loop for Hazardous Material
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(H1))]
    public class Loop_H1_309
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual H1 H1 { get; set; }
        /// <summary>
        /// Additional Hazardous Material Description
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<H2> H2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_309
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
        /// Manifest Amendment Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual M13 M13 { get; set; }
        /// <summary>
        /// Manifest Bill of Lading Details
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual M11 M11 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<Loop_N1_309> N1Loop { get; set; }
        /// <summary>
        /// Loop for In-bond Identifying Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_M12_309 M12Loop { get; set; }
        /// <summary>
        /// Loop for Conveyance Identification
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(7)]
        public virtual List<Loop_VID_309> VIDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for In-bond Identifying Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M12))]
    public class Loop_M12_309
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// In-bond Identifying Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M12 M12 { get; set; }
        /// <summary>
        /// Port or Terminal
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<R4> R4 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_309
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual X1 X1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Quantity and Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N10))]
    public class Loop_N10_309
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity and Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N10 N10 { get; set; }
        /// <summary>
        /// Motor Vehicle Control
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<VC> VC { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(3)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Loop for Hazardous Material
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<Loop_H1_309> H1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Port Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(P4))]
    public class Loop_P4_309
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Port Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual P4 P4 { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<Loop_LX_309> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Conveyance Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VID))]
    public class Loop_VID_309
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Conveyance Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VID VID { get; set; }
        /// <summary>
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        /// Loop for Quantity and Description
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(3)]
        public virtual List<Loop_N10_309> N10Loop { get; set; }
    }
    
    /// <summary>
    /// Customs Manifest
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "309")]
    public class TS309 : EdiMessage
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
        /// Manifest Identifying Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual M10 M10 { get; set; }
        /// <summary>
        /// Loop for Port Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<Loop_P4_309> P4Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
