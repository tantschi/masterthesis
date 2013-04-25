using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpSvn;
using SharpSvn.UI;

namespace MySVNClient
{
    public partial class frmCommit : Form
    {
        public frmCommit()
        {
            InitializeComponent();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (tbFileName.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid filename in the 'File:' box");
                return;
            }

            //This object allows us to provide options for 'svn commit'
            SvnCommitArgs args = new SvnCommitArgs();

            //This is how you specify a commit message.
            args.LogMessage = tbMessage.Text;

            //This is where results for 'svn commit' are stored
            SvnCommitResult result;

            //again, remember to include the using statement with SvnClients
            using (SharpSvn.SvnClient client = new SharpSvn.SvnClient())
            {
                try
                {
                    //Bind allows the client to prompt the user for authentication info.
                    SvnUI.Bind(client, this);

                    //This method is the equivalent of 'svn commit'
                    client.Commit(tbFileName.Text, args, out result);
                    if (result != null)
                        MessageBox.Show("Successfully commited revision " + result.Revision);
                    else
                        MessageBox.Show("No changes have been made to working copy since it was checked out.");
                }
                catch (SvnException se)
                {
                    MessageBox.Show(se.Message + "Error: " + se.SvnErrorCode + Environment.NewLine,
                    "svn commit error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofdFileSelector.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = ofdFileSelector.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
