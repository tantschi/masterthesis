namespace Simulation
{
    partial class Visual
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
            this.rbvisual1 = new System.Windows.Forms.RadioButton();
            this.gbview = new System.Windows.Forms.GroupBox();
            this.btshow = new System.Windows.Forms.Button();
            this.btcancel = new System.Windows.Forms.Button();
            this.tbdesc = new System.Windows.Forms.TextBox();
            this.lvdata = new System.Windows.Forms.ListView();
            this.chdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbdesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbdest = new System.Windows.Forms.Label();
            this.tbdestination = new System.Windows.Forms.TextBox();
            this.btrefresh = new System.Windows.Forms.Button();
            this.rbpiechart = new System.Windows.Forms.RadioButton();
            this.rbbars = new System.Windows.Forms.RadioButton();
            this.gbview.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbvisual1
            // 
            this.rbvisual1.AutoSize = true;
            this.rbvisual1.Location = new System.Drawing.Point(21, 29);
            this.rbvisual1.Name = "rbvisual1";
            this.rbvisual1.Size = new System.Drawing.Size(66, 21);
            this.rbvisual1.TabIndex = 0;
            this.rbvisual1.TabStop = true;
            this.rbvisual1.Text = "Curve";
            this.rbvisual1.UseVisualStyleBackColor = true;
            // 
            // gbview
            // 
            this.gbview.Controls.Add(this.rbbars);
            this.gbview.Controls.Add(this.rbpiechart);
            this.gbview.Controls.Add(this.rbvisual1);
            this.gbview.Controls.Add(this.btshow);
            this.gbview.Location = new System.Drawing.Point(490, 84);
            this.gbview.Name = "gbview";
            this.gbview.Size = new System.Drawing.Size(214, 148);
            this.gbview.TabIndex = 2;
            this.gbview.TabStop = false;
            this.gbview.Text = "Visualize";
            // 
            // btshow
            // 
            this.btshow.Location = new System.Drawing.Point(67, 115);
            this.btshow.Name = "btshow";
            this.btshow.Size = new System.Drawing.Size(75, 23);
            this.btshow.TabIndex = 3;
            this.btshow.Text = "Show";
            this.btshow.UseVisualStyleBackColor = true;
            this.btshow.Click += new System.EventHandler(this.btshow_Click);
            // 
            // btcancel
            // 
            this.btcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btcancel.Location = new System.Drawing.Point(612, 247);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(75, 27);
            this.btcancel.TabIndex = 4;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            // 
            // tbdesc
            // 
            this.tbdesc.Location = new System.Drawing.Point(117, 20);
            this.tbdesc.Name = "tbdesc";
            this.tbdesc.Size = new System.Drawing.Size(340, 22);
            this.tbdesc.TabIndex = 5;
            // 
            // lvdata
            // 
            this.lvdata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdate,
            this.chdata});
            this.lvdata.Location = new System.Drawing.Point(117, 75);
            this.lvdata.Name = "lvdata";
            this.lvdata.Size = new System.Drawing.Size(340, 208);
            this.lvdata.TabIndex = 6;
            this.lvdata.UseCompatibleStateImageBehavior = false;
            this.lvdata.View = System.Windows.Forms.View.Details;
            // 
            // chdate
            // 
            this.chdate.Text = "Date";
            this.chdate.Width = 140;
            // 
            // chdata
            // 
            this.chdata.Text = "Data";
            this.chdata.Width = 190;
            // 
            // lbdesc
            // 
            this.lbdesc.AutoSize = true;
            this.lbdesc.Location = new System.Drawing.Point(24, 23);
            this.lbdesc.Name = "lbdesc";
            this.lbdesc.Size = new System.Drawing.Size(79, 17);
            this.lbdesc.TabIndex = 7;
            this.lbdesc.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data";
            // 
            // lbdest
            // 
            this.lbdest.AutoSize = true;
            this.lbdest.Location = new System.Drawing.Point(24, 50);
            this.lbdest.Name = "lbdest";
            this.lbdest.Size = new System.Drawing.Size(79, 17);
            this.lbdest.TabIndex = 10;
            this.lbdest.Text = "Destination";
            // 
            // tbdestination
            // 
            this.tbdestination.Location = new System.Drawing.Point(117, 47);
            this.tbdestination.Name = "tbdestination";
            this.tbdestination.Size = new System.Drawing.Size(340, 22);
            this.tbdestination.TabIndex = 9;
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(512, 247);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(75, 27);
            this.btrefresh.TabIndex = 11;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // rbpiechart
            // 
            this.rbpiechart.AutoSize = true;
            this.rbpiechart.Location = new System.Drawing.Point(21, 56);
            this.rbpiechart.Name = "rbpiechart";
            this.rbpiechart.Size = new System.Drawing.Size(87, 21);
            this.rbpiechart.TabIndex = 4;
            this.rbpiechart.TabStop = true;
            this.rbpiechart.Text = "Pie Chart";
            this.rbpiechart.UseVisualStyleBackColor = true;
            // 
            // rbbars
            // 
            this.rbbars.AutoSize = true;
            this.rbbars.Location = new System.Drawing.Point(21, 83);
            this.rbbars.Name = "rbbars";
            this.rbbars.Size = new System.Drawing.Size(58, 21);
            this.rbbars.TabIndex = 5;
            this.rbbars.TabStop = true;
            this.rbbars.Text = "Bars";
            this.rbbars.UseVisualStyleBackColor = true;
            // 
            // Visual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btcancel;
            this.ClientSize = new System.Drawing.Size(736, 295);
            this.Controls.Add(this.btrefresh);
            this.Controls.Add(this.lbdest);
            this.Controls.Add(this.tbdestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbdesc);
            this.Controls.Add(this.lvdata);
            this.Controls.Add(this.tbdesc);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.gbview);
            this.Name = "Visual";
            this.Text = "Visualization";
            this.Load += new System.EventHandler(this.Visual_Load);
            this.gbview.ResumeLayout(false);
            this.gbview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbvisual1;
        private System.Windows.Forms.GroupBox gbview;
        private System.Windows.Forms.Button btshow;
        private System.Windows.Forms.Button btcancel;
        public System.Windows.Forms.TextBox tbdesc;
        private System.Windows.Forms.Label lbdesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbdest;
        private System.Windows.Forms.TextBox tbdestination;
        private System.Windows.Forms.ColumnHeader chdate;
        private System.Windows.Forms.ColumnHeader chdata;
        public System.Windows.Forms.ListView lvdata;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.RadioButton rbbars;
        private System.Windows.Forms.RadioButton rbpiechart;
    }
}