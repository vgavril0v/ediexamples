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
    /// Loop for Date/Time Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DTM))]
    public class Loop_DTM_170
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
        /// Box Office Detail
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(250)]
        [Pos(2)]
        public virtual List<BOX> BOX { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_170
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(7)]
        [Pos(3)]
        public virtual List<Loop_DTM_170> DTMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Screen Theater Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(THE))]
    public class Loop_THE_170
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Screen Theater Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual THE THE { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Loop_LX_170> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Revenue Receipts Statement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "170")]
    public class TS170 : EdiMessage
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
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Loop for Screen Theater Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<Loop_THE_170> THELoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
