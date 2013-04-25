using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpSvn;

namespace MySVNClient
{
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

            if (tbLocalPath.Text.Length == 0 || tbRepoURI.Text.Length == 0)
            {
                MessageBox.Show("The 'Repository URI' and 'Local Path' fields cannot be empty.");
                return;
            }

            //SvnUpdateResult provides info about what happened during a checkout
            SvnUpdateResult result;

            //we will use this to tell CheckOut() which revision to fetch
            long revision;

            //SvnCheckoutArgs wraps all of the options for the 'svn checkout' function
            SvnCheckOutArgs args = new SvnCheckOutArgs();

            //path is the path where the local working copy will end up
            string path = tbLocalPath.Text;

            if (long.TryParse(tbRevision.Text, out revision))
            {
                //set the revision number if the user entered a valid number
                args.Revision = new SvnRevision(revision);
            }
            //if args.Revision is not set, it defaults to fetch the HEAD revision.
            else MessageBox.Show("Invalid Revision number, defaulting to HEAD");
            
            //the using statement is necessary to ensure we are freeing up resources
            using (SharpSvn.SvnClient client = new SharpSvn.SvnClient())
            {
                try
                {
                    //SvnUriTarget is a wrapper class for SVN repository URIs
                    SvnUriTarget target = new SvnUriTarget(tbRepoURI.Text);
                    
                    //this is the where 'svn checkout' actually happens.
          
                   if (client.CheckOut(target, path, args, out result))
                        MessageBox.Show("Successfully checked out revision " + result.Revision + ".");
                }
                catch (SvnException se)
                {
                    MessageBox.Show(se.Message,
                    "svn checkout error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (UriFormatException ufe)
                {
                    MessageBox.Show(ufe.Message,
                    "svn checkout error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

    }
}
