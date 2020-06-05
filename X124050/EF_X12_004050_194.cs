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
    /// Loop for Degree Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DEG))]
    public class Loop_DEG_194
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Degree Record
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DEG DEG { get; set; }
        /// <summary>
        /// Field of Study
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<FOS> FOS { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_194
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
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PAM> PAM { get; set; }
        /// <summary>
        /// Health Care Services Delivery
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<HSD> HSD { get; set; }
        /// <summary>
        /// Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<NX1> NX1 { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_N9_194_2> N9Loop { get; set; }
        /// <summary>
        /// Loop for Baseline Item Data
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_PO1_194> PO1Loop { get; set; }
        /// <summary>
        /// Loop for Price Support Data
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_PPL_194> PPLLoop { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_LX_194> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Index Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(INX))]
    public class Loop_INX_194
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Index Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual INX INX { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<K3> K3 { get; set; }
    }
    
    /// <summary>
    /// Loop for Administrative Message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(K2))]
    public class Loop_K2_194
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Administrative Message
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual K2 K2 { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<NM1> NM1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_194
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
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NM1 NM1 { get; set; }
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<DMG> DMG { get; set; }
        /// <summary>
        /// Employment Position
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_N9_194> N9Loop { get; set; }
        /// <summary>
        /// Loop for Degree Record
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_DEG_194> DEGLoop { get; set; }
        /// <summary>
        /// Loop for Administrative Message
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_K2_194> K2Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Extended Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_194
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
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Extended Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_194_2
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
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Loop for Index Detail
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_INX_194> INXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_194
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
    }
    
    /// <summary>
    /// Loop for Pricing Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PD))]
    public class Loop_PD_194
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pricing Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PD PD { get; set; }
        /// <summary>
        /// Pricing Data Detail
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PDD> PDD { get; set; }
    }
    
    /// <summary>
    /// Loop for Pricing Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PD))]
    public class Loop_PD_194_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pricing Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PD PD { get; set; }
        /// <summary>
        /// Specification Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SPI SPI { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Pricing Data Detail
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<PDD> PDD { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Proposal Cost Logic
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PL))]
    public class Loop_PL_194
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Proposal Cost Logic
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PL PL { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PCT PCT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Pricing Data
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_PD_194_2> PDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Baseline Item Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PO1))]
    public class Loop_PO1_194
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
        /// Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Price Support Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PPL))]
    public class Loop_PPL_194
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price Support Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PPL PPL { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Pricing Data
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_PD_194> PDLoop { get; set; }
        /// <summary>
        /// Loop for Proposal Cost Logic
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_PL_194> PLLoop { get; set; }
    }
    
    /// <summary>
    /// Grant or Assistance Application
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "194")]
    public class TS194 : EdiMessage
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
        /// Lead Time
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<LDT> LDT { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_N9_194> N9Loop { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_NM1_194> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual List<Loop_HL_194> HLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SE SE { get; set; }
    }
}
