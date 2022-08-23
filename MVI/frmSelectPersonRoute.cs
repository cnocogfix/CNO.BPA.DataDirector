using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CNO.BPA.DataHandler;
namespace CNO.BPA.MVI
{
   public partial class frmSelectPersonRoute : Form
   {
      public frmSelectPersonRoute(WorkItemRoute[] routes)
      {
         InitializeComponent();
         InitializeGrid();
         foreach (WorkItemRoute wir in routes)
         {
            object[] wirrecord = { false, wir.BusinessArea, wir.WorkType, wir.Status };
            this.SelectPersonGrid.Rows.Add(wirrecord);

         }
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
         //define and create the BA column
         DataGridViewTextBoxColumn bACol = new DataGridViewTextBoxColumn();
         bACol.Name = "BA";
         bACol.HeaderText = "Business Area";
         bACol.DefaultCellStyle.BackColor = Color.LightGray;
         bACol.ReadOnly = true;
         bACol.Width = 100;
         this.SelectPersonGrid.Columns.Add(bACol);
         //define and create the WT column
         DataGridViewTextBoxColumn wTCol = new DataGridViewTextBoxColumn();
         wTCol.Name = "WT";
         wTCol.HeaderText = "Work Type";
         wTCol.DefaultCellStyle.BackColor = Color.LightGray;
         wTCol.ReadOnly = true;
         wTCol.Width = 100;
         this.SelectPersonGrid.Columns.Add(wTCol);
         //define and create the STATUS column
         DataGridViewTextBoxColumn statusCol = new DataGridViewTextBoxColumn();
         statusCol.Name = "STATUS";
         statusCol.HeaderText = "Status";
         statusCol.DefaultCellStyle.BackColor = Color.LightGray;
         statusCol.ReadOnly = true;
         statusCol.Width = 100;
         this.SelectPersonGrid.Columns.Add(statusCol);


      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         //now we can leave
         this.DialogResult = DialogResult.Cancel;
         this.Close();

      }

      private void btnComplete_Click(object sender, EventArgs e)
      {
         Int32 numChecked = 0;
         foreach (DataGridViewRow dr in this.SelectPersonGrid.Rows)
         {
            if ((Boolean)dr.Cells["useRowCheckBox"].Value)
            {
               numChecked++;
            }
         }
         if (numChecked == 0)
         {
            MessageBox.Show("One BA/WT/STATUS combination must be selected.");
            return;
         }
         if (numChecked > 1)
         {
            MessageBox.Show("Only one BA/WT/STATUS combination must be selected.");
            return;
         }
         //now we can leave
         this.DialogResult = DialogResult.OK;
         this.Close();

      }


   }
}