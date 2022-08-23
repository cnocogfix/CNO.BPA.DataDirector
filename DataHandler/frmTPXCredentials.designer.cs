namespace CNO.BPA.DataHandler
{
   partial class frmTPXCredentials
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
         this.lblUserID = new System.Windows.Forms.Label();
         this.txtTPXUserID = new System.Windows.Forms.TextBox();
         this.txtTPXPassword = new System.Windows.Forms.TextBox();
         this.lblPassword = new System.Windows.Forms.Label();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnOK = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblUserID
         // 
         this.lblUserID.AutoSize = true;
         this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblUserID.Location = new System.Drawing.Point(23, 12);
         this.lblUserID.Name = "lblUserID";
         this.lblUserID.Size = new System.Drawing.Size(54, 13);
         this.lblUserID.TabIndex = 0;
         this.lblUserID.Text = "User ID:";
         this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // txtTPXUserID
         // 
         this.txtTPXUserID.Location = new System.Drawing.Point(83, 9);
         this.txtTPXUserID.Name = "txtTPXUserID";
         this.txtTPXUserID.Size = new System.Drawing.Size(136, 20);
         this.txtTPXUserID.TabIndex = 1;
         // 
         // txtTPXPassword
         // 
         this.txtTPXPassword.Location = new System.Drawing.Point(83, 35);
         this.txtTPXPassword.Name = "txtTPXPassword";
         this.txtTPXPassword.PasswordChar = '*';
         this.txtTPXPassword.Size = new System.Drawing.Size(136, 20);
         this.txtTPXPassword.TabIndex = 3;
         // 
         // lblPassword
         // 
         this.lblPassword.AutoSize = true;
         this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblPassword.Location = new System.Drawing.Point(12, 38);
         this.lblPassword.Name = "lblPassword";
         this.lblPassword.Size = new System.Drawing.Size(65, 13);
         this.lblPassword.TabIndex = 2;
         this.lblPassword.Text = "Password:";
         this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // btnCancel
         // 
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(153, 76);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(64, 26);
         this.btnCancel.TabIndex = 4;
         this.btnCancel.Text = "&Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         // 
         // btnOK
         // 
         this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnOK.Location = new System.Drawing.Point(83, 76);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(64, 26);
         this.btnOK.TabIndex = 5;
         this.btnOK.Text = "OK";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // frmTPXCredentials
         // 
         this.AcceptButton = this.btnOK;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(229, 111);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.txtTPXPassword);
         this.Controls.Add(this.lblPassword);
         this.Controls.Add(this.txtTPXUserID);
         this.Controls.Add(this.lblUserID);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "frmTPXCredentials";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "TPX Login Credentials";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblUserID;
      private System.Windows.Forms.TextBox txtTPXUserID;
      private System.Windows.Forms.TextBox txtTPXPassword;
      private System.Windows.Forms.Label lblPassword;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnOK;
   }
}