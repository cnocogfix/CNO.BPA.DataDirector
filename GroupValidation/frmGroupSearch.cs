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
    public partial class frmGroupSearch : Form
    {        
      #region Private Variables

      private bool _IsCancel = false;
      private CommonParameters _cp;

      #endregion

      #region Form Initialization

      public frmGroupSearch(ref CommonParameters CP)
      {
         _cp = CP;
         InitializeComponent();
      }
      private void frmGroupSearch_Load(object sender, EventArgs e)
      {
         if (this.WindowState == FormWindowState.Normal)
         {
            if (_cp.GroupNo.Trim().Length > 0)
            {
               txtGroupNumber.Text = _cp.GroupNo;
            }

            if (_cp.GroupName.Trim().Length > 0)
            {
                txtGroupName.Text = _cp.GroupName;
            }

            if (_cp.MasterGroupNo.Trim().Length > 0)
            {
                txtMasterGroupNumber.Text = _cp.MasterGroupNo;
            }

            if (_cp.MasterGroupName.Trim().Length > 0)
            {
                txtMasterGroupName.Text = _cp.MasterGroupName;
            }

            //load form location to config file
            DataAccess dataaccess = new DataAccess();

            try
            {
               this.Location = dataaccess.selectDDUserFormSettings(this.Name);
            }
            catch { }
         }
      }
      private void frmGroupSearch_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (this.DialogResult != DialogResult.OK)
         {
            _IsCancel = true;
         }
      }
      private void frmGroupSearch_FormClosed(object sender, FormClosedEventArgs e)
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

      private void btnGroupCancel_Click(object sender, EventArgs e)
      {
          //Clear fields
          txtGroupNumber.Text = String.Empty;
          txtGroupName.Text = String.Empty;
          txtMasterGroupNumber.Text = String.Empty;
          txtMasterGroupName.Text = String.Empty;

         _IsCancel = true;

         //leave
         this.Close();
      }
              
      private void btnGroupSearch_Click(object sender, EventArgs e)
      {     
         if (this.txtGroupNumber.Text != "" || this.txtGroupName.Text != "" ||
             this.txtMasterGroupNumber.Text != "" || this.txtMasterGroupName.Text != "")
         {
            //pass the GroupNo, GroupName, MasterGroupNumber, MasterGroupName values in to the common parameters
             if (this.txtGroupNumber.Text != "")
             {
                 _cp.GroupNo = txtGroupNumber.Text.Trim();
             }

             if (this.txtGroupName.Text != "")
             {
                 _cp.GroupName = txtGroupName.Text.Trim();
             }

             if (this.txtMasterGroupNumber.Text != "")
             {
                 _cp.MasterGroupNo = txtMasterGroupNumber.Text.Trim();
             }

             if (this.txtMasterGroupName.Text != "")
             {
                 _cp.MasterGroupName = txtMasterGroupName.Text.Trim();
             }
             
             this.DialogResult = DialogResult.OK;
             this.Close();            
         }
         else
         {
             MessageBox.Show("Please enter at least 1 of the values to search for", "No Enough Data To Search");
         }
      }

      #endregion

      #region Public Properties
      public bool Cancel
      {
         get { return _IsCancel; }
         set { _IsCancel = value; }
      }
      #endregion      
    }
}
