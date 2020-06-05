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
    /// Loop for Statement/Invoice Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G48))]
    public class Loop_G48_882
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Statement/Invoice Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G48 G48 { get; set; }
        /// <summary>
        /// Loop for Allowance or Charge
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<Loop_G72_882> G72Loop { get; set; }
        /// <summary>
        /// Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<G23> G23 { get; set; }
        /// <summary>
        /// F.O.B. Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual G25 G25 { get; set; }
        /// <summary>
        /// Total Invoice Quantity
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual G31 G31 { get; set; }
        /// <summary>
        /// Total Dollars Summary
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual G33 G33 { get; set; }
    }
    
    /// <summary>
    /// Loop for Allowance or Charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G72))]
    public class Loop_G72_882
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or Charge
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G72 G72 { get; set; }
        /// <summary>
        /// Allowance or Charge Description
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<G73> G73 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_882
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
    }
    
    /// <summary>
    /// Direct Store Delivery Summary Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "882")]
    public class TS882 : EdiMessage
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
        /// Statement Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual G47 G47 { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<Loop_N1_882> N1Loop { get; set; }
        /// <summary>
        /// Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(5)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<G23> G23 { get; set; }
        /// <summary>
        /// Loop for Statement/Invoice Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(7)]
        public virtual List<Loop_G48_882> G48Loop { get; set; }
        /// <summary>
        /// Statement Total
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual G49 G49 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SE SE { get; set; }
    }
}
