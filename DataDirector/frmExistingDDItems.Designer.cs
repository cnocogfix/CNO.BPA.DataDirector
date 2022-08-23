namespace CNO.BPA.DataDirector
{
    partial class frmExistingDDItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
           this.dataGridView1 = new System.Windows.Forms.DataGridView();
           this.btnCancel = new System.Windows.Forms.Button();
           this.btnContinue = new System.Windows.Forms.Button();
           this.btnDelete = new System.Windows.Forms.Button();
           this.dataGridView2 = new System.Windows.Forms.DataGridView();
           ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
           ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
           this.SuspendLayout();
           // 
           // dataGridView1
           // 
           this.dataGridView1.AllowUserToAddRows = false;
           this.dataGridView1.AllowUserToDeleteRows = false;
           this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
           this.dataGridView1.Location = new System.Drawing.Point(0, 0);
           this.dataGridView1.MultiSelect = false;
           this.dataGridView1.Name = "dataGridView1";
           this.dataGridView1.ReadOnly = true;
           this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
           this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
           this.dataGridView1.ShowCellErrors = false;
           this.dataGridView1.ShowCellToolTips = false;
           this.dataGridView1.ShowEditingIcon = false;
           this.dataGridView1.ShowRowErrors = false;
           this.dataGridView1.Size = new System.Drawing.Size(440, 129);
           this.dataGridView1.TabIndex = 1;
           this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
           // 
           // btnCancel
           // 
           this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
           this.btnCancel.Location = new System.Drawing.Point(353, 369);
           this.btnCancel.Name = "btnCancel";
           this.btnCancel.Size = new System.Drawing.Size(75, 23);
           this.btnCancel.TabIndex = 2;
           this.btnCancel.Text = "Cancel";
           this.btnCancel.UseVisualStyleBackColor = true;
           this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
           // 
           // btnContinue
           // 
           this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
           this.btnContinue.Location = new System.Drawing.Point(272, 369);
           this.btnContinue.Name = "btnContinue";
           this.btnContinue.Size = new System.Drawing.Size(75, 23);
           this.btnContinue.TabIndex = 3;
           this.btnContinue.Text = "Continue";
           this.btnContinue.UseVisualStyleBackColor = true;
           this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
           // 
           // btnDelete
           // 
           this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
           this.btnDelete.Location = new System.Drawing.Point(191, 369);
           this.btnDelete.Name = "btnDelete";
           this.btnDelete.Size = new System.Drawing.Size(75, 23);
           this.btnDelete.TabIndex = 4;
           this.btnDelete.Text = "Delete";
           this.btnDelete.UseVisualStyleBackColor = true;
           this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
           // 
           // dataGridView2
           // 
           this.dataGridView2.AllowUserToAddRows = false;
           this.dataGridView2.AllowUserToDeleteRows = false;
           this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
           this.dataGridView2.Location = new System.Drawing.Point(0, 135);
           this.dataGridView2.MultiSelect = false;
           this.dataGridView2.Name = "dataGridView2";
           this.dataGridView2.ReadOnly = true;
           this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
           this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
           this.dataGridView2.ShowCellErrors = false;
           this.dataGridView2.ShowCellToolTips = false;
           this.dataGridView2.ShowEditingIcon = false;
           this.dataGridView2.ShowRowErrors = false;
           this.dataGridView2.Size = new System.Drawing.Size(440, 225);
           this.dataGridView2.TabIndex = 6;
           this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
           // 
           // frmExistingDDItems
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(440, 399);
           this.Controls.Add(this.dataGridView2);
           this.Controls.Add(this.btnDelete);
           this.Controls.Add(this.btnContinue);
           this.Controls.Add(this.btnCancel);
           this.Controls.Add(this.dataGridView1);
           this.Name = "frmExistingDDItems";
           this.Text = "Indexes for Current Document";
           this.Load += new System.EventHandler(this.frmExistingDDItems_Load);
           this.Shown += new System.EventHandler(this.frmExistingDDItems_Shown);
           this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmExistingDDItems_FormClosed);
           ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
           ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
           this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}