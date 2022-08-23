namespace CNO.BPA.MVI
{
   partial class frmSelectPerson
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectPerson));
         this.tbCertifiedNo = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.SelectPersonGrid = new System.Windows.Forms.DataGridView();
         this.btnReSearch = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnComplete = new System.Windows.Forms.Button();
         this.btnBridge = new System.Windows.Forms.Button();
         this.rbLTCExN = new System.Windows.Forms.RadioButton();
         this.rbLTCExY = new System.Windows.Forms.RadioButton();
         this.label2 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         ((System.ComponentModel.ISupportInitialize)(this.SelectPersonGrid)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tbCertifiedNo
         // 
         this.tbCertifiedNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.tbCertifiedNo.Location = new System.Drawing.Point(127, 236);
         this.tbCertifiedNo.MaxLength = 24;
         this.tbCertifiedNo.Name = "tbCertifiedNo";
         this.tbCertifiedNo.Size = new System.Drawing.Size(139, 20);
         this.tbCertifiedNo.TabIndex = 75;
         // 
         // label1
         // 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(43, 236);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(81, 22);
         this.label1.TabIndex = 74;
         this.label1.Text = "Certified No:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // SelectPersonGrid
         // 
         this.SelectPersonGrid.AllowUserToAddRows = false;
         this.SelectPersonGrid.AllowUserToDeleteRows = false;
         this.SelectPersonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.SelectPersonGrid.Dock = System.Windows.Forms.DockStyle.Top;
         this.SelectPersonGrid.Location = new System.Drawing.Point(0, 0);
         this.SelectPersonGrid.Name = "SelectPersonGrid";
         this.SelectPersonGrid.Size = new System.Drawing.Size(517, 153);
         this.SelectPersonGrid.TabIndex = 81;
         // 
         // btnReSearch
         // 
         this.btnReSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnReSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnReSearch.Location = new System.Drawing.Point(280, 233);
         this.btnReSearch.Name = "btnReSearch";
         this.btnReSearch.Size = new System.Drawing.Size(70, 23);
         this.btnReSearch.TabIndex = 84;
         this.btnReSearch.Text = "re-Search";
         this.btnReSearch.UseVisualStyleBackColor = true;
         this.btnReSearch.Click += new System.EventHandler(this.btnReSearch_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCancel.Location = new System.Drawing.Point(432, 233);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(70, 23);
         this.btnCancel.TabIndex = 85;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnComplete
         // 
         this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnComplete.Location = new System.Drawing.Point(356, 233);
         this.btnComplete.Name = "btnComplete";
         this.btnComplete.Size = new System.Drawing.Size(70, 23);
         this.btnComplete.TabIndex = 82;
         this.btnComplete.Text = "Complete";
         this.btnComplete.UseVisualStyleBackColor = true;
         this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
         // 
         // btnBridge
         // 
         this.btnBridge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.btnBridge.Image = ((System.Drawing.Image)(resources.GetObject("btnBridge.Image")));
         this.btnBridge.Location = new System.Drawing.Point(13, 227);
         this.btnBridge.Name = "btnBridge";
         this.btnBridge.Size = new System.Drawing.Size(30, 31);
         this.btnBridge.TabIndex = 86;
         this.btnBridge.UseVisualStyleBackColor = true;
         this.btnBridge.Click += new System.EventHandler(this.btnBridge_Click);
         // 
         // rbLTCExN
         // 
         this.rbLTCExN.AutoSize = true;
         this.rbLTCExN.Location = new System.Drawing.Point(175, 26);
         this.rbLTCExN.Name = "rbLTCExN";
         this.rbLTCExN.Size = new System.Drawing.Size(39, 17);
         this.rbLTCExN.TabIndex = 87;
         this.rbLTCExN.TabStop = true;
         this.rbLTCExN.Text = "No";
         this.rbLTCExN.UseVisualStyleBackColor = true;
         // 
         // rbLTCExY
         // 
         this.rbLTCExY.AutoSize = true;
         this.rbLTCExY.Location = new System.Drawing.Point(123, 26);
         this.rbLTCExY.Name = "rbLTCExY";
         this.rbLTCExY.Size = new System.Drawing.Size(43, 17);
         this.rbLTCExY.TabIndex = 88;
         this.rbLTCExY.TabStop = true;
         this.rbLTCExY.Text = "Yes";
         this.rbLTCExY.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(15, 27);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(89, 13);
         this.label2.TabIndex = 89;
         this.label2.Text = "LTC Expense?";
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.rbLTCExY);
         this.groupBox1.Controls.Add(this.rbLTCExN);
         this.groupBox1.Location = new System.Drawing.Point(150, 159);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(223, 62);
         this.groupBox1.TabIndex = 90;
         this.groupBox1.TabStop = false;
         // 
         // frmSelectPerson
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(517, 269);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.btnBridge);
         this.Controls.Add(this.btnReSearch);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnComplete);
         this.Controls.Add(this.SelectPersonGrid);
         this.Controls.Add(this.tbCertifiedNo);
         this.Controls.Add(this.label1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MinimumSize = new System.Drawing.Size(525, 303);
         this.Name = "frmSelectPerson";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Select Person";
         this.Load += new System.EventHandler(this.frmSelectPerson_Load);
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSelectPerson_FormClosed);
         ((System.ComponentModel.ISupportInitialize)(this.SelectPersonGrid)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox tbCertifiedNo;
       private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DataGridView SelectPersonGrid;
       private System.Windows.Forms.Button btnReSearch;
       private System.Windows.Forms.Button btnCancel;
       private System.Windows.Forms.Button btnComplete;
       private System.Windows.Forms.Button btnBridge;
       private System.Windows.Forms.RadioButton rbLTCExN;
       private System.Windows.Forms.RadioButton rbLTCExY;
       private System.Windows.Forms.Label label2;
      private System.Windows.Forms.GroupBox groupBox1;

   }
}