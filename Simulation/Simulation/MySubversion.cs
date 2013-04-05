using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpSvn;
using SharpSvn.UI;
using System.IO;

namespace Simulation
{
    class MySubversion
    {
        String _localDest;

        public MySubversion(String localDest)
        {

            _localDest = localDest;

        }

        private void addSubversion(String dest, String sensors)
        {
            String strLine="Test";

            SavetoFile(dest, strLine);
        }




        private void SavetoSVN(String commitmsg)
        {

            //This object allows us to provide options for 'svn commit'
            SvnCommitArgs args = new SvnCommitArgs();

            //This is how you specify a commit message.
            args.LogMessage = commitmsg;

            //This is where results for 'svn commit' are stored
            SvnCommitResult result;

            using (SharpSvn.SvnClient client = new SharpSvn.SvnClient())
            {
                try
                {
                    //This method is the equivalent of 'svn commit'
                    client.Commit(_localDest, args, out result);
                    if (result != null)
                        Console.Write("Erfolgreich");
                    else
                        Console.Write("Fehler" + result);
                }
                catch (SvnException se)
                {
                    Console.Write("Error: " + se.SvnErrorCode + Environment.NewLine, "svn commit error");
                }
            }
        }

        private void SavetoFile(String dest, String strLine)
        {
            FileStream sensor = new FileStream(dest, FileMode.Append);
            using (StreamWriter sw = new StreamWriter(sensor))
            {
                sw.WriteLine(strLine);
                sw.Close();
            }

        }

        public void saveSubversion(String data, String commitmsg)
        {
            SavetoFile(data);
            SavetoSVN(commitmsg);
        }
    }
}
