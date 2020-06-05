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
    /// Loop for Carrier Interchange Agreement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CI))]
    public class Loop_CI_424
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Carrier Interchange Agreement
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CI CI { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Loop for Switching Conditions
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(5)]
        public virtual List<Loop_SWC_424> SWCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Equipment Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ED))]
    public class Loop_ED_424
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ED ED { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Switching Details
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SWD SWD { get; set; }
        /// <summary>
        /// Switching Rates
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<SWR> SWR { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual D9 D9 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual NTE NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_424
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
        [Pos(2)]
        public virtual N2 N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3 N3 { get; set; }
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
        [ListCount(2)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Loop for Carrier Interchange Agreement
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<Loop_CI_424> CILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Switching Conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SWC))]
    public class Loop_SWC_424
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Switching Conditions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SWC SWC { get; set; }
        /// <summary>
        /// Loop for Equipment Description
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<Loop_ED_424> EDLoop { get; set; }
    }
    
    /// <summary>
    /// Rail Carrier Services Settlement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "424")]
    public class TS424 : EdiMessage
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
        /// Beginning Segment for Carrier's Services Settlement
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BSW BSW { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<Loop_N1_424> N1Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
