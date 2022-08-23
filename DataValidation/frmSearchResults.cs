using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CNO.BPA.Framework;
using CNO.BPA.DataHandler;

namespace CNO.BPA.DataValidation
{
   public partial class frmSearchResults : Form
   {
      #region Private Variables

      Qsrch2_area _qsearch2Results;
      Qsrch2_input _objQsrch2Input;       
      private DataSet _datasetResults = new DataSet();
      private CommonParameters _cp;
      private int _selectedItem;
      private string _siteID = String.Empty;

      #endregion

      #region Form Initialization

      public frmSearchResults(ref CommonParameters CP)
      {
         InitializeComponent();
         _cp = CP;
      }

      private void frmSearchResults_Load(object sender, EventArgs e)
      {
         try
         {
            //log user tracking
            DataHandler.DataAccess dataAccess = new DataAccess();
            dataAccess.createDDUserTracking(ref _cp, "ResultsReturned", "");

         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      #endregion

      #region Form Buttons
      private void btnGetMoreResults_Click(object sender, EventArgs e)
      {
         using (DataAccess dataAccess = new DataAccess())
         {
            ServiceCalls serviceCalls = new ServiceCalls();

            //grab a reference to the current data 
            Qsrch2_area SearchData = _qsearch2Results;
            QSRCH2 QSearch2 = serviceCalls.getQSRCH2();
            //since this is getting more results for the current search, set call type to N
            //SearchData.Ra_Call_Type = "N";

            string startTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            //Create and Build Input Object
            _objQsrch2Input = new Qsrch2_input();
                         
            _objQsrch2Input.Qsrch2_eof = SearchData.Qsrch2_input.Qsrch2_eof;
            _objQsrch2Input.Qsrch2_in_area_cd = SearchData.Qsrch2_input.Qsrch2_in_area_cd;
            _objQsrch2Input.Qsrch2_in_birth = SearchData.Qsrch2_input.Qsrch2_in_birth;
            _objQsrch2Input.Qsrch2_in_cmp = SearchData.Qsrch2_input.Qsrch2_in_cmp;
            _objQsrch2Input.Qsrch2_in_id = SearchData.Qsrch2_input.Qsrch2_in_id;
            _objQsrch2Input.Qsrch2_in_lob = SearchData.Qsrch2_input.Qsrch2_in_lob;
            _objQsrch2Input.Qsrch2_in_name = SearchData.Qsrch2_input.Qsrch2_in_name;
            _objQsrch2Input.Qsrch2_in_name_type = SearchData.Qsrch2_input.Qsrch2_in_name_type;
            _objQsrch2Input.Qsrch2_in_phone = SearchData.Qsrch2_input.Qsrch2_in_phone;
            _objQsrch2Input.Qsrch2_in_ssn = SearchData.Qsrch2_input.Qsrch2_in_ssn;
            _objQsrch2Input.Qsrch2_in_state = SearchData.Qsrch2_input.Qsrch2_in_state;
            _objQsrch2Input.Qsrch2_in_sys = SearchData.Qsrch2_input.Qsrch2_in_sys;
            _objQsrch2Input.Qsrch2_in_zip = SearchData.Qsrch2_input.Qsrch2_in_zip;
            _objQsrch2Input.Qsrch2_more1 = SearchData.Qsrch2_input.Qsrch2_more1;
            _objQsrch2Input.Qsrch2_more2 = SearchData.Qsrch2_input.Qsrch2_more2;
            _objQsrch2Input.Qsrch2_more3 = SearchData.Qsrch2_input.Qsrch2_more3;
            _objQsrch2Input.Qsrch2_source_sys = SearchData.Qsrch2_input.Qsrch2_source_sys;
            
            SearchResults = QSearch2.CallQSRCH2(_objQsrch2Input);
            string endTime1 = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            dataAccess.createPerfLogEntry(ref _cp, startTime1, endTime1, "QSRCH2.CallQSRCH2", SearchResults.Qsrch2_msgs.Qsrch2_msg_text);
         }
      }
      private void btnSearchAgain_Click(object sender, EventArgs e)
      {
         //log user tracking
         DataHandler.DataAccess dataAccess = new DataAccess();
         dataAccess.createDDUserTracking(ref _cp, "SearchAgain", "");

         //indicate the user wants to search again
         this.DialogResult = DialogResult.Retry;
         //exit the form
         this.Close();
      }
      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.DialogResult = DialogResult.Cancel;
         //exit the form
         this.Close();
      }
      private void btnSelect_Click(object sender, EventArgs e)
      {
         string actualSiteID = String.Empty;
         _selectedItem = trvResults.SelectedNode.Index;
         if (_cp.SiteRestriction.ToUpper() == "T")
         {
            //before we return the selected node let's make sure
            //the site id matches with was was passed in
            _siteID = _cp.SiteID;
            DataRow dr = qSearchResults1.Tables["QSearch"].Rows[_selectedItem];

            _cp.SystemNo = dr["SystemNo"].ToString();
            _cp.CompanyNo = dr["CompanyNo"].ToString();

            actualSiteID = getSiteBySelectedPolicy(ref _cp).ToString();
            if (actualSiteID == _siteID || actualSiteID.Length == 0)
            {
               this.DialogResult = DialogResult.OK;
               this.Close();
            }
            else
            {
               //show the user a message and then indicate why validation failed
               frmStopMessage stopForm = new frmStopMessage();
               stopForm.ShowDialog();
            }
         }
         else
         {
            this.DialogResult = DialogResult.OK;
            this.Close();
         }
      }
      #endregion

      #region Form Fields
      private void trvResults_AfterSelect(object sender, TreeViewEventArgs e)
      {
         lblCurrentRecord.Text = Convert.ToString(e.Node.Index + 1);
         DataRow workingRow = qSearchResults1.QSearch.Rows[e.Node.Index];
         txtName.Text = workingRow["Name"].ToString();
         txtAddress1.Text = workingRow["Address1"].ToString();
         txtAddress2.Text = workingRow["Address2"].ToString();
         txtAddress3.Text = workingRow["Address3"].ToString();
         txtAddress4.Text = workingRow["Address4"].ToString();
         txtCity.Text = workingRow["City"].ToString();
         txtState.Text = workingRow["State"].ToString();
         txtZip.Text = workingRow["Zip"].ToString();
         txtSSN.Text = workingRow["SSN"].ToString();
         txtBirthDate.Text = workingRow["BirthDate"].ToString();
         txtAreaCode.Text = workingRow["AreaCode"].ToString();
         txtPhone.Text = workingRow["PhoneExt"].ToString() + workingRow["Phone"].ToString();
         txtPolicyAgent.Text = workingRow["ID"].ToString();
         txtSystem.Text = workingRow["SystemNo"].ToString();
         txtCompany.Text = workingRow["CompanyNo"].ToString();
         txtLOB.Text = workingRow["LOB"].ToString();
         txtProduct.Text = workingRow["Product"].ToString();
         txtNameType.Text = workingRow["NameType"].ToString();
         txtStatus.Text = workingRow["Status"].ToString();
         txtTerminatedDate.Text = workingRow["TerminatedDate"].ToString();
         txtRelationship.Text = workingRow["Relationship"].ToString();
         txtGroupNumber.Text = workingRow["GroupNumber"].ToString();
         txtPlanCode.Text = workingRow["BasePlanCode"].ToString();
         txtIssueDate.Text = workingRow["IssueDate"].ToString();
         txtIssueState.Text = workingRow["IssueState"].ToString();
         txtStatusReason.Text = workingRow["StatusReason"].ToString();
         //workingRow["CorpTaxId"].ToString();
         //workingRow["CustId"].ToString();
         //workingRow["Country"].ToString();         
         //workingRow["Zip4"].ToString();         
         //workingRow["IssueCountry"].ToString();         
         //workingRow["LastActivity"].ToString();
         //workingRow["MedicareId"].ToString();
         //workingRow["PersonStatus"].ToString();
         //workingRow["PersonStatusReason"].ToString();         
         //workingRow["Seq"].ToString();
         //workingRow["Sex"].ToString();         
      }
      #endregion

      #region Private Methods

      private string getSiteBySelectedPolicy(ref CommonParameters CP)
      {
         using (DataAccess dataAccess = new DataAccess())
         {
            string siteID = dataAccess.selectSiteID(ref CP);
            return siteID;
         }
      }

      private void LoadSearchResults(Qsrch2_area Results)
      {
         if (Results != null)
         {
            try
            {
               DataRow workingRow;
               TreeNode objCurrentNode = trvResults.SelectedNode;
               int intCount = -1;
               while (intCount++ < (Results.Qsrch2_output.Qsrch2_cnt - 1))
               {
                  TreeNode objNode = new TreeNode();
                  objNode.Tag = Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_id;
                  objNode.Text = Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_name;
                  objNode.ImageIndex = 0;
                  trvResults.Nodes.Add(objNode);

                  workingRow = qSearchResults1.QSearch.NewRow();
                  workingRow["ID"] = Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_id;
                  workingRow["Name"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_name;
                  workingRow["Address1"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_addr_line1;
                  workingRow["Address2"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_addr_line2;
                  workingRow["City"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_addr_city;
                  workingRow["State"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_addr_state;
                  workingRow["Zip"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_addr_zip;
                  workingRow["SSN"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_ssn;
                  workingRow["BirthDate"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_birth;
                  workingRow["AreaCode"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_area_code;
                  workingRow["Phone"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_phone;
                  workingRow["SystemNo"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_sys;
                  workingRow["CompanyNo"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_cmp;
                  workingRow["Product"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_product;
                  workingRow["LOB"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_line_of_bus; 
                  workingRow["NameType"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_name_type;
                  workingRow["Status"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_status;
                  workingRow["TerminatedDate"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_termination_date;
                  workingRow["Relationship"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_relationship;
                  workingRow["Country"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_addr_country;
                  workingRow["Address3"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_addr_line3;
                  workingRow["Address4"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_addr_line4;
                  workingRow["Zip4"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_addr_zip4;
                  workingRow["BasePlanCode"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_base_plan_code;
                  workingRow["CorpTaxId"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_corp_tax_id;
                  workingRow["CustId"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_cust_id;
                  workingRow["GroupNumber"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_group_number;
                  workingRow["IssueCountry"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_issue_country;
                  workingRow["IssueDate"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_issue_date;
                  workingRow["IssueState"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_issue_state;
                  workingRow["LastActivity"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_last_activity;
                  workingRow["MedicareId"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_medicare_id;
                  workingRow["PersonStatus"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_person_status;
                  workingRow["PersonStatusReason"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_person_status_reason;
                  workingRow["PhoneExt"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_phone_ext;
                  workingRow["Seq"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_seq;
                  workingRow["Sex"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_sex;
                  workingRow["StatusReason"] = _qsearch2Results.Qsrch2_output.Qsrch2_array[intCount].Qsrch2_status_reason;

                  qSearchResults1.QSearch.Rows.Add(workingRow);

               }
               //reset the last selected node
               lblTotalRecords.Text = Convert.ToString(trvResults.Nodes.Count);
               if (objCurrentNode != null)
               {
                  trvResults.SelectedNode = objCurrentNode;
                  trvResults.SelectedNode.StateImageKey = TreeNodeStates.Selected.ToString();
                  lblCurrentRecord.Text = Convert.ToString(1 + trvResults.SelectedNode.Index);
               }
               else
               {
                  lblCurrentRecord.Text = "1";
               }
            }
            catch
            {
               MessageBox.Show("The search results were not able to be loaded.");
            }
         }

      }

      #endregion

      #region Public Properties

      public int SelectedItem
      {
         get { return _selectedItem; }
      }
      public Qsrch2_area SearchResults
      {
         get { return _qsearch2Results; }
         set
         {
            _qsearch2Results = value;
            LoadSearchResults(_qsearch2Results);
         }
      }    
      #endregion
   }
}