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
    /// Loop for ATTRIBUTE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ATT))]
    public class Loop_ATT_MEDREQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ATTRIBUTE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ATT ATT { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<ADR> ADR { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<HAN> HAN { get; set; }
        /// <summary>
        /// RELATIONSHIP
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual REL REL { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<IMD> IMD { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(8)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// PARTY NAME
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(9)]
        public virtual List<PNA> PNA { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(10)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// PERSON DEMOGRAPHIC INFORMATION
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual PDI PDI { get; set; }
        /// <summary>
        /// NATIONALITY
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(12)]
        public virtual List<NAT> NAT { get; set; }
        /// <summary>
        /// LANGUAGE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(13)]
        public virtual List<LAN> LAN { get; set; }
        /// <summary>
        /// CHARACTERISTIC/CLASS ID
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(14)]
        public virtual List<CCI> CCI { get; set; }
        /// <summary>
        /// Loop for ATTENDANCE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(15)]
        public virtual List<Loop_PAS_MEDREQ> PASLoop { get; set; }
        /// <summary>
        /// Loop for CHARACTERISTIC VALUE
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(16)]
        public virtual List<Loop_CAV_MEDREQ> CAVLoop { get; set; }
        /// <summary>
        /// Loop for SEQUENCE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(17)]
        public virtual List<Loop_SEQ_MEDREQ> SEQLoop { get; set; }
        /// <summary>
        /// Loop for GENERAL INDICATOR
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(18)]
        public virtual List<Loop_GIS_MEDREQ> GISLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for AUTHENTICATION RESULT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AUT))]
    public class Loop_AUT_MEDREQ
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
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for CHARACTERISTIC VALUE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CAV))]
    public class Loop_CAV_MEDREQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CHARACTERISTIC VALUE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CAV CAV { get; set; }
        /// <summary>
        /// CLINICAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<CIN> CIN { get; set; }
        /// <summary>
        /// LANGUAGE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<LAN> LAN { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(5)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// Loop for STATUS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(7)]
        public virtual List<Loop_STS_MEDREQ> STSLoop { get; set; }
        /// <summary>
        /// Loop for CLINICAL INTERVENTION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<Loop_CLI_MEDREQ> CLILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for CLINICAL INTERVENTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CLI))]
    public class Loop_CLI_MEDREQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CLINICAL INTERVENTION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CLI CLI { get; set; }
        /// <summary>
        /// Loop for ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<Loop_IMD_MEDREQ> IMDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for CLINICAL INTERVENTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CLI))]
    public class Loop_CLI_MEDREQ_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CLINICAL INTERVENTION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CLI CLI { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual IMD IMD { get; set; }
        /// <summary>
        /// DOSAGE ADMINISTRATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DSG DSG { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// PARTIES TO INSTRUCTION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<INP> INP { get; set; }
    }
    
    /// <summary>
    /// Loop for DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DOC))]
    public class Loop_DOC_MEDREQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DOC DOC { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTM DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for FINANCIAL CHARGES ALLOCATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FCA))]
    public class Loop_FCA_MEDREQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// FINANCIAL CHARGES ALLOCATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FCA FCA { get; set; }
        /// <summary>
        /// GENERAL INDICATOR
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual GIS GIS { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// PRIORITY
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PTY PTY { get; set; }
        /// <summary>
        /// CLINICAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public virtual List<CIN> CIN { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// LANGUAGE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(8)]
        public virtual List<LAN> LAN { get; set; }
        /// <summary>
        /// PACKAGE
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual PAC PAC { get; set; }
        /// <summary>
        /// INFORMATION REQUIRED
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual IRQ IRQ { get; set; }
        /// <summary>
        /// TEST METHOD
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(11)]
        public virtual List<TEM> TEM { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual HAN HAN { get; set; }
        /// <summary>
        /// Loop for SCHEDULING CONDITIONS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(13)]
        public virtual List<Loop_SCC_MEDREQ> SCCLoop { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(14)]
        public virtual List<Loop_DOC_MEDREQ> DOCLoop { get; set; }
        /// <summary>
        /// Loop for ATTRIBUTE
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(15)]
        public virtual List<Loop_ATT_MEDREQ> ATTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for GENERAL INDICATOR
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(GIS))]
    public class Loop_GIS_MEDREQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// GENERAL INDICATOR
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual GIS GIS { get; set; }
        /// <summary>
        /// CHARACTERISTIC/CLASS ID
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<CCI> CCI { get; set; }
        /// <summary>
        /// PRIORITY
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<PTY> PTY { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// CLINICAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<CIN> CIN { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// TEST METHOD
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(8)]
        public virtual List<TEM> TEM { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(9)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(10)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual HAN HAN { get; set; }
        /// <summary>
        /// Loop for SCHEDULING CONDITIONS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(12)]
        public virtual List<Loop_SCC_MEDREQ> SCCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IMD))]
    public class Loop_IMD_MEDREQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IMD IMD { get; set; }
        /// <summary>
        /// DOSAGE ADMINISTRATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DSG> DSG { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// PARTIES TO INSTRUCTION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<INP> INP { get; set; }
    }
    
    /// <summary>
    /// Loop for ATTENDANCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAS))]
    public class Loop_PAS_MEDREQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ATTENDANCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAS PAS { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual RFF RFF { get; set; }
    }
    
    /// <summary>
    /// Loop for PARTY NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PNA))]
    public class Loop_PNA_MEDREQ
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
        [ListCount(9)]
        [Pos(2)]
        public virtual List<ADR> ADR { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// SEQUENCE DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SEQ SEQ { get; set; }
        /// <summary>
        /// LANGUAGE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<LAN> LAN { get; set; }
        /// <summary>
        /// ORGANISATION CLASSIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SPR SPR { get; set; }
        /// <summary>
        /// QUALIFICATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(9)]
        public virtual List<QUA> QUA { get; set; }
        /// <summary>
        /// EMPLOYMENT DETAILS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(10)]
        public virtual List<EMP> EMP { get; set; }
    }
    
    /// <summary>
    /// Loop for RELATIONSHIP
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REL))]
    public class Loop_REL_MEDREQ
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
        /// REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<RFF> RFF { get; set; }
    }
    
    /// <summary>
    /// Loop for RESULT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RSL))]
    public class Loop_RSL_MEDREQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// RESULT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RSL RSL { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// CHARACTERISTIC/CLASS ID
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<CCI> CCI { get; set; }
    }
    
    /// <summary>
    /// Loop for SCHEDULING CONDITIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCC))]
    public class Loop_SCC_MEDREQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// SCHEDULING CONDITIONS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SCC SCC { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for SEQUENCE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SEQ))]
    public class Loop_SEQ_MEDREQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// SEQUENCE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SEQ SEQ { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<IMD> IMD { get; set; }
        /// <summary>
        /// PROCESS IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<PRC> PRC { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// PACKAGE
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PAC PAC { get; set; }
        /// <summary>
        /// PRIORITY
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual PTY PTY { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(9)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(10)]
        public virtual List<TDT> TDT { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(11)]
        public virtual List<HAN> HAN { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(12)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(13)]
        public virtual List<ADR> ADR { get; set; }
        /// <summary>
        /// Loop for CLINICAL INTERVENTION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(14)]
        public virtual List<Loop_CLI_MEDREQ_2> CLILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for STATUS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(STS))]
    public class Loop_STS_MEDREQ
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// STATUS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual STS STS { get; set; }
        /// <summary>
        /// SEQUENCE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SEQ SEQ { get; set; }
        /// <summary>
        /// GENERAL INDICATOR
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual GIS GIS { get; set; }
        /// <summary>
        /// RESULT
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual RSL RSL { get; set; }
        /// <summary>
        /// CHARACTERISTIC/CLASS ID
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<CCI> CCI { get; set; }
        /// <summary>
        /// CLINICAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public virtual List<CIN> CIN { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(9)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// Loop for RESULT
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(10)]
        public virtual List<Loop_RSL_MEDREQ> RSLLoop { get; set; }
        /// <summary>
        /// Loop for RELATIONSHIP
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(11)]
        public virtual List<Loop_REL_MEDREQ> RELLoop { get; set; }
    }
    
    /// <summary>
    /// Medical service request message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "MEDREQ")]
    public class TSMEDREQ : EdiMessage
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
        [ListCount(9)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for PARTY NAME
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(5)]
        public virtual List<Loop_PNA_MEDREQ> PNALoop { get; set; }
        /// <summary>
        /// Loop for FINANCIAL CHARGES ALLOCATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<Loop_FCA_MEDREQ> FCALoop { get; set; }
        /// <summary>
        /// Loop for AUTHENTICATION RESULT
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(7)]
        public virtual List<Loop_AUT_MEDREQ> AUTLoop { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual UNT UNT { get; set; }
    }
}
