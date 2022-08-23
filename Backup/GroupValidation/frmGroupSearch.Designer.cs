namespace CNO.BPA.GroupValidation
{
    partial class frmGroupSearch
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
            this.lblGroupInstructions = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtMasterGroupNumber = new System.Windows.Forms.TextBox();
            this.lblMasterGroupNumer = new System.Windows.Forms.Label();
            this.txtMasterGroupName = new System.Windows.Forms.TextBox();
            this.lblMasterGroupName = new System.Windows.Forms.Label();
            this.btnGroupCancel = new System.Windows.Forms.Button();
            this.btnGroupSearch = new System.Windows.Forms.Button();
            this.txtGroupNumber = new System.Windows.Forms.TextBox();
            this.lblGroupNumer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGroupInstructions
            // 
            this.lblGroupInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGroupInstructions.AutoSize = true;
            this.lblGroupInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupInstructions.Location = new System.Drawing.Point(28, 9);
            this.lblGroupInstructions.Name = "lblGroupInstructions";
            this.lblGroupInstructions.Size = new System.Drawing.Size(218, 13);
            this.lblGroupInstructions.TabIndex = 1;
            this.lblGroupInstructions.Text = "Enter Group Details and click Search";
            this.lblGroupInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGroupName
            // 
            this.txtGroupName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGroupName.Location = new System.Drawing.Point(135, 73);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(123, 20);
            this.txtGroupName.TabIndex = 5;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(59, 76);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(70, 13);
            this.lblGroupName.TabIndex = 4;
            this.lblGroupName.Text = "Group Name:";
            this.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMasterGroupNumber
            // 
            this.txtMasterGroupNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMasterGroupNumber.Location = new System.Drawing.Point(135, 109);
            this.txtMasterGroupNumber.Name = "txtMasterGroupNumber";
            this.txtMasterGroupNumber.Size = new System.Drawing.Size(123, 20);
            this.txtMasterGroupNumber.TabIndex = 7;
            // 
            // lblMasterGroupNumer
            // 
            this.lblMasterGroupNumer.AutoSize = true;
            this.lblMasterGroupNumer.Location = new System.Drawing.Point(15, 112);
            this.lblMasterGroupNumer.Name = "lblMasterGroupNumer";
            this.lblMasterGroupNumer.Size = new System.Drawing.Size(114, 13);
            this.lblMasterGroupNumer.TabIndex = 6;
            this.lblMasterGroupNumer.Text = "Master Group Number:";
            this.lblMasterGroupNumer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMasterGroupName
            // 
            this.txtMasterGroupName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMasterGroupName.Location = new System.Drawing.Point(135, 145);
            this.txtMasterGroupName.Name = "txtMasterGroupName";
            this.txtMasterGroupName.Size = new System.Drawing.Size(123, 20);
            this.txtMasterGroupName.TabIndex = 9;
            // 
            // lblMasterGroupName
            // 
            this.lblMasterGroupName.AutoSize = true;
            this.lblMasterGroupName.Location = new System.Drawing.Point(24, 148);
            this.lblMasterGroupName.Name = "lblMasterGroupName";
            this.lblMasterGroupName.Size = new System.Drawing.Size(105, 13);
            this.lblMasterGroupName.TabIndex = 8;
            this.lblMasterGroupName.Text = "Master Group Name:";
            this.lblMasterGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGroupCancel
            // 
            this.btnGroupCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGroupCancel.Location = new System.Drawing.Point(56, 177);
            this.btnGroupCancel.Name = "btnGroupCancel";
            this.btnGroupCancel.Size = new System.Drawing.Size(75, 23);
            this.btnGroupCancel.TabIndex = 18;
            this.btnGroupCancel.Text = "Cancel";
            this.btnGroupCancel.UseVisualStyleBackColor = true;
            this.btnGroupCancel.Click += new System.EventHandler(this.btnGroupCancel_Click);
            // 
            // btnGroupSearch
            // 
            this.btnGroupSearch.Location = new System.Drawing.Point(137, 177);
            this.btnGroupSearch.Name = "btnGroupSearch";
            this.btnGroupSearch.Size = new System.Drawing.Size(75, 23);
            this.btnGroupSearch.TabIndex = 19;
            this.btnGroupSearch.Text = "Search";
            this.btnGroupSearch.UseVisualStyleBackColor = true;
            this.btnGroupSearch.Click += new System.EventHandler(this.btnGroupSearch_Click);
            // 
            // txtGroupNumber
            // 
            this.txtGroupNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGroupNumber.Location = new System.Drawing.Point(135, 39);
            this.txtGroupNumber.Name = "txtGroupNumber";
            this.txtGroupNumber.Size = new System.Drawing.Size(123, 20);
            this.txtGroupNumber.TabIndex = 17;
            // 
            // lblGroupNumer
            // 
            this.lblGroupNumer.AutoSize = true;
            this.lblGroupNumer.Location = new System.Drawing.Point(50, 42);
            this.lblGroupNumer.Name = "lblGroupNumer";
            this.lblGroupNumer.Size = new System.Drawing.Size(79, 13);
            this.lblGroupNumer.TabIndex = 16;
            this.lblGroupNumer.Text = "Group Number:";
            this.lblGroupNumer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmGroupSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 210);
            this.Controls.Add(this.btnGroupCancel);
            this.Controls.Add(this.btnGroupSearch);
            this.Controls.Add(this.txtGroupNumber);
            this.Controls.Add(this.lblGroupNumer);
            this.Controls.Add(this.txtMasterGroupName);
            this.Controls.Add(this.lblMasterGroupName);
            this.Controls.Add(this.txtMasterGroupNumber);
            this.Controls.Add(this.lblMasterGroupNumer);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.lblGroupInstructions);
            this.Name = "frmGroupSearch";
            this.Text = "Group Lookup";
            this.Load += new System.EventHandler(this.frmGroupSearch_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGroupSearch_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGroupSearch_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroupInstructions;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtMasterGroupNumber;
        private System.Windows.Forms.Label lblMasterGroupNumer;
        private System.Windows.Forms.TextBox txtMasterGroupName;
        private System.Windows.Forms.Label lblMasterGroupName;
        private System.Windows.Forms.Button btnGroupCancel;
        private System.Windows.Forms.Button btnGroupSearch;
        private System.Windows.Forms.TextBox txtGroupNumber;
        private System.Windows.Forms.Label lblGroupNumer;
    }
}