namespace CNO.BPA.MVI
{
    partial class frmSelectPersonRoute
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
           System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectPersonRoute));
           this.SelectPersonGrid = new System.Windows.Forms.DataGridView();
           this.btnCancel = new System.Windows.Forms.Button();
           this.btnComplete = new System.Windows.Forms.Button();
           ((System.ComponentModel.ISupportInitialize)(this.SelectPersonGrid)).BeginInit();
           this.SuspendLayout();
           // 
           // SelectPersonGrid
           // 
           this.SelectPersonGrid.AllowUserToAddRows = false;
           this.SelectPersonGrid.AllowUserToDeleteRows = false;
           this.SelectPersonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.SelectPersonGrid.Dock = System.Windows.Forms.DockStyle.Top;
           this.SelectPersonGrid.Location = new System.Drawing.Point(0, 0);
           this.SelectPersonGrid.Name = "SelectPersonGrid";
           this.SelectPersonGrid.Size = new System.Drawing.Size(384, 132);
           this.SelectPersonGrid.TabIndex = 82;
           // 
           // btnCancel
           // 
           this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
           this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
           this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.btnCancel.Location = new System.Drawing.Point(302, 141);
           this.btnCancel.Name = "btnCancel";
           this.btnCancel.Size = new System.Drawing.Size(70, 23);
           this.btnCancel.TabIndex = 87;
           this.btnCancel.Text = "Cancel";
           this.btnCancel.UseVisualStyleBackColor = true;
           this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
           // 
           // btnComplete
           // 
           this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
           this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.btnComplete.Location = new System.Drawing.Point(226, 141);
           this.btnComplete.Name = "btnComplete";
           this.btnComplete.Size = new System.Drawing.Size(70, 23);
           this.btnComplete.TabIndex = 86;
           this.btnComplete.Text = "Complete";
           this.btnComplete.UseVisualStyleBackColor = true;
           this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
           // 
           // frmSelectPersonRoute
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(384, 172);
           this.Controls.Add(this.btnCancel);
           this.Controls.Add(this.btnComplete);
           this.Controls.Add(this.SelectPersonGrid);
           this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
           this.Name = "frmSelectPersonRoute";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
           this.Text = "Select Route";
           ((System.ComponentModel.ISupportInitialize)(this.SelectPersonGrid)).EndInit();
           this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnComplete;
        internal System.Windows.Forms.DataGridView SelectPersonGrid;
    }
}