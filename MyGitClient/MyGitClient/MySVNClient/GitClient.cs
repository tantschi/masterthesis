using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GitSharp;

namespace MySVNClient
{
    public partial class SvnClient : Form
    {
        public SvnClient()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            // http://www.eqqon.com/index.php/GitSharp/Examples
            //Opening an existing git repository
            Repository repo = new Repository(tbrepo.Text);
            String comment = "My first commit with gitsharp";

            // Now suppose you have created some new files and want to commit them
            repo.Index.Add(tbfile.Text);
            Commit commit = repo.Commit(comment, new Author("Tanja", "t.malitz@gmx.at"));
        }
    }
}
