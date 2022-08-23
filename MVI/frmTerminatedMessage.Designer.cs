namespace CNO.BPA.MVI
{
    partial class frmTerminatedMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerminatedMessage));
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTerminatedPolicy = new System.Windows.Forms.Label();
            this.pbTerminated = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTerminated)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(231, 56);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(56, 21);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblTerminatedPolicy
            // 
            this.lblTerminatedPolicy.Location = new System.Drawing.Point(178, 18);
            this.lblTerminatedPolicy.Name = "lblTerminatedPolicy";
            this.lblTerminatedPolicy.Size = new System.Drawing.Size(183, 33);
            this.lblTerminatedPolicy.TabIndex = 4;
            this.lblTerminatedPolicy.Text = "The selected policy is terminated.";
            this.lblTerminatedPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbTerminated
            // 
            this.pbTerminated.Image = global::CNO.BPA.MVI.Properties.Resources.TerminatedImage;
            this.pbTerminated.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbTerminated.InitialImage")));
            this.pbTerminated.Location = new System.Drawing.Point(13, 18);
            this.pbTerminated.Name = "pbTerminated";
            this.pbTerminated.Size = new System.Drawing.Size(158, 59);
            this.pbTerminated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTerminated.TabIndex = 6;
            this.pbTerminated.TabStop = false;
            // 
            // frmTerminatedMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 96);
            this.Controls.Add(this.pbTerminated);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblTerminatedPolicy);
            this.Name = "frmTerminatedMessage";
            this.Text = "Policy Terminated";
            ((System.ComponentModel.ISupportInitialize)(this.pbTerminated)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTerminatedPolicy;
        private System.Windows.Forms.PictureBox pbTerminated;
    }
}