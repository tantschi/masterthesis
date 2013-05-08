using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Simulation
{
    public partial class Start : Form
    {

        public string repo = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Github\\codegoogle_thesis_svn"; 
        public string install = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructService\\MetaConstructService\\bin\\Debug\\Install.cmd";
        public string uninstall="D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructService\\MetaConstructService\\bin\\Debug\\Uninstall.cmd";
        public string config="D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructService\\MetaConstructService\\bin\\Debug\\MetaConstructService.exe";

        public Start()
        {
            InitializeComponent();
        }

        // ad a new sensor
        private void btadd_Click(object sender, EventArgs e)
        {
            Add addFrm = new Add(this);
            addFrm.ShowDialog();
        }

        // close application
        private void btclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // link sensors or constructs
        private void btlink_Click(object sender, EventArgs e)
        {
            bool ischecked = false;
            foreach (ListViewItem i in lvdata.Items)
            {
                if (i.Checked == true)
                {
                    ischecked = true;
                    break;
                }
            }

            if (ischecked == false)
            {
                MessageBox.Show("Please check an sensor or construct for linking!");
                return;
            }
          
            // open new dialoge
            Link linkFrm = new Link(this);
            linkFrm.ShowDialog();
        }

        // start visualization
        private void btvisual_Click(object sender, EventArgs e)
        {
            Int16 count = 0;

            foreach (ListViewItem i in lvdata.Items)
            {
                if (i.Checked == true)
                {
                    count++;
                }
            }

            // only one sensor/construct is allowed to be selected
            if (count == 1)
            {
                // open new dialog
                Visual linkFrm = new Visual(this);
                linkFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select one sensor or construct to show!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // delete checked constructs or sensors
        private void btdelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvdata.Items)
            {
                if (i.Checked == true)
                {
                    if (i.SubItems[1].Text == "Construct")
                    {
                        MyService ms = new MyService(repo, install, uninstall, config);
                        ms.stopService("Simulation_" + i.SubItems[0].Text);
                    }

                    i.Remove();
                }
            }
        }

        private void btsettings_Click(object sender, EventArgs e)
        {
            // open new dialog
            Settings settingsFrm = new Settings(this);
            settingsFrm.ShowDialog();
        }
    }
}
