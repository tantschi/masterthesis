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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.cbCmdList = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(48, 21);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(325, 17);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Select an SVN command to run and then click \'Go\'";
            // 
            // cbCmdList
            // 
            this.cbCmdList.FormattingEnabled = true;
            this.cbCmdList.Items.AddRange(new object[] {
            "svn checkout",
            "svn commit",
            "svn proplist"});
            this.cbCmdList.Location = new System.Drawing.Point(153, 56);
            this.cbCmdList.Name = "cbCmdList";
            this.cbCmdList.Size = new System.Drawing.Size(121, 24);
            this.cbCmdList.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(91, 98);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(238, 98);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // SvnClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 165);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cbCmdList);
            this.Controls.Add(this.lblPrompt);
            this.Name = "SvnClient";
            this.Text = "SvnClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.ComboBox cbCmdList;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnQuit;
    }
}

