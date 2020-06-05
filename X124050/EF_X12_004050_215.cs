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
    /// Loop for International Manifest Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AT6))]
    public class Loop_AT6_215
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// International Manifest Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AT6 AT6 { get; set; }
        /// <summary>
        /// Shipment Rates and Charges
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MS5 MS5 { get; set; }
        /// <summary>
        /// Baseline Item Data (Invoice)
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual IT1 IT1 { get; set; }
        /// <summary>
        /// Charge
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<CGS> CGS { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual L11 L11 { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(6)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<TXI> TXI { get; set; }
        /// <summary>
        /// Shipment or Package Dimensions
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual MS4 MS4 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual L5 L5 { get; set; }
        /// <summary>
        /// Loop for Subline Item Detail
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(10)]
        public virtual List<Loop_SLN_215> SLNLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Carton (Package) Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CD3))]
    public class Loop_CD3_215
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Carton (Package) Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CD3 CD3 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Shipment or Package Dimensions
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual MS4 MS4 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Shipment Quantity and Weight
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<MS6> MS6 { get; set; }
        /// <summary>
        /// Ancillary Charges
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<ACS> ACS { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(9)]
        public virtual List<Loop_N1_215_2> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_215
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
        [Pos(2)]
        public virtual N2 N2 { get; set; }
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
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<X1> X1 { get; set; }
        /// <summary>
        /// Import License
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<X2> X2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_215_2
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
        [Pos(2)]
        public virtual N2 N2 { get; set; }
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
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<X1> X1 { get; set; }
        /// <summary>
        /// Import License
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<X2> X2 { get; set; }
        /// <summary>
        /// Port or Terminal
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<R4> R4 { get; set; }
    }
    
    /// <summary>
    /// Loop for Subline Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN))]
    public class Loop_SLN_215
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subline Item Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SLN SLN { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Quantity and Description
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<N10> N10 { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<TXI> TXI { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    /// <summary>
    /// Loop for Consolidated Shipment Manifest Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SMD))]
    public class Loop_SMD_215
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Consolidated Shipment Manifest Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SMD SMD { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Shipment Quantity and Weight
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<MS6> MS6 { get; set; }
        /// <summary>
        /// Shipment Rates and Charges
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<MS5> MS5 { get; set; }
        /// <summary>
        /// Shipment or Package Dimensions
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual MS4 MS4 { get; set; }
        /// <summary>
        /// Ancillary Charges
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<ACS> ACS { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_N1_215_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Carton (Package) Detail
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999999)]
        [Pos(10)]
        public virtual List<Loop_CD3_215> CD3Loop { get; set; }
        /// <summary>
        /// Loop for International Manifest Information
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(11)]
        public virtual List<Loop_AT6_215> AT6Loop { get; set; }
    }
    
    /// <summary>
    /// Motor Carrier Pick-up Manifest
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "215")]
    public class TS215 : EdiMessage
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
        /// Beginning Segment for Booking or Pick-up/Delivery
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B1 B1 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        /// Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(5)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual Loop_N1_215 N1Loop { get; set; }
        /// <summary>
        /// Loop for Consolidated Shipment Manifest Data
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999999)]
        [Pos(7)]
        public virtual List<Loop_SMD_215> SMDLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
