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
    /// Loop for Car Information Control
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CIC))]
    public class Loop_CIC_414
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Car Information Control
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CIC CIC { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<Loop_LX_414> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Car Hire Transaction Control
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTC))]
    public class Loop_CTC_414
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Car Hire Transaction Control
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CTC CTC { get; set; }
        /// <summary>
        /// Loop for Car Information Control
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(1000)]
        [Pos(2)]
        public virtual List<Loop_CIC_414> CICLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_414
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
        /// Car Hire Rates
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<CHR> CHR { get; set; }
        /// <summary>
        /// Car Hire Cycle
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<CYC> CYC { get; set; }
        /// <summary>
        /// External Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PRI PRI { get; set; }
        /// <summary>
        /// Price Authority Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PI PI { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Cycle/Summary Value
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual CV CV { get; set; }
    }
    
    /// <summary>
    /// Rail Carhire Settlements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "414")]
    public class TS414 : EdiMessage
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
        /// Leased Equipment Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual LEQ LEQ { get; set; }
        /// <summary>
        /// Loop for Car Hire Transaction Control
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<Loop_CTC_414> CTCLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
