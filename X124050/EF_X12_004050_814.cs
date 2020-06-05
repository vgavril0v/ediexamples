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
    public class Loop_AMT_814
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
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
    }
    
    /// <summary>
    /// Loop for Amount with Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AWD))]
    public class Loop_AWD_814
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Amount with Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AWD AWD { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Type of Financial Accounting Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FA1))]
    public class Loop_FA1_814
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Type of Financial Accounting Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FA1 FA1 { get; set; }
        /// <summary>
        /// Accounting Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<FA2> FA2 { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_AMT_814> AMTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_814
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
        /// Action or Status Indicator
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ASI ASI { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Electronic Funds Transfer Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PM PM { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Loop for Type of Financial Accounting Data
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_FA1_814> FA1Loop { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_NM1_814> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_LM_814> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_814
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
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_814
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
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_814
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
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// General Request, Response or Confirmation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "814")]
    public class TS814 : EdiMessage
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
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Place/Location Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual LCD LCD { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Loop for Type of Financial Accounting Data
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_FA1_814> FA1Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_N1_814> N1Loop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_LM_814> LMLoop { get; set; }
        /// <summary>
        /// Loop for Item Identification
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_LIN_814> LINLoop { get; set; }
        /// <summary>
        /// Loop for Amount with Description
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_AWD_814> AWDLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual SE SE { get; set; }
    }
}
