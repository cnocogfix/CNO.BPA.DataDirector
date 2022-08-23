using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using CNO.BPA.DataHandler;

namespace CNO.BPA.Validation4086
{
   public partial class frmCusipSearch : Form
   {
      #region Private Variables

      private bool _IsCancel = false;
      private CommonParameters _cp;

      #endregion

      #region Form Initialization

      public frmCusipSearch(ref CommonParameters CP)
      {
         _cp = CP;
         InitializeComponent();
      }
      private void frmCusipSearch_Load(object sender, EventArgs e)
      {
         if (_cp.ReportDate.Trim().Length > 0)
         {
            string cultureName = "en-US";
            CultureInfo culture = new CultureInfo(cultureName);
            dtpDocumentDate.Value = Convert.ToDateTime(_cp.ReportDate, culture);
         }
         else
         {
            dtpDocumentDate.Value = DateTime.Now.Date.AddDays(-1);
         }
         if (_cp.AccountNumber.Trim().Length > 0)
         {
            txtCUSIP.Text = _cp.AccountNumber;
         }

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
      }
      private void frmCusipSearch_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (this.DialogResult != DialogResult.OK)
         {
            _IsCancel = true;
         }
      }
      private void frmCusipSearch_FormClosed(object sender, FormClosedEventArgs e)
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
         if (this.txtCUSIP.Text != "" && this.pnlDocumentDate.Visible == false)
         {
            //pass the CUSIP number into the common parameters
            _cp.AccountNumber = txtCUSIP.Text.Trim();
            _cp.CustomReqIndexProperty6 = dtpDocumentDate.Value.ToString("yyyyMMdd"); ;
            this.DialogResult = DialogResult.OK;
            this.Close();            
         }
         else if (this.txtCUSIP.Text == "")
         {
            MessageBox.Show("Please enter a CUSIP number to search for", "CUSIP Number Needed");
         }
         else if (this.pnlDocumentDate.Visible == true)
         {
            MessageBox.Show("Please enter a valid date to search for", "Valid Date Needed");
         }
      }

      #endregion

      #region Private Methods
      private void dtpDocumentDate_ValueChanged(object sender, EventArgs e)
      {
         dateValidation();
      }
      private void dateValidation()
      {
         //if (dtpDocumentDate.Value.Date < DateTime.Now.Date.Subtract(TimeSpan.FromDays(90)))
         //{
         //   pnlDocumentDate.Visible = true;
         //   lblErrorText.Visible = true;
         //}
         //else 
         if (dtpDocumentDate.Value.Date > DateTime.Now.Date)
         {
            pnlDocumentDate.Visible = true;
            lblErrorText.Visible = true;
         }
         else
         {
            pnlDocumentDate.Visible = false;
            lblErrorText.Visible = false;
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
