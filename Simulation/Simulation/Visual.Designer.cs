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
            this.components = new System.ComponentModel.Container();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
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
            this.tintervall = new System.Windows.Forms.Timer(this.components);
            this.gbview.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(136, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Visual Example 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(136, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Visual Example 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // gbview
            // 
            this.gbview.Controls.Add(this.radioButton1);
            this.gbview.Controls.Add(this.radioButton2);
            this.gbview.Controls.Add(this.btshow);
            this.gbview.Location = new System.Drawing.Point(490, 47);
            this.gbview.Name = "gbview";
            this.gbview.Size = new System.Drawing.Size(214, 137);
            this.gbview.TabIndex = 2;
            this.gbview.TabStop = false;
            this.gbview.Text = "Visualize";
            // 
            // btshow
            // 
            this.btshow.Location = new System.Drawing.Point(21, 95);
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
            this.btcancel.Location = new System.Drawing.Point(560, 219);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(75, 23);
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
            this.lvdata.Size = new System.Drawing.Size(340, 167);
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
            this.tbdestination.TextChanged += new System.EventHandler(this.tbdestination_TextChanged);
            // 
            // tintervall
            // 
            this.tintervall.Interval = 5000;
            this.tintervall.Tick += new System.EventHandler(this.tintervall_Tick);
            // 
            // Visual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btcancel;
            this.ClientSize = new System.Drawing.Size(743, 276);
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
            this.gbview.ResumeLayout(false);
            this.gbview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox gbview;
        private System.Windows.Forms.Button btshow;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.TextBox tbdesc;
        private System.Windows.Forms.ListView lvdata;
        private System.Windows.Forms.Label lbdesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbdest;
        private System.Windows.Forms.TextBox tbdestination;
        private System.Windows.Forms.Timer tintervall;
        private System.Windows.Forms.ColumnHeader chdate;
        private System.Windows.Forms.ColumnHeader chdata;
    }
}