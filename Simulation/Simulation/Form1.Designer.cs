namespace Simulation
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Humditiy",
            "Sensor",
            "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Github\\codegoogle_thesis_svn\\humi" +
                "dity.txt"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Temperature",
            "Sensor",
            "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Github\\codegoogle_thesis_svn\\temp" +
                "erature.txt"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Air Pressure",
            "Sensor",
            "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Github\\codegoogle_thesis_svn\\airp" +
                "ressure.txt"}, -1);
            this.lvdata = new System.Windows.Forms.ListView();
            this.chdecription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chorig = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btadd = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btvisual = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.btlink = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvdata
            // 
            this.lvdata.CheckBoxes = true;
            this.lvdata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdecription,
            this.chtype,
            this.chorig});
            listViewItem1.StateImageIndex = 0;
            listViewItem1.Tag = "";
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.lvdata.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvdata.Location = new System.Drawing.Point(21, 31);
            this.lvdata.Name = "lvdata";
            this.lvdata.Size = new System.Drawing.Size(559, 293);
            this.lvdata.TabIndex = 0;
            this.lvdata.UseCompatibleStateImageBehavior = false;
            this.lvdata.View = System.Windows.Forms.View.Details;
            // 
            // chdecription
            // 
            this.chdecription.Text = "Decription";
            this.chdecription.Width = 160;
            // 
            // chtype
            // 
            this.chtype.Text = "Type";
            this.chtype.Width = 70;
            // 
            // chorig
            // 
            this.chorig.Text = "Destination";
            this.chorig.Width = 325;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvdata);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 347);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensors";
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(656, 105);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(103, 23);
            this.btadd.TabIndex = 1;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(656, 143);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(103, 23);
            this.btdelete.TabIndex = 2;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btvisual
            // 
            this.btvisual.Location = new System.Drawing.Point(656, 221);
            this.btvisual.Name = "btvisual";
            this.btvisual.Size = new System.Drawing.Size(103, 23);
            this.btvisual.TabIndex = 3;
            this.btvisual.Text = "Show";
            this.btvisual.UseVisualStyleBackColor = true;
            this.btvisual.Click += new System.EventHandler(this.btvisual_Click);
            // 
            // btclose
            // 
            this.btclose.Location = new System.Drawing.Point(656, 259);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(103, 23);
            this.btclose.TabIndex = 4;
            this.btclose.Text = "Close";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.button4_Click);
            // 
            // btlink
            // 
            this.btlink.Location = new System.Drawing.Point(656, 181);
            this.btlink.Name = "btlink";
            this.btlink.Size = new System.Drawing.Size(103, 23);
            this.btlink.TabIndex = 5;
            this.btlink.Text = "Link";
            this.btlink.UseVisualStyleBackColor = true;
            this.btlink.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 384);
            this.Controls.Add(this.btlink);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btvisual);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btadd);
            this.Name = "Form1";
            this.Text = "Geo Sensor Network";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lvdata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btvisual;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Button btlink;
        private System.Windows.Forms.ColumnHeader chdecription;
        private System.Windows.Forms.ColumnHeader chorig;
        private System.Windows.Forms.ColumnHeader chtype;
    }
}

