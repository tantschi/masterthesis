using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Configuration;

// Quelle: http://www.codeproject.com/Articles/3990/Simple-Windows-Service-Sample
namespace MetaConstructServiceGIT
{
    public partial class MetaConstructServiceGIT : ServiceBase
    {

        #region Member fields
        // Private fields
        private MetaConstructApp _app = new MetaConstructApp();
        #endregion Member fields

        public MetaConstructServiceGIT()
        {
            InitializeComponent();
            this.ServiceName = ConfigurationManager.AppSettings.Get("ServiceName");
        }

        protected override void OnStart(string[] args)
        {
            if (_app == null)
                _app = new MetaConstructApp();

            _app.Start();
        }

        protected override void OnStop()
        {
            if (_app != null)
                _app.Stop();
        }
    }
}
