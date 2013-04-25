namespace MetaConstructService
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventLoggerProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.eventLoggerServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // eventLoggerProcessInstaller
            // 
            this.eventLoggerProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.eventLoggerProcessInstaller.Password = null;
            this.eventLoggerProcessInstaller.Username = null;
            // 
            // eventLoggerServiceInstaller
            // 
            this.eventLoggerServiceInstaller.ServiceName = "Service1";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.eventLoggerProcessInstaller,
            this.eventLoggerServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller eventLoggerProcessInstaller;
        private System.ServiceProcess.ServiceInstaller eventLoggerServiceInstaller;
    }
}