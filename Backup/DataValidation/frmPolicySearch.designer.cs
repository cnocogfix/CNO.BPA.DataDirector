namespace CNO.BPA.DataValidation
{
    partial class frmPolicySearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPolicySearch));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPolicyAgent = new System.Windows.Forms.TextBox();
            this.lblPolicyAgent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.fraNarrowSearch = new System.Windows.Forms.GroupBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtNameType = new System.Windows.Forms.TextBox();
            this.lblNameType = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtSystem = new System.Windows.Forms.TextBox();
            this.lblSystem = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.WorkCategoryGrp = new System.Windows.Forms.GroupBox();
            this.lblWorkCategory = new System.Windows.Forms.Label();
            this.lblSiteID = new System.Windows.Forms.Label();
            this.siteIDList = new System.Windows.Forms.ComboBox();
            this.workCategoryList = new System.Windows.Forms.ComboBox();
            this.gbSearchType = new System.Windows.Forms.GroupBox();
            this.txtSearchType = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.fraNarrowSearch.SuspendLayout();
            this.WorkCategoryGrp.SuspendLayout();
            this.gbSearchType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(92, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(137, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(137, 153);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(161, 20);
            this.txtBirthDate.TabIndex = 6;
            this.txtBirthDate.TextChanged += new System.EventHandler(this.txtBirthDate_TextChanged);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(4, 156);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(131, 13);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Birth (MM/DD/YYYY):";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(137, 49);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(161, 20);
            this.txtSSN.TabIndex = 2;
            this.txtSSN.TextChanged += new System.EventHandler(this.txtSSN_TextChanged);
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(99, 52);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(36, 13);
            this.lblSSN.TabIndex = 4;
            this.lblSSN.Text = "SSN:";
            this.lblSSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(137, 127);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(161, 20);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(88, 130);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPolicyAgent
            // 
            this.txtPolicyAgent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPolicyAgent.Location = new System.Drawing.Point(137, 23);
            this.txtPolicyAgent.Name = "txtPolicyAgent";
            this.txtPolicyAgent.Size = new System.Drawing.Size(161, 20);
            this.txtPolicyAgent.TabIndex = 1;
            this.txtPolicyAgent.TextChanged += new System.EventHandler(this.txtPolicyAgent_TextChanged);
            // 
            // lblPolicyAgent
            // 
            this.lblPolicyAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPolicyAgent.AutoSize = true;
            this.lblPolicyAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicyAgent.Location = new System.Drawing.Point(102, 26);
            this.lblPolicyAgent.Name = "lblPolicyAgent";
            this.lblPolicyAgent.Size = new System.Drawing.Size(24, 13);
            this.lblPolicyAgent.TabIndex = 8;
            this.lblPolicyAgent.Text = "ID:";
            this.lblPolicyAgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtZip);
            this.groupBox1.Controls.Add(this.lblZip);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtSSN);
            this.groupBox1.Controls.Add(this.txtPolicyAgent);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblSSN);
            this.groupBox1.Controls.Add(this.txtBirthDate);
            this.groupBox1.Controls.Add(this.lblBirthDate);
            this.groupBox1.Controls.Add(this.lblPolicyAgent);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 192);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Search";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(136, 101);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(161, 20);
            this.txtZip.TabIndex = 4;
            this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(72, 104);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(62, 13);
            this.lblZip.TabIndex = 9;
            this.lblZip.Text = "Zip Code:";
            this.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fraNarrowSearch
            // 
            this.fraNarrowSearch.Controls.Add(this.txtCompany);
            this.fraNarrowSearch.Controls.Add(this.lblCompany);
            this.fraNarrowSearch.Controls.Add(this.txtNameType);
            this.fraNarrowSearch.Controls.Add(this.lblNameType);
            this.fraNarrowSearch.Controls.Add(this.txtProduct);
            this.fraNarrowSearch.Controls.Add(this.lblProduct);
            this.fraNarrowSearch.Controls.Add(this.txtState);
            this.fraNarrowSearch.Controls.Add(this.lblState);
            this.fraNarrowSearch.Controls.Add(this.txtSystem);
            this.fraNarrowSearch.Controls.Add(this.lblSystem);
            this.fraNarrowSearch.Location = new System.Drawing.Point(7, 205);
            this.fraNarrowSearch.Name = "fraNarrowSearch";
            this.fraNarrowSearch.Size = new System.Drawing.Size(305, 164);
            this.fraNarrowSearch.TabIndex = 11;
            this.fraNarrowSearch.TabStop = false;
            this.fraNarrowSearch.Text = "Narrow the Search";
            // 
            // txtCompany
            // 
            this.txtCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompany.Location = new System.Drawing.Point(135, 51);
            this.txtCompany.MaxLength = 3;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(161, 20);
            this.txtCompany.TabIndex = 8;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(71, 54);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(62, 13);
            this.lblCompany.TabIndex = 18;
            this.lblCompany.Text = "Company:";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNameType
            // 
            this.txtNameType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNameType.Location = new System.Drawing.Point(135, 77);
            this.txtNameType.MaxLength = 1;
            this.txtNameType.Name = "txtNameType";
            this.txtNameType.Size = new System.Drawing.Size(161, 20);
            this.txtNameType.TabIndex = 9;
            // 
            // lblNameType
            // 
            this.lblNameType.AutoSize = true;
            this.lblNameType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameType.Location = new System.Drawing.Point(58, 80);
            this.lblNameType.Name = "lblNameType";
            this.lblNameType.Size = new System.Drawing.Size(75, 13);
            this.lblNameType.TabIndex = 16;
            this.lblNameType.Text = "Name Type:";
            this.lblNameType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProduct
            // 
            this.txtProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduct.Location = new System.Drawing.Point(135, 103);
            this.txtProduct.MaxLength = 1;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(161, 20);
            this.txtProduct.TabIndex = 10;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(78, 106);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(55, 13);
            this.lblProduct.TabIndex = 14;
            this.lblProduct.Text = "Product:";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtState
            // 
            this.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtState.Location = new System.Drawing.Point(135, 129);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(161, 20);
            this.txtState.TabIndex = 11;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(92, 132);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 13);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "State:";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSystem
            // 
            this.txtSystem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSystem.Location = new System.Drawing.Point(135, 25);
            this.txtSystem.MaxLength = 3;
            this.txtSystem.Name = "txtSystem";
            this.txtSystem.Size = new System.Drawing.Size(161, 20);
            this.txtSystem.TabIndex = 7;
            this.txtSystem.TextChanged += new System.EventHandler(this.txtSystem_TextChanged);
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.Location = new System.Drawing.Point(82, 28);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(51, 13);
            this.lblSystem.TabIndex = 10;
            this.lblSystem.Text = "System:";
            this.lblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(318, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 28);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(318, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(318, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // WorkCategoryGrp
            // 
            this.WorkCategoryGrp.Controls.Add(this.lblWorkCategory);
            this.WorkCategoryGrp.Controls.Add(this.lblSiteID);
            this.WorkCategoryGrp.Controls.Add(this.siteIDList);
            this.WorkCategoryGrp.Controls.Add(this.workCategoryList);
            this.WorkCategoryGrp.Location = new System.Drawing.Point(318, 205);
            this.WorkCategoryGrp.Name = "WorkCategoryGrp";
            this.WorkCategoryGrp.Size = new System.Drawing.Size(151, 164);
            this.WorkCategoryGrp.TabIndex = 15;
            this.WorkCategoryGrp.TabStop = false;
            this.WorkCategoryGrp.Text = "Bridge";
            // 
            // lblWorkCategory
            // 
            this.lblWorkCategory.AutoSize = true;
            this.lblWorkCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkCategory.Location = new System.Drawing.Point(6, 84);
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
            this.lblSiteID.Location = new System.Drawing.Point(6, 31);
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
            this.siteIDList.Location = new System.Drawing.Point(9, 49);
            this.siteIDList.Name = "siteIDList";
            this.siteIDList.Size = new System.Drawing.Size(135, 21);
            this.siteIDList.TabIndex = 19;
            this.siteIDList.SelectedIndexChanged += new System.EventHandler(this.siteIDList_SelectedIndexChanged);
            // 
            // workCategoryList
            // 
            this.workCategoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workCategoryList.FormattingEnabled = true;
            this.workCategoryList.Location = new System.Drawing.Point(9, 101);
            this.workCategoryList.Name = "workCategoryList";
            this.workCategoryList.Size = new System.Drawing.Size(135, 21);
            this.workCategoryList.TabIndex = 16;
            this.workCategoryList.SelectedIndexChanged += new System.EventHandler(this.workCategoryList_SelectedIndexChanged);
            // 
            // gbSearchType
            // 
            this.gbSearchType.Controls.Add(this.txtSearchType);
            this.gbSearchType.Location = new System.Drawing.Point(318, 126);
            this.gbSearchType.Name = "gbSearchType";
            this.gbSearchType.Size = new System.Drawing.Size(151, 54);
            this.gbSearchType.TabIndex = 16;
            this.gbSearchType.TabStop = false;
            this.gbSearchType.Text = "Search Type";
            // 
            // txtSearchType
            // 
            this.txtSearchType.Location = new System.Drawing.Point(9, 20);
            this.txtSearchType.Name = "txtSearchType";
            this.txtSearchType.Size = new System.Drawing.Size(135, 20);
            this.txtSearchType.TabIndex = 0;
            // 
            // frmPolicySearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 387);
            this.Controls.Add(this.gbSearchType);
            this.Controls.Add(this.WorkCategoryGrp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.fraNarrowSearch);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPolicySearch";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frmPolicySearch_Load);
            this.Shown += new System.EventHandler(this.frmPolicySearch_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPolicySearch_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fraNarrowSearch.ResumeLayout(false);
            this.fraNarrowSearch.PerformLayout();
            this.WorkCategoryGrp.ResumeLayout(false);
            this.WorkCategoryGrp.PerformLayout();
            this.gbSearchType.ResumeLayout(false);
            this.gbSearchType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPolicyAgent;
        private System.Windows.Forms.Label lblPolicyAgent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox fraNarrowSearch;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtNameType;
        private System.Windows.Forms.Label lblNameType;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtSystem;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
       private System.Windows.Forms.Button btnCancel;
       private System.Windows.Forms.TextBox txtZip;
       private System.Windows.Forms.Label lblZip;
       private System.Windows.Forms.GroupBox WorkCategoryGrp;
       private System.Windows.Forms.ComboBox workCategoryList;
       private System.Windows.Forms.ComboBox siteIDList;
       private System.Windows.Forms.Label lblWorkCategory;
       private System.Windows.Forms.Label lblSiteID;
       private System.Windows.Forms.GroupBox gbSearchType;
       private System.Windows.Forms.TextBox txtSearchType;
    }
}