namespace CNO.BPA.Validation4086
{
   partial class frmCUSIPResults
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
         this.lblTotalRecords = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.btnSelect = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnSearchAgain = new System.Windows.Forms.Button();
         this.lblCurrentRecord = new System.Windows.Forms.Label();
         this.lblResults = new System.Windows.Forms.Label();
         this.txtIssuerID = new System.Windows.Forms.TextBox();
         this.lblIssuerID = new System.Windows.Forms.Label();
         this.txtCUSIP = new System.Windows.Forms.TextBox();
         this.lblCUSIP = new System.Windows.Forms.Label();
         this.txtBorrowerName = new System.Windows.Forms.TextBox();
         this.lblBorrowerName = new System.Windows.Forms.Label();
         this.txtParentName = new System.Windows.Forms.TextBox();
         this.lblParentName = new System.Windows.Forms.Label();
         this.trvResults = new System.Windows.Forms.TreeView();
         this.SuspendLayout();
         // 
         // lblTotalRecords
         // 
         this.lblTotalRecords.AutoSize = true;
         this.lblTotalRecords.Location = new System.Drawing.Point(107, 10);
         this.lblTotalRecords.Name = "lblTotalRecords";
         this.lblTotalRecords.Size = new System.Drawing.Size(13, 13);
         this.lblTotalRecords.TabIndex = 93;
         this.lblTotalRecords.Text = "1";
         this.lblTotalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(87, 10);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(16, 13);
         this.label7.TabIndex = 92;
         this.label7.Text = "of";
         // 
         // btnSelect
         // 
         this.btnSelect.Location = new System.Drawing.Point(313, 130);
         this.btnSelect.Name = "btnSelect";
         this.btnSelect.Size = new System.Drawing.Size(75, 23);
         this.btnSelect.TabIndex = 54;
         this.btnSelect.Text = "Select";
         this.btnSelect.UseVisualStyleBackColor = true;
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(394, 130);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 55;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         // 
         // btnSearchAgain
         // 
         this.btnSearchAgain.Location = new System.Drawing.Point(14, 133);
         this.btnSearchAgain.Name = "btnSearchAgain";
         this.btnSearchAgain.Size = new System.Drawing.Size(122, 19);
         this.btnSearchAgain.TabIndex = 57;
         this.btnSearchAgain.Text = "Search Again";
         this.btnSearchAgain.UseVisualStyleBackColor = true;
         // 
         // lblCurrentRecord
         // 
         this.lblCurrentRecord.Location = new System.Drawing.Point(55, 10);
         this.lblCurrentRecord.Name = "lblCurrentRecord";
         this.lblCurrentRecord.Size = new System.Drawing.Size(33, 13);
         this.lblCurrentRecord.TabIndex = 89;
         this.lblCurrentRecord.Text = "1";
         this.lblCurrentRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // lblResults
         // 
         this.lblResults.AutoSize = true;
         this.lblResults.Location = new System.Drawing.Point(10, 10);
         this.lblResults.Name = "lblResults";
         this.lblResults.Size = new System.Drawing.Size(45, 13);
         this.lblResults.TabIndex = 88;
         this.lblResults.Text = "Record:";
         // 
         // txtIssuerID
         // 
         this.txtIssuerID.Location = new System.Drawing.Point(144, 104);
         this.txtIssuerID.MaxLength = 3;
         this.txtIssuerID.Name = "txtIssuerID";
         this.txtIssuerID.Size = new System.Drawing.Size(324, 20);
         this.txtIssuerID.TabIndex = 76;
         this.txtIssuerID.TabStop = false;
         // 
         // lblIssuerID
         // 
         this.lblIssuerID.AutoSize = true;
         this.lblIssuerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblIssuerID.Location = new System.Drawing.Point(141, 88);
         this.lblIssuerID.Name = "lblIssuerID";
         this.lblIssuerID.Size = new System.Drawing.Size(52, 13);
         this.lblIssuerID.TabIndex = 77;
         this.lblIssuerID.Text = "Issuer ID:";
         this.lblIssuerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtCUSIP
         // 
         this.txtCUSIP.Location = new System.Drawing.Point(144, 26);
         this.txtCUSIP.Name = "txtCUSIP";
         this.txtCUSIP.Size = new System.Drawing.Size(105, 20);
         this.txtCUSIP.TabIndex = 61;
         this.txtCUSIP.TabStop = false;
         // 
         // lblCUSIP
         // 
         this.lblCUSIP.AutoSize = true;
         this.lblCUSIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCUSIP.Location = new System.Drawing.Point(141, 10);
         this.lblCUSIP.Name = "lblCUSIP";
         this.lblCUSIP.Size = new System.Drawing.Size(42, 13);
         this.lblCUSIP.TabIndex = 67;
         this.lblCUSIP.Text = "CUSIP:";
         this.lblCUSIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtBorrowerName
         // 
         this.txtBorrowerName.Location = new System.Drawing.Point(255, 26);
         this.txtBorrowerName.Name = "txtBorrowerName";
         this.txtBorrowerName.Size = new System.Drawing.Size(213, 20);
         this.txtBorrowerName.TabIndex = 64;
         this.txtBorrowerName.TabStop = false;
         // 
         // lblBorrowerName
         // 
         this.lblBorrowerName.AutoSize = true;
         this.lblBorrowerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblBorrowerName.Location = new System.Drawing.Point(252, 10);
         this.lblBorrowerName.Name = "lblBorrowerName";
         this.lblBorrowerName.Size = new System.Drawing.Size(83, 13);
         this.lblBorrowerName.TabIndex = 63;
         this.lblBorrowerName.Text = "Borrower Name:";
         this.lblBorrowerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtParentName
         // 
         this.txtParentName.Location = new System.Drawing.Point(144, 65);
         this.txtParentName.Name = "txtParentName";
         this.txtParentName.Size = new System.Drawing.Size(324, 20);
         this.txtParentName.TabIndex = 59;
         this.txtParentName.TabStop = false;
         // 
         // lblParentName
         // 
         this.lblParentName.AutoSize = true;
         this.lblParentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblParentName.Location = new System.Drawing.Point(141, 49);
         this.lblParentName.Name = "lblParentName";
         this.lblParentName.Size = new System.Drawing.Size(72, 13);
         this.lblParentName.TabIndex = 58;
         this.lblParentName.Text = "Parent Name:";
         this.lblParentName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // trvResults
         // 
         this.trvResults.Location = new System.Drawing.Point(13, 26);
         this.trvResults.Name = "trvResults";
         this.trvResults.Size = new System.Drawing.Size(122, 98);
         this.trvResults.TabIndex = 53;
         this.trvResults.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvResults_AfterSelect);
         // 
         // frmCUSIPResults
         // 
         this.AcceptButton = this.btnSelect;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(479, 160);
         this.Controls.Add(this.lblTotalRecords);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.btnSelect);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSearchAgain);
         this.Controls.Add(this.lblCurrentRecord);
         this.Controls.Add(this.lblResults);
         this.Controls.Add(this.txtIssuerID);
         this.Controls.Add(this.lblIssuerID);
         this.Controls.Add(this.txtCUSIP);
         this.Controls.Add(this.lblCUSIP);
         this.Controls.Add(this.txtBorrowerName);
         this.Controls.Add(this.lblBorrowerName);
         this.Controls.Add(this.txtParentName);
         this.Controls.Add(this.lblParentName);
         this.Controls.Add(this.trvResults);
         this.Name = "frmCUSIPResults";
         this.Text = "Search Results";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblTotalRecords;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Button btnSelect;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnSearchAgain;
      private System.Windows.Forms.Label lblCurrentRecord;
      private System.Windows.Forms.Label lblResults;
      private System.Windows.Forms.TextBox txtIssuerID;
      private System.Windows.Forms.Label lblIssuerID;
      private System.Windows.Forms.TextBox txtCUSIP;
      private System.Windows.Forms.Label lblCUSIP;
      private System.Windows.Forms.TextBox txtBorrowerName;
      private System.Windows.Forms.Label lblBorrowerName;
      private System.Windows.Forms.TextBox txtParentName;
      private System.Windows.Forms.Label lblParentName;
      private System.Windows.Forms.TreeView trvResults;
   }
}