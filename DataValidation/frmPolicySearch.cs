using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using CNO.BPA.DataHandler;
using CNO.BPA.Framework;

namespace CNO.BPA.DataValidation
{
    public partial class frmPolicySearch : Form
    {
        #region Private Variables

        //objects
        private CommonParameters _cp;
        private Dictionary<string, string> _WorkCategories = new Dictionary<string, string>();

        #endregion

        #region Form Initialization

        public frmPolicySearch(ref CommonParameters CP)
        {
            InitializeComponent();
            //obtain a local copy of the common parameters class
            _cp = CP;
        }
        private void frmPolicySearch_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    DataAccess dataaccess = new DataAccess();
                    try
                    {
                        this.Location = dataaccess.selectDDUserFormSettings(this.Name);
                    }
                    catch { }
                }
                workCategoryList.Items.Clear();
                siteIDList.Items.Clear();
                if (_cp.BridgeEnabled == "T")
                {
                    this.siteIDList.Enabled = true;
                    this.workCategoryList.Enabled = true;
                    populateBridgeChoices();
                }
                else
                {
                    this.siteIDList.Enabled = false;
                    this.workCategoryList.Enabled = false;
                }
                //fill in search defaults

                if (_cp.CompanyNo.Trim().Length > 0)
                {
                    this.txtCompany.Text = _cp.CompanyNo.Trim();
                }
                if (_cp.NameType.Trim().Length > 0)
                {
                    this.txtNameType.Text = _cp.NameType.Trim();
                }
                if (_cp.Product.Trim().Length > 0)
                {
                    this.txtProduct.Text = _cp.Product.Trim();
                }
                if (_cp.State.Trim().Length > 0)
                {
                    this.txtState.Text = _cp.State.Trim();
                }
                if (_cp.SystemNo.Trim().Length > 0)
                {
                    this.txtSystem.Text = _cp.SystemNo.Trim();
                }
                if (_cp.InsuredName.Trim().Length > 0)
                {
                    this.txtName.Text = _cp.InsuredName.Trim();
                }
                if (_cp.ID.Trim().Length > 0)
                {
                    this.txtPolicyAgent.Text = _cp.ID.Trim();
                }
                else if (_cp.PolicyNo.Trim().Length > 0)
                {
                    this.txtPolicyAgent.Text = _cp.PolicyNo.Trim();
                }
                else if (_cp.AgentNo.Trim().Length > 0)
                {
                    this.txtPolicyAgent.Text = _cp.AgentNo.Trim();
                }
                if (_cp.Phone.Trim().Length > 0)
                {
                    this.txtPhone.Text = _cp.Phone.Trim();
                }
                if (_cp.SSN.Trim().Length > 0)
                {
                    this.txtSSN.Text = _cp.SSN.Trim();
                }
                if (_cp.BirthDate.Trim().Length > 0)
                {
                    this.txtBirthDate.Text = _cp.BirthDate.Trim();
                }
                if (_cp.ZipCode.Trim().Length > 0)
                {
                    this.txtZip.Text = _cp.ZipCode.Trim();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmPolicySearch_Shown(object sender, EventArgs e)
        {
            //we can locate and select the passed in site value
            int siteIDIndex = siteIDList.FindString(_cp.SiteID);
            siteIDList.SelectedIndex = siteIDIndex;
        }
        private void frmPolicySearch_FormClosed(object sender, FormClosedEventArgs e)
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

        #endregion

        #region Form Buttons

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //now we can leave
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            _cp.InsuredName = txtName.Text = String.Empty;
            _cp.ID = _cp.PolicyNo = _cp.AgentNo = txtPolicyAgent.Text = String.Empty;
            _cp.Phone = txtPhone.Text = String.Empty;
            _cp.SSN = txtSSN.Text = String.Empty;
            _cp.BirthDate = txtBirthDate.Text = String.Empty;
            _cp.ZipCode = txtZip.Text = String.Empty;
            _cp.SystemNo = txtSystem.Text = String.Empty;
            _cp.CompanyNo = txtCompany.Text = String.Empty;
            _cp.NameType = txtNameType.Text = String.Empty;
            _cp.Product = txtProduct.Text = String.Empty;
            _cp.State = txtState.Text = String.Empty;
            txtPolicyAgent.Focus();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fieldsUsed = "";
            //first things first... let's review the bridge info
            reviewBridgeInfo();

            //first determine the name type
            if (txtNameType.Text == "A")
            {
                //check for the values the user wants to search on and set them
                _cp.AgentName = txtName.Text;
                if (txtName.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "AgentName ";
                }
                _cp.ID = txtPolicyAgent.Text;
                if (txtPolicyAgent.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "AgentNo ";
                }
                _cp.AgentPhone = txtPhone.Text;
                if (txtPhone.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "AgentPhone ";
                }
                _cp.AgentSSN = txtSSN.Text;
                if (txtSSN.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "AgentSSN ";
                }
                _cp.AgentBirthDate = txtBirthDate.Text;
                if (txtBirthDate.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "AgentBirthDate ";
                }

                _cp.AgentState = txtState.Text;
                if (txtState.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "AgentState ";
                }
                _cp.AgentZip = txtZip.Text;
                if (txtZip.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "AgentZip ";
                }
                //START: 145620
                _cp.Relationship = txtSearchType.Text;
                if (txtSearchType.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "Relationship ";
                }
                //END: 145620
            }
            else
            {
                //check for the values the user wants to search on and set them
                _cp.InsuredName = txtName.Text;
                if (txtName.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "Name ";
                }
                _cp.ID = txtPolicyAgent.Text;
                if (txtPolicyAgent.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "PolicyNo ";
                }
                _cp.Phone = txtPhone.Text;
                if (txtPhone.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "Phone ";
                }
                _cp.SSN = txtSSN.Text;
                if (txtSSN.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "SSN ";
                }
                _cp.BirthDate = txtBirthDate.Text;
                if (txtBirthDate.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "BirthDate ";
                }
                _cp.State = txtState.Text;
                if (txtState.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "State ";
                }
                _cp.ZipCode = txtZip.Text;
                if (txtZip.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "Zip ";
                }
                //START: 145620
                _cp.Relationship = txtSearchType.Text;
                if (txtSearchType.Text.Length > 0)
                {
                    fieldsUsed = fieldsUsed + "Relationship ";
                }
                //END: 145620
            }
            _cp.SystemNo = txtSystem.Text;
            if (txtSystem.Text.Length > 0)
            {
                fieldsUsed = fieldsUsed + "System ";
            }
            _cp.CompanyNo = txtCompany.Text;
            if (txtCompany.Text.Length > 0)
            {
                fieldsUsed = fieldsUsed + "Company ";
            }
            _cp.NameType = txtNameType.Text;
            if (txtNameType.Text.Length > 0)
            {
                fieldsUsed = fieldsUsed + "NameType ";
            }
            _cp.Product = txtProduct.Text;
            if (txtProduct.Text.Length > 0)
            {
                fieldsUsed = fieldsUsed + "Product ";
            }
            //log user tracking
            DataHandler.DataAccess dataAccess = new DataAccess();
            dataAccess.createDDUserTracking(ref _cp, "Search", fieldsUsed);
            //now we can exit the form 
            this.DialogResult = DialogResult.OK;
        }

        #endregion

        #region Form Fields

        private void siteIDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSiteID = String.Empty;
            string strWorkCategory = String.Empty;

            using (DataAccess dataAccess = new DataAccess())
            {
                //first we need to re-initialize the work category components
                workCategoryList.Items.Clear();
                workCategoryList.SelectedIndex = -1;
                _WorkCategories.Clear();
                //now we can pull back a set of values for the selected site
                DataSet datasetResults = dataAccess.selectDDMainDefinitionValues("BRIDGESETTING",
                            siteIDList.SelectedItem.ToString());
                foreach (DataRow dataRow in datasetResults.Tables[0].Rows)
                {
                    workCategoryList.Items.Add(dataRow.ItemArray.GetValue(3));
                    _WorkCategories.Add(dataRow.ItemArray.GetValue(2).ToString(),
                             dataRow.ItemArray.GetValue(3).ToString());
                }
                //last check to see if the work category in common parameters is in the list
                string wrkCategory = String.Empty;
                bool categoryFound = _WorkCategories.TryGetValue(_cp.WorkCategory, out wrkCategory);
                int wrkCategoryIndex = workCategoryList.FindString(wrkCategory);
                workCategoryList.SelectedIndex = wrkCategoryIndex;

                //START: AR 145620   
                strSiteID = siteIDList.SelectedItem.ToString();

                if (workCategoryList.SelectedItem != null)
                {
                    foreach (string key in _WorkCategories.Keys)
                    {
                        string value = String.Empty;
                        _WorkCategories.TryGetValue(key, out value);
                        if (value == workCategoryList.SelectedItem.ToString())
                        {
                            strWorkCategory = key;
                            break;
                        }
                    }
                }

                txtSearchType.Text = dataAccess.getSearchType(strSiteID, strWorkCategory).ToString();
                //END: AR 145620
            }
        }
        //START: AR 145620
        private void workCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSiteID = String.Empty;
            string strWorkCategory = String.Empty;

            using (DataAccess dataAccess = new DataAccess())
            {
                strSiteID = siteIDList.SelectedItem.ToString();

                if (workCategoryList.SelectedItem != null)
                {
                    foreach (string key in _WorkCategories.Keys)
                    {
                        string value = String.Empty;
                        _WorkCategories.TryGetValue(key, out value);
                        if (value == workCategoryList.SelectedItem.ToString())
                        {
                            strWorkCategory = key;
                            break;
                        }
                    }
                }

                txtSearchType.Text = dataAccess.getSearchType(strSiteID, strWorkCategory).ToString();
            }
        }
        //END: AR 145620
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            _cp.InsuredName = "";
        }
        private void txtPolicyAgent_TextChanged(object sender, EventArgs e)
        {
            _cp.ID = "";
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            _cp.Phone = "";
        }
        private void txtSSN_TextChanged(object sender, EventArgs e)
        {
            _cp.SSN = "";
        }
        private void txtBirthDate_TextChanged(object sender, EventArgs e)
        {
            _cp.BirthDate = "";
        }
        private void txtZip_TextChanged(object sender, EventArgs e)
        {
            _cp.ZipCode = "";
        }
        private void txtSystem_TextChanged(object sender, EventArgs e)
        {
            _cp.SystemNo = "";
        }

        #endregion

        #region Private Methods

        private void populateBridgeChoices()
        {
            DataAccess dataAccess = new DataAccess();
            DataSet datasetResults = dataAccess.selectRoutingChoices();
            foreach (DataRow dataRow in datasetResults.Tables[0].Rows)
            {
                siteIDList.Items.Add(dataRow.ItemArray.GetValue(0));
            }
        }
        private void resetData()
        {
            _cp.BirthDate = "";
            _cp.CompanyNo = "";
            _cp.ID = "";
            _cp.InsuredName = "";
            _cp.NameType = "";
            _cp.Phone = "";
            _cp.Product = "";
            _cp.SSN = "";
            _cp.State = "";
            _cp.SystemNo = "";
            _cp.ZipCode = "";
            GC.Collect();
        }
        private void reviewBridgeInfo()
        {
            if (siteIDList.SelectedItem != null)
            {
                //update the site id in case the user changed it
                _cp.SiteID = siteIDList.SelectedItem.ToString();
            }
            if (workCategoryList.SelectedItem != null)
            {
                foreach (string key in _WorkCategories.Keys)
                {
                    string value = String.Empty;
                    _WorkCategories.TryGetValue(key, out value);
                    if (value == workCategoryList.SelectedItem.ToString())
                    {
                        _cp.WorkCategory = key;
                        break;
                    }
                }
            }
        }

        #endregion        
                
    }
}