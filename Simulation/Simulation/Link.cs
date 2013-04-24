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
                if (i.Checked == true)
                {
                    if (link == "")
                        link = i.Text;
                    else
                        link =  link + " + " + i.Text;
                }
            }
            tblink.Text = link;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            if (tbdest.Text == "" || tbadd.Text == "" || tblink.Text == "")
                MessageBox.Show("Please enter information in every field!");
            
            ListViewItem item = new ListViewItem();
            item.Checked = false;
            item.Text = tbadd.Text;
            item.SubItems.Add("Construct");
            item.SubItems.Add(tbdest.Text);
            ((Form1)startingForm).lvdata.Items.Add(item);


            MyService ms = new MyService();
            ms.installService("Simulation_" + tbadd.Text);
            //ms.startService();

            MySubversion svn = new MySubversion();
            svn.addSubversion(tbdest.Text, tblink.Text, "content");
            this.Close();
        }

        private void btbrowse_Click(object sender, EventArgs e)
        {
            if (ofdselector.ShowDialog() == DialogResult.OK)
            {
                tbdest.Text = ofdselector.FileName;
            }
        }

    }
}
