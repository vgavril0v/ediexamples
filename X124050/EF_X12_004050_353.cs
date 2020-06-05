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
    /// Loop for Customs Events Advisory Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M15))]
    public class Loop_M15_353
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Customs Events Advisory Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M15 M15 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Customs Events Advisory Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "353")]
    public class TS353 : EdiMessage
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
        /// Manifest Identifying Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual M10 M10 { get; set; }
        /// <summary>
        /// Port Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual P4 P4 { get; set; }
        /// <summary>
        /// Loop for Customs Events Advisory Details
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<Loop_M15_353> M15Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
