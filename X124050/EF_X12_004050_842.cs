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
    /// Loop for Electronic Format Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EFI))]
    public class Loop_EFI_842
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Electronic Format Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EFI EFI { get; set; }
        /// <summary>
        /// Binary Data Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BIN BIN { get; set; }
    }
    
    /// <summary>
    /// Loop for Type of Financial Accounting Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FA1))]
    public class Loop_FA1_842
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
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_842
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
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Part Release Status
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<PRS> PRS { get; set; }
        /// <summary>
        /// Characteristic/Class ID
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<CID> CID { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Contract Summary
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual CS CS { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Test Method
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual TMD TMD { get; set; }
        /// <summary>
        /// Physical Sample Description
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual PSD PSD { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_LM_842> LMLoop { get; set; }
        /// <summary>
        /// Loop for Measurements
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_MEA_842> MEALoop { get; set; }
        /// <summary>
        /// Loop for Type of Financial Accounting Data
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_FA1_842> FA1Loop { get; set; }
        /// <summary>
        /// Loop for Sampling Parameters for Summary Statistics
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_SPS_842> SPSLoop { get; set; }
        /// <summary>
        /// Loop for Nonconformance Description
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<Loop_NCD_842> NCDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_842
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
    public class Loop_MEA_842
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
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_842
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
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Nonconformance Action
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NCA))]
    public class Loop_NCA_842
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Nonconformance Action
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NCA NCA { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Paperwork
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_PWK_842> PWKLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_N1_842> N1Loop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_LM_842> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Nonconformance Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NCD))]
    public class Loop_NCD_842
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Nonconformance Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NCD NCD { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Root Cause
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<RC> RC { get; set; }
        /// <summary>
        /// Loop for Electronic Format Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_EFI_842> EFILoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_N1_842> N1Loop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_LM_842> LMLoop { get; set; }
        /// <summary>
        /// Loop for Nonconformance Action
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_NCA_842> NCALoop { get; set; }
        /// <summary>
        /// Loop for Type of Financial Accounting Data
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_FA1_842> FA1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Paperwork
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PWK))]
    public class Loop_PWK_842
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PWK PWK { get; set; }
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
    }
    
    /// <summary>
    /// Loop for Sampling Parameters for Summary Statistics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SPS))]
    public class Loop_SPS_842
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sampling Parameters for Summary Statistics
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SPS SPS { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Physical Sample Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PSD PSD { get; set; }
        /// <summary>
        /// Loop for Measurements
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_MEA_842> MEALoop { get; set; }
        /// <summary>
        /// Loop for Statistics
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_STA_842> STALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Statistics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(STA))]
    public class Loop_STA_842
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Statistics
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual STA STA { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Nonconformance Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "842")]
    public class TS842 : EdiMessage
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
        /// Beginning Segment For Nonconformance Report
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BNR BNR { get; set; }
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
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Loop for Measurements
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_MEA_842> MEALoop { get; set; }
        /// <summary>
        /// Loop for Paperwork
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_PWK_842> PWKLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_N1_842> N1Loop { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual List<Loop_HL_842> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual SE SE { get; set; }
    }
}
