﻿using System;
using EdiFabric.Core.Model.Edi.Edifact;

namespace Parser2
{
    public class EDIFactSegmentBuilders
    {
        /// <summary>
        /// Build UNB.
        /// </summary>
        public static UNB BuildUnb(string controlNumber)
        {
            return new UNB
            {
                SYNTAXIDENTIFIER_1 = new S001
                {
                    //  Syntax Identifier
                    SyntaxIdentifier_1 = "UNOC",
                    //  Syntax Version Number
                    SyntaxVersionNumber_2 = "3"
                },
                INTERCHANGESENDER_2 = new S002
                {
                    //  Interchange sender identification
                    InterchangeSenderIdentification_1 = "RECONGROUP",
                    //  Identification code qualifier
                    IdentificationCodeQualifier_2 = "ZZ",
                    //  Interchange sender internal identification
                    InterchangeSenderInternalIdentification_3 = "ZZZ"
                },
                INTERCHANGERECIPIENT_3 = new S003
                {
                    //  Interchange recipient identification
                    InterchangeRecipientIdentification_1 = "662424795TEST",
                    //  Identification code qualifier
                    IdentificationCodeQualifier_2 = "16",
                    //  Interchange recipient internal identification
                    InterchangeRecipientInternalIdentification_3 = "ZZZ"
                },
                DATEANDTIMEOFPREPARATION_4 = new S004
                {
                    //  Date
                    Date_1 = DateTime.Now.Date.ToString("yyMMdd"),
                    //  Time
                    Time_2 = DateTime.Now.TimeOfDay.ToString("hhmm")
                },
                //  Interchange control reference
                InterchangeControlReference_5 = controlNumber
            };
        }

        /// <summary>
        /// Build UNG.
        /// </summary>
        public static UNG BuildUng(string controlNumber, string transactionType)
        {
            return new UNG
            {
                //  The type of messages in the group, INVOIC, etc.
                MessageGroupIdentification_1 = transactionType,
                APPLICATIONSENDERIDENTIFICATION_2 = new S006
                {
                    //  Sender identification
                    ApplicationSenderIdentification_1 = "RECONGROUP",
                    IdentificationCodeQualifier_2 = "ZZZ"
                },
                APPLICATIONRECIPIENTIDENTIFICATION_3 = new S007
                {
                    //  Recipient identification
                    ApplicationRecipientIdentification_1 = "662424795TEST",
                    IdentificationCodeQualifier_2 = "ZZZ"
                },
                DATEANDTIMEOFPREPARATION_4 = new S004
                {
                    //  Date
                    Date_1 = DateTime.Now.Date.ToString("yyMMdd"),
                    //  Time
                    Time_2 = DateTime.Now.TimeOfDay.ToString("hhmm")
                },
                //  Group control reference
                GroupReferenceNumber_5 = controlNumber,
                //  Controlling agency
                ControllingAgency_6 = "UN"
            };
        }

    }
}