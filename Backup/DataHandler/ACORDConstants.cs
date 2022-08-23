using System;
using System.Collections;

namespace IntegrationCommonLib
{
    public struct OLI_CARRIERFORM
    {
        public const uint UNKNOW = 0;
        public const uint DIRECT = 1;
        public const uint REINSURER = 2;
    }
    public enum MAJOR_LINE { UNDEFINED, LIFE, ANNUITY, DIH }

    public struct OLI_NATION
    {
        public const uint USA = 1;
    }
    public struct OLI_DTHBENETYPE
    {
        public const uint LEVEL = 1;
        public const uint INCR = 2;
        public const uint LIFECOMM_INCR = 1013300001;
        public const uint RETPREM = 3;
        public const uint SIMPPCT = 4;
        public const uint COMPPCT = 5;
    }

    public struct OLI_RATING
    {
        public const uint OLI_UNKNOWN = 0;
        public const uint OLI_OTHER = 2147483647;
    }
    public struct COMMON
    {
        // Common Lookup Codes
        public const uint OLI_UNKNOWN = 0;
        public const uint OLI_OTHER = 2147483647;
    }
    public struct OLI_GRPTYPE
    {
        public const uint LIST_BILL = 1013300001;
    }
    public struct OLI_BOOL
    {
        // Boolean Values
        public const String FALSE = "0";
        public const String TRUE = "1";
    }

    // ***********************************
    // * ACORD Message/Transaction Codes *
    // ***********************************

    // Result Codes
    public struct RESULT
    {
        public const uint SUCCESS = 1;
        public const uint SUCCESSINFO = 2;
        public const uint RECDPEND = 3;
        public const uint RECDPENDINFO = 4;
        public const uint FAILURE = 5;
    }
    // Message Severity Codes
    public struct OLI_MSGSEVERITY
    {
        public const uint INFO = 1;
        public const uint SEVERE = 2;
        public const uint WARNING = 3;
        public const uint OVERIDABLE = 4;
        public const uint OVERRIDDEN = 5;
    }
    // Result Info Codes (not comprehensive)
    public struct RESULTINFO
    {
        public const uint GENERAL = 100;
        public const uint STATUS_INFO = 101;
        public const uint DATA = 200;
        public const uint XMLPARSE = 201;
        public const uint DBCONSTRAINT = 202;
        public const uint INVALIDTRANSCONTEXT = 203;
        public const uint NOTAVAILSYS = 300;
        public const uint NOTAVAILFUNCTION = 400;
        public const uint UNSUPPORTED = 500;
        public const uint UNABLEATTHISTIME = 600;
        public const uint SUPPORTED_TRANS = 601;
        public const uint MAXERRSEXCEED = 700;
        public const uint MAXRECSEXCEED = 710;
        public const uint TABLEREADERROR = 720;
        public const uint INSSUFFICIENTINFO = 730;
        public const uint UNKNOWN = 999;
        public const uint INVALIDUSER = 1420;
        public const uint SECURITYVIOLATION = 1700;
        public const uint INVALIDPSWD = 1740;
        public const uint OBJECTNOTFOUND = 2001;
        public const uint DUPLICATEOBJECT = 2002;
        public const uint ELEMENTMISSING = 2003;
        public const uint ELEMENTINVALID = 2004;
        public const uint ELEMENTBELOWRANGE = 2005;
        public const uint ELEMENTABOVERANGE = 2006;
        public const uint NOTALLOWED = 2007;
    }

    // ***********************
    // * ACORD Lookup Tables *
    // ***********************

    // Accounting Activity Types (Financial Activity)
    public struct OLI_FINACTTYPE
    {
        public const uint INIT = 1; 			// Initial
        public const uint REV = 2;				// Reversal
        public const uint REFUND = 3;
        public const uint TRANSFER = 4;
        public const uint MONTHLY_GIR_CRDT = 1013300102;
        public const uint MONTHLY_INT_CRD = 1013300101;
        public const uint MONTHLY_FUND_VALUE = 349;
        public const uint MONTHLY_DEDUCTIONS = 321;
        public const uint MONTHLY_EXPENSES = 1013300022;
        public const uint MONTHLY_NAR = 1013300033;
        public const uint MONTHLY_COI = 1013300005;
        public const uint DEPOSIT = 1;
        public const uint WITHDRAW = 294;
    }


    // Accounting LU Activity Types (Financial Activity)
    public struct OLI_MAV_FINACTTYPE
    {
        public const uint MONTHLY_CASH_VALUE = 1013300005;
        public const uint MONTHLY_GIR_CRDT = 1013300102;
        public const uint MONTHLY_INT_CRD = 1013300101;
        public const uint MONTHLY_AMT_RISK = 1013300033;
        public const uint MONTHLY_COI = 1013300005;
        public const uint MONTHLY_EXPENSES = 1013300022;
    }


    // Address Type
    public struct OLI_ADTYPE
    {
        public const uint HOME = 1;
        public const uint BUS = 2;
        public const uint BUSINESS = 2; 		// Not ACORD but better
        public const uint VAC = 3;
        public const uint VACATION = 3; 		// Not ACORD
        public const uint REGOFFICE = 9;
        public const uint TEMP = 11;
        public const uint PREVIOUS = 12;
        public const uint APPTPURPOSE = 13;
        public const uint BILLINGRETTO = 14;	// Billing return to (Don't ask me!)
        public const uint INDVWORKLOC = 15;
        public const uint BUSSHIPPING = 16;
        public const uint MAILING = 17;
        public const uint CLAIMCENTER = 18;
        public const uint OVERNIGHT = 19;
        public const uint POLMAIL = 20;
        public const uint COMM = 21;
        public const uint COMMISSIONMAIL = 21;	// Not ACORD
        public const uint AGENTCSA = 24;
        public const uint CLIENTCSA = 25;
        public const uint BILLMAIL = 26;
        public const uint BILLING = 26; 		// Not ACORD
        public const uint HDQRTRS = 27;
    }

    // Arrangement Types (not exhaustive)
    public struct OLI_ARRTYPE
    {
        public const uint OSA = 19;
        public const uint AUTOPAY = 22; 			// Automatic Payments (PAC, EFC, etc.)
        public const uint AIP = 23; 				// Automatic Investment Program
        public const uint SDCA = 24;				// Special Dollar Cost Averaging
        public const uint RECURRINGCONTRIB = 34;
        public const uint LUMPSUM = 35;
        public const uint STANDINGALLOC = 37;
        public const uint SUBSQNTPREMS = 39;		// Subsequent Premiums
        public const uint PAYROLLDEDUCT = 54;		// Payroll Deduction
    }
    // Basic Attachment Types
    public struct OLI_BASICATTACHMENTTYPE
    {
        public const uint TEXT = 1;
        public const uint IMAGE = 2;
        public const uint FILE = 3;
    }

    // Attachment Types (not exhaustive)
    public struct OLI_ATTACH
    {
        public const uint DOC = 1;
        public const uint COMMENT = 2;
        public const uint LETTER = 3;
        public const uint EMAIL = 4;
        public const uint FORM = 5;
        public const uint GENERALNOTE = 14;
    }

    // Attachment Locations
    public struct OLI_ATTACHLOCATION
    {
        public const uint INLINE = 1;
        public const uint URLREFERENCE = 2;
        public const uint MULTIPART = 3;
    }

    // Basic Attachment Types
    public struct OLI_LU_BASICATTMNTTY
    {
        public const uint TEXT = 1;
        public const uint IMAGE = 2;
        public const uint FILE = 3;
    }

    // Coverage Indicator Code
    public struct OLI_COVIND
    {
        public const uint BASE = 1;
        public const uint RIDER = 2;
        public const uint BASEINCR = 3;
        public const uint INTEGRATED = 4;
    }

    // Coverage Type Code (Not exhaustive)
    public struct OLI_COVTYPE
    {
        public const uint WLORDINARY = 1;
        public const uint WLMODIFIED = 2;
        public const uint WLLIMITEDPAY = 3;
        public const uint WLGRADPREM = 4;
        public const uint INTSENSITIVEWL = 5;
        public const uint TERMLEVEL = 6;
        public const uint TERMDECREASE = 7;
        public const uint TERMINCREASE = 8;
        public const uint UNIVLIFE = 9;
        public const uint INDXUNIVLIFE = 10;
        public const uint VARUNIVLIFE = 11;
        public const uint EXINTLIFE = 12;
        public const uint VARWLIFE = 13;
        public const uint DISABILITY = 14;
        public const uint LTC = 16;
    }

    // Fee Type Code (Not exhaustive)
    public struct OLI_FEE
    {
        public const uint POLICYFEE = 1;
        public const uint ADMINISTRATION = 2;
        public const uint MORTALITY = 7;
        public const uint EXPENSE = 8;
        public const uint SURRENDER = 16;
    }
    public struct OLI_FINACTIVITYSTATUS
    {
        public const uint PENDING = 1;
        public const uint COMPLETED = 2;
        public const uint FINACTSTAT_ALL = 3;
        public const uint CANCELLED = 4;
    }
    // Financial Activity Type (Not exhaustive)
    public struct OLI_FINACT
    {
        public const uint PREMIUM = 1;
        public const uint LOANPYMNT = 2;
        public const uint GROSSLOAN = 3;
        public const uint DIVPOL = 4;
        public const uint CLAIMPYMNT = 5;
        public const uint SPECAMTNETWITH = 6;
        public const uint PREMIUMINIT = 7;
        public const uint PREMIUMINITTERM = 8;
        public const uint PREMIUMIADDSIN = 9;
        public const uint FULLSURR = 10;
        public const uint PARTSURR = 11;
        public const uint ADJUNIT = 13;
        public const uint ADMFEE = 14;
        public const uint ANNFEE = 15;
        public const uint ASSALLOC = 17;
        public const uint ASSREB = 18;
        public const uint CANCEL = 19;
        public const uint DLRCOST = 22;
        public const uint DTHCLM = 23;
        public const uint EXCHCRDT = 29;
        public const uint FREELK = 30;
        public const uint FREELKCANC = 32;
        public const uint FEELIQ = 94;
        public const uint EXTCRDT = 95;
        public const uint FIXBONUS = 98;
        public const uint ANNUITIZATION = 100;
        public const uint PAYOUTSYSTEMATIC = 101;
        public const uint MINMIUMDIST = 102;
        public const uint FUNDTRANSFER = 103;
        public const uint CWA = 170;
        public const uint CWAREFUND = 171;
        public const uint ROLLOVEREXT = 192;
        public const uint ROLLOVERINT = 193;
        public const uint ROLLOVEREXTQ = 194;
        public const uint ROLLOVEREXTR = 195;
        public const uint ROLLOVEREXT1035 = 196;
        public const uint ENHDTHBENE = 209;
        public const uint _1035INIT = 210;
        public const uint _1035IADD = 211;
        public const uint TRANSIN = 220;
        public const uint TRANSINTTTETTE = 221;
        public const uint TRANSEXTTTETTE = 222;
        public const uint TRANSIDIRQUAL = 223;
        public const uint UNEARNEDPREM = 225;
        public const uint PREPAIDLOANINT = 226;
        public const uint UNEARNEDDIVOPTPREM = 227;
        public const uint MVA = 228;
        public const uint ACCUMLOANINT = 229;
        public const uint ADDTL = 230;
        public const uint CASHDIVPAID = 241;
        public const uint DIVPUA = 242;
        public const uint DIVREDPREM = 243;
        public const uint DIVOPTACCUM = 244;
        public const uint DIVOPTOYT = 245;
        public const uint DIVREDLOAN = 246;
        public const uint REINPYMT = 248;
        public const uint APDFPYMT = 249;
        public const uint ADPPYMT = 250;
        public const uint LNPAYOFF = 251;
        public const uint ANNRIDERPYMT = 252;
        public const uint LNINTPYMT = 254;
        public const uint REFUNDCV = 256;
        public const uint REFUNDPRM = 257;
        public const uint REFUNDPUEXCESS = 258;
        public const uint DIVWTHDRWL = 261;
        public const uint DIVINT = 262;
        public const uint DISCPREMINT = 263;
        public const uint PDFINT = 264;
        public const uint CONVETI = 267;
        public const uint MATURITY = 268;
        public const uint CONVRPU = 269;
        public const uint LPSEDAILY = 270;
        public const uint CONVRSURR = 283;
        public const uint PREMREFDEATH = 284;
        public const uint INTAUTOSURR = 286;
        public const uint MAXALLOWED = 287;
        public const uint PUAFULLSURR = 288;
        public const uint TSALOAN = 289;
        public const uint DPFWITHDRAW = 290;
        public const uint PDFWITHDRAW = 291;
        public const uint PUAPARTSURR = 292;
        public const uint OYTPARTSURR = 293;
        public const uint SPECAMTGROSSWITH = 294;
        public const uint SURRFREEWITH = 295;
        public const uint INTNETWITH = 296;
        public const uint INTGROSSWITH = 297;
        public const uint REQMINWITH = 298;
        public const uint PREF = 299;
        public const uint LOANTAKEN = 300;
        public const uint APL = 301;
        public const uint HOME = 302;
        public const uint NONHOME = 303;
        public const uint MAXLOAN = 305;
        public const uint LOANINTCAPITARR = 306;
        public const uint LOANINTCAPITADV = 307;
        public const uint BILLDIVSHORTFALL = 308;
        public const uint PDFADD = 310;
        public const uint PDFADJUST = 311;
        public const uint INTDTHCLAIM = 312;
        public const uint REININT = 313;
        public const uint PYMNTOVERAGE = 315;
        public const uint LNPYOFFBYDIV = 316;
        public const uint PYMNTSHORTAGE = 317;
        public const uint CHRGADJUST = 319;
        public const uint CUMULATIVECHRG = 320;
        public const uint CHRGDEDUCT = 321;
        public const uint CHRGCALEXP = 322;
        public const uint SURRCHARGE = 323;
        public const uint RECURRINGDEP = 326;
        public const uint SINGLEMATPAY = 327;
        public const uint INTPAY = 328;
        public const uint RECURRINGPAY = 329;
        public const uint SUBSTEQUAL = 330;
        public const uint DIVTRANS = 331;
        public const uint CAPGAINTRANS = 332;
        public const uint PCTVALWITH = 333;
        public const uint THRESHTRANSFER = 334;
        public const uint INTSWEEP = 335;
        public const uint CONVFULLPDUP = 336;
        public const uint SELLALL = 337;
        public const uint BUY = 338;
        public const uint SWITCH = 339;
        public const uint PARTSWITCH = 340;
        public const uint SHORTSELL = 341;
        public const uint SELL = 342;
        public const uint PREFERREDWITH = 343;
        public const uint EVENTCHARGE = 344;
        public const uint ADHOCCHARGE = 345;
        public const uint TRADECHARGE = 348;
        public const uint FUNDTRANSACTION = 349;
        public const uint RISKPREMIUMS = 350;
        public const uint SINGLE = 351;
        public const uint BACKPAYMENT = 352;
        public const uint NEGRISKPREMIUMS = 355;
        public const uint AMB = 356;
        public const uint PAL = 357;
        public const uint RESERVECHARGE = 358;
        public const uint PREMIUMCHARGE = 359;
        public const uint SURRENDERTAX = 360;
        public const uint MONEYIN = 361;
        public const uint MONEYOUT = 362;
        public const uint FREEVALUECANCL = 363;
        public const uint GRPXFER = 365;
        public const uint JUMBCREDIT = 366;
        public const uint LOANDEFAULT = 367;
        public const uint OVERCONTWITHD = 368;
        public const uint PARTIALANNUIT = 369;
        public const uint DCAXFER = 374;
        public const uint EMPLOYEEOPTCONTRIB = 375;
        public const uint PRIVATECONTRIBUTION = 376;
        public const uint SINGLEPREMIUMCHARGES = 377;
        public const uint WOP = 378;
        public const uint PAYINDIVORCE = 379;
        public const uint PAYOUTDIVORCE = 380;
        public const uint INTPOST = 381;
        public const uint LEGAL = 384;
        public const uint INTRST = 385;
        public const uint INVTG = 386;
        public const uint INVESTCOMMISSION = 387;
        public const uint PREMBONUS = 390;
        public const uint PREMQUALCREDIT = 391;
        public const uint CONSISTOPTAMT = 392;
        public const uint AUTOLN = 400;
        public const uint ALL = 999;
        public const uint COIBONUS = 271;
        public const uint EXPNSBONUS = 272;
        public const uint COIEXPBONUS = 273;
        public const uint FIRSTYRBONUS = 274;
        public const uint CVBONUS = 275;
        public const uint NONGUARINTBONUS = 276;
        public const uint GUARINTBONUS = 277;
        public const uint UNAPPLDCASHIN = 278;
        public const uint UNAPPLDCASHOUT = 279;
        public const uint RTNDITEMIN = 280;
        public const uint RTNDITEMOUT = 281;
        public const uint ER = 231;
        public const uint ERDISC = 232;
        public const uint EEVOL = 233;
        public const uint EEMNDT = 234;
        public const uint EEDSR = 235;
        public const uint EEDC = 236;
        public const uint EENONDED = 237;
        public const uint IRA = 238;
        public const uint EEEED = 239;
        public const uint ERMTCH = 240;
    }

    // Gender
    public struct OLI_GENDER
    {
        public const uint MALE = 1;
        public const uint FEMALE = 2;
        public const uint UNISEX = 3;
        public const uint COMBINED = 4;
    }

    // Government ID Type (Not exhaustive)
    public struct OLI_GOVTID
    {
        public const uint SSN = 1;
        public const sbyte TID = 2;
        public const uint SIN = 3;					// Canada
        public const uint USEMPID = 8;				// EIN
        public const uint USNONRESTID = 9;			// Non-resident alien
    }

    // Government ID Status
    public struct OLI_GOVTIDSTAT
    {
        public const uint CERTIFIED = 1;
        public const uint NOTCERTIFIED = 2;
        public const uint APPLIEDFOR = 3;
        public const uint NO = 4;
        public const uint ATTESTED = 5;
        public const uint ATTESTEDFAIL = 6;
        public const uint IRSREQCERT = 7;
        public const uint IRSREQCER2IN3 = 8;
        public const uint BKUPWHOLDING = 9;
        public const uint REFUSE = 12;
        public const uint W9RECEIVED = 18;
        public const uint NOCERTATTEMPT = 19;
    }

    // Holding Type
    public struct OLI_HOLDTYPE
    {
        public const uint ASSETLIAB = 1;
        public const uint POLICY = 2;
        public const uint INVESTMENT = 3;
        public const uint PACKAGE = 4;
        public const uint POLICYINVESTMENT = 5;
        public const uint GROUPMASTER = 6;
        public const uint BANKING = 7;
        public const uint MORTGAGE = 8;
    }

    // Line of Business
    public struct OLI_LINEBUS
    {
        public const uint LIFE = 1;
        public const uint ANNUITY = 2;
        public const uint DI = 3;
        public const uint HEALTH = 4;
        public const uint LTC = 5;
        public const uint CRITICALILL = 7;
        public const uint MEDICARESUPP = 9;
        public const uint SPECIFIEDDISEASE = 1013300001;
        public const uint UL = 1013300002;
        public const uint PRIVATEFFSPLAN = 1013300003;
        public const uint PRESCRIPTIONDRUGPLAN = 1013300004;
        public const uint IMMEDIATE = 1013300005;
        public const uint TRUEGROUP = 1013300006;
        public const uint GROUPCONTRACT = 1013300007;
    }
    // Loan Status
    public struct OLI_LOANSTAT
    {
        public const uint AVAIL = 1;
        public const uint REQUESTED = 2;
        public const uint TAKEN = 3;
        public const uint DELINQUENT = 4;
        public const uint DEFAULTED = 5;
    }

    // Measurement Units
    public struct OLI_MEASURE
    {
        public const uint METRIC = 1;				// Centimeters/Kilograms
        public const uint USSTANDARD = 2;			// Inches/Pounds
        public const uint USSECOND = 3; 			// ft.in/lb.oz
        public const uint USTHIRD = 4;				// decimal ft/lb
    }

    // Organization Form  (Not exhaustive)
    public struct OLI_ORG
    {
        public const uint SOLEP = 1;			// Sole Proprietor
        public const uint PARTNER = 2;			// Partnership
        public const uint LTDPART = 3;			// Limited Partnership
        public const uint PRVCORP = 4;			// Private Corporation
        public const uint PUBCORP = 5;			// Public Comporation
        public const uint STP = 6;				// "S" Corporation
        public const uint PROCORP = 7;			// Professional Corporation
        public const uint PERSERV = 8;			// Personal Services Corp.
        public const uint GOVERN = 9;			// Government Agency
        public const uint ASSOC = 10;			// Association
        public const uint CHARIT = 11;			// Charitable Organization
        public const uint NONPROF = 12; 		// Nonprofit Organization
        public const uint CTP = 13; 			// "C" Comporation
        public const uint LTDLIAB = 14; 		// Limited Liability Corp.
        public const uint Franchise = 15;		// Franchise
    }

    // Participant Role Codes (not exhaustive)
    public struct OLI_PARTICROLE
    {
        public const uint PRIMARY = 1;
        public const uint OTHINSURED = 2;
        public const uint CHILD = 3;
        public const uint DEP = 4;
        public const uint SPOUSE = 5;
        public const uint JOINT = 6;
        public const uint BENE = 7;
        public const uint BUSPARTNER = 8;
        public const uint BENECONT = 9;
        public const uint BENETERT = 10;
        public const uint BENEASSIGNEE = 11;
        public const uint PAYOR = 12;
        public const uint PAYEE = 13;
        public const uint CORRESPONDENCE = 14;
        public const uint PRIMAGENT = 15;
        public const uint ADDAGENT = 16;
        public const uint WITNESS = 17;
        public const uint OWNER = 18;
        public const uint TRUSTEE = 19;
        public const uint PARENTGUARDIAN = 20;
        public const uint CTRSIGNAGENT = 21;
        public const uint APPLICANT = 22;
        public const uint GRANTOR = 23;
        public const uint CUSTODIAN = 24;
        public const uint PLANADMIN = 25;
        public const uint OTHBILLREC = 26;
        public const uint ANNUITANT = 27;
        public const uint JNTANNUITANT = 28;
        public const uint OWNERCONT = 29;
        public const uint SERVAGENT = 30;
        public const uint _3RDPARTYRECIP = 31;
        public const uint STMTRECIP = 32;
        public const uint POWATTY = 33;
        public const uint ASSIGNEE = 34;
        public const uint DENTAL_PROVIDER = 35;
        public const uint OWNERANNUITANT = 36;
        public const uint ENROLLEE = 37;
        public const uint ANNUITANTCONTINGENT = 38;
        public const uint PLANSPONSOR = 39;
        public const uint UNDERWRITER = 40;
        public const uint CRUASSOC = 41;
        public const uint PERSONOWN = 42;
        public const uint JOINTCONT = 43;
        public const uint ANNSPOUSE = 44;
        public const uint COANNUITANT = 45;
        public const uint JOINTOWNER = 50;
        public const uint CONSERVATOR = 51;
        public const uint UNBORNCHILD = 52;
        public const uint UNKNOWNASSIGNEE = 53;
        public const uint INVESTIGATOR = 56;
        public const uint ATTENDPHYSICIAN = 57;
        public const uint MEDEXAMINER = 58;
        public const uint FIRSTNOTIFIER = 59;
        public const uint CLAIMPROXY = 60;
        public const uint MORTGAGEE = 62;
        public const uint LOSSPAYEE = 63;
        public const uint DRIVER = 64;
        public const uint EXCLUDEDDRIVER = 65;
        public const uint LESSOR = 66;
        public const uint OTHRINTERESTED = 67;
        public const uint OTRRESIDENT = 68;
        public const uint SUCCESSORCUSTOD = 69;
        public const uint RENTER = 70;
        public const uint RESIDENT = 71;
        public const uint LIENHOLDER = 72;
        public const uint COAPPLICANT = 73;
        public const uint CLAIMPROCESSOR = 74;
        public const uint CLAIMSMANAGER = 75;
        public const uint CLAIMSCLERK = 76;
        public const uint CLAIMAPPR = 77;
        public const uint SUCCEEDBENE = 78;
    }

    // Party Type Codes
    public struct OLI_PT
    {
        public const uint PERSON = 1;
        public const uint ORG = 2;
    }

    // Pay Methods	(Not exhaustive)
    public struct OLI_PAYMETH
    {
        public const uint NOBILL = 1;
        public const uint REGBILL = 2;
        public const uint IRREFBILL = 3;
        public const uint PAID = 4;
        public const uint LISTBILL = 5;
        public const uint PAYROLL = 6;
        public const uint ETRANS = 7;
        public const uint GOVALLOT = 8;
        public const uint CREDCARD = 9;
        public const uint PAC = 26;
    }

    // Pay Modes (not exhaustive)
    public struct OLI_PAYMODE
    {
        public const uint ANNUAL = 1;
        public const uint SEMIANNUAL = 2;			  // ACORD uses BIANNUAL
        public const uint QUARTERLY = 3;
        public const uint MNTHLY = 4;
        public const uint BIMNTHLY = 5;
        public const uint WKLY = 6;
        public const uint BIWKLY = 7;
        public const uint SINGLEPAY = 9;
        public const uint MNTH49 = 10;
        public const uint EVERY4WEEKS = 12;
        public const uint MNTH410 = 13;
        public const uint NONE = 99;
        public const uint TWENTYSIX = 1013300006;
        public const uint FIFTYTWO = 1013300007;
    }

    // Phone Types (not exhaustive)
    public struct OLI_PHONETYPE
    {
        public const uint HOME = 1;
        public const uint BUS = 2;
        public const uint BUSFAX = 4;
        public const uint HOMEFAX = 15;
        public const uint VOICE = 16;
        public const uint FAX = 19;
    }

    // Policy Product Types (not exhaustive)
    public struct OLI_PRODTYPE
    {
        public const uint WL = 1;
        public const uint TERM = 2;
        public const uint UL = 3;
        public const uint VUL = 4;
        public const uint INDXUL = 5;
        public const uint INTWL = 6;
        public const uint EXINTL = 7;
        public const uint VWL = 8;
        public const uint ANN = 9;
        public const uint VAR = 10;
        public const uint INDX = 11;
        public const uint BANKERS_GATEWAY_PRODUCT = 1013300013;
        public const uint JUVENILE_ESTATE_BUILDER = 1013300014;
        public const uint UNIVERSAL_TREND = 1013300015;
        public const uint WHOLE_LIFE_PACE = 1013300016;
        public const uint EQUITY_INDEXED = 1013300017;
        public const uint BONUS_EQUITY_INDEXED = 1013300018;
        public const uint SENIOR_GROUP_MEDICAL = 1013300019;
        public const uint LIFE = 1013300020;
        public const uint ANNUITY = 1013300021;
        public const uint HEALTH = 1013300022;
        public const uint IMMEDIATE = 1013300023;
        public const uint TRUE_GROUP = 1013300024;
        public const uint HIGH_DEDUCTIBLE_MEDICARE_SUPPLEMENT = 1013300025;
        public const uint CRITICAL_ILNESS_WO_CANCER = 1013300026;
        public const uint CRITICAL_ILNESS_WITH_CANCER = 1013300027;
        public const uint PULSE_PROTECTION = 1013300028;
        public const uint DECREASING_TERM = 1013300029;
        public const uint RENEWABLE_TERM = 1013300030;
        public const uint NOINS = 1013300031;
    }
    public struct BillingStatuses
    {
        public const uint ACTIVE = 1;
        public const uint SUSPEND = 6;
        public const uint HOLD = 1013300001;
    }

    public struct BillingStatusReasons
    {
        public const uint Paid_Up = 1013300001;
        public const uint Single_Premium = 1013300002;
        public const uint Early_Paid_Up = 1013300003;
        public const uint Waiver_Pending = 1013300004;
        public const uint Death_Pending = 1013300005;
        public const uint Policy_Change = 1013300006;
        public const uint Billing_Error = 1013300007;
        public const uint RPU = 1013300008;
        public const uint Extended_Term_Insurance = 1013300009;
        public const uint Adjustment = 1013300010;
        public const uint Waiver_Disability = 1013300011;
        public const uint NFO = 1013300012;
        public const uint Vanish = 1013300013;
        public const uint Vanish_Base = 1013300014;
        public const uint Stopped_Premium = 1013300015;
    }
    // Policy Status (not exhaustive)
    public struct OLI_POLSTAT
    {
        public const uint ACTIVE = 1;					// LP Code A
        public const uint INACTIVE = 2;
        public const uint PAIDUP = 3;
        public const uint LAPSED = 4;
        public const uint LAPSEPEND = 5;
        public const uint SURR = 6;
        public const uint NOTAKE = 7;
        public const uint PENDING = 8;					// LP Code P
        public const uint TERMINATE = 14;				// LP Code T
        public const uint GRACEPD = 42;
        public const uint SUSPEND = 55; 				// LP Code S
    }
    public struct OLI_OBJECTTYPE
    {
        public const uint CLIENT = 1;
        public const uint ADDRESS = 2;
        public const uint PHONE = 3;
        public const uint HOLDING = 4;
        public const uint EXPENSENEED = 5;
        public const uint PARTY = 6;
        public const uint ACTIVITY = 7;
        public const uint RELATION = 8;
        public const uint ATTACHMENT = 9;
        public const uint LICENSE = 10;
        public const uint CARRIERAPPOINTMENT = 11;
        public const uint SECURITY = 12;
        public const uint PRODUCER = 13;
        public const uint AUTHORINFO = 14;
        public const uint BUSINESSRULEINFO = 15;
        public const uint GROUPING = 16;
        public const uint HOUSEHOLD = 17;
        public const uint POLICY = 18;
        public const uint LIFE = 19;
        public const uint LIFECOVERAGE = 20;
        public const uint COVOPTION = 21;
        public const uint LIFEPARTICIPANT = 22;
        public const uint KEYEDVALUE = 23;
        public const uint LIFEUSA = 24;
        public const uint ANNUITY = 25;
        public const uint PAYOUT = 26;
        public const uint PAYOUTPARTICIPANT = 27;
        public const uint DHPARTICIPANT = 28;
        public const uint DISABILITYHEALTH = 29;
        public const uint DHRIDER = 30;
        public const uint INVESTMENT = 31;
        public const uint SUBACCOUNT = 32;
        public const uint INVESTPRODUCT = 33;
        public const uint INVESTPORTFOLIO = 34;
        public const uint POLICYPRODUCT = 35;
        public const uint CARRIER = 36;
        public const uint RESULTSET = 37;
        public const uint RSFIELD = 38;
        public const uint RSFIELDS = 39;
        public const uint CRITERIA = 40;
        public const uint LINKMANAGER = 41;
        public const uint ERRORS = 42;
        public const uint RECORDOWNER = 43;
        public const uint OBJCOLLECTION = 44;
        public const uint SERVER = 45;
        public const uint BUSINESRULEINFOS = 50;
        public const uint EXTENSIONCONTEXT = 51;
        public const uint BUSINESSRULECONTEXT = 52;
        public const uint LINKINFO = 53;
        public const uint ERROR = 54;
        public const uint PRIORNAME = 55;
        public const uint EMAILADDRESS = 56;
        public const uint REQUIREMENTINFO = 57;
        public const uint APPLICATIONINFO = 58;
        public const uint RISK = 59;
        public const uint SUBSTANCEUSAGE = 60;
        public const uint MEDCONDITION = 61;
        public const uint MEDTREATMENT = 62;
        public const uint MEDPREVENTION = 63;
        public const uint FAMILLNESS = 64;
        public const uint VIOLATION = 65;
        public const uint CRIMCONVICTION = 66;
        public const uint MILITARYEXP = 67;
        public const uint HHFAMILYINS = 68;
        public const uint LIFESTYLEACTIVITY = 69;
        public const uint UNDERWATERDIVINGEXP = 70;
        public const uint DIVEPURPOSE = 71;
        public const uint RACINGEXP = 72;
        public const uint COMPETITIONDETAIL = 73;
        public const uint AIRSPORTSEXP = 74;
        public const uint BALLOONINGEXP = 75;
        public const uint HANGGLIDINGEXP = 76;
        public const uint ULTRALITEEXP = 77;
        public const uint PARACHUTINGEXP = 78;
        public const uint CLIMBINGEXP = 79;
        public const uint FOREIGNTRAVEL = 80;
        public const uint AVIATIONEXP = 81;
        public const uint CURRENCY = 82;
        public const uint EXCHANGERATE = 83;
        public const uint INVESTPRODUCTINFO = 84;
        public const uint COMPENSATIONPAYMENT = 85;
        public const uint ANNRIDER = 86;
        public const uint CURRENCIES = 87;
        public const uint ANNUITYUSA = 88;
        public const uint ARRANGEMENT = 89;
        public const uint ARRSOURCE = 90;
        public const uint ARRDESTINATION = 91;
        public const uint FINACTIVITY = 92;
        public const uint FINSTMT = 93;
        public const uint COMMSTMT = 94;
        public const uint COMMDETAIL = 95;
        public const uint BILLSTMT = 96;
        public const uint BILLDETAIL = 97;
        public const uint SCENARIO = 98;
        public const uint SCENARIOPART = 99;
        public const uint MEDEXAM = 100;
        public const uint FORMINSTANCE = 101;
        public const uint SIGNATUREINFO = 102;
        public const uint FORMRESPONSE = 103;
        public const uint ASSOCRESPONSEDATA = 104;
        public const uint CLAIM = 105;
        public const uint LOAN = 106;
        public const uint ALTPREMMODE = 107;
        public const uint INVESTPRODUCTXLAT = 108;
        public const uint HOLDINGXLAT = 109;
        public const uint COVOPTIONXLAT = 110;
        public const uint COVERAGEXLAT = 111;
        public const uint POLICYPRODUCTXLAT = 112;
        public const uint INVESTPORTFOLIOXLAT = 113;
        public const uint PARTYXLAT = 114;
        public const uint PERSON = 115;
        public const uint ORGANIZATION = 116;
        public const uint COVERAGEPRODUCT = 117;
        public const uint COVERAGEPRODUCTXLAT = 118;
        public const uint INTENT = 119;
        public const uint OBJ_STATUSEVENT = 120;
        public const uint ABDOMENMEASURE = 121;
        public const uint ACCOUNTINGSTATEMENT = 122;
        public const uint ALLOWEDRELATIONSHIP = 123;
        public const uint ANNUITYPRODUCTEXCLUDE = 124;
        public const uint AUTHORIZATIONTRANSACTION = 130;
        public const uint CHARGEPCTSCHEDULE = 131;
        public const uint XTBML = 132;
        public const uint EXAM = 133;
        public const uint EMPLOYMENT = 136;
        public const uint FINANCIALEXPERIENCE = 138;
        public const uint POLICYPRODUCTINFO = 140;
        public const uint PAYMENTMETHOD = 141;
        public const uint COVOPTIONPRODUCT = 154;
        public const uint UNDERWRITINGCLASSPRODUCT = 156;
        public const uint LIFEPRODUCT = 162;
        public const uint PAYMENT = 163;
        public const uint ACCOUNTINGACTIVITY = 164;
        public const uint REINSURANCEINFO = 165;
        public const uint BENEFITLIMIT = 166;
        public const uint PRIORLTC = 167;
        public const uint PHARMACY = 168;
        public const uint PHYSICIAN = 169;
        public const uint PHYSICIANINFO = 170;
        public const uint PRESCRIPTIONDRUG = 171;
        public const uint PRESCRIPTIONFILL = 172;
        public const uint ORGANIZATIONFINANCIALDATA = 173;
        public const uint CHESTFORCEDMEASURE = 174;
        public const uint CHESTFULLMEASURE = 175;
        public const uint COMMOPTIONAVAILABLE = 176;
        public const uint COVOPTIONPRODUCTXLAT = 177;
        public const uint TAXWITHHOLDING = 178;
        public const uint SYSTEMMESSAGE = 179;
        public const uint ENDORSEMENT = 180;
        public const uint EXCLUSION = 181;
        public const uint SUBSTANDARDRATING = 182;
        public const uint SETTLEMENTINFO = 183;
        public const uint SETTLEMENTDETAIL = 184;
        public const uint ANNUITYPRODUCT = 185;
        public const uint BREAKPOINT = 186;
        public const uint FEE = 187;
        public const uint AUTHORIZATION = 188;
        public const uint OWNERSHIP = 189;
        public const uint BUSINESSPROCESSALLOWED = 190;
        public const uint FEATUREPRODUCT = 191;
        public const uint INCOMEPAYOUTPRODUCTOPTION = 192;
        public const uint INVESTPRODUCTRATEVARIATION = 193;
        public const uint INVESTPRODUCTRATEVARIATIONBYDURATION = 194;
        public const uint INVESTPRODUCTRATEVARIATIONBYVOLUME = 195;
        public const uint ALLOCATION = 196;
        public const uint PRODUCTREQUISITE = 197;
        public const uint PRODUCTCONFLICT = 198;
        public const uint SOURCEINFO = 199;
        public const uint COMMISSIONCALCACTIVITY = 200;
        public const uint COMMISSIONCALCDETAIL = 201;
        public const uint COMMISSIONCALCINFO = 202;
        public const uint COMMISSIONPRODUCT = 203;
        public const uint COMMISSIONSTATEMENT = 204;
        public const uint RESTRICTIONINFO = 205;
        public const uint FREELOOKINVESTRULEPRODUCT = 206;
        public const uint INVESTRULEPRODUCT = 207;
        public const uint NUMINVESTPRODUCT = 208;
        public const uint LOANPROVISION = 209;
        public const uint MINBALANCECALCRULE = 210;
        public const uint DIVIDEND = 211;
        public const uint LAPSEPROVISION = 212;
        public const uint NONFORPROVISION = 213;
        public const uint REWARD = 214;
        public const uint ALLOWEDSUBSTANDARD = 215;
        public const uint RATINGAGENCYINFO = 216;
        public const uint AMOUNTPRODUCT = 217;
        public const uint FEATUREOPTPRODUCT = 218;
        public const uint FEATUREREQUISITE = 219;
        public const uint FEATURECONFLICT = 220;
        public const uint BANKING = 221;
        public const uint AUTHORIZEDSIGNATORY = 222;
        public const uint ILLUSTRATIONREPORTREQUEST = 223;
        public const uint PREFERREDREQFULFILLER = 224;
        public const uint TRACKINGINFO = 225;
        public const uint LABTESTING = 226;
        public const uint LABTESTRESULT = 227;
        public const uint LABTESTREMARK = 228;
        public const uint QUALITATIVERESULT = 229;
        public const uint QUANTITATIVERESULT = 230;
        public const uint REFERENCERANGE = 231;
        public const uint SPECIALTESTORDERED = 232;
        public const uint URINETEMPERATURE = 233;
        public const uint KIT = 234;
        public const uint CAMPAIGN = 235;
        public const uint DESTINVESTPRODUCT = 236;
        public const uint DISTRIBUTIONCHANNELINFO = 237;
        public const uint ENTITYTYPE = 238;
        public const uint EVENT = 239;
        public const uint EXCLUSIONINVESTPRODUCT = 240;
        public const uint EXTENDORCALL = 241;
        public const uint FINANCIALACTIVITYINFO = 242;
        public const uint GOVTIDINFO = 243;
        public const uint HEIGHT2 = 244;
        public const uint INCOMEOPTCONFLICT = 245;
        public const uint INCOMEOPTINFO = 246;
        public const uint INCOMEOPTREQUISITE = 247;
        public const uint INFORMATIONSERVICE = 248;
        public const uint INVESTSUBTOTALINFO = 249;
        public const uint INVESTPRODUCTINFOXLAT = 250;
        public const uint JURISDICTIONAPPROVAL = 251;
        public const uint OLIFEEXTENSION = 252;
        public const uint PERIODICBALANCEYTDINFO = 253;
        public const uint POLICYACTIVITYLIST = 254;
        public const uint PRODUCERAGREEMENT = 255;
        public const uint QUALIFIEDPLANENTITY = 256;
        public const uint REGISTRATIONJURISDICTION = 257;
        public const uint RESULTSRECEIVERPARTY = 258;
        public const uint SOURCEINVESTPRODUCT = 259;
        public const uint SUPPERANNUATION = 260;
        public const uint SURRENDERCHARGESCHEDULE = 261;
        public const uint EDUCATION = 263;
        public const uint REGISTRATION = 264;
        public const uint UNDERWRITINGCLASSPRODUCTXLAT = 265;
        public const uint LINEOFAUTHORITY = 266;
        public const uint VALUES = 267;
        public const uint PROPERTYANDCASUALTY = 268;
        public const uint WEIGHT2 = 269;
        public const uint OBJ_270 = 270;
        public const uint DISTRIBUTATIONAGREEMENT = 271;
        public const uint COMMREMITTANCE = 272;
        public const uint OBJ_273 = 273;
        public const uint COMMSCHEDULE = 274;
        public const uint COMMFORMULA = 275;
        public const uint DISTRIBUTIONAGREEMENTINFO = 276;
        public const uint FUNDINGSOURCEMETHODSALLOWED = 277;
        public const uint OBJ_278 = 278;
        public const uint OBJ_279 = 279;
        public const uint OBJ_280 = 280;
        public const uint SCHEDULEDCHANGE = 281;
        public const uint MEDICALEQUIPMENT = 282;
        public const uint CARDIACMURMER = 283;
        public const uint OBJ_284 = 284;
        public const uint OBJ_285 = 285;
        public const uint OBJ_286 = 286;
        public const uint OBJ_287 = 287;
        public const uint OBJ_288 = 288;
        public const uint OBJ_289 = 289;
        public const uint URL = 290;
        public const uint DISTRIBUTIONLEVEL = 291;
        public const uint OBJ_292 = 292;
        public const uint OBJ_293 = 293;
        public const uint OBJ_294 = 294;
        public const uint OBJ_295 = 295;
        public const uint OBJ_296 = 296;
        public const uint OBJ_297 = 297;
        public const uint OBJ_298 = 298;
        public const uint OBJ_299 = 299;
        public const uint TABLEREF = 300;
        public const uint IDENTITYVERIFICATION = 301;
        public const uint IDENTIFICATION = 302;
        public const uint VERIFIERPARTICIPANT = 303;
        public const uint LIFEUSAPRODUCT = 304;
        public const uint IRSPREMCALCMETHOD = 305;
        public const uint MARKET = 306;
        public const uint FEATURETRANSACTIONPRODUCT = 307;
        public const uint FEATUREPRODUCTINFO = 308;
        public const uint ADMINTRANSACTIONPRODUCT = 309;
        public const uint POLICYSTATUSCC = 310;
        public const uint CLAIMESTIMATE = 311;
        public const uint ADDITIONALINTERESTRATEINFO = 312;
        public const uint SITUSINFO = 313;
        public const uint REGULATORYDISTAGREEMENT = 314;
        public const uint PRODUCTTYPEINFO = 315;
        public const uint DISTINGUISHEDOBJECT = 316;
        public const uint PREMIUMRATE = 317;
        public const uint DIVIDENDRATE = 318;
        public const uint CASHVALUERATE = 319;
        public const uint COIRATE = 320;
        public const uint CAUSEOFDEATH = 321;
        public const uint ACCOUNTDESIGNATIONCC = 323;
        public const uint ALLOCTYPEPRODUCT = 326;
        public const uint ALLOWEDDAYCC = 327;
        public const uint APPTCOUNTY = 332;
        public const uint ASSOCIATEDRESPONSEDATA = 335;
        public const uint ASSUMEDINTERESTRATECC = 336;
        public const uint AUTHORIZATIONENTITYCC = 337;
        public const uint AXIS = 340;
        public const uint AXISDEF = 341;
        public const uint BESTDAYTOCALLCC = 343;
        public const uint BILLINGDETAIL = 344;
        public const uint BILLINGSTATEMENT = 345;
        public const uint BUSINESSMETHODCC = 346;
        public const uint BUSINESSPROCESSCC = 347;
        public const uint CHANGESUBTYPE = 348;
        public const uint COLINDEXCAPCC = 352;
        public const uint COLINDEXCC = 353;
        public const uint COMMISSIONDETAIL = 355;
        public const uint COMMISSIONLINKCC = 356;
        public const uint CONTENTCLASSIFICATION = 358;
        public const uint CONTINGENTJOINTCC = 359;
        public const uint COVERAGE = 360;
        public const uint CRIMINALCONVICTION = 368;
        public const uint CRITERIAEXPRESSION = 369;
        public const uint DATATRANSMITTALSUBTYPE = 370;
        public const uint DEATHBENEFITOPTCC = 371;
        public const uint DEFLIFEINSMETHODCC = 372;
        public const uint DISTRIBUTIONCHANNELCC = 374;
        public const uint EXTENSION = 379;
        public const uint FAMILYILLNESS = 380;
        public const uint FEATUREOPTCONFLICT = 381;
        public const uint FEATUREOPTREQUISITE = 382;
        public const uint FINACTIVITYTYPECC = 383;
        public const uint FINANCIALACTIVITY = 384;
        public const uint FINANCIALSTATEMENT = 387;
        public const uint FORMINSTANCEDESTINATION = 389;
        public const uint FORMINSTANCEREQUEST = 390;
        public const uint HHFAMILYINSURANCE = 394;
        public const uint ILLUSTRATIONREQUEST = 396;
        public const uint ILLUSTRATIONRESULT = 397;
        public const uint ILLUSTRATIONTXN = 398;
        public const uint INCOMEOPTIONCC = 400;
        public const uint INCOMEOPTIONINFO = 401;
        public const uint INVESTMENTSUBTOTALINFO = 404;
        public const uint ISSUEGENDERCC = 408;
        public const uint JURISDICTIONCC = 410;
        public const uint KEY = 411;
        public const uint KEYDEF = 412;
        public const uint LEVELIZATIONOPTIONCC = 413;
        public const uint LINEOFAUTHORITYCC = 415;
        public const uint LOANINTMETHODCC = 416;
        public const uint MEDICALCONDITION = 417;
        public const uint MEDICALEXAM = 418;
        public const uint MEDICALPREVENTION = 419;
        public const uint MEDICALTREATMENT = 420;
        public const uint METADATA = 421;
        public const uint MIBREQUEST = 422;
        public const uint MIBSERVICEDESCRIPTOR = 423;
        public const uint MIBSERVICEOPTIONS = 424;
        public const uint OBJECTTYPECC = 425;
        public const uint OLIFE = 426;
        public const uint PARTICIPANT = 428;
        public const uint PAYMENTFORMCC = 430;
        public const uint PAYMENTMODEMETHPRODUCT = 431;
        public const uint PAYMENTSOURCECC = 432;
        public const uint PERIODCERTAINCC = 433;
        public const uint POLICYISSUETYPECC = 436;
        public const uint PROXYVENDOR = 440;
        public const uint QUALIFIEDPLANCC = 441;
        public const uint RATEVARIATION = 443;
        public const uint RATEVARIATIONBYDURATION = 444;
        public const uint RATEVARIATIONBYVOLUME = 445;
        public const uint REINSURANCEREQUEST = 448;
        public const uint RELATIONSHIPCC = 449;
        public const uint REQUESTBASIS = 450;
        public const uint RESULTBASIS = 451;
        public const uint RESULTINFO = 452;
        public const uint RIDER = 454;
        public const uint SCENARIOPARTICIPANT = 455;
        public const uint SCHEDULEDPAYMENTCC = 456;
        public const uint SOURCEOFFUNDSCC = 460;
        public const uint SPLITPCTINCREMENTSCC = 461;
        public const uint STATUSRECEIVERPARTY = 462;
        public const uint SUPERANNUATION = 463;
        public const uint TABLE = 465;
        public const uint TARGETURL = 466;
        public const uint TRANSRESULT = 467;
        public const uint TRUSTTYPECC = 468;
        public const uint TXLIFE = 469;
        public const uint TXLIFENOTIFY = 470;
        public const uint TXLIFEREQUEST = 471;
        public const uint TXLIFERESPONSE = 472;
        public const uint USERAUTHREQUEST = 474;
        public const uint USERAUTHRESPONSE = 475;
        public const uint USERPSWD = 476;
        public const uint VECTOR = 478;
        public const uint VECTORITEM = 479;
        public const uint VECTORREQUEST = 480;
        public const uint VENDORAPP = 481;
        public const uint RATEOFRETURNINFO = 484;
        public const uint PAYOUTCHANGE = 485;
        public const uint LOGICALEXPRESSION = 486;
        public const uint LOGICALCRITERIA = 487;
        public const uint LIFESTYLEVIOLATION = 488;
        public const uint DATECOLLECTION = 489;
        public const uint CLAIMMEDCONDITIONINFO = 490;
        public const uint CONTINGENCYBENEFITCHANGE = 491;
        public const uint ALLOWEDCHANGE = 492;
        public const uint ALLOWEDPERCENT = 493;
        public const uint POLICYVALUES = 494;
        public const uint LOSTCAPABILITY = 495;
        public const uint COMPLEXCONTENTDESCRIPTOR = 496;
        public const uint CLAIMMEDTREATMENTINFO = 497;
        public const uint REQUISITEINVESTPRODUCT = 498;
        public const uint CLAIMREVIEW = 499;
        public const uint INQUIRYVIEW = 500;
        public const uint OBJECTTYPEINFO = 501;
        public const uint RELATIONROLECODECC = 502;
        public const uint PARTICIPANTROLECODECC = 503;
        public const uint ASSOCIATEDOBJECTINFO = 504;
        public const uint ASSOCPARTICIPANTOBJECTINFO = 505;
        public const uint LOANACTIVITY = 506;
        public const uint POLICYSTATEMENT = 507;
        public const uint POLICYSTATEMENTDETAIL = 508;
        public const uint CASE = 509;
        public const uint INVESTMENTSTATEMENT = 510;
        public const uint SUBACCOUNTSTATEMENT = 511;
        public const uint SUBACCOUNTSTATEMENTDETAIL = 512;
        public const uint INVESTMENTSTATEMENTDETAIL = 513;
        public const uint DISABILITYHEALTHPRODUCT = 514;
        public const uint RIDERPRODUCT = 515;
        public const uint DISABILITYHEALTHPROVISIONS = 516;
        public const uint ELIMPERIODACCOPTION = 517;
        public const uint ELIMPERIODSICKOPTION = 518;
        public const uint BENEPERIODACCOPTION = 519;
        public const uint BENEPERIODSICKOPTION = 520;
        public const uint EMPLOYMENTCLASSOPTION = 521;
        public const uint OCCUPCLASSOPTION = 522;
        public const uint HEALTHSERVICEOPTION = 523;
        public const uint NATURESUBCATEGORYOPTION = 524;
        public const uint MEDPROVIDEROPTION = 525;
        public const uint PROVIDERCLASSOPTION = 526;
        public const uint CONDITIONTYPEOPTION = 527;
        public const uint MANNEROFLOSSOPTION = 528;
        public const uint DEDUCTIONOPTION = 529;
        public const uint BENEFITLIMITOPTION = 530;
        public const uint MANAGEDCAREOPTION = 531;
        public const uint OBJ_1001 = 1001;
        public const uint OTHER = 2147483647;
    }
    // Relation Role Codes (not exhaustive)
    public struct OLI_REL
    {
        public const uint SPOUSE = 1;
        public const uint CHILD = 2;
        public const uint PARENT = 3;
        public const uint SIBLING = 4;
        public const uint FAMILY = 5;
        public const uint EMPLOYEE = 6;
        public const uint EMPLOYER = 7;
        public const uint OWNER = 8;
        public const uint PARTNER = 9;
        public const uint ADVISOR = 10;
        public const uint AGENT = 11;
        public const uint REFERRAL = 12;
        public const uint NOMINATOR = 13;
        public const uint FRIEND = 14;
        public const uint DOMPART = 15; 		  // Domestic Partner
        public const uint ROOMMATE = 16;
        public const uint BUSCONTACT = 17;
        public const uint HOUSEHOLD = 18;
        public const uint ADVISEE = 20;
        public const uint CLIENT = 21;
        public const uint HHHEAD = 23;			  // Household Head
        public const uint HHMEMBER = 24;		  // Household Member
        public const uint OWNEDBY = 25;
        public const uint LEGALGUARD = 27;
        public const uint GROUP = 28;
        public const uint GRPCONTACT = 29;
        public const uint GRPMEMBER = 30;
        public const uint PAYER = 31;
        public const uint INSURED = 32;
        public const uint COVINSURED = 33;
        public const uint BENEFICIARY = 34;
        public const uint ANNUITANT = 35;
        public const uint CONTGNTBENE = 36;
        public const uint PRIMAGENT = 37;
        public const uint SERVAGENT = 38;			// Servicing Agent
        public const uint ASSIGNAGENT = 39; 		// Assigned Agent
        public const uint DEPENDENT = 40;
        public const uint PHYSICIAN = 41;
        public const uint PATIENT = 42;
        public const uint ORIGINATOR = 43;
        public const uint SUPERIORAGENT = 46;
        public const uint SUBORDAGENT = 47;
        public const uint GENAGENT = 48;
        public const uint CONSIGNEEAGENT = 51;
        public const uint ADDWRITINGAGENT = 52;
        public const uint SPLITAGENT = 52;			// Conseco Term
        public const uint REGAGENT = 53;
        public const uint PLANSPONSOR = 54;
        public const uint ASSIGNBENE = 55;
        public const uint TERTBENE = 56;			// Teriary Beneficiary
        public const uint CUSTODIAN = 57;
        public const uint REPLACED = 63;
        public const uint REPLACEDBY = 64;
        public const uint ROLLOVER = 65;
        public const uint ROLLEDINTO = 66;
        public const uint EXCHANGED = 67;
        public const uint EXCHANGEDBY = 68;
        public const uint MEMBER = 75;
        public const uint SUCCESSOR_OWNER = 78;
        public const uint BROKER = 83;
        public const uint SUPOFC = 85;				// Superior Office
        public const uint SUBORDOFC = 86;			// Subordinate Office
        public const uint CARRIER = 87;
        public const uint GRANDPARENT = 92;
        public const uint GRANDCHILD = 93;
        public const uint STEPCHILD = 94;
        public const uint COUNTERAGENT = 95;
        public const uint APPLICANT = 96;
        public const uint REQUESTOR = 97;
        public const uint ATTACHEDFORM = 105;
        public const uint INCLUDEFORM = 106;
        public const uint FORMFOR = 107;
        public const uint FIANCEE = 111;
        public const uint UNDERWRITER = 112;
        public const uint BANKER = 115;
        public const uint BANKEROF = 116;
        public const uint PAYEE = 119;
        public const uint AGENTOF = 120;
        public const uint AGENCYOF = 121;
        public const uint ADDSERVAGT = 126;
        public const uint PRIMARY = 144;
        public const uint CONTINGENTANNUITANT = 153;
        public const uint JOINTANNUITANT = 183;
        public const uint JOINTOWNER = 184;
        public const uint JOINTINSURED = 189;
        public const uint OWNERBENE = 191;
        public const uint OWNERCONTBENE = 192;
        public const uint REGIONALOFFICE = 212;
        public const uint HOMEOFFICE = 213;
        public const uint ASSISSTANT = 230;
        public const uint CASEMANAGER = 235;
        public const uint HIT = 1001;
        public const uint TRY = 1002;
        public const uint CLAIMANT = 1013300070;
        public const uint PROVIDER = 1013300071;
        public const uint SECONDARY_INSURED = 1013300004;
    }

    // Rider type codes and split up by type
    // Generic Riders (not exhaustive)
    public struct OLI_RIDER
    {
        public const uint COLA = 1;
        public const uint OPAI = 12;
        public const uint PE = 96;
        public const uint TIR = 203;
        public const uint GIB = 204;
        public const uint EEB = 205;
        public const uint DB = 206;
        public const uint BASE = 1013300064;
    }

    // Disability Rider Type Codes (not exhaustive)
    public struct OLI_DIRIDER
    {
        public const uint EXCLU = 2;
        public const uint FIO = 3;
        public const uint GIR = 4;
        public const uint CONVINC = 37;
    }

    // Tax Status (policies/investments)
    public struct OLI_TAX_STAT
    {
        public const uint FULL = 1; 			// Fully taxed
        public const uint DEFERRED = 2;
        public const uint EXEMPT = 3;
    }
    public struct OLI_TAXPLACE
    {
        public const uint FEDERAL = 1;
        public const uint JURISDICTION = 2;
        public const uint LOCAL = 3;
    }
    // Tax Withholding Calculation Method (Not exhaustive)
    public struct OLI_WITHCALCMTH
    {
        public const uint STANDARD = 1;
        public const uint BACKUP = 2;
        public const uint NONE = 3;
    }
    public struct OLI_PREMSUSPENSE
    {
        public const uint PREMSUSPENSE_BALDUE = 1;
    }
    public struct OLI_PRIVOPT
    {
       public const uint OLI_UNKNOWN = 0;
       public const uint OLI_PRIVOPT_PHONE = 1013300001;
       public const uint OLI_PRIVOPT_MAIL = 1013300002;
       public const uint OLI_PRIVOPT_EMAIL = 1013300003;
       public const uint OLI_PRIVOPT_SHARE = 1013300004;
       public const uint OLI_PRIVOPT_SHARE3RDPTY = 1013300005;
       public const uint OLI_OTHER = 2147483647;

    }
    public struct OLI_PRIVSTAT
    {
       public const uint OLI_UNKNOWN = 0;
       public const uint OLI_PRIVSTAT_OPTIN = 1013300001;
       public const uint OLI_PRIVSTAT_OPTOUT = 1013300002;

    }
    public struct OLI_TRANSTYPECODES
    {
       public const uint OLI_TRANS_FA = 101;
       public const uint OLI_TRANS_FT = 102;
       public const uint OLI_TRANS_NBSUB = 103;
       public const uint OLI_TRANS_PARORD = 104;
       public const uint OLI_TRANS_WITHDR = 105;
       public const uint OLI_TRANS_UPDARR = 107;
       public const uint OLI_TRANS_XXXXXX = 109;
       public const uint OLI_TRANS_ILLCAL = 111;
       public const uint OLI_TRANS_GENREQ = 121;
       public const uint OLI_TRANS_GENRES = 122;
       public const uint OLI_TRANS_INQREQUIREMENT = 123;
       public const uint OLI_TRANS_PARNOT = 124;
       public const uint OLI_TRANS_STANOT = 125;
       public const uint OLI_TRANS_REPNOT = 126;
       public const uint OLI_TRANS_REPPRO = 127;
       public const uint OLI_TRANS_INQREPLACE = 128;
       public const uint OLI_TRANS_LICENSEREQ = 129;
       public const uint OLI_TRANS_EMPLOY = 130;
       public const uint OLI_TRANS_FINSET = 140;
       public const uint OLI_TRANS_UNDACT = 151;
       public const uint OLI_TRANS_AGENTREASSGNMT = 161;
       public const uint OLI_TRANS_DISTAGRUPDATE = 170;
       public const uint OLI_TRANS_CHGADR = 181;
       public const uint OLI_TRANS_CHGPHN = 182;
       public const uint OLI_TRANS_CHGEMA = 183;
       public const uint OLI_TRANS_CHGBIL = 184;
       public const uint OLI_TRANS_CHGFIN = 185;
       public const uint OLI_TRANS_CHGPAR = 186;
       public const uint OLI_TRANS_CHGACT = 187;
       public const uint OLI_TRANS_CHGMSG = 188;
       public const uint OLI_TRANS_BLKTRN = 191;
       public const uint OLI_TRANS_INQPRP = 201;
       public const uint OLI_TRANS_INQINP = 202;
       public const uint OLI_TRANS_INQHLD = 203;
       public const uint OLI_TRANS_INQPAR = 204;
       public const uint OLI_TRANST_INQGRP = 205;
       public const uint OLI_TRANS_INQCOM = 206;
       public const uint OLI_TRANS_INQBIL = 207;
       public const uint OLI_TRANS_INQBIH = 208;
       public const uint OLI_TRANS_INQNOT = 210;
       public const uint OLI_TRANS_INQLIC = 211;
       public const uint OLI_TRANS_INQVAL = 212;
       public const uint OLI_TRANS_INQFIN = 213;
       public const uint OLI_TRANS_INQMSG = 214;
       public const uint OLI_TRANS_INQARRANGEMENT = 215;
       public const uint OLI_TRANS_INQREQ = 216;
       public const uint OLI_TRANS_INQACT = 217;
       public const uint OLI_TRANS_INQPVT05 = 218;
       public const uint OLI_TRANS_INQDOC = 219;
       public const uint OLI_TRANS_INQTBL = 221;
       public const uint OLI_TRANS_INQARCDOC = 222;
       public const uint OLI_TRANS_INQAPP = 223;
       public const uint OLI_TRANS_INQACCTNG = 225;
       public const uint OLI_TRANS_FINSTMTREQ = 226;
       public const uint OLI_TRANS_SYSTEMSTATUS = 227;
       public const uint OLI_TRANS_PRODINQ = 228;
       public const uint OLI_TRANS_FORMINSTANCEINQ = 229;
       public const uint OLI_TRANS_INQBANK = 230;
       public const uint OLI_TRANS_HOLDPRODINQ = 233;
       public const uint OLI_TRANS_DISTAGRINQ = 234;
       public const uint OLI_TRANS_SRCPAR = 301;
       public const uint OLI_TRANS_SRCHLD = 302;
       public const uint OLI_TRANS_SRCINP = 303;
       public const uint OLI_TRANS_SRCPRP = 304;
       public const uint OLI_TRANS_SRCACT = 305;
       public const uint OLI_TRANS_SRCGRP = 306;
       public const uint OLI_TRANS_SRCARCDOC = 309;
       public const uint OLI_TRANS_FORMINSTANCESEARCH = 310;
       public const uint OLI_TRANS_DISTAGRSEARCH = 311;
       public const uint OLI_TRANS_SRCTBL = 321;
       public const uint OLI_TRANS_MIBINQ = 401;
       public const uint OLI_TRANS_MIBUPT = 402;
       public const uint OLI_TRANS_MIBFOL = 403;
       public const uint OLI_TRANS_MIBFOLREQ = 404;
       public const uint OLI_TRANS_UPDAPPREQ = 410;
       public const uint OLI_TRANS_UPDAPPREN = 411;
       public const uint OLI_TRANS_UPDAPPNOTE = 412;
       public const uint OLI_TRANS_UPDAPTERM = 413;
       public const uint OLI_TRANS_DOCPREP = 500;
       public const uint OLI_TRANS_CHGMSC = 501;
       public const uint OLI_TRANS_CHGHLD = 502;
       public const uint OLI_TRANS_DECRSK = 503;
       public const uint OLI_TRANS_CHGEND = 504;
       public const uint OLI_TRANS_CHGSTA = 505;
       public const uint OLI_TRANS_UPDATT = 506;
       public const uint OLI_TRANS_CSC507 = 507;
       public const uint OLI_TRANS_PAYMNT = 508;
       public const uint OLI_TRANS_LOANPROC = 509;
       public const uint OLI_TRANS_UPDFORMINSTANCE = 510;
       public const uint OLI_TRANS_LREACT = 551;
       public const uint OLI_TRANS_LREFAC = 552;
       public const uint OLI_TRANS_PREARRNONFIN = 561;
       public const uint OLI_TRANS_PHARMP = 601;
       public const uint OLI_TRANS_COMMCALC = 701;
       public const uint OLI_TRANS_FIRSTNOTICE = 810;
       public const uint OLI_TRANS_DISCREPANCY = 1112;
       public const uint OLI_TRANS_TRNREQRUESULT = 1122;
       public const uint OLI_TRANS_TRNREQ = 1123;
       public const uint OLI_TRANS_TRNPARAMED = 1124;
       public const uint OLI_TRANS_TRNCAS = 1125;
       public const uint OLI_TRANS_TRNREPLACE = 1128;
       public const uint OLI_TRANS_TRNPOLPRD = 1201;
       public const uint OLI_TRANS_TRNINVPRD = 1202;
       public const uint OLI_TRANS_TRNHLD = 1203;
       public const uint OLI_TRANS_TRNPARTY = 1204;
       public const uint OLI_TRANST_TRNGRP = 1205;
       public const uint OLI_TRANS_TRNCOM = 1206;
       public const uint OLI_TRANS_TRNVAL = 1212;
       public const uint OLI_TRANS_TRNFIN = 1213;
       public const uint OLI_TRANS_TRNTBL = 1221;
       public const uint OLI_TRANS_TRNAPP = 1223;
       public const uint OLI_TRANS_TRNACCTNG = 1225;
       public const uint OLI_TRANS_TRNPRODINQ = 1228;
       public const uint OLI_TRANS_TRNDISTAGR = 1234;
       public const uint OLI_TRANS_TRNPHARM = 1601;
       public const uint OLI_TRANS_BILLTRNSMTL = 1801;
       public const uint OLI_TRANS_RES = 9000;
       public const uint OLI_TRANS_PRODSEARCH = 1013325000;
       public const uint OLI_OTHER = 2147483647;
    }
   // Variant Types (not exhaustive) (used for AttachmentData)
    public struct OLI_VARIANT
    {
        public const uint STRING = 8;
    }
    public struct OLI_UNWRITECLASS
    {
        public const uint UNKNOWN = 0;
        public const uint STANDARD = 1;
        public const uint PREFERRED = 2;
        public const uint RATED = 3;
        public const uint STANDARDPLUS = 5;
        public const uint UNINSURABLE = 7;
        public const uint PREFPLUS = 19;
    }
    public struct OLI_MANNEROFLOSS
    {
        public const uint ACCIDENT = 1;
        public const uint SICKNESS = 2;
        public const uint HOMICIDE = 3;
        public const uint SUICIDE = 4;
        public const uint UNDETERMINED = 5;
    }

    // **************************
    // * Conseco specific items *
    // **************************
    public struct CONSECO
    {
        public const String VENDORCODE = "133";
    }

    public interface ACORDConstants
    {
    }
    public static class AcordGenderXref
    {
        public static uint getAcordCode(string gender)
        {
            uint acordGenderCode = COMMON.OLI_OTHER;
            switch (gender)
            {
                case "M":
                    acordGenderCode = OLI_GENDER.MALE;
                    break;
                case "F":
                    acordGenderCode = OLI_GENDER.FEMALE;
                    break;

                default:
                    acordGenderCode = COMMON.OLI_OTHER;
                    break;
            }
            return acordGenderCode;
        }
    }
    public class AcordStateXref
    {
        const int TABLE_ENTRIES = 81;
        public Hashtable LookupAbrevByAcord;
        public Hashtable LookupAcordByAbrev;
        public Hashtable LookupNameByAcord;
        public Hashtable LookupNameByAbrev;
        public Hashtable LookupCountryByAcord;

        public AcordStateXref()
        {
            LookupAcordByAbrev = new Hashtable(TABLE_ENTRIES);
            LookupAcordByAbrev.Add("AL", 1);
            LookupAcordByAbrev.Add("AK", 2);
            LookupAcordByAbrev.Add("AS", 3);
            LookupAcordByAbrev.Add("AZ", 4);
            LookupAcordByAbrev.Add("AR", 5);
            LookupAcordByAbrev.Add("CA", 6);
            LookupAcordByAbrev.Add("CO", 7);
            LookupAcordByAbrev.Add("CT", 8);
            LookupAcordByAbrev.Add("DE", 9);
            LookupAcordByAbrev.Add("DC", 10);
            LookupAcordByAbrev.Add("FS", 11);
            LookupAcordByAbrev.Add("FL", 12);
            LookupAcordByAbrev.Add("GA", 13);
            LookupAcordByAbrev.Add("GU", 14);
            LookupAcordByAbrev.Add("HI", 15);
            LookupAcordByAbrev.Add("ID", 16);
            LookupAcordByAbrev.Add("IL", 17);
            LookupAcordByAbrev.Add("IN", 18);
            LookupAcordByAbrev.Add("IA", 19);
            LookupAcordByAbrev.Add("KS", 20);
            LookupAcordByAbrev.Add("KY", 21);
            LookupAcordByAbrev.Add("LA", 22);
            LookupAcordByAbrev.Add("ME", 23);
            LookupAcordByAbrev.Add("MH", 24);
            LookupAcordByAbrev.Add("MD", 25);
            LookupAcordByAbrev.Add("MA", 26);
            LookupAcordByAbrev.Add("MI", 27);
            LookupAcordByAbrev.Add("MN", 28);
            LookupAcordByAbrev.Add("MS", 29);
            LookupAcordByAbrev.Add("MO", 30);
            LookupAcordByAbrev.Add("MT", 31);
            LookupAcordByAbrev.Add("NE", 32);
            LookupAcordByAbrev.Add("NV", 33);
            LookupAcordByAbrev.Add("NH", 34);
            LookupAcordByAbrev.Add("NJ", 35);
            LookupAcordByAbrev.Add("NM", 36);
            LookupAcordByAbrev.Add("NY", 37);
            LookupAcordByAbrev.Add("NC", 38);
            LookupAcordByAbrev.Add("ND", 39);
            LookupAcordByAbrev.Add("MP", 40);
            LookupAcordByAbrev.Add("OH", 41);
            LookupAcordByAbrev.Add("OK", 42);
            LookupAcordByAbrev.Add("OR", 43);
            LookupAcordByAbrev.Add("PW", 44);
            LookupAcordByAbrev.Add("PA", 45);
            LookupAcordByAbrev.Add("PR", 46);
            LookupAcordByAbrev.Add("RI", 47);
            LookupAcordByAbrev.Add("SC", 48);
            LookupAcordByAbrev.Add("SD", 49);
            LookupAcordByAbrev.Add("TN", 50);
            LookupAcordByAbrev.Add("TX", 51);
            LookupAcordByAbrev.Add("UT", 52);
            LookupAcordByAbrev.Add("VT", 53);
            LookupAcordByAbrev.Add("VI", 54);
            LookupAcordByAbrev.Add("VA", 55);
            LookupAcordByAbrev.Add("WA", 56);
            LookupAcordByAbrev.Add("WV", 57);
            LookupAcordByAbrev.Add("WI", 58);
            LookupAcordByAbrev.Add("WY", 59);
            LookupAcordByAbrev.Add("AA", 60);
            LookupAcordByAbrev.Add("AE", 61);
            LookupAcordByAbrev.Add("AP", 62);
            LookupAcordByAbrev.Add("GB", 80);

            LookupAbrevByAcord = new Hashtable(TABLE_ENTRIES);
            LookupAbrevByAcord.Add(1, "AL");
            LookupAbrevByAcord.Add(2, "AK");
            LookupAbrevByAcord.Add(3, "AS");
            LookupAbrevByAcord.Add(4, "AZ");
            LookupAbrevByAcord.Add(5, "AR");
            LookupAbrevByAcord.Add(6, "CA");
            LookupAbrevByAcord.Add(7, "CO");
            LookupAbrevByAcord.Add(8, "CT");
            LookupAbrevByAcord.Add(9, "DE");
            LookupAbrevByAcord.Add(10, "DC");
            LookupAbrevByAcord.Add(11, "FS");
            LookupAbrevByAcord.Add(12, "FL");
            LookupAbrevByAcord.Add(13, "GA");
            LookupAbrevByAcord.Add(14, "GU");
            LookupAbrevByAcord.Add(15, "HI");
            LookupAbrevByAcord.Add(16, "ID");
            LookupAbrevByAcord.Add(17, "IL");
            LookupAbrevByAcord.Add(18, "IN");
            LookupAbrevByAcord.Add(19, "IA");
            LookupAbrevByAcord.Add(20, "KS");
            LookupAbrevByAcord.Add(21, "KY");
            LookupAbrevByAcord.Add(22, "LA");
            LookupAbrevByAcord.Add(23, "ME");
            LookupAbrevByAcord.Add(24, "MH");
            LookupAbrevByAcord.Add(25, "MD");
            LookupAbrevByAcord.Add(26, "MA");
            LookupAbrevByAcord.Add(27, "MI");
            LookupAbrevByAcord.Add(28, "MN");
            LookupAbrevByAcord.Add(29, "MS");
            LookupAbrevByAcord.Add(30, "MO");
            LookupAbrevByAcord.Add(31, "MT");
            LookupAbrevByAcord.Add(32, "NE");
            LookupAbrevByAcord.Add(33, "NV");
            LookupAbrevByAcord.Add(34, "NH");
            LookupAbrevByAcord.Add(35, "NJ");
            LookupAbrevByAcord.Add(36, "NM");
            LookupAbrevByAcord.Add(37, "NY");
            LookupAbrevByAcord.Add(38, "NC");
            LookupAbrevByAcord.Add(39, "ND");
            LookupAbrevByAcord.Add(40, "MP");
            LookupAbrevByAcord.Add(41, "OH");
            LookupAbrevByAcord.Add(42, "OK");
            LookupAbrevByAcord.Add(43, "OR");
            LookupAbrevByAcord.Add(44, "PW");
            LookupAbrevByAcord.Add(45, "PA");
            LookupAbrevByAcord.Add(46, "PR");
            LookupAbrevByAcord.Add(47, "RI");
            LookupAbrevByAcord.Add(48, "SC");
            LookupAbrevByAcord.Add(49, "SD");
            LookupAbrevByAcord.Add(50, "TN");
            LookupAbrevByAcord.Add(51, "TX");
            LookupAbrevByAcord.Add(52, "UT");
            LookupAbrevByAcord.Add(53, "VT");
            LookupAbrevByAcord.Add(54, "VI");
            LookupAbrevByAcord.Add(55, "VA");
            LookupAbrevByAcord.Add(56, "WA");
            LookupAbrevByAcord.Add(57, "WV");
            LookupAbrevByAcord.Add(58, "WI");
            LookupAbrevByAcord.Add(59, "WY");
            LookupAbrevByAcord.Add(60, "AA");
            LookupAbrevByAcord.Add(61, "AE");
            LookupAbrevByAcord.Add(62, "AP");
            LookupAbrevByAcord.Add(80, "GB");

            LookupNameByAcord = new Hashtable(TABLE_ENTRIES);
            LookupNameByAcord.Add(0, "Unknown");
            LookupNameByAcord.Add(1, "Alabama");
            LookupNameByAcord.Add(2, "Alaska");
            LookupNameByAcord.Add(3, "American Samoa");
            LookupNameByAcord.Add(4, "Arizona");
            LookupNameByAcord.Add(5, "Arkansas");
            LookupNameByAcord.Add(6, "California");
            LookupNameByAcord.Add(7, "Colorado");
            LookupNameByAcord.Add(8, "Connecticut");
            LookupNameByAcord.Add(9, "Delaware");
            LookupNameByAcord.Add(10, "District of Columbia");
            LookupNameByAcord.Add(12, "Florida");
            LookupNameByAcord.Add(13, "Georgia");
            LookupNameByAcord.Add(14, "Guam");
            LookupNameByAcord.Add(15, "Hawaii");
            LookupNameByAcord.Add(16, "Idaho");
            LookupNameByAcord.Add(17, "Illinois");
            LookupNameByAcord.Add(18, "Indiana");
            LookupNameByAcord.Add(19, "Iowa");
            LookupNameByAcord.Add(20, "Kansas");
            LookupNameByAcord.Add(21, "Kentucky");
            LookupNameByAcord.Add(22, "Louisiana");
            LookupNameByAcord.Add(23, "Maine");
            LookupNameByAcord.Add(25, "Maryland");
            LookupNameByAcord.Add(26, "Massachusetts");
            LookupNameByAcord.Add(27, "Michigan");
            LookupNameByAcord.Add(28, "Minnesota");
            LookupNameByAcord.Add(29, "Mississippi");
            LookupNameByAcord.Add(30, "Missouri");
            LookupNameByAcord.Add(31, "Montana");
            LookupNameByAcord.Add(32, "Nebraska");
            LookupNameByAcord.Add(33, "Nevada");
            LookupNameByAcord.Add(34, "New Hampshire");
            LookupNameByAcord.Add(35, "New Jersey");
            LookupNameByAcord.Add(36, "New Mexico");
            LookupNameByAcord.Add(37, "New York");
            LookupNameByAcord.Add(38, "North Carolina");
            LookupNameByAcord.Add(39, "North Dakota");
            LookupNameByAcord.Add(40, "Northern Mariana Islands");
            LookupNameByAcord.Add(41, "Ohio");
            LookupNameByAcord.Add(42, "Oklahoma");
            LookupNameByAcord.Add(43, "Oregon");
            LookupNameByAcord.Add(45, "Pennsylvania");
            LookupNameByAcord.Add(46, "Puerto Rico");
            LookupNameByAcord.Add(47, "Rhode Island");
            LookupNameByAcord.Add(48, "South Carolina");
            LookupNameByAcord.Add(49, "South Dakota");
            LookupNameByAcord.Add(50, "Tennessee");
            LookupNameByAcord.Add(51, "Texas");
            LookupNameByAcord.Add(52, "Utah");
            LookupNameByAcord.Add(53, "Vermont");
            LookupNameByAcord.Add(54, "Virgin Islands");
            LookupNameByAcord.Add(55, "Virginia");
            LookupNameByAcord.Add(56, "Washington");
            LookupNameByAcord.Add(57, "West Virginia");
            LookupNameByAcord.Add(58, "Wisconsin");
            LookupNameByAcord.Add(59, "Wyoming");
            LookupNameByAcord.Add(60, "Armed Forces Americas (except Canada)");
            LookupNameByAcord.Add(61, "Armed Forces Canada, Africa, Europe, Middle East");
            LookupNameByAcord.Add(62, "US Armed Forces Pacific");
            LookupNameByAcord.Add(80, "Guantanamo Bay (US Naval Base) Cuba");

            LookupNameByAbrev = new Hashtable(TABLE_ENTRIES);
            LookupNameByAbrev.Add("AL", "Alabama");
            LookupNameByAbrev.Add("AK", "Alaska");
            LookupNameByAbrev.Add("AS", "American Samoa");
            LookupNameByAbrev.Add("AZ", "Arizona");
            LookupNameByAbrev.Add("AR", "Arkansas");
            LookupNameByAbrev.Add("CA", "California");
            LookupNameByAbrev.Add("CO", "Colorado");
            LookupNameByAbrev.Add("CT", "Connecticut");
            LookupNameByAbrev.Add("DE", "Delaware");
            LookupNameByAbrev.Add("DC", "District of Columbia");
            LookupNameByAbrev.Add("FL", "Florida");
            LookupNameByAbrev.Add("GA", "Georgia");
            LookupNameByAbrev.Add("GU", "Guam");
            LookupNameByAbrev.Add("HI", "Hawaii");
            LookupNameByAbrev.Add("ID", "Idaho");
            LookupNameByAbrev.Add("IL", "Illinois");
            LookupNameByAbrev.Add("IN", "Indiana");
            LookupNameByAbrev.Add("IA", "Iowa");
            LookupNameByAbrev.Add("KS", "Kansas");
            LookupNameByAbrev.Add("KY", "Kentucky");
            LookupNameByAbrev.Add("LA", "Louisiana");
            LookupNameByAbrev.Add("ME", "Maine");
            LookupNameByAbrev.Add("MD", "Maryland");
            LookupNameByAbrev.Add("MA", "Massachusetts");
            LookupNameByAbrev.Add("MI", "Michigan");
            LookupNameByAbrev.Add("MN", "Minnesota");
            LookupNameByAbrev.Add("MS", "Mississippi");
            LookupNameByAbrev.Add("MO", "Missouri");
            LookupNameByAbrev.Add("MT", "Montana");
            LookupNameByAbrev.Add("NE", "Nebraska");
            LookupNameByAbrev.Add("NV", "Nevada");
            LookupNameByAbrev.Add("NH", "New Hampshire");
            LookupNameByAbrev.Add("NJ", "New Jersey");
            LookupNameByAbrev.Add("NM", "New Mexico");
            LookupNameByAbrev.Add("NY", "New York");
            LookupNameByAbrev.Add("NC", "North Carolina");
            LookupNameByAbrev.Add("ND", "North Dakota");
            LookupNameByAbrev.Add("MP", "Northern Mariana Islands");
            LookupNameByAbrev.Add("OH", "Ohio");
            LookupNameByAbrev.Add("OK", "Oklahoma");
            LookupNameByAbrev.Add("OR", "Oregon");
            LookupNameByAbrev.Add("PA", "Pennsylvania");
            LookupNameByAbrev.Add("PR", "Puerto Rico");
            LookupNameByAbrev.Add("RI", "Rhode Island");
            LookupNameByAbrev.Add("SC", "South Carolina");
            LookupNameByAbrev.Add("SD", "South Dakota");
            LookupNameByAbrev.Add("TN", "Tennessee");
            LookupNameByAbrev.Add("TX", "Texas");
            LookupNameByAbrev.Add("UT", "Utah");
            LookupNameByAbrev.Add("VT", "Vermont");
            LookupNameByAbrev.Add("VI", "Virgin Islands");
            LookupNameByAbrev.Add("VA", "Virginia");
            LookupNameByAbrev.Add("WA", "Washington");
            LookupNameByAbrev.Add("WV", "West Virginia");
            LookupNameByAbrev.Add("WI", "Wisconsin");
            LookupNameByAbrev.Add("WY", "Wyoming");
            LookupNameByAbrev.Add("AA", "Armed Forces Americas (except Canada)");
            LookupNameByAbrev.Add("AE", "Armed Forces Canada, Africa, Europe, Middle East");
            LookupNameByAbrev.Add("AP", "US Armed Forces Pacific");
            LookupNameByAbrev.Add("GB", "Guantanamo Bay (US Naval Base) Cuba");
            LookupCountryByAcord = new Hashtable(250);
            LookupCountryByAcord.Add(0, "Unknown");
            LookupCountryByAcord.Add(1, "United States of America");
            LookupCountryByAcord.Add(1001, "Anguilla");
            LookupCountryByAcord.Add(1002, "Panama (also known as Canal Zone)");
            LookupCountryByAcord.Add(1003, "Cote d Ivoire");
            LookupCountryByAcord.Add(1004, "Eritrea");
            LookupCountryByAcord.Add(1005, "Kazakhstan");
            LookupCountryByAcord.Add(1006, "Kyrgyzstan");
            LookupCountryByAcord.Add(1007, "Cocos (Keeling) Islands");
            LookupCountryByAcord.Add(1008, "Mongolia");
            LookupCountryByAcord.Add(1009, "Bouvet Island");
            LookupCountryByAcord.Add(1010, "Seychelles");
            LookupCountryByAcord.Add(1011, "British Indian Ocean Territory");
            LookupCountryByAcord.Add(1013, "Samoa");
            LookupCountryByAcord.Add(1014, "Timor-Leste");
            LookupCountryByAcord.Add(1015, "French Southern Territories");
            LookupCountryByAcord.Add(1016, "Heard Island and McDonald Islands");
            LookupCountryByAcord.Add(1017, "Mayotte");
            LookupCountryByAcord.Add(1018, "Pitcairn");
            LookupCountryByAcord.Add(1019, "Svalbard and Jan Mayen");
            LookupCountryByAcord.Add(1020, "Tokelau");
            LookupCountryByAcord.Add(1021, "United States Minor Outlying Islands");
            LookupCountryByAcord.Add(1022, "Western Sahara");
            LookupCountryByAcord.Add(1023, "Maldives");
            LookupCountryByAcord.Add(1024, "Christmas Island");
            LookupCountryByAcord.Add(1025, "Norfolk Island");
            LookupCountryByAcord.Add(1027, "Congo");
            LookupCountryByAcord.Add(1028, "Monaco");
            LookupCountryByAcord.Add(1029, "Holy See (Vatican City State)");
            LookupCountryByAcord.Add(1031, "Swaziland");
            LookupCountryByAcord.Add(1032, "Palestinian Territory, Occupied");
            LookupCountryByAcord.Add(2, "Canada");
            LookupCountryByAcord.Add(20, "Egypt");
            LookupCountryByAcord.Add(212, "Morocco");
            LookupCountryByAcord.Add(213, "Algeria");
            LookupCountryByAcord.Add(2147483647, "Other");
            LookupCountryByAcord.Add(216, "Tunisia");
            LookupCountryByAcord.Add(218, "Libyan Arab Jamahiriya");
            LookupCountryByAcord.Add(220, "Gambia");
            LookupCountryByAcord.Add(221, "Senegal");
            LookupCountryByAcord.Add(222, "Mauritania");
            LookupCountryByAcord.Add(223, "Mali");
            LookupCountryByAcord.Add(224, "Guinea");
            LookupCountryByAcord.Add(226, "Burkina Faso");
            LookupCountryByAcord.Add(227, "Niger");
            LookupCountryByAcord.Add(228, "Togo");
            LookupCountryByAcord.Add(229, "Benin");
            LookupCountryByAcord.Add(230, "Mauritius");
            LookupCountryByAcord.Add(231, "Liberia");
            LookupCountryByAcord.Add(232, "Sierra Leone");
            LookupCountryByAcord.Add(233, "Ghana");
            LookupCountryByAcord.Add(234, "Nigeria");
            LookupCountryByAcord.Add(235, "Chad");
            LookupCountryByAcord.Add(236, "Central African Republic");
            LookupCountryByAcord.Add(237, "Cameroon");
            LookupCountryByAcord.Add(238, "Cape Verde");
            LookupCountryByAcord.Add(239, "Sao Tome and Principe");
            LookupCountryByAcord.Add(240, "Equatorial Guinea");
            LookupCountryByAcord.Add(241, "Gabon");
            LookupCountryByAcord.Add(242, "Bahamas");
            LookupCountryByAcord.Add(244, "Angola");
            LookupCountryByAcord.Add(246, "Barbados");
            LookupCountryByAcord.Add(249, "Sudan");
            LookupCountryByAcord.Add(250, "Rwanda");
            LookupCountryByAcord.Add(251, "Ethiopia");
            LookupCountryByAcord.Add(252, "Somalia");
            LookupCountryByAcord.Add(253, "Djibouti");
            LookupCountryByAcord.Add(254, "Kenya");
            LookupCountryByAcord.Add(255, "Tanzania, United Republic of");
            LookupCountryByAcord.Add(256, "Uganda");
            LookupCountryByAcord.Add(257, "Burundi");
            LookupCountryByAcord.Add(258, "Mozambique");
            LookupCountryByAcord.Add(260, "Zambia");
            LookupCountryByAcord.Add(261, "Madagascar");
            LookupCountryByAcord.Add(262, "Reunion");
            LookupCountryByAcord.Add(263, "Zimbabwe");
            LookupCountryByAcord.Add(264, "Namibia");
            LookupCountryByAcord.Add(265, "Malawi");
            LookupCountryByAcord.Add(266, "Lesotho");
            LookupCountryByAcord.Add(267, "Botswana");
            LookupCountryByAcord.Add(268, "Antigua and Barbuda");
            LookupCountryByAcord.Add(269, "Comoros");
            LookupCountryByAcord.Add(27, "South Africa");
            LookupCountryByAcord.Add(270, "Guinea-Bissau");
            LookupCountryByAcord.Add(271, "Congo, the Democratic Republic of the");
            LookupCountryByAcord.Add(284, "Virgin Islands, British");
            LookupCountryByAcord.Add(290, "Saint Helena");
            LookupCountryByAcord.Add(297, "Aruba");
            LookupCountryByAcord.Add(298, "Faroe Islands");
            LookupCountryByAcord.Add(299, "Greenland");
            LookupCountryByAcord.Add(30, "Greece");
            LookupCountryByAcord.Add(31, "Netherlands");
            LookupCountryByAcord.Add(32, "Belgium");
            LookupCountryByAcord.Add(33, "France");
            LookupCountryByAcord.Add(34, "Spain");
            LookupCountryByAcord.Add(345, "Cayman Islands");
            LookupCountryByAcord.Add(350, "Gilbratar");
            LookupCountryByAcord.Add(351, "Portugal");
            LookupCountryByAcord.Add(352, "Luxembourg");
            LookupCountryByAcord.Add(353, "Ireland");
            LookupCountryByAcord.Add(354, "Iceland");
            LookupCountryByAcord.Add(355, "Albania");
            LookupCountryByAcord.Add(356, "Malta");
            LookupCountryByAcord.Add(357, "Cyprus");
            LookupCountryByAcord.Add(358, "Finland");
            LookupCountryByAcord.Add(359, "Bulgaria");
            LookupCountryByAcord.Add(36, "Hungary");
            LookupCountryByAcord.Add(360, "Guernsey");
            LookupCountryByAcord.Add(370, "Lithuania");
            LookupCountryByAcord.Add(371, "Latvia");
            LookupCountryByAcord.Add(372, "Estonia");
            LookupCountryByAcord.Add(373, "Moldova, Republic of");
            LookupCountryByAcord.Add(374, "Armenia");
            LookupCountryByAcord.Add(375, "Belarus");
            LookupCountryByAcord.Add(376, "Andorra");
            LookupCountryByAcord.Add(378, "San Marino");
            LookupCountryByAcord.Add(38, "Yugoslavia");
            LookupCountryByAcord.Add(380, "Ukraine");
            LookupCountryByAcord.Add(385, "Croatia");
            LookupCountryByAcord.Add(386, "Slovenia");
            LookupCountryByAcord.Add(387, "Bosnia and Herzegovina");
            LookupCountryByAcord.Add(389, "Macedonia, The Former Yugoslav Republic of");
            LookupCountryByAcord.Add(39, "Italy");
            LookupCountryByAcord.Add(40, "Romania");
            LookupCountryByAcord.Add(41, "Switzerland");
            LookupCountryByAcord.Add(420, "Czech Republic");
            LookupCountryByAcord.Add(421, "Slovakia");
            LookupCountryByAcord.Add(423, "Liechtenstein");
            LookupCountryByAcord.Add(43, "Austria");
            LookupCountryByAcord.Add(44, "United Kingdom");
            LookupCountryByAcord.Add(441, "Bermuda");
            LookupCountryByAcord.Add(45, "Denmark");
            LookupCountryByAcord.Add(46, "Sweden");
            LookupCountryByAcord.Add(47, "Norway");
            LookupCountryByAcord.Add(473, "Grenada");
            LookupCountryByAcord.Add(48, "Poland");
            LookupCountryByAcord.Add(49, "Germany");
            LookupCountryByAcord.Add(500, "Falkland Islands (Malvinas)");
            LookupCountryByAcord.Add(501, "Belize");
            LookupCountryByAcord.Add(502, "Guatemala");
            LookupCountryByAcord.Add(503, "El Salvador");
            LookupCountryByAcord.Add(504, "Honduras");
            LookupCountryByAcord.Add(505, "Nicaragua");
            LookupCountryByAcord.Add(506, "Costa Rica");
            LookupCountryByAcord.Add(508, "Saint Pierre and Miquelon");
            LookupCountryByAcord.Add(509, "Haiti");
            LookupCountryByAcord.Add(51, "Peru");
            LookupCountryByAcord.Add(510, "Puerto Rico");
            LookupCountryByAcord.Add(511, "Virgin Islands, US");
            LookupCountryByAcord.Add(512, "South Georgia and the South Sandwich Islands");
            LookupCountryByAcord.Add(52, "Mexico");
            LookupCountryByAcord.Add(53, "Cuba");
            LookupCountryByAcord.Add(54, "Argentina");
            LookupCountryByAcord.Add(55, "Brazil");
            LookupCountryByAcord.Add(56, "Chile");
            LookupCountryByAcord.Add(57, "Colombia");
            LookupCountryByAcord.Add(58, "Venezuela");
            LookupCountryByAcord.Add(590, "Guadeloupe");
            LookupCountryByAcord.Add(591, "Bolivia");
            LookupCountryByAcord.Add(592, "Guyana");
            LookupCountryByAcord.Add(593, "Ecuador");
            LookupCountryByAcord.Add(594, "French Guiana");
            LookupCountryByAcord.Add(595, "Paraguay");
            LookupCountryByAcord.Add(596, "Martinique");
            LookupCountryByAcord.Add(597, "Suriname");
            LookupCountryByAcord.Add(598, "Uruguay");
            LookupCountryByAcord.Add(599, "Netherlands Antilles");
            LookupCountryByAcord.Add(60, "Malaysia");
            LookupCountryByAcord.Add(61, "Australia");
            LookupCountryByAcord.Add(62, "Indonesia");
            LookupCountryByAcord.Add(63, "Philippines");
            LookupCountryByAcord.Add(64, "New Zealand");
            LookupCountryByAcord.Add(649, "Turks and Caicos Islands");
            LookupCountryByAcord.Add(65, "Singapore");
            LookupCountryByAcord.Add(66, "Thailand");
            LookupCountryByAcord.Add(664, "Montserrat");
            LookupCountryByAcord.Add(671, "Guam");
            LookupCountryByAcord.Add(672, "Antarctica");
            LookupCountryByAcord.Add(673, "Brunei Darussalam");
            LookupCountryByAcord.Add(674, "Nauru");
            LookupCountryByAcord.Add(675, "Papua New Guinea");
            LookupCountryByAcord.Add(676, "Tonga");
            LookupCountryByAcord.Add(677, "Solomon Islands");
            LookupCountryByAcord.Add(678, "Vanuatu");
            LookupCountryByAcord.Add(679, "Fiji");
            LookupCountryByAcord.Add(681, "Wallis and Futuna");
            LookupCountryByAcord.Add(682, "Cook Islands");
            LookupCountryByAcord.Add(683, "Niue");
            LookupCountryByAcord.Add(684, "American Samoa");
            LookupCountryByAcord.Add(686, "Kiribati");
            LookupCountryByAcord.Add(687, "New Caledonia");
            LookupCountryByAcord.Add(688, "Tuvalu");
            LookupCountryByAcord.Add(689, "French Polynesia");
            LookupCountryByAcord.Add(693, "Palau");
            LookupCountryByAcord.Add(694, "Marshall Islands");
            LookupCountryByAcord.Add(695, "Micronesia, Federated States of");
            LookupCountryByAcord.Add(7, "Russian Federation");
            LookupCountryByAcord.Add(758, "Saint Lucia");
            LookupCountryByAcord.Add(767, "Dominica");
            LookupCountryByAcord.Add(784, "Saint Vincent and the Grenadines");
            LookupCountryByAcord.Add(809, "Dominican Republic");
            LookupCountryByAcord.Add(81, "Japan");
            LookupCountryByAcord.Add(84, "Viet Nam");
            LookupCountryByAcord.Add(852, "Hong Kong");
            LookupCountryByAcord.Add(853, "Macao");
            LookupCountryByAcord.Add(855, "Cambodia");
            LookupCountryByAcord.Add(856, "Lao Peoples Democratic Republic");
            LookupCountryByAcord.Add(86, "China");
            LookupCountryByAcord.Add(868, "Trinidad and Tobago");
            LookupCountryByAcord.Add(869, "Saint Kitts and Nevis");
            LookupCountryByAcord.Add(876, "Jamaica");
            LookupCountryByAcord.Add(880, "Bangladesh");
            LookupCountryByAcord.Add(886, "Taiwan, Province of China");
            LookupCountryByAcord.Add(90, "Turkey");
            LookupCountryByAcord.Add(91, "India");
            LookupCountryByAcord.Add(92, "Pakistan");
            LookupCountryByAcord.Add(93, "Afghanistan");
            LookupCountryByAcord.Add(94, "Sri Lanka");
            LookupCountryByAcord.Add(950, "Myanmar");
            LookupCountryByAcord.Add(951, "Korea, Republic of");
            LookupCountryByAcord.Add(952, "Korea, Democratic Peoples Republic of");
            LookupCountryByAcord.Add(961, "Lebanon");
            LookupCountryByAcord.Add(962, "Jordan");
            LookupCountryByAcord.Add(963, "Syrian Arab Republic");
            LookupCountryByAcord.Add(964, "Iraq");
            LookupCountryByAcord.Add(965, "Kuwait");
            LookupCountryByAcord.Add(966, "Saudi Arabia");
            LookupCountryByAcord.Add(967, "Yemen");
            LookupCountryByAcord.Add(968, "Oman");
            LookupCountryByAcord.Add(971, "United Arab Emirates");
            LookupCountryByAcord.Add(972, "Israel");
            LookupCountryByAcord.Add(973, "Bahrain");
            LookupCountryByAcord.Add(974, "Qatar");
            LookupCountryByAcord.Add(975, "Bhutan");
            LookupCountryByAcord.Add(977, "Nepal");
            LookupCountryByAcord.Add(98, "Iran, Islamic Republic of");
            LookupCountryByAcord.Add(992, "Tajikistan");
            LookupCountryByAcord.Add(993, "Turkmenistan");
            LookupCountryByAcord.Add(994, "Azerbaijan");
            LookupCountryByAcord.Add(995, "Georgia");
            LookupCountryByAcord.Add(998, "Uzbekistan");
        }
    }
}
