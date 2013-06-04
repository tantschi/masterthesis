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
    public partial class Add : Form
    {

        Form startingForm;

        public Add(Form f)
        {
            InitializeComponent();
            startingForm = f;
        }

        private void btadd_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem i in ((Start)startingForm).lvdata.Items)
            {
                // Name of sensor has to be unique!
                if (i.Text == tbdescription.Text)
                {
                    MessageBox.Show("Please give the sensor a unique name!", "Name sensor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbdescription.Focus();
                    return;
                }
            } 
            
            // Add sensor to list
            ListViewItem item = new ListViewItem();
            item.Checked = false;
            item.Text = tbdescription.Text;
            item.SubItems.Add("Sensor");
            item.SubItems.Add(tblocaldest.Text);
            ((Start)startingForm).lvdata.Items.Add(item);
            this.Close();
        }

        private void btbrowse_Click_1(object sender, EventArgs e)
        {
            if (ofdselector.ShowDialog() == DialogResult.OK)
            {
                tblocaldest.Text = ofdselector.FileName;
            }
        }

    }
}
