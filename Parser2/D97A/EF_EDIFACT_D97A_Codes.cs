namespace EdiFabric.Templates.EdifactD97A
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using System.Xml.Serialization;
    
    
    [Serializable()]
    [DataContract()]
    public class EDIFACT_A
    {
    }
    
    [Serializable()]
    [DataContract()]
    public class EDIFACT_AN
    {
    }
    
    /// <summary>
    /// Document/message name, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117," +
        "118,119,12,120,121,122,123,124,125,126,127,128,129,13,130,131,132,133,134,135,13" +
        "6,137,138,139,14,140,142,143,144,145,146,147,148,149,15,150,151,152,153,154,155," +
        "156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,17" +
        "4,175,176,177,178,179,18,180,181,182,183,184,19,190,2,20,201,202,203,204,205,206" +
        ",207,208,209,21,210,211,212,215,22,220,221,222,223,224,225,226,227,228,229,23,23" +
        "0,231,232,233,24,240,241,242,245,25,26,27,270,271,28,29,3,30,31,310,311,315,32,3" +
        "20,325,326,327,328,33,330,335,34,340,341,343,345,35,350,351,36,37,370,38,380,381" +
        ",382,383,384,385,386,387,388,389,39,390,393,394,395,396,4,40,409,41,412,42,425,4" +
        "26,427,428,429,43,430,431,435,44,447,448,45,450,451,452,454,455,456,457,458,460," +
        "465,466,467,468,469,47,48,481,485,49,490,491,492,493,5,51,52,520,53,530,54,55,55" +
        "0,56,57,575,58,580,59,6,60,61,610,62,621,622,623,624,63,630,631,632,633,635,64,6" +
        "40,65,650,655,66,67,68,69,7,70,700,701,702,703,704,705,706,707,708,709,71,710,71" +
        "1,712,713,714,715,716,72,720,722,723,724,73,730,74,740,741,743,744,745,746,75,75" +
        "0,76,760,761,763,764,765,766,77,770,775,78,780,781,782,783,784,785,786,787,788,7" +
        "89,79,790,791,792,793,794,795,796,797,798,799,8,80,81,810,811,812,82,820,821,822" +
        ",823,824,825,83,830,833,84,840,841,85,850,851,852,853,855,856,86,860,861,862,863" +
        ",864,865,87,870,88,89,890,895,896,9,90,901,91,910,911,913,914,915,916,917,92,925" +
        ",926,927,929,93,930,931,932,933,934,935,936,937,938,94,940,941,95,950,951,952,95" +
        "3,954,955,96,960,961,962,963,964,965,966,97,98,99,990,991,995,996,998,")]
    public class EDIFACT_ID_1001
    {
    }
    
    /// <summary>
    /// Message section, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,2,5,6,7,8,9,")]
    public class EDIFACT_ID_1049
    {
    }
    
    /// <summary>
    /// Document line indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_1073
    {
    }
    
    /// <summary>
    /// Code list qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",100,101,102,103,104,105,106,107,108,109,110,112,113,114,115,116,117,118,119,12,120,121,122,123,125,126,127,128,129,130,131,132,133,134,135,136,137,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,16,160,161,162,163,164,165,166,167,168,169,170,172,173,174,175,176,177,178,179,180,181,182,183,184,185,186,187,188,189,190,191,192,23,25,35,36,37,38,39,42,43,44,45,46,52,53,54,55,56,57,58,59,60,61,62,63,64,65,67,68,69,70,71,72,ZZZ,")]
    public class EDIFACT_ID_1131
    {
    }
    
    /// <summary>
    /// Reference qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAA,AAB,AAC,AAD,AAE,AAG,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAS,AAT,AAU,AAV,AAY,AAZ," +
        "ABA,ABB,ABC,ABD,ABE,ABG,ABH,ABI,ABJ,ABK,ABL,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABW,ABX," +
        "ABY,ABZ,AC,ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,A" +
        "CR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH,ADI,ADJ,ADK,A" +
        "DL,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,ADU,ADV,ADW,ADY,ADZ,AE,AEA,AEB,AEC,AED,AEE,AE" +
        "F,AEG,AEH,AEI,AEJ,AEK,AEL,AEM,AEN,AEO,AEP,AEQ,AER,AES,AET,AEU,AEV,AEW,AEX,AEY,AE" +
        "Z,AF,AFA,AFB,AFC,AFD,AFE,AFF,AFG,AFH,AFI,AFJ,AFK,AFL,AFM,AFN,AFO,AFP,AFQ,AFR,AFS" +
        ",AFT,AFU,AFV,AFW,AFX,AFY,AFZ,AGA,AGB,AGC,AGD,AGE,AGF,AGG,AGH,AGI,AGJ,AGK,AGL,AGM" +
        ",AGN,AGO,AGP,AGQ,AGR,AGS,AGT,AGU,AGV,AGW,AGX,AGY,AGZ,AHA,AHB,AHC,AHD,AHE,AHF,AHG" +
        ",AHH,AHI,AHJ,AHK,AHL,AHM,AHN,AHO,AHP,AHQ,AHR,AHS,AHT,AHU,AHV,AHW,AHX,AHY,AHZ,AIA" +
        ",AIB,AIC,AID,AIE,AIF,AIG,AIH,AII,AIJ,AIK,AIL,AIM,AIN,AIO,AIP,AIQ,AIR,AIS,AIT,AIU" +
        ",AIV,AIW,AIX,AIY,AIZ,AJA,AJB,AJC,AJD,AJE,AJF,AJG,AJH,AJI,AJJ,AJK,AJL,AJM,AJN,AJO" +
        ",AJP,AJQ,AJR,AJS,AJT,AJU,AJV,AJW,AJX,AJY,AJZ,AKA,AKB,AKC,AKD,AKE,AKF,AKG,AKK,AKL" +
        ",AKM,AKO,AKP,AKQ,AKR,AKS,AKT,AKU,AKV,AKW,AKX,ALA,ALB,ALC,ALD,ALE,ALF,ALG,ALH,ALI" +
        ",ALJ,ALK,ALL,ALM,ALN,ALO,ALP,ALQ,ALR,ALS,ALT,ALU,ALV,ALW,ALX,ALY,ALZ,AMA,AMB,AMC" +
        ",AMD,AME,AMF,AMG,AMI,AMJ,AMK,AML,AMN,AMQ,AMR,AMS,AMT,AMU,AP,ASC,AU,AV,AWB,BA,BC," +
        "BD,BE,BH,BM,BN,BO,BR,BT,BW,CAS,CD,CEC,CFE,CFO,CG,CH,CK,CKN,CM,CMR,CN,CNO,CO,COF," +
        "CP,CR,CRN,CS,CST,CT,CU,CV,CW,CZ,DA,DAN,DB,DI,DL,DM,DQ,DR,EA,EB,ED,EE,EI,EN,EP,EQ" +
        ",ER,ERN,ET,EX,FC,FF,FI,FLW,FN,FO,FS,FT,FV,FX,GA,GC,GD,GDN,GN,HS,HWB,IA,IB,ICA,IC" +
        "E,ICO,II,IL,INB,INN,INO,IP,IS,IT,IV,JB,JE,LA,LAN,LAR,LB,LC,LI,LO,LS,MA,MB,MF,MG," +
        "MH,MR,MRN,MS,MSS,MWB,NA,OH,OI,ON,OP,OR,PB,PC,PD,PE,PF,PI,PK,PL,POR,PP,PQ,PR,PS,P" +
        "W,PY,RA,RC,RCN,RE,REN,RF,RR,RT,SA,SB,SD,SE,SF,SH,SI,SM,SN,SP,SQ,SRN,SS,STA,SW,SZ" +
        ",TB,TE,TF,TI,TL,TN,TP,UAR,UC,UCN,UN,UO,VA,VC,VM,VN,VON,VP,VR,VS,VT,VV,WE,WM,WN,W" +
        "R,WS,WY,XA,XC,XP,ZZZ,")]
    public class EDIFACT_ID_1153
    {
    }
    
    /// <summary>
    /// Sequence number source, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_1159
    {
    }
    
    /// <summary>
    /// Message function, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,6,7,8,9,")]
    public class EDIFACT_ID_1225
    {
    }
    
    /// <summary>
    /// Calculation sequence indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_1227
    {
    }
    
    /// <summary>
    /// Action request/notification, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_1229
    {
    }
    
    /// <summary>
    /// Status indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_1245
    {
    }
    
    /// <summary>
    /// Document/message status, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_1373
    {
    }
    
    /// <summary>
    /// Computer environment details qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_1501
    {
    }
    
    /// <summary>
    /// Data format, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_1503
    {
    }
    
    /// <summary>
    /// Value list type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_1505
    {
    }
    
    /// <summary>
    /// Class designator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_1507
    {
    }
    
    /// <summary>
    /// Date/time/period qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",10,101,107,108,109,11,110,111,113,114,115,116,117,118,119,12,123,124,125,126,128,129,13,131,132,133,134,135,136,137,138,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154,155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21,210,211,212,213,214,215,216,217,218,219,22,221,222,223,224,225,226,227,228,229,230,231,232,233,234,235,236,237,238,239,240,241,242,243,244,245,246,247,248,249,250,251,252,253,254,255,256,257,258,259,260,261,262,263,264,265,266,267,268,270,271,272,273,274,275,276,277,278,279,280,281,282,283,284,285,286,287,288,290,291,292,293,294,295,296,297,298,299,3,300,301,302,303,304,305,306,307,308,309,310,311,312,313,314,315,316,317,318,319,320,321,322,323,324,325,326,327,328,329,330,331,332,333,334,335,336,337,338,339,340,341,342,343,344,345,346,347,348,349,35,350,351,352,353,354,355,356,357,358,359,36,360,361,362,363,364,365,366,367,368,369,37,370,371,372,373,374,375,376,377,378,379,38,380,381,382,383,384,387,388,389,39,390,391,392,393,394,395,396,397,398,399,4,400,401,402,403,404,405,406,407,408,409,410,411,412,413,414,415,416,417,42,44,45,46,47,48,49,50,51,52,53,54,55,58,59,60,61,63,64,65,67,69,7,71,72,74,75,76,79,8,81,84,85,89,9,90,91,92,93,94,95,96,97,ZZZ,")]
    public class EDIFACT_ID_2005
    {
    }
    
    /// <summary>
    /// Time relation, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_2009
    {
    }
    
    /// <summary>
    /// Frequency, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,J,M,Q,S,T,W,Y,ZZZ,")]
    public class EDIFACT_ID_2013
    {
    }
    
    /// <summary>
    /// Despatch pattern, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,6,7,ZZZ,")]
    public class EDIFACT_ID_2015
    {
    }
    
    /// <summary>
    /// Despatch pattern timing, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,Y,ZZZ,")]
    public class EDIFACT_ID_2017
    {
    }
    
    /// <summary>
    /// Type of period, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",3M,6M,AA,AD,CD,CW,D,DC,DW,F,H,HM,M,MN,P,S,SD,SI,W,WD,WW,Y,ZZZ,")]
    public class EDIFACT_ID_2151
    {
    }
    
    /// <summary>
    /// Date/time/period format qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",101,102,103,105,106,107,108,109,110,2,201,202,203,204,3,301,302,303,304,305,306,401,402,404,405,501,502,503,600,601,602,603,604,608,609,610,613,614,615,616,701,702,703,704,705,706,707,708,709,710,711,713,715,716,717,718,801,802,803,804,805,806,807,808,809,810,811,812,813,814,")]
    public class EDIFACT_ID_2379
    {
    }
    
    /// <summary>
    /// Payment time reference, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,11,12,13,14,2,21,22,23,24,25,26,27,28,29,3,31,32,33,4,41,42,43,44,45,46,47,48," +
        "5,52,53,54,55,56,57,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78" +
        ",79,8,80,81,9,ZZZ,")]
    public class EDIFACT_ID_2475
    {
    }
    
    /// <summary>
    /// Party qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BS,BT,BU,BV,BW,BX,BY,BZ,C1,C2,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,COP,CP,CPD,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,DA,DB,DC,DCP,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EO,EP,EQ,ER,ES,ET,EU,EV,EW,EX,EY,EZ,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FO,FP,FQ,FR,FS,FT,FU,FV,FW,FX,FY,FZ,GA,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,I1,I2,IB,IC,ID,IE,IF,IG,IH,II,IJ,IL,IM,IN,IO,IP,IQ,IR,IS,IT,IU,IV,IW,LA,LB,LN,LP,MA,MF,MG,MI,MP,MR,MS,MT,N1,N2,NI,OA,OB,OF,OI,OO,OP,OR,OS,OT,OV,OY,P1,P2,P3,P4,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PQ,PR,PS,PT,PW,PX,PY,PZ,RA,RB,RE,RF,RH,RI,RL,RM,RP,RS,RV,RW,SB,SE,SF,SG,SI,SK,SN,SO,SR,SS,ST,SU,SX,SY,SZ,TC,TCP,TD,TR,TS,TT,UC,UD,UHP,UP,VN,WD,WH,WM,WPA,WS,XX,ZZZ,")]
    public class EDIFACT_ID_3035
    {
    }
    
    /// <summary>
    /// Party name format, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_3045
    {
    }
    
    /// <summary>
    /// Code list responsible agency, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117,118,119,12,120,121,122,123,124,125,126,128,129,13,130,131,132,133,134,135,136,137,138,139,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154,155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,19,190,191,192,193,194,195,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,ZZZ,")]
    public class EDIFACT_ID_3055
    {
    }
    
    /// <summary>
    /// Test media, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,ZZZ,")]
    public class EDIFACT_ID_3077
    {
    }
    
    /// <summary>
    /// Organisation classification, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_3079
    {
    }
    
    /// <summary>
    /// Address type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_3131
    {
    }
    
    /// <summary>
    /// Contact function, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA,BB,BC,BD,BE,BF,BU,CA,CB,CC,CD,CE,CF,CG,CN,CO,CP,CR,CW,DE,DI,DL,EB,EC,ED,EX,GR,HE,HG,HM,IC,IN,LB,LO,MC,MD,MH,MR,MS,NT,OC,PA,PD,PE,PM,QA,QC,RD,SA,SC,SD,SR,SU,TA,TD,TI,TR,WH,ZZZ,")]
    public class EDIFACT_ID_3139
    {
    }
    
    /// <summary>
    /// Communication channel identifier, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,CA,EI,EM,EX,FT,FX,GM,IE,IM,MA,PB,PS,SW,TE,TG,TL,TM,TT,TX,XF,")]
    public class EDIFACT_ID_3153
    {
    }
    
    /// <summary>
    /// Communication channel qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,CA,EI,EM,EX,FT,FX,GM,IE,IM,MA,PB,PS,SW,TE,TG,TL,TM,TT,TX,XF" +
        ",")]
    public class EDIFACT_ID_3155
    {
    }
    
    /// <summary>
    /// Place/location qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117,118,119,12,120,121,122,123,124,125,126,127,128,129,13,130,131,132,133,134,135,136,137,138,139,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154,155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,18,19,2,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,60,61,62,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,ZZZ,")]
    public class EDIFACT_ID_3227
    {
    }
    
    /// <summary>
    /// Sample location, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_3237
    {
    }
    
    /// <summary>
    /// Geographic environment, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DO,DR,EA,IN,IR,")]
    public class EDIFACT_ID_3279
    {
    }
    
    /// <summary>
    /// Recipient of the instruction identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_3285
    {
    }
    
    /// <summary>
    /// Person characteristic qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_3289
    {
    }
    
    /// <summary>
    /// Name component original representation, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_3295
    {
    }
    
    /// <summary>
    /// Address purpose, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_3299
    {
    }
    
    /// <summary>
    /// Party enacting instruction identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_3301
    {
    }
    
    /// <summary>
    /// Name status, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,5,6,")]
    public class EDIFACT_ID_3397
    {
    }
    
    /// <summary>
    /// Name component status, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_3401
    {
    }
    
    /// <summary>
    /// Name type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,7,8,")]
    public class EDIFACT_ID_3403
    {
    }
    
    /// <summary>
    /// Name component qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,2,3,5,6,7,8,9,")]
    public class EDIFACT_ID_3405
    {
    }
    
    /// <summary>
    /// Language qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_3455
    {
    }
    
    /// <summary>
    /// Address status, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,4,5,")]
    public class EDIFACT_ID_3475
    {
    }
    
    /// <summary>
    /// Address format, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_3477
    {
    }
    
    /// <summary>
    /// Marital status, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_3479
    {
    }
    
    /// <summary>
    /// Nationality qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_3493
    {
    }
    
    /// <summary>
    /// Delivery plan status indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,3,4,5,9,")]
    public class EDIFACT_ID_4017
    {
    }
    
    /// <summary>
    /// Business function, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ADV,AGT,AMY,BEC,BEN,BON,CAS,CBF,CDT,COC,COM,COS,CPY,DIV,FEX,GDS,GVT,IHP,INS,INT," +
        "LIF,LOA,LOR,NET,PEN,REF,REN,ROY,SAL,SCV,SEC,SSB,SUB,TAX,VAT,ZZZ,")]
    public class EDIFACT_ID_4025
    {
    }
    
    /// <summary>
    /// Business function qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_4027
    {
    }
    
    /// <summary>
    /// Priority qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_4035
    {
    }
    
    /// <summary>
    /// Class of trade, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AG,BG,BR,CN,DE,DI,JB,MF,OE,RS,RT,ST,WH,WS,")]
    public class EDIFACT_ID_4043
    {
    }
    
    /// <summary>
    /// Characteristic relevance, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_4051
    {
    }
    
    /// <summary>
    /// Terms of delivery or transport function, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_4055
    {
    }
    
    /// <summary>
    /// Contract and carriage condition, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4065
    {
    }
    
    /// <summary>
    /// Special conditions, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117,118,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,")]
    public class EDIFACT_ID_4183
    {
    }
    
    /// <summary>
    /// Transport charges method of payment, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,CA,CC,CF,DF,FO,IC,MX,NC,NS,PA,PB,PC,PE,PO,PP,PU,RC,RF,RS,TP,WC,ZZZ,")]
    public class EDIFACT_ID_4215
    {
    }
    
    /// <summary>
    /// Transport priority, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_4219
    {
    }
    
    /// <summary>
    /// Discrepancy, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AN,AS,BK,BP,CA,CC,CE,CI,CK,CM,CN,CO,CP,CS,IC,IS,LS,NF,NN,NS" +
        ",OF,OM,OP,OS,OW,PA,PD,PI,PK,PN,PO,PP,PS,RA,SL,SP,SS,TW,UR,ZZZ,")]
    public class EDIFACT_ID_4221
    {
    }
    
    /// <summary>
    /// Marking instructions, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,4,5,6,7,8,9" +
        ",ZZZ,")]
    public class EDIFACT_ID_4233
    {
    }
    
    /// <summary>
    /// Prepaid/collect indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,P,")]
    public class EDIFACT_ID_4237
    {
    }
    
    /// <summary>
    /// Terms of payment identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_4277
    {
    }
    
    /// <summary>
    /// Payment terms type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35" +
        ",4,5,6,7,8,9,ZZZ,")]
    public class EDIFACT_ID_4279
    {
    }
    
    /// <summary>
    /// Change reason, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,BD,BQ,DC" +
        ",EV,GU,GW,LD,MC,PC,PD,PQ,PS,PW,PZ,QO,QP,QT,SC,UM,UP,WD,WO,ZZZ,")]
    public class EDIFACT_ID_4295
    {
    }
    
    /// <summary>
    /// Response type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AF,AG,AI,AJ,AP,CA,CO,NA,RE,")]
    public class EDIFACT_ID_4343
    {
    }
    
    /// <summary>
    /// Product id. function qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4347
    {
    }
    
    /// <summary>
    /// Bank operation, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ABX,BEX,BGI,BKD,BKI,CAL,CHG,CHI,CHN,CLR,COL,COM,CON,CPP,CUX,DDT,DEP,FEX,FGI,INT," +
        "LOC,LOK,MSC,PAC,PGI,POS,REC,RET,RGI,RTR,SEC,STO,TCK,TRF,UGI,VDA,WDL,ZZZ,")]
    public class EDIFACT_ID_4383
    {
    }
    
    /// <summary>
    /// Instruction, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AP,AT,CO,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DN" +
        ",DO,DP,EI,EM,EX,QC,QE,RL,SW,")]
    public class EDIFACT_ID_4401
    {
    }
    
    /// <summary>
    /// Instruction qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4403
    {
    }
    
    /// <summary>
    /// Status, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4405
    {
    }
    
    /// <summary>
    /// Sample process status, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_4407
    {
    }
    
    /// <summary>
    /// Test route of administering, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,ZZZ,")]
    public class EDIFACT_ID_4419
    {
    }
    
    /// <summary>
    /// Payment guarantee, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,20,21,23,24,41,44,45,ZZZ,")]
    public class EDIFACT_ID_4431
    {
    }
    
    /// <summary>
    /// Payment channel, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,2,3,4,5,6,7,8,9,ZZZ,")]
    public class EDIFACT_ID_4435
    {
    }
    
    /// <summary>
    /// Payment conditions, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,5,6,61,62,63,64,69,7,70,71,8,9,ZZZ,")]
    public class EDIFACT_ID_4439
    {
    }
    
    /// <summary>
    /// Text subject qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,ABY,ABZ,ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,ADA,ADB,ADC,ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,ADU,ADV,ADW,ADX,ADY,ADZ,AEA,AEB,AEC,AED,AEE,ALC,ALL,ARR,AUT,BLC,BLR,CCI,CEX,CHG,CIP,CLP,CLR,COI,CUR,CUS,DAR,DCL,DEL,DIN,DOC,DUT,EUR,FBC,GBL,GEN,GS7,HAN,HAZ,ICN,IIN,IMI,IND,INS,INV,IRP,ITR,ITS,LIN,LOI,MCO,MKS,ORI,OSI,PAC,PAI,PAY,PKG,PKT,PMD,PMT,PRD,PRF,PRI,PUR,QIN,QQD,QUT,RAH,REG,RET,REV,RQR,RQT,SAF,SIC,SIN,SLR,SPA,SPG,SPH,SPP,SPT,SRN,SSR,SUR,TCA,TDT,TRA,TRR,TXD,WHI,ZZZ,")]
    public class EDIFACT_ID_4451
    {
    }
    
    /// <summary>
    /// Text function, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_4453
    {
    }
    
    /// <summary>
    /// Back order, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,F,N,W,Y,ZZZ,")]
    public class EDIFACT_ID_4455
    {
    }
    
    /// <summary>
    /// Product/service substitution, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,ZZZ,")]
    public class EDIFACT_ID_4457
    {
    }
    
    /// <summary>
    /// Payment means, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,25,26,27,28,29,3,30,31,32,33,34,35" +
        ",36,37,38,39,4,40,41,42,43,5,50,6,60,61,62,63,64,65,66,67,7,70,74,75,76,77,78,8," +
        "9,91,92,93,94,95,96,97,ZZZ,")]
    public class EDIFACT_ID_4461
    {
    }
    
    /// <summary>
    /// Intra-company payment, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_4463
    {
    }
    
    /// <summary>
    /// Adjustment reason, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59," +
        "6,60,61,62,63,64,65,7,8,9,ZZZ,")]
    public class EDIFACT_ID_4465
    {
    }
    
    /// <summary>
    /// Settlement, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,3,4,5,6,7,8,9,ZZZ,")]
    public class EDIFACT_ID_4471
    {
    }
    
    /// <summary>
    /// Type of financial transaction, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,4,5,6,7,8,")]
    public class EDIFACT_ID_4487
    {
    }
    
    /// <summary>
    /// Delivery requirements, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,BK,CD,DA,DB,DD,IS,P1,P2,SC,SF,SP,")]
    public class EDIFACT_ID_4493
    {
    }
    
    /// <summary>
    /// Reason for inventory movement, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4499
    {
    }
    
    /// <summary>
    /// Inventory movement direction, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_4501
    {
    }
    
    /// <summary>
    /// Inventory balance method, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_4503
    {
    }
    
    /// <summary>
    /// Credit cover request, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_4505
    {
    }
    
    /// <summary>
    /// Credit cover response, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4507
    {
    }
    
    /// <summary>
    /// Credit cover reason, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4509
    {
    }
    
    /// <summary>
    /// Requested information, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4511
    {
    }
    
    /// <summary>
    /// Maintenance operation, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_4513
    {
    }
    
    /// <summary>
    /// Seal condition, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_4517
    {
    }
    
    /// <summary>
    /// Monetary function, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,4,5,7,8,9,")]
    public class EDIFACT_ID_5007
    {
    }
    
    /// <summary>
    /// Index qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5013
    {
    }
    
    /// <summary>
    /// Monetary amount type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117,118,119,12,120,121,122,123,124,125,126,127,128,129,13,130,131,132,133,134,135,136,138,139,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154,155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,19,190,192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21,210,211,212,213,214,215,216,217,218,219,22,220,221,222,223,224,225,226,227,228,229,23,230,231,232,233,234,235,236,237,238,239,24,240,241,242,243,244,245,246,247,248,249,25,250,251,252,253,254,255,256,257,258,259,26,260,261,262,263,264,265,266,267,268,269,27,270,271,272,273,274,275,276,277,278,279,28,280,281,282,283,284,285,286,287,288,289,29,290,291,292,293,294,295,296,297,298,299,3,30,300,301,302,303,304,305,306,307,308,309,31,310,311,312,313,314,315,316,317,318,319,32,320,321,322,323,324,325,326,327,328,329,33,330,331,332,333,334,335,336,338,339,34,340,341,342,343,344,345,346,347,348,349,35,350,351,352,353,354,355,356,357,358,359,36,360,361,362,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,ZZZ,")]
    public class EDIFACT_ID_5025
    {
    }
    
    /// <summary>
    /// Index type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_5027
    {
    }
    
    /// <summary>
    /// Index value representation, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_5039
    {
    }
    
    /// <summary>
    /// Contribution qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,ZZZ,")]
    public class EDIFACT_ID_5047
    {
    }
    
    /// <summary>
    /// Contribution type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,ZZZ,")]
    public class EDIFACT_ID_5049
    {
    }
    
    /// <summary>
    /// Price qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAA,AAB,AAC,AAD,AAE,AAF,AAG,CAL,INF,INV,")]
    public class EDIFACT_ID_5125
    {
    }
    
    /// <summary>
    /// Duty/tax/fee type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAA,AAB,AAC,AAD,ADD,BOL,CAP,CAR,COC,CST,CUD,CVD,ENV,EXC,EXP,FET,FRE,GCN,GST,ILL," +
        "IMP,IND,LAC,LCN,LDP,LOC,LST,MCA,MCD,OTH,PDB,PDC,PRF,SCN,SSS,STT,SUP,SUR,SWT,TAC," +
        "TOT,TOX,TTA,VAD,VAT,")]
    public class EDIFACT_ID_5153
    {
    }
    
    /// <summary>
    /// Charge/allowance description, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,6,7,8,9,")]
    public class EDIFACT_ID_5189
    {
    }
    
    /// <summary>
    /// Sub-line price change, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,I,S,")]
    public class EDIFACT_ID_5213
    {
    }
    
    /// <summary>
    /// Charge category, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_5237
    {
    }
    
    /// <summary>
    /// Rate/tariff class identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,K,M,N,Q,R,S,")]
    public class EDIFACT_ID_5243
    {
    }
    
    /// <summary>
    /// Percentage qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,5,6,7,8,9,")]
    public class EDIFACT_ID_5245
    {
    }
    
    /// <summary>
    /// Percentage basis, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_5249
    {
    }
    
    /// <summary>
    /// Duty/tax/fee rate basis identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5273
    {
    }
    
    /// <summary>
    /// Duty/tax/fee function qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,9,")]
    public class EDIFACT_ID_5283
    {
    }
    
    /// <summary>
    /// Duty/tax/fee category, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AA,AB,AC,AD,B,C,E,G,H,O,S,Z,")]
    public class EDIFACT_ID_5305
    {
    }
    
    /// <summary>
    /// Remuneration type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5315
    {
    }
    
    /// <summary>
    /// Price type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AI,AQ,CA,CT,CU,DI,EC,NW,PC,PE,PK,PL,PT,PU,PV,PW,QT,SR,TB,TU,TW,WH" +
        ",")]
    public class EDIFACT_ID_5375
    {
    }
    
    /// <summary>
    /// Product group type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_5379
    {
    }
    
    /// <summary>
    /// Price type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,AI,ALT,AP,BR,CAT,CDV,CON,CP,CU,CUP,CUS,DAP,DIS,DPR,DR,DSC,EC,ES,EUP,FCR,GRP,INV,LBL,MAX,MIN,MNR,MSR,MXR,NE,NQT,NTP,NW,OCR,OFR,PAQ,PBQ,PPD,PPR,PRO,PRP,PW,QTE,RES,RTP,SHD,SRP,SW,TB,TRF,TU,TW,WH,")]
    public class EDIFACT_ID_5387
    {
    }
    
    /// <summary>
    /// Price multiplier qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,CSD,CSR,DIS,SEL,")]
    public class EDIFACT_ID_5393
    {
    }
    
    /// <summary>
    /// Rate type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5419
    {
    }
    
    /// <summary>
    /// Allowance or charge qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,")]
    public class EDIFACT_ID_5463
    {
    }
    
    /// <summary>
    /// Sub-line indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_5495
    {
    }
    
    /// <summary>
    /// Quantity qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117,118,119,12,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21,210,211,212,213,214,215,216,217,218,219,22,23,24,25,26,27,28,29,3,30,31,32,33,35,36,40,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,")]
    public class EDIFACT_ID_6063
    {
    }
    
    /// <summary>
    /// Control qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,4,5,6,7,8,9,")]
    public class EDIFACT_ID_6069
    {
    }
    
    /// <summary>
    /// Frequency qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_6071
    {
    }
    
    /// <summary>
    /// Result type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_6077
    {
    }
    
    /// <summary>
    /// Result normalcy indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_6079
    {
    }
    
    /// <summary>
    /// Dosage administration qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_6085
    {
    }
    
    /// <summary>
    /// Result qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_6087
    {
    }
    
    /// <summary>
    /// Dimension qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_6145
    {
    }
    
    /// <summary>
    /// Measurement attribute identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,18,19,2,20,21,22,23,24,25,26,27,28,29,3,32,33,34,35,36,37" +
        ",38,39,4,40,41,42,43,44,45,5,6,7,8,9,")]
    public class EDIFACT_ID_6155
    {
    }
    
    /// <summary>
    /// Range type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_6167
    {
    }
    
    /// <summary>
    /// Size qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_6173
    {
    }
    
    /// <summary>
    /// Temperature qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_6245
    {
    }
    
    /// <summary>
    /// Measurement purpose qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ABP,ASW,CH,CHW,CN,CS,CT,DEN,DR,DT,DV,DX,EGW,EN,EVO,FO,IV,LAO,LC,LGL,LL,LMT,NAX,PAL,PC,PD,PL,PLL,RL,RN,SE,SH,SM,SO,SPG,SR,ST,SU,SV,TE,TL,TR,TX,VO,VOL,VT,WT,WX,")]
    public class EDIFACT_ID_6311
    {
    }
    
    /// <summary>
    /// Property measured, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ABO,ABQ,ABR,ABS,ABU,ABV,ABW,ABX,ABY,ABZ,ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,ADU,ADV,ADW,ADX,ADY,ADZ,AEA,AEB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEJ,AEK,AEM,AF,B,BL,BND,BR,BRA,BRE,BS,BSW,BW,CHN,CM,CT,CV,CZ,D,DI,DL,DN,DP,DR,DS,DW,E,EA,F,FI,FL,FN,FV,G,GG,GW,HF,HM,HT,IB,ID,L,LM,LN,LND,M,MO,MW,N,OD,PRS,PTN,RA,RF,RJ,RMW,RP,RUN,RY,SQ,T,TC,TH,TN,TT,U,VH,VW,WA,WD,WM,WT,WU,XH,XQ,XZ,YS,ZAL,ZAS,ZB,ZBI,ZC,ZCA,ZCB,ZCE,ZCL,ZCO,ZCR,ZCU,ZFE,ZFS,ZGE,ZH,ZK,ZMG,ZMN,ZMO,ZN,ZNA,ZNB,ZNI,ZO,ZP,ZPB,ZS,ZSB,ZSE,ZSI,ZSL,ZSN,ZTA,ZTE,ZTI,ZV,ZW,ZWA,ZZN,ZZR,ZZZ,")]
    public class EDIFACT_ID_6313
    {
    }
    
    /// <summary>
    /// Measurement significance, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,11,12,13,15,3,4,5,6,7,8,")]
    public class EDIFACT_ID_6321
    {
    }
    
    /// <summary>
    /// Statistic type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_6331
    {
    }
    
    /// <summary>
    /// Currency market exchange, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAA,AMS,ARG,AST,AUS,BEL,CAN,CAR,CIE,DEN,ECR,FIN,FRA,IMF,LNF,LNS,MIL,NOR,NYC,PHI," +
        "SRE,SWE,ZUR,")]
    public class EDIFACT_ID_6341
    {
    }
    
    /// <summary>
    /// Currency qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_6343
    {
    }
    
    /// <summary>
    /// Currency details qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_6347
    {
    }
    
    /// <summary>
    /// Number of units qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_6353
    {
    }
    
    /// <summary>
    /// Clinical information qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_6415
    {
    }
    
    /// <summary>
    /// Physical or logical state qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7001
    {
    }
    
    /// <summary>
    /// Physical or logical state, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_7007
    {
    }
    
    /// <summary>
    /// Sample selection method, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7039
    {
    }
    
    /// <summary>
    /// Sample description, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_7045
    {
    }
    
    /// <summary>
    /// Sample direction, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_7047
    {
    }
    
    /// <summary>
    /// Property class, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_7059
    {
    }
    
    /// <summary>
    /// Packaging terms and conditions, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7073
    {
    }
    
    /// <summary>
    /// Packaging level, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_7075
    {
    }
    
    /// <summary>
    /// Item description type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,S,X,")]
    public class EDIFACT_ID_7077
    {
    }
    
    /// <summary>
    /// Item characteristic, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117,118,119,12,120,121,122,123,124,125,126,127,128,129,13,130,131,132,133,134,135,136,137,138,139,14,140,141,142,143,144,145,146,147,149,15,150,151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,19,2,21,22,23,24,25,26,28,3,30,32,35,38,4,43,5,54,56,58,59,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,")]
    public class EDIFACT_ID_7081
    {
    }
    
    /// <summary>
    /// Configuration, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,I,")]
    public class EDIFACT_ID_7083
    {
    }
    
    /// <summary>
    /// Nature of cargo, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7085
    {
    }
    
    /// <summary>
    /// Item number type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AT,AU,AV,AW,AX,AY,AZ,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BO,BP,CC,CG,CL,CR,CV,DR,DW,EC,EF,EN,GB,GN,GS,HS,IB,IN,IS,IT,IZ,MA,MF,MN,MP,NB,ON,PD,PL,PO,PV,QS,RC,RN,RU,RY,SA,SG,SK,SN,SRS,SS,ST,TG,UA,UP,VN,VP,VS,VX,ZZZ,")]
    public class EDIFACT_ID_7143
    {
    }
    
    /// <summary>
    /// Special services, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,ABY,ABZ,ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,ADU,ADV,ADX,ADY,AEA,AEB,AEC,AED,AEF,AEG,AEH,AG,AJ,AL,AM,AU,CA,CAA,CAB,CAC,CAD,CAE,CAF,CAG,CAH,CAI,CAJ,CAK,CB,CD,CG,CK,CL,CO,CP,CS,CT,CW,DA,DAA,DAB,DAD,DAE,DI,DL,DM,EAA,EAB,EG,EP,ER,EX,FA,FAA,FAB,FAC,FC,FG,FH,FI,FN,FR,GAA,HAA,HD,HH,IA,IAA,IAB,ID,IF,IN,IR,IS,KO,L1,LA,LAA,LAB,LAC,LF,LS,MA,MAA,MAB,MAC,MAD,MAE,MC,MI,ML,NAA,OA,OAA,PA,PAA,PAB,PAC,PAD,PAE,PC,PD,PI,PL,PN,PO,QAA,QD,RAA,RAB,RAC,RAD,RAE,RAF,RAG,RAH,RE,RF,RH,RO,RP,RV,SA,SAA,SAB,SAC,SAD,SAE,SAF,SAG,SAH,SAI,SAJ,SC,SD,SF,SG,SH,SM,ST,SU,SZ,TAA,TAB,TAC,TAD,TAE,TD,TS,TT,TV,TX,TZ,UM,V1,V2,VAA,VAB,VL,WH,XAA,YY,ZZZ,")]
    public class EDIFACT_ID_7161
    {
    }
    
    /// <summary>
    /// Hierarchical level, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7171
    {
    }
    
    /// <summary>
    /// Hierarchy object qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_7173
    {
    }
    
    /// <summary>
    /// Process type identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7187
    {
    }
    
    /// <summary>
    /// Packaging related information, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",34,35,36,37,38,39,40,41,42,43,44,45,50,51,52,53,54,55,56,57,58,59,60,61,62,63,66" +
        ",67,68,69,70,71,72,73,74,75,76,77,")]
    public class EDIFACT_ID_7233
    {
    }
    
    /// <summary>
    /// Service requirement, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,5,6,7,8,9,")]
    public class EDIFACT_ID_7273
    {
    }
    
    /// <summary>
    /// Sector/subject identification qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7293
    {
    }
    
    /// <summary>
    /// Set identification qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7297
    {
    }
    
    /// <summary>
    /// Requirement designator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_7299
    {
    }
    
    /// <summary>
    /// Processing indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59," +
        "6,60,61,62,63,64,65,66,67,7,8,9,ZZZ,")]
    public class EDIFACT_ID_7365
    {
    }
    
    /// <summary>
    /// Surface/layer indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1S,2S,AA,AB,AC,AD,AE,BC,BS,BT,DF,FR,IN,LE,OA,OS,OT,RI,RR,ST,TB,TP,TS,UC,")]
    public class EDIFACT_ID_7383
    {
    }
    
    /// <summary>
    /// Identity number qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA" +
        ",BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BX,CN,EE,EM,IL,ML,PN,S" +
        "C,VV,")]
    public class EDIFACT_ID_7405
    {
    }
    
    /// <summary>
    /// Indexing structure qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7429
    {
    }
    
    /// <summary>
    /// Agreement type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7431
    {
    }
    
    /// <summary>
    /// Agreement type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_7433
    {
    }
    
    /// <summary>
    /// Membership qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,ZZZ,")]
    public class EDIFACT_ID_7449
    {
    }
    
    /// <summary>
    /// Membership category identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_7451
    {
    }
    
    /// <summary>
    /// Membership level qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_7455
    {
    }
    
    /// <summary>
    /// Type of inventory affected, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_7491
    {
    }
    
    /// <summary>
    /// Damage details qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_7493
    {
    }
    
    /// <summary>
    /// Identification qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7495
    {
    }
    
    /// <summary>
    /// Component function qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_7497
    {
    }
    
    /// <summary>
    /// Transport stage qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,2,20,21,22,23,24,25,26,27,28,30,")]
    public class EDIFACT_ID_8051
    {
    }
    
    /// <summary>
    /// Equipment qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AD,AE,AG,AH,AI,BL,BPN,BPY,BR,BX,CH,CN,DPA,EFP,EYP,FPN,FPR,FSU,LAR,LU,MPA,P" +
        "A,PBP,PFP,PL,PPA,PST,RF,RG,RGF,RO,RR,SCA,SCB,SCC,SFA,SPP,STR,SW,TE,TP,TS,TSU,UL," +
        "")]
    public class EDIFACT_ID_8053
    {
    }
    
    /// <summary>
    /// Equipment supplier, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_8077
    {
    }
    
    /// <summary>
    /// Transit direction, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BS,SB,SC,SD,SF,SS,ZZZ,")]
    public class EDIFACT_ID_8101
    {
    }
    
    /// <summary>
    /// Equipment size and type identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,5,6,7,8,9,")]
    public class EDIFACT_ID_8155
    {
    }
    
    /// <summary>
    /// Full/empty indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_8169
    {
    }
    
    /// <summary>
    /// Type of means of transport identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,2,21,22,23,24,25,3,31,32,33,35,36,37,38,4,5,6,7,8,9" +
        ",")]
    public class EDIFACT_ID_8179
    {
    }
    
    /// <summary>
    /// Equipment status, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_8249
    {
    }
    
    /// <summary>
    /// Dangerous goods regulations, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ADR,AGS,ANR,ARD,CFR,COM,GVE,GVS,ICA,IMD,RGE,RID,TEC,UI,ZZZ,")]
    public class EDIFACT_ID_8273
    {
    }
    
    /// <summary>
    /// Container/package status, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_8275
    {
    }
    
    /// <summary>
    /// Transport ownership, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_8281
    {
    }
    
    /// <summary>
    /// Transport movement, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_8323
    {
    }
    
    /// <summary>
    /// Category of means of transport, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_8325
    {
    }
    
    /// <summary>
    /// Movement type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,11,12,13,2,21,22,23,3,31,32,33,4,41,42,43,44,5,")]
    public class EDIFACT_ID_8335
    {
    }
    
    /// <summary>
    /// Packing group, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_8339
    {
    }
    
    /// <summary>
    /// Haulage arrangements, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_8341
    {
    }
    
    /// <summary>
    /// Returnable package load contents, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_8393
    {
    }
    
    /// <summary>
    /// Returnable package freight payment responsibility, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,ZZZ,")]
    public class EDIFACT_ID_8395
    {
    }
    
    /// <summary>
    /// Excess transportation reason, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,P,R,T,U,V,W,X,Y,ZZZ,")]
    public class EDIFACT_ID_8457
    {
    }
    
    /// <summary>
    /// Excess transportation responsibility, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,S,X,ZZZ,")]
    public class EDIFACT_ID_8459
    {
    }
    
    /// <summary>
    /// Employment qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_9003
    {
    }
    
    /// <summary>
    /// Status event, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,102,103,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,")]
    public class EDIFACT_ID_9011
    {
    }
    
    /// <summary>
    /// Status reason, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59," +
        "6,60,61,62,63,64,65,7,8,9,")]
    public class EDIFACT_ID_9013
    {
    }
    
    /// <summary>
    /// Status type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_9015
    {
    }
    
    /// <summary>
    /// Attribute function qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,ZZZ,")]
    public class EDIFACT_ID_9017
    {
    }
    
    /// <summary>
    /// Qualification area, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_9035
    {
    }
    
    /// <summary>
    /// Qualification qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_9037
    {
    }
    
    /// <summary>
    /// Relationship qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_9141
    {
    }
    
    /// <summary>
    /// Simple data element character representation, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_9153
    {
    }
    
    /// <summary>
    /// Simple data element length type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_9155
    {
    }
    
    /// <summary>
    /// Code set indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_9161
    {
    }
    
    /// <summary>
    /// Type of duty regime, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,8,9,")]
    public class EDIFACT_ID_9213
    {
    }
    
    /// <summary>
    /// Sealing party, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,CA,CU,SH,TO,")]
    public class EDIFACT_ID_9303
    {
    }
    
    /// <summary>
    /// Government procedure, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_9353
    {
    }
    
    /// <summary>
    /// Government involvement, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_9411
    {
    }
    
    /// <summary>
    /// Government agency, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_9415
    {
    }
    
    /// <summary>
    /// Government action, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_9417
    {
    }
    
    /// <summary>
    /// Stages qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_9421
    {
    }
    
    /// <summary>
    /// Clinical intervention qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_9441
    {
    }
    
    [Serializable()]
    [DataContract()]
    public class EDIFACT_N
    {
    }
}
