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
    /// Loop for Date or Time or Period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DTP))]
    public class Loop_DTP_159
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual LQ LQ { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_N9_159> N9Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G63))]
    public class Loop_G63_159
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Period
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G63 G63 { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Loop for Extended Reference Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_N9_159> N9Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_159
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
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Screen Theater Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_THE_159> THELoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Extended Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_159
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
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PCT PCT { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Screen Theater Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(THE))]
    public class Loop_THE_159
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Screen Theater Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual THE THE { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Language Use
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual LUI LUI { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual MEA MEA { get; set; }
        /// <summary>
        /// Industry Code Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual LQ LQ { get; set; }
        /// <summary>
        /// Loop for Date or Time or Period
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual List<Loop_DTP_159> DTPLoop { get; set; }
        /// <summary>
        /// Loop for Period
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_G63_159> G63Loop { get; set; }
    }
    
    /// <summary>
    /// Motion Picture Booking Confirmation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "159")]
    public class TS159 : EdiMessage
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
        /// Beginning Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGN BGN { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_LX_159> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
