namespace EdiFabric.Templates.EdifactD97A
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Loop for AUTHENTICATION RESULT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AUT))]
    public class Loop_AUT_SSRECH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// AUTHENTICATION RESULT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AUT AUT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for CONTRIBUTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(COT))]
    public class Loop_COT_SSRECH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTRIBUTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual COT COT { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<CNT> CNT { get; set; }
    }
    
    /// <summary>
    /// Loop for DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DTM))]
    public class Loop_DTM_SSRECH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// ADDRESS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ADR ADR { get; set; }
    }
    
    /// <summary>
    /// Loop for EMPLOYMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EMP))]
    public class Loop_EMP_SSRECH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// EMPLOYMENT DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EMP EMP { get; set; }
        /// <summary>
        /// PARTY NAME
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PNA PNA { get; set; }
        /// <summary>
        /// ADDRESS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ADR ADR { get; set; }
    }
    
    /// <summary>
    /// Loop for INDEX DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IND))]
    public class Loop_IND_SSRECH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// INDEX DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IND IND { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(6)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// CONTRIBUTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<COT> COT { get; set; }
        /// <summary>
        /// Loop for EMPLOYMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_EMP_SSRECH EMPLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PERSON DEMOGRAPHIC INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PDI))]
    public class Loop_PDI_SSRECH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PERSON DEMOGRAPHIC INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PDI PDI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for PARTY NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PNA))]
    public class Loop_PNA_SSRECH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PARTY NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PNA PNA { get; set; }
        /// <summary>
        /// ADDRESS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ADR ADR { get; set; }
        /// <summary>
        /// RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual GIR GIR { get; set; }
    }
    
    /// <summary>
    /// Loop for PARTY NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PNA))]
    public class Loop_PNA_SSRECH_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PARTY NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PNA PNA { get; set; }
        /// <summary>
        /// NATIONALITY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NAT NAT { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DOC DOC { get; set; }
        /// <summary>
        /// ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<ADR> ADR { get; set; }
        /// <summary>
        /// ATTRIBUTE
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<ATT> ATT { get; set; }
        /// <summary>
        /// Loop for DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<Loop_DTM_SSRECH> DTMLoop { get; set; }
        /// <summary>
        /// Loop for PERSON DEMOGRAPHIC INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<Loop_PDI_SSRECH> PDILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_SSRECH
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }
    
    /// <summary>
    /// Worker's insurance history message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "SSRECH")]
    public class TSSSRECH : EdiMessage
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Message Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual UNH UNH { get; set; }
        /// <summary>
        /// BEGINNING OF MESSAGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGM BGM { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// GENERAL INDICATOR
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual GIS GIS { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_RFF_SSRECH RFFLoop { get; set; }
        /// <summary>
        /// Loop for PARTY NAME
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<Loop_PNA_SSRECH> PNALoop { get; set; }
        /// <summary>
        /// Loop for INDEX DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(7)]
        public virtual List<Loop_IND_SSRECH> INDLoop { get; set; }
        /// <summary>
        /// SECTION CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual UNS UNS { get; set; }
        /// <summary>
        /// Loop for PARTY NAME
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(6)]
        [Pos(9)]
        public virtual List<Loop_PNA_SSRECH_2> PNALoop2 { get; set; }
        /// <summary>
        /// Loop for CONTRIBUTION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(10)]
        public virtual List<Loop_COT_SSRECH> COTLoop { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(11)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for AUTHENTICATION RESULT
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual Loop_AUT_SSRECH AUTLoop { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual UNT UNT { get; set; }
    }
}
