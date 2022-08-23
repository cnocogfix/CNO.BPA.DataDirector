using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CNO.BPA.DataHandler
{
    [Serializable()]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [GuidAttribute("5A1BA75D-AC21-451d-A5A6-99CBB7A03022")]
    public class CommonParameters : ISerializable
    {
        #region Variables
        //datasets
        public DataSet _datasetResults = null;
        public MVIFieldData _MVIFieldData = new MVIFieldData();
        //constants
        //path change to C:\Users\COGFIX\AppData\Local\Emc\InputAccel\Custom\Bin
         public string CONFIG_PATH = Environment.GetFolderPath(Environment
        .SpecialFolder.LocalApplicationData) +@"\Emc\InputAccel\Custom\Bin\";
       // public string CONFIG_PATH = Environment.GetFolderPath(Environment
       //.SpecialFolder.LocalApplicationData) +@"\Emc\InputAccel\Custom\Bin\";
        //booleans
        private bool _isBundleNeeded = false;
        private bool _isCancelled = false;
        private bool _isContinued = false;
        private bool _isSearchNeeded = false;
        private bool _isValidTOB = false;
        private bool _isPopCodeFound = false;
        private bool _rememberCertifiedNo = false;
        private bool _rememberBusinessArea = false;
        private bool _rememberWorkType = false;

        private bool _trackUser = false;
        private bool _trackPerformance = false;
        //integers
        private int _AWDCaseID = 0;
        private int _AWDPriority = 0;
        private int _AWDRequestID = 0;
        private int _AWDSourceID = 0;
        private int _AWDTranID = 0;
        private int _AWDCaseIDPrevious = 0;
        private int _AWDRequestIDPrevious = 0;
        private int _AWDTranIDPrevious = 0;
        private int _BatchItemID = 0;
        private int _DDItemSeq = 0;
        private int _DDItemSeqPrevious = 0;
        private int _DocustreamRequestID = 0;
        private int _FORequestID = 0;        
        private int _InvoiceRequestID = 0;        
        private int _TPRequestID = 0;
        private int _ImgCount = 0;
        private int _Priority = 0;
        private int _Validation = 0;
        //strings
        private string _AccountNumber = String.Empty;
        private string _acordType = String.Empty;
        private string _Address1 = String.Empty;
        private string _Address2 = String.Empty;
        private string _Address3 = String.Empty;
        private string _Address4 = String.Empty;
        private string _AgentAddress1 = String.Empty;
        private string _AgentAddress2 = String.Empty;
        private string _AgentAddress3 = String.Empty;
        private string _AgentAddress4 = String.Empty;
        private string _AgentBirthDate = String.Empty;
        private string _AgentCity = String.Empty;
        private string _AgentName = String.Empty;
        private string _AgentNo = String.Empty;
        private string _AgentPhone = String.Empty;
        private string _AgentSSN = "0";
        private string _AgentState = String.Empty;
        private string _AgentZip = String.Empty;
        private string _AgentZip4 = String.Empty;
        private string _alteredQuestion = String.Empty;
        private string _ApplicationNo = String.Empty;
        private string _AWDSourceType = String.Empty;
        private string _AWDStatus = String.Empty;
        private string _BatchNo = String.Empty;
        private string _birthDate = String.Empty;
        private string _blankBacks = String.Empty;
        private string _boxNo = String.Empty;
        private string _bundleNo = String.Empty;
        private string _bridgeEnabled = "T";
        private string _businessArea = String.Empty;
        private string _caseWorkType = String.Empty;
        private string _cashAmount = String.Empty;
        private string _certificateNo = String.Empty;
        private string _certifiedNo = String.Empty;
        private string _checkAmount = String.Empty;
        private string _checkNo = String.Empty;
        private string _city = String.Empty;
        private string _classOperator = String.Empty;
        private string _companyCode = String.Empty;
        private string _CompanyCodeBICPS = String.Empty;
        private string _companyNo = String.Empty;
        private string _contestable = String.Empty;
        private string _controlNo = String.Empty;
        private string _controlNoMaster = String.Empty;
        private string _controlYear = String.Empty;
        private string _corpTaxId = String.Empty;
        private string _CostCenter = String.Empty;
        private string _countHCFA = "0";
        private string _countUB92 = "0";
        private string _countPHEOMB = "0";
        private string _countEOMB = "0";
        private string _countAttachment = "0";
        private string _country = String.Empty;
        private string _custId = String.Empty;
        private string _CustomerAccount = String.Empty;
        private string _Custom1 = String.Empty;
        private string _Custom1Name = String.Empty;
        private string _Custom2 = String.Empty;
        private string _Custom2Name = String.Empty;
        private string _Custom3 = String.Empty;
        private string _Custom3Name = String.Empty;
        private string _Custom4 = String.Empty;
        private string _Custom4Name = String.Empty;
        private string _Custom5 = String.Empty;
        private string _Custom5Name = String.Empty;
        private string _Custom6 = String.Empty;
        private string _Custom6Name = String.Empty;
        private string _Custom7 = String.Empty;
        private string _Custom7Name = String.Empty;
        private string _Custom8 = String.Empty;
        private string _Custom8Name = String.Empty;
        private string _Custom9 = String.Empty;
        private string _Custom9Name = String.Empty;
        private string _Custom10 = String.Empty;
        private string _Custom10Name = String.Empty;
        private string _Custom11 = String.Empty;
        private string _Custom11Name = String.Empty;
        private string _Custom12 = String.Empty;
        private string _Custom12Name = String.Empty;
        private string _Custom13 = String.Empty;
        private string _Custom13Name = String.Empty;
        private string _Custom14 = String.Empty;
        private string _Custom14Name = String.Empty;
        private string _Custom15 = String.Empty;
        private string _Custom15Name = String.Empty;
        private string _Custom16 = String.Empty;
        private string _Custom16Name = String.Empty;
        private string _Custom17 = String.Empty;
        private string _Custom17Name = String.Empty;
        private string _Custom18 = String.Empty;
        private string _Custom18Name = String.Empty;
        private string _Custom19 = String.Empty;
        private string _Custom19Name = String.Empty;
        private string _Custom20 = String.Empty;
        private string _Custom20Name = String.Empty;
        private string _CustomReq1 = String.Empty;
        private string _CustomReq1Name = String.Empty;
        private string _CustomReq2 = String.Empty;
        private string _CustomReq2Name = String.Empty;
        private string _CustomReq3 = String.Empty;
        private string _CustomReq3Name = String.Empty;
        private string _CustomReq4 = String.Empty;
        private string _CustomReq4Name = String.Empty;
        private string _CustomReq5 = String.Empty;
        private string _CustomReq5Name = String.Empty;
        private string _CustomReq6 = String.Empty;
        private string _CustomReq6Name = String.Empty;
        private string _Description = String.Empty;
        private string _Description2 = String.Empty;
        private string _DocClassName = String.Empty;
        private string _DocType = String.Empty;
        private string _docTypeOrig = String.Empty;
        private string _DocustreamCode = String.Empty;
        private string _EFTI = String.Empty;
        private string _effectiveDate = String.Empty;
        private string _emailDate = String.Empty;
        private string _emailId = String.Empty;
        private string _emailTo = String.Empty;
        private string _emailSender = String.Empty;        
        private string _externalItemID = String.Empty;
        private string _faxAccount = String.Empty;
        private string _faxFrom = String.Empty;
        private string _faxID = String.Empty;
        private string _faxServer = String.Empty;
        private string _faxTo = String.Empty;
        private string _firstName = String.Empty;
        private string _FisDocID = String.Empty;
        private string _FNP8_AREA = String.Empty;
        private string _FNP8_AUTODECLARE = String.Empty;
        private string _FNP8_AUTOSYNCPROPS = String.Empty;
        private string _FNP8_DOCCLASSNAME = String.Empty;
        private string _FNP8_FOLDER = String.Empty;
        private string _FNP8_OBJECTSTORE = String.Empty;
        private string _FNP8_RECORDFILEDIN = String.Empty;
        private string _FNP8_RECORDCLASSNAME = String.Empty;
        private string _FNP8_SUBACTIVITY = String.Empty;
        private string _FNP8_SUBFUNCTION = String.Empty;
        private string _FormName = String.Empty;
        private string _FullName = String.Empty;
        private string _glCompanyCode = String.Empty;
        private string _GroupID = String.Empty;
        private string _GroupNo = String.Empty;
        private string _GroupName = String.Empty;
        private string _HolderNumber = String.Empty;
        private string _HolderNumberIsValid = String.Empty;
        private string _ID = String.Empty;
        private string _indexOperator = String.Empty;
        private string _indexType = String.Empty;
        private string _inputSource = String.Empty;
        private string _InvoiceDate = String.Empty;
        private string _InvoiceDescription = String.Empty;
        private string _InvoiceNumber = String.Empty;
        private string _InvoiceType = String.Empty;
        private string _InvoiceTotal = String.Empty;
        private string _issueCountry = String.Empty;
        private string _issueDate = String.Empty;
        private string _issueState = String.Empty;
        private string _lastActivity = String.Empty;
        private string _lastName = String.Empty;
        private string _lifeProIndicator = String.Empty;
        private string _LineOfBusiness = String.Empty;
        private string _MasterGroupID = String.Empty;
        private string _masterGroupName = String.Empty;
        private string _masterGroupNo = String.Empty;
        private string _medicareId = String.Empty;
        private string _middleName = String.Empty;
        private string _moliDocType = String.Empty;
        private string _Name = String.Empty;
        private string _NameType = String.Empty;
        private string _nodeCurrent = String.Empty;
        private string _nodeEnvelope = String.Empty;
        private string _nodePrevious = String.Empty;
        private string _officeNo = String.Empty;
        private string _patientName = String.Empty;
        private string _personStatus = String.Empty;
        private string _personStatusReason = String.Empty;
        private string _Phone = String.Empty;
        private string _PhoneExtension = String.Empty;
        private string _planCode = String.Empty;
        private string _PolicyNo = String.Empty;
        private string _PONumber = String.Empty;
        private string _popCode = String.Empty;
        private string _popsPresent = String.Empty;
        private string _privacyShareOptOut = String.Empty;
        private string _privacyShare3rdPartyOptOut = String.Empty;
        private string _privacyMasterID = String.Empty;
        private string _processStep = String.Empty;
        private string _Product = String.Empty;
        private string _productCategory = String.Empty;
        private string _propertyName = String.Empty;
        private string _providerTIN = String.Empty;
        private string _provName = String.Empty;
        private string _reasonCode = String.Empty;
        private string _receivedDate = String.Empty;
        private string _receivedDateCRD = String.Empty;
        private string _rejectCode = String.Empty;
        private string _rejectOption = String.Empty;
        private string _Relationship = String.Empty;
        private string _rememberBAWT = String.Empty;
        private string _requirementID = String.Empty;
        private string _replacementIndicator = String.Empty;
        private string _replacementQuestion = String.Empty;
        private string _ReportDate = String.Empty;
        private string _routeCode = String.Empty;
        private string _ScannerID = String.Empty;
        private string _ScanDate = String.Empty;
        private string _scanOperator = String.Empty;
        private string _searchProvider = String.Empty;
        private string _searchType = String.Empty;
        private string _sex = String.Empty;
        private string _signature = String.Empty;
        private string _SiteID = String.Empty;
        private string _siteRestriction = String.Empty;
        private string _sortCode = String.Empty;
        private string _SSN = "0";
        private string _State = String.Empty;
        private string _Status = String.Empty;
        private string _statusReason = String.Empty;
        private string _SupplierNumber = String.Empty;
        private string _SupplierSite = String.Empty;
        private string _SystemID = String.Empty;
        private string _SystemNo = String.Empty;
        private string _targetSystem = String.Empty;
        private string _TaxAmount = String.Empty;
        private string _templateName = String.Empty;
        private string _terminateDate = String.Empty;
        private string _terminatedDate = String.Empty;
        private string _transType = String.Empty;
        private string _typeofBill = String.Empty;
        private string _validationMessage = String.Empty;
        private string _validationStart = String.Empty;
        private string _VendorName = String.Empty;
        private string _WorkCategory = String.Empty;
        private string _WorkType = String.Empty;
        private string _WritingAgent = String.Empty;
        private string _ZipCode = String.Empty;
        private string _ZipCode4 = String.Empty;


        #endregion
        public CommonParameters()
        {
        }
        public CommonParameters(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            _MVIFieldData = (MVIFieldData)info.GetValue("MVIFieldData", typeof(MVIFieldData));
            _BatchNo = (string)info.GetValue("BatchNo", typeof(string));
            _SiteID = (string)info.GetValue("SiteID", typeof(string));
            _WorkCategory = (string)info.GetValue("WorkCategory", typeof(string));
            _nodeEnvelope = (string)info.GetValue("nodeEnvelope", typeof(string));
            _rememberCertifiedNo = (bool)info.GetValue("rememberCertifiedNo", typeof(bool));
            _rememberBusinessArea = (bool)info.GetValue("rememberBusinessArea", typeof(bool));
            _rememberWorkType = (bool)info.GetValue("rememberWorkType", typeof(bool));
            _certifiedNo = (string)info.GetValue("certifiedNo", typeof(string));
            _businessArea = (string)info.GetValue("businessArea", typeof(string));
            _WorkType = (string)info.GetValue("WorkType", typeof(string));
            _nodeCurrent = (string)info.GetValue("nodeCurrent", typeof(string));
            _DDItemSeq = (int)info.GetValue("DDItemSeq", typeof(int));

        }

        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"
            info.AddValue("MVIFieldData", _MVIFieldData);
            info.AddValue("BatchNo", _BatchNo);
            info.AddValue("SiteID", _SiteID);
            info.AddValue("WorkCategory", _WorkCategory);
            info.AddValue("nodeEnvelope", _nodeEnvelope);
            info.AddValue("rememberCertifiedNo", _rememberCertifiedNo);
            info.AddValue("rememberBusinessArea", _rememberBusinessArea);
            info.AddValue("rememberWorkType", _rememberWorkType);
            info.AddValue("certifiedNo", _certifiedNo);
            info.AddValue("businessArea", _businessArea);
            info.AddValue("WorkType", _WorkType);
            info.AddValue("nodeCurrent", _nodeCurrent);
            info.AddValue("DDItemSeq", _DDItemSeq);
        }
        private void setName()
        {
            if (LastName.Trim().Length > 0)
            {
                _Name = LastName.Trim();
            }
            if (FirstName.Trim().Length > 0)
            {
                _Name += " " + FirstName.Trim();
            }
            _Name = _Name.Trim();
        }
        #region Public Properties
        //booleans
        [ComVisible(true)]
        public bool IsBundleNeeded
        {
            get { return _isBundleNeeded; }
            set { _isBundleNeeded = value; }
        }
        [ComVisible(true)]
        public bool IsCancelled
        {
            get { return _isCancelled; }
            set { _isCancelled = value; }
        }
        [ComVisible(true)]
        public bool IsContinued
        {
            get { return _isContinued; }
            set { _isContinued = value; }
        }
        [ComVisible(true)]
        public bool IsSearchNeeded
        {
            get { return _isSearchNeeded; }
            set { _isSearchNeeded = value; }
        }
        [ComVisible(true)]
        public bool IsValidTOB
        {
            get { return _isValidTOB; }
            set { _isValidTOB = value; }
        }
        [ComVisible(true)]
        public bool IsPopCodeFound
        {
            get { return _isPopCodeFound; }
            set { _isPopCodeFound = value; }
        }
        [ComVisible(true)]
        public bool RememberCertifiedNo
        {
            get { return _rememberCertifiedNo; }
            set { _rememberCertifiedNo = value; }
        }
        [ComVisible(true)]
        public bool RememberBusinessArea
        {
            get { return _rememberBusinessArea; }
            set { _rememberBusinessArea = value; }
        }
        [ComVisible(true)]
        public bool RememberWorkType
        {
            get { return _rememberWorkType; }
            set { _rememberWorkType = value; }
        }
        [ComVisible(true)]
        public bool TrackUser
        {
            get { return _trackUser; }
            set { _trackUser = value; }
        }
        [ComVisible(true)]
        public bool TrackPerformance
        {
            get { return _trackPerformance; }
            set { _trackPerformance = value; }
        }

        //integers
        [ComVisible(true)]
        public int AWDCaseID
        {
            get { return _AWDCaseID; }
            set { _AWDCaseID = value; }
        }
        [ComVisible(true)]
        public int AWDPriority
        {
            get { return _AWDPriority; }
            set { _AWDPriority = value; }
        }
        [ComVisible(true)]
        public int AWDRequestID
        {
            get { return _AWDRequestID; }
            set { _AWDRequestID = value; }
        }
        [ComVisible(true)]
        public int AWDSourceID
        {
            get { return _AWDSourceID; }
            set { _AWDSourceID = value; }
        }
        [ComVisible(true)]
        public int AWDTranID
        {
            get { return _AWDTranID; }
            set { _AWDTranID = value; }
        }
        [ComVisible(true)]
        public int AWDCaseIDPrevious
        {
            get { return _AWDCaseIDPrevious; }
            set { _AWDCaseIDPrevious = value; }
        }
        [ComVisible(true)]
        public int AWDRequestIDPrevious
        {
            get { return _AWDRequestIDPrevious; }
            set { _AWDRequestIDPrevious = value; }
        }
        [ComVisible(true)]
        public int AWDTranIDPrevious
        {
            get { return _AWDTranIDPrevious; }
            set { _AWDTranIDPrevious = value; }
        }
        [ComVisible(true)]
        public int DDItemSeq
        {
            get { return _DDItemSeq; }
            set { _DDItemSeq = value; }
        }
        [ComVisible(true)]
        public int DDItemSeqPrevious
        {
            get { return _DDItemSeqPrevious; }
            set { _DDItemSeqPrevious = value; }
        }
        [ComVisible(true)]
        public int DocustreamRequestID
        {
            get { return _DocustreamRequestID; }
            set { _DocustreamRequestID = value; }
        }
        [ComVisible(true)]
        public int FORequestID
        {
            get { return _FORequestID; }
            set { _FORequestID = value; }
        }        
        [ComVisible(true)]
        public int InvoiceRequestID
        {
            get { return _InvoiceRequestID; }
            set { _InvoiceRequestID = value; }
        }        
        [ComVisible(true)]
        public int TPRequestID
        {
            get { return _TPRequestID; }
            set { _TPRequestID = value; }
        }
        [ComVisible(true)]
        public int BatchItemID
        {
            get { return _BatchItemID; }
            set { _BatchItemID = value; }
        }
        [ComVisible(true)]
        public int Priority
        {
            get { return _Priority; }
            set { _Priority = value; }
        }

        //strings
        [ComVisible(true)]
        public string AcordType
        {
            get { return _acordType; }
            set { _acordType = value; }
        }
        [ComVisible(true)]
        public string AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
        }
        [ComVisible(true)]
        public string Address1
        {
            get { return _Address1; }
            set { _Address1 = value; }
        }
        [ComVisible(true)]
        public string Address2
        {
            get { return _Address2; }
            set { _Address2 = value; }
        }
        [ComVisible(true)]
        public string Address3
        {
            get { return _Address3; }
            set { _Address3 = value; }
        }
        [ComVisible(true)]
        public string Address4
        {
            get { return _Address4; }
            set { _Address4 = value; }
        }
        [ComVisible(true)]
        public string AgentAddress1
        {
            get { return _AgentAddress1; }
            set { _AgentAddress1 = value; }
        }
        [ComVisible(true)]
        public string AgentAddress2
        {
            get { return _AgentAddress2; }
            set { _AgentAddress2 = value; }
        }
        [ComVisible(true)]
        public string AgentAddress3
        {
            get { return _AgentAddress3; }
            set { _AgentAddress3 = value; }
        }
        [ComVisible(true)]
        public string AgentAddress4
        {
            get { return _AgentAddress4; }
            set { _AgentAddress4 = value; }
        }
        [ComVisible(true)]
        public string AgentBirthDate
        {
            get { return _AgentBirthDate; }
            set { _AgentBirthDate = value; }
        }
        [ComVisible(true)]
        public string AgentCity
        {
            get { return _AgentCity; }
            set { _AgentCity = value; }
        }
        [ComVisible(true)]
        public string AgentName
        {
            get { return _AgentName; }
            set { _AgentName = value; }
        }
        [ComVisible(true)]
        public string AgentNo
        {
            get { return _AgentNo; }
            set { _AgentNo = value; }
        }
        [ComVisible(true)]
        public string AgentPhone
        {
            get { return _AgentPhone; }
            set { _AgentPhone = value; }
        }
        [ComVisible(true)]
        public string AgentSSN
        {
            get { return _AgentSSN; }
            set { _AgentSSN = value; }
        }
        [ComVisible(true)]
        public string AgentState
        {
            get { return _AgentState; }
            set { _AgentState = value; }
        }
        [ComVisible(true)]
        public string AgentZip
        {
            get { return _AgentZip; }
            set { _AgentZip = value; }
        }
        [ComVisible(true)]
        public string AgentZip4
        {
            get { return _AgentZip4; }
            set { _AgentZip4 = value; }
        }
        [ComVisible(true)]
        public string AlteredQuestion
        {
            get { return _alteredQuestion; }
            set { _alteredQuestion = value; }
        }
        [ComVisible(true)]
        public string ApplicationNo
        {
            get { return _ApplicationNo; }
            set { _ApplicationNo = value; }
        }
        [ComVisible(true)]
        public string AWDSourceType
        {
            get { return _AWDSourceType; }
            set { _AWDSourceType = value; }
        }
        [ComVisible(true)]
        public string AWDStatus
        {
            get { return _AWDStatus; }
            set { _AWDStatus = value; }
        }
        [ComVisible(true)]
        public string BatchNo
        {
            get { return _BatchNo; }
            set { _BatchNo = value; }
        }
        [ComVisible(true)]
        public string BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        public string BlankBacks
        {
            get { return _blankBacks; }
            set { _blankBacks = value; }
        }
        [ComVisible(true)]
        public string BoxNo
        {
            get { return _boxNo; }
            set { _boxNo = value; }
        }
        [ComVisible(true)]
        public string BridgeEnabled
        {
            get { return _bridgeEnabled; }
            set { _bridgeEnabled = value; }
        }
        [ComVisible(true)]
        public string BundleNo
        {
            get { return _bundleNo; }
            set { _bundleNo = value; }
        }
        [ComVisible(true)]
        public string BusinessArea
        {
            get { return _businessArea; }
            set { _businessArea = value; }
        }
        [ComVisible(true)]
        public string CaseWorkType
        {
            get { return _caseWorkType; }
            set { _caseWorkType = value; }
        }
        [ComVisible(true)]
        public string CashAmount
        {
            get { return _cashAmount; }
            set { _cashAmount = value; }
        }
        [ComVisible(true)]
        public string Certificate_No
        {
            get { return _certificateNo; }
            set { _certificateNo = value; }
        }
        [ComVisible(true)]
        public string CertifiedNo
        {
            get { return _certifiedNo; }
            set { _certifiedNo = value; }
        }
        [ComVisible(true)]
        public string CheckAmount
        {
            get { return _checkAmount; }
            set { _checkAmount = value; }
        }
        [ComVisible(true)]
        public string CheckNumber
        {
            get { return _checkNo; }
            set { _checkNo = value; }
        }
        [ComVisible(true)]
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        [ComVisible(true)]
        public string ClassificationOperator
        {
            get { return _classOperator; }
            set { _classOperator = value; }
        }
        [ComVisible(true)]
        public string CompanyCode
        {
            get { return _companyCode; }
            set { _companyCode = value; }
        }
        [ComVisible(true)]
        public string CompanyCodeBICPS
        {
            get { return _CompanyCodeBICPS; }
            set { _CompanyCodeBICPS = value; }
        }
        [ComVisible(true)]
        public string CompanyNo
        {
            get { return _companyNo; }
            set { _companyNo = value; }
        }
        [ComVisible(true)]
        public string Contestable
        {
            get { return _contestable; }
            set { _contestable = value; }
        }
        [ComVisible(true)]
        public string ControlNo
        {
            get { return _controlNo; }
            set { _controlNo = value; }
        }
        [ComVisible(true)]
        public string ControlNoMaster
        {
            get { return _controlNoMaster; }
            set { _controlNoMaster = value; }
        }
        [ComVisible(true)]
        public string ControlYear
        {
            get { return _controlYear; }
            set { _controlYear = value; }
        }
        [ComVisible(true)]
        public string CorpTaxId
        {
            get { return _corpTaxId; }
            set { _corpTaxId = value; }
        }
        [ComVisible(true)]
        public string CostCenter
        {
            get { return _CostCenter; }
            set { _CostCenter = value; }
        }
        [ComVisible(true)]
        public string CountHCFA
        {
            get { return _countHCFA; }
            set { _countHCFA = value; }
        }
        [ComVisible(true)]
        public string CountUB92
        {
            get { return _countUB92; }
            set { _countUB92 = value; }
        }
        [ComVisible(true)]
        public string CountPHEOMB
        {
            get { return _countPHEOMB; }
            set { _countPHEOMB = value; }
        }
        [ComVisible(true)]
        public string CountEOMB
        {
            get { return _countEOMB; }
            set { _countEOMB = value; }
        }
        [ComVisible(true)]
        public string CountAttachment
        {
            get { return _countAttachment; }
            set { _countAttachment = value; }
        }
        [ComVisible(true)]
        public string CurrentNodeID
        {
            get { return _nodeCurrent; }
            set { _nodeCurrent = value; }
        }
        [ComVisible(true)]
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        [ComVisible(true)]
        public string CustId
        {
            get { return _custId; }
            set { _custId = value; }
        }
        [ComVisible(true)]
        public string CustomerAccount
        {
            get { return _CustomerAccount; }
            set { _CustomerAccount = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty1Name
        {
            get { return _Custom1Name; }
            set { _Custom1Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty2Name
        {
            get { return _Custom2Name; }
            set { _Custom2Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty3Name
        {
            get { return _Custom3Name; }
            set { _Custom3Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty4Name
        {
            get { return _Custom4Name; }
            set { _Custom4Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty5Name
        {
            get { return _Custom5Name; }
            set { _Custom5Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty6Name
        {
            get { return _Custom6Name; }
            set { _Custom6Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty7Name
        {
            get { return _Custom7Name; }
            set { _Custom7Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty8Name
        {
            get { return _Custom8Name; }
            set { _Custom8Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty9Name
        {
            get { return _Custom9Name; }
            set { _Custom9Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty10Name
        {
            get { return _Custom10Name; }
            set { _Custom10Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty11Name
        {
            get { return _Custom11Name; }
            set { _Custom11Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty12Name
        {
            get { return _Custom12Name; }
            set { _Custom12Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty13Name
        {
            get { return _Custom13Name; }
            set { _Custom13Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty14Name
        {
            get { return _Custom14Name; }
            set { _Custom14Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty15Name
        {
            get { return _Custom15Name; }
            set { _Custom15Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty16Name
        {
            get { return _Custom16Name; }
            set { _Custom16Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty17Name
        {
            get { return _Custom17Name; }
            set { _Custom17Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty18Name
        {
            get { return _Custom18Name; }
            set { _Custom18Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty19Name
        {
            get { return _Custom19Name; }
            set { _Custom19Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty20Name
        {
            get { return _Custom20Name; }
            set { _Custom20Name = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty1
        {
            get { return _Custom1; }
            set { _Custom1 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty2
        {
            get { return _Custom2; }
            set { _Custom2 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty3
        {
            get { return _Custom3; }
            set { _Custom3 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty4
        {
            get { return _Custom4; }
            set { _Custom4 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty5
        {
            get { return _Custom5; }
            set { _Custom5 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty6
        {
            get { return _Custom6; }
            set { _Custom6 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty7
        {
            get { return _Custom7; }
            set { _Custom7 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty8
        {
            get { return _Custom8; }
            set { _Custom8 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty9
        {
            get { return _Custom9; }
            set { _Custom9 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty10
        {
            get { return _Custom10; }
            set { _Custom10 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty11
        {
            get { return _Custom11; }
            set { _Custom11 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty12
        {
            get { return _Custom12; }
            set { _Custom12 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty13
        {
            get { return _Custom13; }
            set { _Custom13 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty14
        {
            get { return _Custom14; }
            set { _Custom14 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty15
        {
            get { return _Custom15; }
            set { _Custom15 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty16
        {
            get { return _Custom16; }
            set { _Custom16 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty17
        {
            get { return _Custom17; }
            set { _Custom17 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty18
        {
            get { return _Custom18; }
            set { _Custom18 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty19
        {
            get { return _Custom19; }
            set { _Custom19 = value; }
        }
        [ComVisible(true)]
        public string CustomIndexProperty20
        {
            get { return _Custom20; }
            set { _Custom20 = value; }
        }
        [ComVisible(true)]
        public string CustomReqIndexProperty1Name
        {
            get { return _CustomReq1Name; }
            set { _CustomReq1Name = value; }
        }
        [ComVisible(true)]
        public string CustomReqIndexProperty2Name
        {
            get { return _CustomReq2Name; }
            set { _CustomReq2Name = value; }
        }
        [ComVisible(true)]
        public string CustomReqIndexProperty3Name
        {
            get { return _CustomReq3Name; }
            set { _CustomReq3Name = value; }
        }
        [ComVisible(true)]
        public string CustomReqIndexProperty4Name
        {
            get { return _CustomReq4Name; }
            set { _CustomReq4Name = value; }
        }
        [ComVisible(true)]
        public string CustomReqIndexProperty5Name
        {
            get { return _CustomReq5Name; }
            set { _CustomReq5Name = value; }
        }
        [ComVisible(true)]
        public string CustomReqIndexProperty6Name
        {
            get { return _CustomReq6Name; }
            set { _CustomReq6Name = value; }
        }
        [ComVisible(true)]
        public string CustomReqIndexProperty1
        {
            get { return _CustomReq1; }
            set { _CustomReq1 = value; }
        }
        [ComVisible(true)]
        public string CustomReqIndexProperty2
        {
            get { return _CustomReq2; }
            set { _CustomReq2 = value; }
        }
        [ComVisible(true)]
        public string CustomReqIndexProperty3
        {
            get { return _CustomReq3; }
            set { _CustomReq3 = value; }
        }
        [ComVisible(true)]
        public string CustomReqIndexProperty4
        {
            get { return _CustomReq4; }
            set { _CustomReq4 = value; }
        }
        [ComVisible(true)]
        public string CustomReqIndexProperty5
        {
            get { return _CustomReq5; }
            set { _CustomReq5 = value; }
        }
        [ComVisible(true)]
        public string CustomReqIndexProperty6
        {
            get { return _CustomReq6; }
            set { _CustomReq6 = value; }
        }
        [ComVisible(true)]
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        [ComVisible(true)]
        public string Description2
        {
            get { return _Description2; }
            set { _Description2 = value; }
        }
        [ComVisible(true)]
        public string DocType
        {
            get { return _DocType; }
            set { _DocType = value; }
        }
        [ComVisible(true)]
        public string DocTypeOrig
        {
            get { return _docTypeOrig; }
            set { _docTypeOrig = value; }
        }
        [ComVisible(true)]
        public string DocustreamCode
        {
            get { return _DocustreamCode; }
            set { _DocustreamCode = value; }
        }
        [ComVisible(true)]
        public string EFTI
        {
            get { return _EFTI; }
            set { _EFTI = value; }
        }
        [ComVisible(true)]
        public string EffectiveDate
        {
            get { return _effectiveDate; }
            set { _effectiveDate = value; }
        }
        [ComVisible(true)]
        public string EmailDate
        {
            get { return _emailDate; }
            set { _emailDate = value; }
        }
        [ComVisible(true)]
        public string EmailID
        {
            get { return _emailId; }
            set { _emailId = value; }
        }
        [ComVisible(true)]
        public string EmailTo
        {
            get { return _emailTo; }
            set { _emailTo = value; }
        }
        [ComVisible(true)]
        public string EmailSender
        {
            get { return _emailSender; }
            set { _emailSender = value; }
        }        
        [ComVisible(true)]
        public string EnvelopeNodeID
        {
            get { return _nodeEnvelope; }
            set { _nodeEnvelope = value; }
        }
        [ComVisible(true)]
        public string ExternalItemID
        {
            get { return _externalItemID; }
            set { _externalItemID = value; }
        }
        [ComVisible(true)]
        public string FaxAccount
        {
            get { return _faxAccount; }
            set { _faxAccount = value; }
        }
        [ComVisible(true)]
        public string FaxID
        {
            get { return _faxID; }
            set { _faxID = value; }
        }
        [ComVisible(true)]
        public string FaxFrom
        {
            get { return _faxFrom; }
            set { _faxFrom = value; }
        }
        [ComVisible(true)]
        public string FaxTo
        {
            get { return _faxTo; }
            set { _faxTo = value; }
        }
        [ComVisible(true)]
        public string FaxServer
        {
            get { return _faxServer; }
            set { _faxServer = value; }
        }
        [ComVisible(true)]
        public string FDocClassName
        {
            get { return _DocClassName; }
            set { _DocClassName = value; }
        }
        [ComVisible(true)]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                setName();
            }
        }
        [ComVisible(true)]
        public string FisDocID
        {
            get { return _FisDocID; }
            set { _FisDocID = value; }
        }
        [ComVisible(true)]
        public string FNP8_DOCCLASSNAME
        {
            get { return _FNP8_DOCCLASSNAME; }
            set { _FNP8_DOCCLASSNAME = value; }
        }
        [ComVisible(true)]
        public string FNP8_OBJECTSTORE
        {
            get { return _FNP8_OBJECTSTORE; }
            set { _FNP8_OBJECTSTORE = value; }
        }
        [ComVisible(true)]
        public string FNP8_FOLDER
        {
            get { return _FNP8_FOLDER; }
            set { _FNP8_FOLDER = value; }
        }
        [ComVisible(true)]
        public string FNP8_AREA
        {
            get { return _FNP8_AREA; }
            set { _FNP8_AREA = value; }
        }
        [ComVisible(true)]
        public string FNP8_AUTODECLARE
        {
            get { return _FNP8_AUTODECLARE; }
            set { _FNP8_AUTODECLARE = value; }
        }
        [ComVisible(true)]
        public string FNP8_AUTOSYNCPROPS
        {
            get { return _FNP8_AUTOSYNCPROPS; }
            set { _FNP8_AUTOSYNCPROPS = value; }
        }
        [ComVisible(true)]
        public string FNP8_RECORDFILEDIN
        {
            get { return _FNP8_RECORDFILEDIN; }
            set { _FNP8_RECORDFILEDIN = value; }
        }
        [ComVisible(true)]
        public string FNP8_RECORDCLASSNAME
        {
            get { return _FNP8_RECORDCLASSNAME; }
            set { _FNP8_RECORDCLASSNAME = value; }
        }
        [ComVisible(true)]
        public string FNP8_SUBACTIVITY
        {
            get { return _FNP8_SUBACTIVITY; }
            set { _FNP8_SUBACTIVITY = value; }
        }
        [ComVisible(true)]
        public string FNP8_SUBFUNCTION
        {
            get { return _FNP8_SUBFUNCTION; }
            set { _FNP8_SUBFUNCTION = value; }
        }
        [ComVisible(true)]
        public string FormName
        {
            get { return _FormName; }
            set { _FormName = value; }
        }
        [ComVisible(true)]
        public string FullName
        {
            get { return _FullName; }
            set
            {
                _FullName = value;
            }
        }
        [ComVisible(true)]
        public string GLCompanyCode
        {
            get { return _glCompanyCode; }
            set { _glCompanyCode = value; }
        }
        [ComVisible(true)]
        public string GroupID
        {
            get { return _GroupID; }
            set { _GroupID = value; }
        }
        [ComVisible(true)]
        public string GroupNo
        {
            get { return _GroupNo; }
            set { _GroupNo = value; }
        }
        [ComVisible(true)]
        public string GroupName
        {
            get { return _GroupName; }
            set { _GroupName = value; }
        }
        [ComVisible(true)]
        public string HolderNumber
        {
            get { return _HolderNumber; }
            set { _HolderNumber = value; }
        }
        [ComVisible(true)]
        public string HolderNumberIsValid
        {
            get { return _HolderNumberIsValid; }
            set { _HolderNumberIsValid = value; }
        }
        [ComVisible(true)]
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        [ComVisible(true)]
        public string IndexOperator
        {
            get { return _indexOperator; }
            set { _indexOperator = value; }
        }
        [ComVisible(true)]
        public string IndexType
        {
            get { return _indexType; }
            set { _indexType = value; }
        }
        [ComVisible(true)]
        public int ImgCount
        {
            get { return _ImgCount; }
            set { _ImgCount = value; }
        }
        [ComVisible(true)]
        public string InputSource
        {
            get { return _inputSource; }
            set { _inputSource = value; }
        }
        [ComVisible(true)]
        public string InsuredName
        {
            get { return _Name; }
            set
            {
                _Name = value;
                //try
                //{
                //   //parse first, middle, last
                //   string Name = value.Trim();

                //   string[] arrNames = Name.Split(' ');

                //   if (arrNames.Length > 0)
                //   {
                //      _firstName = arrNames[0].Trim();
                //   }
                //   if (arrNames.Length > 1)
                //   {
                //      _lastName = arrNames[arrNames.Length - 1].Trim();
                //   }
                //   if (arrNames.Length > 2)
                //   {
                //      _middleName = string.Join(" ", arrNames, 1, arrNames.Length - 2).Trim();
                //   }

                //}
                //catch { }

            }
        }
        [ComVisible(true)]
        public string InvoiceDate
        {
            get { return _InvoiceDate; }
            set { _InvoiceDate = value; }
        }
        [ComVisible(true)]
        public string InvoiceDescription
        {
            get { return _InvoiceDescription; }
            set { _InvoiceDescription = value; }
        }
        [ComVisible(true)]
        public string InvoiceNumber
        {
            get { return _InvoiceNumber; }
            set { _InvoiceNumber = value; }
        }
        [ComVisible(true)]
        public string InvoiceTotal
        {
            get { return _InvoiceTotal; }
            set { _InvoiceTotal = value; }
        }
        [ComVisible(true)]
        public string InvoiceType
        {
            get { return _InvoiceType; }
            set { _InvoiceType = value; }
        }
        [ComVisible(true)]
        public string IssueCountry
        {
            get { return _issueCountry; }
            set { _issueCountry = value; }
        }
        [ComVisible(true)]
        public string IssueDate
        {
            get { return _issueDate; }
            set { _issueDate = value; }
        }
        [ComVisible(true)]
        public string IssueState
        {
            get { return _issueState; }
            set { _issueState = value; }
        }
        public string LastActivity
        {
            get { return _lastActivity; }
            set { _lastActivity = value; }
        }
        [ComVisible(true)]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                setName();
            }
        }
        [ComVisible(true)]
        public string LifeProIndicator
        {
            get { return _lifeProIndicator; }
            set { _lifeProIndicator = value; }
        }
        [ComVisible(true)]
        public string LineOfBusiness
        {
            get { return _LineOfBusiness; }
            set { _LineOfBusiness = value; }
        }
        [ComVisible(true)]
        public string MasterGroupID
        {
            get { return _MasterGroupID; }
            set { _MasterGroupID = value; }
        }
        [ComVisible(true)]
        public string MasterGroupName
        {
            get { return _masterGroupName; }
            set { _masterGroupName = value; }
        }
        [ComVisible(true)]
        public string MasterGroupNo
        {
            get { return _masterGroupNo; }
            set { _masterGroupNo = value; }
        }
        [ComVisible(true)]
        public string MedicareId
        {
            get { return _medicareId; }
            set { _medicareId = value; }
        }
        [ComVisible(true)]
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                _middleName = value;
                setName();
            }
        }
        [ComVisible(true)]
        public string MOLIDocType
        {
            get { return _moliDocType; }
            set { _moliDocType = value; }
        }
        [ComVisible(true)]
        public string NameType
        {
            get { return _NameType; }
            set { _NameType = value; }
        }
        [ComVisible(true)]
        public string OfficeNo
        {
            get { return _officeNo; }
            set { _officeNo = value; }
        }
        [ComVisible(true)]
        public string PatientName
        {
            get { return _patientName; }
            set { _patientName = value; }
        }
        [ComVisible(true)]
        public string PersonStatus
        {
            get { return _personStatus; }
            set { _personStatus = value; }
        }
        [ComVisible(true)]
        public string PersonStatusReason
        {
            get { return _personStatusReason; }
            set { _personStatusReason = value; }
        }
        [ComVisible(true)]
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        [ComVisible(true)]
        public string PhoneExtension
        {
            get { return _PhoneExtension; }
            set { _PhoneExtension = value; }
        }
        [ComVisible(true)]
        public string PlanCode
        {
            get { return _planCode; }
            set { _planCode = value; }
        }
        [ComVisible(true)]
        public string PolicyNo
        {
            get { return _PolicyNo; }
            set { _PolicyNo = value; }
        }
        [ComVisible(true)]
        public string PONumber
        {
            get { return _PONumber; }
            set { _PONumber = value; }
        }
        [ComVisible(true)]
        public string PopCode
        {
            get { return _popCode; }
            set { _popCode = value; }
        }
        [ComVisible(true)]
        public string PopsPresent
        {
            get { return _popsPresent; }
            set { _popsPresent = value; }
        }
        [ComVisible(true)]
        public string PreviousNodeID
        {
            get { return _nodePrevious; }
            set { _nodePrevious = value; }
        }
        [ComVisible(true)]
        public string PrivShareOptOut
        {
            get { return _privacyShareOptOut; }
            set { _privacyShareOptOut = value; }
        }
        [ComVisible(true)]
        public string PrivShare3rdPartyOptOut
        {
            get { return _privacyShare3rdPartyOptOut; }
            set { _privacyShare3rdPartyOptOut = value; }
        }
        [ComVisible(true)]
        public string PrivMasterID
        {
            get { return _privacyMasterID; }
            set { _privacyMasterID = value; }
        }
        [ComVisible(true)]
        public string ProcessStep
        {
            get { return _processStep; }
            set { _processStep = value; }
        }
        [ComVisible(true)]
        public string Product
        {
            get { return _Product; }
            set { _Product = value; }
        }
        [ComVisible(true)]
        public string ProductCategory
        {
            get { return _productCategory; }
            set { _productCategory = value; }
        }
        [ComVisible(true)]
        public string PropertyName
        {
            get { return _propertyName; }
            set { _propertyName = value; }
        }
        [ComVisible(true)]
        public string ProviderTIN
        {
            get { return _providerTIN; }
            set { _providerTIN = value; }
        }
        [ComVisible(true)]
        public string ProvName
        {
            get { return _provName; }
            set { _provName = value; }
        }
        [ComVisible(true)]
        public string ReasonCode
        {
            get { return _reasonCode; }
            set { _reasonCode = value; }
        }
        [ComVisible(true)]
        public string ReceivedDate
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        }
        [ComVisible(true)]
        public string ReceivedDateCRD
        {
            get { return _receivedDateCRD; }
            set { _receivedDateCRD = value; }
        }
        [ComVisible(true)]
        public string RejectCode
        {
            get { return _rejectCode; }
            set { _rejectCode = value; }
        }
        [ComVisible(true)]
        public string RejectOption
        {
            get { return _rejectOption; }
            set { _rejectOption = value; }
        }
        [ComVisible(true)]
        public string Relationship
        {
            get { return _Relationship; }
            set { _Relationship = value; }
        }
        [ComVisible(true)]
        public string RememberBAWT
        {
            get { return _rememberBAWT; }
            set { _rememberBAWT = value; }
        }
        [ComVisible(true)]
        public string ReplacementIndicator
        {
            get { return _replacementIndicator; }
            set { _replacementIndicator = value; }
        }
        [ComVisible(true)]
        public string ReplacementQuestion
        {
            get { return _replacementQuestion; }
            set { _replacementQuestion = value; }
        }
        [ComVisible(true)]
        public string ReportDate
        {
            get { return _ReportDate; }
            set { _ReportDate = value; }
        }
        [ComVisible(true)]
        public string RequirementID
        {
            get { return _requirementID; }
            set { _requirementID = value; }
        }
        [ComVisible(true)]
        public string RouteCode
        {
            get { return _routeCode; }
            set { _routeCode = value; }
        }
        [ComVisible(true)]
        public string ScannerID
        {
            get { return _ScannerID; }
            set { _ScannerID = value; }
        }
        [ComVisible(true)]
        public string ScanDate
        {
            get { return _ScanDate; }
            set { _ScanDate = value; }
        }
        [ComVisible(true)]
        public string ScanOperator
        {
            get { return _scanOperator; }
            set { _scanOperator = value; }
        }
        [ComVisible(true)]
        public string SearchProvider
        {
            get { return _searchProvider; }
            set { _searchProvider = value; }
        }
        [ComVisible(true)]
        public string SearchType
        {
            get { return _searchType; }
            set { _searchType = value; }
        }
        [ComVisible(true)]
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        [ComVisible(true)]
        public string Signature
        {
            get { return _signature; }
            set { _signature = value; }
        }
        [ComVisible(true)]
        public string SortCode
        {
            get { return _sortCode; }
            set { _sortCode = value; }
        }
        [ComVisible(true)]
        public string SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }
        [ComVisible(true)]
        public string SiteID
        {
            get { return _SiteID; }
            set { _SiteID = value; }
        }
        [ComVisible(true)]
        public string SiteRestriction
        {
            get { return _siteRestriction; }
            set { _siteRestriction = value; }
        }
        [ComVisible(true)]
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
        [ComVisible(true)]
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        [ComVisible(true)]
        public string StatusReason
        {
            get { return _statusReason; }
            set { _statusReason = value; }
        }
        [ComVisible(true)]
        public string SupplierNumber
        {
            get { return _SupplierNumber; }
            set { _SupplierNumber = value; }
        }
        [ComVisible(true)]
        public string SupplierSite
        {
            get { return _SupplierSite; }
            set { _SupplierSite = value; }
        }
        [ComVisible(true)]
        public string SystemID
        {
            get { return _SystemID; }
            set { _SystemID = value; }
        }
        [ComVisible(true)]
        public string SystemNo
        {
            get { return _SystemNo; }
            set { _SystemNo = value; }
        }
        [ComVisible(true)]
        public string TargetSystem
        {
            get { return _targetSystem; }
            set { _targetSystem = value; }
        }
        [ComVisible(true)]
        public string TaxAmount
        {
            get { return _TaxAmount; }
            set { _TaxAmount = value; }
        }
        [ComVisible(true)]
        public string TemplateName
        {
            get { return _templateName; }
            set { _templateName = value; }
        }
        [ComVisible(true)]
        public string TerminatedDate
        {
            get { return _terminatedDate; }
            set { _terminatedDate = value; }
        }
        [ComVisible(true)]
        public string TransType
        {
            get { return _transType; }
            set { _transType = value; }
        }
        [ComVisible(true)]
        public string TypeOfBill
        {
            get { return _typeofBill; }
            set { _typeofBill = value; }
        }
        [ComVisible(true)]
        public int Validation
        {
            get { return _Validation; }
            set { _Validation = value; }
        }
        [ComVisible(true)]
        public string ValidationMessage
        {
            get { return _validationMessage; }
            set { _validationMessage = value; }
        }
        [ComVisible(true)]
        public string ValidationStart
        {
            get { return _validationStart; }
            set { _validationStart = value; }
        }
        [ComVisible(true)]
        public string VendorName
        {
            get { return _VendorName; }
            set { _VendorName = value; }
        }
        [ComVisible(true)]
        public string WorkCategory
        {
            get { return _WorkCategory; }
            set { _WorkCategory = value; }
        }
        [ComVisible(true)]
        public string WorkType
        {
            get { return _WorkType; }
            set { _WorkType = value; }
        }
        [ComVisible(true)]
        public string ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }
        }
        [ComVisible(true)]
        public string ZipCode4
        {
            get { return _ZipCode4; }
            set { _ZipCode4 = value; }
        }
        [ComVisible(true)]
        public string WritingAgent
        {
            get { return _WritingAgent; }
            set { _WritingAgent = value; }
        }
        #endregion
        #region Public Methods
        public void Clear()
        {
            MVIFieldData _MVIFieldData = new MVIFieldData();

            //booleans
            _isBundleNeeded = false;
            _isContinued = false;
            _isSearchNeeded = false;
            _isValidTOB = false;
            _isPopCodeFound = false;
            //integers
            _AWDCaseID = 0;
            _AWDRequestID = 0;
            _AWDSourceID = 0;
            _AWDTranID = 0;
            _AWDCaseIDPrevious = 0;
            _AWDRequestIDPrevious = 0;
            _AWDTranIDPrevious = 0;
            _BatchItemID = 0;
            _DDItemSeq = 0;
            _DocustreamRequestID = 0;
            _FORequestID = 0;            
            _InvoiceRequestID = 0;            
            _TPRequestID = 0;
            _Validation = 0;
            //strings
            _AccountNumber = String.Empty;
            _Address1 = String.Empty;
            _Address2 = String.Empty;
            _Address3 = String.Empty;
            _Address4 = String.Empty;
            _AgentNo = String.Empty;
            _ApplicationNo = String.Empty;
            _birthDate = String.Empty;
            _bundleNo = String.Empty;
            _businessArea = String.Empty;
            _caseWorkType = String.Empty;
            _certifiedNo = String.Empty;
            _certificateNo = String.Empty;
            _city = String.Empty;
            _companyCode = String.Empty;
            _CompanyCodeBICPS = String.Empty;
            _companyNo = String.Empty;
            _contestable = String.Empty;
            _corpTaxId = String.Empty;
            _CostCenter = String.Empty;
            _country = String.Empty;
            _custId = String.Empty;
            _CustomerAccount = String.Empty;
            _Custom1 = String.Empty;
            _Custom2 = String.Empty;
            _Custom3 = String.Empty;
            _Custom4 = String.Empty;
            _Custom5 = String.Empty;
            _Custom6 = String.Empty;
            _Custom7 = String.Empty;
            _Custom8 = String.Empty;
            _Custom9 = String.Empty;
            _Custom10 = String.Empty;
            _Custom11 = String.Empty;
            _Custom12 = String.Empty;
            _Custom13 = String.Empty;
            _Custom14 = String.Empty;
            _Custom15 = String.Empty;
            _Custom16 = String.Empty;
            _Custom17 = String.Empty;
            _Custom18 = String.Empty;
            _Custom19 = String.Empty;
            _Custom20 = String.Empty;
            _CustomReq1 = String.Empty;
            _CustomReq2 = String.Empty;
            _CustomReq3 = String.Empty;
            _CustomReq4 = String.Empty;
            _CustomReq5 = String.Empty;
            _CustomReq6 = String.Empty;
            _Description = String.Empty;
            _Description2 = String.Empty;
            _DocClassName = String.Empty;
            _DocType = String.Empty;
            _effectiveDate = String.Empty;
            _FisDocID = String.Empty;
            _FNP8_AREA = String.Empty;
            _FNP8_AUTODECLARE = String.Empty;
            _FNP8_AUTOSYNCPROPS = String.Empty;
            _FNP8_DOCCLASSNAME = String.Empty;
            _FNP8_RECORDFILEDIN = String.Empty;
            _FNP8_RECORDCLASSNAME = String.Empty;
            _FNP8_SUBACTIVITY = String.Empty;
            _FNP8_SUBFUNCTION = String.Empty;
            _FullName = String.Empty;
            _glCompanyCode = String.Empty;
            _GroupID = String.Empty;
            _GroupNo = String.Empty;
            _GroupName = String.Empty;
            _HolderNumber = String.Empty;
            _HolderNumberIsValid = String.Empty;
            _ID = String.Empty;
            _indexOperator = String.Empty;
            _indexType = String.Empty;
            _InvoiceDate = String.Empty;
            _InvoiceDescription = String.Empty;
            _InvoiceNumber = String.Empty;
            _InvoiceTotal = String.Empty;
            _InvoiceType = String.Empty;
            _issueCountry = String.Empty;
            _issueDate = String.Empty;
            _issueState = String.Empty;
            _LineOfBusiness = String.Empty;
            _MasterGroupID = String.Empty;
            _masterGroupName = String.Empty;
            _masterGroupNo = String.Empty;
            _medicareId = String.Empty;
            _Name = String.Empty;
            _NameType = String.Empty;
            _patientName = String.Empty;
            _Phone = String.Empty;
            _PhoneExtension = String.Empty;
            _planCode = String.Empty;
            _PolicyNo = String.Empty;
            _PONumber = String.Empty;
            _popCode = String.Empty;
            _processStep = String.Empty;
            _Product = String.Empty;
            _reasonCode = String.Empty;
            _rejectCode = String.Empty;
            _rejectOption = String.Empty;
            _Relationship = String.Empty;
            _ReportDate = String.Empty;
            _routeCode = String.Empty;
            _searchProvider = String.Empty;
            _searchType = String.Empty;
            _sex = String.Empty;
            _sortCode = String.Empty;
            _siteRestriction = String.Empty;
            _SSN = "0";
            _State = String.Empty;
            _Status = String.Empty;
            _statusReason = String.Empty;
            _SupplierNumber = String.Empty;
            _SupplierSite = String.Empty;
            _SystemID = String.Empty;
            _SystemNo = String.Empty;
            _TaxAmount = String.Empty;
            _terminatedDate = String.Empty;
            _VendorName = String.Empty;
            _WorkType = String.Empty;
            _ZipCode = String.Empty;
            _ZipCode4 = String.Empty;
        }

        public object this[string propertyName]
        {
            get
            {
                PropertyInfo pi = this.GetType().GetProperty(propertyName);
                if (null != pi && pi.CanRead)
                {
                    return pi.GetValue(this, null);
                }
                else
                {
                    return String.Empty;
                }
            }
            set
            {
                PropertyInfo pi = this.GetType().GetProperty(propertyName);
                if (null != pi && pi.CanWrite)
                {
                    pi.SetValue(this, value, null);
                }
            }
        }
        #endregion
    }
}