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
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_874
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
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Extended Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_874
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Place/Location Description
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual LCD LCD { get; set; }
        /// <summary>
        /// Contract Summary
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CS CS { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Loop for Subline Item Detail
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_SLN_874> SLNLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Subline Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN))]
    public class Loop_SLN_874
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subline Item Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SLN SLN { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<III> III { get; set; }
    }
    
    /// <summary>
    /// Commodity Movement Services Response
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "874")]
    public class TS874 : EdiMessage
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
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<III> III { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual List<Loop_N1_874> N1Loop { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_N9_874> N9Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
