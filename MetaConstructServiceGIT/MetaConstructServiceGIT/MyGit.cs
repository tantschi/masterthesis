using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GitSharp.Commands;
using GitSharp;
using GitSharp.Core;
using GitSharp.Core.Transport;

namespace MetaConstructServiceGIT
{
    class MyGit
    {
        String _localDest; 
        String _repo;

        public MyGit(String localDest, String localRepo)
        {
            _localDest = localDest;
            _repo = localRepo;
        }

        public void addGit(String commitmsg, String content)
        {
            SavetoFile(content);
            SavetoGit(commitmsg);
        }

        private void SavetoFile(String strLine)
        {
            FileStream sensor = new FileStream(_localDest, System.IO.FileMode.Append);
            using (StreamWriter sw = new StreamWriter(sensor))
            {
                sw.WriteLine(strLine);
                sw.Close();
            }
        }

        private void SavetoGit(String commitmsg)
        {
            //Opening an existing git repository
            GitSharp.Repository repo = new GitSharp.Repository(_repo);

            // Now suppose you have created some new files and want to commit them
            repo.Index.Add(_localDest);
            GitSharp.Commit commit = repo.Commit(commitmsg, new Author("Tanja", "t.malitz@gmx.at"));

            /*
            PushCommand push = new PushCommand();

            if (commit.IsValid)
            {
                PushCommand pushCommand = new PushCommand
                {
                    RefSpecs = new List<RefSpec> {
                        new RefSpec("HEAD", "refs/for/master") //refs/for/master
                    },
                    Force = true,
                    Repository = repo
                };
                pushCommand.AddAll();
                pushCommand.Execute();
            } */
            
        }
        
    }
}
