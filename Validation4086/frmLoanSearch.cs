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
   public partial class frmLoanSearch : Form
   {
      #region Private Variables

      private bool _IsCancel = false;
      private CommonParameters _cp;

      #endregion

      #region Form Initialization

      public frmLoanSearch(ref CommonParameters CP)
      {
         _cp = CP;
         InitializeComponent();
      }
      private void frmLoanSearch_Load(object sender, EventArgs e)
      {
         if (this.WindowState == FormWindowState.Normal)
         {
            if (_cp.AccountNumber.Trim().Length > 0)
            {
               txtLoan.Text = _cp.AccountNumber;
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
      private void frmCusipSearch_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (this.DialogResult != DialogResult.OK)
         {
            _IsCancel = true;
         }
      }
      private void frmLoanSearch_FormClosed(object sender, FormClosedEventArgs e)
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
         _IsCancel = true;
         //leave
         this.Close();
      }
      private void btnSearch_Click(object sender, EventArgs e)
      {     
         if (this.txtLoan.Text != "")
         {
            //pass the loan value in to the common parameters
            _cp.AccountNumber = txtLoan.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();            
         }
         else
         {
            MessageBox.Show("Please enter a loan number to search for", "Loan Number Needed");
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
