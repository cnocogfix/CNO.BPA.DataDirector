using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CNO.BPA.DataHandler;

namespace CNO.BPA.Validation4086
{
   public partial class frmCUSIPResults : Form
   {
     #region Private Variables
     
      private DataSet _datasetResults = new DataSet();
      private CommonParameters _cp;
      private int _selectedItem;

      #endregion
     #region Form Initialization
      public frmCUSIPResults(ref CommonParameters CP)
      {
         InitializeComponent();
         _cp = CP;
         _datasetResults = _cp._datasetResults;
      }
      private void frmCUSIPResults_Load(object sender, EventArgs e)
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
            LoadSearchResults(_datasetResults);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
      private void frmCUSIPResults_FormClosed(object sender, FormClosedEventArgs e)
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
         _selectedItem = trvResults.SelectedNode.Index;
         DataRow workingRow = _datasetResults.Tables[0].Rows[_selectedItem];
         _cp.AccountNumber = workingRow["CUSIP"].ToString();
         _cp.VendorName = workingRow["PARENT_NAME"].ToString();
         _cp.FullName = workingRow["BORROWER_NAME"].ToString();
         //_cp.Description2 = workingRow["ISSUER_ID"].ToString();

         this.DialogResult = DialogResult.OK;
         this.Close();         
      }
     #endregion
     #region Form Fields
      private void trvResults_AfterSelect(object sender, TreeViewEventArgs e)
      {
         lblCurrentRecord.Text = Convert.ToString(e.Node.Index + 1);
         DataRow workingRow = _datasetResults.Tables[0].Rows[e.Node.Index];
         txtCUSIP.Text = workingRow["CUSIP"].ToString();
         txtBorrowerName.Text = workingRow["BORROWER_NAME"].ToString();
         //txtParentName.Text = workingRow["PARENT_NAME"].ToString();
         txtIssuerID.Text = workingRow["ISSUER_ID"].ToString();
      }
      #endregion
     #region Private Methods

      private void LoadSearchResults(DataSet Results)
      {
         if (Results != null)
         {
            try
            {
               
               TreeNode objCurrentNode = trvResults.SelectedNode;
               foreach(DataRow row in Results.Tables[0].Rows)
               {
                  TreeNode objNode = new TreeNode();
                  objNode.Tag = row["CUSIP"].ToString() + row["PARENT_NAME"].ToString();
                  objNode.Text = row["CUSIP"].ToString();
                  objNode.ImageIndex = 0;
                  trvResults.Nodes.Add(objNode);               
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

   }
}
