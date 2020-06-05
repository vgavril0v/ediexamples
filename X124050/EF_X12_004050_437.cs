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
    /// Loop for Rail Junction Settlement Role Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(JS))]
    public class Loop_JS_437
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rail Junction Settlement Role Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual JS JS { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Standard Transportation Commodity Code Identification
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<SID> SID { get; set; }
    }
    
    /// <summary>
    /// Railroad Junctions and Interchanges Activity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "437")]
    public class TS437 : EdiMessage
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
        /// Beginning Segment Railroad Junctions and Interchanges Update Activity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BJF BJF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Railroad Junction Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual JCT JCT { get; set; }
        /// <summary>
        /// Loop for Rail Junction Settlement Role Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<Loop_JS_437> JSLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
