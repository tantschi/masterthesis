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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add addFrm = new Add(this);
            addFrm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
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
          
            Link linkFrm = new Link(this);
            linkFrm.ShowDialog();
        }

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
            if (count == 1)
            {
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

        private void btdelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvdata.Items)
            {
           
                if (i.SubItems[1].Text == "Construct")
                {
                    MyService ms = new MyService();
                    ms.stopService("Simulation_" + i.SubItems[0].Text);

                }

                if (i.Checked == true)
                {
                    i.Remove();
                }

            }
        }




    }
}
