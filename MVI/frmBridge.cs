using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using CNO.BPA.DataHandler;

namespace CNO.BPA.MVI
{
   public partial class frmBridge : Form
   {
      #region Variables

      private string _applicationData = "";
      private string _SiteID = "";
      private string _WorkCategory = "";
      private Dictionary<string, string> _WorkCategories = new Dictionary<string, string>();

      #endregion
      #region Form Initialization
      public frmBridge(string callingForm)
      {
         InitializeComponent();


         //locate the common files directory
         _applicationData = Environment.GetFolderPath
            (Environment.SpecialFolder.LocalApplicationData);

      }
      private void frmBridge_Load(object sender, EventArgs e)
      {

         workCategoryList.Items.Clear();
         siteIDList.Items.Clear();
         populateBridgeChoices();
         //we can locate and select the passed in site value
         int siteIDIndex = siteIDList.FindString(_SiteID);
         siteIDList.SelectedIndex = siteIDIndex;

         string wrkCategory = String.Empty;
         bool categoryFound = _WorkCategories.TryGetValue(_WorkCategory, out wrkCategory);
         int wrkCategoryIndex = workCategoryList.FindString(wrkCategory);
         workCategoryList.SelectedIndex = wrkCategoryIndex;



      }
      #endregion
      #region Form Buttons
      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.Close();
      }
      private void btnOK_Click(object sender, EventArgs e)
      {
         if (this.siteIDList.SelectedItem == null)
         {
            MessageBox.Show("Please select a Site ID or click cancel to return to the main form");
            return;
         }
         if (this.workCategoryList.SelectedItem == null)
         {
            MessageBox.Show("Please select a Work Category or click cancel to return to the main form");
            return;
         }
         
         this.DialogResult = DialogResult.Abort;


      }
      #endregion
      #region Form Dropdowns
      private void siteIDList_SelectedIndexChanged(object sender, EventArgs e)
      {


         using (DataAccess dataAccess = new DataAccess())
         {
            _SiteID = siteIDList.SelectedItem.ToString();
            //first we need to re-initialize the work category components
            workCategoryList.Items.Clear();
            workCategoryList.SelectedIndex = -1;
            _WorkCategories.Clear();
            //now we can pull back a set of values for the selected site
            DataSet datasetResults = dataAccess.selectDDMainDefinitionValues("BRIDGESETTING",
                        siteIDList.SelectedItem.ToString());
            foreach (DataRow dataRow in datasetResults.Tables[0].Rows)
            {
               workCategoryList.Items.Add(dataRow.ItemArray.GetValue(3));
               _WorkCategories.Add(dataRow.ItemArray.GetValue(2).ToString(),
                        dataRow.ItemArray.GetValue(3).ToString());
            }
            //last check to see if the work category in common parameters is in the list
            string wrkCategory = String.Empty;
            bool categoryFound = _WorkCategories.TryGetValue(_WorkCategory, out wrkCategory);
            int wrkCategoryIndex = workCategoryList.FindString(wrkCategory);
            workCategoryList.SelectedIndex = wrkCategoryIndex;
         }



      }
      private void workCategoryList_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (workCategoryList.SelectedItem != null)
         {
            foreach (string key in _WorkCategories.Keys)
            {
               string value = String.Empty;
               _WorkCategories.TryGetValue(key, out value);
               if (value == workCategoryList.SelectedItem.ToString())
               {
                  _WorkCategory = key;
                  break;
               }
            }
         }

      }
      #endregion
      #region Form Population
      private void populateBridgeChoices()
      {
         DataAccess dataAccess = new DataAccess();
         DataSet datasetResults = dataAccess.selectRoutingChoices();
         foreach (DataRow dataRow in datasetResults.Tables[0].Rows)
         {
            siteIDList.Items.Add(dataRow.ItemArray.GetValue(0));
         }


      }      
      #endregion
      #region Public Properties

      public string SiteID
      {
         get { return _SiteID; }
         set { _SiteID = value; }
      }
      public string WorkCategory
      {
         get { return _WorkCategory; }
         set { _WorkCategory = value; }
      }
      #endregion



   }
}