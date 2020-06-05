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
    public class Loop_CI_361
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
        /// Remarks
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual K1 K1 { get; set; }
    }
    
    /// <summary>
    /// Carrier Interchange Agreement (Ocean)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "361")]
    public class TS361 : EdiMessage
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
        /// Loop for Carrier Interchange Agreement
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<Loop_CI_361> CILoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
