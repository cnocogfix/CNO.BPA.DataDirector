using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Xml;
using CNO.BPA.DataHandler;
namespace CNO.BPA.MVI
{
   public partial class frmSelectPerson : Form
   {
      #region Variables
      private string CONFIG_PATH = Environment.GetFolderPath(Environment
         .SpecialFolder.LocalApplicationData) +@"\Emc\InputAccel\Custom\Bin\";


      private CommonParameters _cp;
      private WorkitemResults _WorkItemResultsUse = null;
      #endregion
      #region Form Initialization
      public frmSelectPerson(ref CommonParameters CP)
      {
         InitializeComponent();
         InitializeGrid();
         //obtain a local copy of the common parameters class
         _cp = CP;



      }
      private void InitializeGrid()
      {
         //start by clearing the grid
         this.SelectPersonGrid.Rows.Clear();
         this.SelectPersonGrid.Columns.Clear();

         //define and create the checkbox column
         DataGridViewCheckBoxColumn useRowCol = new DataGridViewCheckBoxColumn();
         useRowCol.Name = "useRowCheckBox";
         useRowCol.HeaderText = "";
         useRowCol.DefaultCellStyle.BackColor = Color.White;
         useRowCol.ReadOnly = false;
         useRowCol.Width = 40;
         useRowCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         this.SelectPersonGrid.Columns.Add(useRowCol);
         //define and create the first name column
         DataGridViewTextBoxColumn firstNameCol = new DataGridViewTextBoxColumn();
         firstNameCol.Name = "FirstName";
         firstNameCol.HeaderText = "First Name";
         firstNameCol.DefaultCellStyle.BackColor = Color.LightGray;
         firstNameCol.ReadOnly = true;
         firstNameCol.Width = 100;
         this.SelectPersonGrid.Columns.Add(firstNameCol);
         //define and create the Last Name column
         DataGridViewTextBoxColumn lastNameCol = new DataGridViewTextBoxColumn();
         lastNameCol.Name = "LastName";
         lastNameCol.HeaderText = "Last Name";
         lastNameCol.DefaultCellStyle.BackColor = Color.LightGray;
         lastNameCol.ReadOnly = true;
         lastNameCol.Width = 150;
         this.SelectPersonGrid.Columns.Add(lastNameCol);
         //define and create the DOB column
         DataGridViewTextBoxColumn dOBCol = new DataGridViewTextBoxColumn();
         dOBCol.Name = "DOB";
         dOBCol.HeaderText = "DOB";
         dOBCol.Width = 150;
         dOBCol.ValueType = typeof(DateTime);
         this.SelectPersonGrid.Columns.Add(dOBCol);
         //define and create the SEX column
         DataGridViewTextBoxColumn sEXCol = new DataGridViewTextBoxColumn();
         sEXCol.Name = "Sex";
         sEXCol.HeaderText = "Sex";
         sEXCol.Width = 40;
         this.SelectPersonGrid.Columns.Add(sEXCol);
         //define and create the LTC Expense drop down
         //DataGridViewComboBoxColumn lTCExpCol = new DataGridViewComboBoxColumn();
         //lTCExpCol.Name = "LTCExp";
         //lTCExpCol.HeaderText = "LTC Expense?";
         //lTCExpCol.Width = 60;
         //lTCExpCol.Items.Add("Yes");
         //lTCExpCol.Items.Add("No");
         //this.SelectPersonGrid.Columns.Add(lTCExpCol);

      }
      #endregion
      #region Form Population
      public void populateGrid()
      {
         try
         {

            Boolean defaultRow;
            DataAccess dataAccess = new DataAccess();
            string urlSelectPerson = dataAccess.selectDDMainDefinitionValue("WEBSERVICE", "SelectPerson");


            SelectPerson SelectPersonWS = new CNO.BPA.DataHandler.SelectPerson(urlSelectPerson);
            
               CNO.BPA.DataHandler.LookUpResults lookUpResults = new LookUpResults();
               lookUpResults = SelectPersonWS.Lookup(_cp.PolicyNo);
               CNO.BPA.DataHandler.Person[] person = lookUpResults.PersonArray;
               if (lookUpResults.StatusCode != 0)
               {
                  MessageBox.Show(lookUpResults.StatusDesc);
               }
               else
               {
                  if (person.Length > 1)
                  {
                     defaultRow = false;
                  }
                  else
                  {
                     defaultRow = true;
                  }
                  foreach (CNO.BPA.DataHandler.Person p in person)
                  {
                     object[] sprecord = { defaultRow, p.FirstName, p.LastName, p.DOB, p.Sex };
                     this.SelectPersonGrid.Rows.Add(sprecord);

                  }
               }
            
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }

      }
      #endregion
      #region Form Buttons
      private void btnReSearch_Click(object sender, EventArgs e)
      {
         //now we can leave
         this.DialogResult = DialogResult.Ignore;
         this.Close();

      }
      private void btnCancel_Click(object sender, EventArgs e)
      {
         //now we can leave
         this.DialogResult = DialogResult.Cancel;
         this.Close();
      }
      private void btnComplete_Click(object sender, EventArgs e)
      {
         Boolean userCancelled = false;
         List<CNO.BPA.DataHandler.Person> selPersons = new List<CNO.BPA.DataHandler.Person>();
         CNO.BPA.DataHandler.Person selPerson;
         Boolean haveSelected = false;
         string lTCExpense;
         //get certified no if its filled in
         if (tbCertifiedNo.Text != "")
         {
            _cp.CertifiedNo = tbCertifiedNo.Text;
         }
         if (this.rbLTCExN.Checked == false && this.rbLTCExY.Checked == false)
         {
            MessageBox.Show("Yes or No must be selected for LTC Expense.");
            return;
         }
         //build call to SelectPerson by looping through results
         foreach (DataGridViewRow dr in this.SelectPersonGrid.Rows)
         {
            if ((Boolean)dr.Cells["useRowCheckBox"].Value)
            {
               //if (dr.Cells["LTCExp"].Value.ToString() == "")
               //{
               //    MessageBox.Show("Yes or No must be selected for LTC Expense on selected rows.");
               //    return;
               //}
               //add to list
               haveSelected = true;
               selPerson = new CNO.BPA.DataHandler.Person();
               selPerson.FirstName = dr.Cells["FirstName"].Value.ToString();
               selPerson.LastName = dr.Cells["LastName"].Value.ToString();
               selPerson.DOB = (DateTime)dr.Cells["DOB"].Value;
               selPerson.Sex = dr.Cells["Sex"].Value.ToString();
               selPersons.Add(selPerson);

            }
         }
         if (false == haveSelected)
         {
            MessageBox.Show("At least one row must be selected.");
            return;
         }
         if (this.rbLTCExN.Checked == true)
         {
            lTCExpense = "No";
         }
         else
         {
            lTCExpense = "Yes";
         }
         //build input to SelectPerson call
         Selections selections = new Selections();
         selections.PolicyNumber = _cp.PolicyNo;
         selections.LTCExpense = lTCExpense;
         selections.PersonArray = selPersons.ToArray();
         ServiceCalls serviceCalls = new ServiceCalls();
         SelectPerson SelectPersonWS = serviceCalls.getSelectPerson();         
         WorkitemResults workitemResults = new WorkitemResults();
         
           workitemResults = SelectPersonWS.CallSelectPerson(selections);
            
            if (workitemResults.StatusCode != 0)
            {
               MessageBox.Show(workitemResults.StatusDesc);
               return;
            }
            //need to check for work items with multiple BA/WT/STATUS combinations
            //if a multiple is found user must select one
            foreach (WorkItem wi in workitemResults.WorkItem)
            {
               if (wi.WorkItemRoute.Length > 1)//pop form for user to select one route (BA/WT/STATUS combo)
               {
                  this.Hide();
                  using (frmSelectPersonRoute formSPR = new frmSelectPersonRoute(wi.WorkItemRoute))
                  {

                     //setup a return from the dialog
                     System.Windows.Forms.DialogResult dres = formSPR.ShowDialog();
                     //
                     switch (dres)
                     {
                        case System.Windows.Forms.DialogResult.OK:
                           foreach (DataGridViewRow dr in formSPR.SelectPersonGrid.Rows)
                           {
                              if ((Boolean)dr.Cells["useRowCheckBox"].Value)
                              {
                                 //change route array to be single selected route
                                 WorkItemRoute selWIR = new WorkItemRoute();
                                 selWIR.BusinessArea = dr.Cells["BA"].Value.ToString();
                                 selWIR.WorkType = dr.Cells["WT"].Value.ToString();
                                 selWIR.Status = dr.Cells["STATUS"].Value.ToString();
                                 wi.WorkItemRoute = new WorkItemRoute[] { selWIR };
                              }
                           }

                           break;
                        case System.Windows.Forms.DialogResult.Cancel:
                           //user cancelled
                           userCancelled = true;
                           break;
                        default:
                           //user cancelled
                           userCancelled = true;
                           break;
                     }
                     if (userCancelled == true) { return; }

                  }
               }

            }
            _WorkItemResultsUse = workitemResults;         
         //now we can leave
         this.DialogResult = DialogResult.OK;
         this.Close();
      }
      private void btnBridge_Click(object sender, EventArgs e)
      {
         frmBridge formBridge = new frmBridge("SelectPerson");
         formBridge.SiteID = _cp.SiteID;
         formBridge.WorkCategory = _cp.WorkCategory;
         DialogResult formReturn = formBridge.ShowDialog();

         switch (formReturn)
         {
            case DialogResult.Abort:
               _cp.SiteID = formBridge.SiteID;
               _cp.WorkCategory = formBridge.WorkCategory;
               this.DialogResult = DialogResult.Abort;
               break;
            default:
               this.DialogResult = DialogResult.Cancel;
               break;
         }
      }
      #endregion
      #region Public Properties

      public WorkitemResults WorkItemResultsUse
      {
         get { return _WorkItemResultsUse; }
         set { _WorkItemResultsUse = value; }
      }
      #endregion

      private void frmSelectPerson_Load(object sender, EventArgs e)
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

      private void frmSelectPerson_FormClosed(object sender, FormClosedEventArgs e)
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