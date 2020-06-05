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
    /// Loop for Certifications and Clauses
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(C8))]
    public class Loop_C8_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Certifications and Clauses
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C8 C8 { get; set; }
        /// <summary>
        /// Certifications Clauses Continuation
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<C8C> C8C { get; set; }
        /// <summary>
        /// Supplementary Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<SUP> SUP { get; set; }
    }
    
    /// <summary>
    /// Loop for Pricing Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTP))]
    public class Loop_CTP_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CTP CTP { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Loop for Hazardous Material
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(H1))]
    public class Loop_H1_304
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
        [ListCount(10)]
        [Pos(2)]
        public virtual List<H2> H2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Item - Quantity and Weight
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L0))]
    public class Loop_L0_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L0 L0 { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Item Physical Details
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(4)]
        public virtual List<Loop_PO4_304> PO4Loop { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual L4 L4 { get; set; }
        /// <summary>
        /// Hazardous Certification
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(7)]
        public virtual List<LH6> LH6 { get; set; }
        /// <summary>
        /// Loop for Pallet Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(8)]
        public virtual List<Loop_PAL_304> PALLoop { get; set; }
        /// <summary>
        /// Loop for Pricing Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Loop_CTP_304 CTPLoop { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(10)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Alternate Lading Description
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(12)]
        public virtual List<L12> L12 { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(13)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Loop for Rate and Charges
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(14)]
        public virtual List<Loop_L1_304> L1Loop { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual L7 L7 { get; set; }
        /// <summary>
        /// Loop for Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(16)]
        public virtual List<Loop_SAC_304> SACLoop { get; set; }
        /// <summary>
        /// Loop for Charge Detail
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(17)]
        public virtual List<Loop_L9_304> L9Loop { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(18)]
        public virtual List<X1> X1 { get; set; }
        /// <summary>
        /// Import License
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(19)]
        public virtual List<X2> X2 { get; set; }
        /// <summary>
        /// Loop for Certifications and Clauses
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(20)]
        public virtual List<Loop_C8_304> C8Loop { get; set; }
        /// <summary>
        /// Loop for Hazardous Material
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(21)]
        public virtual List<Loop_H1_304> H1Loop { get; set; }
        /// <summary>
        /// Loop for Hazardous Identification Information
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(22)]
        public virtual List<Loop_LH1_304> LH1Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(23)]
        public virtual List<Loop_N1_304> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Rate and Charges
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L1))]
    public class Loop_L1_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rate and Charges
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L1 L1 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Loop for Total Weight and Charges
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L3))]
    public class Loop_L3_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Total Weight and Charges
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L3 L3 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(4)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Supplementary Information
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(5)]
        public virtual List<SUP> SUP { get; set; }
        /// <summary>
        /// Loop for Rate and Charges
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<Loop_L1_304> L1Loop { get; set; }
        /// <summary>
        /// Loop for Total Monetary Value Summary
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_TDS_304 TDSLoop { get; set; }
        /// <summary>
        /// Loop for Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<Loop_SAC_304> SACLoop { get; set; }
        /// <summary>
        /// Loop for Charge Detail
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_L9_304> L9Loop { get; set; }
        /// <summary>
        /// Invoice Shipment Summary
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public virtual List<ISS> ISS { get; set; }
        /// <summary>
        /// Event Detail
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<V9> V9 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(12)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(24)]
        [Pos(13)]
        public virtual List<L11> L11 { get; set; }
    }
    
    /// <summary>
    /// Loop for Charge Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L9))]
    public class Loop_L9_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Charge Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L9 L9 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Loop for Hazardous Identification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_LH1_304
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
        [ListCount(25)]
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
        /// <summary>
        /// Hazardous Material Identifying Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<LHR> LHR { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_304
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
        /// Container Details
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Y2> Y2 { get; set; }
        /// <summary>
        /// Loop for Equipment Details
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(3)]
        public virtual List<Loop_N7_304> N7Loop { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(4)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Item Physical Details
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(6)]
        public virtual List<Loop_PO4_304> PO4Loop { get; set; }
        /// <summary>
        /// Loop for Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [ListCount(120)]
        [Pos(7)]
        public virtual List<Loop_L0_304> L0Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Insurance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M1))]
    public class Loop_M1_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Insurance
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M1 M1 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_304
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
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<G61> G61 { get; set; }
    }
    
    /// <summary>
    /// Loop for Equipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N7))]
    public class Loop_N7_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual L4 L4 { get; set; }
        /// <summary>
        /// Equipment Environment
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N12 N12 { get; set; }
        /// <summary>
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        /// Seal Number Replacement
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(6)]
        public virtual List<M7A> M7A { get; set; }
        /// <summary>
        /// Equipment and Temperature
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual W09 W09 { get; set; }
        /// <summary>
        /// Hazardous Certification
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(8)]
        public virtual List<LH6> LH6 { get; set; }
        /// <summary>
        /// Loop for Rate and Charges
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(9)]
        public virtual List<Loop_L1_304> L1Loop { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual L7 L7 { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(11)]
        public virtual List<X1> X1 { get; set; }
        /// <summary>
        /// Import License
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(12)]
        public virtual List<X2> X2 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(13)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Hazardous Material
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(14)]
        public virtual List<Loop_H1_304> H1Loop { get; set; }
        /// <summary>
        /// Loop for Hazardous Identification Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(15)]
        public virtual List<Loop_LH1_304> LH1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Pallet Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAL))]
    public class Loop_PAL_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pallet Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAL PAL { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Physical Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PO4))]
    public class Loop_PO4_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
    }
    
    /// <summary>
    /// Loop for Port or Terminal
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(R4))]
    public class Loop_R4_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Port or Terminal
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual R4 R4 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Service, Promotion, Allowance, or Charge Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SAC))]
    public class Loop_SAC_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SAC SAC { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Loop for Total Monetary Value Summary
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TDS))]
    public class Loop_TDS_304
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Total Monetary Value Summary
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TDS TDS { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Shipping Instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "304")]
    public class TS304 : EdiMessage
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
        /// Beginning Segment for Shipment Information Transaction
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B2 B2 { get; set; }
        /// <summary>
        /// Set Purpose
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual B2A B2A { get; set; }
        /// <summary>
        /// Authentication
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<Y6> Y6 { get; set; }
        /// <summary>
        /// Shipment Type Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual G1 G1 { get; set; }
        /// <summary>
        /// Beyond Routing
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual G2 G2 { get; set; }
        /// <summary>
        /// Compensation Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual G3 G3 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(8)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Vessel Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(10)]
        public virtual List<V1> V1 { get; set; }
        /// <summary>
        /// Vessel Schedule
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual V3 V3 { get; set; }
        /// <summary>
        /// Letter of Credit Reference
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual M0 M0 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Loop for Insurance
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(14)]
        public virtual List<Loop_M1_304> M1Loop { get; set; }
        /// <summary>
        /// Sales/Delivery Terms
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual M2 M2 { get; set; }
        /// <summary>
        /// Bank ID
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual C2 C2 { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual ITD ITD { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(18)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(19)]
        public virtual List<Loop_N1_304> N1Loop { get; set; }
        /// <summary>
        /// Loop for Port or Terminal
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(20)]
        public virtual List<Loop_R4_304> R4Loop { get; set; }
        /// <summary>
        /// Route Information with Preference
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(21)]
        public virtual List<R2A> R2A { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(22)]
        public virtual List<R2> R22 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(23)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(24)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(25)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(26)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(27)]
        public virtual List<X1> X1 { get; set; }
        /// <summary>
        /// Import License
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(28)]
        public virtual List<X2> X2 { get; set; }
        /// <summary>
        /// Loop for Certifications and Clauses
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(29)]
        public virtual List<Loop_C8_304> C8Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(30)]
        public virtual List<Loop_LX_304> LXLoop { get; set; }
        /// <summary>
        /// Loop for Total Weight and Charges
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual Loop_L3_304 L3Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(32)]
        public virtual SE SE { get; set; }
    }
}
