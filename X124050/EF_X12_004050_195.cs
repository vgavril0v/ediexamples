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
    public class Loop_AMT_195
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
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Conditions Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CRC))]
    public class Loop_CRC_195
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CRC CRC { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Conditions Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CRC))]
    public class Loop_CRC_195_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CRC CRC { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Conditions Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CRC))]
    public class Loop_CRC_195_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CRC CRC { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_LM_195_3> LMLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_N1_195_2> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_195
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
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_195_2
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
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_195_3
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
    /// Loop for Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MEA))]
    public class Loop_MEA_195
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
        /// Individual or Event Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<LIE> LIE { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_195
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
        [ListCount(3)]
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
        [ListCount(5)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Reference Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_REF_195> REFLoop { get; set; }
        /// <summary>
        /// Loop for Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_CRC_195_2> CRCLoop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_LM_195> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_195_2
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
        [ListCount(3)]
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
    }
    
    /// <summary>
    /// Loop for Baseline Item Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PO1))]
    public class Loop_PO1_195
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Baseline Item Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PO1 PO1 { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Loop for Measurements
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_MEA_195> MEALoop { get; set; }
        /// <summary>
        /// Loop for Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_REF_195_2> REFLoop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_LM_195_2> LMLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_N1_195_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_CRC_195_3> CRCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_195
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_195_2
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
        /// Individual or Event Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<LIE> LIE { get; set; }
    }
    
    /// <summary>
    /// Federal Communications Commission (FCC) License Application
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "195")]
    public class TS195 : EdiMessage
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Loop for Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_CRC_195> CRCLoop { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_AMT_195> AMTLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_N1_195> N1Loop { get; set; }
        /// <summary>
        /// Loop for Baseline Item Data
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_PO1_195> PO1Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual SE SE { get; set; }
    }
}
