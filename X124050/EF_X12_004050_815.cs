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
    /// Loop for Cryptographic Service Message Certificates and Keys
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CSC))]
    public class Loop_CSC_815
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Cryptographic Service Message Certificates and Keys
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CSC CSC { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    /// <summary>
    /// Cryptographic Service Message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "815")]
    public class TS815 : EdiMessage
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
        /// Cryptographic Service Message Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual CSM CSM { get; set; }
        /// <summary>
        /// Cryptographic Service Message Body
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<CSB> CSB { get; set; }
        /// <summary>
        /// Loop for Cryptographic Service Message Certificates and Keys
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_CSC_815> CSCLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
