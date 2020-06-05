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
    public class Loop_LX_460
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
        /// Rate Subset
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<RS> RS { get; set; }
        /// <summary>
        /// Rate Data
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(3)]
        public virtual List<RD> RD { get; set; }
        /// <summary>
        /// Loop for Route Code Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<Loop_R9_460> R9Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Patron
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PT))]
    public class Loop_PT_460
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patron
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PT PT { get; set; }
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
    /// Loop for Junctions and Proportions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(R2B))]
    public class Loop_R2B_460
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
        [ListCount(25)]
        [Pos(2)]
        public virtual List<R2C> R2C { get; set; }
    }
    
    /// <summary>
    /// Loop for Route Code Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(R9))]
    public class Loop_R9_460
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
        /// Factor
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(2)]
        public virtual List<FK> FK { get; set; }
        /// <summary>
        /// Loop for Junctions and Proportions
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(3)]
        public virtual List<Loop_R2B_460> R2BLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Docket Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SB))]
    public class Loop_SB_460
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Docket Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SB SB { get; set; }
        /// <summary>
        /// Geography
        /// </summary>
        [DataMember]
        [ListCount(150)]
        [Pos(2)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        /// Loop for Docket Sub-level
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(300)]
        [Pos(3)]
        public virtual List<Loop_SC_460> SCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Docket Sub-level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SC))]
    public class Loop_SC_460
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Docket Sub-level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SC SC { get; set; }
        /// <summary>
        /// Geography
        /// </summary>
        [DataMember]
        [ListCount(150)]
        [Pos(2)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        /// Shipment Conditions
        /// </summary>
        [DataMember]
        [ListCount(150)]
        [Pos(3)]
        public virtual List<CD> CD { get; set; }
        /// <summary>
        /// Rate or Minimum Qualifiers
        /// </summary>
        [DataMember]
        [ListCount(48)]
        [Pos(4)]
        public virtual List<RAB> RAB { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(60)]
        [Pos(5)]
        public virtual List<Loop_LX_460> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Railroad Price Distribution Request or Response
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "460")]
    public class TS460 : EdiMessage
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
        /// Rate or Minimum Qualifiers
        /// </summary>
        [DataMember]
        [ListCount(48)]
        [Pos(9)]
        public virtual List<RAB> RAB { get; set; }
        /// <summary>
        /// Loop for Patron
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(10)]
        public virtual List<Loop_PT_460> PTLoop { get; set; }
        /// <summary>
        /// Loop for Docket Level
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(50)]
        [Pos(11)]
        public virtual List<Loop_SB_460> SBLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual SE SE { get; set; }
    }
}
