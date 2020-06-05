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
    /// Loop for Hazardous Material
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(H1))]
    public class Loop_H1_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual H1 H1 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Additional Hazardous Material Description
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<Loop_H2_355> H2Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Additional Hazardous Material Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(H2))]
    public class Loop_H2_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Additional Hazardous Material Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual H2 H2 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        /// Loop for Manifest Amendment Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_M13_355 M13Loop { get; set; }
        /// <summary>
        /// Loop for Manifest Bill of Lading Details
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_M11_355 M11Loop { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(4)]
        public virtual List<Loop_N9_355> N9Loop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_N1_355> N1Loop { get; set; }
        /// <summary>
        /// Loop for In-bond Identifying Information
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(6)]
        public virtual List<Loop_M12_355> M12Loop { get; set; }
        /// <summary>
        /// Loop for General Order Status Information
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(7)]
        public virtual List<Loop_M14_355> M14Loop { get; set; }
        /// <summary>
        /// Loop for Customs Events Advisory Details
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(8)]
        public virtual List<Loop_M15_355> M15Loop { get; set; }
        /// <summary>
        /// Loop for Permit to Transfer Request Details
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(9)]
        public virtual List<Loop_M20_355> M20Loop { get; set; }
        /// <summary>
        /// Loop for Conveyance Identification
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(10)]
        public virtual List<Loop_VID_355> VIDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Manifest Bill of Lading Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M11))]
    public class Loop_M11_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Manifest Bill of Lading Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M11 M11 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for In-bond Identifying Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M12))]
    public class Loop_M12_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// In-bond Identifying Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M12 M12 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Port Function
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<Loop_P5_355> P5Loop { get; set; }
        /// <summary>
        /// Loop for Supplementary In-Bond Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_M21_355 M21Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Manifest Amendment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M13))]
    public class Loop_M13_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Manifest Amendment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M13 M13 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for General Order Status Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M14))]
    public class Loop_M14_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// General Order Status Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M14 M14 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Customs Events Advisory Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M15))]
    public class Loop_M15_355
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
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Permit to Transfer Request Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M20))]
    public class Loop_M20_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Permit to Transfer Request Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M20 M20 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Supplementary In-Bond Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M21))]
    public class Loop_M21_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Supplementary In-Bond Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M21 M21 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Bill of Lading
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MBL))]
    public class Loop_MBL_355
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
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Manifest Amendment Details
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(3)]
        public virtual List<Loop_M13_355> M13Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_355
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
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<Loop_N3_355> N3Loop { get; set; }
        /// <summary>
        /// Loop for Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_N4_355 N4Loop { get; set; }
        /// <summary>
        /// Loop for Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_PER_355 PERLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Quantity and Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N10))]
    public class Loop_N10_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity and Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N10 N10 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Hazardous Material
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<Loop_H1_355> H1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N3))]
    public class Loop_N3_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Geographic Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N4))]
    public class Loop_N4_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Extended Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N9 N9 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Port Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(P4))]
    public class Loop_P4_355
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
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<Loop_LX_355> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Port Function
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(P5))]
    public class Loop_P5_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Port Function
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual P5 P5 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Administrative Communications Contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PER))]
    public class Loop_PER_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Motor Vehicle Control
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VC))]
    public class Loop_VC_355
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Motor Vehicle Control
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VC VC { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Conveyance Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VID))]
    public class Loop_VID_355
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
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Bill of Lading
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<Loop_MBL_355> MBLLoop { get; set; }
        /// <summary>
        /// Loop for Motor Vehicle Control
        /// </summary>
        [DataMember]
        [ListCount(36)]
        [Pos(4)]
        public virtual List<Loop_VC_355> VCLoop { get; set; }
        /// <summary>
        /// Loop for Quantity and Description
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(5)]
        public virtual List<Loop_N10_355> N10Loop { get; set; }
    }
    
    /// <summary>
    /// U.S. Customs Acceptance/Rejection
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "355")]
    public class TS355 : EdiMessage
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
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Port Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<Loop_P4_355> P4Loop { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual K3 K3 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
