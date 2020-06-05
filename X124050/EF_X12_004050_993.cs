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
    /// Loop for Assurance Header Level 2
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(S4A))]
    public class Loop_S4A_993
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assurance Header Level 2
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual S4A S4A { get; set; }
        /// <summary>
        /// Security Value
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SVA SVA { get; set; }
    }
    
    /// <summary>
    /// Secured Receipt or Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "993")]
    public class TS993 : EdiMessage
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
        /// Transaction Set Response Header
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AK2 AK2 { get; set; }
        /// <summary>
        /// Security Protocol Error
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SPE SPE { get; set; }
        /// <summary>
        /// Assurance Protocol Error
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual APE APE { get; set; }
        /// <summary>
        /// Loop for Assurance Header Level 2
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<Loop_S4A_993> S4ALoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
