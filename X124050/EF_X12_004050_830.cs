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
    /// Loop for Forecast Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FST))]
    public class Loop_FST_830
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Forecast Schedule
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FST FST { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Destination Quantity
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(3)]
        public virtual List<SDQ> SDQ { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_LM_830> LMLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_830
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Unit Detail
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual UIT UIT { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Additional Item Detail
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(5)]
        public virtual List<PO3> PO3 { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(6)]
        public virtual List<CTP> CTP { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(7)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(40)]
        [Pos(8)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(9)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(10)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        /// Part Release Status
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual PRS PRS { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(13)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(14)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(15)]
        public virtual List<SAC> SAC { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(16)]
        public virtual List<ITD> ITD { get; set; }
        /// <summary>
        /// Tax Reference
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(17)]
        public virtual List<TAX> TAX { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        /// Lead Time
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(19)]
        public virtual List<LDT> LDT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Resource Authorization
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(21)]
        public virtual List<ATH> ATH { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual TD1 TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(23)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(24)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(25)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(26)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Demand Detail
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(27)]
        public virtual List<DD> DD { get; set; }
        /// <summary>
        /// Loop for Subline Item Detail
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(28)]
        public virtual List<Loop_SLN_830> SLNLoop { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(29)]
        public virtual List<Loop_N1_830> N1Loop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual List<Loop_LM_830> LMLoop { get; set; }
        /// <summary>
        /// Loop for Forecast Schedule
        /// </summary>
        [DataMember]
        [Pos(31)]
        public virtual List<Loop_FST_830> FSTLoop { get; set; }
        /// <summary>
        /// Loop for Ship/Delivery Pattern
        /// </summary>
        [DataMember]
        [ListCount(260)]
        [Pos(32)]
        public virtual List<Loop_SDP_830> SDPLoop { get; set; }
        /// <summary>
        /// Loop for Shipped/Received Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(33)]
        public virtual List<Loop_SHP_830> SHPLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Code Source Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_830
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_830
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
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual FOB FOB { get; set; }
    }
    
    /// <summary>
    /// Loop for Ship/Delivery Pattern
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SDP))]
    public class Loop_SDP_830
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SDP SDP { get; set; }
        /// <summary>
        /// Forecast Schedule
        /// </summary>
        [DataMember]
        [ListCount(260)]
        [Pos(2)]
        public virtual List<FST> FST { get; set; }
    }
    
    /// <summary>
    /// Loop for Shipped/Received Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SHP))]
    public class Loop_SHP_830
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipped/Received Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SHP SHP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Subline Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN))]
    public class Loop_SLN_830
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
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(2)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<NM1> NM1 { get; set; }
    }
    
    /// <summary>
    /// Planning Schedule with Release Capability
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "830")]
    public class TS830 : EdiMessage
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
        /// Beginning Segment for Planning Schedule
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BFR BFR { get; set; }
        /// <summary>
        /// Preassigned Purchase Order Numbers
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<XPO> XPO { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Tax Reference
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<TAX> TAX { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(9)]
        public virtual List<CTP> CTP { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(10)]
        public virtual List<SAC> SAC { get; set; }
        /// <summary>
        /// Sales Requirements
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual CSH CSH { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(12)]
        public virtual List<ITD> ITD { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(13)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(14)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(40)]
        [Pos(15)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(16)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(17)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(18)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(19)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(20)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(21)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(22)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(23)]
        public virtual List<Loop_N1_830> N1Loop { get; set; }
        /// <summary>
        /// Loop for Code Source Information
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual List<Loop_LM_830> LMLoop { get; set; }
        /// <summary>
        /// Loop for Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(25)]
        public virtual List<Loop_LIN_830> LINLoop { get; set; }
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual CTT CTT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual SE SE { get; set; }
    }
}
