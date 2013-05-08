using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulation
{
    public partial class Settings : Form
    {

        Form startingForm;

        public Settings(Form f)
        {
            InitializeComponent();
            startingForm = f;


            if (((Start)startingForm).lbvcs.Text == "SVN")
            {
                rbsvn.Checked = true;
            }
            else
            {
                rbgit.Checked = true;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void btbrowsesvn_Click(object sender, EventArgs e)
        {
            if (ofdselector.ShowDialog() == DialogResult.OK)
            {
                tbreposvn.Text = ofdselector.FileName;
            }
        }

        private void btbrowse_git_Click(object sender, EventArgs e)
        {
            if (ofdselector.ShowDialog() == DialogResult.OK)
            {
                tbrepogit.Text = ofdselector.FileName;
            }
        }

        private void rbsvn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbsvn.Checked == true)
            {
                ((Start)startingForm).lbvcs.Text = "SVN";
                ((Start)startingForm).repo = tbreposvn.Text;
                ((Start)startingForm).install = tbsvninstall.Text;
                ((Start)startingForm).uninstall = tbsvnuninstall.Text;
                ((Start)startingForm).config = tbsvnconfig.Text;
            }
            else
            {
                ((Start)startingForm).lbvcs.Text = "GIT";
                ((Start)startingForm).repo = tbrepogit.Text;
                ((Start)startingForm).install = tbgitinstall.Text;
                ((Start)startingForm).uninstall = tbgituninstall.Text;
                ((Start)startingForm).config = tbgitconfig.Text;
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {

        }
    }
}
