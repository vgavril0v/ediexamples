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
    /// Loop for Characteristic/Class ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CID))]
    public class Loop_CID_841
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
        /// Unit Detail
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual UIT UIT { get; set; }
        /// <summary>
        /// Test Method
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<TMD> TMD { get; set; }
        /// <summary>
        /// Physical Sample Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PSD PSD { get; set; }
        /// <summary>
        /// Conditional Sampling Sequence
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CSS CSS { get; set; }
        /// <summary>
        /// Sampling Parameters for Summary Statistics
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SPS SPS { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Measurements
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_MEA_841> MEALoop { get; set; }
        /// <summary>
        /// Loop for Statistics
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_STA_841> STALoop { get; set; }
        /// <summary>
        /// Loop for Conditional Sampling Frequency
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_CSF_841> CSFLoop { get; set; }
        /// <summary>
        /// Loop for Electronic Format Identification
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_EFI_841> EFILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Characteristic/Class ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CID))]
    public class Loop_CID_841_2
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
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MEA MEA { get; set; }
        /// <summary>
        /// Statistics
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual STA STA { get; set; }
    }
    
    /// <summary>
    /// Loop for Conditional Sampling Frequency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CSF))]
    public class Loop_CSF_841
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Conditional Sampling Frequency
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CSF CSF { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_LS_841 LSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Electronic Format Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EFI))]
    public class Loop_EFI_841
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
        [Pos(2)]
        public virtual BIN BIN { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_841
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
        /// Loop for Specification Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_SPI_841_2> SPILoop { get; set; }
        /// <summary>
        /// Loop for Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_PID_841> PIDLoop { get; set; }
        /// <summary>
        /// Loop for Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_REF_841> REFLoop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_LX_841> LXLoop { get; set; }
        /// <summary>
        /// Loop for Electronic Format Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_EFI_841> EFILoop { get; set; }
        /// <summary>
        /// Loop for Characteristic/Class ID
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_CID_841> CIDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_841
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
        /// Loop for Characteristic/Class ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_CID_841_2> CIDLoop { get; set; }
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
    public class Loop_LX_841
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
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Test Method
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TMD TMD { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Physical Sample Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PSD> PSD { get; set; }
        /// <summary>
        /// Sampling Parameters for Summary Statistics
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<SPS> SPS { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MEA))]
    public class Loop_MEA_841
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
    public class Loop_N1_841
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
        public virtual List<N4> N4 { get; set; }
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
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_841_2
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
        public virtual List<N4> N4 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<N9> N9 { get; set; }
    }
    
    /// <summary>
    /// Loop for Product/Item Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PID))]
    public class Loop_PID_841
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PID PID { get; set; }
        /// <summary>
        /// Packaging Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PKD> PKD { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Unit Detail
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<UIT> UIT { get; set; }
        /// <summary>
        /// Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Loop for Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_PKG_841> PKGLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Marking, Packaging, Loading
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PKG))]
    public class Loop_PKG_841
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PKG PKG { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_841
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Specification Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SPI))]
    public class Loop_SPI_841
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Specification Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SPI SPI { get; set; }
        /// <summary>
        /// Revision Date/Time
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<RDT> RDT { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual X1 X1 { get; set; }
        /// <summary>
        /// Import License
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual X2 X2 { get; set; }
        /// <summary>
        /// Customs Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual X7 X7 { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Loop for Reference Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_REF_841> REFLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_N1_841> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Specification Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SPI))]
    public class Loop_SPI_841_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Specification Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SPI SPI { get; set; }
        /// <summary>
        /// Revision Date/Time
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<RDT> RDT { get; set; }
        /// <summary>
        /// Problem Report
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PRR> PRR { get; set; }
        /// <summary>
        /// Part Disposition
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<PRT> PRT { get; set; }
        /// <summary>
        /// Part Release Status
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PRS PRS { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_N1_841_2> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Statistics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(STA))]
    public class Loop_STA_841
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
    /// Specifications/Technical Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "841")]
    public class TS841 : EdiMessage
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
        /// Loop for Specification Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<Loop_SPI_841> SPILoop { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_HL_841> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
