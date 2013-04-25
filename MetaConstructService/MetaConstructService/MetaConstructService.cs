using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Configuration;

namespace MetaConstructService
{
    public partial class EventLoggerService : ServiceBase
    {

        #region Member fields
        // Private fields
        private MetaConstructApp _app = new MetaConstructApp();
        #endregion Member fields

        public EventLoggerService()
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
