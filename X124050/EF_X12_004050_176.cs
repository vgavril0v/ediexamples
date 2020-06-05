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
    public class Loop_AMT_176
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Legal Claims
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(BBC))]
    public class Loop_BBC_176
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Legal Claims
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BBC BBC { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AMT AMT { get; set; }
    }
    
    /// <summary>
    /// Loop for Legal Claims
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(BBC))]
    public class Loop_BBC_176_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Legal Claims
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BBC BBC { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
    }
    
    /// <summary>
    /// Loop for Date/Time Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DTM))]
    public class Loop_DTM_176
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<CRC> CRC { get; set; }
    }
    
    /// <summary>
    /// Loop for Electronic Format Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EFI))]
    public class Loop_EFI_176
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
    /// Loop for Form Group
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FGS))]
    public class Loop_FGS_176
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Form Group
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FGS FGS { get; set; }
        /// <summary>
        /// Case Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CDS CDS { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Specification Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SPI SPI { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Conditions Indicator
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        /// Period Amount
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<PAM> PAM { get; set; }
        /// <summary>
        /// Legal Claim Updates
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual BCU BCU { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Administration of Justice Event Description
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual CED CED { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_LM_176> LMLoop { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_AMT_176> AMTLoop { get; set; }
        /// <summary>
        /// Loop for Legal Claims
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_BBC_176> BBCLoop { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_NM1_176> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Electronic Format Identification
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_EFI_176> EFILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_176
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
        /// Administration of Justice Event Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CED CED { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_176
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
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
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
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual PCT PCT { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Legal Claims
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_BBC_176_2> BBCLoop { get; set; }
        /// <summary>
        /// Loop for Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_DTM_176> DTMLoop { get; set; }
    }
    
    /// <summary>
    /// Court Submission
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "176")]
    public class TS176 : EdiMessage
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Form Group
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_FGS_176> FGSLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
