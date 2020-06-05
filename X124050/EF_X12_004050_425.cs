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
    /// Loop for Waybill Request Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ZT))]
    public class Loop_ZT_425
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Waybill Request Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ZT ZT { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual D9 D9 { get; set; }
    }
    
    /// <summary>
    /// Rail Waybill Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "425")]
    public class TS425 : EdiMessage
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
        /// Loop for Waybill Request Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(255)]
        [Pos(2)]
        public virtual List<Loop_ZT_425> ZTLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SE SE { get; set; }
    }
}
