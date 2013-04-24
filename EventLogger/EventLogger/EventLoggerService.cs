using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Configuration;

namespace EventLogger
{
    public partial class EventLoggerService : ServiceBase
    {

        #region Member fields
        // Private fields
        private EventLoggerApp _app = new EventLoggerApp();
        #endregion Member fields

        public EventLoggerService()
        {
            InitializeComponent();
            this.ServiceName = ConfigurationManager.AppSettings.Get("ServiceName");
        }

        protected override void OnStart(string[] args)
        {
            if (_app == null)
                _app = new EventLoggerApp();

            _app.Start();
        }

        protected override void OnStop()
        {
            if (_app != null)
                _app.Stop();
        }
    }
}
