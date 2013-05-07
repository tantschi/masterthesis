namespace Simulation
{
    partial class Add
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
            this.btcancel = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.ofdselector = new System.Windows.Forms.OpenFileDialog();
            this.lbdescription = new System.Windows.Forms.Label();
            this.tblocaldest = new System.Windows.Forms.TextBox();
            this.tbdescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btbrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btcancel
            // 
            this.btcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btcancel.Location = new System.Drawing.Point(328, 87);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(86, 23);
            this.btcancel.TabIndex = 23;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(191, 87);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(87, 23);
            this.btadd.TabIndex = 22;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // ofdselector
            // 
            this.ofdselector.FileName = "openFileDialog1";
            // 
            // lbdescription
            // 
            this.lbdescription.AutoSize = true;
            this.lbdescription.Location = new System.Drawing.Point(38, 61);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(79, 17);
            this.lbdescription.TabIndex = 27;
            this.lbdescription.Text = "Description";
            // 
            // tblocaldest
            // 
            this.tblocaldest.Location = new System.Drawing.Point(192, 31);
            this.tblocaldest.Name = "tblocaldest";
            this.tblocaldest.Size = new System.Drawing.Size(274, 22);
            this.tblocaldest.TabIndex = 25;
            this.tblocaldest.Text = "D:\\04_semester\\masterarbeit_hawaii_stuff\\praxis\\github\\codegoogle_thesis_svn\\humi" +
    "dity.txt";
            // 
            // tbdescription
            // 
            this.tbdescription.Location = new System.Drawing.Point(192, 59);
            this.tbdescription.Name = "tbdescription";
            this.tbdescription.Size = new System.Drawing.Size(364, 22);
            this.tbdescription.TabIndex = 28;
            this.tbdescription.Text = "Humidity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Local SVN Destination";
            // 
            // btbrowse
            // 
            this.btbrowse.Location = new System.Drawing.Point(472, 30);
            this.btbrowse.Name = "btbrowse";
            this.btbrowse.Size = new System.Drawing.Size(84, 23);
            this.btbrowse.TabIndex = 26;
            this.btbrowse.Text = "Browse ...";
            this.btbrowse.UseVisualStyleBackColor = true;
            this.btbrowse.Click += new System.EventHandler(this.btbrowse_Click_1);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btcancel;
            this.ClientSize = new System.Drawing.Size(611, 139);
            this.Controls.Add(this.lbdescription);
            this.Controls.Add(this.tblocaldest);
            this.Controls.Add(this.tbdescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbrowse);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btadd);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.OpenFileDialog ofdselector;
        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.TextBox tblocaldest;
        private System.Windows.Forms.TextBox tbdescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbrowse;
    }
}