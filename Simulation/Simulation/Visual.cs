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
            foreach (ListViewItem i in ((Form1)startingForm).lvdata.Items)
            {
                if (i.Checked == true)
                {
                    tbdesc.Text = i.Text;
                    tbdestination.Text = i.SubItems[2].Text;
                }
            }
            tintervall.Start();
        }

        private void btshow_Click(object sender, EventArgs e)
        {

        }

        private void tbdestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadfromFile(String dest)
        {
            String text;
            ListViewItem item = new ListViewItem();
            using (StreamReader sw = new StreamReader(dest))
            {
                text = sw.ReadLine();
                item.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                item.SubItems.Add(text);
                lvdata.Items.Add(item);
                sw.Close();
            }

        }


        private void tintervall_Tick(object sender, EventArgs e)
        {
            //superversion update
            // read from file
            ReadfromFile(tbdestination.Text);


        }




    }
}
