namespace CNO.BPA.Validation4086
{
   partial class frmLoanResults
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
         this.txtTenant = new System.Windows.Forms.TextBox();
         this.lblTenant = new System.Windows.Forms.Label();
         this.txtPropertyState = new System.Windows.Forms.TextBox();
         this.lblPropertyState = new System.Windows.Forms.Label();
         this.txtPropertyAddress1 = new System.Windows.Forms.TextBox();
         this.lblPropertyAddress1 = new System.Windows.Forms.Label();
         this.txtLoanNumber = new System.Windows.Forms.TextBox();
         this.lblLoanNumber = new System.Windows.Forms.Label();
         this.txtBorrowerName = new System.Windows.Forms.TextBox();
         this.lblBorrowerName = new System.Windows.Forms.Label();
         this.txtPropertyCity = new System.Windows.Forms.TextBox();
         this.lblPropertyCity = new System.Windows.Forms.Label();
         this.txtPropertyName = new System.Windows.Forms.TextBox();
         this.lblPropertyName = new System.Windows.Forms.Label();
         this.trvResults = new System.Windows.Forms.TreeView();
         this.txtPropertyAddress2 = new System.Windows.Forms.TextBox();
         this.lblPropertyAddress2 = new System.Windows.Forms.Label();
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
         this.btnSelect.Location = new System.Drawing.Point(312, 257);
         this.btnSelect.Name = "btnSelect";
         this.btnSelect.Size = new System.Drawing.Size(75, 23);
         this.btnSelect.TabIndex = 54;
         this.btnSelect.Text = "Select";
         this.btnSelect.UseVisualStyleBackColor = true;
         this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(393, 257);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 55;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnSearchAgain
         // 
         this.btnSearchAgain.Location = new System.Drawing.Point(13, 260);
         this.btnSearchAgain.Name = "btnSearchAgain";
         this.btnSearchAgain.Size = new System.Drawing.Size(122, 19);
         this.btnSearchAgain.TabIndex = 57;
         this.btnSearchAgain.Text = "Search Again";
         this.btnSearchAgain.UseVisualStyleBackColor = true;
         this.btnSearchAgain.Click += new System.EventHandler(this.btnSearchAgain_Click);
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
         // txtTenant
         // 
         this.txtTenant.Location = new System.Drawing.Point(144, 231);
         this.txtTenant.MaxLength = 3;
         this.txtTenant.Name = "txtTenant";
         this.txtTenant.Size = new System.Drawing.Size(324, 20);
         this.txtTenant.TabIndex = 80;
         this.txtTenant.TabStop = false;
         // 
         // lblTenant
         // 
         this.lblTenant.AutoSize = true;
         this.lblTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTenant.Location = new System.Drawing.Point(141, 215);
         this.lblTenant.Name = "lblTenant";
         this.lblTenant.Size = new System.Drawing.Size(44, 13);
         this.lblTenant.TabIndex = 81;
         this.lblTenant.Text = "Tenant:";
         this.lblTenant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtPropertyState
         // 
         this.txtPropertyState.Location = new System.Drawing.Point(397, 192);
         this.txtPropertyState.MaxLength = 3;
         this.txtPropertyState.Name = "txtPropertyState";
         this.txtPropertyState.Size = new System.Drawing.Size(71, 20);
         this.txtPropertyState.TabIndex = 78;
         this.txtPropertyState.TabStop = false;
         // 
         // lblPropertyState
         // 
         this.lblPropertyState.AutoSize = true;
         this.lblPropertyState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPropertyState.Location = new System.Drawing.Point(394, 176);
         this.lblPropertyState.Name = "lblPropertyState";
         this.lblPropertyState.Size = new System.Drawing.Size(77, 13);
         this.lblPropertyState.TabIndex = 79;
         this.lblPropertyState.Text = "Property State:";
         this.lblPropertyState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtPropertyAddress1
         // 
         this.txtPropertyAddress1.Location = new System.Drawing.Point(144, 104);
         this.txtPropertyAddress1.MaxLength = 3;
         this.txtPropertyAddress1.Name = "txtPropertyAddress1";
         this.txtPropertyAddress1.Size = new System.Drawing.Size(324, 20);
         this.txtPropertyAddress1.TabIndex = 76;
         this.txtPropertyAddress1.TabStop = false;
         // 
         // lblPropertyAddress1
         // 
         this.lblPropertyAddress1.AutoSize = true;
         this.lblPropertyAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPropertyAddress1.Location = new System.Drawing.Point(141, 88);
         this.lblPropertyAddress1.Name = "lblPropertyAddress1";
         this.lblPropertyAddress1.Size = new System.Drawing.Size(99, 13);
         this.lblPropertyAddress1.TabIndex = 77;
         this.lblPropertyAddress1.Text = "Property Address 1:";
         this.lblPropertyAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtLoanNumber
         // 
         this.txtLoanNumber.Location = new System.Drawing.Point(144, 26);
         this.txtLoanNumber.Name = "txtLoanNumber";
         this.txtLoanNumber.Size = new System.Drawing.Size(105, 20);
         this.txtLoanNumber.TabIndex = 61;
         this.txtLoanNumber.TabStop = false;
         // 
         // lblLoanNumber
         // 
         this.lblLoanNumber.AutoSize = true;
         this.lblLoanNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblLoanNumber.Location = new System.Drawing.Point(141, 10);
         this.lblLoanNumber.Name = "lblLoanNumber";
         this.lblLoanNumber.Size = new System.Drawing.Size(74, 13);
         this.lblLoanNumber.TabIndex = 67;
         this.lblLoanNumber.Text = "Loan Number:";
         this.lblLoanNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
         // txtPropertyCity
         // 
         this.txtPropertyCity.Location = new System.Drawing.Point(144, 192);
         this.txtPropertyCity.Name = "txtPropertyCity";
         this.txtPropertyCity.Size = new System.Drawing.Size(247, 20);
         this.txtPropertyCity.TabIndex = 65;
         this.txtPropertyCity.TabStop = false;
         // 
         // lblPropertyCity
         // 
         this.lblPropertyCity.AutoSize = true;
         this.lblPropertyCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPropertyCity.Location = new System.Drawing.Point(141, 176);
         this.lblPropertyCity.Name = "lblPropertyCity";
         this.lblPropertyCity.Size = new System.Drawing.Size(69, 13);
         this.lblPropertyCity.TabIndex = 60;
         this.lblPropertyCity.Text = "Property City:";
         this.lblPropertyCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtPropertyName
         // 
         this.txtPropertyName.Location = new System.Drawing.Point(144, 65);
         this.txtPropertyName.Name = "txtPropertyName";
         this.txtPropertyName.Size = new System.Drawing.Size(324, 20);
         this.txtPropertyName.TabIndex = 59;
         this.txtPropertyName.TabStop = false;
         // 
         // lblPropertyName
         // 
         this.lblPropertyName.AutoSize = true;
         this.lblPropertyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPropertyName.Location = new System.Drawing.Point(141, 49);
         this.lblPropertyName.Name = "lblPropertyName";
         this.lblPropertyName.Size = new System.Drawing.Size(80, 13);
         this.lblPropertyName.TabIndex = 58;
         this.lblPropertyName.Text = "Property Name:";
         this.lblPropertyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // trvResults
         // 
         this.trvResults.Location = new System.Drawing.Point(13, 26);
         this.trvResults.Name = "trvResults";
         this.trvResults.Size = new System.Drawing.Size(122, 225);
         this.trvResults.TabIndex = 53;
         this.trvResults.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvResults_AfterSelect);
         // 
         // txtPropertyAddress2
         // 
         this.txtPropertyAddress2.Location = new System.Drawing.Point(144, 148);
         this.txtPropertyAddress2.MaxLength = 3;
         this.txtPropertyAddress2.Name = "txtPropertyAddress2";
         this.txtPropertyAddress2.Size = new System.Drawing.Size(324, 20);
         this.txtPropertyAddress2.TabIndex = 94;
         this.txtPropertyAddress2.TabStop = false;
         // 
         // lblPropertyAddress2
         // 
         this.lblPropertyAddress2.AutoSize = true;
         this.lblPropertyAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPropertyAddress2.Location = new System.Drawing.Point(141, 132);
         this.lblPropertyAddress2.Name = "lblPropertyAddress2";
         this.lblPropertyAddress2.Size = new System.Drawing.Size(99, 13);
         this.lblPropertyAddress2.TabIndex = 95;
         this.lblPropertyAddress2.Text = "Property Address 2:";
         this.lblPropertyAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // frmLoanResults
         // 
         this.AcceptButton = this.btnSelect;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(479, 289);
         this.Controls.Add(this.txtPropertyAddress2);
         this.Controls.Add(this.lblPropertyAddress2);
         this.Controls.Add(this.lblTotalRecords);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.btnSelect);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSearchAgain);
         this.Controls.Add(this.lblCurrentRecord);
         this.Controls.Add(this.lblResults);
         this.Controls.Add(this.txtTenant);
         this.Controls.Add(this.lblTenant);
         this.Controls.Add(this.txtPropertyState);
         this.Controls.Add(this.lblPropertyState);
         this.Controls.Add(this.txtPropertyAddress1);
         this.Controls.Add(this.lblPropertyAddress1);
         this.Controls.Add(this.txtLoanNumber);
         this.Controls.Add(this.lblLoanNumber);
         this.Controls.Add(this.txtBorrowerName);
         this.Controls.Add(this.lblBorrowerName);
         this.Controls.Add(this.txtPropertyCity);
         this.Controls.Add(this.lblPropertyCity);
         this.Controls.Add(this.txtPropertyName);
         this.Controls.Add(this.lblPropertyName);
         this.Controls.Add(this.trvResults);
         this.Name = "frmLoanResults";
         this.Text = "Search Results";
         this.Load += new System.EventHandler(this.frmLoanResults_Load);
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLoanResults_FormClosed);
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
      private System.Windows.Forms.TextBox txtTenant;
      private System.Windows.Forms.Label lblTenant;
      private System.Windows.Forms.TextBox txtPropertyState;
      private System.Windows.Forms.Label lblPropertyState;
      private System.Windows.Forms.TextBox txtPropertyAddress1;
      private System.Windows.Forms.Label lblPropertyAddress1;
      private System.Windows.Forms.TextBox txtLoanNumber;
      private System.Windows.Forms.Label lblLoanNumber;
      private System.Windows.Forms.TextBox txtBorrowerName;
      private System.Windows.Forms.Label lblBorrowerName;
      private System.Windows.Forms.TextBox txtPropertyCity;
      private System.Windows.Forms.Label lblPropertyCity;
      private System.Windows.Forms.TextBox txtPropertyName;
      private System.Windows.Forms.Label lblPropertyName;
      private System.Windows.Forms.TreeView trvResults;
      private System.Windows.Forms.TextBox txtPropertyAddress2;
      private System.Windows.Forms.Label lblPropertyAddress2;
   }
}