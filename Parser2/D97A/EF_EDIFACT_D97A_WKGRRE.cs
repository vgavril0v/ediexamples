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
    public class Loop_ATT_WKGRRE
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
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FTX FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTA))]
    public class Loop_CTA_WKGRRE
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
    /// Loop for EMPLOYMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EMP))]
    public class Loop_EMP_WKGRRE
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
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// Loop for ATTRIBUTE
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<Loop_ATT_WKGRRE> ATTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for GENERAL INDICATOR
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(GIS))]
    public class Loop_GIS_WKGRRE
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
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FTX FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MOA))]
    public class Loop_MOA_WKGRRE
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MOA MOA { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RNG RNG { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual FTX FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for PARTY NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PNA))]
    public class Loop_PNA_WKGRRE
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
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_CTA_WKGRRE> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PARTY NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PNA))]
    public class Loop_PNA_WKGRRE_2
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
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// NATIONALITY
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<NAT> NAT { get; set; }
        /// <summary>
        /// PERSON DEMOGRAPHIC INFORMATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PDI PDI { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<DOC> DOC { get; set; }
    }
    
    /// <summary>
    /// Loop for PARTY NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PNA))]
    public class Loop_PNA_WKGRRE_3
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
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual FTX FTX { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_CTA_WKGRRE> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_WKGRRE
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
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_WKGRRE_2
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
        [Required]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for PARTY NAME
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_PNA_WKGRRE_2 PNALoop { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual FTX FTX { get; set; }
        /// <summary>
        /// Loop for GENERAL INDICATOR
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_GIS_WKGRRE> GISLoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_RFF_WKGRRE> RFFLoop { get; set; }
        /// <summary>
        /// Loop for EMPLOYMENT DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual Loop_EMP_WKGRRE EMPLoop { get; set; }
        /// <summary>
        /// Loop for REMUNERATION TYPE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<Loop_SAL_WKGRRE> SALLoop { get; set; }
        /// <summary>
        /// Loop for PARTY NAME
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(9)]
        public virtual List<Loop_PNA_WKGRRE_3> PNALoop2 { get; set; }
    }
    
    /// <summary>
    /// Loop for REMUNERATION TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SAL))]
    public class Loop_SAL_WKGRRE
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REMUNERATION TYPE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SAL SAL { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FTX FTX { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for ATTRIBUTE
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<Loop_ATT_WKGRRE> ATTLoop { get; set; }
        /// <summary>
        /// Loop for GENERAL INDICATOR
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<Loop_GIS_WKGRRE> GISLoop { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_MOA_WKGRRE> MOALoop { get; set; }
    }
    
    /// <summary>
    /// Work grant request message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "WKGRRE")]
    public class TSWKGRRE : EdiMessage
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
        [Required]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Loop for PARTY NAME
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<Loop_PNA_WKGRRE> PNALoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_RFF_WKGRRE> RFFLoop { get; set; }
        /// <summary>
        /// Loop for GENERAL INDICATOR
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<Loop_GIS_WKGRRE> GISLoop { get; set; }
        /// <summary>
        /// SECTION CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual UNS UNS { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(200)]
        [Pos(9)]
        public virtual List<Loop_RFF_WKGRRE_2> RFFLoop2 { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual UNT UNT { get; set; }
    }
}
