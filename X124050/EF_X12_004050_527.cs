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
    /// Loop for Contract Summary
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CS))]
    public class Loop_CS_527
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contract Summary
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CS CS { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<G69> G69 { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(6)]
        public virtual List<Loop_LM_527> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Type of Financial Accounting Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FA1))]
    public class Loop_FA1_527
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
    }
    
    /// <summary>
    /// Loop for Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_527
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
        /// Contract Summary
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CS CS { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Receiving Conditions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_RCD_527> RCDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_527
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
        [ListCount(100)]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_527
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
        [ListCount(5)]
        [Pos(5)]
        public virtual List<G61> G61 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_527_2
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
        [Pos(5)]
        public virtual G61 G61 { get; set; }
    }
    
    /// <summary>
    /// Loop for Quantity Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_527
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(3)]
        public virtual List<Loop_LM_527> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Receiving Conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RCD))]
    public class Loop_RCD_527
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Receiving Conditions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RCD RCD { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Furnished Goods and Services
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual GF GF { get; set; }
        /// <summary>
        /// Demand Detail
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(4)]
        public virtual List<DD> DD { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Transportation Instructions
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<G66> G66 { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(9)]
        public virtual List<Loop_LM_527> LMLoop { get; set; }
        /// <summary>
        /// Loop for Contract Summary
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_CS_527> CSLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(11)]
        public virtual List<Loop_N1_527_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Reference Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_REF_527> REFLoop { get; set; }
        /// <summary>
        /// Loop for Quantity Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_QTY_527> QTYLoop { get; set; }
        /// <summary>
        /// Loop for Type of Financial Accounting Data
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_FA1_527> FA1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_527
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(5)]
        public virtual List<Loop_LM_527> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Material Due-In and Receipt
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "527")]
    public class TS527 : EdiMessage
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
        /// Beginning Segment for Material Management
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BR BR { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(5)]
        public virtual List<Loop_LM_527> LMLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<Loop_N1_527> N1Loop { get; set; }
        /// <summary>
        /// Loop for Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual List<Loop_LIN_527> LINLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
