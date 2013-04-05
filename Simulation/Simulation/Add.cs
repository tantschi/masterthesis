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

        private void btcancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Checked = false;
            item.Text = tbdescription.Text;
            item.SubItems.Add("Sensor");
            item.SubItems.Add(tblocaldest.Text);
            ((Form1)startingForm).lvdata.Items.Add(item);
            this.Close();
        }
    }
}
