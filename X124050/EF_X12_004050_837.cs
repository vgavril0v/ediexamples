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
    /// Loop for Health Claim
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CLM))]
    public class Loop_CLM_837
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Health Claim
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CLM CLM { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(150)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Claim Codes
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CL1 CL1 { get; set; }
        /// <summary>
        /// Orthodontic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DN1 DN1 { get; set; }
        /// <summary>
        /// Tooth Summary
        /// </summary>
        [DataMember]
        [ListCount(35)]
        [Pos(5)]
        public virtual List<DN2> DN2 { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual CN1 CN1 { get; set; }
        /// <summary>
        /// Disability Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DSB DSB { get; set; }
        /// <summary>
        /// Peer Review Organization or Utilization Review
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual UR UR { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(40)]
        [Pos(10)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(11)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<K3> K3 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(13)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Ambulance Certification
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual CR1 CR1 { get; set; }
        /// <summary>
        /// Chiropractic Certification
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual CR2 CR2 { get; set; }
        /// <summary>
        /// Durable Medical Equipment Certification
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual CR3 CR3 { get; set; }
        /// <summary>
        /// Enteral or Parenteral Therapy Certification
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(17)]
        public virtual List<CR4> CR4 { get; set; }
        /// <summary>
        /// Oxygen Therapy Certification
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual CR5 CR5 { get; set; }
        /// <summary>
        /// Home Health Care Certification
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual CR6 CR6 { get; set; }
        /// <summary>
        /// Pacemaker Certification
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(20)]
        public virtual List<CR8> CR8 { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(21)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        /// Health Care Information Codes
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(22)]
        public virtual List<HI> HI { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(23)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Health Care Pricing
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual HCP HCP { get; set; }
        /// <summary>
        /// Loop for Home Health Treatment Plan Certification
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(25)]
        public virtual List<Loop_CR7_837> CR7Loop { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(26)]
        public virtual List<Loop_NM1_837_3> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Subscriber Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(27)]
        public virtual List<Loop_SBR_837> SBRLoop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual List<Loop_LX_837> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Home Health Treatment Plan Certification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CR7))]
    public class Loop_CR7_837
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Home Health Treatment Plan Certification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CR7 CR7 { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(2)]
        public virtual List<HSD> HSD { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_837
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HL HL { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRV PRV { get; set; }
        /// <summary>
        /// Subscriber Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SBR SBR { get; set; }
        /// <summary>
        /// Patient Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PAT PAT { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<Loop_NM1_837_2> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Health Claim
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(8)]
        public virtual List<Loop_CLM_837> CLMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_837
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
        /// Pricing Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CTP CTP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Industry Code Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_837
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LQ LQ { get; set; }
        /// <summary>
        /// Supporting Documentation
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<FRM> FRM { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_837
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
        /// Professional Service
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SV1 SV1 { get; set; }
        /// <summary>
        /// Institutional Service
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SV2 SV2 { get; set; }
        /// <summary>
        /// Dental Service
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SV3 SV3 { get; set; }
        /// <summary>
        /// Tooth Identification
        /// </summary>
        [DataMember]
        [ListCount(32)]
        [Pos(5)]
        public virtual List<TOO> TOO { get; set; }
        /// <summary>
        /// Drug Service
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SV4 SV4 { get; set; }
        /// <summary>
        /// Durable Medical Equipment Service
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SV5 SV5 { get; set; }
        /// <summary>
        /// Anesthesia Service
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SV6 SV6 { get; set; }
        /// <summary>
        /// Drug Adjudication
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SV7 SV7 { get; set; }
        /// <summary>
        /// Health Care Information Codes
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(10)]
        public virtual List<HI> HI { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Ambulance Certification
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual CR1 CR1 { get; set; }
        /// <summary>
        /// Chiropractic Certification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(13)]
        public virtual List<CR2> CR2 { get; set; }
        /// <summary>
        /// Durable Medical Equipment Certification
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual CR3 CR3 { get; set; }
        /// <summary>
        /// Enteral or Parenteral Therapy Certification
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(15)]
        public virtual List<CR4> CR4 { get; set; }
        /// <summary>
        /// Oxygen Therapy Certification
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual CR5 CR5 { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(17)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(18)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(19)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(20)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Contract Information
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual CN1 CN1 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(22)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(23)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(24)]
        public virtual List<K3> K3 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(25)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Purchase Service
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual PS1 PS1 { get; set; }
        /// <summary>
        /// Immunization Status
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual List<IMM> IMM { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [DataMember]
        [Pos(28)]
        public virtual HSD HSD { get; set; }
        /// <summary>
        /// Health Care Pricing
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual HCP HCP { get; set; }
        /// <summary>
        /// Loop for Item Identification
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual List<Loop_LIN_837> LINLoop { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(31)]
        public virtual List<Loop_NM1_837_3> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Service Line Adjudication
        /// </summary>
        [DataMember]
        [Pos(32)]
        public virtual List<Loop_SVD_837> SVDLoop { get; set; }
        /// <summary>
        /// Loop for Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual List<Loop_LQ_837> LQLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_837
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_837_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
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
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_837_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRV PRV { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_837_4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
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
        [ListCount(2)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Subscriber Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SBR))]
    public class Loop_SBR_837
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subscriber Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SBR SBR { get; set; }
        /// <summary>
        /// Claims Adjustment
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<CAS> CAS { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(3)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Other Health Insurance Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual OI OI { get; set; }
        /// <summary>
        /// Medicare Inpatient Adjudication
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual MIA MIA { get; set; }
        /// <summary>
        /// Medicare Outpatient Adjudication
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual MOA MOA { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<Loop_NM1_837_4> NM1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Service Line Adjudication
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SVD))]
    public class Loop_SVD_837
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Line Adjudication
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SVD SVD { get; set; }
        /// <summary>
        /// Claims Adjustment
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<CAS> CAS { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "837")]
    public class TS837 : EdiMessage
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
        /// Beginning of Hierarchical Transaction
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BHT BHT { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<Loop_NM1_837> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual List<Loop_HL_837> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
