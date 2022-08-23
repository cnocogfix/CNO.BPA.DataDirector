namespace CNO.BPA.PrivacyMailingValidation
{
   partial class frmPrivacySearch
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
         this.txtMasterID = new System.Windows.Forms.TextBox();
         this.lblMasterID = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(35, 94);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 9;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnSearch
         // 
         this.btnSearch.Location = new System.Drawing.Point(131, 94);
         this.btnSearch.Name = "btnSearch";
         this.btnSearch.Size = new System.Drawing.Size(75, 23);
         this.btnSearch.TabIndex = 8;
         this.btnSearch.Text = "Search";
         this.btnSearch.UseVisualStyleBackColor = true;
         this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
         // 
         // lblInstructions
         // 
         this.lblInstructions.AutoSize = true;
         this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblInstructions.Location = new System.Drawing.Point(42, 14);
         this.lblInstructions.Name = "lblInstructions";
         this.lblInstructions.Size = new System.Drawing.Size(196, 13);
         this.lblInstructions.TabIndex = 7;
         this.lblInstructions.Text = "Enter Master ID and click Search";
         // 
         // txtMasterID
         // 
         this.txtMasterID.Location = new System.Drawing.Point(65, 51);
         this.txtMasterID.Name = "txtMasterID";
         this.txtMasterID.Size = new System.Drawing.Size(158, 20);
         this.txtMasterID.TabIndex = 6;
         // 
         // lblMasterID
         // 
         this.lblMasterID.AutoSize = true;
         this.lblMasterID.Location = new System.Drawing.Point(9, 53);
         this.lblMasterID.Name = "lblMasterID";
         this.lblMasterID.Size = new System.Drawing.Size(53, 13);
         this.lblMasterID.TabIndex = 5;
         this.lblMasterID.Text = "Master ID";
         // 
         // frmPrivacySearch
         // 
         this.AcceptButton = this.btnSearch;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(247, 142);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSearch);
         this.Controls.Add(this.lblInstructions);
         this.Controls.Add(this.txtMasterID);
         this.Controls.Add(this.lblMasterID);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.Name = "frmPrivacySearch";
         this.Text = "Privacy Search";
         this.Load += new System.EventHandler(this.frmPrivacySearch_Load);
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrivacySearch_FormClosed);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnSearch;
      private System.Windows.Forms.Label lblInstructions;
      private System.Windows.Forms.TextBox txtMasterID;
      private System.Windows.Forms.Label lblMasterID;
   }
}