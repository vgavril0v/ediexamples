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
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_453
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
        /// Railroad Interline Service Definition Detail
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(2)]
        public virtual List<ISD> ISD { get; set; }
        /// <summary>
        /// Interline Service Commitment Detail
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(3)]
        public virtual List<ISC> ISC { get; set; }
    }
    
    /// <summary>
    /// Loop for Requested Service Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SR))]
    public class Loop_SR_453
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Requested Service Schedule
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SR SR { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(2)]
        public virtual List<Loop_LX_453> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Railroad Service Commitment Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "453")]
    public class TS453 : EdiMessage
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
        /// Beginning Segment for Service Commitment Advice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual SSC SSC { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(4)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(5)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        /// Origin and Destination
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual OD OD { get; set; }
        /// <summary>
        /// Price Authority Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<PI> PI { get; set; }
        /// <summary>
        /// Product (Commodity)
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<PR> PR { get; set; }
        /// <summary>
        /// Car Type
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(9)]
        public virtual List<CT> CT { get; set; }
        /// <summary>
        /// Association of American Railroads Pool Code Restrictions
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(10)]
        public virtual List<APR> APR { get; set; }
        /// <summary>
        /// Railroad Interline Service Special Handling Restrictions
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(11)]
        public virtual List<SHR> SHR { get; set; }
        /// <summary>
        /// Loop for Requested Service Schedule
        /// </summary>
        [DataMember]
        [ListCount(7)]
        [Pos(12)]
        public virtual List<Loop_SR_453> SRLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual SE SE { get; set; }
    }
}
