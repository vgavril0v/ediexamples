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
    /// Loop for Equipment Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(JID))]
    public class Loop_JID_819
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual JID JID { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(5)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<MEA> MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for Line Item Detail for the Operating Expense Statement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(JIL))]
    public class Loop_JIL_819
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item Detail for the Operating Expense Statement
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual JIL JIL { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(4)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<ITA> ITA { get; set; }
        /// <summary>
        /// Partner Share Accounting
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PSA PSA { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Loop for Equipment Detail
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(9)]
        public virtual List<Loop_JID_819> JIDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_819
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(6)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Partner Share Accounting
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PSA))]
    public class Loop_PSA_819
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Partner Share Accounting
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PSA PSA { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(7)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(8)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Joint Interest Billing and Operating Expense Statement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "819")]
    public class TS819 : EdiMessage
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
        /// Beginning Segment for Joint Interest Billing and Operating Expense Statement
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BOS BOS { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<ITD> ITD { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<Loop_N1_819> N1Loop { get; set; }
        /// <summary>
        /// Loop for Line Item Detail for the Operating Expense Statement
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10000)]
        [Pos(6)]
        public virtual List<Loop_JIL_819> JILLoop { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Total Monetary Value Summary
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual TDS TDS { get; set; }
        /// <summary>
        /// Loop for Partner Share Accounting
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(10)]
        public virtual List<Loop_PSA_819> PSALoop { get; set; }
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [DataMember]
        [Required]
        [Pos(11)]
        public virtual CTT CTT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual SE SE { get; set; }
    }
}
