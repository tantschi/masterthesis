namespace Simulation
{
    partial class Settings
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
            this.rbsvn = new System.Windows.Forms.RadioButton();
            this.rbgit = new System.Windows.Forms.RadioButton();
            this.tbrepogit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btok = new System.Windows.Forms.Button();
            this.gbvcs = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbgitconfig = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbgituninstall = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbgitinstall = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbsvnconfig = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbsvnuninstall = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbsvninstall = new System.Windows.Forms.TextBox();
            this.btbrowsesvn = new System.Windows.Forms.Button();
            this.btbrowse_git = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbreposvn = new System.Windows.Forms.TextBox();
            this.ofdselector = new System.Windows.Forms.OpenFileDialog();
            this.gbvcs.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbsvn
            // 
            this.rbsvn.AutoSize = true;
            this.rbsvn.Checked = true;
            this.rbsvn.Location = new System.Drawing.Point(20, 30);
            this.rbsvn.Name = "rbsvn";
            this.rbsvn.Size = new System.Drawing.Size(100, 21);
            this.rbsvn.TabIndex = 0;
            this.rbsvn.TabStop = true;
            this.rbsvn.Text = "Subversion";
            this.rbsvn.UseVisualStyleBackColor = true;
            this.rbsvn.CheckedChanged += new System.EventHandler(this.rbsvn_CheckedChanged);
            // 
            // rbgit
            // 
            this.rbgit.AutoSize = true;
            this.rbgit.Location = new System.Drawing.Point(444, 30);
            this.rbgit.Name = "rbgit";
            this.rbgit.Size = new System.Drawing.Size(52, 21);
            this.rbgit.TabIndex = 1;
            this.rbgit.Text = "GIT";
            this.rbgit.UseVisualStyleBackColor = true;
            // 
            // tbrepogit
            // 
            this.tbrepogit.Location = new System.Drawing.Point(557, 58);
            this.tbrepogit.Name = "tbrepogit";
            this.tbrepogit.Size = new System.Drawing.Size(185, 22);
            this.tbrepogit.TabIndex = 2;
            this.tbrepogit.Text = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Github\\thesis_git";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Repository";
            // 
            // btok
            // 
            this.btok.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btok.Location = new System.Drawing.Point(420, 216);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(75, 23);
            this.btok.TabIndex = 4;
            this.btok.Text = "OK";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // gbvcs
            // 
            this.gbvcs.Controls.Add(this.label7);
            this.gbvcs.Controls.Add(this.tbgitconfig);
            this.gbvcs.Controls.Add(this.label8);
            this.gbvcs.Controls.Add(this.tbgituninstall);
            this.gbvcs.Controls.Add(this.label9);
            this.gbvcs.Controls.Add(this.tbgitinstall);
            this.gbvcs.Controls.Add(this.label6);
            this.gbvcs.Controls.Add(this.tbsvnconfig);
            this.gbvcs.Controls.Add(this.label5);
            this.gbvcs.Controls.Add(this.tbsvnuninstall);
            this.gbvcs.Controls.Add(this.label4);
            this.gbvcs.Controls.Add(this.tbsvninstall);
            this.gbvcs.Controls.Add(this.btbrowsesvn);
            this.gbvcs.Controls.Add(this.btbrowse_git);
            this.gbvcs.Controls.Add(this.label3);
            this.gbvcs.Controls.Add(this.tbreposvn);
            this.gbvcs.Controls.Add(this.rbsvn);
            this.gbvcs.Controls.Add(this.rbgit);
            this.gbvcs.Controls.Add(this.label1);
            this.gbvcs.Controls.Add(this.tbrepogit);
            this.gbvcs.Location = new System.Drawing.Point(25, 22);
            this.gbvcs.Name = "gbvcs";
            this.gbvcs.Size = new System.Drawing.Size(859, 183);
            this.gbvcs.TabIndex = 5;
            this.gbvcs.TabStop = false;
            this.gbvcs.Text = "Version Control System";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Config";
            // 
            // tbgitconfig
            // 
            this.tbgitconfig.Location = new System.Drawing.Point(557, 142);
            this.tbgitconfig.Name = "tbgitconfig";
            this.tbgitconfig.Size = new System.Drawing.Size(274, 22);
            this.tbgitconfig.TabIndex = 20;
            this.tbgitconfig.Text = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructServiceG" +
    "IT\\MetaConstructServiceGIT\\bin\\Debug\\MetaConstructServiceGIT.exe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Uninstall";
            // 
            // tbgituninstall
            // 
            this.tbgituninstall.Location = new System.Drawing.Point(557, 114);
            this.tbgituninstall.Name = "tbgituninstall";
            this.tbgituninstall.Size = new System.Drawing.Size(274, 22);
            this.tbgituninstall.TabIndex = 18;
            this.tbgituninstall.Text = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructServiceG" +
    "IT\\MetaConstructServiceGIT\\bin\\Debug\\Uninstall.cmd";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Install";
            // 
            // tbgitinstall
            // 
            this.tbgitinstall.Location = new System.Drawing.Point(557, 86);
            this.tbgitinstall.Name = "tbgitinstall";
            this.tbgitinstall.Size = new System.Drawing.Size(274, 22);
            this.tbgitinstall.TabIndex = 16;
            this.tbgitinstall.Text = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructServiceG" +
    "IT\\MetaConstructServiceGIT\\bin\\Debug\\Install.cmd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Config";
            // 
            // tbsvnconfig
            // 
            this.tbsvnconfig.Location = new System.Drawing.Point(136, 139);
            this.tbsvnconfig.Name = "tbsvnconfig";
            this.tbsvnconfig.Size = new System.Drawing.Size(274, 22);
            this.tbsvnconfig.TabIndex = 14;
            this.tbsvnconfig.Text = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructService\\" +
    "MetaConstructService\\bin\\Debug\\MetaConstructService.exe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Uninstall";
            // 
            // tbsvnuninstall
            // 
            this.tbsvnuninstall.Location = new System.Drawing.Point(136, 111);
            this.tbsvnuninstall.Name = "tbsvnuninstall";
            this.tbsvnuninstall.Size = new System.Drawing.Size(274, 22);
            this.tbsvnuninstall.TabIndex = 12;
            this.tbsvnuninstall.Text = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructService\\" +
    "MetaConstructService\\bin\\Debug\\Uninstall.cmd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Install";
            // 
            // tbsvninstall
            // 
            this.tbsvninstall.Location = new System.Drawing.Point(136, 83);
            this.tbsvninstall.Name = "tbsvninstall";
            this.tbsvninstall.Size = new System.Drawing.Size(274, 22);
            this.tbsvninstall.TabIndex = 10;
            this.tbsvninstall.Text = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructService\\" +
    "MetaConstructService\\bin\\Debug\\Install.cmd";
            // 
            // btbrowsesvn
            // 
            this.btbrowsesvn.Location = new System.Drawing.Point(328, 53);
            this.btbrowsesvn.Name = "btbrowsesvn";
            this.btbrowsesvn.Size = new System.Drawing.Size(82, 23);
            this.btbrowsesvn.TabIndex = 9;
            this.btbrowsesvn.Text = "Browse ...";
            this.btbrowsesvn.UseVisualStyleBackColor = true;
            this.btbrowsesvn.Click += new System.EventHandler(this.btbrowsesvn_Click);
            // 
            // btbrowse_git
            // 
            this.btbrowse_git.Location = new System.Drawing.Point(749, 56);
            this.btbrowse_git.Name = "btbrowse_git";
            this.btbrowse_git.Size = new System.Drawing.Size(82, 23);
            this.btbrowse_git.TabIndex = 6;
            this.btbrowse_git.Text = "Browse ...";
            this.btbrowse_git.UseVisualStyleBackColor = true;
            this.btbrowse_git.Click += new System.EventHandler(this.btbrowse_git_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Repository";
            // 
            // tbreposvn
            // 
            this.tbreposvn.Location = new System.Drawing.Point(136, 55);
            this.tbreposvn.Name = "tbreposvn";
            this.tbreposvn.Size = new System.Drawing.Size(185, 22);
            this.tbreposvn.TabIndex = 7;
            this.tbreposvn.Text = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Github\\codegoogle_thesis_svn";
            // 
            // ofdselector
            // 
            this.ofdselector.FileName = "openFileDialog1";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btok;
            this.ClientSize = new System.Drawing.Size(918, 259);
            this.Controls.Add(this.gbvcs);
            this.Controls.Add(this.btok);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gbvcs.ResumeLayout(false);
            this.gbvcs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbsvn;
        private System.Windows.Forms.RadioButton rbgit;
        private System.Windows.Forms.TextBox tbrepogit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.GroupBox gbvcs;
        private System.Windows.Forms.Button btbrowse_git;
        private System.Windows.Forms.Button btbrowsesvn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbreposvn;
        private System.Windows.Forms.OpenFileDialog ofdselector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbgitconfig;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbgituninstall;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbgitinstall;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbsvnconfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbsvnuninstall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbsvninstall;
    }
}