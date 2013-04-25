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
    public partial class frmPropList : Form
    {
        public frmPropList()
        {
            InitializeComponent();
        }

        private void btnGetProps_Click(object sender, EventArgs e)
        {
            if (tbFileURI.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid file URI in the 'File URI:' box.");
                return;
            }

            //Clear out the list view for the next list of properties
            lvProps.Items.Clear();

            //This will be the target file from which we are retrieving properties
            SvnTarget tgt = SvnTarget.FromString(tbFileURI.Text);

            //This collection will contain property collections for each node
            System.Collections.ObjectModel.Collection<SvnPropertyListEventArgs> proplist;

            //This is where we can specify arguments to svn proplist
            SvnPropertyListArgs args = new SvnPropertyListArgs();

            if (cbRecurse.Checked == true)
            {
                //This will cause GetPropertyList to get properties recursively.
                args.Depth = SvnDepth.Infinity;
            }

            using (SharpSvn.SvnClient client = new SharpSvn.SvnClient())
            {
                try
                {
                    //This method is what executes svn proplist
                    client.GetPropertyList(tgt, args, out proplist);

                    //Each SvnPropertyListEventArgs represents the prop. set for a node
                    foreach (SvnPropertyListEventArgs node in proplist)
                    {
                        //Each SvnPropertyValue represents a single name/value property pair
                        foreach (SvnPropertyValue propVal in node.Properties)
                        {
                            ListViewItem entry = new ListViewItem(node.Path);
                            entry.SubItems.Add(propVal.Key);
                            entry.SubItems.Add(propVal.StringValue);
                            lvProps.Items.Add(entry);
                        }
                    }
                    //refresh the column sizes
                    for (int i = 0; i < 3; i++) lvProps.Columns[i].Width = -2;
                }
                catch (SvnException se)
                {
                    MessageBox.Show(se.Message + Environment.NewLine +
                    "Error:" + se.SvnErrorCode,
                    "svn proplist error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        } 

    }
}
