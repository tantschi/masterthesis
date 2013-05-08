using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;

namespace MetaConstructServiceGIT
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();

        static void Main(string[] args)
        {
            // just for debugging
            if (args.Length > 0 && args[0].ToLower() == "/console")
            {
                AllocConsole();

                MetaConstructApp app = new MetaConstructApp();
                app.Start();

                string input = string.Empty;
                Console.Write("Input 'exit' to stop application: ");
               
                // work until exit is inputed
                while (input.ToLower() != "exit")
                    input = Console.ReadLine();

                app.Stop();
            }
            else
            {
                // Initialize and run the service
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[] { new MetaConstructServiceGIT() };
                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}