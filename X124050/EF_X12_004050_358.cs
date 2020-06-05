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
    /// Loop for Bill of Lading
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MBL))]
    public class Loop_MBL_358
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Bill of Lading
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MBL MBL { get; set; }
        /// <summary>
        /// Manifest Amendment Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual M13 M13 { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual X1 X1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Port Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(P4))]
    public class Loop_P4_358
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
        /// Loop for Conveyance Identification
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<Loop_VID_358> VIDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Conveyance Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VID))]
    public class Loop_VID_358
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Conveyance Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VID VID { get; set; }
        /// <summary>
        /// Loop for Bill of Lading
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<Loop_MBL_358> MBLLoop { get; set; }
    }
    
    /// <summary>
    /// Customs Consist Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "358")]
    public class TS358 : EdiMessage
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
        public virtual List<Loop_P4_358> P4Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
