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

        private void btnGo_Click(object sender, EventArgs e)
        {
            object command = cbCmdList.SelectedItem;
            if (command == null) //If the combo box was empty
            {
                MessageBox.Show("Please select an SVN command from the pull down menu.");
                return;
            }
            switch (command.ToString())
            {
                case "svn checkout": //Open the svn checkout box
                    frmCheckout checkOutFrm = new frmCheckout();
                    checkOutFrm.ShowDialog();
                    break;
                case "svn commit": //Open the svn commit form
                    frmCommit commitForm = new frmCommit();
                    commitForm.ShowDialog();
                    break;
                case "svn proplist": //Open the svn proplist form
                    frmPropList propListForm = new frmPropList();
                    propListForm.ShowDialog();
                    break;
                default: //User probably typed something invalid
                    MessageBox.Show("Please select a valid SVN command from the pull down menu.");
                    break;
            }
        }
    }
}
