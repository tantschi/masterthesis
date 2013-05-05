using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Threading;
using System.Diagnostics;
using System.Configuration;


namespace Simulation
{
    class MyService
    {

        public void startService(String serviceName)
        {

            ServiceController[] scServices;
            scServices = ServiceController.GetServices();

            foreach (ServiceController scTemp in scServices)
            {

                if (scTemp.ServiceName == serviceName)
                {
                    ServiceController sc = new ServiceController(serviceName);

                    if (sc.Status == ServiceControllerStatus.Stopped)
                    {
                        sc.Start();
                    }
                }
            }

        }

        public void stopService(String serviceName)
        {
            ServiceController[] scServices;
            scServices = ServiceController.GetServices();

            foreach (ServiceController scTemp in scServices)
            {

                if (scTemp.ServiceName == serviceName)
                {
                    ServiceController sc = new ServiceController(serviceName);

                    if (sc.Status != ServiceControllerStatus.Stopped)
                    {
                        sc.Stop();
                    }
                    SetConfigurationValue("ServiceName", serviceName);
                    uninstallService(serviceName);
                    Thread.Sleep(1000);
                }
            }
        }

        public void installService(String service, String destination, String commit, String intervall)
        {
            SetConfigurationValue("ServiceName", service);
            SetConfigurationValue("Destination", destination);
            SetConfigurationValue("CommitMsg", commit);
            SetConfigurationValue("Intervall", intervall);

            Process p = new Process();
            p.StartInfo.FileName = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructService\\MetaConstructService\\bin\\Debug\\Install.cmd";
            //p.StartInfo.Arguments = "/i \"C:\\Application.msi\"/qn";
            p.Start();
            p.WaitForExit();
        }

        public void uninstallService(String value)
        {
            SetConfigurationValue("ServiceName", value);
            Process p = new Process();
            p.StartInfo.FileName = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructService\\MetaConstructService\\bin\\Debug\\Uninstall.cmd";
            //p.StartInfo.Arguments = "/i \"C:\\Application.msi\"/qn";
            p.Start();
        }

        private void SetConfigurationValue(String key, String value)
        {

            Configuration configuration = ConfigurationManager.OpenExeConfiguration("D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructService\\MetaConstructService\\bin\\Debug\\MetaConstructService.exe");
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
    
        }

    }
}
