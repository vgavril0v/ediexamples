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
    /// Loop for Monetary Amount Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_AMT_142
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<TXI> TXI { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Loop for Characteristic/Class ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CID))]
    public class Loop_CID_142
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Characteristic/Class ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CID CID { get; set; }
        /// <summary>
        /// Test Method
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<TMD> TMD { get; set; }
        /// <summary>
        /// Loop for Measurements
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_MEA_142> MEALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Baseline Item Data (Invoice)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IT1))]
    public class Loop_IT1_142
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Baseline Item Data (Invoice)
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IT1 IT1 { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Part Disposition
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PRT PRT { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<ITA> ITA { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_142
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
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Product Service Contract
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<PSC> PSC { get; set; }
        /// <summary>
        /// Product Special Services
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<SSS> SSS { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_142
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
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_142
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
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<Loop_N9_142> N9Loop { get; set; }
        /// <summary>
        /// Loop for Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_LIN_142> LINLoop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<Loop_LM_142> LMLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_N1_142_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Problem Report
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual List<Loop_PRR_142> PRRLoop { get; set; }
        /// <summary>
        /// Loop for Repair Action
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual List<Loop_REP_142> REPLoop { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Loop_AMT_142 AMTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MEA))]
    public class Loop_MEA_142
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MEA MEA { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<LIN> LIN { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_142
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
        [ListCount(3)]
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
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_142_2
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
        [ListCount(3)]
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
        [ListCount(2)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Extended Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_142
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N9 N9 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Problem Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PRR))]
    public class Loop_PRR_142
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Problem Report
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PRR PRR { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Root Cause
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual RC RC { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Product Service Contract
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<PSC> PSC { get; set; }
        /// <summary>
        /// Product Special Services
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<SSS> SSS { get; set; }
        /// <summary>
        /// Loop for Characteristic/Class ID
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_CID_142> CIDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Repair Action
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REP))]
    public class Loop_REP_142
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Repair Action
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REP REP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Root Cause
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual RC RC { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<ITA> ITA { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Part Disposition
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual PRT PRT { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(11)]
        public virtual List<Loop_LM_142> LMLoop { get; set; }
        /// <summary>
        /// Loop for Measurements
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_MEA_142> MEALoop { get; set; }
        /// <summary>
        /// Loop for Baseline Item Data (Invoice)
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_IT1_142> IT1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Total Monetary Value Summary
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TDS))]
    public class Loop_TDS_142
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
        /// Tax Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<TXI> TXI { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Product Service Claim
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "142")]
    public class TS142 : EdiMessage
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
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [Pos(4)]
        public virtual List<Loop_N1_142> N1Loop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual List<Loop_LX_142> LXLoop { get; set; }
        /// <summary>
        /// Loop for Total Monetary Value Summary
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_TDS_142 TDSLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
