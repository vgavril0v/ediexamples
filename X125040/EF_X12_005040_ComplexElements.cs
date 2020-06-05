namespace EdiFabric.Templates.X12005040
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
    /// Composite Unit of Measure
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C001")]
    public class C001 : I_C001
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        public string Exponent_02 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        public string Multiplier_03 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(5)]
        public string Exponent_05 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        public string Multiplier_06 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(8)]
        public string Exponent_08 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(9)]
        public string Multiplier_09 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(11)]
        public string Exponent_11 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(12)]
        public string Multiplier_12 { get; set; }
        /// <summary>
        /// Unit or Basis for Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        /// <summary>
        /// Exponent
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(14)]
        public string Exponent_14 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(15)]
        public string Multiplier_15 { get; set; }
    }
    
    /// <summary>
    /// Actions Indicated
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public string PaperworkReportActionCode_01 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public string PaperworkReportActionCode_02 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public string PaperworkReportActionCode_03 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public string PaperworkReportActionCode_04 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    /// <summary>
    /// Composite Medical Procedure Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C003")]
    public class C003 : I_C003
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(1)]
        public string ProductServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public string ProductServiceID_02 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public string ProcedureModifier_03 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public string ProcedureModifier_04 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public string ProcedureModifier_05 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public string ProcedureModifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(9)]
        public string ProcedureModifier_09 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(10)]
        public string ProcedureModifier_10 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(11)]
        public string ProcedureModifier_11 { get; set; }
        /// <summary>
        /// Procedure Modifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(12)]
        public string ProcedureModifier_12 { get; set; }
    }
    
    /// <summary>
    /// Composite Diagnosis Code Pointer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C004")]
    public class C004 : I_C004
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(1)]
        public string DiagnosisCodePointer_01 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(2)]
        public string DiagnosisCodePointer_02 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(3)]
        public string DiagnosisCodePointer_03 { get; set; }
        /// <summary>
        /// Diagnosis Code Pointer
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(4)]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    /// <summary>
    /// Tooth Surface
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C005")]
    public class C005 : I_C005
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(1)]
        public string ToothSurfaceCode_01 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(2)]
        public string ToothSurfaceCode_02 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(3)]
        public string ToothSurfaceCode_03 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(4)]
        public string ToothSurfaceCode_04 { get; set; }
        /// <summary>
        /// Tooth Surface Code
        /// </summary>
        [DataMember]
        [DataElement("1369", typeof(X12_ID_1369))]
        [Pos(5)]
        public string ToothSurfaceCode_05 { get; set; }
    }
    
    /// <summary>
    /// Oral Cavity Designation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C006")]
    public class C006 : I_C006
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1361", typeof(X12_AN))]
        [Pos(1)]
        public string OralCavityDesignationCode_01 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1361", typeof(X12_AN))]
        [Pos(2)]
        public string OralCavityDesignationCode_02 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1361", typeof(X12_AN))]
        [Pos(3)]
        public string OralCavityDesignationCode_03 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1361", typeof(X12_AN))]
        [Pos(4)]
        public string OralCavityDesignationCode_04 { get; set; }
        /// <summary>
        /// Oral Cavity Designation Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1361", typeof(X12_AN))]
        [Pos(5)]
        public string OralCavityDesignationCode_05 { get; set; }
    }
    
    /// <summary>
    /// Amount Qualifying Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C007")]
    public class C007 : I_C007
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(2)]
        public string AmountQualifierCode_02 { get; set; }
        /// <summary>
        /// Value Detail Code
        /// </summary>
        [DataMember]
        [DataElement("1638", typeof(X12_ID_1638))]
        [Pos(3)]
        public string ValueDetailCode_03 { get; set; }
        /// <summary>
        /// Measurement Significance Code
        /// </summary>
        [DataMember]
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(4)]
        public string MeasurementSignificanceCode_04 { get; set; }
        /// <summary>
        /// Unit of Time Period or Interval
        /// </summary>
        [DataMember]
        [DataElement("344", typeof(X12_ID_344))]
        [Pos(5)]
        public string UnitofTimePeriodorInterval_05 { get; set; }
        /// <summary>
        /// Net/Gross Code
        /// </summary>
        [DataMember]
        [DataElement("1637", typeof(X12_ID_1637))]
        [Pos(6)]
        public string NetGrossCode_06 { get; set; }
        /// <summary>
        /// Measurement Significance Code
        /// </summary>
        [DataMember]
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(7)]
        public string MeasurementSignificanceCode_07 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(8)]
        public string Description_08 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(9)]
        public string IndustryCode_09 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(10)]
        public string CodeListQualifierCode_10 { get; set; }
    }
    
    /// <summary>
    /// Health Care Code Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022 : I_C022
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        /// <summary>
        /// Date Time Period Format Qualifier
        /// </summary>
        [DataMember]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        /// <summary>
        /// Date Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    /// <summary>
    /// Health Care Service Location Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C023")]
    public class C023 : I_C023
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Facility Code Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(1)]
        public string FacilityCodeValue_01 { get; set; }
        /// <summary>
        /// Facility Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("1332", typeof(X12_ID_1332))]
        [Pos(2)]
        public string FacilityCodeQualifier_02 { get; set; }
        /// <summary>
        /// Claim Frequency Type Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("1325", typeof(X12_AN))]
        [Pos(3)]
        public string ClaimFrequencyTypeCode_03 { get; set; }
    }
    
    /// <summary>
    /// Related Causes Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C024")]
    public class C024 : I_C024
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(1)]
        public string RelatedCausesCode_01 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(2)]
        public string RelatedCausesCode_02 { get; set; }
        /// <summary>
        /// Related-Causes Code
        /// </summary>
        [DataMember]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(3)]
        public string RelatedCausesCode_03 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(5)]
        public string CountryCode_05 { get; set; }
    }
    
    /// <summary>
    /// Assurance Token Parameters
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C028")]
    public class C028 : I_C028
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(1)]
        public string AssuranceTokenParameterCode_01 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(2)]
        public string AssuranceTokenParameterValue_02 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(3)]
        public string AssuranceTokenParameterCode_03 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(4)]
        public string AssuranceTokenParameterValue_04 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(5)]
        public string AssuranceTokenParameterCode_05 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(6)]
        public string AssuranceTokenParameterValue_06 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(7)]
        public string AssuranceTokenParameterCode_07 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(8)]
        public string AssuranceTokenParameterValue_08 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(9)]
        public string AssuranceTokenParameterCode_09 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(10)]
        public string AssuranceTokenParameterValue_10 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(11)]
        public string AssuranceTokenParameterCode_11 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(12)]
        public string AssuranceTokenParameterValue_12 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(13)]
        public string AssuranceTokenParameterCode_13 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(14)]
        public string AssuranceTokenParameterValue_14 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(15)]
        public string AssuranceTokenParameterCode_15 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(16)]
        public string AssuranceTokenParameterValue_16 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(17)]
        public string AssuranceTokenParameterCode_17 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(18)]
        public string AssuranceTokenParameterValue_18 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Code
        /// </summary>
        [DataMember]
        [DataElement("1439", typeof(X12_ID_1439))]
        [Pos(19)]
        public string AssuranceTokenParameterCode_19 { get; set; }
        /// <summary>
        /// Assurance Token Parameter Value
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("1442", typeof(X12_AN))]
        [Pos(20)]
        public string AssuranceTokenParameterValue_20 { get; set; }
    }
    
    /// <summary>
    /// Position in Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C030")]
    public class C030 : I_C030
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Element Position in Segment
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("722", typeof(X12_N0))]
        [Pos(1)]
        public string ElementPositioninSegment_01 { get; set; }
        /// <summary>
        /// Component Data Element Position in Composite
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1528", typeof(X12_N0))]
        [Pos(2)]
        public string ComponentDataElementPositioninComposite_02 { get; set; }
        /// <summary>
        /// Repeating Data Element Position
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("1686", typeof(X12_N0))]
        [Pos(3)]
        public string RepeatingDataElementPosition_03 { get; set; }
    }
    
    /// <summary>
    /// Security Token Value
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C033")]
    public class C033 : I_C033
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Security Value Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1572", typeof(X12_ID_1572))]
        [Pos(1)]
        public string SecurityValueQualifier_01 { get; set; }
        /// <summary>
        /// Encoded Security Value
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1573", typeof(X12_AN))]
        [Pos(2)]
        public string EncodedSecurityValue_02 { get; set; }
    }
    
    /// <summary>
    /// Computation Methods
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C034")]
    public class C034 : I_C034
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assurance Algorithm
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1574", typeof(X12_ID_1574))]
        [Pos(1)]
        public string AssuranceAlgorithm_01 { get; set; }
        /// <summary>
        /// Hashing Algorithm
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1575", typeof(X12_ID_1575))]
        [Pos(2)]
        public string HashingAlgorithm_02 { get; set; }
    }
    
    /// <summary>
    /// Provider Specialty Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C035")]
    public class C035 : I_C035
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Provider Specialty Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1222", typeof(X12_ID_1222))]
        [Pos(1)]
        public string ProviderSpecialtyCode_01 { get; set; }
        /// <summary>
        /// Agency Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AgencyQualifierCode_02 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(3)]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    /// <summary>
    /// Index Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C036")]
    public class C036 : I_C036
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Configuration Type Code
        /// </summary>
        [DataMember]
        [DataElement("1395", typeof(X12_ID_1395))]
        [Pos(1)]
        public string ConfigurationTypeCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ReferenceIdentification_03 { get; set; }
        /// <summary>
        /// X-Peg
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("863", typeof(X12_R))]
        [Pos(4)]
        public string XPeg_04 { get; set; }
        /// <summary>
        /// Y-Peg
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("864", typeof(X12_R))]
        [Pos(5)]
        public string YPeg_05 { get; set; }
    }
    
    /// <summary>
    /// Tax Field Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C037")]
    public class C037 : I_C037
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tax Information Identification Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("817", typeof(X12_AN))]
        [Pos(1)]
        public string TaxInformationIdentificationNumber_01 { get; set; }
        /// <summary>
        /// Application Error Condition Code
        /// </summary>
        [DataMember]
        [DataElement("647", typeof(X12_ID_647))]
        [Pos(2)]
        public string ApplicationErrorConditionCode_02 { get; set; }
    }
    
    /// <summary>
    /// Reference Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040 : I_C040
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        /// <summary>
        /// Reference Identification Qualifier
        /// </summary>
        [DataMember]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    /// <summary>
    /// Adjustment Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C042")]
    public class C042 : I_C042
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Adjustment Reason Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("426", typeof(X12_ID_426))]
        [Pos(1)]
        public string AdjustmentReasonCode_01 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
    }
    
    /// <summary>
    /// Health Care Claim Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C043")]
    public class C043 : I_C043
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(1)]
        public string IndustryCode_01 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(3)]
        public string EntityIdentifierCode_03 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(4)]
        public string CodeListQualifierCode_04 { get; set; }
    }
    
    /// <summary>
    /// Conditions Indicated
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C045")]
    public class C045 : I_C045
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(1)]
        public string ConditionIndicator_01 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(2)]
        public string ConditionIndicator_02 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(3)]
        public string ConditionIndicator_03 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        /// <summary>
        /// Condition Indicator
        /// </summary>
        [DataMember]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
    }
    
    /// <summary>
    /// Composite Qualifier Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C046")]
    public class C046 : I_C046
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(1)]
        public string RateValueQualifier_01 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(2)]
        public string RateValueQualifier_02 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(3)]
        public string RateValueQualifier_03 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(4)]
        public string RateValueQualifier_04 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(5)]
        public string RateValueQualifier_05 { get; set; }
    }
    
    /// <summary>
    /// Composite Type of Real Estate Asset Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C047")]
    public class C047 : I_C047
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Type of Real Estate Asset Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(1)]
        public string TypeofRealEstateAssetCode_01 { get; set; }
        /// <summary>
        /// Type of Real Estate Asset Code
        /// </summary>
        [DataMember]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(2)]
        public string TypeofRealEstateAssetCode_02 { get; set; }
        /// <summary>
        /// Type of Real Estate Asset Code
        /// </summary>
        [DataMember]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(3)]
        public string TypeofRealEstateAssetCode_03 { get; set; }
        /// <summary>
        /// Type of Real Estate Asset Code
        /// </summary>
        [DataMember]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(4)]
        public string TypeofRealEstateAssetCode_04 { get; set; }
        /// <summary>
        /// Type of Real Estate Asset Code
        /// </summary>
        [DataMember]
        [DataElement("1074", typeof(X12_ID_1074))]
        [Pos(5)]
        public string TypeofRealEstateAssetCode_05 { get; set; }
    }
    
    /// <summary>
    /// Composite Use of Proceeds
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C048")]
    public class C048 : I_C048
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Use of Proceeds Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1082", typeof(X12_ID_1082))]
        [Pos(1)]
        public string UseofProceedsCode_01 { get; set; }
        /// <summary>
        /// Refinance Type Code
        /// </summary>
        [DataMember]
        [DataElement("1680", typeof(X12_ID_1680))]
        [Pos(2)]
        public string RefinanceTypeCode_02 { get; set; }
        /// <summary>
        /// Use of Proceeds Code
        /// </summary>
        [DataMember]
        [DataElement("1082", typeof(X12_ID_1082))]
        [Pos(3)]
        public string UseofProceedsCode_03 { get; set; }
        /// <summary>
        /// Yes/No Condition or Response Code
        /// </summary>
        [DataMember]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(4)]
        public string YesNoConditionorResponseCode_04 { get; set; }
    }
    
    /// <summary>
    /// Certificate Look-up Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C050")]
    public class C050 : I_C050
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Look-up Value Protocol Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1675", typeof(X12_ID_1675))]
        [Pos(1)]
        public string LookupValueProtocolCode_01 { get; set; }
        /// <summary>
        /// Filter ID Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(2)]
        public string FilterIDCode_02 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(3)]
        public string VersionIdentifier_03 { get; set; }
        /// <summary>
        /// Look-up Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4096)]
        [DataElement("1565", typeof(X12_AN))]
        [Pos(4)]
        public string LookupValue_04 { get; set; }
        /// <summary>
        /// Look-up Value Protocol Code
        /// </summary>
        [DataMember]
        [DataElement("1675", typeof(X12_ID_1675))]
        [Pos(5)]
        public string LookupValueProtocolCode_05 { get; set; }
        /// <summary>
        /// Filter ID Code
        /// </summary>
        [DataMember]
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(6)]
        public string FilterIDCode_06 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        /// <summary>
        /// Look-up Value
        /// </summary>
        [DataMember]
        [StringLength(1, 4096)]
        [DataElement("1565", typeof(X12_AN))]
        [Pos(8)]
        public string LookupValue_08 { get; set; }
        /// <summary>
        /// Look-up Value Protocol Code
        /// </summary>
        [DataMember]
        [DataElement("1675", typeof(X12_ID_1675))]
        [Pos(9)]
        public string LookupValueProtocolCode_09 { get; set; }
        /// <summary>
        /// Filter ID Code
        /// </summary>
        [DataMember]
        [DataElement("1570", typeof(X12_ID_1570))]
        [Pos(10)]
        public string FilterIDCode_10 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(11)]
        public string VersionIdentifier_11 { get; set; }
        /// <summary>
        /// Look-up Value
        /// </summary>
        [DataMember]
        [StringLength(1, 4096)]
        [DataElement("1565", typeof(X12_AN))]
        [Pos(12)]
        public string LookupValue_12 { get; set; }
    }
    
    /// <summary>
    /// Medicare Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C052")]
    public class C052 : I_C052
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Medicare Plan Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1218", typeof(X12_ID_1218))]
        [Pos(1)]
        public string MedicarePlanCode_01 { get; set; }
        /// <summary>
        /// Eligibility Reason Code
        /// </summary>
        [DataMember]
        [DataElement("1701", typeof(X12_ID_1701))]
        [Pos(2)]
        public string EligibilityReasonCode_02 { get; set; }
        /// <summary>
        /// Eligibility Reason Code
        /// </summary>
        [DataMember]
        [DataElement("1701", typeof(X12_ID_1701))]
        [Pos(3)]
        public string EligibilityReasonCode_03 { get; set; }
        /// <summary>
        /// Eligibility Reason Code
        /// </summary>
        [DataMember]
        [DataElement("1701", typeof(X12_ID_1701))]
        [Pos(4)]
        public string EligibilityReasonCode_04 { get; set; }
    }
    
    /// <summary>
    /// Standards Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C053")]
    public class C053 : I_C053
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Electronic Form Standards Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("922", typeof(X12_ID_922))]
        [Pos(1)]
        public string ElectronicFormStandardsTypeCode_01 { get; set; }
        /// <summary>
        /// Electronic Form Standards Identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("1707", typeof(X12_AN))]
        [Pos(2)]
        public string ElectronicFormStandardsIdentifier_02 { get; set; }
        /// <summary>
        /// Implementation Convention Reference
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("1705", typeof(X12_AN))]
        [Pos(3)]
        public string ImplementationConventionReference_03 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(4)]
        public string VersionIdentifier_04 { get; set; }
        /// <summary>
        /// Revision Value
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("796", typeof(X12_AN))]
        [Pos(5)]
        public string RevisionValue_05 { get; set; }
    }
    
    /// <summary>
    /// Tax Service Non-payment Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C055")]
    public class C055 : I_C055
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(1)]
        public string TaxServiceNonpaymentCode_01 { get; set; }
        /// <summary>
        /// Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(2)]
        public string TaxServiceNonpaymentCode_02 { get; set; }
        /// <summary>
        /// Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(3)]
        public string TaxServiceNonpaymentCode_03 { get; set; }
        /// <summary>
        /// Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(4)]
        public string TaxServiceNonpaymentCode_04 { get; set; }
        /// <summary>
        /// Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(5)]
        public string TaxServiceNonpaymentCode_05 { get; set; }
        /// <summary>
        /// Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(6)]
        public string TaxServiceNonpaymentCode_06 { get; set; }
        /// <summary>
        /// Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(7)]
        public string TaxServiceNonpaymentCode_07 { get; set; }
        /// <summary>
        /// Tax Service Non-payment Code
        /// </summary>
        [DataMember]
        [DataElement("1720", typeof(X12_ID_1720))]
        [Pos(8)]
        public string TaxServiceNonpaymentCode_08 { get; set; }
    }
    
    /// <summary>
    /// Composite Race or Ethnicity Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C056")]
    public class C056 : I_C056
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Race or Ethnicity Code
        /// </summary>
        [DataMember]
        [DataElement("1109", typeof(X12_ID_1109))]
        [Pos(1)]
        public string RaceorEthnicityCode_01 { get; set; }
        /// <summary>
        /// Code List Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(2)]
        public string CodeListQualifierCode_02 { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(3)]
        public string IndustryCode_03 { get; set; }
    }
    
    /// <summary>
    /// Communication Number Component
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C057")]
    public class C057 : I_C057
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(1)]
        public string CommunicationNumberQualifier_01 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(2)]
        public string CommunicationNumber_02 { get; set; }
    }
    
    /// <summary>
    /// Context Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C998")]
    public class C998 : I_C998
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Context Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("9999", typeof(X12_AN))]
        [Pos(1)]
        public string ContextName_01 { get; set; }
        /// <summary>
        /// Context Reference
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9998", typeof(X12_AN))]
        [Pos(2)]
        public string ContextReference_02 { get; set; }
    }
    
    /// <summary>
    /// Reference in Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C999")]
    public class C999 : I_C999
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Data Element Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("725", typeof(X12_N0))]
        [Pos(1)]
        public string DataElementReferenceNumber_01 { get; set; }
        /// <summary>
        /// Data Element Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("725", typeof(X12_N0))]
        [Pos(2)]
        public string DataElementReferenceNumber_02 { get; set; }
    }
}
