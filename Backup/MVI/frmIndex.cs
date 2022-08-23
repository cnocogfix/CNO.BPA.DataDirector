using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using CNO.BPA.Framework;
using CNO.BPA.DataHandler;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CNO.BPA.MVI
{
    [ComVisible(false)]
    public partial class frmIndex : Form
    {
        #region Variables
        //constants
        //objects
        private CommonParameters _cp;
        private CommonParameters _prevcp;
        ServiceCalls _serviceCalls = new ServiceCalls();
        DataAccess _dataAccess = new DataAccess();
        AWDHierarchy _awdHierarchy;
        //integers
        private int _defaultSelection = -1;
        private List<MaskedComboBox> _mcbs = new List<MaskedComboBox>();
        //bool
        private bool _isFocus = false;
        #endregion
        #region Form Initialization
        public frmIndex(ref CommonParameters CP, CommonParameters prevCP)
        {
            InitializeComponent();
            //obtain a local copy of the common parameters class
            _cp = CP;
            _prevcp = prevCP;
            //load the xml settings file

        }
        private void frmIndex_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    //load form location to config file
                    DataAccess dataaccess = new DataAccess();
                    try
                    {
                        this.Location = dataaccess.selectDDUserFormSettings(this.Name);
                    }
                    catch { }
                }
                if (_cp.BridgeEnabled == "T")
                {
                    this.btnBridge.Enabled = true;
                }
                else
                {
                    this.btnBridge.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmIndex_Shown(object sender, EventArgs e)
        {
            //add all the masked combo boxes to the list
            _mcbs.Add(this.mcbCustom1);
            _mcbs.Add(this.mcbCustom2);
            _mcbs.Add(this.mcbCustom3);
            _mcbs.Add(this.mcbCustom4);
            _mcbs.Add(this.mcbCustom5);
            _mcbs.Add(this.mcbCustom6);
            _mcbs.Add(this.mcbCustom7);
            _mcbs.Add(this.mcbCustom8);
            _mcbs.Add(this.mcbCustom9);
            _mcbs.Add(this.mcbCustom10);
            _mcbs.Add(this.mcbCustom11);
            _mcbs.Add(this.mcbCustom12);
            _mcbs.Add(this.mcbCustom13);
            _mcbs.Add(this.mcbCustom14);
            _mcbs.Add(this.mcbCustom15);
            _mcbs.Add(this.mcbCustom16);
            _mcbs.Add(this.mcbCustom17);
            _mcbs.Add(this.mcbCustom18);
            _mcbs.Add(this.mcbCustom19);
            _mcbs.Add(this.mcbCustom20);
            _mcbs.Add(this.mcbCustomReq1);
            _mcbs.Add(this.mcbCustomReq2);
            _mcbs.Add(this.mcbCustomReq3);
            _mcbs.Add(this.mcbCustomReq4);
            _mcbs.Add(this.mcbCustomReq5);
            _mcbs.Add(this.mcbCustomReq6);

            //link the remember value check boxes to the appropriate MaskedComboBoxes
            this.mcbCustom1.RememberValueCheckBox = this.chkCustom1;
            this.mcbCustom2.RememberValueCheckBox = this.chkCustom2;
            this.mcbCustom3.RememberValueCheckBox = this.chkCustom3;
            this.mcbCustom4.RememberValueCheckBox = this.chkCustom4;
            this.mcbCustom5.RememberValueCheckBox = this.chkCustom5;
            this.mcbCustom6.RememberValueCheckBox = this.chkCustom6;
            this.mcbCustom7.RememberValueCheckBox = this.chkCustom7;
            this.mcbCustom8.RememberValueCheckBox = this.chkCustom8;
            this.mcbCustom9.RememberValueCheckBox = this.chkCustom9;
            this.mcbCustom10.RememberValueCheckBox = this.chkCustom10;
            this.mcbCustom11.RememberValueCheckBox = this.chkCustom11;
            this.mcbCustom12.RememberValueCheckBox = this.chkCustom12;
            this.mcbCustom13.RememberValueCheckBox = this.chkCustom13;
            this.mcbCustom14.RememberValueCheckBox = this.chkCustom14;
            this.mcbCustom15.RememberValueCheckBox = this.chkCustom15;
            this.mcbCustom16.RememberValueCheckBox = this.chkCustom16;
            this.mcbCustom17.RememberValueCheckBox = this.chkCustom17;
            this.mcbCustom18.RememberValueCheckBox = this.chkCustom18;
            this.mcbCustom19.RememberValueCheckBox = this.chkCustom19;
            this.mcbCustom20.RememberValueCheckBox = this.chkCustom20;
            this.mcbCustomReq1.RememberValueCheckBox = this.chkCustomReq1;
            this.mcbCustomReq2.RememberValueCheckBox = this.chkCustomReq2;
            this.mcbCustomReq3.RememberValueCheckBox = this.chkCustomReq3;
            this.mcbCustomReq4.RememberValueCheckBox = this.chkCustomReq4;
            this.mcbCustomReq5.RememberValueCheckBox = this.chkCustomReq5;
            this.mcbCustomReq6.RememberValueCheckBox = this.chkCustomReq6;

            if (_cp.PreviousNodeID != "0" & _cp.PreviousNodeID.Length != 0)
            {
                //pull back the previous node's case id and tran id values 
                _dataAccess.getAWDLinkData(ref _cp);
            }
            loadAWDHierarchy();
            loadBA();
            loadCustomFields();
            resizeForm();
            //populate the header block showing the qsearch2 results
            //based on name type
            if (_cp.NameType == "A")
            {
                txtInsuredName.Text = _cp.AgentName;
                lblInsuredName.Text = "Agent Name:";

                txtAddress1.Text = _cp.AgentAddress1;
                txtAddress2.Text = _cp.AgentAddress2;
                txtAddress3.Text = _cp.AgentAddress3;
                txtAddress4.Text = _cp.AgentAddress4;
                txtAddress5.Text = _cp.AgentCity + ' ' + _cp.AgentState + ' ' + _cp.AgentZip;
                txtBirthday.Text = _cp.AgentBirthDate;
                txtSSN.Text = _cp.AgentSSN;
                txtPhone.Text = _cp.AgentPhone;
            }
            else
            {
                txtInsuredName.Text = _cp.InsuredName;
                lblInsuredName.Text = "Insured Name:";
                txtAddress1.Text = _cp.Address1;
                txtAddress2.Text = _cp.Address2;
                txtAddress3.Text = _cp.Address3;
                txtAddress4.Text = _cp.Address4;
                txtAddress5.Text = _cp.City + ' ' + _cp.State + ' ' + _cp.ZipCode;
                txtBirthday.Text = _cp.BirthDate;
                txtSSN.Text = _cp.SSN;
                txtPhone.Text = _cp.Phone;
            }
            txtID.Text = _cp.ID;
            txtSystemNo.Text = _cp.SystemNo;
            txtCompanyNo.Text = _cp.CompanyNo;
            txtStatus.Text = _cp.Status;
            txtLineofBusiness.Text = _cp.LineOfBusiness;
            txtProduct.Text = _cp.Product;
            txtPlanCode.Text = _cp.PlanCode;
            txtTerminatedDate.Text = _cp.TerminatedDate;
            //txtGroupNumber.Text = _cp.GroupNo;
            txtIssueState.Text = _cp.IssueState;
            txtIssueDate.Text = _cp.IssueDate;
            txtStatusReason.Text = _cp.StatusReason;
            txtRelationship.Text = _cp.Relationship;

            //populate the ba
            if (_cp.BusinessArea.Length != 0)
            {
                int intBAIndex = cboBusinessArea.FindString(_cp.BusinessArea);
                cboBusinessArea.SelectedIndex = intBAIndex;
            }
            //start the user in the worktype dropdown, provided it is available
            if (cboWorkType.Enabled == true)
            {
                cboWorkType.Select();
            }
            //default the awd hierarchy to the standard transaction/source
            listAWDHierarchy.SelectedIndex = _defaultSelection;

            //AR 145620
            //Set focus on the field that needs to be filled next
            setFocus();

        }
        private void resizeForm()
        {
            //check to see if there are any custom required fields
            //if not, then hide the frame and move everything up
            if (lblCustomReq1.Visible == false & lblCustomReq2.Visible == false
               & lblCustomReq3.Visible == false & lblCustomReq4.Visible == false
               & lblCustomReq5.Visible == false & lblCustomReq6.Visible == false)
            {
                fraRequired.Visible = false;
                switch (_cp.IndexType)
                {
                    case "AWD":
                        pnlAWD.Top = grpSelectedInfo.Height + 10;
                        pnlCustomFields.Top = pnlAWD.Top + pnlAWD.Height;
                        this.Height = pnlAWD.Bottom + 10;
                        pnlAWD.Visible = true;
                        fraDocustream.Visible = false;
                        break;
                    case "DST":
                        fraDocustream.Top = grpSelectedInfo.Height + 10;
                        pnlCustomFields.Top = fraDocustream.Top + fraDocustream.Height;
                        this.Height = fraDocustream.Bottom + 10;
                        pnlAWD.Visible = false;
                        fraDocustream.Visible = true;
                        break;
                    default:
                        pnlCustomFields.Top = grpSelectedInfo.Height + 10;
                        pnlAWD.Visible = false;
                        fraDocustream.Visible = false;
                        this.Height = pnlCustomFields.Top;
                        break;
                }
            }
            else
            {
                if (lblCustomReq5.Visible == true | lblCustomReq6.Visible == true)
                {
                    fraRequired.Height = lblCustomReq5.Top + lblCustomReq5.Height + 10;
                }
                else if (lblCustomReq3.Visible == true | lblCustomReq4.Visible == true)
                {
                    fraRequired.Height = lblCustomReq3.Top + lblCustomReq3.Height + 10;
                }
                else if (lblCustomReq1.Visible == true | lblCustomReq2.Visible == true)
                {
                    fraRequired.Height = lblCustomReq1.Top + lblCustomReq1.Height + 10;
                }
                switch (_cp.IndexType)
                {

                    case "AWD":
                        //we need to show the AWD specific fields next
                        pnlAWD.Top = fraRequired.Top + fraRequired.Height + 10;
                        pnlCustomFields.Top = pnlAWD.Top + pnlAWD.Height;
                        this.Height = pnlCustomFields.Top;
                        pnlAWD.Visible = true;
                        fraDocustream.Visible = false;
                        break;
                    case "DST":
                        //we need to show the Docustream specific fields next
                        fraDocustream.Top = fraRequired.Top + fraRequired.Height + 10;
                        pnlCustomFields.Top = fraDocustream.Top + fraDocustream.Height;
                        this.Height = pnlCustomFields.Top;
                        pnlAWD.Visible = false;
                        fraDocustream.Visible = true;
                        break;
                    default:
                        pnlAWD.Visible = false;
                        fraDocustream.Visible = false;
                        pnlCustomFields.Top = fraRequired.Top + fraRequired.Height + 10;
                        this.Height = pnlCustomFields.Top;
                        break;
                }

            }
            //

            //resize the rest of the form based on what is visible
            if (lblCustom19.Visible == true | lblCustom20.Visible == true)
            {
                this.Height += lblCustom19.Top + 100;
            }
            else if (lblCustom17.Visible == true | lblCustom18.Visible == true)
            {
                this.Height += lblCustom17.Top + 100;
            }
            else if (lblCustom15.Visible == true | lblCustom16.Visible == true)
            {
                this.Height += lblCustom15.Top + 100;
            }
            else if (lblCustom13.Visible == true | lblCustom13.Visible == true)
            {
                this.Height += lblCustom13.Top + 100;
            }
            else if (lblCustom11.Visible == true | lblCustom12.Visible == true)
            {
                this.Height += lblCustom11.Top + 100;
            }
            else if (lblCustom9.Visible == true | lblCustom10.Visible == true)
            {
                this.Height += lblCustom9.Top + 100;
            }
            else if (lblCustom7.Visible == true | lblCustom8.Visible == true)
            {
                this.Height += lblCustom7.Top + 100;
            }
            else if (lblCustom5.Visible == true | lblCustom6.Visible == true)
            {
                this.Height += lblCustom5.Top + 100;
            }
            else if (lblCustom3.Visible == true | lblCustom4.Visible == true)
            {
                this.Height += lblCustom3.Top + 100;
            }
            else if (lblCustom1.Visible == true | lblCustom2.Visible == true)
            {
                this.Height += lblCustom1.Top + 100;
            }
            else
            {
                pnlCustomFields.Visible = false;
                this.Height += 80;
            }
        }
        #endregion
        #region Form Buttons
        private void btnComplete_Click(object sender, EventArgs e)
        {
            DataHandler.DataAccess dataAccess = new DataAccess();
            dataAccess.createDDUserTracking(ref _cp, "Complete", "");
            //placeholder for return value
            int returnValue = 0;
            //the form needs to be validated to ensure required values exist
            returnValue = validateForm();
            if (returnValue != 0)
            {
                return;
            }
            //now we can leave

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void    btnContinue_Click(object sender, EventArgs e)
        {
            DataHandler.DataAccess dataAccess = new DataAccess();
            dataAccess.createDDUserTracking(ref _cp, "Continue", "");
            //placeholder for return value
            int returnValue = 0;
            //the form needs to be validated to ensure required values exist
            returnValue = validateForm();
            if (returnValue != 0)
            {
                return;
            }
            //now we can leave

            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //now we can leave
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnReSearch_Click(object sender, EventArgs e)
        {
            DataHandler.DataAccess dataAccess = new DataAccess();
            dataAccess.createDDUserTracking(ref _cp, "Re-Search", "");

            //now we can leave
            this.DialogResult = DialogResult.Ignore;
            this.Close();
        }
        private void btnBridge_Click(object sender, EventArgs e)
        {
            frmBridge formBridge = new frmBridge("AWD");
            formBridge.SiteID = _cp.SiteID;
            formBridge.WorkCategory = _cp.WorkCategory;
            DialogResult formReturn = formBridge.ShowDialog();

            switch (formReturn)
            {
                case DialogResult.Abort:
                    _cp.SiteID = formBridge.SiteID;
                    _cp.WorkCategory = formBridge.WorkCategory;
                    this.DialogResult = DialogResult.Abort;
                    break;
                default:
                    this.DialogResult = DialogResult.Cancel;
                    break;
            }

        }
        #endregion
        #region Form Dropdowns
        private void cboBusinessArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear out any previous selection
            cboWorkType.Text = "";
            cboWorkType.Items.Clear();
            if (cboBusinessArea.SelectedIndex >= 0)
            {
                //update the ba selected
                _cp.BusinessArea = cboBusinessArea.SelectedItem.ToString();
                //and then load/re-load the items        
                loadWT();
                //just in case the user already changed the hierarchy list
                if (listAWDHierarchy.SelectedItem != null)
                {
                    listCaseWorkTypes.Text = "";
                    listCaseWorkTypes.Items.Clear();
                    setupAWDierarchy();
                    if (listCaseWorkTypes.Items.Count == 1)
                    {
                        //default to the first item
                        listCaseWorkTypes.SelectedIndex = 0;
                    }
                }
            }
        }

        //private void cboSystemID_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //set the system id value the user selected
        //    _cp.SystemID = cboSystemID.SelectedItem.ToString();
        //    //clear out any previous selection
        //    cboCompanyCode.Text = "";
        //    cboCompanyCode.Items.Clear();
        //    //and then load/re-load the items
        //    loadCompany();
        //}
        private void cboWorkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if a user selects a worktype, then 
            //based on the site id and work category, 
            //perform bundling if required
            if (_cp.SiteID == "CIC" && _cp.WorkCategory == "CLM")
            {
                _cp.WorkType = cboWorkType.SelectedItem.ToString();
                performBundling();
            }
        }
        private void listAWDHierarchy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //is it a valid selection
            validateHierarchySelection(listAWDHierarchy.SelectedItem.ToString());

            //we need to take action based on the new selection
            //if the ba has been selected take the following action
            if (cboBusinessArea.SelectedItem != null)
            {
                _cp.BusinessArea = cboBusinessArea.SelectedItem.ToString();
                setupAWDierarchy();
            }
        }
        private void listCaseWorkTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCaseWorkTypes.SelectedItem != null)
            {
                _cp.CaseWorkType = listCaseWorkTypes.SelectedItem.ToString();
            }
        }
        private int validateHierarchySelection(string selectedItem)
        {
            int returnVal = validHierarchySelection(selectedItem);
            switch (returnVal)
            {
                case 0:
                    //validation successful
                    break;
                case -1:
                    //no previous item to continue
                    MessageBox.Show("A previous item is required for this selection.",
                       "Invalid Selection", MessageBoxButtons.OK);
                    listCaseWorkTypes.SelectedIndex = -1;
                    listAWDHierarchy.SelectedIndex = _defaultSelection;
                    break;
                case -2:
                    //specific item to continue does not exist
                    MessageBox.Show("An open case is required for this selection.",
                       "Invalid Selection", MessageBoxButtons.OK);
                    listCaseWorkTypes.SelectedIndex = -1;
                    listAWDHierarchy.SelectedIndex = _defaultSelection;
                    break;
                case -3:
                    //specific item to continue does not exist
                    MessageBox.Show("An open workitem is required for this selection.",
                       "Invalid Selection", MessageBoxButtons.OK);
                    listCaseWorkTypes.SelectedIndex = -1;
                    listAWDHierarchy.SelectedIndex = _defaultSelection;
                    break;
            }
            return returnVal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedItem"></param>
        /// <returns> 0 = Success
        ///          -1 = Can't continue first item
        ///          -2 = Can't continue case without existing case
        ///          -3 = can't continue workitem without existing workitem
        /// </returns>
        private int validHierarchySelection(string selectedItem)
        {
            try
            {
                //first determine
                if (_cp.PreviousNodeID.Length == 0 | _cp.PreviousNodeID == "0")
                {
                    switch (selectedItem)
                    {
                        case "Continue Case w/WorkItem":
                        case "Add Source to WorkItem":
                        case "Continue Stnd WorkItem":
                        case "Add Source to Case":
                            return -1;
                    }
                }
                else
                {
                    switch (selectedItem)
                    {
                        case "Add Source to Case":
                        case "Continue Case w/WorkItem":
                            //case must exist
                            if (_cp.AWDCaseIDPrevious.ToString().Length == 0 || _cp.AWDCaseIDPrevious <= 0)
                            {
                                return -2;
                            }
                            break;
                        case "Add Source to WorkItem":
                        case "Continue Stnd WorkItem":
                            //workitem must exist
                            if (_cp.AWDTranIDPrevious.ToString().Length == 0 || _cp.AWDTranIDPrevious <= 0)
                            {
                                return -3;
                            }
                            break;
                    }
                }
            }
            catch
            {
            }
            return 0;
        }
        private void setupAWDierarchy()
        {
            switch (listAWDHierarchy.SelectedItem.ToString())
            {
                case "Start Case w/WorkItem":
                    loadCaseWT();
                    listCaseWorkTypes.Enabled = true;

                    cboWorkType.Enabled = true;
                    break;
                case "Continue Case w/WorkItem":
                    listCaseWorkTypes.SelectedIndex = -1;
                    listCaseWorkTypes.Enabled = false;
                    cboWorkType.Enabled = true;
                    break;
                case "Add Source to WorkItem":
                case "Continue Stnd WorkItem":
                    listCaseWorkTypes.SelectedIndex = -1;
                    listCaseWorkTypes.Enabled = false;
                    cboWorkType.Enabled = true;
                    break;
                case "Begin Case w/Source":
                    loadCaseWT();
                    listCaseWorkTypes.Enabled = true;
                    cboWorkType.SelectedIndex = -1;
                    cboWorkType.Enabled = false;
                    break;
                case "Add Source to Case":
                    loadCaseWT();
                    listCaseWorkTypes.Enabled = true;
                    cboWorkType.SelectedIndex = -1;
                    cboWorkType.Enabled = false;
                    break;
                case "New Stnd WorkItem":
                    listCaseWorkTypes.SelectedIndex = -1;
                    listCaseWorkTypes.Enabled = false;
                    cboWorkType.Enabled = true;
                    break;
                default:
                    listCaseWorkTypes.SelectedIndex = -1;
                    listCaseWorkTypes.Enabled = false;
                    cboWorkType.Enabled = true;
                    break;
            }
        }
        #endregion
        #region Form Population
        private void performBundling()
        {
            try
            {
                //first we need to determine if bundling is required or not
                string bundleFlag = getBundleFlag();
                if (bundleFlag.ToUpper() == "Y")
                {
                    //next we need to check the worktype exclusion list
                    bool isBundleNeeded = _dataAccess.IsWorkTypeExcluded(ref _cp);
                    if (isBundleNeeded == false)
                    {
                        return;
                    }
                    //if we get here the the document requires bundling
                    //, so prompt the user for what they want to do
                    DialogResult returnVal = MessageBox.Show(
                       "This document will require a bundle number."
                       + "\n\rShould the system create the bundle at this time?",
                       "Bundle Required", MessageBoxButtons.YesNo);
                    if (returnVal == DialogResult.No)
                    {
                        return;
                    }
                    //the user has decided to generate the required bundle number
                    //call out to the webservice and generate a bundle number
                    string bundleNo = _serviceCalls.generateBundleNo(ref _cp);
                    if (bundleNo.Length != 0)
                    {
                        _cp.BundleNo = bundleNo;
                        populateCustom("BundleNo", _cp.BundleNo, true);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("frmIndex.performBundling: " + ex.Message);
            }
        }
        private string getBundleFlag()
        {
            string bundleFlag = _dataAccess.getBundleFlag(ref _cp);
            return bundleFlag;
        }
        private void loadAWDHierarchy()
        {
            try
            {
                _awdHierarchy = _dataAccess.getAWDHierarchy(ref _cp);
                foreach (DataRow dr in _awdHierarchy.Tables[0].Rows)
                {
                    int defaultSelection = listAWDHierarchy.Items.Add
                        (dr["STRUCTURE_SELECTION"].ToString());
                    if (dr["DEFAULT_SELECTION"].ToString() == "Y")
                    {
                        _defaultSelection = defaultSelection;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("MVI.frmAWD.LoadAWDHierarchy: " + ex.Message);
            }
        }
        private void loadBA()
        {
            List<string> baValues = _dataAccess.getBAList(ref _cp);
            foreach (string ba in baValues)
            {
                cboBusinessArea.Items.Add(ba);
            }
            if (cboBusinessArea.Items.Count == 1)
            {
                //default to the first item
                cboBusinessArea.SelectedIndex = 0;
            }
        }
        private void loadWT()
        {
            List<string> wtValues = _dataAccess.getWTList(ref _cp);
            foreach (string wt in wtValues)
            {
                cboWorkType.Items.Add(wt);
            }
            //now that we've loaded values, we can enable this
            cboWorkType.Enabled = true;
            if (cboWorkType.Items.Count == 1)
            {
                //default to the first item
                cboWorkType.SelectedIndex = 0;
            }
            else
            {
                if (cboWorkType.Items.Contains(_cp.WorkType))
                {
                    int itemLocation = cboWorkType.Items.IndexOf(_cp.WorkType);
                    cboWorkType.SelectedIndex = itemLocation;
                }
            }
        }
        private void loadCaseWT()
        {
            List<string> wtValues = _dataAccess.getCaseWT(ref _cp);
            foreach (string wt in wtValues)
            {
                listCaseWorkTypes.Items.Add(wt);
            }
            if (listCaseWorkTypes.Items.Count == 1)
            {
                //default to the first item
                listCaseWorkTypes.SelectedIndex = 0;
            }
            else
            {
                if (listCaseWorkTypes.Items.Contains(_cp.CaseWorkType))
                {
                    int itemLocation = listCaseWorkTypes.Items.IndexOf(_cp.CaseWorkType);
                    listCaseWorkTypes.SelectedIndex = itemLocation;
                }
            }
        }
        private void loadCustomFields()
        {
            //pull back a dataset of the fields needed for the current work category
            _dataAccess.getMVIFieldData(ref _cp);
            foreach (DataRow dr in _cp._MVIFieldData.Tables["DD_MVI_FIELD_DEFINITION"].Select(null, "LOCATION, FIELD_ORDER"))
            {
                if (dr["VISIBLE"].ToString() == "T")
                {
                    switch (dr["LOCATION"].ToString())
                    {
                        case "R":
                            switch (dr["FIELD_ORDER"].ToString())
                            {
                                case "1":
                                    loadCustom(lblCustomReq1, mcbCustomReq1, _cp.CustomReqIndexProperty1, dr, chkCustomReq1);
                                    break;
                                case "2":
                                    loadCustom(lblCustomReq2, mcbCustomReq2, _cp.CustomReqIndexProperty2, dr, chkCustomReq2);
                                    break;
                                case "3":
                                    loadCustom(lblCustomReq3, mcbCustomReq3, _cp.CustomReqIndexProperty3, dr, chkCustomReq3);
                                    break;
                                case "4":
                                    loadCustom(lblCustomReq4, mcbCustomReq4, _cp.CustomReqIndexProperty4, dr, chkCustomReq4);
                                    break;
                                case "5":
                                    loadCustom(lblCustomReq5, mcbCustomReq5, _cp.CustomReqIndexProperty5, dr, chkCustomReq5);
                                    break;
                                case "6":
                                    loadCustom(lblCustomReq6, mcbCustomReq6, _cp.CustomReqIndexProperty6, dr, chkCustomReq6);
                                    break;
                            }
                            break;
                        case "C":
                            switch (dr["FIELD_ORDER"].ToString())
                            {
                                case "1":
                                    loadCustom(lblCustom1, mcbCustom1, _cp.CustomIndexProperty1, dr, chkCustom1);
                                    break;
                                case "2":
                                    loadCustom(lblCustom2, mcbCustom2, _cp.CustomIndexProperty2, dr, chkCustom2);
                                    break;
                                case "3":
                                    loadCustom(lblCustom3, mcbCustom3, _cp.CustomIndexProperty3, dr, chkCustom3);
                                    break;
                                case "4":
                                    loadCustom(lblCustom4, mcbCustom4, _cp.CustomIndexProperty4, dr, chkCustom4);
                                    break;
                                case "5":
                                    loadCustom(lblCustom5, mcbCustom5, _cp.CustomIndexProperty5, dr, chkCustom5);
                                    break;
                                case "6":
                                    loadCustom(lblCustom6, mcbCustom6, _cp.CustomIndexProperty6, dr, chkCustom6);
                                    break;
                                case "7":
                                    loadCustom(lblCustom7, mcbCustom7, _cp.CustomIndexProperty7, dr, chkCustom7);
                                    break;
                                case "8":
                                    loadCustom(lblCustom8, mcbCustom8, _cp.CustomIndexProperty8, dr, chkCustom8);
                                    break;
                                case "9":
                                    loadCustom(lblCustom9, mcbCustom9, _cp.CustomIndexProperty9, dr, chkCustom9);
                                    break;
                                case "10":
                                    loadCustom(lblCustom10, mcbCustom10, _cp.CustomIndexProperty10, dr, chkCustom10);
                                    break;
                                case "11":
                                    loadCustom(lblCustom11, mcbCustom11, _cp.CustomIndexProperty11, dr, chkCustom11);
                                    break;
                                case "12":
                                    loadCustom(lblCustom12, mcbCustom12, _cp.CustomIndexProperty12, dr, chkCustom12);
                                    break;
                                case "13":
                                    loadCustom(lblCustom13, mcbCustom13, _cp.CustomIndexProperty13, dr, chkCustom13);
                                    break;
                                case "14":
                                    loadCustom(lblCustom14, mcbCustom14, _cp.CustomIndexProperty14, dr, chkCustom14);
                                    break;
                                case "15":
                                    loadCustom(lblCustom15, mcbCustom15, _cp.CustomIndexProperty15, dr, chkCustom15);
                                    break;
                                case "16":
                                    loadCustom(lblCustom16, mcbCustom16, _cp.CustomIndexProperty16, dr, chkCustom16);
                                    break;
                                case "17":
                                    loadCustom(lblCustom17, mcbCustom17, _cp.CustomIndexProperty17, dr, chkCustom17);
                                    break;
                                case "18":
                                    loadCustom(lblCustom18, mcbCustom18, _cp.CustomIndexProperty18, dr, chkCustom18);
                                    break;
                                case "19":
                                    loadCustom(lblCustom19, mcbCustom19, _cp.CustomIndexProperty19, dr, chkCustom19);
                                    break;
                                case "20":
                                    loadCustom(lblCustom20, mcbCustom20, _cp.CustomIndexProperty20, dr, chkCustom20);
                                    break;
                            }
                            break;
                    }
                }
                else
                {
                    //try to set cp value to default value if needed
                    if (dr["DEFAULT_VALUE"].ToString().Length > 0 && _cp[dr["FIELD_NAME"].ToString()].ToString().Length == 0)
                    {
                        _cp[dr["FIELD_NAME"].ToString()] = dr["DEFAULT_VALUE"].ToString();
                    }
                }
            }

            //check for sticky values
            if (_cp.BatchNo == _prevcp.BatchNo && _cp.SiteID == _prevcp.SiteID &&
               _cp.WorkCategory == _prevcp.WorkCategory && _cp.EnvelopeNodeID == _prevcp.EnvelopeNodeID)
            {
                if (_prevcp.RememberCertifiedNo)
                {
                    _cp.CertifiedNo = _prevcp.CertifiedNo;
                    this.txtCertifiedNo.Text = _cp.CertifiedNo;
                    this.chkCertified.Checked = true;
                }
                else
                {
                    this.chkCertified.Checked = false;
                }
                if (_prevcp.RememberBusinessArea)
                {
                    _cp.BusinessArea = _prevcp.BusinessArea;
                    int intBAIndex = cboBusinessArea.FindString(_cp.BusinessArea);
                    cboBusinessArea.SelectedIndex = intBAIndex;
                    this.chkBusinessArea.Checked = true;
                }
                else
                {
                    this.chkBusinessArea.Checked = false;
                }
                if (_prevcp.RememberWorkType)
                {
                    _cp.WorkType = _prevcp.WorkType;
                    int intWTIndex = cboWorkType.FindString(_cp.WorkType);
                    cboWorkType.SelectedIndex = intWTIndex;
                    this.chkWorkType.Checked = true;
                }
                else
                {
                    this.chkWorkType.Checked = false;
                }

                foreach (DataRow dr in _prevcp._MVIFieldData.Tables["DD_MVI_FIELD_DEFINITION"].Rows)
                {
                    string FieldName = dr["FIELD_NAME"].ToString();
                    MaskedComboBox mcb = returnConditionalField(FieldName);
                    if (null != mcb)
                    {
                        if (dr["REMEMBER_VALUES_CHECKED"].ToString() == "T")
                        {
                            mcb.RememberValueCheckBox.Checked = true;
                            if (mcb.ShowDropDown == true)
                            {
                                ComboBoxItem cbi = findComboBoxItem(dr["LOCAL_VALUE"].ToString(), mcb);
                                if (cbi != null)
                                {
                                    mcb.SelectedItem = cbi;
                                }
                            }
                            else
                            {
                                mcb.Text = dr["LOCAL_VALUE"].ToString();
                            }
                        }
                        else
                        {
                            mcb.RememberValueCheckBox.Checked = false;
                        }
                    }
                }
            }
            else
            {
                //use routing definition to determine if remeber BA and WT should be 
                //checked by default
                if (_cp.RememberBAWT.Trim().ToUpper() == "T")
                {
                    this.chkBusinessArea.Checked = true;
                    this.chkWorkType.Checked = true;
                }
                else
                {
                    this.chkBusinessArea.Checked = false;
                    this.chkWorkType.Checked = false;

                }
            }
        }
        private void loadCustom(Label Field, MaskedComboBox mcb, String Value, DataRow DR, CheckBox cbRemember)
        {
            bool isLocked = false;

            //if CP does not have value sent in, check for default value in table
            if (Value.Length == 0)
            {
                if (DR["DEFAULT_VALUE"].ToString().Length > 0)
                {
                    Value = DR["DEFAULT_VALUE"].ToString();
                }
            }

            //set the label
            Field.Text = DR["FIELD_LABEL"].ToString();
            //determine if Remember Value checkbox should be visible
            if (DR["REMEMBER_VALUES"].ToString() == "T")
            {
                cbRemember.Visible = true;
            }

            //determine if the object should allow edits or not
            if (DR["LOCKED"].ToString() == "T")
            {
                isLocked = true;
            }
            int maxLength = 0;
            int.TryParse(DR["MAX_LENGTH"].ToString(), out maxLength);
            if (maxLength > 0)
            {
                mcb.MaxLength = maxLength;

            }
            //load up the dropdown
            if (DR["FIELD_TYPE"].ToString() == "DDL")
            {
                populateDrowDown(mcb, DR, Value);
                //make sure the text box is hidden
                mcb.ShowDropDown = true;
                //and show the dropdown

            }
            else
            {
                mcb.ShowDropDown = false;
                //apply the mask
                if (DR["MASK"].ToString().Length > 0)
                {
                    mcb.Mask = DR["MASK"].ToString();
                }
                //first we try to set the field based on the common parameter value
                string fieldname = DR["FIELD_NAME"].ToString();


                string cpvalue;

                //AR 145620 - Added null validation below
                if (_cp[fieldname] != null)
                {
                    cpvalue = _cp[fieldname].ToString();
                }
                else
                {
                    cpvalue = String.Empty;
                }

                mcb.Text = cpvalue;
                //next check to see if a custom value was sent... if so, override
                if (Value.Trim().Length > 0)
                {
                    mcb.Text = Value;
                }

            }
            mcb.Tag = DR["FIELD_NAME"].ToString();
            mcb.Visible = true;
            Field.Visible = true;
            if (isLocked == true)
            {
                mcb.Enabled = false;
                mcb.BackColor = Color.White;
            }
        }

        /// <summary>
        /// This function sets the focus of the cursor on the field that is BLANK on index screen.
        /// </summary>
        private void setFocus()
        {
            try
            {
                foreach (DataRow dr in _cp._MVIFieldData.Tables["DD_MVI_FIELD_DEFINITION"].Select(null, "LOCATION, FIELD_ORDER"))
                {
                    if (dr["VISIBLE"].ToString() == "T")
                    {
                        switch (dr["LOCATION"].ToString())
                        {
                            case "R":
                                switch (dr["FIELD_ORDER"].ToString())
                                {
                                    case "1":
                                        if (mcbCustomReq1.Text == "" && _isFocus == false)
                                        {
                                            mcbCustomReq1.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "2":
                                        if (mcbCustomReq2.Text == "" && _isFocus == false)
                                        {
                                            mcbCustomReq2.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "3":
                                        if (mcbCustomReq3.Text == "" && _isFocus == false)
                                        {
                                            mcbCustomReq3.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "4":
                                        if (mcbCustomReq4.Text == "" && _isFocus == false)
                                        {
                                            mcbCustomReq4.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "5":
                                        if (mcbCustomReq5.Text == "" && _isFocus == false)
                                        {
                                            mcbCustomReq5.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "6":
                                        if (mcbCustomReq6.Text == "" && _isFocus == false)
                                        {
                                            mcbCustomReq6.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                }
                                break;
                            case "C":
                                switch (dr["FIELD_ORDER"].ToString())
                                {
                                    case "1":
                                        if (mcbCustom1.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom1.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "2":
                                        if (mcbCustom2.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom2.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "3":
                                        if (mcbCustom3.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom3.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "4":
                                        if (mcbCustom4.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom4.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "5":
                                        if (mcbCustom5.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom5.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "6":
                                        if (mcbCustom6.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom6.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "7":
                                        if (mcbCustom7.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom7.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "8":
                                        if (mcbCustom8.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom8.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "9":
                                        if (mcbCustom9.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom9.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "10":
                                        if (mcbCustom10.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom10.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "11":
                                        if (mcbCustom11.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom11.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "12":
                                        if (mcbCustom12.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom12.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "13":
                                        if (mcbCustom13.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom13.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "14":
                                        if (mcbCustom14.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom14.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "15":
                                        if (mcbCustom15.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom15.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "16":
                                        if (mcbCustom16.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom16.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "17":
                                        if (mcbCustom17.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom17.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "18":
                                        if (mcbCustom18.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom18.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "19":
                                        if (mcbCustom19.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom19.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                    case "20":
                                        if (mcbCustom20.Text == "" && _isFocus == false)
                                        {
                                            mcbCustom20.Focus();
                                            _isFocus = true;
                                        }
                                        break;
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populateDrowDown(MaskedComboBox mcb, DataRow DR, string Value)
        {
            mcb.Items.Clear();
            mcb.Text = "";
            DataRow[] foundRows;
            mcb.Tag = DR["FIELD_NAME"].ToString();
            string searchFilter = "FIELD_NAME = '" + DR["FIELD_NAME"].ToString() + "'";
            //look for a parent for additional Filter criteria
            string parent = DR["FIELD_NAME_PARENT"].ToString();
            if (parent.Length != 0)
            {
                //find value of parent
                object parentValue = _cp[parent];
                searchFilter = searchFilter + " and FIELD_NAME_PARENT_VALUE = '" + parentValue.ToString() + "'";
            }
            foundRows = _cp._MVIFieldData.Tables["DD_MVI_FIELD_CHOICES"].Select(searchFilter, "CHOICE_DISPLAY ASC");

            foreach (DataRow dr in foundRows)
            {
                mcb.ValueMember = "Value";
                mcb.DisplayMember = "Display";
                //int itemLoc = Dropdown.Items.Add(dr["CHOICE_DISPLAY"].ToString());
                string display = dr["CHOICE_DISPLAY"].ToString();
                string value = dr["CHOICE_VALUE"].ToString();
                string docType = dr["DOCUMENT_TYPE"].ToString();
                string fDocClassName = dr["F_DOCCLASSNAME"].ToString();
                string lineOfBusiness = dr["LINE_OF_BUSINESS"].ToString();
                string FNP8_DocClassName = dr["FNP8_DOCCLASSNAME"].ToString();
                string FNP8_ObjectStore = dr["FNP8_OBJECTSTORE"].ToString();
                string FNP8_Folder = dr["FNP8_FOLDER"].ToString();




                int itemLoc = mcb.Items.Add(new ComboBoxItem(display, value, docType, fDocClassName, lineOfBusiness, FNP8_DocClassName, FNP8_ObjectStore, FNP8_Folder));

                if (dr["DEFAULT_CHOICE"].ToString() == "T")
                {
                    mcb.SelectedIndex = itemLoc;
                }
            }

            if (mcb.Items.Count == 1)
            {
                //default to the first item
                mcb.SelectedIndex = 0;
                // set cp value
                _cp[mcb.Tag.ToString()] = mcb.Text;
            }
            else
            {
                string cpValue = _cp[DR["FIELD_NAME"].ToString()].ToString();
                //first we try to set the field based on the common parameter value
                if (cpValue.Length > 0)
                {
                    ComboBoxItem cbi = findComboBoxItem(cpValue, mcb);
                    if (cbi != null)
                    {
                        mcb.SelectedItem = cbi;
                    }

                }
                //next check to see if a custom value was sent... if so, override
                if (Value.Trim().Length > 0)
                {
                    ComboBoxItem cbi = findComboBoxItem(Value, mcb);
                    if (cbi != null)
                    {
                        mcb.SelectedItem = cbi;
                    }

                }
            }
        }
        private ComboBoxItem findComboBoxItem(string Value, MaskedComboBox mcb)
        {
            foreach (ComboBoxItem cbi in mcb.Items)
            {
                if (cbi.Value == Value)
                {
                    return cbi;
                }
            }
            return null;
        }
        private void populateCustom(string tag, string value, bool lockDesired)
        {
            foreach (MaskedComboBox mcb in _mcbs)
            {

                if (null != mcb.Tag && mcb.Tag.ToString() == tag)
                {
                    mcb.Text = value;
                    mcb.Enabled = !lockDesired;
                }

            }
        }
        #endregion
        #region Form Validations
        private int validateForm()
        {
            try
            {
                int returnValue = 0;

                //validate that at least one of the default required fields are filled out
                returnValue = validateRequiredFields();
                if (returnValue == -1)
                {
                    //there was an issue with the validation, and the user was notified
                    return -1;
                }
                //only worry about this if it is an AWD type
                if (_cp.IndexType.ToUpper() == "AWD")
                {
                    #region AWD Hierarchy Validation
                    //see if selection is valid
                    int validHierarchy = validateHierarchySelection(listAWDHierarchy.SelectedItem.ToString());
                    if (validHierarchy != 0)
                    {
                        //there was an issue with the validation, and the user was notified
                        return -1;
                    }
                    //pull out the values from the structure selection
                    DataRow selectedStructure = _awdHierarchy.Hierarchy.Rows[listAWDHierarchy.SelectedIndex];
                    switch (selectedStructure["STRUCTURE_SELECTION"].ToString())
                    {
                        case "Continue Case w/WorkItem":
                            _cp.AWDCaseID = _cp.AWDCaseIDPrevious;
                            _cp.AWDTranID = Convert.ToInt32(selectedStructure["TRANSACTION_ID"]);
                            _cp.AWDRequestID = _cp.AWDRequestIDPrevious;
                            break;
                        case "Add Source to WorkItem":
                        case "Continue Stnd WorkItem":
                            if (_cp.AWDCaseIDPrevious.ToString().Length == 0 || _cp.AWDCaseIDPrevious == 0)
                            {
                                _cp.AWDCaseID = -1;
                            }
                            else
                            {
                                _cp.AWDCaseID = _cp.AWDCaseIDPrevious;
                            }
                            _cp.AWDTranID = _cp.AWDTranIDPrevious;
                            _cp.AWDRequestID = _cp.AWDRequestIDPrevious;
                            break;
                        case "Add Source to Case":
                            _cp.AWDCaseID = _cp.AWDCaseIDPrevious;
                            _cp.AWDTranID = Convert.ToInt32(selectedStructure["TRANSACTION_ID"]);
                            _cp.AWDRequestID = _cp.AWDRequestIDPrevious;
                            break;
                        case "Start Case w/WorkItem":
                        case "Begin Case w/Source":
                            if (listCaseWorkTypes.SelectedItem == null)
                            {
                                //they didn't select a case work type
                                MessageBox.Show("A Case Work Type must be selected in order to continue.",
                                    "Missing Required Field");
                                listCaseWorkTypes.Focus();
                                return -1;
                            }
                            else
                            {
                                _cp.CaseWorkType = listCaseWorkTypes.SelectedItem.ToString();
                                _cp.AWDCaseID = Convert.ToInt32(selectedStructure["CASE_ID"]);
                                _cp.AWDTranID = Convert.ToInt32(selectedStructure["TRANSACTION_ID"]);
                            }
                            break;
                        default:
                            _cp.AWDCaseID = Convert.ToInt32(selectedStructure["CASE_ID"]);
                            _cp.AWDTranID = Convert.ToInt32(selectedStructure["TRANSACTION_ID"]);
                            break;
                    }

                    #endregion

                    //now check to see if they picked a ba
                    if (cboBusinessArea.SelectedItem == null)
                    {
                        //they didn't select a buisness area
                        MessageBox.Show("A Buisness Area must be selected in order to continue.",
                            "Missing Required Field");
                        cboBusinessArea.Focus();
                        return -1;
                    }
                    else
                    {
                        //they filled out the business area
                        _cp.BusinessArea = cboBusinessArea.SelectedItem.ToString();
                    }
                    //check to see if they picked a work type
                    if (cboWorkType.Enabled)
                    {
                        if (cboWorkType.SelectedItem == null)
                        {
                            //they didn't select a work type
                            MessageBox.Show("A Work Type must be selected in order to continue.",
                                "Missing Required Field");
                            cboWorkType.Focus();
                            return -1;
                        }
                        else
                        {
                            //they filled out the business area
                            _cp.WorkType = cboWorkType.SelectedItem.ToString();
                        }
                    }
                    else
                    {
                        //clear the worktype
                        _cp.WorkType = String.Empty;
                    }
                }

                //now validate all of the custom fields are good
                returnValue = validateCustomFields();
                if (returnValue == -1)
                {
                    return -1;
                }
                //update dates to correct DB format
                Indexer indexer = new Indexer();
                indexer.formatDateFields(ref _cp);
                //populate table in CP with values
                foreach (DataRow dr in _cp._MVIFieldData.Tables["DD_MVI_FIELD_DEFINITION"].Rows)
                {

                    string FieldName = dr["FIELD_NAME"].ToString();
                    if (dr["VISIBLE"].ToString() == "T")
                    {
                        MaskedComboBox mcb = returnConditionalField(FieldName);
                        dr["LOCAL_VALUE"] = mcb.Text;
                        _cp[FieldName] = mcb.Text;
                        if (mcb.ShowDropDown && mcb.SelectedIndex >= 0)
                        {
                            //if it is a dropdown and the user selected a value...
                            ComboBoxItem cbi = (ComboBoxItem)mcb.SelectedItem;
                            //pull the actual value instead of the display
                            dr["LOCAL_VALUE"] = cbi.Value;
                            _cp[FieldName] = cbi.Value;
                            //look for default values for selected choice
                            if (cbi.DocType.Length > 0)
                            {
                                _cp.DocType = cbi.DocType;
                            }
                            if (cbi.FDocClassName.Length > 0)
                            {
                                _cp.FDocClassName = cbi.FDocClassName;
                            }
                            if (cbi.LineOfBusiness.Length > 0)
                            {
                                _cp.LineOfBusiness = cbi.LineOfBusiness;
                            }
                            if (cbi.FNP8_DOCCLASSNAME.Length > 0)
                            {
                                _cp.FNP8_DOCCLASSNAME = cbi.FNP8_DOCCLASSNAME;
                            }
                            if (cbi.FNP8_OBJECTSTORE.Length > 0)
                            {
                                _cp.FNP8_OBJECTSTORE = cbi.FNP8_OBJECTSTORE;
                            }
                            if (cbi.FNP8_FOLDER.Length > 0)
                            {
                                _cp.FNP8_FOLDER = cbi.FNP8_FOLDER;
                                _cp.FNP8_RECORDFILEDIN = cbi.FNP8_FOLDER;
                            }
                        }
                        if (mcb.RememberValueCheckBox.Visible && mcb.RememberValueCheckBox.Checked)
                        {
                            dr["REMEMBER_VALUES_CHECKED"] = "T";
                        }
                    }
                    else
                    {
                        dr["LOCAL_VALUE"] = _cp[FieldName].ToString();
                    }
                }

                //Only do docustream checks if it is going to docustream (DST)
                if (_cp.IndexType.ToUpper() == "DST")
                {
                    int hcfacount = 0;
                    int ubcount = 0;
                    int pheombcount = 0;
                    int eombcount = 0;

                    if (!int.TryParse(this.txtHCFACount.Text, out hcfacount) || hcfacount < 0)
                    {
                        MessageBox.Show("HCFA Count must be 0 or greater.",
                                          "Invalid Number");
                        txtHCFACount.Focus();
                        return -1;
                    }
                    if (!int.TryParse(this.txtUBCount.Text, out ubcount) || ubcount < 0)
                    {
                        MessageBox.Show("UB Count must be 0 or greater.",
                                          "Invalid Number");
                        txtUBCount.Focus();
                        return -1;
                    }
                    if (!int.TryParse(this.txtPHEOMBCount.Text, out pheombcount) || pheombcount < 0)
                    {
                        MessageBox.Show("PHEOMB Count must be 0 or greater.",
                                          "Invalid Number");
                        txtPHEOMBCount.Focus();
                        return -1;
                    }
                    if (!int.TryParse(this.txtEOMBCount.Text, out eombcount) || eombcount < 0)
                    {
                        MessageBox.Show("EOMB Count must be 0 or greater.",
                                          "Invalid Number");
                        txtEOMBCount.Focus();
                        return -1;
                    }
                    //There must be a minimum value of 1 in the HCFA or UB or PHEOMB count boxes
                    if ((hcfacount + ubcount + pheombcount) < 1)
                    {
                        MessageBox.Show("Total of HCFA, UB, and PHEOMB count must be 1 or greater.",
                              "Invalid Count");
                        txtHCFACount.Focus();
                        return -1;
                    }
                    else
                    {
                        //If there's a minimum value of 1 in either HCFA or UB, then there must be a minimum value of one in the EOMB or PHEOMB 
                        if ((hcfacount + ubcount) > 0 && (pheombcount + eombcount) < 1)
                        {
                            MessageBox.Show("If there's a minimum value of 1 in either HCFA or UB, then there must be a minimum value of one in the EOMB or PHEOMB",
                                        "Invalid Count");
                            txtHCFACount.Focus();
                            return -1;

                        }
                    }

                    _cp.CountHCFA = hcfacount.ToString();
                    _cp.CountUB92 = ubcount.ToString();
                    _cp.CountPHEOMB = pheombcount.ToString();
                    _cp.CountEOMB = eombcount.ToString();

                    if (hcfacount > 0)
                    {
                        _cp.FormName = "HCFA1500";
                    }
                    else if (ubcount > 0)
                    {
                        _cp.FormName = "UB92";
                        if (_cp.TypeOfBill.Length == 0)
                        {
                            MessageBox.Show("When the form is UB, Type of Bill is required.",
                               "TOB Required");
                            return -1;

                        }
                    }
                    else if (pheombcount > 0)
                    {
                        _cp.FormName = "PHEOMB";
                    }

                    _dataAccess.getRouteCode(ref _cp);
                    if (_cp.DocustreamCode.Length == 0)
                    {
                        string msg = String.Empty;
                        //this item does not route to docustream
                        //check for valid type of bill
                        if (_cp.FormName == "UB92" && false == _dataAccess.CheckTypeOfBill(ref _cp))
                        {
                            msg = " Type of Bill does not exist in lookup table.";
                        }

                        MessageBox.Show("This item does not route to Docustream." + msg,
                              "Invalid for Docustream");
                        return -1;

                    }
                }
                
                //lastly grab the certified no
                _cp.CertifiedNo = txtCertifiedNo.Text;
                _cp.RememberCertifiedNo = this.chkCertified.Checked;
                _cp.RememberBusinessArea = this.chkBusinessArea.Checked;
                _cp.RememberWorkType = this.chkWorkType.Checked;
                //and if we make it here... return all ok
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                   "Error");

                return -1;
            }
        }
        private int validateCustomFields()
        {
            foreach (DataRow dr in _cp._MVIFieldData.Tables["DD_MVI_FIELD_DEFINITION"].Rows)
            {
                if (dr["VISIBLE"].ToString() == "T")
                {
                    if (dr["LOCATION"].ToString() == "C")
                    {
                        switch (dr["FIELD_ORDER"].ToString())
                        {
                            case "1":
                                int returnValue = validateCustom(lblCustom1, mcbCustom1,
                                    _cp.CustomIndexProperty1Name, _cp.CustomIndexProperty1, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "2":
                                returnValue = validateCustom(lblCustom2, mcbCustom2,
                                    _cp.CustomIndexProperty2Name, _cp.CustomIndexProperty2, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "3":
                                returnValue = validateCustom(lblCustom3, mcbCustom3,
                                    _cp.CustomIndexProperty3Name, _cp.CustomIndexProperty3, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "4":
                                returnValue = validateCustom(lblCustom4, mcbCustom4,
                                    _cp.CustomIndexProperty4Name, _cp.CustomIndexProperty4, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "5":
                                returnValue = validateCustom(lblCustom5, mcbCustom5,
                                    _cp.CustomIndexProperty5Name, _cp.CustomIndexProperty5, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "6":
                                returnValue = validateCustom(lblCustom6, mcbCustom6,
                                    _cp.CustomIndexProperty6Name, _cp.CustomIndexProperty6, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "7":
                                returnValue = validateCustom(lblCustom7, mcbCustom7,
                                    _cp.CustomIndexProperty7Name, _cp.CustomIndexProperty7, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "8":
                                returnValue = validateCustom(lblCustom8, mcbCustom8,
                                    _cp.CustomIndexProperty8Name, _cp.CustomIndexProperty8, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "9":
                                returnValue = validateCustom(lblCustom9, mcbCustom9,
                                    _cp.CustomIndexProperty9Name, _cp.CustomIndexProperty9, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "10":
                                returnValue = validateCustom(lblCustom10, mcbCustom10,
                                    _cp.CustomIndexProperty10Name, _cp.CustomIndexProperty10, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "11":
                                returnValue = validateCustom(lblCustom11, mcbCustom11,
                                    _cp.CustomIndexProperty11Name, _cp.CustomIndexProperty11, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "12":
                                returnValue = validateCustom(lblCustom12, mcbCustom12,
                                    _cp.CustomIndexProperty12Name, _cp.CustomIndexProperty12, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "13":
                                returnValue = validateCustom(lblCustom13, mcbCustom13,
                                    _cp.CustomIndexProperty13Name, _cp.CustomIndexProperty13, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "14":
                                returnValue = validateCustom(lblCustom14, mcbCustom14,
                                    _cp.CustomIndexProperty14Name, _cp.CustomIndexProperty14, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "15":
                                returnValue = validateCustom(lblCustom15, mcbCustom15,
                                    _cp.CustomIndexProperty15Name, _cp.CustomIndexProperty15, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "16":
                                returnValue = validateCustom(lblCustom16, mcbCustom16,
                                    _cp.CustomIndexProperty16Name, _cp.CustomIndexProperty16, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "17":
                                returnValue = validateCustom(lblCustom17, mcbCustom17,
                                    _cp.CustomIndexProperty17Name, _cp.CustomIndexProperty17, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "18":
                                returnValue = validateCustom(lblCustom18, mcbCustom18,
                                    _cp.CustomIndexProperty18Name, _cp.CustomIndexProperty18, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "19":
                                returnValue = validateCustom(lblCustom19, mcbCustom19,
                                    _cp.CustomIndexProperty19Name, _cp.CustomIndexProperty19, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                            case "20":
                                returnValue = validateCustom(lblCustom20, mcbCustom20,
                                    _cp.CustomIndexProperty20Name, _cp.CustomIndexProperty20, dr);
                                if (returnValue == -1)
                                {
                                    return -1;
                                }
                                break;
                        }

                    }
                }
                //AR 145620 - START
                //If the field in DD_MVI_FIELD_DEFINITION is EFFECTIVE DATE
                //Add validation on Effective Date                
                if (dr["FIELD_NAME"].ToString().ToUpper() == "EFFECTIVEDATE")
                {
                    //The below validation is specific to CLM work category
                    if (_cp.WorkCategory == "CLM")
                    {
                        if (!String.IsNullOrEmpty(_cp.ReceivedDate))
                        {
                            switch (_cp.SiteID)
                            {
                                case "CIC":
                                    switch (_cp.SystemNo)
                                    {
                                        case "CIC":
                                        case "L7G":
                                        case "LCC":
                                        case "LLC":
                                        case "PPC":
                                            determineContestability("SHARP");
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
                                            determineContestability("LIFEPRO");
                                            break;
                                    }
                                    break;
                                case "BLC":
                                    switch (_cp.SystemNo)
                                    {
                                        case "CIB":
                                            determineContestability("SHARP");
                                            break;
                                        case "LPK":
                                        case "CIV":
                                            determineContestability("LIFEPRO");
                                            break;
                                    }
                                    break;
                            }
                        }
                    }
                }
                //AR 145620 - END
            }
            //if we make it through all the custom fields send the all ok
            return 0;
        }
        private int validateRequiredFields()
        {
            //validate the fields have been filled out 
            int combinedLength = 0;

            if (lblCustomReq1.Visible == true || lblCustomReq2.Visible == true
               || lblCustomReq3.Visible == true || lblCustomReq4.Visible == true
               || lblCustomReq5.Visible == true || lblCustomReq6.Visible == true)
            {
                foreach (DataRow dr in _cp._MVIFieldData.Tables["DD_MVI_FIELD_DEFINITION"].Rows)
                {
                    if (dr["VISIBLE"].ToString() == "T")
                    {
                        if (dr["LOCATION"].ToString() == "R")
                        {
                            switch (dr["FIELD_ORDER"].ToString())
                            {
                                case "1":
                                    int returnValue = validateRequired(lblCustomReq1, mcbCustomReq1,
                                        _cp.CustomReqIndexProperty1Name, _cp.CustomReqIndexProperty1, dr);
                                    if (returnValue > 0)
                                    {
                                        combinedLength += returnValue;
                                    }
                                    else if (returnValue == -1)
                                    {
                                        return -1;
                                    }
                                    break;
                                case "2":
                                    returnValue = validateRequired(lblCustomReq2, mcbCustomReq2,
                                        _cp.CustomReqIndexProperty2Name, _cp.CustomReqIndexProperty2, dr);
                                    if (returnValue > 0)
                                    {
                                        combinedLength += returnValue;
                                    }
                                    else if (returnValue == -1)
                                    {
                                        return -1;
                                    }
                                    break;
                                case "3":
                                    returnValue = validateRequired(lblCustomReq3, mcbCustomReq3,
                                        _cp.CustomReqIndexProperty3Name, _cp.CustomReqIndexProperty3, dr);
                                    if (returnValue > 0)
                                    {
                                        combinedLength += returnValue;
                                    }
                                    else if (returnValue == -1)
                                    {
                                        return -1;
                                    }
                                    break;
                                case "4":
                                    returnValue = validateRequired(lblCustomReq4, mcbCustomReq4,
                                        _cp.CustomReqIndexProperty4Name, _cp.CustomReqIndexProperty4, dr);
                                    if (returnValue > 0)
                                    {
                                        combinedLength += returnValue;
                                    }
                                    else if (returnValue == -1)
                                    {
                                        return -1;
                                    }
                                    break;
                                case "5":
                                    returnValue = validateRequired(lblCustomReq5, mcbCustomReq5,
                                        _cp.CustomReqIndexProperty5Name, _cp.CustomReqIndexProperty5, dr);
                                    if (returnValue > 0)
                                    {
                                        combinedLength += returnValue;
                                    }
                                    else if (returnValue == -1)
                                    {
                                        return -1;
                                    }
                                    break;
                                case "6":
                                    returnValue = validateRequired(lblCustomReq6, mcbCustomReq6,
                                        _cp.CustomReqIndexProperty6Name, _cp.CustomReqIndexProperty6, dr);
                                    if (returnValue > 0)
                                    {
                                        combinedLength += returnValue;
                                    }
                                    else if (returnValue == -1)
                                    {
                                        return -1;
                                    }
                                    break;
                            }
                        }
                    }
                }
                //now let's check to see if our combined length is greater than zero
                if (combinedLength == 0)
                {
                    //they didn't fill out any of them
                    MessageBox.Show("At least 1 of the required fields must have a value in order to continue.",
                        "Missing Required Field");
                    mcbCustomReq1.Focus();
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        private int validateRequired(Label Field, MaskedComboBox mcb, String Name, String Value, DataRow DR)
        {
            if (mcb.SelectedItem != null)
            {
                //they selected a custom dropdown item
                Value = mcb.SelectedItem.ToString();
                Name = DR["FIELD_NAME"].ToString();
                return Value.Length;
            }
            else if (mcb.Text.Length != 0)
            {
                //they filled out the text item
                Value = mcb.Text;
                Name = DR["FIELD_NAME"].ToString();
                //check to see if there is a field validation
                string regExpression = DR["VALIDATION"].ToString();
                if (regExpression.Length > 0)
                {
                    Regex rg = new Regex(regExpression);
                    if (!rg.IsMatch(Value))
                    {
                        MessageBox.Show("The " + Field.Text.ToString()
                           + " field did not pass validation.", "Field Validation");
                        return -1;
                    }
                }
                return Value.Length;
            }
            return 0;
        }

        private int validateCustom(Label Field, MaskedComboBox mcb, String Name, String Value, DataRow DR)
        {
            int returnValue = 1;

            if (mcb.SelectedItem != null)
            {
                //they selected a custom dropdown item
                ComboBoxItem myitem = (ComboBoxItem)mcb.SelectedItem;
                Value = myitem.Value;
                // Value = mcb.SelectedItem. /.SelectedItem.ToString();

                Name = DR["FIELD_NAME"].ToString();
                returnValue = 0;
            }
            else if (mcb.Text.Length != 0)
            {
                //they filled out the text item
                Value = mcb.Text;
                Name = DR["FIELD_NAME"].ToString();
                //check to see if there is a field validation
                string regExpression = DR["VALIDATION"].ToString();
                if (regExpression.Length > 0)
                {
                    Regex rg = new Regex(regExpression);
                    if (!rg.IsMatch(Value))
                    {
                        MessageBox.Show("The " + Field.Text.ToString()
                           + " field did not pass validation.", "Field Validation");
                        returnValue = -1;
                    }
                }
            }
            else
            {
                //check to see if we need to require the field
                if (DR["REQUIRED"].ToString() == "T")
                {
                    //they didn't select a custom dropdown item
                    MessageBox.Show("A " + Field.Text
                        + " must be present in order to continue.",
                        "Missing Required Field");

                    mcb.Focus();

                    //indicate missing required value
                    returnValue = -1;
                }
            }
                        
            //AR145620 - START
            //Add validation on Terminated Date
            if (DR["FIELD_NAME"].ToString() == "TerminatedDate")
            {
                //The below validation is specific to BLC/CLM combination
                if (_cp.SiteID == "BLC" && _cp.WorkCategory == "CLM")
                {
                    if (!String.IsNullOrEmpty(_cp.TerminatedDate))
                    {
                        if (!String.IsNullOrEmpty(_cp.ReceivedDate))
                        {
                            //Calculated no.of days between Received Date and Terminated Date
                            int intElapsedDays = (DateTime.Parse(_cp.ReceivedDate) - DateTime.Parse(_cp.TerminatedDate)).Days;

                            //If no.of days is more than 540 days then show pop up
                            if (intElapsedDays > 540)
                            {
                                frmTerminatedMessage objFrmTerminated = new frmTerminatedMessage();
                                objFrmTerminated.ShowDialog();
                            }
                        }
                    }
                }
            }

            //Add validation on Issue Date
            if (DR["FIELD_NAME"].ToString() == "IssueDate")
            {
                //The below validation is specific to BLC/PHS combination
                if (_cp.SiteID == "BLC" && _cp.WorkCategory == "PHS")
                {
                    if (!String.IsNullOrEmpty(_cp.IssueDate))
                    {
                        if (!String.IsNullOrEmpty(_cp.ReceivedDate))
                        {
                            //Calculated no.of days between Received Date and Issue Date
                            int intIssueElapsedDays = (DateTime.Parse(_cp.ReceivedDate) - DateTime.Parse(_cp.IssueDate)).Days;

                            //If no.of days is less than 90 days then show pop up
                            if (intIssueElapsedDays < 90)
                            {
                                txtIssueDate.Text = _cp.IssueDate;

                                frmNBOMessage objFrmNBOMessage = new frmNBOMessage();
                                objFrmNBOMessage.ShowDialog();
                            }
                        }
                    }
                }
            }            
            //AR145620 - END
            
            if (returnValue != -1 && DR["CONDITIONAL"].ToString() == "T")
            {
                //look at the conditions table to see what field it is conditional on
                returnValue = validateConditional(DR, mcb);
            }

            //if the code makes it here... we need to return 1 indicating no value
            return returnValue;
        }

        /// <summary>
        /// The function takes the admin system name and calculates the effective date. Finally sets the work type.
        /// </summary>
        /// <param name="strAdminSystem"></param>
        /// <returns></returns>
        private void determineContestability(string strAdminSystem)
        {
            if (strAdminSystem == "SHARP")
            {
                if (!String.IsNullOrEmpty(_cp.IssueDate))
                {
                    //Fetch contestable value for a given plan code
                    _dataAccess.selectContestableFromPlanCode(ref _cp);

                    if (_cp.Contestable == "T")
                    {
                        //Calculated no.of days between Received Date and Issue Date
                        int intEffectiveDays = (DateTime.Parse(_cp.ReceivedDate) - DateTime.Parse(_cp.IssueDate)).Days;

                        //If the duration is less than or equal to 24 months / 730 days then set the work type to CONTEST
                        if (intEffectiveDays <= 730)
                        {
                            _cp.WorkType = "CONTEST";                            
                        }
                    }
                }
            }
            else if (strAdminSystem == "LIFEPRO")
            {
                //If the administrative system is LifePRO, compare Issue Date and Effective Date.
                //Whichever of these two dates is the oldest compare it to the Received Date. 
                //If the result is 730 days (24 months) or less, the work should be assigned to the CONTEST Work Type in AWD.
                //Add another condition to filter records if the Plan Code is not in the list from database.

                //Fetch contestable value for a given plan code if plan code is not null
                if(!String.IsNullOrEmpty(_cp.PlanCode))
                    _dataAccess.selectContestableFromPlanCode(ref _cp);

                //If contestable then proceed further
                if (_cp.Contestable == "T")
                {
                    //Perform date validations on Issue Date and Effective Date
                    if ((!String.IsNullOrEmpty(_cp.IssueDate)) && (String.IsNullOrEmpty(_cp.EffectiveDate)))
                    {
                        //Calculated no.of days between Issue Date and Received Date
                        int intIssueDays = (DateTime.Parse(_cp.ReceivedDate) - DateTime.Parse(_cp.IssueDate)).Days;

                        //If the duration is less than or equal to 24 months / 730 days then set the work type to CONTEST
                        if (intIssueDays <= 730)
                        {
                            _cp.WorkType = "CONTEST";
                        }
                    }
                    else if ((String.IsNullOrEmpty(_cp.IssueDate)) && (!String.IsNullOrEmpty(_cp.EffectiveDate)))
                    {
                        //Calculated no.of days between Effective Date and Received Date
                        int intEffectiveDays = (DateTime.Parse(_cp.ReceivedDate) - DateTime.Parse(_cp.EffectiveDate)).Days;

                        //If the duration is less than or equal to 24 months / 730 days then set the work type to CONTEST
                        if (intEffectiveDays <= 730)
                        {
                            _cp.WorkType = "CONTEST";
                        }
                    }
                    else if ((!String.IsNullOrEmpty(_cp.IssueDate)) && (!String.IsNullOrEmpty(_cp.EffectiveDate)))
                    {
                        if ((DateTime.Parse(_cp.EffectiveDate) - DateTime.Parse(_cp.IssueDate)).Days >= 0)
                        {
                            //Consider Effective Date as the oldest date

                            //Calculated no.of days between Effective Date and Received Date
                            int intEffectiveDays = (DateTime.Parse(_cp.ReceivedDate) - DateTime.Parse(_cp.EffectiveDate)).Days;

                            //If the duration is less than or equal to 24 months / 730 days then set the work type to CONTEST
                            if (intEffectiveDays <= 730)
                            {
                                _cp.WorkType = "CONTEST";
                            }
                        }
                        else
                        {
                            //Consider Issue Date as the oldest date

                            //Calculated no.of days between Issue Date and Received Date
                            int intIssueDays = (DateTime.Parse(_cp.ReceivedDate) - DateTime.Parse(_cp.IssueDate)).Days;

                            //If the duration is less than or equal to 24 months / 730 days then set the work type to CONTEST
                            if (intIssueDays <= 730)
                            {
                                _cp.WorkType = "CONTEST";
                            }
                        }
                    }
                }

                

                //if (!String.IsNullOrEmpty(_cp.IssueDate))
                //{
                //    if (!String.IsNullOrEmpty(_cp.EffectiveDate))
                //    {
                //        //Fetch contestable value for a given plan code
                //        _dataAccess.selectContestableFromPlanCode(ref _cp);

                //        if (_cp.Contestable == "T")
                //        {
                //            if ((DateTime.Parse(_cp.EffectiveDate) - DateTime.Parse(_cp.IssueDate)).Days >= 0)
                //            {
                //                //Consider Effective Date as the oldest date

                //                //Calculated no.of days between Effective Date and Received Date
                //                int intEffectiveDays = (DateTime.Parse(_cp.ReceivedDate) - DateTime.Parse(_cp.EffectiveDate)).Days;

                //                //If the duration is less than or equal to 24 months / 730 days then set the work type to CONTEST
                //                if (intEffectiveDays <= 730)
                //                {
                //                    _cp.WorkType = "CONTEST";
                //                }
                //            }
                //            else
                //            {
                //                //Consider Issue Date as the oldest date

                //                //Calculated no.of days between Issue Date and Received Date
                //                int intIssueDays = (DateTime.Parse(_cp.ReceivedDate) - DateTime.Parse(_cp.IssueDate)).Days;

                //                //If the duration is less than or equal to 24 months / 730 days then set the work type to CONTEST
                //                if (intIssueDays <= 730)
                //                {
                //                    _cp.WorkType = "CONTEST";
                //                }
                //            }
                //        }
                //    }
                //}    
      
            }
        }

        private int validateConditional(DataRow DR, MaskedComboBox mcb)
        {
            //first we need to pull back the condition for the current row
            //DataRow drConditions = _cp._MVIFieldData.DD_MVI_FIELD_CONDITIONS.FindBySITE_IDWORK_CATEGORYFIELD_NAME(_cp.SiteID, _cp.WorkCategory, DR["FIELD_NAME"].ToString());
            //MessageBox.Show(drConditions["CONDITIONAL_FIELD_NAME"].ToString());
            DataView view = new DataView();

            view.Table = _cp._MVIFieldData.DD_MVI_FIELD_CONDITIONS;
            view.RowFilter = "SITE_ID = '" + _cp.SiteID + "' and WORK_CATEGORY = '" +
                              _cp.WorkCategory + "' and FIELD_NAME = '" + DR["FIELD_NAME"].ToString() + "'";
            view.Sort = "CONDITIONAL_OPERATOR, CONDITIONAL_FIELD_NAME, CONDITIONAL_FIELD_VALUE";

            foreach (DataRowView drv in view)
            {
                MaskedComboBox condMCB = returnConditionalField(drv["CONDITIONAL_FIELD_NAME"].ToString());
                DataRow drCondition = _cp._MVIFieldData.DD_MVI_FIELD_DEFINITION.FindBySITE_IDWORK_CATEGORYFIELD_NAME(_cp.SiteID, _cp.WorkCategory, drv["CONDITIONAL_FIELD_NAME"].ToString());

                //MessageBox.Show(drv["CONDITIONAL_FIELD_NAME"].ToString());
                if (drv["CONDITIONAL_OPERATOR"].ToString() == "P")
                {
                    //this field needs to be filled in if another field is filled in
                    if (condMCB.Text.Length > 0 && mcb.Text.Length == 0)
                    {

                        MessageBox.Show(DR["FIELD_LABEL"].ToString()
                                  + " must be present when a " + drCondition["FIELD_LABEL"].ToString() +
                                    " is filled in.",
                                  "Missing Required Field");
                        return -1;
                    }
                }
                else if (drv["CONDITIONAL_OPERATOR"].ToString() == "=")
                {
                    if (drv["CONDITIONAL_FIELD_VALUE"].ToString() == condMCB.Text)
                    {
                        string[] validValues;
                        validValues = drv["FIELD_VALUE"].ToString().Split(Convert.ToChar("|"));
                        //check value of conditional field for match
                        if (Array.IndexOf(validValues, mcb.Text) == -1)
                        {
                            MessageBox.Show(DR["FIELD_LABEL"].ToString()
                                + " must be " + listValidValues(validValues) + " when " + drCondition["FIELD_LABEL"].ToString() +
                                  " is " + drv["CONDITIONAL_FIELD_VALUE"].ToString(),
                                "Invalid Value");
                            return -1;
                        }
                    }
                }
            }

            return 0;
        }
        private string listValidValues(string[] validValues)
        {
            string retvalue = "";

            foreach (string str in validValues)
            {
                if (retvalue != "")
                {
                    retvalue = retvalue + " or ";
                }
                retvalue = retvalue + str;
            }
            return retvalue;
        }
        private MaskedComboBox returnConditionalField(string FieldName)
        {
            foreach (MaskedComboBox mcb in _mcbs)
            {
                if (null != mcb.Tag && mcb.Tag.ToString() == FieldName)
                {
                    return mcb;
                }

            }
            return null;
        }
        #endregion

        private void mcb_ValueChanged(object sender, EventArgs e)
        {


            MaskedComboBox mcbChanged = (MaskedComboBox)sender;
            if (null != mcbChanged.Tag)
            {
                _cp[mcbChanged.Tag.ToString()] = mcbChanged.Text;
                if (mcbChanged.ShowDropDown)
                {

                    //loop through definition table
                    //if this field is a parent for a choice list
                    //then update the appropriate choice list
                    foreach (DataRow dr in _cp._MVIFieldData.Tables["DD_MVI_FIELD_DEFINITION"].Rows)
                    {
                        if (dr["FIELD_NAME_PARENT"].ToString() == mcbChanged.Tag.ToString())
                        {
                            //find control that needs updating
                            string FieldName = dr["FIELD_NAME"].ToString();
                            MaskedComboBox mcb = returnConditionalField(FieldName);
                            if (null != mcb)
                            {
                                populateDrowDown(mcb, dr, "");
                            }
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (MaskedComboBox mcb in _mcbs)
                {
                    if (mcb.Visible)
                    {
                        mcb.SelectedIndex = -1;
                        mcb.Text = "";
                        mcb.RememberValueCheckBox.Checked = true;
                    }
                }
                this.txtCertifiedNo.Text = "";
                this.chkCertified.Checked = true;
                this.cboWorkType.SelectedIndex = -1;
                this.cboBusinessArea.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        private void txtHCFACount_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;

        }

        private void frmIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    //save form location to config file
                    DataAccess dataaccess = new DataAccess();
                    try
                    {
                        dataaccess.createDDUserFormSettings("U", this.Name, this.Location.X.ToString(), this.Location.Y.ToString());
                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}