namespace CNO.BPA.MVI
{
    partial class frmNBOMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNBOMessage));
            this.btnOk = new System.Windows.Forms.Button();
            this.lblNBO = new System.Windows.Forms.Label();
            this.pbNBO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNBO)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(200, 49);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(56, 21);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblNBO
            // 
            this.lblNBO.Location = new System.Drawing.Point(159, 13);
            this.lblNBO.Name = "lblNBO";
            this.lblNBO.Size = new System.Drawing.Size(151, 33);
            this.lblNBO.TabIndex = 6;
            this.lblNBO.Text = "The selected policy is NBO.";
            this.lblNBO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbNBO
            // 
            this.pbNBO.Image = global::CNO.BPA.MVI.Properties.Resources.NBOMessage;
            this.pbNBO.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbNBO.InitialImage")));
            this.pbNBO.Location = new System.Drawing.Point(9, 14);
            this.pbNBO.Name = "pbNBO";
            this.pbNBO.Size = new System.Drawing.Size(133, 56);
            this.pbNBO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNBO.TabIndex = 9;
            this.pbNBO.TabStop = false;
            // 
            // frmNBOMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 89);
            this.Controls.Add(this.pbNBO);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblNBO);
            this.Name = "frmNBOMessage";
            this.Text = "NBO Policy";
            ((System.ComponentModel.ISupportInitialize)(this.pbNBO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblNBO;
        private System.Windows.Forms.PictureBox pbNBO;
    }
}