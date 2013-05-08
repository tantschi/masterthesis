using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Reflection;

namespace MetaConstructServiceGIT
{
    class MyConfig
    {
        public string GetConfigurationValue(string key)
        {
            Assembly service = Assembly.GetAssembly(typeof(ProjectInstaller));
            Configuration config = ConfigurationManager.OpenExeConfiguration(service.Location);
            if (config.AppSettings.Settings[key] != null)
            {
                return config.AppSettings.Settings[key].Value;
            }
            else
            {
                throw new IndexOutOfRangeException("Settings collection does not contain the requested key:" + key);
            }
        }
    }
}
