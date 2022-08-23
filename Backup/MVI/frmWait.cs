using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CNO.BPA.DataHandler;

namespace CNO.BPA.MVI
{
   public partial class frmWait : Form
   {
      private string _parentFormName;
      public frmWait(string parentFormName)
      {
         _parentFormName = parentFormName;
         InitializeComponent();
      }

      private void frmWait_Load(object sender, EventArgs e)
      {
         if (this.WindowState == FormWindowState.Normal)
         {
            //load form location to config file
            DataAccess dataaccess = new DataAccess();
            try
            {
               this.Location = dataaccess.selectDDUserFormSettings(_parentFormName);
            }
            catch { }
         }

      }
   }
}
