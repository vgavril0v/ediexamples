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
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_494
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
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Price Authority Identification
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(3)]
        public virtual List<PI> PI { get; set; }
    }
    
    /// <summary>
    /// Loop for Junctions and Proportions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(R2B))]
    public class Loop_R2B_494
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Junctions and Proportions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual R2B R2B { get; set; }
        /// <summary>
        /// Division Basis
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<R2C> R2C { get; set; }
    }
    
    /// <summary>
    /// Loop for Route Code Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(R9))]
    public class Loop_R9_494
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Route Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual R9 R9 { get; set; }
        /// <summary>
        /// Loop for Junctions and Proportions
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Loop_R2B_494> R2BLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Rate Basis/Scales
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCL))]
    public class Loop_SCL_494
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rate Basis/Scales
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SCL SCL { get; set; }
        /// <summary>
        /// Rate Data
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(2)]
        public virtual List<RD> RD { get; set; }
    }
    
    /// <summary>
    /// Rail Scale Rates
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "494")]
    public class TS494 : EdiMessage
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
        /// Rate Request Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual REN REN { get; set; }
        /// <summary>
        /// Docket Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual DK DK { get; set; }
        /// <summary>
        /// Price Authority Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(8)]
        [Pos(4)]
        public virtual List<PI> PI { get; set; }
        /// <summary>
        /// Product (Commodity)
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(5)]
        public virtual List<PR> PR { get; set; }
        /// <summary>
        /// Docket Control Status
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SS SS { get; set; }
        /// <summary>
        /// Status Action
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual SA SA { get; set; }
        /// <summary>
        /// Shipment Conditions
        /// </summary>
        [DataMember]
        [ListCount(150)]
        [Pos(8)]
        public virtual List<CD> CD { get; set; }
        /// <summary>
        /// Geography
        /// </summary>
        [DataMember]
        [ListCount(150)]
        [Pos(9)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        /// Rate or Minimum Qualifiers
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(10)]
        public virtual List<RAB> RAB { get; set; }
        /// <summary>
        /// Patron
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(11)]
        public virtual List<PT> PT { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual Loop_LX_494 LXLoop { get; set; }
        /// <summary>
        /// Loop for Route Code Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(13)]
        public virtual List<Loop_R9_494> R9Loop { get; set; }
        /// <summary>
        /// Loop for Rate Basis/Scales
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(14)]
        public virtual List<Loop_SCL_494> SCLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual SE SE { get; set; }
    }
}
