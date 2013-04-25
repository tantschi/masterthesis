namespace MySVNClient
{
    partial class frmPropList
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
            this.lvProps = new System.Windows.Forms.ListView();
            this.chFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPropName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPropValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbRecurse = new System.Windows.Forms.CheckBox();
            this.lblFileURI = new System.Windows.Forms.Label();
            this.lblProperties = new System.Windows.Forms.Label();
            this.tbFileURI = new System.Windows.Forms.TextBox();
            this.btnGetProps = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvProps
            // 
            this.lvProps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFilePath,
            this.chPropName,
            this.chPropValue});
            this.lvProps.Location = new System.Drawing.Point(24, 96);
            this.lvProps.Name = "lvProps";
            this.lvProps.Size = new System.Drawing.Size(443, 213);
            this.lvProps.TabIndex = 0;
            this.lvProps.UseCompatibleStateImageBehavior = false;
            this.lvProps.View = System.Windows.Forms.View.Details;
            // 
            // chFilePath
            // 
            this.chFilePath.Text = "File";
            this.chFilePath.Width = 0;
            // 
            // chPropName
            // 
            this.chPropName.Text = "Name";
            this.chPropName.Width = 0;
            // 
            // chPropValue
            // 
            this.chPropValue.Text = "Value";
            this.chPropValue.Width = 0;
            // 
            // cbRecurse
            // 
            this.cbRecurse.AutoSize = true;
            this.cbRecurse.Location = new System.Drawing.Point(24, 47);
            this.cbRecurse.Name = "cbRecurse";
            this.cbRecurse.Size = new System.Drawing.Size(190, 21);
            this.cbRecurse.TabIndex = 1;
            this.cbRecurse.Text = "Recurse into Directories?";
            this.cbRecurse.UseVisualStyleBackColor = true;
            // 
            // lblFileURI
            // 
            this.lblFileURI.AutoSize = true;
            this.lblFileURI.Location = new System.Drawing.Point(21, 22);
            this.lblFileURI.Name = "lblFileURI";
            this.lblFileURI.Size = new System.Drawing.Size(61, 17);
            this.lblFileURI.TabIndex = 2;
            this.lblFileURI.Text = "File URI:";
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Location = new System.Drawing.Point(21, 76);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(77, 17);
            this.lblProperties.TabIndex = 3;
            this.lblProperties.Text = "Properties:";
            // 
            // tbFileURI
            // 
            this.tbFileURI.Location = new System.Drawing.Point(98, 19);
            this.tbFileURI.Name = "tbFileURI";
            this.tbFileURI.Size = new System.Drawing.Size(369, 22);
            this.tbFileURI.TabIndex = 4;
            // 
            // btnGetProps
            // 
            this.btnGetProps.Location = new System.Drawing.Point(240, 47);
            this.btnGetProps.Name = "btnGetProps";
            this.btnGetProps.Size = new System.Drawing.Size(119, 23);
            this.btnGetProps.TabIndex = 5;
            this.btnGetProps.Text = "Get Properties";
            this.btnGetProps.UseVisualStyleBackColor = true;
            this.btnGetProps.Click += new System.EventHandler(this.btnGetProps_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(365, 47);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmPropList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(503, 333);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetProps);
            this.Controls.Add(this.tbFileURI);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.lblFileURI);
            this.Controls.Add(this.cbRecurse);
            this.Controls.Add(this.lvProps);
            this.Name = "frmPropList";
            this.Text = "svn proplist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProps;
        private System.Windows.Forms.ColumnHeader chFilePath;
        private System.Windows.Forms.ColumnHeader chPropName;
        private System.Windows.Forms.ColumnHeader chPropValue;
        private System.Windows.Forms.CheckBox cbRecurse;
        private System.Windows.Forms.Label lblFileURI;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.TextBox tbFileURI;
        private System.Windows.Forms.Button btnGetProps;
        private System.Windows.Forms.Button btnCancel;
    }
}