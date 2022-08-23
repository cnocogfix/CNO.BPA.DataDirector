using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CNO.BPA.DataDirector;
using CNO.BPA.DataHandler;
using CNO.BPA.DataValidation;
using CNO.BPA.Validation4086;

using System.Web.Services.Protocols;

namespace DataDirectorControlPanel
{

   public partial class frmMain : Form
   {
      Director _dataDirector = new Director();
      DataAccess _dataAccess = new DataAccess();
      CommonParameters _cp;


      public frmMain()
      {
         InitializeComponent();
         _dataDirector.Complete += new CompleteEventHandler(Director_Complete);
      }
      private void Director_Complete(int Result, string Description)
      {
         // MessageBox.Show(Description);

         MessageBox.Show(Result + " " + Description + "\r\n" + _cp.InsuredName + "\r\n" + _cp.PlanCode + "\r\n" + _cp.SortCode);


      }
      private void btnLaunchDD_Click(object sender, EventArgs e)
      {

         _cp = new CommonParameters();
         if (siteIDList.SelectedItem != null)
         {
            //set the site id
            _cp.SiteID = siteIDList.SelectedItem.ToString();
         }
         else
         {
            MessageBox.Show("A Site ID is required in order\r\n"
                + "to launch the Data Director");
            return;
         }
         if (workCategoryList.SelectedItem != null)
         {
            //set the work category
            _cp.WorkCategory = workCategoryList.SelectedItem.ToString();
         }
         else
         {
            MessageBox.Show("A Work Category is required in order\r\n"
                + "to launch the Data Director");
            return;
         }

         //next see if any search criteria is being passed in            
         if (txtID.Text.Length > 0) _cp.ID = txtID.Text;
         if (txtSSN.Text.Length > 0) _cp.SSN = txtSSN.Text;
         if (txtName.Text.Length > 0) _cp.InsuredName = txtName.Text;
         if (txtZip.Text.Length > 0) _cp.ZipCode = txtZip.Text;
         if (txtPhone.Text.Length > 0) _cp.Phone = txtPhone.Text;
         if (txtBirthDate.Text.Length > 0) _cp.BirthDate = txtBirthDate.Text;

         if (txtBusinessArea.Text.Length > 0) _cp.BusinessArea = txtBusinessArea.Text;
         if (txtWorkType.Text.Length > 0) _cp.WorkType = txtWorkType.Text;

          
          _cp.EnvelopeNodeID = "1";
         _cp.ScannerID = "57";
         _cp.BatchNo = "TestDDBatch";
         _cp.CurrentNodeID = "1";
         _dataAccess.getMVIFieldData(ref _cp);
         //launch the data director
         _dataDirector.LaunchDD(ref _cp);

      }
      private void frmMain_Load(object sender, EventArgs e)
      {
         DataSet datasetResults = _dataAccess.selectRoutingChoices();
         foreach (DataRow dataRow in datasetResults.Tables[0].Rows)
         {
            siteIDList.Items.Add(dataRow.ItemArray.GetValue(0));
         }

      }
      private void siteIDList_SelectedIndexChanged(object sender, EventArgs e)
      {
         workCategoryList.Items.Clear();
         workCategoryList.Enabled = true;
         DataSet datasetResults = _dataAccess.selectRoutingChoices(siteIDList.SelectedItem.ToString());
         foreach (DataRow dataRow in datasetResults.Tables[0].Rows)
         {
            workCategoryList.Items.Add(dataRow.ItemArray.GetValue(0));
         }

      }
      private void btnAutoValidate_Click(object sender, EventArgs e)
      {
         _cp = new CommonParameters();
         if (siteIDList.SelectedItem != null)
         {
            //set the site id
            _cp.SiteID = siteIDList.SelectedItem.ToString();
         }
         else
         {
            MessageBox.Show("A Site ID is required in order\r\n"
                + "to launch the Data Director");
            return;
         }
         if (workCategoryList.SelectedItem != null)
         {
            //set the work category
            _cp.WorkCategory = workCategoryList.SelectedItem.ToString();
         }
         else
         {
            MessageBox.Show("A Work Category is required in order\r\n"
                + "to launch the Data Director");
            return;
         }

         //next see if any search criteria is being passed in            
         if (txtID.Text.Length > 0) _cp.ID = txtID.Text;
         if (txtSSN.Text.Length > 0) _cp.SSN = txtSSN.Text;
         if (txtName.Text.Length > 0) _cp.InsuredName = txtName.Text;
         if (txtZip.Text.Length > 0) _cp.ZipCode = txtZip.Text;
         if (txtPhone.Text.Length > 0) _cp.Phone = txtPhone.Text;
         if (txtBirthDate.Text.Length > 0) _cp.BirthDate = txtBirthDate.Text;
         Validation dv = new Validation();
         _cp.SiteRestriction = "T";
         int i = dv.AutoValidate(ref _cp);
         MessageBox.Show(i.ToString());
        

      }
      private void button1_Click(object sender, EventArgs e)
      {
         CommonParameters cp = new CommonParameters();
         cp.ControlNo = "0913900015";
         string ret;
         Validation val = new Validation();
         ret = val.getALCCC14data(ref cp);
         MessageBox.Show(ret
            + System.Environment.NewLine
            + "State: " + cp.State
            + System.Environment.NewLine
            + "ReplacementIndicator: " + cp.ReplacementIndicator
            + System.Environment.NewLine
            + "TransType: " + cp.TransType
            + System.Environment.NewLine
            + "ProductCategory: " + cp.ProductCategory
            );

         cp.DocTypeOrig = "APP";
         ret = val.getFrontOfficeBarcodeValues(ref cp);

         ret = val.getFrontOfficeProdCatXrefValues(ref cp);

      }
      private void btnValidate_Click(object sender, EventArgs e)
      {
         _cp = new CommonParameters();
         if (siteIDList.SelectedItem != null)
         {
            //set the site id
            _cp.SiteID = siteIDList.SelectedItem.ToString();
         }
         else
         {
            MessageBox.Show("A Site ID is required in order\r\n"
                + "to launch the Data Director");
            return;
         }
         if (workCategoryList.SelectedItem != null)
         {
            //set the work category
            _cp.WorkCategory = workCategoryList.SelectedItem.ToString();
         }
         else
         {
            MessageBox.Show("A Work Category is required in order\r\n"
                + "to launch the Data Director");
            return;
         }

         //next see if any search criteria is being passed in            
         if (txtID.Text.Length > 0) _cp.ID = txtID.Text;
         if (txtSSN.Text.Length > 0) _cp.SSN = txtSSN.Text;
         if (txtName.Text.Length > 0) _cp.InsuredName = txtName.Text;
         if (txtZip.Text.Length > 0) _cp.ZipCode = txtZip.Text;
         if (txtPhone.Text.Length > 0) _cp.Phone = txtPhone.Text;
         if (txtBirthDate.Text.Length > 0) _cp.BirthDate = txtBirthDate.Text;
         Validation dv = new Validation();
         _cp.SiteRestriction = "T";
         int i = dv.Validate(ref _cp);
         MessageBox.Show(i.ToString() + " System: " + _cp.SystemID   + " Company: " + _cp.CompanyCode);
        

      }
      private void btnPrivacyDetail_Click(object sender, EventArgs e)
      {
        
         ServiceCalls sc = new ServiceCalls();
         CommonParameters CP = new CommonParameters();
         CP.Address1 = "1857 E 70TH STREET";
         CP.City = "LOS ANGELES";
         CP.State = "CA";
         CP.ZipCode = "90001";
         CP.FirstName = "ANGELICA";
         CP.LastName = "ARREOLA";
         CP.PrivShareOptOut = "F";
         CP.PrivShare3rdPartyOptOut = "F";//optout
         sc.updatePrivacyDetail(ref CP);

         MessageBox.Show("Done.");


      }
      private void btn4086PP_Click(object sender, EventArgs e)
      {
         _cp = new CommonParameters();
        
         _cp.SiteID = "ENT";
         _cp.WorkCategory = "4086_PP";
         _cp.ReportDate = "2013/05/24";
         _cp.Description = "OFFERING";
         _cp.DocType = "MEMO";
         
         _cp.EnvelopeNodeID = "1";
         _cp.ScannerID = "57";
         _cp.BatchNo = "TestPPBatch";
         _cp.BoxNo = "130422999";
         _cp.CurrentNodeID = "1";
         _dataAccess.getMVIFieldData(ref _cp);
         //launch the data director
         _dataDirector.LaunchDD(ref _cp);
      }
      private void btn4086M_Click(object sender, EventArgs e)
      {
         _cp = new CommonParameters();

         _cp.SiteID = "ENT";
         _cp.WorkCategory = "4086_MORT";
         _cp.ReportDate = "2013/04/01";
         _cp.Description = "BORROWER INFO";
         _cp.Description2 = "WORKING FILE I SEC";
         _cp.DocType = "MISC";

         _cp.EnvelopeNodeID = "1";
         _cp.ScannerID = "57";
         _cp.BatchNo = "TestMORTBatch";
         _cp.BoxNo = "130422999";
         _cp.CurrentNodeID = "1";
         _dataAccess.getMVIFieldData(ref _cp);
         //launch the data director
         _dataDirector.LaunchDD(ref _cp);
      }
      private void btn4086MAuto_Click(object sender, EventArgs e)
      {
         _cp = new CommonParameters();

         _cp.AccountNumber = "1006";
         _cp.Address1 = "1060 RICHARD SAILORS PKWY";

         _cp.SiteID = "ENT";
         _cp.WorkCategory = "4086_MORT";
         _cp.ReportDate = "2013/04/30";
         _cp.Description = "OPERATING STATEMENT";
         _cp.Description2 = "WORKING FILE I SEC";
         _cp.DocType = "STMT";         
         _cp.EnvelopeNodeID = "1";
         _cp.ScannerID = "57";
         _cp.BatchNo = "TestMORTBatch";
         _cp.BoxNo = "130422999";
         _cp.CurrentNodeID = "1";
         _dataAccess.getMVIFieldData(ref _cp);
         
         //launch the autovalidation
         LoanSearch ls = new LoanSearch();
         int returnValue = ls.loanValidation(ref _cp);
         MessageBox.Show("The automatic Loan Number Validation has returned: " + returnValue.ToString() + "\r\n\r\n"
            + "Loan Number: \t" + _cp.AccountNumber + "\r\n"
            + "Borrower: \t\t" + _cp.LastName + "\r\n"
            + "Tenant: \t\t" + _cp.FullName + "\r\n"
            + "Property Name: \t" + _cp.PropertyName + "\r\n"
            + "Property Address: \t" + _cp.Address1 + "\r\n"
            + "Property City: \t" + _cp.City + "\r\n"
            + "Property State: \t" + _cp.State);
      }
      private void btn4086PPAuto_Click(object sender, EventArgs e)
      {
         _cp = new CommonParameters();

        // _cp.AccountNumber = "03030#AC8";
         _cp.AccountNumber = "01877KAA1";

         _cp.SiteID = "ENT";
         _cp.WorkCategory = "4086_PP";
         _cp.Description = "OFFERING";
         _cp.DocType = "MEMO";

         _cp.EnvelopeNodeID = "1";
         _cp.ScannerID = "57";
         _cp.BatchNo = "TestPPBatch";
         _cp.BoxNo = "130422999";
         _cp.CurrentNodeID = "1";
         _dataAccess.getMVIFieldData(ref _cp);
         //launch the autovalidation
         CusipSearch cs = new CusipSearch();
         int returnValue = cs.ValidateCUSIP(ref _cp);
         MessageBox.Show("The automatic CUSIP Validation has returned: " + returnValue.ToString() + "\r\n\r\n"
         + "CUSIP: \t\t" + _cp.AccountNumber + "\r\n"
         + "Parent Name: \t" + _cp.VendorName + "\r\n"
         + "Borrower Name: \t" + _cp.FullName + "\r\n"
         + "Issuer Id: \t\t" + _cp.Description2);
      }
   }
}
