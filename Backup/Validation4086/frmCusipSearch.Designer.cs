namespace CNO.BPA.Validation4086
{
   partial class frmCusipSearch
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCusipSearch));
         this.lblCUSIP = new System.Windows.Forms.Label();
         this.txtCUSIP = new System.Windows.Forms.TextBox();
         this.lblInstructions = new System.Windows.Forms.Label();
         this.btnSearch = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.lblDocumentDate = new System.Windows.Forms.Label();
         this.dtpDocumentDate = new System.Windows.Forms.DateTimePicker();
         this.pnlDocumentDate = new System.Windows.Forms.Panel();
         this.lblErrorText = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lblCUSIP
         // 
         this.lblCUSIP.AutoSize = true;
         this.lblCUSIP.Location = new System.Drawing.Point(61, 38);
         this.lblCUSIP.Name = "lblCUSIP";
         this.lblCUSIP.Size = new System.Drawing.Size(42, 13);
         this.lblCUSIP.TabIndex = 0;
         this.lblCUSIP.Text = "CUSIP:";
         this.lblCUSIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtCUSIP
         // 
         this.txtCUSIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtCUSIP.Location = new System.Drawing.Point(107, 35);
         this.txtCUSIP.Name = "txtCUSIP";
         this.txtCUSIP.Size = new System.Drawing.Size(142, 20);
         this.txtCUSIP.TabIndex = 1;
         // 
         // lblInstructions
         // 
         this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.lblInstructions.AutoSize = true;
         this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblInstructions.Location = new System.Drawing.Point(48, 9);
         this.lblInstructions.Name = "lblInstructions";
         this.lblInstructions.Size = new System.Drawing.Size(178, 13);
         this.lblInstructions.TabIndex = 2;
         this.lblInstructions.Text = "Enter CUSIP and click Search";
         this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // btnSearch
         // 
         this.btnSearch.Location = new System.Drawing.Point(174, 108);
         this.btnSearch.Name = "btnSearch";
         this.btnSearch.Size = new System.Drawing.Size(75, 23);
         this.btnSearch.TabIndex = 3;
         this.btnSearch.Text = "Search";
         this.btnSearch.UseVisualStyleBackColor = true;
         this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(93, 108);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 4;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // lblDocumentDate
         // 
         this.lblDocumentDate.AutoSize = true;
         this.lblDocumentDate.Location = new System.Drawing.Point(18, 67);
         this.lblDocumentDate.Name = "lblDocumentDate";
         this.lblDocumentDate.Size = new System.Drawing.Size(85, 13);
         this.lblDocumentDate.TabIndex = 6;
         this.lblDocumentDate.Text = "Document Date:";
         this.lblDocumentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // dtpDocumentDate
         // 
         this.dtpDocumentDate.CustomFormat = "MM/dd/yyyy";
         this.dtpDocumentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.dtpDocumentDate.Location = new System.Drawing.Point(109, 61);
         this.dtpDocumentDate.Name = "dtpDocumentDate";
         this.dtpDocumentDate.Size = new System.Drawing.Size(138, 20);
         this.dtpDocumentDate.TabIndex = 8;
         this.dtpDocumentDate.ValueChanged += new System.EventHandler(this.dtpDocumentDate_ValueChanged);
         // 
         // pnlDocumentDate
         // 
         this.pnlDocumentDate.BackColor = System.Drawing.Color.Red;
         this.pnlDocumentDate.Location = new System.Drawing.Point(107, 59);
         this.pnlDocumentDate.Name = "pnlDocumentDate";
         this.pnlDocumentDate.Size = new System.Drawing.Size(142, 24);
         this.pnlDocumentDate.TabIndex = 7;
         this.pnlDocumentDate.Visible = false;
         // 
         // lblErrorText
         // 
         this.lblErrorText.AutoSize = true;
         this.lblErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblErrorText.ForeColor = System.Drawing.Color.Red;
         this.lblErrorText.Location = new System.Drawing.Point(99, 86);
         this.lblErrorText.Name = "lblErrorText";
         this.lblErrorText.Size = new System.Drawing.Size(161, 13);
         this.lblErrorText.TabIndex = 9;
         this.lblErrorText.Text = "DATE RANGE EXCEPTION";
         this.lblErrorText.Visible = false;
         // 
         // frmCusipSearch
         // 
         this.AcceptButton = this.btnSearch;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(272, 143);
         this.Controls.Add(this.lblErrorText);
         this.Controls.Add(this.dtpDocumentDate);
         this.Controls.Add(this.pnlDocumentDate);
         this.Controls.Add(this.lblDocumentDate);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSearch);
         this.Controls.Add(this.lblInstructions);
         this.Controls.Add(this.txtCUSIP);
         this.Controls.Add(this.lblCUSIP);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "frmCusipSearch";
         this.Text = "Private Placment Lookup";
         this.Load += new System.EventHandler(this.frmCusipSearch_Load);
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCusipSearch_FormClosed);
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCusipSearch_FormClosing);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblCUSIP;
      private System.Windows.Forms.TextBox txtCUSIP;
      private System.Windows.Forms.Label lblInstructions;
      private System.Windows.Forms.Button btnSearch;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Label lblDocumentDate;
      private System.Windows.Forms.DateTimePicker dtpDocumentDate;
      private System.Windows.Forms.Panel pnlDocumentDate;
      private System.Windows.Forms.Label lblErrorText;
   }
}