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
    /// Railroad Station Master File
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "431")]
    public class TS431 : EdiMessage
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
        /// Beginning Segment for Railroad Station Master File
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual SMB SMB { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N4> N4 { get; set; }
        /// <summary>
        /// Shipment Conditions
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<CD> CD { get; set; }
        /// <summary>
        /// Station Codes Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual SMS SMS { get; set; }
        /// <summary>
        /// Station Address
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<SMA> SMA { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Cross Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<SMR> SMR { get; set; }
        /// <summary>
        /// Operational Services
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<SMO> SMO { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual SE SE { get; set; }
    }
}
