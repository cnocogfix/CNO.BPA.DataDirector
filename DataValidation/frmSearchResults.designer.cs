namespace CNO.BPA.DataValidation
{
    partial class frmSearchResults
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchResults));
            this.trvResults = new System.Windows.Forms.TreeView();
            this.imlResults = new System.Windows.Forms.ImageList(this.components);
            this.txtPolicyAgent = new System.Windows.Forms.TextBox();
            this.lblPolicyAgent = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtNameType = new System.Windows.Forms.TextBox();
            this.lblNameType = new System.Windows.Forms.Label();
            this.txtLOB = new System.Windows.Forms.TextBox();
            this.lblLOB = new System.Windows.Forms.Label();
            this.txtSystem = new System.Windows.Forms.TextBox();
            this.lblSystem = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAreaCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGetMoreResults = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblCurrentRecord = new System.Windows.Forms.Label();
            this.btnSearchAgain = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.qSearchResults1 = new CNO.BPA.DataValidation.QSearchRslts();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtRelationship = new System.Windows.Forms.TextBox();
            this.lblRelationship = new System.Windows.Forms.Label();
            this.txtAddress4 = new System.Windows.Forms.TextBox();
            this.lblAddress4 = new System.Windows.Forms.Label();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.lblAddress3 = new System.Windows.Forms.Label();
            this.txtIssueState = new System.Windows.Forms.TextBox();
            this.lblIssueState = new System.Windows.Forms.Label();
            this.txtGroupNumber = new System.Windows.Forms.TextBox();
            this.lblGroupNumber = new System.Windows.Forms.Label();
            this.txtStatusReason = new System.Windows.Forms.TextBox();
            this.lblStatusReason = new System.Windows.Forms.Label();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.txtPlanCode = new System.Windows.Forms.TextBox();
            this.lblPlanCode = new System.Windows.Forms.Label();
            this.txtTerminatedDate = new System.Windows.Forms.TextBox();
            this.lblTerminatedDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qSearchResults1)).BeginInit();
            this.SuspendLayout();
            // 
            // trvResults
            // 
            this.trvResults.ImageIndex = 0;
            this.trvResults.ImageList = this.imlResults;
            this.trvResults.Location = new System.Drawing.Point(13, 30);
            this.trvResults.Name = "trvResults";
            this.trvResults.SelectedImageIndex = 0;
            this.trvResults.Size = new System.Drawing.Size(201, 294);
            this.trvResults.TabIndex = 0;
            this.trvResults.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvResults_AfterSelect);
            // 
            // imlResults
            // 
            this.imlResults.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlResults.ImageStream")));
            this.imlResults.TransparentColor = System.Drawing.Color.Transparent;
            this.imlResults.Images.SetKeyName(0, "user.ico");
            // 
            // txtPolicyAgent
            // 
            this.txtPolicyAgent.Location = new System.Drawing.Point(222, 30);
            this.txtPolicyAgent.Name = "txtPolicyAgent";
            this.txtPolicyAgent.Size = new System.Drawing.Size(153, 20);
            this.txtPolicyAgent.TabIndex = 12;
            this.txtPolicyAgent.TabStop = false;
            // 
            // lblPolicyAgent
            // 
            this.lblPolicyAgent.AutoSize = true;
            this.lblPolicyAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicyAgent.Location = new System.Drawing.Point(219, 14);
            this.lblPolicyAgent.Name = "lblPolicyAgent";
            this.lblPolicyAgent.Size = new System.Drawing.Size(111, 13);
            this.lblPolicyAgent.TabIndex = 18;
            this.lblPolicyAgent.Text = "Policy/Agent Number:";
            this.lblPolicyAgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(499, 147);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(98, 20);
            this.txtPhone.TabIndex = 13;
            this.txtPhone.TabStop = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(496, 131);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(436, 69);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(161, 20);
            this.txtSSN.TabIndex = 15;
            this.txtSSN.TabStop = false;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(433, 53);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(32, 13);
            this.lblSSN.TabIndex = 14;
            this.lblSSN.Text = "SSN:";
            this.lblSSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(436, 108);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(161, 20);
            this.txtBirthDate.TabIndex = 16;
            this.txtBirthDate.TabStop = false;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(433, 92);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(108, 13);
            this.lblBirthDate.TabIndex = 11;
            this.lblBirthDate.Text = "Birth (MM DD YYYY):";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(222, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 10;
            this.txtName.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(219, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(428, 30);
            this.txtCompany.MaxLength = 3;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(51, 20);
            this.txtCompany.TabIndex = 20;
            this.txtCompany.TabStop = false;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(425, 14);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(54, 13);
            this.lblCompany.TabIndex = 28;
            this.lblCompany.Text = "Company:";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNameType
            // 
            this.txtNameType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameType.Location = new System.Drawing.Point(535, 30);
            this.txtNameType.MaxLength = 1;
            this.txtNameType.Name = "txtNameType";
            this.txtNameType.Size = new System.Drawing.Size(62, 20);
            this.txtNameType.TabIndex = 21;
            this.txtNameType.TabStop = false;
            // 
            // lblNameType
            // 
            this.lblNameType.AutoSize = true;
            this.lblNameType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameType.Location = new System.Drawing.Point(532, 14);
            this.lblNameType.Name = "lblNameType";
            this.lblNameType.Size = new System.Drawing.Size(65, 13);
            this.lblNameType.TabIndex = 27;
            this.lblNameType.Text = "Name Type:";
            this.lblNameType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLOB
            // 
            this.txtLOB.Location = new System.Drawing.Point(485, 30);
            this.txtLOB.MaxLength = 1;
            this.txtLOB.Name = "txtLOB";
            this.txtLOB.Size = new System.Drawing.Size(44, 20);
            this.txtLOB.TabIndex = 22;
            this.txtLOB.TabStop = false;
            // 
            // lblLOB
            // 
            this.lblLOB.AutoSize = true;
            this.lblLOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOB.Location = new System.Drawing.Point(482, 14);
            this.lblLOB.Name = "lblLOB";
            this.lblLOB.Size = new System.Drawing.Size(31, 13);
            this.lblLOB.TabIndex = 26;
            this.lblLOB.Text = "LOB:";
            this.lblLOB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSystem
            // 
            this.txtSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSystem.Location = new System.Drawing.Point(381, 30);
            this.txtSystem.MaxLength = 3;
            this.txtSystem.Name = "txtSystem";
            this.txtSystem.Size = new System.Drawing.Size(41, 20);
            this.txtSystem.TabIndex = 19;
            this.txtSystem.TabStop = false;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.Location = new System.Drawing.Point(378, 14);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(44, 13);
            this.lblSystem.TabIndex = 24;
            this.lblSystem.Text = "System:";
            this.lblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(222, 108);
            this.txtAddress1.MaxLength = 3;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(208, 20);
            this.txtAddress1.TabIndex = 29;
            this.txtAddress1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Address 1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(222, 147);
            this.txtAddress2.MaxLength = 3;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(208, 20);
            this.txtAddress2.TabIndex = 31;
            this.txtAddress2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Address 2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(222, 265);
            this.txtCity.MaxLength = 3;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(93, 20);
            this.txtCity.TabIndex = 33;
            this.txtCity.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "City:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(321, 265);
            this.txtState.MaxLength = 3;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(32, 20);
            this.txtState.TabIndex = 35;
            this.txtState.TabStop = false;
            this.txtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "State:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(359, 265);
            this.txtZip.MaxLength = 3;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(71, 20);
            this.txtZip.TabIndex = 37;
            this.txtZip.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Zip:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAreaCode
            // 
            this.txtAreaCode.Location = new System.Drawing.Point(436, 147);
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.Size = new System.Drawing.Size(57, 20);
            this.txtAreaCode.TabIndex = 39;
            this.txtAreaCode.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Area Code:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGetMoreResults
            // 
            this.btnGetMoreResults.Location = new System.Drawing.Point(24, 337);
            this.btnGetMoreResults.Name = "btnGetMoreResults";
            this.btnGetMoreResults.Size = new System.Drawing.Size(180, 19);
            this.btnGetMoreResults.TabIndex = 3;
            this.btnGetMoreResults.Text = "Get more Results";
            this.btnGetMoreResults.UseVisualStyleBackColor = true;
            this.btnGetMoreResults.Click += new System.EventHandler(this.btnGetMoreResults_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(12, 13);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(45, 13);
            this.lblResults.TabIndex = 42;
            this.lblResults.Text = "Record:";
            // 
            // lblCurrentRecord
            // 
            this.lblCurrentRecord.Location = new System.Drawing.Point(57, 13);
            this.lblCurrentRecord.Name = "lblCurrentRecord";
            this.lblCurrentRecord.Size = new System.Drawing.Size(33, 13);
            this.lblCurrentRecord.TabIndex = 43;
            this.lblCurrentRecord.Text = "1";
            this.lblCurrentRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearchAgain
            // 
            this.btnSearchAgain.Location = new System.Drawing.Point(24, 360);
            this.btnSearchAgain.Name = "btnSearchAgain";
            this.btnSearchAgain.Size = new System.Drawing.Size(179, 19);
            this.btnSearchAgain.TabIndex = 4;
            this.btnSearchAgain.Text = "Search Again";
            this.btnSearchAgain.UseVisualStyleBackColor = true;
            this.btnSearchAgain.Click += new System.EventHandler(this.btnSearchAgain_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(519, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(438, 356);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(436, 187);
            this.txtStatus.MaxLength = 1;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(62, 20);
            this.txtStatus.TabIndex = 47;
            this.txtStatus.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(433, 171);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 48;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qSearchResults1
            // 
            this.qSearchResults1.DataSetName = "QSearchRslts";
            this.qSearchResults1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "of";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(109, 13);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(13, 13);
            this.lblTotalRecords.TabIndex = 50;
            this.lblTotalRecords.Text = "1";
            this.lblTotalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(436, 265);
            this.txtProduct.MaxLength = 1;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(62, 20);
            this.txtProduct.TabIndex = 51;
            this.txtProduct.TabStop = false;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(433, 249);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(47, 13);
            this.lblProduct.TabIndex = 52;
            this.lblProduct.Text = "Product:";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRelationship
            // 
            this.txtRelationship.Location = new System.Drawing.Point(505, 265);
            this.txtRelationship.MaxLength = 3;
            this.txtRelationship.Name = "txtRelationship";
            this.txtRelationship.Size = new System.Drawing.Size(92, 20);
            this.txtRelationship.TabIndex = 55;
            this.txtRelationship.TabStop = false;
            // 
            // lblRelationship
            // 
            this.lblRelationship.AutoSize = true;
            this.lblRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelationship.Location = new System.Drawing.Point(502, 249);
            this.lblRelationship.Name = "lblRelationship";
            this.lblRelationship.Size = new System.Drawing.Size(68, 13);
            this.lblRelationship.TabIndex = 56;
            this.lblRelationship.Text = "Relationship:";
            this.lblRelationship.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress4
            // 
            this.txtAddress4.Location = new System.Drawing.Point(222, 226);
            this.txtAddress4.MaxLength = 3;
            this.txtAddress4.Name = "txtAddress4";
            this.txtAddress4.Size = new System.Drawing.Size(208, 20);
            this.txtAddress4.TabIndex = 59;
            this.txtAddress4.TabStop = false;
            // 
            // lblAddress4
            // 
            this.lblAddress4.AutoSize = true;
            this.lblAddress4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress4.Location = new System.Drawing.Point(219, 210);
            this.lblAddress4.Name = "lblAddress4";
            this.lblAddress4.Size = new System.Drawing.Size(57, 13);
            this.lblAddress4.TabIndex = 60;
            this.lblAddress4.Text = "Address 4:";
            this.lblAddress4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(222, 187);
            this.txtAddress3.MaxLength = 3;
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(208, 20);
            this.txtAddress3.TabIndex = 57;
            this.txtAddress3.TabStop = false;
            // 
            // lblAddress3
            // 
            this.lblAddress3.AutoSize = true;
            this.lblAddress3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress3.Location = new System.Drawing.Point(219, 171);
            this.lblAddress3.Name = "lblAddress3";
            this.lblAddress3.Size = new System.Drawing.Size(57, 13);
            this.lblAddress3.TabIndex = 58;
            this.lblAddress3.Text = "Address 3:";
            this.lblAddress3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIssueState
            // 
            this.txtIssueState.Location = new System.Drawing.Point(436, 226);
            this.txtIssueState.MaxLength = 3;
            this.txtIssueState.Name = "txtIssueState";
            this.txtIssueState.Size = new System.Drawing.Size(62, 20);
            this.txtIssueState.TabIndex = 61;
            this.txtIssueState.TabStop = false;
            // 
            // lblIssueState
            // 
            this.lblIssueState.AutoSize = true;
            this.lblIssueState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueState.Location = new System.Drawing.Point(433, 210);
            this.lblIssueState.Name = "lblIssueState";
            this.lblIssueState.Size = new System.Drawing.Size(63, 13);
            this.lblIssueState.TabIndex = 62;
            this.lblIssueState.Text = "Issue State:";
            this.lblIssueState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGroupNumber
            // 
            this.txtGroupNumber.Location = new System.Drawing.Point(222, 304);
            this.txtGroupNumber.MaxLength = 3;
            this.txtGroupNumber.Name = "txtGroupNumber";
            this.txtGroupNumber.Size = new System.Drawing.Size(101, 20);
            this.txtGroupNumber.TabIndex = 63;
            this.txtGroupNumber.TabStop = false;
            // 
            // lblGroupNumber
            // 
            this.lblGroupNumber.AutoSize = true;
            this.lblGroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupNumber.Location = new System.Drawing.Point(219, 288);
            this.lblGroupNumber.Name = "lblGroupNumber";
            this.lblGroupNumber.Size = new System.Drawing.Size(79, 13);
            this.lblGroupNumber.TabIndex = 64;
            this.lblGroupNumber.Text = "Group Number:";
            this.lblGroupNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStatusReason
            // 
            this.txtStatusReason.Location = new System.Drawing.Point(504, 187);
            this.txtStatusReason.MaxLength = 3;
            this.txtStatusReason.Name = "txtStatusReason";
            this.txtStatusReason.Size = new System.Drawing.Size(93, 20);
            this.txtStatusReason.TabIndex = 65;
            this.txtStatusReason.TabStop = false;
            // 
            // lblStatusReason
            // 
            this.lblStatusReason.AutoSize = true;
            this.lblStatusReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusReason.Location = new System.Drawing.Point(500, 171);
            this.lblStatusReason.Name = "lblStatusReason";
            this.lblStatusReason.Size = new System.Drawing.Size(80, 13);
            this.lblStatusReason.TabIndex = 66;
            this.lblStatusReason.Text = "Status Reason:";
            this.lblStatusReason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.Location = new System.Drawing.Point(504, 226);
            this.txtIssueDate.MaxLength = 3;
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Size = new System.Drawing.Size(93, 20);
            this.txtIssueDate.TabIndex = 67;
            this.txtIssueDate.TabStop = false;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(502, 210);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(61, 13);
            this.lblIssueDate.TabIndex = 68;
            this.lblIssueDate.Text = "Issue Date:";
            this.lblIssueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPlanCode
            // 
            this.txtPlanCode.Location = new System.Drawing.Point(436, 304);
            this.txtPlanCode.MaxLength = 3;
            this.txtPlanCode.Name = "txtPlanCode";
            this.txtPlanCode.Size = new System.Drawing.Size(161, 20);
            this.txtPlanCode.TabIndex = 69;
            this.txtPlanCode.TabStop = false;
            // 
            // lblPlanCode
            // 
            this.lblPlanCode.AutoSize = true;
            this.lblPlanCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanCode.Location = new System.Drawing.Point(433, 288);
            this.lblPlanCode.Name = "lblPlanCode";
            this.lblPlanCode.Size = new System.Drawing.Size(59, 13);
            this.lblPlanCode.TabIndex = 70;
            this.lblPlanCode.Text = "Plan Code:";
            this.lblPlanCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTerminatedDate
            // 
            this.txtTerminatedDate.Location = new System.Drawing.Point(330, 304);
            this.txtTerminatedDate.MaxLength = 3;
            this.txtTerminatedDate.Name = "txtTerminatedDate";
            this.txtTerminatedDate.Size = new System.Drawing.Size(100, 20);
            this.txtTerminatedDate.TabIndex = 71;
            this.txtTerminatedDate.TabStop = false;
            // 
            // lblTerminatedDate
            // 
            this.lblTerminatedDate.AutoSize = true;
            this.lblTerminatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminatedDate.Location = new System.Drawing.Point(327, 288);
            this.lblTerminatedDate.Name = "lblTerminatedDate";
            this.lblTerminatedDate.Size = new System.Drawing.Size(89, 13);
            this.lblTerminatedDate.TabIndex = 72;
            this.lblTerminatedDate.Text = "Terminated Date:";
            this.lblTerminatedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 395);
            this.Controls.Add(this.txtTerminatedDate);
            this.Controls.Add(this.lblTerminatedDate);
            this.Controls.Add(this.txtPlanCode);
            this.Controls.Add(this.lblPlanCode);
            this.Controls.Add(this.txtIssueDate);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.txtStatusReason);
            this.Controls.Add(this.lblStatusReason);
            this.Controls.Add(this.txtGroupNumber);
            this.Controls.Add(this.lblGroupNumber);
            this.Controls.Add(this.txtIssueState);
            this.Controls.Add(this.lblIssueState);
            this.Controls.Add(this.txtAddress4);
            this.Controls.Add(this.lblAddress4);
            this.Controls.Add(this.txtAddress3);
            this.Controls.Add(this.lblAddress3);
            this.Controls.Add(this.txtRelationship);
            this.Controls.Add(this.lblRelationship);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearchAgain);
            this.Controls.Add(this.lblCurrentRecord);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnGetMoreResults);
            this.Controls.Add(this.txtAreaCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtNameType);
            this.Controls.Add(this.lblNameType);
            this.Controls.Add(this.txtLOB);
            this.Controls.Add(this.lblLOB);
            this.Controls.Add(this.txtSystem);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.txtPolicyAgent);
            this.Controls.Add(this.lblPolicyAgent);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.trvResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Results";
            this.Load += new System.EventHandler(this.frmSearchResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qSearchResults1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TreeView trvResults;
       private System.Windows.Forms.ImageList imlResults;
       private System.Windows.Forms.TextBox txtPolicyAgent;
       private System.Windows.Forms.Label lblPolicyAgent;
       private System.Windows.Forms.TextBox txtPhone;
       private System.Windows.Forms.Label lblPhone;
       private System.Windows.Forms.TextBox txtSSN;
       private System.Windows.Forms.Label lblSSN;
       private System.Windows.Forms.TextBox txtBirthDate;
       private System.Windows.Forms.Label lblBirthDate;
       private System.Windows.Forms.TextBox txtName;
       private System.Windows.Forms.Label lblName;
       private System.Windows.Forms.TextBox txtCompany;
       private System.Windows.Forms.Label lblCompany;
       private System.Windows.Forms.TextBox txtNameType;
       private System.Windows.Forms.Label lblNameType;
       private System.Windows.Forms.TextBox txtLOB;
       private System.Windows.Forms.Label lblLOB;
       private System.Windows.Forms.TextBox txtSystem;
       private System.Windows.Forms.Label lblSystem;
       private System.Windows.Forms.TextBox txtAddress1;
       private System.Windows.Forms.Label label1;
       private System.Windows.Forms.TextBox txtAddress2;
       private System.Windows.Forms.Label label2;
       private System.Windows.Forms.TextBox txtCity;
       private System.Windows.Forms.Label label3;
       private System.Windows.Forms.TextBox txtState;
       private System.Windows.Forms.Label label4;
       private System.Windows.Forms.TextBox txtZip;
       private System.Windows.Forms.Label label5;
       private System.Windows.Forms.TextBox txtAreaCode;
       private System.Windows.Forms.Label label6;
       private System.Windows.Forms.Button btnGetMoreResults;
       private System.Windows.Forms.Label lblResults;
       private System.Windows.Forms.Label lblCurrentRecord;
       private System.Windows.Forms.Button btnSearchAgain;
       private System.Windows.Forms.Button btnCancel;
       private System.Windows.Forms.Button btnSelect;
       private System.Windows.Forms.TextBox txtStatus;
       private System.Windows.Forms.Label lblStatus;
       private QSearchRslts qSearchResults1;
       private System.Windows.Forms.Label label7;
       private System.Windows.Forms.Label lblTotalRecords;
       private System.Windows.Forms.TextBox txtProduct;
       private System.Windows.Forms.Label lblProduct;
       private System.Windows.Forms.TextBox txtRelationship;
       private System.Windows.Forms.Label lblRelationship;
       private System.Windows.Forms.TextBox txtAddress4;
       private System.Windows.Forms.Label lblAddress4;
       private System.Windows.Forms.TextBox txtAddress3;
       private System.Windows.Forms.Label lblAddress3;
       private System.Windows.Forms.TextBox txtIssueState;
       private System.Windows.Forms.Label lblIssueState;
       private System.Windows.Forms.TextBox txtGroupNumber;
       private System.Windows.Forms.Label lblGroupNumber;
       private System.Windows.Forms.TextBox txtStatusReason;
       private System.Windows.Forms.Label lblStatusReason;
       private System.Windows.Forms.TextBox txtIssueDate;
       private System.Windows.Forms.Label lblIssueDate;
       private System.Windows.Forms.TextBox txtPlanCode;
       private System.Windows.Forms.Label lblPlanCode;
       private System.Windows.Forms.TextBox txtTerminatedDate;
       private System.Windows.Forms.Label lblTerminatedDate;

    }
}