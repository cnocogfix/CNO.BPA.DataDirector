namespace CNO.BPA.DataValidation
{
    partial class frmESCSearch
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
            this.lblESCInstructions = new System.Windows.Forms.Label();
            this.btnESCCancel = new System.Windows.Forms.Button();
            this.btnESCSearch = new System.Windows.Forms.Button();
            this.txtHolderNumber = new System.Windows.Forms.TextBox();
            this.lblHolderNumer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblESCInstructions
            // 
            this.lblESCInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblESCInstructions.AutoSize = true;
            this.lblESCInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblESCInstructions.Location = new System.Drawing.Point(17, 9);
            this.lblESCInstructions.Name = "lblESCInstructions";
            this.lblESCInstructions.Size = new System.Drawing.Size(225, 13);
            this.lblESCInstructions.TabIndex = 2;
            this.lblESCInstructions.Text = "Enter Holder Number and click Search";
            this.lblESCInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnESCCancel
            // 
            this.btnESCCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnESCCancel.Location = new System.Drawing.Point(49, 68);
            this.btnESCCancel.Name = "btnESCCancel";
            this.btnESCCancel.Size = new System.Drawing.Size(75, 23);
            this.btnESCCancel.TabIndex = 14;
            this.btnESCCancel.Text = "Cancel";
            this.btnESCCancel.UseVisualStyleBackColor = true;
            this.btnESCCancel.Click += new System.EventHandler(this.btnESCCancel_Click);
            // 
            // btnESCSearch
            // 
            this.btnESCSearch.Location = new System.Drawing.Point(130, 68);
            this.btnESCSearch.Name = "btnESCSearch";
            this.btnESCSearch.Size = new System.Drawing.Size(75, 23);
            this.btnESCSearch.TabIndex = 15;
            this.btnESCSearch.Text = "Search";
            this.btnESCSearch.UseVisualStyleBackColor = true;
            this.btnESCSearch.Click += new System.EventHandler(this.btnESCSearch_Click);
            // 
            // txtHolderNumber
            // 
            this.txtHolderNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHolderNumber.Location = new System.Drawing.Point(129, 35);
            this.txtHolderNumber.Name = "txtHolderNumber";
            this.txtHolderNumber.Size = new System.Drawing.Size(63, 20);
            this.txtHolderNumber.TabIndex = 13;
            // 
            // lblHolderNumer
            // 
            this.lblHolderNumer.AutoSize = true;
            this.lblHolderNumer.Location = new System.Drawing.Point(44, 38);
            this.lblHolderNumer.Name = "lblHolderNumer";
            this.lblHolderNumer.Size = new System.Drawing.Size(81, 13);
            this.lblHolderNumer.TabIndex = 12;
            this.lblHolderNumer.Text = "Holder Number:";
            this.lblHolderNumer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmESCSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 103);
            this.Controls.Add(this.btnESCCancel);
            this.Controls.Add(this.btnESCSearch);
            this.Controls.Add(this.txtHolderNumber);
            this.Controls.Add(this.lblHolderNumer);
            this.Controls.Add(this.lblESCInstructions);
            this.Name = "frmESCSearch";
            this.Text = "ESC Search";
            this.Load += new System.EventHandler(this.frmESCSearch_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmESCSearch_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmESCSearch_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblESCInstructions;
        private System.Windows.Forms.Button btnESCCancel;
        private System.Windows.Forms.Button btnESCSearch;
        private System.Windows.Forms.TextBox txtHolderNumber;
        private System.Windows.Forms.Label lblHolderNumer;
    }
}