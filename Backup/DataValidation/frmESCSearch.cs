using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CNO.BPA.DataHandler;

namespace CNO.BPA.DataValidation
{
    public partial class frmESCSearch : Form
    {
        #region Private Variables

        private bool _IsCancel = false;
        private CommonParameters _cp;

        #endregion

        public frmESCSearch(ref CommonParameters CP)
        {
            _cp = CP;
            InitializeComponent();
        }

        private void frmESCSearch_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                //Clear Holder Number
                txtHolderNumber.Text = "";
                _cp.HolderNumber = "";

                //load form location to config file
                DataAccess dataaccess = new DataAccess();

                try
                {
                    this.Location = dataaccess.selectDDUserFormSettings(this.Name);
                }
                catch { }
            }
        }
        
        private void frmESCSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                _IsCancel = true;
            }
        }

        private void frmESCSearch_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnESCSearch_Click(object sender, EventArgs e)
        {
            if (this.txtHolderNumber.Text != "")
            {
                //pass the Holder Number in to the common parameters                
                _cp.HolderNumber = txtHolderNumber.Text.Trim();
            }            
            this.DialogResult = DialogResult.OK;
            this.Close();                        
        }

        private void btnESCCancel_Click(object sender, EventArgs e)
        {
            _IsCancel = true;
            //leave
            this.Close();
        }

        #region Public Properties
        public bool Cancel
        {
            get { return _IsCancel; }
            set { _IsCancel = value; }
        }
        #endregion
    }      
}
