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
    /// Loop for Port Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(P4))]
    public class Loop_P4_354
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Port Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual P4 P4 { get; set; }
        /// <summary>
        /// Automated Manifest Archive Status Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual X01 X01 { get; set; }
        /// <summary>
        /// Automated Manifest Bills Eligible/Overdue Archive Details
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<X02> X02 { get; set; }
    }
    
    /// <summary>
    /// U.S. Customs Automated Manifest Archive Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "354")]
    public class TS354 : EdiMessage
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
        [Required]
        [Pos(2)]
        public virtual M10 M10 { get; set; }
        /// <summary>
        /// Loop for Port Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<Loop_P4_354> P4Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
