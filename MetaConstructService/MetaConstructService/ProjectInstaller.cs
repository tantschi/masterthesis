using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;


namespace MetaConstructService
{
    [RunInstaller(true)]

    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {

        public ProjectInstaller()
        {

            //InitializeComponent();
            this.Installers.Add(GetServiceInstaller());
            this.Installers.Add(GetServiceProcessInstaller());
        }

        private ServiceInstaller GetServiceInstaller()
        {
            ServiceInstaller installer = new ServiceInstaller();
            MyConfig mc = new MyConfig();
            installer.ServiceName = mc.GetConfigurationValue("ServiceName");
            return installer;
        }

        private ServiceProcessInstaller GetServiceProcessInstaller()
        {
            ServiceProcessInstaller installer = new ServiceProcessInstaller();
            installer.Account = ServiceAccount.User;
            installer.Username = "TANTSCHI-PC\\Tantschi";
            installer.Password = "georg";
            return installer;
        }
    }
}
