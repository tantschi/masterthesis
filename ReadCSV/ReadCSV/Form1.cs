using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace ReadCSV
{
    public partial class freadcsv : Form
    {

        private StreamReader sr;
        private String vcs;


        public freadcsv()
        {
            InitializeComponent();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            tinterval.Stop();
            sr.Close();
        }

        private void btload_Click(object sender, EventArgs e)
        {
            tinterval.Interval = Convert.ToInt32(tbinterval.Text) * 1000;
            vcs = "SVN";
            FileStream sensor = new FileStream(tbfile.Text, FileMode.Open);
            sr = new StreamReader(sensor, System.Text.Encoding.Default);
            lvdata.Items.Clear();
            tinterval.Start();
        }

        private void tinterval_Tick(object sender, EventArgs e)
        {
            if (sr.Peek() > -1)
            {
                string strLine = sr.ReadLine();
                String timestamp = DateTime.Now.ToString();

                ListViewItem item = new ListViewItem();
                item.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                item.SubItems.Add(strLine);
                item.SubItems.Add(tbdescription.Text);
                lvdata.Items.Add(item);
                lvdata.Sorting = SortOrder.Descending;

                if (vcs == "SVN")
                {
                    MySubversion svn = new MySubversion(tblocaldest.Text);
                    svn.saveSubversion(strLine, tbcommitmsg.Text);
                }
                else
                {
                    MyGit git = new MyGit(tblocaldestgit.Text, tblocalrepogit.Text);
                    git.saveGit(strLine, tbcommitmsg.Text);
                } 
            }
            else
            {
                tinterval.Stop();
                sr.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brbrowse_Click(object sender, EventArgs e)
        {
            if (ofdfileselector.ShowDialog() == DialogResult.OK)
            {
                tbfile.Text = ofdfileselector.FileName;
            }
        }

        private void btcancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdfileselector.ShowDialog() == DialogResult.OK)
            {
                tblocaldest.Text = ofdfileselector.FileName;
            }
        }

        private void btstartgit_Click(object sender, EventArgs e)
        {
            tinterval.Interval = Convert.ToInt32(tbinterval.Text) * 1000;
            FileStream sensor = new FileStream(tbfile.Text, FileMode.Open);
            sr = new StreamReader(sensor, System.Text.Encoding.Default);
            vcs = "GIT";
            lvdata.Items.Clear();
            tinterval.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tinterval.Stop();
            sr.Close();
        }

    }
}
