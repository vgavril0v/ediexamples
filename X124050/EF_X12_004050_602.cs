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
    public class Loop_LX_602
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
        /// Scale Rate Detail
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SRD SRD { get; set; }
        /// <summary>
        /// Loop for Scale Rates
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(3)]
        public virtual List<Loop_SRM_602> SRMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_602
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
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Product (Commodity)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PR))]
    public class Loop_PR_602
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product (Commodity)
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PR PR { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Shipment Conditions
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<CD> CD { get; set; }
    }
    
    /// <summary>
    /// Loop for Rate Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RA))]
    public class Loop_RA_602
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rate Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RA RA { get; set; }
        /// <summary>
        /// Rate/Minimum Detail
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(2)]
        public virtual List<RB> RB { get; set; }
        /// <summary>
        /// Factor
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(3)]
        public virtual List<FK> FK { get; set; }
    }
    
    /// <summary>
    /// Loop for Personal Property Rate
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RH))]
    public class Loop_RH_602
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Personal Property Rate
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RH RH { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
    }
    
    /// <summary>
    /// Loop for Docket Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SB))]
    public class Loop_SB_602
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
        [ListCount(999)]
        [Pos(2)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        /// Loop for Docket Sub-level
        /// </summary>
        [DataMember]
        [ListCount(400)]
        [Pos(3)]
        public virtual List<Loop_SC_602> SCLoop { get; set; }
        /// <summary>
        /// Loop for Scale Rate Header
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(4)]
        public virtual List<Loop_SRT_602> SRTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Docket Sub-level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SC))]
    public class Loop_SC_602
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
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        /// Shipment Conditions
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(3)]
        public virtual List<CD> CD { get; set; }
        /// <summary>
        /// Loop for Rate Header
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<Loop_RA_602> RALoop { get; set; }
        /// <summary>
        /// Loop for Personal Property Rate
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<Loop_RH_602> RHLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Scale Rates
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SRM))]
    public class Loop_SRM_602
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Scale Rates
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SRM SRM { get; set; }
        /// <summary>
        /// Traffic Evaluation Factors
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<SRA> SRA { get; set; }
    }
    
    /// <summary>
    /// Loop for Scale Rate Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SRT))]
    public class Loop_SRT_602
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Scale Rate Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SRT SRT { get; set; }
        /// <summary>
        /// Minimum Detail
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<MIN> MIN { get; set; }
        /// <summary>
        /// Scale Rate Detail
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(3)]
        public virtual List<SRD> SRD { get; set; }
        /// <summary>
        /// Scale Rates
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(4)]
        public virtual List<SRM> SRM { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(6)]
        public virtual List<Loop_LX_602> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Transportation Services Tender
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "602")]
    public class TS602 : EdiMessage
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
        /// Docket Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual DK DK { get; set; }
        /// <summary>
        /// External Reference Identifier
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(3)]
        public virtual List<PRI> PRI { get; set; }
        /// <summary>
        /// Docket Control Status
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SS SS { get; set; }
        /// <summary>
        /// Status Action
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<SA> SA { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Shipment Conditions
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(7)]
        public virtual List<CD> CD { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(8)]
        public virtual List<Loop_N1_602> N1Loop { get; set; }
        /// <summary>
        /// Loop for Product (Commodity)
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(9)]
        public virtual List<Loop_PR_602> PRLoop { get; set; }
        /// <summary>
        /// Loop for Docket Level
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(10)]
        public virtual List<Loop_SB_602> SBLoop { get; set; }
        /// <summary>
        /// Miscellaneous Services
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(11)]
        public virtual List<MS> MS { get; set; }
        /// <summary>
        /// Demurrage/Detention/ Storage Rate
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(12)]
        public virtual List<DM> DM { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual SE SE { get; set; }
    }
}
