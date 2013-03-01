using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GitSharp;

namespace ReadCSV
{
    class MyGit
    {
        String _repo;
        String _localDest;

        public MyGit(String localDest, String localRepo)
        {
            _localDest = localDest;
            _repo = localRepo;
        }

        private void SavetoGit(String commitmsg)
        {
            //Opening an existing git repository
            Repository repo = new Repository(_repo);

            // Now suppose you have created some new files and want to commit them
            repo.Index.Add(_localDest);
            Commit commit = repo.Commit(commitmsg, new Author("Tanja", "t.malitz@gmx.at"));
        }

        private void SavetoFile(String strLine)
        {
            FileStream sensor = new FileStream(_localDest, FileMode.Append);
            using (StreamWriter sw = new StreamWriter(sensor))
            {
                sw.WriteLine(strLine);
                sw.Close();
            }
        }

        public void saveGit(String data, String commitmsg)
        {
            SavetoFile(data);
            SavetoGit(commitmsg);
        }

    }
}
