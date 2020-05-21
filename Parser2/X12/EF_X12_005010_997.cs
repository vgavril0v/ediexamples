namespace EdiFabric.Templates.X12005010
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
    /// Loop for Transaction Set Response Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AK2))]
    public class Loop_AK2_997
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Response Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AK2 AK2 { get; set; }
        /// <summary>
        /// Loop for Data Segment Note
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_AK3_997> AK3Loop { get; set; }
        /// <summary>
        /// Transaction Set Response Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual AK5 AK5 { get; set; }
    }
    
    /// <summary>
    /// Loop for Data Segment Note
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AK3))]
    public class Loop_AK3_997
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Data Segment Note
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AK3 AK3 { get; set; }
        /// <summary>
        /// Data Element Note
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<AK4> AK4 { get; set; }
    }
    
    /// <summary>
    /// Functional Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "997")]
    public class TS997 : EdiMessage
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
        /// Functional Group Response Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AK1 AK1 { get; set; }
        /// <summary>
        /// Loop for Transaction Set Response Header
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_AK2_997> AK2Loop { get; set; }
        /// <summary>
        /// Functional Group Response Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual AK9 AK9 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
