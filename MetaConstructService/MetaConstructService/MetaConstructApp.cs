using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;
using System.Linq;

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
                    String commitmsg = mc.GetConfigurationValue("CommitMsg");
                    String dest = mc.GetConfigurationValue("Destination");
                    String content = getContent();

                    // add content to subversion on specific destination
                    MySubversion ms = new MySubversion();
                    ms.addSubversion(dest, commitmsg, DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + ";" + content);

                    // Sleep for Interval 
                    String intervall = mc.GetConfigurationValue("Intervall");
                    Int32 intervalltime = Convert.ToInt32(intervall) * 1000;
                    Thread.Sleep(intervalltime);
                }
            }
            catch (ThreadAbortException)
            {
                
            }
        }

        // extract link between sensors or constructs
        private String getContent()
        {
            MyConfig mc = new MyConfig();
            String dest = mc.GetConfigurationValue("CommitMsg");

            String sensor;
            String value;
        
            NameValueCollection col = ConfigurationManager.AppSettings;
            List<String> list = new List<String>();
            for (int i = 0; i < col.Count; i++)
            {
                if (col.Keys[i].Contains("data_"))
                {
                    // remove data_
                    sensor = col.Keys[i].Remove(0,5);

                    // if link contains that data-piece
                    if (dest.Contains(sensor))
                    {
                        value = ReadfromFile(col[i]);

                        String[] split = value.Split(';');
                        dest = dest.Replace(sensor, split[1]);
                    }
                }
            }

            // calculate result
            MathParser parser = new MathParser();
            bool isRadians = false;
            double result = parser.Parse(dest, isRadians);
            return result.ToString();

        }

        /* return last line of .txt-File */
        private String ReadfromFile(String dest)
        {
            String text = File.ReadLines(dest).Last();
            return text;
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
