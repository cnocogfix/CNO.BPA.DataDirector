using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CNO.BPA.DataHandler;

namespace CNO.BPA.PrivacyMailingValidation
{
   public partial class frmPrivacySearch : Form
   {
      private CommonParameters _cp;
      public frmPrivacySearch(ref CommonParameters CP)
      {
         _cp = CP;
         InitializeComponent();
      }

      private void frmPrivacySearch_Load(object sender, EventArgs e)
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

      }


      private void btnCancel_Click(object sender, EventArgs e)
      {
         //now we can leave
         this.DialogResult = DialogResult.Cancel;
         this.Close();

      }

      private void btnSearch_Click(object sender, EventArgs e)
      {
         int dvReturn = 0;
         if (this.txtMasterID.Text != "")
         {
            //search for Master ID
            DataHandler.DataAccess dataAccess = new DataAccess();
            _cp.PrivMasterID = this.txtMasterID.Text.Trim();
            dvReturn = dataAccess.selectPrivacyMailing(ref _cp);

            switch (dvReturn)
            {
               case 0: //validation completed successfully
                  this.DialogResult = DialogResult.OK;
                  this.Close();
                  break;
               case -2:
                  //Master ID not found
                  MessageBox.Show("Master ID was not found in database", "Valid Master ID Needed");
                  break;
               default:
                  //unexpected return
                  MessageBox.Show("Unexpected return from database search", "Error");
                  break;
            }


         }
         else
         {
            MessageBox.Show("Please enter Master ID", "Master ID Needed");

         }


      }

      private void frmPrivacySearch_FormClosed(object sender, FormClosedEventArgs e)
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

   }
}
