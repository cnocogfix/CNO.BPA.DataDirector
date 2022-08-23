using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CNO.BPA.DataHandler;
using System.Runtime.InteropServices;

namespace CNO.BPA.DataValidation
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [GuidAttribute("79770D60-5255-4adf-B123-85704D66E64A")]
    public class Validation
    {
        #region Private Variables

        private Qsrch2_area _qsearch2Results;
        private ServiceCalls _serviceCalls = new ServiceCalls();

        #endregion
        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CP"></param>
        /// <returns> 0     success
        ///          -1     validation cancelled
        ///          -2     </returns>
        public int Validate(ref CommonParameters CP)
        {
            try
            {
                //START: AR 145620
                DataAccess dataAccess = new DataAccess();
                //END: AR 145620

                using (frmPolicySearch SearchForm = new frmPolicySearch(ref CP))
                {
                    int returnValue = 0;
                    using (PolicySearch objPolicySearch = new PolicySearch())
                    {

                        //first we want to check to see if any data was passed in
                        if (searchData(ref CP) == true)
                        {
                            goto SEARCHBYPASS;
                        }
                    RESEARCH:

                        DialogResult searchDiagRes = SearchForm.ShowDialog();
                        switch (searchDiagRes)
                        {
                            case DialogResult.OK:

                                break;
                            case DialogResult.Cancel:
                                return -1;
                            default:
                                return -1;
                        }

                    SEARCHBYPASS:
                        //pass the data in to the search
                        sendSearchData(ref CP, objPolicySearch);
                        //now we are ready to perform the search
                        returnValue = objPolicySearch.Search(ref CP);
                        switch (returnValue)
                        {
                            case 0:
                                _qsearch2Results = objPolicySearch.GetResults;
                                break;
                            case 1:
                            case 2:
                            case 3:
                                _qsearch2Results = objPolicySearch.GetResults;
                                MessageBox.Show(_qsearch2Results.Qsrch2_msgs.Qsrch2_msg_text);
                                goto RESEARCH;
                            case 4:
                                _qsearch2Results = objPolicySearch.GetResults;
                                MessageBox.Show("NO MATCHING ENTRIES FOUND FOR SEARCH CRITERIA.");
                                goto RESEARCH;
                            case -1:    //no results
                                return -1;
                            case -2:    //site id does not match
                                //show the user a message and then indicate why validation failed
                                frmStopMessage stopForm = new frmStopMessage();
                                stopForm.ShowDialog();
                                goto RESEARCH;
                            default:
                                return -1;
                        }
                        //determine if the user needs to select
                        if (objPolicySearch.Hits > 1)
                        {
                            using (frmSearchResults objSearchResults = new frmSearchResults(ref CP))
                            {
                                //forward the results to the results screen
                                objSearchResults.SearchResults = _qsearch2Results;
                                
                                //show the results form
                                DialogResult resultsDiagRes = objSearchResults.ShowDialog();
                                switch (resultsDiagRes)
                                {
                                    case DialogResult.OK:
                                        getSearchResults(ref CP, _qsearch2Results, objSearchResults.SelectedItem);

                                        //check for any pop messages
                                        Qdetl2_area objQdetl2_Area = _serviceCalls.lookupPOPCodes(ref CP);

                                        if (objQdetl2_Area.Qdetl2_output.Qdetl2_pop_cnt > 0)
                                        {
                                            if (objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array != null)
                                            {
                                                CP.PopsPresent = "T";

                                                frmPopMessages popMessages = new frmPopMessages(objQdetl2_Area);

                                                //START: AR 145620
                                                //TODO: Hard Coded for testing. This needs to be removed. Commented for the moment.
                                                //objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array[0].Qdetl2_pop_cd = "SHP4";
                                                //objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array[0].Qdetl2_pop_cd = "SSSRE";
                                                //objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array[i].Qdetl2_pop_cd = "SSRE";

                                                for (int i = 0; i <= objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array.Length - 1; i++)
                                                {
                                                    if (null != objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array[i].Qdetl2_pop_cd)
                                                    {
                                                        if (objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array[i].Qdetl2_pop_cd.ToString().Length > 0)
                                                        {

                                                            //Set the PopCode custom parameter
                                                            CP.PopCode = objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array[i].Qdetl2_pop_cd.ToString();

                                                            //Do a lookup on the popcode and set business area and work type
                                                            dataAccess.selectPopCodeLookupList(ref CP);

                                                            if (CP.IsPopCodeFound == true)
                                                                break;
                                                        }
                                                    }
                                                }
                                                //END: AR 145620

                                                popMessages.ShowDialog();                                                
                                            }
                                        }
                                        else
                                        {
                                            CP.PopsPresent = "F";
                                        }
                                        break;
                                    case DialogResult.Cancel:
                                        return -1;
                                    case DialogResult.Retry:  //indicates the research btn was clicked
                                        goto RESEARCH;
                                    default:
                                        return -1;
                                }
                            }
                        }
                        else if (objPolicySearch.Hits == 1)
                        {
                            //there was only one item returned, so we 
                            //simply need to pull back the first item
                            getSearchResults(ref CP, _qsearch2Results, 0);
                            //check for any pop messages
                            Qdetl2_area objQdetl2_Area = _serviceCalls.lookupPOPCodes(ref CP);

                            if (objQdetl2_Area.Qdetl2_output.Qdetl2_pop_cnt > 0)
                            {
                                if (objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array != null)
                                {
                                    CP.PopsPresent = "T";

                                    frmPopMessages popMessages = new frmPopMessages(objQdetl2_Area);

                                    for (int i = 0; i <= objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array.Length - 1; i++)
                                    {
                                        if (null != objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array[i].Qdetl2_pop_cd)
                                        {
                                            if (objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array[i].Qdetl2_pop_cd.ToString().Length > 0)
                                            {
                                                //Set the PopCode custom parameter
                                                CP.PopCode = objQdetl2_Area.Qdetl2_output.Qdetl2_pop_array[i].Qdetl2_pop_cd.ToString();

                                                //Do a lookup on the popcode and set business area and work type
                                                dataAccess.selectPopCodeLookupList(ref CP);

                                                if (CP.IsPopCodeFound == true)
                                                    break;
                                            }
                                        }
                                    }

                                    popMessages.ShowDialog();
                                }
                            }
                            else
                            {
                                CP.PopsPresent = "F";
                            }
                        }
                    }
                }
                //this completes the policy validation 
                return 0;

            }
            catch
            {
                return -99;
            }
        }
        public int Validate(ref CommonParameters CP, bool Silent)
        {
            DataAccess dataAccess = new DataAccess();
            //see if we need to select routing
            if (CP.SiteRestriction.Length == 0)
            {
                dataAccess.selectRouting(ref CP);
            }
            if (Silent != true)
            {
                return Validate(ref CP);
            }
            else
            {
                using (PolicySearch objPolicySearch = new PolicySearch())
                {
                    //first we want to check to see if any data was passed in
                    if (searchData(ref CP))
                    {
                        //pass the data in to the search
                        sendSearchData(ref CP, objPolicySearch);
                    }
                    //show the search form
                    int returnValue = objPolicySearch.Search(ref CP);

                    if (returnValue != 0)
                    {
                        return -1;
                    }
                    //grab the results
                    _qsearch2Results = objPolicySearch.GetResults;
                    //check to see if the results object is valid
                    if (_qsearch2Results == null) return -2;
                    //determine if the user needs to select
                    if (objPolicySearch.Hits > 1)
                    {
                        return -3;
                    }
                    else
                    {
                        //there was only one item returned, so we 
                        //only need to parse through the results    

                        getSearchResults(ref CP, _qsearch2Results, 0);
                        //check for any pop messages
                        Qdetl2_area objQdetl2_area = _serviceCalls.lookupPOPCodes(ref CP);
                        if (objQdetl2_area.Qdetl2_output.Qdetl2_pop_cnt > 0)
                        {
                            //there are pop messages
                            CP.PopsPresent = "T";
                            return -4;

                        }
                        else
                        {
                            CP.PopsPresent = "F";
                        }
                        return 0;
                    }
                }
            }
        }
        public int AutoValidate(ref CommonParameters CP)
        {
            using (PolicySearch policySearch = new PolicySearch())
            {
                int returnValue = 0;
                policySearch.SiteID = CP.SiteID;

                returnValue = validationRound1(ref CP, policySearch);
                if (returnValue >= 0)
                {
                    //we matched so pull the results into the properties
                    getSearchResults(ref CP, _qsearch2Results, returnValue);
                    //indicate what validation worked
                    if (CP.SortCode != "000" & CP.SortCode.Length > 0 & CP.Status != "3")
                    {
                        CP.Validation = 110;
                        //now we can leave
                        return 0;
                    }
                }
                returnValue = validationRound1a(ref CP, _qsearch2Results);
                if (returnValue >= 0)
                {
                    //we matched so pull the results into the properties
                    getSearchResults(ref CP, _qsearch2Results, returnValue);
                    if (CP.SortCode != "000" & CP.SortCode.Length > 0 & CP.Status != "3")
                    {
                        //indicate what validation worked
                        CP.Validation = 114;
                        //now we can leave
                        return 0;
                    }
                }
                returnValue = validationRound1b(ref CP, _qsearch2Results);
                if (returnValue >= 0)
                {
                    //we matched so pull the results into the properties
                    getSearchResults(ref CP, _qsearch2Results, returnValue);
                    if (CP.SortCode != "000" & CP.SortCode.Length > 0 & CP.Status != "3")
                    {
                        //indicate what validation worked
                        CP.Validation = 118;
                        //now we can leave
                        return 0;
                    }
                }
                returnValue = validationRound2(ref CP, _qsearch2Results);
                if (returnValue >= 0)
                {
                    //we matched so pull the results into the properties
                    getSearchResults(ref CP, _qsearch2Results, returnValue);
                    if (CP.SortCode != "000" & CP.SortCode.Length > 0 & CP.Status != "3")
                    {
                        //indicate what validation worked
                        CP.Validation = 120;
                        //now we can leave
                        return 0;
                    }
                }
                //new search logic
                returnValue = validationRound3(ref CP, _qsearch2Results);
                if (returnValue >= 0)
                {
                    //we matched so pull the results into the properties
                    getSearchResults(ref CP, _qsearch2Results, returnValue);
                    if (CP.SortCode != "000" & CP.SortCode.Length > 0 & CP.Status != "3")
                    {
                        //indicate what validation worked
                        CP.Validation = 130;
                        //now we can leave
                        return 0;
                    }
                }
                //clear out any search values before searching again
                policySearch.reset();
                if (validationRound4(ref CP, policySearch) == 1)
                {
                    //we matched so pull the results into the properties
                    getSearchResults(ref CP, _qsearch2Results);
                    if (CP.SortCode != "000" & CP.SortCode.Length > 0 & CP.Status != "3")
                    {
                        //indicate what validation worked
                        CP.Validation = 210;
                        //now we can leave
                        return 0;
                    }
                }
                //clear out any search values before searching again
                policySearch.reset();
                if (validationRound7(ref CP, policySearch) == 1)
                {
                    //we matched so pull the results into the properties
                    getSearchResults(ref CP, _qsearch2Results);
                    if (CP.SortCode != "000" & CP.SortCode.Length > 0 & CP.Status != "3")
                    {
                        //indicate what validation worked
                        CP.Validation = 310;
                        //now we can leave
                        return 0;
                    }
                }
                return -1;
            }
        }
        public Boolean ValidateTOB(ref CommonParameters CP)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.CheckTypeOfBill(ref CP);
            return CP.IsValidTOB;
        }
        public int ValidateHIC(ref CommonParameters CP)
        {
            if (validationHIC(ref CP) == 1)
            {
                //we matched so pull the results into the properties
                getSearchResults(ref CP, _qsearch2Results);
                //indicate what validation worked
                CP.Validation = 510;
                //now we can leave
                return 0;
            }
            return -1;
        }
        public string getALCCC14data(ref CommonParameters CP)
        {
            return _serviceCalls.lookupALCCC14(ref CP);
        }
        public string getFrontOfficeBarcodeValues(ref CommonParameters CP)
        {
            DataAccess dataAccess = new DataAccess();
            return dataAccess.selectFrontOfficeBarcode(ref CP);
        }
        public string getFrontOfficeProdCatXrefValues(ref CommonParameters CP)
        {
            DataAccess dataAccess = new DataAccess();
            return dataAccess.selectFrontOfficeProdCatXref(ref CP);
        }

        #endregion
        #region Private Methods
        private string cleanIDValue(string CurrentValue)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < CurrentValue.Length; i++)
                if (char.IsLetterOrDigit(CurrentValue[i]))
                {
                    sb.Append(CurrentValue[i]);
                }
            return sb.ToString();
        }
        private string removeNonNumerics(string CurrentValue)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < CurrentValue.Length; i++)
                if (char.IsNumber(CurrentValue[i]))
                {
                    sb.Append(CurrentValue[i]);
                }
            return sb.ToString();
        }
        private void getSearchResults(ref CommonParameters CP, Qsrch2_area Results)
        {
            getSearchResults(ref CP, Results, 0);
        }
        private void getSearchResults(ref CommonParameters CP, Qsrch2_area Results, int Index)
        {
            //there was only one item returned, so we 
            //only need to parse through the results                     

            CP.CompanyNo = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_cmp;
            CP.ID = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_id;
            CP.LineOfBusiness = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_line_of_bus;
            CP.NameType = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_name_type;
            CP.Product = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_product; 
            CP.SystemNo = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_sys;
            CP.Status = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_status;
            CP.Relationship = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_relationship;
            CP.TerminatedDate = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_termination_date;

            DateTime tempTerminatedDate;

            DateTime.TryParse(CP.TerminatedDate, out tempTerminatedDate);

            if (tempTerminatedDate.ToString() == "1/1/0001 12:00:00 AM")
            {
                CP.TerminatedDate = String.Empty;
            }
            
            CP.Country = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_country;
            CP.PlanCode = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_base_plan_code;
            CP.CorpTaxId = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_corp_tax_id;
            CP.CustId = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_cust_id;
            CP.GroupNo = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_group_number;
            CP.IssueCountry = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_issue_country;
            CP.IssueDate = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_issue_date;
            CP.IssueState = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_issue_state;
            CP.LastActivity = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_last_activity;
            CP.MedicareId = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_medicare_id;
            CP.PersonStatus = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_person_status;
            CP.PersonStatusReason = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_person_status_reason;
            CP.Sex = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_sex;
            CP.StatusReason = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_status_reason;

            if (CP.NameType == "P")
            {
                CP.PolicyNo = cleanIDValue(CP.ID);
                CP.Address1 = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_line1;
                CP.Address2 = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_line2;
                CP.Address3 = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_line3;
                CP.Address4 = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_line4;
                CP.City = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_city;
                CP.BirthDate = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_birth;
                CP.InsuredName = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_name;
                CP.Phone = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_area_code + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_phone;
                CP.SSN = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_ssn;
                CP.State = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_state;
                CP.ZipCode = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_zip;
                CP.ZipCode4 = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_zip4;
            }
            if (CP.NameType == "A")
            {
                CP.AgentNo = cleanIDValue(CP.ID);
                CP.AgentAddress1 = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_line1;
                CP.AgentAddress2 = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_line2;
                CP.AgentAddress3 = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_line3;
                CP.AgentAddress4 = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_line4;
                CP.AgentCity = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_city;
                CP.AgentBirthDate = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_birth;
                CP.AgentName = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_name;
                CP.AgentPhone = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_area_code + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_phone;
                CP.AgentSSN = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_ssn;
                CP.AgentState = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_state;
                CP.AgentZip = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_zip;
                CP.AgentZip4 = "" + Results.Qsrch2_output.Qsrch2_array[Index].Qsrch2_addr_zip4;
            }
            //check for any pop messages
            Qdetl2_area objQdetl2_area = _serviceCalls.lookupPOPCodes(ref CP);

            //the next 2 steps should only be taken if the admin systems are not reported to be down
            if (checkPopSDOWN(objQdetl2_area) == false)
            {
                getClaimData(ref CP);
                performDataTranslation(ref CP);
            }
        }
        private void getClaimData(ref CommonParameters CP)
        {
            string startTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            DataAccess dataAccess = new DataAccess();

            //lookup policy in BICPS
            _serviceCalls.lookupBICEPS(ref CP);
            //lookup issue state and plan code based on site
            switch (CP.SiteID)
            {
                case "CIC":
                    switch (CP.SystemNo)
                    {
                        case "CIC":
                        case "L7G":
                        case "LCC":
                        case "LLC":
                        case "PPC":
                            _serviceCalls.lookupSharp(ref CP);
                            break;
                        case "LPK":
                        case "EP0":
                        case "LPA":
                        case "LPC":
                        case "LPE":
                        case "LPL":
                        case "LPN":
                        case "LPP":
                        case "LPT":
                        case "LPY":
                            _serviceCalls.lookupLifePro(ref CP);
                            break;
                        case "L70":
                        case "AS4":
                        case "BAN":
                        case "CFO":
                        case "LCP":
                        case "OAC":
                        case "UFL":
                            _serviceCalls.lookupCS01(ref CP);
                            break;
                    }
                    break;
                case "BLC":
                    switch (CP.SystemNo)
                    {
                        case "CIB":
                            _serviceCalls.lookupSharp(ref CP);
                            break;
                        case "LPK":
                        case "CIV":
                            _serviceCalls.lookupLifePro(ref CP);
                            break;
                    }
                    break;
            }

            string endTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            dataAccess.createPerfLogEntry(ref CP, startTime1, endTime1, "GetClaimData", "SUCCESS");

        }
        private void performDataTranslation(ref CommonParameters CP)
        {
            string startTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            DataAccess dataAccess = new DataAccess();
            //translate plan code to sort code
            dataAccess.selectSortCodeFromPlanCode(ref CP);
            //pull back the lob, work type and whether a 
            //bundle is needed based on the sort code
            dataAccess.selectSortCodeValues(ref CP);
            //now pull back the admin system xref values
            dataAccess.selectAdminSystemXrefValues(ref CP);

            string endTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            dataAccess.createPerfLogEntry(ref CP, startTime1, endTime1, "PerfDataTrans", "SUCCESS");

        }
        private bool searchData(ref CommonParameters CP)
        {
            //define a place to hold the return
            bool blnSearchData = false;
            //first we want to check to see if any data was passed in
            if (CP.ID.Trim().Length > 0) blnSearchData = true;
            //check policy specific values
            if (CP.PolicyNo.Trim().Length > 0) blnSearchData = true;
            if (CP.BirthDate.Trim().Length > 0) blnSearchData = true;
            if (CP.InsuredName.Trim().Length > 0) blnSearchData = true;
            if (CP.Phone.Trim().Length > 0) blnSearchData = true;
            if (CP.SSN != "0") blnSearchData = true;
            if (CP.ZipCode.Trim().Length > 0) blnSearchData = true;
            //check agent specific values
            if (CP.AgentNo.Trim().Length > 0) blnSearchData = true;
            if (CP.AgentBirthDate.Trim().Length > 0) blnSearchData = true;
            if (CP.AgentName.Trim().Length > 0) blnSearchData = true;
            if (CP.AgentPhone.Trim().Length > 0) blnSearchData = true;
            if (CP.AgentSSN != "0") blnSearchData = true;
            if (CP.AgentZip.Trim().Length > 0) blnSearchData = true;
            //then we can return the response
            return blnSearchData;
        }
        private void sendSearchData(ref CommonParameters CP, PolicySearch SearchObj)
        {
            //pass the generic search values
            SearchObj.NameType = CP.NameType;
            SearchObj.Product = CP.Product;
            SearchObj.CompanyNo = CP.CompanyNo;
            SearchObj.SystemNo = CP.SystemNo;
            //now pass those search values specific to the name type
            if (CP.NameType == "P" || CP.NameType == String.Empty)
            {
                if (CP.ID.Length > 0)
                {
                    SearchObj.ID = CP.ID;
                }
                else if (CP.PolicyNo.Length > 0)
                {
                    SearchObj.ID = CP.PolicyNo;
                }
                else
                {
                    SearchObj.ID = String.Empty;
                }
                SearchObj.InsuredName = CP.InsuredName;
                SearchObj.BirthDate = CP.BirthDate;
                SearchObj.Phone = CP.Phone;
                SearchObj.SSN = CP.SSN;
                SearchObj.State = CP.State;
                SearchObj.ZipCode = CP.ZipCode;
            }
            if (CP.NameType == "A")
            {
                if (CP.ID.Length > 0)
                {
                    SearchObj.ID = CP.ID;
                }
                else if (CP.AgentNo.Length > 0)
                {
                    SearchObj.ID = CP.AgentNo;
                }
                else
                {
                    SearchObj.ID = String.Empty;
                }
                SearchObj.InsuredName = CP.AgentName;
                SearchObj.BirthDate = CP.AgentBirthDate;
                SearchObj.Phone = CP.AgentPhone;
                SearchObj.SSN = CP.AgentSSN;
                SearchObj.State = CP.AgentState;
                SearchObj.ZipCode = CP.AgentZip;
            }
        }
        /// <summary>searches only on policy number and returns the 
        /// first 19 results.</summary>
        /// <returns># of Hits will be returned if successful validation
        ///          -1 will be returned if validation was a failure</returns>      
        /// <remarks>changes:   BEH   04/01/2008  created
        ///                     BEH   10/01/2009  revised logic per itsr 90158</remarks> 
        ///                     BEH   02/08/2010  revised logic per emer 111
        private int validationRound1(ref CommonParameters CP, PolicySearch policySearch)
        {
            if (CP.ID.Trim().Length > 0)
            {
                policySearch.ID = CP.ID;
                //call the search               
                switch (policySearch.Search(ref CP))
                {
                    case 0:
                        //pull back the results object
                        _qsearch2Results = policySearch.GetResults;
                        break;
                    default:
                        //assume that if the search was unsuccessful we should continue
                        break;
                }
            }
            return -1;
        }
        private int validationRound1a(ref CommonParameters CP, Qsrch2_area searchResults)
        {
            int blankSpace = 0;
            string[] insuredName = new string[2];

            if (null != searchResults)
            {
                if (CP.InsuredName.Trim().Length > 0)
                {
                    //determine where the space is between first and last name
                    blankSpace = CP.InsuredName.IndexOf(" ");
                    if (blankSpace != -1)
                    {
                        insuredName[0] = CP.InsuredName.Substring(0, blankSpace);
                        insuredName[1] = CP.InsuredName.Substring(blankSpace + 1);
                    }
                    else
                    {
                        insuredName[0] = CP.InsuredName.Trim();
                    }
                    //first pass: Policy Number and Last name
                    foreach (object name in insuredName)
                    {
                        if (null != name)
                        {
                            for (int i = 0; i < searchResults.Qsrch2_output.Qsrch2_cnt; i++)
                            {
                                if (searchResults.Qsrch2_output.Qsrch2_array[i].Qsrch2_name.ToUpper().Contains(name.ToString().ToUpper()))
                                {
                                    return i;
                                }
                            }
                        }
                    }
                }
            }
            return -1;
        }
        private int validationRound1b(ref CommonParameters CP, Qsrch2_area searchResults)
        {
            int blankSpace = 0;
            string[] patientName = new string[2];

            if (null != searchResults)
            {
                if ((CP.PatientName.Trim().ToUpper() != CP.InsuredName.Trim().ToUpper())
                   & CP.PatientName.Trim().Length > 0)
                {
                    //determine where the space is between first and last name
                    blankSpace = CP.PatientName.IndexOf(" ");
                    if (blankSpace != -1)
                    {
                        patientName[0] = CP.PatientName.Substring(0, blankSpace);
                        patientName[1] = CP.PatientName.Substring(blankSpace + 1);
                    }
                    else
                    {
                        patientName[0] = CP.PatientName.Trim();
                    }
                    foreach (object name in patientName)
                    {
                        if (null != name)
                        {
                            for (int i = 0; i < searchResults.Qsrch2_output.Qsrch2_cnt; i++)
                            {
                                if (searchResults.Qsrch2_output.Qsrch2_array[i].Qsrch2_name.ToUpper().Contains(name.ToString().ToUpper()))
                                {
                                    return i;
                                }
                            }
                        }
                    }
                }
            }
            return -1;
        }
        /// <summary>searches the first 19 results of policy number only to see if 
        /// the zip code is a match for any of them.  If so, it takes that record
        /// and calls it a match.</summary>
        /// <returns># of Hits will be returned if successful validation
        ///          -1 will be returned if validation was a failure</returns>      
        /// <remarks>changes:   BEH   04/01/2008  created
        ///                     BEH   10/01/2009  revised logic per 90158</remarks> 
        private int validationRound2(ref CommonParameters CP, Qsrch2_area searchResults)
        {
            if (null != searchResults)
            {
                if (CP.ZipCode.Trim().Length > 0)
                {
                    for (int i = 0; i < searchResults.Qsrch2_output.Qsrch2_cnt; i++)
                    {
                        if (searchResults.Qsrch2_output.Qsrch2_array[i].Qsrch2_addr_zip ==
                           CP.ZipCode)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }
        /// <summary>searches the first 19 results of policy number only to see if 
        /// the phone number is a match for any of them.  If so, it takes that record
        /// and calls it a match.</summary>
        /// <returns># of Hits will be returned if successful validation
        ///          -1 will be returned if validation was a failure</returns>      
        /// <remarks>changes:   BEH   04/01/2008  created
        ///                     BEH   10/01/2009  revised logic per 90158</remarks> 
        private int validationRound3(ref CommonParameters CP, Qsrch2_area searchResults)
        {
            if (null != searchResults)
            {
                if (CP.Phone.Trim().Length > 0)
                {
                    for (int i = 0; i < searchResults.Qsrch2_output.Qsrch2_cnt; i++)
                    {
                        if (searchResults.Qsrch2_output.Qsrch2_array[i].Qsrch2_phone ==
                           CP.Phone)
                        {
                            return i;
                        }
                    }
                }
            }
            //make sure the search results object is reset, since the next
            //round of validation will perform a new search
            searchResults = null;
            return -1;
        }
        /// <summary>searches the ssn field using the policy number and compares 
        /// the first 19 results. if the first 19 are all for the same ID, System, and
        /// Company, then they are to be considered the same policy and a match.</summary>
        /// <returns># of Hits will be returned if successful validation
        ///          -1 will be returned if validation was a failure</returns>      
        /// <remarks>changes:   BEH   04/01/2008  created
        ///                     BEH   10/01/2009  revised logic per 90158</remarks> 
        private int validationRound4(ref CommonParameters CP, PolicySearch policySearch)
        {
            if (CP.ID.Trim().Length == 9)
            {
                //verify there are no non-numberic characters
                int policyNumber;
                bool isNumeric = int.TryParse(CP.ID, out policyNumber);
                if (isNumeric)
                {
                    //now we can set the search values
                    policySearch.SSN = policyNumber.ToString();
                    //call the search               
                    switch (policySearch.Search(ref CP))
                    {
                        case 0:
                            //pull back the results object
                            _qsearch2Results = policySearch.GetResults;
                            //check the number of hits
                            return policySearch.Hits;
                        default:
                            //assume that if the search was unsuccessful we should continue
                            break;
                    }
                }
            }
            return -1;
        }
        /// <summary>searches the first 19 results of policy no in ssn field to see if 
        /// the zip code is a match for any of them.  If so, it takes that record
        /// and calls it a match.</summary>
        /// <returns># of Hits will be returned if successful validation
        ///          -1 will be returned if validation was a failure</returns>      
        /// <remarks>changes:   BEH   04/01/2008  created
        ///                     BEH   10/01/2009  revised logic per 90158</remarks> 
        private int validationRound5(ref CommonParameters CP, Ws_Sossrch_Data searchResults)
        {
            if (null != searchResults)
            {
                if (CP.ZipCode.Trim().Length > 0)
                {
                    for (int i = 0; i < searchResults.Current_Screen_Area.Cs_Cnt; i++)
                    {
                        if (searchResults.Current_Screen_Area.Cs_Array[i].Cs_Zip ==
                           CP.ZipCode)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }
        /// <summary>searches the first 19 results of policy no in ssn field to see if 
        /// the phone number is a match for any of them.  If so, it takes that record
        /// and calls it a match.</summary>
        /// <returns># of Hits will be returned if successful validation
        ///          -1 will be returned if validation was a failure</returns>      
        /// <remarks>changes:   BEH   04/01/2008  created
        ///                     BEH   10/01/2009  revised logic per 90158</remarks> 
        private int validationRound6(ref CommonParameters CP, Ws_Sossrch_Data searchResults)
        {
            if (null != searchResults)
            {
                if (CP.Phone.Trim().Length > 0)
                {
                    for (int i = 0; i < searchResults.Current_Screen_Area.Cs_Cnt; i++)
                    {
                        if (searchResults.Current_Screen_Area.Cs_Array[i].Cs_Phone ==
                           CP.Phone)
                        {
                            return i;
                        }

                    }
                }
            }
            //make sure the search results object is reset
            searchResults = null;
            return -1;
        }
        /// <summary>searches the ssn field using the policy number,
        /// where 10th character is alpha and 1-9 are numeric, and compares 
        /// the first 19 results. if the first 19 are all for the same ID, System, and
        /// Company, then they are to be considered the same policy and a match.</summary>
        /// <returns># of Hits will be returned if successful validation
        ///          -1 will be returned if validation was a failure</returns>      
        /// <remarks>changes:   BEH   04/01/2008  created
        ///                     BEH   10/01/2009  revised logic per 90158</remarks> 
        private int validationRound7(ref CommonParameters CP, PolicySearch policySearch)
        {
            if (CP.ID.Trim().Length == 10)
            {
                //look at 10th position, if alpha... take 1st 9 and proceed
                string tenthChar = CP.ID.Substring(9, 1);
                Regex expression = new Regex("[a-zA-Z]");
                if (expression.IsMatch(tenthChar))
                {
                    string polNumber = CP.ID.Substring(0, 9);
                    //verify there are no non-numberic characters
                    int policyNumber;
                    bool isNumeric = int.TryParse(polNumber, out policyNumber);
                    if (isNumeric)
                    {
                        //now we can set the search values
                        policySearch.SSN = policyNumber.ToString();
                        //call the search               
                        switch (policySearch.Search(ref CP))
                        {
                            case 0:
                                //pull back the results object
                                _qsearch2Results = policySearch.GetResults;
                                //check the number of hits
                                return policySearch.Hits;
                            default:
                                //assume that if the search was unsuccessful we should continue
                                break;
                        }
                    }
                }
            }
            return -1;
        }
        /// <summary>searches the first 19 results of policy no in ssn field, 
        /// where 10th character is alpha and 1-9 are numeric, to see if 
        /// the zip code is a match for any of them.  If so, it takes that record
        /// and calls it a match.</summary>
        /// <returns># of Hits will be returned if successful validation
        ///          -1 will be returned if validation was a failure</returns>      
        /// <remarks>changes:   BEH   04/01/2008  created
        ///                     BEH   10/01/2009  revised logic per 90158</remarks> 
        private int validationRound8(ref CommonParameters CP, Ws_Sossrch_Data searchResults)
        {
            if (null != searchResults)
            {
                if (CP.ZipCode.Trim().Length > 0)
                {
                    for (int i = 0; i < searchResults.Current_Screen_Area.Cs_Cnt; i++)
                    {
                        if (searchResults.Current_Screen_Area.Cs_Array[i].Cs_Zip ==
                           CP.ZipCode)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }
        /// <summary>searches the first 19 results of policy no in ssn field,
        /// where 10th character is alpha and 1-9 are numeric, to see if 
        /// the phone number is a match for any of them.  If so, it takes that record
        /// and calls it a match.</summary>
        /// <returns># of Hits will be returned if successful validation
        ///          -1 will be returned if validation was a failure</returns>      
        /// <remarks>changes:   BEH   04/01/2008  created
        ///                     BEH   10/01/2009  revised logic per 90158</remarks> 
        private int validationRound9(ref CommonParameters CP, Ws_Sossrch_Data searchResults)
        {
            if (null != searchResults)
            {
                if (CP.Phone.Trim().Length > 0)
                {
                    for (int i = 0; i < searchResults.Current_Screen_Area.Cs_Cnt; i++)
                    {
                        if (searchResults.Current_Screen_Area.Cs_Array[i].Cs_Phone ==
                           CP.Phone)
                        {
                            return i;
                        }
                    }
                }
            }
            //make sure the search results object is reset
            searchResults = null;
            return -1;
        }
        /// <summary>searches ssn field using a modified HIC value.</summary>
        /// <returns># of Hits will be returned if successful validation
        ///          -1 will be returned if validation was a failure</returns>      
        /// <remarks>changes:   BEH   05/09/2008  created</remarks>
        private int validationHIC(ref CommonParameters CP)
        {
            using (PolicySearch policySearch = new PolicySearch())
            {
                string ssn = "";

                if (CP.ID.Length > 0)
                {
                    //remove all characters that are non-numeric
                    ssn = removeNonNumerics(CP.ID);
                    //now truncate to 9 characters
                    if (ssn.Length > 9)
                    {
                        ssn = ssn.Substring(1, 9);
                        CP.SSN = ssn;
                    }
                    //now we can set the search values
                    policySearch.SSN = ssn;
                    //call the search               
                    switch (policySearch.Search(ref CP))
                    {
                        case 0:
                            //pull back the results object
                            _qsearch2Results = policySearch.GetResults;
                            //check the number of hits
                            return policySearch.Hits;
                        default:
                            //assume that if the search was unsuccessful we should continue
                            break;
                    }
                }
                return -1;
            }
        }
        private Boolean checkPopSDOWN(Qdetl2_area popData)
        {
            Boolean retValue = false;
            
            Qdetl2_areaQdetl2_outputQdetl2_pop_arrayQdetl2_pop_lines[] output;

            if (popData.Qdetl2_output.Qdetl2_pop_cnt > 0)
            {
                if (popData.Qdetl2_output.Qdetl2_pop_array != null)
                {
                    for (int i = 0; i <= popData.Qdetl2_output.Qdetl2_pop_array.Length - 1; i++)
                    {
                        output = popData.Qdetl2_output.Qdetl2_pop_array;

                        if (null != output[i].Qdetl2_pop_cd)
                        {
                            if (output[i].Qdetl2_pop_cd.ToString() == "SDOWN")
                            {
                                retValue = true;
                            }
                        }
                    }
                }
            }
            return retValue;

        }
        #endregion
    }
}
