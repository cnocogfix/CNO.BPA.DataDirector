using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CNO.BPA.DataHandler;

namespace CNO.BPA.GroupValidation
{
    public partial class frmGroupSearchResults : Form
    {
        
     #region Private Variables
     
      private DataSet _datasetResults = new DataSet();
      private CommonParameters _cp;
      private int _selectedItem;

     #endregion

     #region Form Initialization

      public frmGroupSearchResults(ref CommonParameters CP)
      {
         InitializeComponent();
         _cp = CP;
         _datasetResults = _cp._datasetResults;
      }

      private void frmGroupSearchResults_Load(object sender, EventArgs e)
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

            //log user tracking
            DataHandler.DataAccess dataAccess = new DataAccess();
            dataAccess.createDDUserTracking(ref _cp, "ResultsReturned", "");
            LoadGroupSearchResults(_datasetResults);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
      private void frmGroupSearchResults_FormClosed(object sender, FormClosedEventArgs e)
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
         _selectedItem = trvGroupResults.SelectedNode.Index;          
         DataRow workingRow = _datasetResults.Tables[0].Rows[_selectedItem];
         
         _cp.City = workingRow["CITY"].ToString();
         _cp.CompanyCode = workingRow["COMPANY"].ToString();
         _cp.EmailID = workingRow["CONTACTEMAIL"].ToString();
         _cp.FirstName = workingRow["CONTACTNAME"].ToString().Trim();
         _cp.Phone = workingRow["CONTACTNUMBER"].ToString().Trim();
         _cp.GroupID = workingRow["GROUPID"].ToString().Trim();
         _cp.GroupName = workingRow["GROUPNAME"].ToString().Trim();
         _cp.GroupNo = workingRow["GROUPNUMBER"].ToString().Trim();
         _cp.SystemID = workingRow["GROUPSYSTEM"].ToString().Trim();
         _cp.AgentNo = workingRow["IMOAGENTNUMBER"].ToString().Trim();
         _cp.LineOfBusiness = workingRow["LINEOFBUSINESS"].ToString().Trim();
         _cp.Address1 = workingRow["MAILINGADDRESS1"].ToString().Trim();
         _cp.Address2 = workingRow["MAILINGADDRESS2"].ToString().Trim();
         _cp.MasterGroupID = workingRow["MASTERGROUPID"].ToString().Trim();
         _cp.MasterGroupName = workingRow["MGGROUPNAME"].ToString().Trim();
         _cp.MasterGroupNo = workingRow["MGGROUPNUMBER"].ToString().Trim();
         _cp.State = workingRow["STATE"].ToString().Trim();
         _cp.Status = workingRow["STATUS"].ToString().Trim();
         _cp.ZipCode = workingRow["ZIP"].ToString().Trim();

         this.DialogResult = DialogResult.OK;
         this.Close();         
      }
     #endregion
     #region Form Fields
      private void trvGroupResults_AfterSelect(object sender, TreeViewEventArgs e)
      {
         lblCurrentRecord.Text = Convert.ToString(e.Node.Index + 1);
         DataRow workingRow = _datasetResults.Tables[0].Rows[e.Node.Index];

         txtCity.Text = workingRow["CITY"].ToString();
         txtCompany.Text = workingRow["COMPANY"].ToString();
         txtContactEmail.Text = workingRow["CONTACTEMAIL"].ToString();
         txtContactName.Text = workingRow["CONTACTNAME"].ToString().Trim();
         txtContactNumer.Text = workingRow["CONTACTNUMBER"].ToString().Trim();
         txtGroupId.Text = workingRow["GROUPID"].ToString().Trim();
         txtGroupName.Text = workingRow["GROUPNAME"].ToString().Trim();
         txtGroupNumer.Text = workingRow["GROUPNUMBER"].ToString().Trim();
         txtGroupSystem.Text = workingRow["GROUPSYSTEM"].ToString().Trim();
         txtAgentNumber.Text = workingRow["IMOAGENTNUMBER"].ToString().Trim();
         txtLineOfBusiness.Text = workingRow["LINEOFBUSINESS"].ToString().Trim();
         txtMailingAddress1.Text = workingRow["MAILINGADDRESS1"].ToString().Trim();
         txtMailingAddress2.Text = workingRow["MAILINGADDRESS2"].ToString().Trim();
         txtMasterGroupId.Text = workingRow["MASTERGROUPID"].ToString().Trim();
         txtMasterGroupName.Text = workingRow["MGGROUPNAME"].ToString().Trim();
         txtMasterGroupNumber.Text = workingRow["MGGROUPNUMBER"].ToString().Trim();
         txtState.Text = workingRow["STATE"].ToString().Trim();         
         txtZip.Text = workingRow["ZIP"].ToString().Trim();
      }
     #endregion

     #region Private Methods

      private void LoadGroupSearchResults(DataSet Results)
      {
         if (Results != null)
         {
            try
            {
               
               TreeNode objCurrentNode = trvGroupResults.SelectedNode;
               foreach(DataRow row in Results.Tables[0].Rows)
               {
                  TreeNode objNode = new TreeNode();
                  objNode.Tag = row["GROUPNUMBER"].ToString() + row["GROUPNAME"].ToString();
                  objNode.Text = row["GROUPNUMBER"].ToString();
                  objNode.ImageIndex = 0;
                  trvGroupResults.Nodes.Add(objNode);
               }

               //reset the last selected node
               lblTotalRecords.Text = Convert.ToString(trvGroupResults.Nodes.Count);

               if (objCurrentNode != null)
               {
                   trvGroupResults.SelectedNode = objCurrentNode;
                   trvGroupResults.SelectedNode.StateImageKey = TreeNodeStates.Selected.ToString();
                   lblCurrentRecord.Text = Convert.ToString(1 + trvGroupResults.SelectedNode.Index);
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
    }
}
