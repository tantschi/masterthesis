using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpSvn;
using SharpSvn.UI;
using System.IO;

namespace MetaConstructService
{
    class MySubversion
    {
        public void addSubversion(String dest, String commitmsg, String content)
        {
            SavetoFile(dest, content);
            SavetoSVN(dest, commitmsg);
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

        private void SavetoSVN(String dest, String commitmsg)
        {

            //This object allows us to provide options for 'svn commit'
            SvnCommitArgs args = new SvnCommitArgs();

            //This is how you specify a commit message.
            args.LogMessage = commitmsg;

            //This is where results for 'svn commit' are stored
            SvnCommitResult result;
            String logdest = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Github\\codegoogle_thesis_svn\\log.txt";

            using (SharpSvn.SvnClient client = new SharpSvn.SvnClient())
            {
                try
                {
                    //This method is the equivalent of 'svn commit'
                    client.Commit(dest, args, out result);
                    if (result != null)
                        SavetoFile(logdest, "Erfolgreich");
                    else
                        SavetoFile(logdest, "Fehler" + result);
                }
                catch (SvnException se)
                {
                    SavetoFile(logdest, "svn commit Error: " + se.SvnErrorCode + " + " + Environment.NewLine); 
                    Console.Write("Error: " + se.SvnErrorCode + se.SvnErrorCategory + Environment.NewLine, "svn commit error");
                }
            }
        }
    }
}
