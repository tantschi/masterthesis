namespace MySVNClient
{
    partial class SvnClient
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
            this.lbfile = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tbfile = new System.Windows.Forms.TextBox();
            this.btadd = new System.Windows.Forms.Button();
            this.tbrepo = new System.Windows.Forms.TextBox();
            this.lbrepo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbfile
            // 
            this.lbfile.AutoSize = true;
            this.lbfile.Location = new System.Drawing.Point(48, 21);
            this.lbfile.Name = "lbfile";
            this.lbfile.Size = new System.Drawing.Size(34, 17);
            this.lbfile.TabIndex = 0;
            this.lbfile.Text = "File:";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(344, 175);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tbfile
            // 
            this.tbfile.Location = new System.Drawing.Point(138, 21);
            this.tbfile.Name = "tbfile";
            this.tbfile.Size = new System.Drawing.Size(469, 22);
            this.tbfile.TabIndex = 4;
            this.tbfile.Text = "D:\\04_semester\\masterarbeit_hawaii_stuff\\Praxis\\GIT\\GitTestJava\\neu.txt";
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(631, 21);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 5;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // tbrepo
            // 
            this.tbrepo.Location = new System.Drawing.Point(138, 49);
            this.tbrepo.Name = "tbrepo";
            this.tbrepo.Size = new System.Drawing.Size(469, 22);
            this.tbrepo.TabIndex = 7;
            this.tbrepo.Text = "D:\\04_semester\\masterarbeit_hawaii_stuff\\Praxis\\GIT\\GitTestJava";
            // 
            // lbrepo
            // 
            this.lbrepo.AutoSize = true;
            this.lbrepo.Location = new System.Drawing.Point(48, 49);
            this.lbrepo.Name = "lbrepo";
            this.lbrepo.Size = new System.Drawing.Size(80, 17);
            this.lbrepo.TabIndex = 6;
            this.lbrepo.Text = "Repository:";
            // 
            // SvnClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 382);
            this.Controls.Add(this.tbrepo);
            this.Controls.Add(this.lbrepo);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.tbfile);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lbfile);
            this.Name = "SvnClient";
            this.Text = "SvnClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbfile;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox tbfile;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox tbrepo;
        private System.Windows.Forms.Label lbrepo;
    }
}

