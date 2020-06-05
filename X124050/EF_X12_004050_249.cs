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
    /// Loop for Animal Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ANI))]
    public class Loop_ANI_249
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Animal Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ANI ANI { get; set; }
        /// <summary>
        /// Animal Results Counts
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<ARC> ARC { get; set; }
        /// <summary>
        /// General Dosing Parameters
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<GDP> GDP { get; set; }
        /// <summary>
        /// Animal Disposition
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ADI ADI { get; set; }
        /// <summary>
        /// Animal Test Result
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<ATR> ATR { get; set; }
        /// <summary>
        /// Loop for Animal Observation Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_AOL_249> AOLLoop { get; set; }
        /// <summary>
        /// Loop for Animal Reproductive Status
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_AST_249> ASTLoop { get; set; }
        /// <summary>
        /// Loop for Animal Offspring/Fetus Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_AOI_249> AOILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Animal Offspring/Fetus Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AOI))]
    public class Loop_AOI_249
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Animal Offspring/Fetus Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AOI AOI { get; set; }
        /// <summary>
        /// Animal Test Result
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<ATR> ATR { get; set; }
        /// <summary>
        /// Loop for Animal Observation Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_AOL_249> AOLLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Animal Observation Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AOL))]
    public class Loop_AOL_249
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Animal Observation Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AOL AOL { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// Loop for Animal Observation Result
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_AOR_249> AORLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Animal Observation Result
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AOR))]
    public class Loop_AOR_249
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Animal Observation Result
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AOR AOR { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Animal Reproductive Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AST))]
    public class Loop_AST_249
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Animal Reproductive Status
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AST AST { get; set; }
        /// <summary>
        /// Animal Parturition Status
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ADT ADT { get; set; }
        /// <summary>
        /// Animal Offspring Counts
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<AOC> AOC { get; set; }
    }
    
    /// <summary>
    /// Loop for Group Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(GID))]
    public class Loop_GID_249
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Group Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual GID GID { get; set; }
        /// <summary>
        /// Group Dosage Parameters
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual GRP GRP { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<MSG> MSG { get; set; }
        /// <summary>
        /// General Dosing Parameters
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<GDP> GDP { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual List<Loop_N1_249_2> N1Loop { get; set; }
        /// <summary>
        /// Loop for Animal Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual List<Loop_ANI_249> ANILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_249
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
        /// Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual G61 G61 { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_249_2
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
    /// Animal Toxicological Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "249")]
    public class TS249 : EdiMessage
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
        /// Study Parameters
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual STP STP { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_N1_249> N1Loop { get; set; }
        /// <summary>
        /// Loop for Group Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual List<Loop_GID_249> GIDLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
