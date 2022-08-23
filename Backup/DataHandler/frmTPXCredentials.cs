using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CNO.BPA.DataHandler
{
   public partial class frmTPXCredentials : Form
   {
      private string _tpxUser = "";
      private string _tpxPassword = "";

      public frmTPXCredentials()
      {
         InitializeComponent();
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         //simply take the values and store them
         _tpxUser = txtTPXUserID.Text;       
         _tpxPassword = txtTPXPassword.Text;
         //now we can leave
      }
      public string TPXUser
      {
         get { return _tpxUser; }
      }
      public string TPXPassword
      {
         get { return _tpxPassword; }
      }


   }
}