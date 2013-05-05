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
    public partial class Link : Form
    {
        Form startingForm;

        public Link(Form f)
        {
            InitializeComponent();
            startingForm = f;

            String link = "";

            foreach (ListViewItem i in ((Form1)startingForm).lvdata.Items)
            {
                // Link each construct with + (= standard setting)
                if (i.Checked == true)
                {
                    if (link == "")
                        link = i.Text;
                    else
                        link =  link + " + " + i.Text;

                    i.Checked = false; // remove checked
                }
            }
            tblink.Text = link;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // add new link (= construct) to sensor system
        private void btadd_Click(object sender, EventArgs e)
        {
            if (tbdest.Text == "" || tbadd.Text == "" || tblink.Text == "")
                MessageBox.Show("Please enter information in every field!");
            
            // add new construct to sensor list
            ListViewItem item = new ListViewItem();
            item.Checked = false;
            item.Text = tbadd.Text;
            item.SubItems.Add("Construct");
            item.SubItems.Add(tbdest.Text);
            ((Form1)startingForm).lvdata.Items.Add(item);

            // start windows service
            MyService ms = new MyService();
            String servicename = "Simulation_" + tbadd.Text;
            ms.installService(servicename, tbdest.Text, tblink.Text, tbseconds.Text);
            ms.startService(servicename);

            this.Close();
        }

        // chose SVN destination for sensor
        private void btbrowse_Click(object sender, EventArgs e)
        {
            if (ofdselector.ShowDialog() == DialogResult.OK)
            {
                tbdest.Text = ofdselector.FileName;
            }
        }

    }
}
