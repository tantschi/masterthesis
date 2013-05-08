using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Threading;
using System.Diagnostics;
using System.Configuration;
using System.Collections.Specialized;

namespace Simulation
{
    class MyService
    {
        // member deklaration
        private string _repo;
        private string _install;
        private string _uninstall;
        private string _config;

        public MyService(string repo, string install, string uninstall, string config)
        {
            _repo = repo;
            _install = install;
            _uninstall = uninstall;
            _config = config;
        }

        // install and start Service
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

        // stop and unistall service
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
                    AddConfigurationValue("ServiceName", serviceName);
                    uninstallService(serviceName);
                    Thread.Sleep(1000);
                }
            }
        }

        // install Service
        public void installService(String service, String destination, String commit, String intervall, Dictionary<string, string> data, String vcs)
        {
            AddConfigurationValue("ServiceName", service);
            AddConfigurationValue("Destination", destination);
            AddConfigurationValue("CommitMsg", commit);
            AddConfigurationValue("Intervall", intervall);

            DeleteConfigurationValue();
            foreach (KeyValuePair<string, string> kvp in data)
            {
                AddConfigurationValue("data_" + kvp.Key, kvp.Value); 
            }

            Process p = new Process();
            p.StartInfo.FileName = _install;
            p.Start();
            p.WaitForExit();
        }

        // uninstall Service
        public void uninstallService(String value)
        {
            AddConfigurationValue("ServiceName", value);
            Process p = new Process();
            p.StartInfo.FileName = _uninstall;
            p.Start();
        }

        // Delete configuration for Service
        private void DeleteConfigurationValue()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(_config); 

            foreach (String key in configuration.AppSettings.Settings.AllKeys)
            {
                if (key.Contains("data_"))
                {
                    configuration.AppSettings.Settings.Remove(key);
                }
            }

            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        // Add configuration for Service
        private void AddConfigurationValue(String key, String value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(_config);
            foreach (String loopkey in configuration.AppSettings.Settings.AllKeys)
            {
                if (loopkey.Contains(key))
                {
                    configuration.AppSettings.Settings.Remove(loopkey);
                }
            }
            
            configuration.AppSettings.Settings.Add(key, value);
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
