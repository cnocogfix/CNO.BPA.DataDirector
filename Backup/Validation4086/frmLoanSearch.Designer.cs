namespace CNO.BPA.Validation4086
{
   partial class frmLoanSearch
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
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnSearch = new System.Windows.Forms.Button();
         this.lblInstructions = new System.Windows.Forms.Label();
         this.txtLoan = new System.Windows.Forms.TextBox();
         this.lblCUSIP = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnCancel
         // 
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(81, 97);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 9;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnSearch
         // 
         this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnSearch.Location = new System.Drawing.Point(162, 97);
         this.btnSearch.Name = "btnSearch";
         this.btnSearch.Size = new System.Drawing.Size(75, 23);
         this.btnSearch.TabIndex = 8;
         this.btnSearch.Text = "Search";
         this.btnSearch.UseVisualStyleBackColor = true;
         this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
         // 
         // lblInstructions
         // 
         this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.lblInstructions.AutoSize = true;
         this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblInstructions.Location = new System.Drawing.Point(29, 14);
         this.lblInstructions.Name = "lblInstructions";
         this.lblInstructions.Size = new System.Drawing.Size(216, 13);
         this.lblInstructions.TabIndex = 7;
         this.lblInstructions.Text = "Enter Loan Number and click Search";
         this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtLoan
         // 
         this.txtLoan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtLoan.Location = new System.Drawing.Point(114, 42);
         this.txtLoan.Name = "txtLoan";
         this.txtLoan.Size = new System.Drawing.Size(123, 20);
         this.txtLoan.TabIndex = 6;
         // 
         // lblCUSIP
         // 
         this.lblCUSIP.AutoSize = true;
         this.lblCUSIP.Location = new System.Drawing.Point(34, 45);
         this.lblCUSIP.Name = "lblCUSIP";
         this.lblCUSIP.Size = new System.Drawing.Size(74, 13);
         this.lblCUSIP.TabIndex = 5;
         this.lblCUSIP.Text = "Loan Number:";
         this.lblCUSIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // frmLoanSearch
         // 
         this.AcceptButton = this.btnSearch;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(274, 137);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSearch);
         this.Controls.Add(this.lblInstructions);
         this.Controls.Add(this.txtLoan);
         this.Controls.Add(this.lblCUSIP);
         this.Name = "frmLoanSearch";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Loan Number Lookup";
         this.Load += new System.EventHandler(this.frmLoanSearch_Load);
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLoanSearch_FormClosed);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnSearch;
      private System.Windows.Forms.Label lblInstructions;
      private System.Windows.Forms.TextBox txtLoan;
      private System.Windows.Forms.Label lblCUSIP;
   }
}