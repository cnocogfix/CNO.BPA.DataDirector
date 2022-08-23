namespace CNO.BPA.MVI
{
   partial class frmBridge
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBridge));
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.lblWorkCategory = new System.Windows.Forms.Label();
         this.lblSiteID = new System.Windows.Forms.Label();
         this.siteIDList = new System.Windows.Forms.ComboBox();
         this.workCategoryList = new System.Windows.Forms.ComboBox();
         this.btnOK = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.lblWorkCategory);
         this.groupBox1.Controls.Add(this.lblSiteID);
         this.groupBox1.Controls.Add(this.siteIDList);
         this.groupBox1.Controls.Add(this.workCategoryList);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(157, 109);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         // 
         // lblWorkCategory
         // 
         this.lblWorkCategory.AutoSize = true;
         this.lblWorkCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblWorkCategory.Location = new System.Drawing.Point(6, 56);
         this.lblWorkCategory.Name = "lblWorkCategory";
         this.lblWorkCategory.Size = new System.Drawing.Size(81, 13);
         this.lblWorkCategory.TabIndex = 25;
         this.lblWorkCategory.Text = "Work Category:";
         this.lblWorkCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // lblSiteID
         // 
         this.lblSiteID.AutoSize = true;
         this.lblSiteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblSiteID.Location = new System.Drawing.Point(6, 12);
         this.lblSiteID.Name = "lblSiteID";
         this.lblSiteID.Size = new System.Drawing.Size(42, 13);
         this.lblSiteID.TabIndex = 24;
         this.lblSiteID.Text = "Site ID:";
         this.lblSiteID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // siteIDList
         // 
         this.siteIDList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.siteIDList.FormattingEnabled = true;
         this.siteIDList.Location = new System.Drawing.Point(6, 32);
         this.siteIDList.Name = "siteIDList";
         this.siteIDList.Size = new System.Drawing.Size(145, 21);
         this.siteIDList.TabIndex = 23;
         this.siteIDList.SelectedIndexChanged += new System.EventHandler(this.siteIDList_SelectedIndexChanged);
         // 
         // workCategoryList
         // 
         this.workCategoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.workCategoryList.FormattingEnabled = true;
         this.workCategoryList.Location = new System.Drawing.Point(6, 77);
         this.workCategoryList.Name = "workCategoryList";
         this.workCategoryList.Size = new System.Drawing.Size(145, 21);
         this.workCategoryList.TabIndex = 22;
         this.workCategoryList.SelectedIndexChanged += new System.EventHandler(this.workCategoryList_SelectedIndexChanged);
         // 
         // btnOK
         // 
         this.btnOK.Location = new System.Drawing.Point(12, 130);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(75, 28);
         this.btnOK.TabIndex = 3;
         this.btnOK.Text = "OK";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(96, 130);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 28);
         this.btnCancel.TabIndex = 4;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // frmBridge
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(181, 166);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.groupBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "frmBridge";
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "The Bridge";
         this.Load += new System.EventHandler(this.frmBridge_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Label lblWorkCategory;
      private System.Windows.Forms.Label lblSiteID;
      private System.Windows.Forms.ComboBox siteIDList;
      private System.Windows.Forms.ComboBox workCategoryList;
   }
}