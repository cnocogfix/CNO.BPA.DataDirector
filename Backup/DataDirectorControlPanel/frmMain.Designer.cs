namespace DataDirectorControlPanel
{
    partial class frmMain
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
           System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
           this.RequiredInfoGrp = new System.Windows.Forms.GroupBox();
           this.lblWorkType = new System.Windows.Forms.Label();
           this.txtWorkType = new System.Windows.Forms.TextBox();
           this.lblBusinessArea = new System.Windows.Forms.Label();
           this.txtBusinessArea = new System.Windows.Forms.TextBox();
           this.groupBox2 = new System.Windows.Forms.GroupBox();
           this.txtZip = new System.Windows.Forms.TextBox();
           this.lblZip = new System.Windows.Forms.Label();
           this.txtPhone = new System.Windows.Forms.TextBox();
           this.lblPhone = new System.Windows.Forms.Label();
           this.txtSSN = new System.Windows.Forms.TextBox();
           this.txtID = new System.Windows.Forms.TextBox();
           this.txtName = new System.Windows.Forms.TextBox();
           this.label2 = new System.Windows.Forms.Label();
           this.label3 = new System.Windows.Forms.Label();
           this.txtBirthDate = new System.Windows.Forms.TextBox();
           this.lblBirthDate = new System.Windows.Forms.Label();
           this.lblPolicyAgent = new System.Windows.Forms.Label();
           this.lblWorkCategory = new System.Windows.Forms.Label();
           this.lblSiteID = new System.Windows.Forms.Label();
           this.siteIDList = new System.Windows.Forms.ComboBox();
           this.workCategoryList = new System.Windows.Forms.ComboBox();
           this.btnLaunchDD = new System.Windows.Forms.Button();
           this.btnAutoValidate = new System.Windows.Forms.Button();
           this.btnALCCC14 = new System.Windows.Forms.Button();
           this.btnValidate = new System.Windows.Forms.Button();
           this.btnPrivacyDetail = new System.Windows.Forms.Button();
           this.btn4086PP = new System.Windows.Forms.Button();
           this.btn4086M = new System.Windows.Forms.Button();
           this.btn4086MAuto = new System.Windows.Forms.Button();
           this.btn4086PPAuto = new System.Windows.Forms.Button();
           this.RequiredInfoGrp.SuspendLayout();
           this.groupBox2.SuspendLayout();
           this.SuspendLayout();
           // 
           // RequiredInfoGrp
           // 
           this.RequiredInfoGrp.Controls.Add(this.lblWorkType);
           this.RequiredInfoGrp.Controls.Add(this.txtWorkType);
           this.RequiredInfoGrp.Controls.Add(this.lblBusinessArea);
           this.RequiredInfoGrp.Controls.Add(this.txtBusinessArea);
           this.RequiredInfoGrp.Controls.Add(this.groupBox2);
           this.RequiredInfoGrp.Controls.Add(this.lblWorkCategory);
           this.RequiredInfoGrp.Controls.Add(this.lblSiteID);
           this.RequiredInfoGrp.Controls.Add(this.siteIDList);
           this.RequiredInfoGrp.Controls.Add(this.workCategoryList);
           this.RequiredInfoGrp.Location = new System.Drawing.Point(12, 12);
           this.RequiredInfoGrp.Name = "RequiredInfoGrp";
           this.RequiredInfoGrp.Size = new System.Drawing.Size(257, 327);
           this.RequiredInfoGrp.TabIndex = 16;
           this.RequiredInfoGrp.TabStop = false;
           this.RequiredInfoGrp.Text = "Information Required to launch the Data Director";
           // 
           // lblWorkType
           // 
           this.lblWorkType.AutoSize = true;
           this.lblWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.lblWorkType.Location = new System.Drawing.Point(32, 295);
           this.lblWorkType.Name = "lblWorkType";
           this.lblWorkType.Size = new System.Drawing.Size(73, 13);
           this.lblWorkType.TabIndex = 28;
           this.lblWorkType.Text = "Work Type:";
           this.lblWorkType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           // 
           // txtWorkType
           // 
           this.txtWorkType.Location = new System.Drawing.Point(111, 292);
           this.txtWorkType.Name = "txtWorkType";
           this.txtWorkType.Size = new System.Drawing.Size(126, 20);
           this.txtWorkType.TabIndex = 27;
           // 
           // lblBusinessArea
           // 
           this.lblBusinessArea.AutoSize = true;
           this.lblBusinessArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.lblBusinessArea.Location = new System.Drawing.Point(14, 269);
           this.lblBusinessArea.Name = "lblBusinessArea";
           this.lblBusinessArea.Size = new System.Drawing.Size(91, 13);
           this.lblBusinessArea.TabIndex = 26;
           this.lblBusinessArea.Text = "Business Area:";
           this.lblBusinessArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           // 
           // txtBusinessArea
           // 
           this.txtBusinessArea.Location = new System.Drawing.Point(111, 266);
           this.txtBusinessArea.Name = "txtBusinessArea";
           this.txtBusinessArea.Size = new System.Drawing.Size(126, 20);
           this.txtBusinessArea.TabIndex = 25;
           // 
           // groupBox2
           // 
           this.groupBox2.Controls.Add(this.txtZip);
           this.groupBox2.Controls.Add(this.lblZip);
           this.groupBox2.Controls.Add(this.txtPhone);
           this.groupBox2.Controls.Add(this.lblPhone);
           this.groupBox2.Controls.Add(this.txtSSN);
           this.groupBox2.Controls.Add(this.txtID);
           this.groupBox2.Controls.Add(this.txtName);
           this.groupBox2.Controls.Add(this.label2);
           this.groupBox2.Controls.Add(this.label3);
           this.groupBox2.Controls.Add(this.txtBirthDate);
           this.groupBox2.Controls.Add(this.lblBirthDate);
           this.groupBox2.Controls.Add(this.lblPolicyAgent);
           this.groupBox2.Location = new System.Drawing.Point(6, 70);
           this.groupBox2.Name = "groupBox2";
           this.groupBox2.Size = new System.Drawing.Size(245, 190);
           this.groupBox2.TabIndex = 24;
           this.groupBox2.TabStop = false;
           this.groupBox2.Text = "By-Pass Search Screen by Sending in Criteria";
           // 
           // txtZip
           // 
           this.txtZip.Location = new System.Drawing.Point(83, 103);
           this.txtZip.Name = "txtZip";
           this.txtZip.Size = new System.Drawing.Size(145, 20);
           this.txtZip.TabIndex = 4;
           // 
           // lblZip
           // 
           this.lblZip.AutoSize = true;
           this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.lblZip.Location = new System.Drawing.Point(19, 106);
           this.lblZip.Name = "lblZip";
           this.lblZip.Size = new System.Drawing.Size(62, 13);
           this.lblZip.TabIndex = 9;
           this.lblZip.Text = "Zip Code:";
           this.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           // 
           // txtPhone
           // 
           this.txtPhone.Location = new System.Drawing.Point(84, 129);
           this.txtPhone.Name = "txtPhone";
           this.txtPhone.Size = new System.Drawing.Size(145, 20);
           this.txtPhone.TabIndex = 5;
           // 
           // lblPhone
           // 
           this.lblPhone.AutoSize = true;
           this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.lblPhone.Location = new System.Drawing.Point(35, 132);
           this.lblPhone.Name = "lblPhone";
           this.lblPhone.Size = new System.Drawing.Size(47, 13);
           this.lblPhone.TabIndex = 6;
           this.lblPhone.Text = "Phone:";
           this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           // 
           // txtSSN
           // 
           this.txtSSN.Location = new System.Drawing.Point(84, 51);
           this.txtSSN.Name = "txtSSN";
           this.txtSSN.Size = new System.Drawing.Size(145, 20);
           this.txtSSN.TabIndex = 2;
           // 
           // txtID
           // 
           this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txtID.Location = new System.Drawing.Point(84, 25);
           this.txtID.Name = "txtID";
           this.txtID.Size = new System.Drawing.Size(145, 20);
           this.txtID.TabIndex = 1;
           // 
           // txtName
           // 
           this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txtName.Location = new System.Drawing.Point(84, 77);
           this.txtName.Name = "txtName";
           this.txtName.Size = new System.Drawing.Size(145, 20);
           this.txtName.TabIndex = 3;
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label2.Location = new System.Drawing.Point(39, 80);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(43, 13);
           this.label2.TabIndex = 0;
           this.label2.Text = "Name:";
           this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label3.Location = new System.Drawing.Point(46, 54);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(36, 13);
           this.label3.TabIndex = 4;
           this.label3.Text = "SSN:";
           this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           // 
           // txtBirthDate
           // 
           this.txtBirthDate.Location = new System.Drawing.Point(84, 155);
           this.txtBirthDate.Name = "txtBirthDate";
           this.txtBirthDate.Size = new System.Drawing.Size(145, 20);
           this.txtBirthDate.TabIndex = 6;
           // 
           // lblBirthDate
           // 
           this.lblBirthDate.AutoSize = true;
           this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.lblBirthDate.Location = new System.Drawing.Point(20, 158);
           this.lblBirthDate.Name = "lblBirthDate";
           this.lblBirthDate.Size = new System.Drawing.Size(62, 13);
           this.lblBirthDate.TabIndex = 2;
           this.lblBirthDate.Text = "Birthdate:";
           this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           // 
           // lblPolicyAgent
           // 
           this.lblPolicyAgent.AutoSize = true;
           this.lblPolicyAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.lblPolicyAgent.Location = new System.Drawing.Point(58, 28);
           this.lblPolicyAgent.Name = "lblPolicyAgent";
           this.lblPolicyAgent.Size = new System.Drawing.Size(24, 13);
           this.lblPolicyAgent.TabIndex = 8;
           this.lblPolicyAgent.Text = "ID:";
           this.lblPolicyAgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           // 
           // lblWorkCategory
           // 
           this.lblWorkCategory.AutoSize = true;
           this.lblWorkCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.lblWorkCategory.Location = new System.Drawing.Point(122, 27);
           this.lblWorkCategory.Name = "lblWorkCategory";
           this.lblWorkCategory.Size = new System.Drawing.Size(81, 13);
           this.lblWorkCategory.TabIndex = 21;
           this.lblWorkCategory.Text = "Work Category:";
           this.lblWorkCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           // 
           // lblSiteID
           // 
           this.lblSiteID.AutoSize = true;
           this.lblSiteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.lblSiteID.Location = new System.Drawing.Point(14, 27);
           this.lblSiteID.Name = "lblSiteID";
           this.lblSiteID.Size = new System.Drawing.Size(42, 13);
           this.lblSiteID.TabIndex = 20;
           this.lblSiteID.Text = "Site ID:";
           this.lblSiteID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
           // 
           // siteIDList
           // 
           this.siteIDList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           this.siteIDList.FormattingEnabled = true;
           this.siteIDList.Location = new System.Drawing.Point(17, 43);
           this.siteIDList.Name = "siteIDList";
           this.siteIDList.Size = new System.Drawing.Size(68, 21);
           this.siteIDList.TabIndex = 19;
           this.siteIDList.SelectedIndexChanged += new System.EventHandler(this.siteIDList_SelectedIndexChanged);
           // 
           // workCategoryList
           // 
           this.workCategoryList.DropDownHeight = 200;
           this.workCategoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           this.workCategoryList.Enabled = false;
           this.workCategoryList.FormattingEnabled = true;
           this.workCategoryList.IntegralHeight = false;
           this.workCategoryList.Location = new System.Drawing.Point(125, 43);
           this.workCategoryList.Name = "workCategoryList";
           this.workCategoryList.Size = new System.Drawing.Size(121, 21);
           this.workCategoryList.TabIndex = 16;
           // 
           // btnLaunchDD
           // 
           this.btnLaunchDD.Location = new System.Drawing.Point(188, 345);
           this.btnLaunchDD.Name = "btnLaunchDD";
           this.btnLaunchDD.Size = new System.Drawing.Size(83, 23);
           this.btnLaunchDD.TabIndex = 17;
           this.btnLaunchDD.Text = "Launch DD";
           this.btnLaunchDD.UseVisualStyleBackColor = true;
           this.btnLaunchDD.Click += new System.EventHandler(this.btnLaunchDD_Click);
           // 
           // btnAutoValidate
           // 
           this.btnAutoValidate.Location = new System.Drawing.Point(91, 345);
           this.btnAutoValidate.Name = "btnAutoValidate";
           this.btnAutoValidate.Size = new System.Drawing.Size(83, 23);
           this.btnAutoValidate.TabIndex = 25;
           this.btnAutoValidate.Text = "Auto Validate";
           this.btnAutoValidate.UseVisualStyleBackColor = true;
           this.btnAutoValidate.Click += new System.EventHandler(this.btnAutoValidate_Click);
           // 
           // btnALCCC14
           // 
           this.btnALCCC14.Location = new System.Drawing.Point(12, 374);
           this.btnALCCC14.Name = "btnALCCC14";
           this.btnALCCC14.Size = new System.Drawing.Size(71, 23);
           this.btnALCCC14.TabIndex = 25;
           this.btnALCCC14.Text = "ALCCC14";
           this.btnALCCC14.UseVisualStyleBackColor = true;
           this.btnALCCC14.Click += new System.EventHandler(this.button1_Click);
           // 
           // btnValidate
           // 
           this.btnValidate.Location = new System.Drawing.Point(91, 374);
           this.btnValidate.Name = "btnValidate";
           this.btnValidate.Size = new System.Drawing.Size(83, 23);
           this.btnValidate.TabIndex = 26;
           this.btnValidate.Text = "Validate";
           this.btnValidate.UseVisualStyleBackColor = true;
           this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
           // 
           // btnPrivacyDetail
           // 
           this.btnPrivacyDetail.Location = new System.Drawing.Point(12, 345);
           this.btnPrivacyDetail.Name = "btnPrivacyDetail";
           this.btnPrivacyDetail.Size = new System.Drawing.Size(70, 23);
           this.btnPrivacyDetail.TabIndex = 27;
           this.btnPrivacyDetail.Text = "PrivacyDetail";
           this.btnPrivacyDetail.UseVisualStyleBackColor = true;
           this.btnPrivacyDetail.Click += new System.EventHandler(this.btnPrivacyDetail_Click);
           // 
           // btn4086PP
           // 
           this.btn4086PP.Location = new System.Drawing.Point(12, 403);
           this.btn4086PP.Name = "btn4086PP";
           this.btn4086PP.Size = new System.Drawing.Size(70, 23);
           this.btn4086PP.TabIndex = 28;
           this.btn4086PP.Text = "4086 PP";
           this.btn4086PP.UseVisualStyleBackColor = true;
           this.btn4086PP.Click += new System.EventHandler(this.btn4086PP_Click);
           // 
           // btn4086M
           // 
           this.btn4086M.Location = new System.Drawing.Point(91, 403);
           this.btn4086M.Name = "btn4086M";
           this.btn4086M.Size = new System.Drawing.Size(83, 23);
           this.btn4086M.TabIndex = 29;
           this.btn4086M.Text = "4086 M";
           this.btn4086M.UseVisualStyleBackColor = true;
           this.btn4086M.Click += new System.EventHandler(this.btn4086M_Click);
           // 
           // btn4086MAuto
           // 
           this.btn4086MAuto.Location = new System.Drawing.Point(188, 403);
           this.btn4086MAuto.Name = "btn4086MAuto";
           this.btn4086MAuto.Size = new System.Drawing.Size(83, 23);
           this.btn4086MAuto.TabIndex = 30;
           this.btn4086MAuto.Text = "4086 M Auto";
           this.btn4086MAuto.UseVisualStyleBackColor = true;
           this.btn4086MAuto.Click += new System.EventHandler(this.btn4086MAuto_Click);
           // 
           // btn4086PPAuto
           // 
           this.btn4086PPAuto.Location = new System.Drawing.Point(188, 374);
           this.btn4086PPAuto.Name = "btn4086PPAuto";
           this.btn4086PPAuto.Size = new System.Drawing.Size(83, 23);
           this.btn4086PPAuto.TabIndex = 31;
           this.btn4086PPAuto.Text = "4086 PP Auto";
           this.btn4086PPAuto.UseVisualStyleBackColor = true;
           this.btn4086PPAuto.Click += new System.EventHandler(this.btn4086PPAuto_Click);
           // 
           // frmMain
           // 
           this.AcceptButton = this.btnLaunchDD;
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(283, 434);
           this.Controls.Add(this.btn4086PPAuto);
           this.Controls.Add(this.btn4086MAuto);
           this.Controls.Add(this.btn4086M);
           this.Controls.Add(this.btn4086PP);
           this.Controls.Add(this.btnPrivacyDetail);
           this.Controls.Add(this.btnValidate);
           this.Controls.Add(this.btnALCCC14);
           this.Controls.Add(this.btnAutoValidate);
           this.Controls.Add(this.btnLaunchDD);
           this.Controls.Add(this.RequiredInfoGrp);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
           this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
           this.MaximizeBox = false;
           this.MinimizeBox = false;
           this.Name = "frmMain";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "Data Director Control Panel";
           this.Load += new System.EventHandler(this.frmMain_Load);
           this.RequiredInfoGrp.ResumeLayout(false);
           this.RequiredInfoGrp.PerformLayout();
           this.groupBox2.ResumeLayout(false);
           this.groupBox2.PerformLayout();
           this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RequiredInfoGrp;
        private System.Windows.Forms.Label lblWorkCategory;
        private System.Windows.Forms.Label lblSiteID;
        private System.Windows.Forms.ComboBox siteIDList;
        private System.Windows.Forms.ComboBox workCategoryList;
        private System.Windows.Forms.Button btnLaunchDD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblPolicyAgent;
        private System.Windows.Forms.Button btnAutoValidate;
        private System.Windows.Forms.Button btnALCCC14;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnPrivacyDetail;
        private System.Windows.Forms.Label lblBusinessArea;
        private System.Windows.Forms.TextBox txtBusinessArea;
        private System.Windows.Forms.Label lblWorkType;
        private System.Windows.Forms.TextBox txtWorkType;
        private System.Windows.Forms.Button btn4086PP;
        private System.Windows.Forms.Button btn4086M;
        private System.Windows.Forms.Button btn4086MAuto;
        private System.Windows.Forms.Button btn4086PPAuto;
    }
}

