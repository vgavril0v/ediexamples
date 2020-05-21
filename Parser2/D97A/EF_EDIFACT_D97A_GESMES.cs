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
    /// Loop for ARRAY STRUCTURE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ASI))]
    public class Loop_ASI_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ARRAY STRUCTURE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ASI ASI { get; set; }
        /// <summary>
        /// GENERAL INDICATOR
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<GIS> GIS { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// IDENTITY
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<IDE> IDE { get; set; }
        /// <summary>
        /// Loop for STRUCTURE COMPONENT DEFINITION
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(5)]
        public virtual List<Loop_SCD_GESMES> SCDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for CODE VALUE DEFINITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CDV))]
    public class Loop_CDV_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CODE VALUE DEFINITION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CDV CDV { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// IDENTITY
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<IDE> IDE { get; set; }
    }
    
    /// <summary>
    /// Loop for CODE VALUE DEFINITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CDV))]
    public class Loop_CDV_GESMES_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CODE VALUE DEFINITION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CDV CDV { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTA))]
    public class Loop_CTA_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CTA CTA { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for DATA SET IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DSI))]
    public class Loop_DSI_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATA SET IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DSI DSI { get; set; }
        /// <summary>
        /// STATUS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<STS> STS { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<GIR> GIR { get; set; }
        /// <summary>
        /// ARRAY INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(6)]
        public virtual List<ARR> ARR { get; set; }
        /// <summary>
        /// Loop for IDENTITY
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(7)]
        public virtual List<Loop_IDE_GESMES_2> IDELoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<Loop_NAD_GESMES> NADLoop { get; set; }
        /// <summary>
        /// Loop for FOOTNOTE SET
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<Loop_FNS_GESMES> FNSLoop { get; set; }
        /// <summary>
        /// Loop for FOOTNOTE
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(10)]
        public virtual List<Loop_FNT_GESMES> FNTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for FOOTNOTE SET
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FNS))]
    public class Loop_FNS_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// FOOTNOTE SET
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FNS FNS { get; set; }
        /// <summary>
        /// Loop for RELATIONSHIP
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<Loop_REL_GESMES> RELLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for FOOTNOTE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FNT))]
    public class Loop_FNT_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// FOOTNOTE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FNT FNT { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for RELATED IDENTIFICATION NUMBERS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(GIR))]
    public class Loop_GIR_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual GIR GIR { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for IDENTITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IDE))]
    public class Loop_IDE_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// IDENTITY
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IDE IDE { get; set; }
        /// <summary>
        /// ATTRIBUTE
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<ATT> ATT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for IDENTITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IDE))]
    public class Loop_IDE_GESMES_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// IDENTITY
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IDE IDE { get; set; }
        /// <summary>
        /// GENERAL INDICATOR
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<GIS> GIS { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for CODE VALUE DEFINITION
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(4)]
        public virtual List<Loop_CDV_GESMES_2> CDVLoop { get; set; }
        /// <summary>
        /// Loop for STRUCTURE COMPONENT DEFINITION
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(5)]
        public virtual List<Loop_SCD_GESMES_2> SCDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_NAD_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NAD NAD { get; set; }
        /// <summary>
        /// IDENTITY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual IDE IDE { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<Loop_CTA_GESMES> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for RELATIONSHIP
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REL))]
    public class Loop_REL_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// RELATIONSHIP
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REL REL { get; set; }
        /// <summary>
        /// ARRAY INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ARR ARR { get; set; }
        /// <summary>
        /// IDENTITY
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<IDE> IDE { get; set; }
    }
    
    /// <summary>
    /// Loop for STRUCTURE COMPONENT DEFINITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCD))]
    public class Loop_SCD_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// STRUCTURE COMPONENT DEFINITION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SCD SCD { get; set; }
        /// <summary>
        /// ATTRIBUTE
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<ATT> ATT { get; set; }
        /// <summary>
        /// Loop for IDENTITY
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<Loop_IDE_GESMES> IDELoop { get; set; }
    }
    
    /// <summary>
    /// Loop for STRUCTURE COMPONENT DEFINITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCD))]
    public class Loop_SCD_GESMES_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// STRUCTURE COMPONENT DEFINITION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SCD SCD { get; set; }
        /// <summary>
        /// ATTRIBUTE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<ATT> ATT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for CODE VALUE DEFINITION
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<Loop_CDV_GESMES_2> CDVLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for STATISTICAL CONCEPT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(STC))]
    public class Loop_STC_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// STATISTICAL CONCEPT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual STC STC { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// IDENTITY
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<IDE> IDE { get; set; }
    }
    
    /// <summary>
    /// Loop for VALUE LIST IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VLI))]
    public class Loop_VLI_GESMES
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// VALUE LIST IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VLI VLI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// IDENTITY
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<IDE> IDE { get; set; }
        /// <summary>
        /// Loop for RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_GIR_GESMES> GIRLoop { get; set; }
        /// <summary>
        /// Loop for CODE VALUE DEFINITION
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(6)]
        public virtual List<Loop_CDV_GESMES> CDVLoop { get; set; }
    }
    
    /// <summary>
    /// Generic statistical message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "GESMES")]
    public class TSGESMES : EdiMessage
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
        [Pos(2)]
        public virtual BGM BGM { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for FOOTNOTE
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<Loop_FNT_GESMES> FNTLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<Loop_NAD_GESMES> NADLoop { get; set; }
        /// <summary>
        /// Loop for VALUE LIST IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<Loop_VLI_GESMES> VLILoop { get; set; }
        /// <summary>
        /// Loop for STATISTICAL CONCEPT
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(7)]
        public virtual List<Loop_STC_GESMES> STCLoop { get; set; }
        /// <summary>
        /// Loop for ARRAY STRUCTURE IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(8)]
        public virtual List<Loop_ASI_GESMES> ASILoop { get; set; }
        /// <summary>
        /// Loop for DATA SET IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(9)]
        public virtual List<Loop_DSI_GESMES> DSILoop { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual UNT UNT { get; set; }
    }
}
