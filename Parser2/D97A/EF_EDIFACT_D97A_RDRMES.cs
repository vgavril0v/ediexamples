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
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTA))]
    public class Loop_CTA_RDRMES
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
        [ListCount(9)]
        [Pos(2)]
        public virtual List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for IDENTITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IDE))]
    public class Loop_IDE_RDRMES
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
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_NAD_RDRMES NADLoop { get; set; }
        /// <summary>
        /// Loop for STRUCTURE COMPONENT DEFINITION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_SCD_RDRMES> SCDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_NAD_RDRMES
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
        /// REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<Loop_CTA_RDRMES> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for STRUCTURE COMPONENT DEFINITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCD))]
    public class Loop_SCD_RDRMES
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
        /// ARRAY INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ARR ARR { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<RFF> RFF { get; set; }
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
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_NAD_RDRMES> NADLoop { get; set; }
    }
    
    /// <summary>
    /// Raw data reporting message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "RDRMES")]
    public class TSRDRMES : EdiMessage
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
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<Loop_NAD_RDRMES> NADLoop { get; set; }
        /// <summary>
        /// Loop for IDENTITY
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(5)]
        public virtual List<Loop_IDE_RDRMES> IDELoop { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual UNT UNT { get; set; }
    }
}
