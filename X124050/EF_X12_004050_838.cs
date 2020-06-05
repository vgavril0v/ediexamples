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
    /// Loop for Electronic Systems Environment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENE))]
    public class Loop_ENE_838
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Electronic Systems Environment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ENE ENE { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_N1_838_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Capabilities
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_TXN_838> TXNLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Place/Location Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LCD))]
    public class Loop_LCD_838
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Place/Location Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LCD LCD { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N2 N2 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DMG> DMG { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<MEA> MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_838
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_838
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
        /// Loop for Trade Union Data
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_TUD_838> TUDLoop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_838
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
        /// Place or Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PLA PLA { get; set; }
        /// <summary>
        /// Place/Location Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<LCD> LCD { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_N1_838> N1Loop { get; set; }
        /// <summary>
        /// Loop for Electronic Systems Environment
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_ENE_838> ENELoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_838
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
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<CUR> CUR { get; set; }
        /// <summary>
        /// Tax Reference
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<TAX> TAX { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<FOB> FOB { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<ITD> ITD { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Specification Identifier
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<SPI> SPI { get; set; }
        /// <summary>
        /// Foreign and Industry Business
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<FBB> FBB { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(14)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Loop for Place/Location Description
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_LCD_838> LCDLoop { get; set; }
        /// <summary>
        /// Loop for Trading Partner Detail
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<Loop_TPD_838> TPDLoop { get; set; }
        /// <summary>
        /// Loop for Period Amount
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<Loop_PAM_838> PAMLoop { get; set; }
        /// <summary>
        /// Loop for Transaction Capabilities
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual List<Loop_TXN_838> TXNLoop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<Loop_LM_838> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_838_2
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
        /// Trading Partner Detail
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<TPD> TPD { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Period Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAM))]
    public class Loop_PAM_838
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAM PAM { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Tax Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<TAX> TAX { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<CUR> CUR { get; set; }
    }
    
    /// <summary>
    /// Loop for Supplier Rating
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SPR))]
    public class Loop_SPR_838
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Supplier Rating
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SPR SPR { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Trading Partner Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TPD))]
    public class Loop_TPD_838
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Trading Partner Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TPD TPD { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_LS_838 LSLoop { get; set; }
        /// <summary>
        /// Loop for Supplier Rating
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_SPR_838> SPRLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Trade Union Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TUD))]
    public class Loop_TUD_838
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Trade Union Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TUD TUD { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Capabilities
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TXN))]
    public class Loop_TXN_838
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Capabilities
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TXN TXN { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Trading Partner Profile
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "838")]
    public class TS838 : EdiMessage
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
        /// Beginning Segment For Trading Partner Profile
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BTP BTP { get; set; }
        /// <summary>
        /// Request Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REQ REQ { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Specification Identifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<SPI> SPI { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_LX_838> LXLoop { get; set; }
        /// <summary>
        /// Entity Relationship
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<ERI> ERI { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual SE SE { get; set; }
    }
}
