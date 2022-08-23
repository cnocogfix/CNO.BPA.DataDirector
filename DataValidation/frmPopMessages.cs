using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CNO.BPA.DataValidation
{
   public partial class frmPopMessages : Form
   {
      private Qdetl2_area _popData;

      public frmPopMessages(Qdetl2_area PopData)
      {
         _popData = PopData;
         InitializeComponent();
         InitializeGrid();
         populateGrid();
      }
      private void InitializeGrid()
      {
         //start by clearing the grid
         dataGridView1.Rows.Clear();
         dataGridView1.Columns.Clear();
         //dataGridView1.Dock = DockStyle.Fill;
         //define and create the db parameter column
         DataGridViewTextBoxColumn popCode = new DataGridViewTextBoxColumn();
         popCode.Name = "POPCODE";
         popCode.HeaderText = "Pop Code";
         popCode.DefaultCellStyle.BackColor = Color.Pink;
         popCode.ReadOnly = true;
         //dbParm.Width = 120;
         popCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
         dataGridView1.Columns.Add(popCode);
         //define and create the ia value column
         DataGridViewTextBoxColumn popMSG = new DataGridViewTextBoxColumn();
         popMSG.HeaderText = "POP MESSAGE";
         popMSG.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
         popMSG.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
         dataGridView1.Columns.Add(popMSG);

      }
      private void populateGrid()
      {

         try
         {  
            Qdetl2_areaQdetl2_outputQdetl2_pop_arrayQdetl2_pop_lines[] output;

            if (_popData.Qdetl2_output.Qdetl2_pop_cnt > 0)
            {
                if (_popData.Qdetl2_output.Qdetl2_pop_array != null)
                {
                    for (int i = 0; i <= _popData.Qdetl2_output.Qdetl2_pop_array.Length - 1; i++)
                    {
                        output = _popData.Qdetl2_output.Qdetl2_pop_array;

                        if (null != output[i].Qdetl2_pop_cd)
                        {

                            if (output[i].Qdetl2_pop_cd.ToString().Length > 0)
                            {
                                //add each type to the drop down

                                DataGridViewRow row = new DataGridViewRow();

                                string[] dbValues = new string[2];

                                dbValues[0] = output[i].Qdetl2_pop_cd.ToString();

                                dbValues[1] = output[i].Qdetl2_pop_msg.ToString();

                                dataGridView1.Rows.Add(dbValues);

                            }

                        }

                        if (null != output[i].Qdetl2_pop_msg)
                        {

                            if (output[i].Qdetl2_pop_msg.ToString().Length > 0)
                            {

                                int prevRow = dataGridView1.Rows.GetLastRow(

                                   DataGridViewElementStates.Visible);

                                if (i > 0)
                                {

                                    string prevValue = dataGridView1.Rows[prevRow]

                                      .Cells[1].Value.ToString();


                                    dataGridView1.Rows[prevRow].Cells[1].Value = prevValue + "\r\n"

                                       + output[i].Qdetl2_pop_msg.ToString();

                                }
                            }
                        }
                    }
                }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }          
      }

      private void btnContinue_Click(object sender, EventArgs e)
      {
         //we can simply close the form and continue normal processing
         this.Close();        
      } 
   }
}