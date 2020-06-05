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
    /// Loop for Account Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ACT))]
    public class Loop_ACT_822
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Account Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ACT ACT { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Adjustments to Balances or Services
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(3)]
        public virtual List<ADJ> ADJ { get; set; }
        /// <summary>
        /// Loop for Rate Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_RTE_822> RTELoop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_LX_822> LXLoop { get; set; }
        /// <summary>
        /// Loop for Service Charges
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_SER_822> SERLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Entity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENT))]
    public class Loop_ENT_822
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Entity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ENT ENT { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_N1_822> N1Loop { get; set; }
        /// <summary>
        /// Loop for Account Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_ACT_822> ACTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_822
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
        /// Balance Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<BLN> BLN { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_822
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Rate Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RTE))]
    public class Loop_RTE_822
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rate Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RTE RTE { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Charges
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SER))]
    public class Loop_SER_822
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Charges
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SER SER { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<CTP> CTP { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Account Analysis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "822")]
    public class TS822 : EdiMessage
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
        [Required]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_N1_822 N1Loop { get; set; }
        /// <summary>
        /// Loop for Rate Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_RTE_822> RTELoop { get; set; }
        /// <summary>
        /// Loop for Entity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual List<Loop_ENT_822> ENTLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
