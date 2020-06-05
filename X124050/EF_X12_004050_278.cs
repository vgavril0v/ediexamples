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
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_278
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
        /// Trace
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<TRN> TRN { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<AAA> AAA { get; set; }
        /// <summary>
        /// Health Care Services Review Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual UM UM { get; set; }
        /// <summary>
        /// Health Care Services Review
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual HCR HCR { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Health Care Information Codes
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual HI HI { get; set; }
        /// <summary>
        /// Professional Service
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SV1 SV1 { get; set; }
        /// <summary>
        /// Institutional Service
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual SV2 SV2 { get; set; }
        /// <summary>
        /// Dental Service
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual SV3 SV3 { get; set; }
        /// <summary>
        /// Tooth Identification
        /// </summary>
        [DataMember]
        [ListCount(32)]
        [Pos(12)]
        public virtual List<TOO> TOO { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual HSD HSD { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(14)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        /// Claim Codes
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual CL1 CL1 { get; set; }
        /// <summary>
        /// Ambulance Certification
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual CR1 CR1 { get; set; }
        /// <summary>
        /// Chiropractic Certification
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual CR2 CR2 { get; set; }
        /// <summary>
        /// Enteral or Parenteral Therapy Certification
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual CR4 CR4 { get; set; }
        /// <summary>
        /// Oxygen Therapy Certification
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual CR5 CR5 { get; set; }
        /// <summary>
        /// Home Health Care Certification
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual CR6 CR6 { get; set; }
        /// <summary>
        /// Home Health Treatment Plan Certification
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual CR7 CR7 { get; set; }
        /// <summary>
        /// Pacemaker Certification
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual CR8 CR8 { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual MSG MSG { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual List<Loop_NM1_278> NM1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_278
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N2 N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<AAA> AAA { get; set; }
        /// <summary>
        /// Provider Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual PRV PRV { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Insured Benefit
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual INS INS { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(11)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Health Care Services Review Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "278")]
    public class TS278 : EdiMessage
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
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_HL_278> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
