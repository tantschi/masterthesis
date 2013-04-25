using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace MetaConstructService
{
    public class MetaConstructApp
    {

        #region Member fields
        // Private fields
        private Thread _thread;
        #endregion Member fields5

        #region Private methods
        private void Execute()
        {
            // Loop until the thread gets aborted
            try
            {
                while (true)
                {
                    MyConfig mc = new MyConfig();
                    String dest = mc.GetConfigurationValue("Destination");
                    MySubversion ms = new MySubversion();
                    ms.addSubversion(dest, "Tanja aus MetaConstructService", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + ";content");

                    // Sleep for one minute 
                    Thread.Sleep(60000);
                }
            }
            catch (ThreadAbortException)
            {
                
            }
        }
        #endregion Private methods

        #region Public methods
        public void Start()
        {
            _thread = new Thread(new ThreadStart(Execute));
            _thread.Start();
        }

        public void Stop()
        {
            if (_thread != null)
            {
                _thread.Abort();
                _thread.Join();
            }
        }
        #endregion Public methods
    }
}
