using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CNO.BPA.DataHandler;

namespace CNO.BPA.DataDirector
{
   public partial class frmExistingDDItems : Form
   {
      BindingSource masterBindingSource = new BindingSource();

      BindingSource detailsBindingSource = new BindingSource();

      IndexData _datasetResults;
      //        DataSet _datasetIndexes;
      CommonParameters _cp;

      private DataGridViewColumn childSortColumn = null;
      private ListSortDirection childSortdirection = ListSortDirection.Ascending;

      public frmExistingDDItems(IndexData Results, ref CommonParameters CP)
      {
         InitializeComponent();
         //pull in the main dataset
         _datasetResults = Results;
         _cp = CP;
      }

      private void frmExistingDDItems_Shown(object sender, EventArgs e)
      {

         masterBindingSource.DataSource = _datasetResults;
         masterBindingSource.DataMember = "DD_ITEM";
         detailsBindingSource.DataSource = masterBindingSource;
         detailsBindingSource.DataMember = "DD_ITEM_DD_ITEM_INDEXES";

         dataGridView1.DataSource = masterBindingSource;
         dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

         dataGridView2.DataSource = detailsBindingSource;
         childSortColumn = dataGridView2.Columns[1];
         childSortdirection = ListSortDirection.Ascending;
         dataGridView2.Sort(childSortColumn, childSortdirection);




      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         //now we can leave
         this.DialogResult = DialogResult.Cancel;
         this.Close();
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         if (dataGridView1.RowCount > 0)
         {
            int dditemseq;
            string uniqueID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int currentRow = dataGridView1.SelectedRows[0].Index;
            int.TryParse(uniqueID, out dditemseq);
            _cp.DDItemSeq = dditemseq;
            DeleteRecord();
            DataRow dr = _datasetResults.Tables[0].Rows[currentRow];
            dr.Delete();
            _datasetResults.AcceptChanges();
         }
      }
      private void DeleteRecord()
      {
         //grab an instance of the data access class
         DataHandler.DataAccess dataAccess = new DataAccess();
         dataAccess.deleteDataDirectorItem(ref _cp);
      }

      private void btnShowValues_Click(object sender, EventArgs e)
      {
         DataAccess dataAccess = new DataAccess();
         DataSet datasetResults = dataAccess.selectDataDirectorItem(ref _cp);

      }

      private void frmExistingDDItems_Load(object sender, EventArgs e)
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

      private void btnContinue_Click(object sender, EventArgs e)
      {
         //now we can leave
         this.DialogResult = DialogResult.Yes;
         this.Close();

      }

      private void frmExistingDDItems_FormClosed(object sender, FormClosedEventArgs e)
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


      private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
      {
         childSortColumn = dataGridView2.SortedColumn;
         if (dataGridView2.SortOrder == SortOrder.Ascending)
         {
            childSortdirection = ListSortDirection.Ascending;
         }
         else
         {
            childSortdirection = ListSortDirection.Descending;
         }

      }

      private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
      {
         if (null != dataGridView2 && dataGridView2.RowCount > 0)
         {
            if (null != childSortColumn)
            {
               dataGridView2.Sort(childSortColumn, childSortdirection);
            }
         }
      }
      

   }
}
