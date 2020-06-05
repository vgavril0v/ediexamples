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
    /// Loop for Export Shipment Identifying Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(BA1))]
    public class Loop_BA1_601
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Export Shipment Identifying Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BA1 BA1 { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Vessel Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual V5 V5 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Port Function
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<P5> P5 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// In-bond Identifying Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual M12 M12 { get; set; }
        /// <summary>
        /// Conveyance Identification
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(8)]
        public virtual List<VID> VID { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_N1_601> N1Loop { get; set; }
        /// <summary>
        /// Loop for Commodity Details
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(10)]
        public virtual List<Loop_L13_601> L13Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Commodity Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(L13))]
    public class Loop_L13_601
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Commodity Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L13 L13 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual X1 X1 { get; set; }
        /// <summary>
        /// Vehicle Information
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<VEH> VEH { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<Loop_N1_601_2> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_601
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_601_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
    }
    
    /// <summary>
    /// U.S. Customs Export Shipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "601")]
    public class TS601 : EdiMessage
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
        /// Loop for Export Shipment Identifying Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<Loop_BA1_601> BA1Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SE SE { get; set; }
    }
}
