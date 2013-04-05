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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpsvn = new System.Windows.Forms.TabPage();
            this.lbdescription = new System.Windows.Forms.Label();
            this.tblocaldest = new System.Windows.Forms.TextBox();
            this.tbdescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btcancel = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpsvn.SuspendLayout();
            this.tpgit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpsvn);
            this.tabControl1.Controls.Add(this.tpgit);
            this.tabControl1.Location = new System.Drawing.Point(62, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 170);
            this.tabControl1.TabIndex = 21;
            // 
            // tpsvn
            // 
            this.tpsvn.Controls.Add(this.lbdescription);
            this.tpsvn.Controls.Add(this.tblocaldest);
            this.tpsvn.Controls.Add(this.tbdescription);
            this.tpsvn.Controls.Add(this.label2);
            this.tpsvn.Controls.Add(this.button1);
            this.tpsvn.Location = new System.Drawing.Point(4, 25);
            this.tpsvn.Name = "tpsvn";
            this.tpsvn.Padding = new System.Windows.Forms.Padding(3);
            this.tpsvn.Size = new System.Drawing.Size(511, 141);
            this.tpsvn.TabIndex = 0;
            this.tpsvn.Text = "SVN";
            this.tpsvn.UseVisualStyleBackColor = true;
            // 
            // lbdescription
            // 
            this.lbdescription.AutoSize = true;
            this.lbdescription.Location = new System.Drawing.Point(11, 63);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(79, 17);
            this.lbdescription.TabIndex = 17;
            this.lbdescription.Text = "Description";
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
            // tbdescription
            // 
            this.tbdescription.Location = new System.Drawing.Point(130, 61);
            this.tbdescription.Name = "tbdescription";
            this.tbdescription.Size = new System.Drawing.Size(364, 22);
            this.tbdescription.TabIndex = 18;
            this.tbdescription.Text = "Humidity";
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
            // 
            // btstartgit
            // 
            this.btstartgit.Location = new System.Drawing.Point(130, 101);
            this.btstartgit.Name = "btstartgit";
            this.btstartgit.Size = new System.Drawing.Size(87, 23);
            this.btstartgit.TabIndex = 21;
            this.btstartgit.Text = "Start";
            this.btstartgit.UseVisualStyleBackColor = true;
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
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(333, 236);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(86, 23);
            this.btcancel.TabIndex = 23;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(196, 236);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(87, 23);
            this.btadd.TabIndex = 22;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btcancel;
            this.ClientSize = new System.Drawing.Size(660, 311);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.tabControl1);
            this.Name = "Add";
            this.Text = "Add";
            this.tabControl1.ResumeLayout(false);
            this.tpsvn.ResumeLayout(false);
            this.tpsvn.PerformLayout();
            this.tpgit.ResumeLayout(false);
            this.tpgit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpsvn;
        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.TextBox tblocaldest;
        private System.Windows.Forms.TextBox tbdescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tpgit;
        private System.Windows.Forms.TextBox tblocalrepogit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btstartgit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tblocaldestgit;
        private System.Windows.Forms.TextBox tbcommitgit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btadd;
    }
}