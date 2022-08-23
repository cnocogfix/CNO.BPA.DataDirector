using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CNO.BPA.DataHandler;

namespace CNO.BPA.DataValidation
{
    class PolicySearch : IDisposable
    {
        #region Private Variables

        QSRCH2 _qsearchObj2;
        Qsrch2_area _qsearch2Results;
        Qsrch2_input _objQsrch2Input;
        DataAccess _dataAccess = new DataAccess();
        ServiceCalls _serviceCalls = new ServiceCalls();
        private int _Hits = 0;
        private string _BirthDate = String.Empty;
        private string _CompanyNo = String.Empty;
        private string _ID = String.Empty;
        private string _Name = String.Empty;
        private string _NameType = String.Empty;
        private string _Phone = String.Empty;
        private string _Product = String.Empty;

        //AR 145620
        private string _Relationship = String.Empty;

        private string _SiteID = String.Empty;
        private string _SSN = String.Empty;
        private string _State = String.Empty;
        private string _SystemNo = String.Empty;
        private string _ZipCode = String.Empty;

        #endregion

        #region Constructors

        public PolicySearch()
        {

            _qsearchObj2 = _serviceCalls.getQSRCH2();
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// The number of results that were parsed from the return message
        /// </summary>
        public int Hits
        {
            get { return _Hits; }
            set { _Hits = value; }
        }
        /// <summary>
        /// resets all search parameters to an empty string
        /// </summary>
        public void reset()
        {
            _Name = "";
            _ID = "";
            _Phone = "";
            _SSN = "";
            _BirthDate = "";
            _ZipCode = "";
            _SystemNo = "";
            _CompanyNo = "";
            _NameType = "";
            _Product = "";

            //AR 145620
            _Relationship = "";

            _State = "";

        }
        public int Search(ref CommonParameters CP)
        {
            Int32 retNum = 0;
            string startTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            try
            {

               // Qsrch2_area objQsrch2Area = new Qsrch2_area();
                _objQsrch2Input = new Qsrch2_input();

                //AR 145620 - Commented below line of old code as phone object is not needed any more
                //Ws_Sossrch_DataRa_Sel_FldsRa_Sel_Fone objPhone = new Ws_Sossrch_DataRa_Sel_FldsRa_Sel_Fone();
                
                string actualSiteID = String.Empty;
                
                //since this is the first search, set call type to F
                //AR 145620 - Commented below line of code as it is not needed any more
                //objSearchData.Ra_Call_Type = "F";

                //check for the values the user wants to search on and set them
                if (_Name.Length > 0)
                    _objQsrch2Input.Qsrch2_in_name = _Name;
                if (_ID.Length > 0)
                    _objQsrch2Input.Qsrch2_in_id = _ID;
                if (_Phone.Length > 0)
                {
                    if (_Phone.Length == 10)
                    {
                        _objQsrch2Input.Qsrch2_in_area_cd = _Phone.Substring(0, 3);
                        _objQsrch2Input.Qsrch2_in_phone = _Phone.Substring(3, 7);
                    }
                    else
                    {
                        _objQsrch2Input.Qsrch2_in_phone = _Phone;
                    }                    
                }
                if (_SSN != "0")
                    _objQsrch2Input.Qsrch2_in_ssn = _SSN;
                if (_BirthDate.Length > 0)
                    _objQsrch2Input.Qsrch2_in_birth = _BirthDate;
                if (_SystemNo.Length > 0)
                    _objQsrch2Input.Qsrch2_in_sys = _SystemNo;
                if (_CompanyNo.Length > 0)
                    _objQsrch2Input.Qsrch2_in_cmp = _CompanyNo;
                if (_NameType.Length > 0)
                    _objQsrch2Input.Qsrch2_in_name_type = _NameType;

                //AR 145620 - Commented below line as it is not needed any more
                //if (_Product.Length > 0)
                //    objSelFlds.Ra_Sel_Prod = _Product;

                if (_State.Length > 0)
                    _objQsrch2Input.Qsrch2_in_state = _State;
                if (_ZipCode.Length > 0)
                    _objQsrch2Input.Qsrch2_in_zip = _ZipCode;

                //once we've collected the search fields let's add them to the search object
                //objQsrch2Area.Qsrch2_input = objQsrch2Input;

                //now we can call the search
                string startTime2 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                _qsearch2Results = _qsearchObj2.CallQSRCH2(_objQsrch2Input);

                string endTime2 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                _dataAccess.createPerfLogEntry(ref CP, startTime2, endTime2, "QSRCH2.CallQSRCH2", _qsearch2Results.Qsrch2_msgs.Qsrch2_msg_text);

                if (_qsearch2Results.Qsrch2_msgs.Qsrch2_msg_lvl.ToString() == "0")
                {
                    //pull in the number of items in the array
                    //this will tell us if there are more than one return
                    //it is not an exact count of the number of results           
                    string strResult = _qsearch2Results.Qsrch2_output.Qsrch2_cnt.ToString();

                    if (strResult.Length != 0)
                    {
                        int intOutHits = 0;
                        int.TryParse(strResult, System.Globalization.NumberStyles
                           .AllowThousands, null, out intOutHits);
                        if (intOutHits > 1)
                        {
                            //setup a boolean to determine if any of the values
                            //do not match
                            bool isMatch = true;
                            //setup 3 local strings to hold the data to compare with
                            string policyNo = _qsearch2Results.Qsrch2_output.Qsrch2_array[0].Qsrch2_id;
                            string systemNo = _qsearch2Results.Qsrch2_output.Qsrch2_array[0].Qsrch2_sys;
                            string companyNo = _qsearch2Results.Qsrch2_output.Qsrch2_array[0].Qsrch2_cmp;

                            //let's loop through the results to see if they are all
                            //the same policy, system, company
                            for (int i = 0; i < intOutHits; i++)
                            {
                                //Ws_Sossrch_DataCurrent_Screen_AreaCs_Array policy
                                //= _qsearchResults.Current_Screen_Area.Cs_Array[i];

                                Qsrch2_areaQsrch2_outputQsrch2_array policy
                                    = _qsearch2Results.Qsrch2_output.Qsrch2_array[i];

                                if (policyNo != policy.Qsrch2_id)
                                {
                                    isMatch = false;
                                    break;
                                }
                                if (systemNo != policy.Qsrch2_sys)
                                {
                                    isMatch = false;
                                    break;
                                }
                                if (companyNo != policy.Qsrch2_cmp)
                                {
                                    isMatch = false;
                                    break;
                                }
                            }

                            if (isMatch)
                            {                                
                                ////If all records that are returned match then implement logic to determine which record to return.                                

                                ////Qsrch2_areaQsrch2_outputQsrch2_array emptyPolicy = new Qsrch2_areaQsrch2_outputQsrch2_array();
                                //Qsrch2_areaQsrch2_outputQsrch2_array[] temp = new Qsrch2_areaQsrch2_outputQsrch2_array[(short)(19)];

                                ////Filter search records returned based on CP.Relationship value like whether it is "OWNER" or "INSURED"
                                ////If the CP.Relationship is "ALL" then nothing needs to be done and all the records need to be shown
                                //if (CP.Relationship.ToUpper() != "ALL" && CP.Relationship.ToUpper() != "")
                                //{
                                //    int missForSearchType = 0;
                                //    int hitsForSearchType = 0;

                                //    for (int i = 0; i < _qsearch2Results.Qsrch2_output.Qsrch2_cnt; i++)
                                //    {
                                //        if (_qsearch2Results.Qsrch2_output.Qsrch2_array[i].Qsrch2_relationship.Contains(CP.Relationship))
                                //        {
                                //            temp[hitsForSearchType] = _qsearch2Results.Qsrch2_output.Qsrch2_array[i];
                                //            hitsForSearchType++;
                                //        }
                                //        else
                                //        {
                                //            _qsearch2Results.Qsrch2_output.Qsrch2_array[i] = null;
                                //            missForSearchType++;
                                //        }
                                //    }

                                //    _qsearch2Results.Qsrch2_output.Qsrch2_array = temp;
                                //    _qsearch2Results.Qsrch2_output.Qsrch2_cnt = (short)(hitsForSearchType);
                                //}

                                //START: AR 145620

                                //If all records that are returned match then implement logic to determine which record to return.                                
                                Qsrch2_areaQsrch2_outputQsrch2_array[] temp = new Qsrch2_areaQsrch2_outputQsrch2_array[(short)(19)];

                                //Filter search records returned based on CP.Relationship value like whether it is "OWNER" or "INSURED"
                                //If the CP.Relationship is "ALL" then nothing needs to be done and all the records need to be shown
                                if (CP.Relationship.ToUpper() != "ALL" && CP.Relationship.ToUpper() != "")
                                {
                                    for (int i = 0; i < _qsearch2Results.Qsrch2_output.Qsrch2_cnt; i++)
                                    {
                                        if ((_qsearch2Results.Qsrch2_output.Qsrch2_array[i].Qsrch2_relationship != null) && (_qsearch2Results.Qsrch2_output.Qsrch2_array[i].Qsrch2_relationship != ""))
                                        {
                                            if (_qsearch2Results.Qsrch2_output.Qsrch2_array[i].Qsrch2_relationship.ToString() == CP.Relationship)
                                            {
                                                temp[0] = _qsearch2Results.Qsrch2_output.Qsrch2_array[i];
                                                break;
                                            }
                                        }
                                    }

                                    if (temp[0] != null)
                                    {
                                        _qsearch2Results.Qsrch2_output.Qsrch2_array = temp;
                                        _qsearch2Results.Qsrch2_output.Qsrch2_cnt = 1;
                                    }
                                    else
                                    {
                                        _qsearch2Results.Qsrch2_output.Qsrch2_array = temp;
                                        _qsearch2Results.Qsrch2_output.Qsrch2_cnt = 0;
                                        intOutHits = 0;

                                        //No Results after filtering on Relationship
                                        retNum = 4;

                                        return retNum;
                                    }
                                }

                                //The if statement is put on the existing line of code as part of AR 145620.
                                //This is to set intOutHits to 1 if there is only 1 search result
                                if (_qsearch2Results.Qsrch2_output.Qsrch2_cnt == 1)
                                {
                                    intOutHits = 1;
                                }

                                //END: AR 145620


                                if (CP.SiteRestriction.ToUpper() == "T" && _qsearch2Results.Qsrch2_output.Qsrch2_cnt > 0)
                                {
                                    //before we return the number of results let's make sure
                                    //the site id matches with was was passed in
                                    //check to see if the policy info matches the site
                                    
                                    //pass in static values
                                    _SiteID = CP.SiteID;
                                    
                                    CP.SystemNo = "" + _qsearch2Results.Qsrch2_output.Qsrch2_array[0].Qsrch2_sys;
                                    CP.CompanyNo = "" + _qsearch2Results.Qsrch2_output.Qsrch2_array[0].Qsrch2_cmp;
                                    
                                    //pull back the site returned by the query
                                    actualSiteID = getSiteBySelectedPolicy(ref CP).ToString();

                                    if (actualSiteID == _SiteID || actualSiteID.Length == 0)
                                    {
                                        Hits = intOutHits;
                                    }
                                    else
                                    {
                                        retNum = -2;
                                    }
                                }
                                else
                                {
                                    Hits = intOutHits;
                                }
                            }
                            else
                            {
                                Hits = intOutHits;
                            }
                        }
                        else // the number of items returned is not 0 and also not greater than 1
                        {
                            if (CP.SiteRestriction.ToUpper() == "T" && _qsearch2Results.Qsrch2_output.Qsrch2_cnt > 0)
                            {
                                //before we return the number of results let's make sure
                                //the site id matches with was was passed in
                                //check to see if the policy info matches the site
                                //pass in static values
                                _SiteID = CP.SiteID;

                                CP.SystemNo = "" + _qsearch2Results.Qsrch2_output.Qsrch2_array[0].Qsrch2_sys;
                                CP.CompanyNo = "" + _qsearch2Results.Qsrch2_output.Qsrch2_array[0].Qsrch2_cmp;
                                
                                //pull back the site returned by the query
                                actualSiteID = getSiteBySelectedPolicy(ref CP).ToString();
                                if (actualSiteID == _SiteID || actualSiteID.Length == 0)
                                {
                                    Hits = intOutHits;
                                }
                                else
                                {
                                    retNum = -2;
                                }
                            }
                            else
                            {
                                Hits = intOutHits;
                            }
                        }
                    }
                }
                else
                {
                    Int32.TryParse(_qsearch2Results.Qsrch2_msgs.Qsrch2_msg_lvl.ToString(), out retNum);
                }
                return retNum;
            }

            catch
            {
                retNum = 3;
                return retNum;
            }
            finally
            {
                string msg;
                switch (retNum)
                {
                    case 0:
                        msg = "SUCCESS";
                        break;
                    case 1:
                    case 2:
                    case 3:
                        msg = _qsearch2Results.Qsrch2_msgs.Qsrch2_msg_text;                        
                        break;
                    case 4:
                        msg = "NO MATCHING ENTRIES FOUND FOR SEARCH CRITERIA.";
                        break;
                    case -1:    //no results
                        msg = "NO RESULTS";
                        break;
                    case -2:    //site id does not match
                        msg = "SITE ID DOES NOT MATCH";
                        break;
                    default:
                        msg = "UNKNOWN";
                        break;
                }

                string endTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                _dataAccess.createPerfLogEntry(ref CP, startTime1, endTime1, "PolicySearch", msg);

            }
        }

        #endregion

        #region Private Methods

        private string getSiteBySelectedPolicy(ref CommonParameters CP)
        {
            DataAccess dataAccess = new DataAccess();
            string siteID = dataAccess.selectSiteID(ref CP);
            return siteID;
        }

        #endregion

        #region Public Properties

        public string BirthDate
        {
            get { return _BirthDate; }
            set { _BirthDate = value; }
        }
        public string CompanyNo
        {
            get { return _CompanyNo; }
            set { _CompanyNo = value; }
        }
        public Qsrch2_area GetResults
        {
            get { return _qsearch2Results; }
            set { _qsearch2Results = value; }
        }
        //public Qsrch2_input GetInput
        //{
        //    get { return _objQsrch2Input; }
        //    set { _objQsrch2Input = value; }
        //}
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string InsuredName
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string NameType
        {
            get { return _NameType; }
            set { _NameType = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public string Product
        {
            get { return _Product; }
            set { _Product = value; }
        }
        public string Relationship
        {
            get { return _Relationship; }
            set { _Relationship = value; }
        }
        public string SiteID
        {
            get { return _SiteID; }
            set { _SiteID = value; }
        }
        public string SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
        public string SystemNo
        {
            get { return _SystemNo; }
            set { _SystemNo = value; }
        }
        public string ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            _Name = "";
            _ID = "";
            _Phone = "";
            _SSN = "";
            _BirthDate = "";
            _ZipCode = "";
            _SystemNo = "";
            _CompanyNo = "";
            _NameType = "";
            _Product = "";
            _State = "";
        }

        #endregion
    }
}
