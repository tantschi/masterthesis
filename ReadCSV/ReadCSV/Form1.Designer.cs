namespace ReadCSV
{
    partial class freadcsv
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
            this.lbfile = new System.Windows.Forms.Label();
            this.tbfile = new System.Windows.Forms.TextBox();
            this.brbrowse = new System.Windows.Forms.Button();
            this.btstart = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.tbinterval = new System.Windows.Forms.TextBox();
            this.lbinterval = new System.Windows.Forms.Label();
            this.lvdata = new System.Windows.Forms.ListView();
            this.chtimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chcontent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbdescription = new System.Windows.Forms.TextBox();
            this.lbdescription = new System.Windows.Forms.Label();
            this.tinterval = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ofdfileselector = new System.Windows.Forms.OpenFileDialog();
            this.tblocaldest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcommitmsg = new System.Windows.Forms.TextBox();
            this.btquit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpsvn = new System.Windows.Forms.TabPage();
            this.tpgit = new System.Windows.Forms.TabPage();
            this.tblocalrepogit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btstartgit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tblocaldestgit = new System.Windows.Forms.TextBox();
            this.tbcommitgit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpsvn.SuspendLayout();
            this.tpgit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbfile
            // 
            this.lbfile.AutoSize = true;
            this.lbfile.Location = new System.Drawing.Point(15, 54);
            this.lbfile.Name = "lbfile";
            this.lbfile.Size = new System.Drawing.Size(92, 17);
            this.lbfile.TabIndex = 0;
            this.lbfile.Text = "Sensor origin";
            // 
            // tbfile
            // 
            this.tbfile.Location = new System.Drawing.Point(114, 53);
            this.tbfile.Name = "tbfile";
            this.tbfile.Size = new System.Drawing.Size(294, 22);
            this.tbfile.TabIndex = 1;
            this.tbfile.Text = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Testdaten_Einlesen\\feuchtigkeit.c" +
    "sv";
            // 
            // brbrowse
            // 
            this.brbrowse.Location = new System.Drawing.Point(414, 54);
            this.brbrowse.Name = "brbrowse";
            this.brbrowse.Size = new System.Drawing.Size(84, 23);
            this.brbrowse.TabIndex = 2;
            this.brbrowse.Text = "Browse ...";
            this.brbrowse.UseVisualStyleBackColor = true;
            this.brbrowse.Click += new System.EventHandler(this.brbrowse_Click);
            // 
            // btstart
            // 
            this.btstart.Location = new System.Drawing.Point(130, 101);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(87, 23);
            this.btstart.TabIndex = 3;
            this.btstart.Text = "Start";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btload_Click);
            // 
            // btstop
            // 
            this.btstop.Location = new System.Drawing.Point(267, 101);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(86, 23);
            this.btstop.TabIndex = 4;
            this.btstop.Text = "Stop";
            this.btstop.UseVisualStyleBackColor = true;
            this.btstop.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // tbinterval
            // 
            this.tbinterval.Location = new System.Drawing.Point(114, 81);
            this.tbinterval.Name = "tbinterval";
            this.tbinterval.Size = new System.Drawing.Size(60, 22);
            this.tbinterval.TabIndex = 9;
            this.tbinterval.Text = "1";
            this.tbinterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbinterval
            // 
            this.lbinterval.AutoSize = true;
            this.lbinterval.Location = new System.Drawing.Point(15, 84);
            this.lbinterval.Name = "lbinterval";
            this.lbinterval.Size = new System.Drawing.Size(54, 17);
            this.lbinterval.TabIndex = 8;
            this.lbinterval.Text = "Interval";
            // 
            // lvdata
            // 
            this.lvdata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chtimestamp,
            this.chcontent,
            this.chdescription});
            this.lvdata.Location = new System.Drawing.Point(583, 23);
            this.lvdata.Name = "lvdata";
            this.lvdata.Size = new System.Drawing.Size(455, 307);
            this.lvdata.TabIndex = 10;
            this.lvdata.UseCompatibleStateImageBehavior = false;
            this.lvdata.View = System.Windows.Forms.View.Details;
            // 
            // chtimestamp
            // 
            this.chtimestamp.Text = "Timestamp";
            this.chtimestamp.Width = 125;
            // 
            // chcontent
            // 
            this.chcontent.Text = "Content";
            this.chcontent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chcontent.Width = 85;
            // 
            // chdescription
            // 
            this.chdescription.Text = "Description";
            this.chdescription.Width = 206;
            // 
            // tbdescription
            // 
            this.tbdescription.Location = new System.Drawing.Point(114, 21);
            this.tbdescription.Name = "tbdescription";
            this.tbdescription.Size = new System.Drawing.Size(384, 22);
            this.tbdescription.TabIndex = 12;
            this.tbdescription.Text = "humidity";
            // 
            // lbdescription
            // 
            this.lbdescription.AutoSize = true;
            this.lbdescription.Location = new System.Drawing.Point(15, 24);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(79, 17);
            this.lbdescription.TabIndex = 11;
            this.lbdescription.Text = "Description";
            // 
            // tinterval
            // 
            this.tinterval.Interval = 5000;
            this.tinterval.Tick += new System.EventHandler(this.tinterval_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "seconds";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ofdfileselector
            // 
            this.ofdfileselector.FileName = "openFileDialog1";
            this.ofdfileselector.InitialDirectory = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Testdaten_Einlesen";
            // 
            // tblocaldest
            // 
            this.tblocaldest.Location = new System.Drawing.Point(130, 33);
            this.tblocaldest.Name = "tblocaldest";
            this.tblocaldest.Size = new System.Drawing.Size(274, 22);
            this.tblocaldest.TabIndex = 15;
            this.tblocaldest.Text = "D:\\04_semester\\masterarbeit_hawaii_stuff\\praxis\\github\\codegoogle_thesis_svn\\humi" +
    "dity.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Local Destination";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Browse ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brbrowse);
            this.groupBox1.Controls.Add(this.tbdescription);
            this.groupBox1.Controls.Add(this.lbfile);
            this.groupBox1.Controls.Add(this.tbfile);
            this.groupBox1.Controls.Add(this.lbinterval);
            this.groupBox1.Controls.Add(this.tbinterval);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbdescription);
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 121);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Commit Message";
            // 
            // tbcommitmsg
            // 
            this.tbcommitmsg.Location = new System.Drawing.Point(130, 61);
            this.tbcommitmsg.Name = "tbcommitmsg";
            this.tbcommitmsg.Size = new System.Drawing.Size(364, 22);
            this.tbcommitmsg.TabIndex = 18;
            this.tbcommitmsg.Text = "TMalitz Test";
            // 
            // btquit
            // 
            this.btquit.Location = new System.Drawing.Point(233, 343);
            this.btquit.Name = "btquit";
            this.btquit.Size = new System.Drawing.Size(86, 23);
            this.btquit.TabIndex = 19;
            this.btquit.Text = "Quit";
            this.btquit.UseVisualStyleBackColor = true;
            this.btquit.Click += new System.EventHandler(this.btcancel_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpsvn);
            this.tabControl1.Controls.Add(this.tpgit);
            this.tabControl1.Location = new System.Drawing.Point(29, 167);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 170);
            this.tabControl1.TabIndex = 20;
            // 
            // tpsvn
            // 
            this.tpsvn.Controls.Add(this.label3);
            this.tpsvn.Controls.Add(this.tblocaldest);
            this.tpsvn.Controls.Add(this.tbcommitmsg);
            this.tpsvn.Controls.Add(this.label2);
            this.tpsvn.Controls.Add(this.btstop);
            this.tpsvn.Controls.Add(this.btstart);
            this.tpsvn.Controls.Add(this.button1);
            this.tpsvn.Location = new System.Drawing.Point(4, 25);
            this.tpsvn.Name = "tpsvn";
            this.tpsvn.Padding = new System.Windows.Forms.Padding(3);
            this.tpsvn.Size = new System.Drawing.Size(511, 141);
            this.tpsvn.TabIndex = 0;
            this.tpsvn.Text = "SVN";
            this.tpsvn.UseVisualStyleBackColor = true;
            // 
            // tpgit
            // 
            this.tpgit.Controls.Add(this.tblocalrepogit);
            this.tpgit.Controls.Add(this.label6);
            this.tpgit.Controls.Add(this.button4);
            this.tpgit.Controls.Add(this.button3);
            this.tpgit.Controls.Add(this.btstartgit);
            this.tpgit.Controls.Add(this.label4);
            this.tpgit.Controls.Add(this.tblocaldestgit);
            this.tpgit.Controls.Add(this.tbcommitgit);
            this.tpgit.Controls.Add(this.label5);
            this.tpgit.Controls.Add(this.button2);
            this.tpgit.Location = new System.Drawing.Point(4, 25);
            this.tpgit.Name = "tpgit";
            this.tpgit.Padding = new System.Windows.Forms.Padding(3);
            this.tpgit.Size = new System.Drawing.Size(511, 141);
            this.tpgit.TabIndex = 1;
            this.tpgit.Text = "Git";
            this.tpgit.UseVisualStyleBackColor = true;
            // 
            // tblocalrepogit
            // 
            this.tblocalrepogit.Location = new System.Drawing.Point(133, 13);
            this.tblocalrepogit.Name = "tblocalrepogit";
            this.tblocalrepogit.Size = new System.Drawing.Size(274, 22);
            this.tblocalrepogit.TabIndex = 25;
            this.tblocalrepogit.Text = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Github\\thesis_git";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Local Repository";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(413, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Browse ...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btstartgit
            // 
            this.btstartgit.Location = new System.Drawing.Point(130, 101);
            this.btstartgit.Name = "btstartgit";
            this.btstartgit.Size = new System.Drawing.Size(87, 23);
            this.btstartgit.TabIndex = 21;
            this.btstartgit.Text = "Start";
            this.btstartgit.UseVisualStyleBackColor = true;
            this.btstartgit.Click += new System.EventHandler(this.btstartgit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Commit Message";
            // 
            // tblocaldestgit
            // 
            this.tblocaldestgit.Location = new System.Drawing.Point(133, 41);
            this.tblocaldestgit.Name = "tblocaldestgit";
            this.tblocaldestgit.Size = new System.Drawing.Size(274, 22);
            this.tblocaldestgit.TabIndex = 20;
            this.tblocaldestgit.Text = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Github\\thesis_git\\humidity.txt";
            // 
            // tbcommitgit
            // 
            this.tbcommitgit.Location = new System.Drawing.Point(133, 69);
            this.tbcommitgit.Name = "tbcommitgit";
            this.tbcommitgit.Size = new System.Drawing.Size(364, 22);
            this.tbcommitgit.TabIndex = 23;
            this.tbcommitgit.Text = "TMalitz Test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Local Destination";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Browse ...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // freadcsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 391);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btquit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvdata);
            this.Name = "freadcsv";
            this.Text = "Simulation - Geo Sensor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpsvn.ResumeLayout(false);
            this.tpsvn.PerformLayout();
            this.tpgit.ResumeLayout(false);
            this.tpgit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbfile;
        private System.Windows.Forms.TextBox tbfile;
        private System.Windows.Forms.Button brbrowse;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Button btstop;
        private System.Windows.Forms.TextBox tbinterval;
        private System.Windows.Forms.Label lbinterval;
        private System.Windows.Forms.ListView lvdata;
        private System.Windows.Forms.ColumnHeader chtimestamp;
        private System.Windows.Forms.ColumnHeader chcontent;
        private System.Windows.Forms.ColumnHeader chdescription;
        private System.Windows.Forms.TextBox tbdescription;
        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.Timer tinterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdfileselector;
        private System.Windows.Forms.TextBox tblocaldest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbcommitmsg;
        private System.Windows.Forms.Button btquit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpsvn;
        private System.Windows.Forms.TabPage tpgit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tblocaldestgit;
        private System.Windows.Forms.TextBox tbcommitgit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btstartgit;
        private System.Windows.Forms.TextBox tblocalrepogit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
    }
}

