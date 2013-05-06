namespace Simulation
{
    partial class Link
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
            this.btadd = new System.Windows.Forms.Button();
            this.tbadd = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.tblink = new System.Windows.Forms.TextBox();
            this.btcancel = new System.Windows.Forms.Button();
            this.lblink = new System.Windows.Forms.Label();
            this.lbdest = new System.Windows.Forms.Label();
            this.tbdest = new System.Windows.Forms.TextBox();
            this.btbrowse = new System.Windows.Forms.Button();
            this.ofdselector = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tbseconds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(193, 188);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 0;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // tbadd
            // 
            this.tbadd.Location = new System.Drawing.Point(139, 115);
            this.tbadd.Name = "tbadd";
            this.tbadd.Size = new System.Drawing.Size(372, 22);
            this.tbadd.TabIndex = 1;
            this.tbadd.Text = "New Construct";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(36, 115);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(45, 17);
            this.lbname.TabIndex = 2;
            this.lbname.Text = "Name";
            // 
            // tblink
            // 
            this.tblink.Location = new System.Drawing.Point(139, 37);
            this.tblink.Name = "tblink";
            this.tblink.Size = new System.Drawing.Size(372, 22);
            this.tblink.TabIndex = 3;
            // 
            // btcancel
            // 
            this.btcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btcancel.Location = new System.Drawing.Point(295, 188);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(75, 23);
            this.btcancel.TabIndex = 4;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            // 
            // lblink
            // 
            this.lblink.AutoSize = true;
            this.lblink.Location = new System.Drawing.Point(36, 37);
            this.lblink.Name = "lblink";
            this.lblink.Size = new System.Drawing.Size(34, 17);
            this.lblink.TabIndex = 5;
            this.lblink.Text = "Link";
            // 
            // lbdest
            // 
            this.lbdest.AutoSize = true;
            this.lbdest.Location = new System.Drawing.Point(36, 76);
            this.lbdest.Name = "lbdest";
            this.lbdest.Size = new System.Drawing.Size(79, 17);
            this.lbdest.TabIndex = 7;
            this.lbdest.Text = "Destination";
            // 
            // tbdest
            // 
            this.tbdest.Location = new System.Drawing.Point(139, 76);
            this.tbdest.Name = "tbdest";
            this.tbdest.Size = new System.Drawing.Size(274, 22);
            this.tbdest.TabIndex = 6;
            this.tbdest.Text = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Github\\codegoogle_thesis_svn\\newc" +
    "onst.txt";
            // 
            // btbrowse
            // 
            this.btbrowse.Location = new System.Drawing.Point(419, 76);
            this.btbrowse.Name = "btbrowse";
            this.btbrowse.Size = new System.Drawing.Size(92, 23);
            this.btbrowse.TabIndex = 17;
            this.btbrowse.Text = "Browse ...";
            this.btbrowse.UseVisualStyleBackColor = true;
            this.btbrowse.Click += new System.EventHandler(this.btbrowse_Click);
            // 
            // ofdselector
            // 
            this.ofdselector.FileName = "openFileDialog1";
            this.ofdselector.InitialDirectory = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Github\\codegoogle_thesis_svn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Interval";
            // 
            // tbseconds
            // 
            this.tbseconds.Location = new System.Drawing.Point(140, 152);
            this.tbseconds.Name = "tbseconds";
            this.tbseconds.Size = new System.Drawing.Size(66, 22);
            this.tbseconds.TabIndex = 18;
            this.tbseconds.Text = "60";
            this.tbseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Seconds";
            // 
            // Link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btcancel;
            this.ClientSize = new System.Drawing.Size(609, 280);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbseconds);
            this.Controls.Add(this.btbrowse);
            this.Controls.Add(this.lbdest);
            this.Controls.Add(this.tbdest);
            this.Controls.Add(this.lblink);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.tblink);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.tbadd);
            this.Controls.Add(this.btadd);
            this.Name = "Link";
            this.Text = "Link";
            this.Load += new System.EventHandler(this.Link_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox tbadd;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tblink;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Label lblink;
        private System.Windows.Forms.Label lbdest;
        private System.Windows.Forms.TextBox tbdest;
        private System.Windows.Forms.Button btbrowse;
        private System.Windows.Forms.OpenFileDialog ofdselector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbseconds;
        private System.Windows.Forms.Label label2;
    }
}