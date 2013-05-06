using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Simulation
{
    public partial class Visual : Form
    {

        Form startingForm;

        public Visual(Form f)
        {
            InitializeComponent();
            startingForm = f;
            foreach (ListViewItem i in ((Start)startingForm).lvdata.Items)
            {
                if (i.Checked == true)
                {
                    tbdesc.Text = i.Text;
                    tbdestination.Text = i.SubItems[2].Text;
                }
            }
            ReadfromFile(tbdestination.Text);
        }

        // open visualization
        private void btshow_Click(object sender, EventArgs e)
        {
            if (rbvisual1.Checked == true)
            {
                Graph mygraph = new Graph(this);
                mygraph.ShowDialog();
            }
        }

        // read subversion file
        private void ReadfromFile(String dest)
        {
            String text;
            lvdata.Items.Clear();
            
            using (StreamReader sr = new StreamReader(dest))
            {
                while (sr.Peek() >= 0)
                {
                    text = sr.ReadLine();
                    String[] split = text.Split(';');
                    ListViewItem item = new ListViewItem();
                    item.Text = split[0];
                    item.SubItems.Add(split[1]);
                    lvdata.Items.Add(item);
                }
                sr.Close();
            }
        }

        // refresh view
        private void btrefresh_Click(object sender, EventArgs e)
        {
            ReadfromFile(tbdestination.Text);
        }

        private void Visual_Load(object sender, EventArgs e)
        {

        }
    }
}
