namespace MySVNClient
{
    partial class frmCheckout
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
            this.lblRepoURI = new System.Windows.Forms.Label();
            this.lblLocalPath = new System.Windows.Forms.Label();
            this.lblRevision = new System.Windows.Forms.Label();
            this.tbRepoURI = new System.Windows.Forms.TextBox();
            this.tbLocalPath = new System.Windows.Forms.TextBox();
            this.tbRevision = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRepoURI
            // 
            this.lblRepoURI.AutoSize = true;
            this.lblRepoURI.Location = new System.Drawing.Point(22, 22);
            this.lblRepoURI.Name = "lblRepoURI";
            this.lblRepoURI.Size = new System.Drawing.Size(103, 17);
            this.lblRepoURI.TabIndex = 0;
            this.lblRepoURI.Text = "Repository URI";
            // 
            // lblLocalPath
            // 
            this.lblLocalPath.AutoSize = true;
            this.lblLocalPath.Location = new System.Drawing.Point(22, 57);
            this.lblLocalPath.Name = "lblLocalPath";
            this.lblLocalPath.Size = new System.Drawing.Size(75, 17);
            this.lblLocalPath.TabIndex = 1;
            this.lblLocalPath.Text = "Local Path";
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Location = new System.Drawing.Point(22, 89);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(62, 17);
            this.lblRevision.TabIndex = 2;
            this.lblRevision.Text = "Revision";
            // 
            // tbRepoURI
            // 
            this.tbRepoURI.Location = new System.Drawing.Point(149, 22);
            this.tbRepoURI.Name = "tbRepoURI";
            this.tbRepoURI.Size = new System.Drawing.Size(281, 22);
            this.tbRepoURI.TabIndex = 3;
            // 
            // tbLocalPath
            // 
            this.tbLocalPath.Location = new System.Drawing.Point(149, 54);
            this.tbLocalPath.Name = "tbLocalPath";
            this.tbLocalPath.Size = new System.Drawing.Size(281, 22);
            this.tbLocalPath.TabIndex = 4;
            // 
            // tbRevision
            // 
            this.tbRevision.Location = new System.Drawing.Point(149, 84);
            this.tbRevision.Name = "tbRevision";
            this.tbRevision.Size = new System.Drawing.Size(281, 22);
            this.tbRevision.TabIndex = 5;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(190, 124);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(285, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(472, 175);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.tbRevision);
            this.Controls.Add(this.tbLocalPath);
            this.Controls.Add(this.tbRepoURI);
            this.Controls.Add(this.lblRevision);
            this.Controls.Add(this.lblLocalPath);
            this.Controls.Add(this.lblRepoURI);
            this.Name = "frmCheckout";
            this.Text = "svn checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepoURI;
        private System.Windows.Forms.Label lblLocalPath;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.TextBox tbRepoURI;
        private System.Windows.Forms.TextBox tbLocalPath;
        private System.Windows.Forms.TextBox tbRevision;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCancel;
    }
}