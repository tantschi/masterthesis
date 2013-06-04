using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace Simulation
{
    public partial class Visual : Form
    {

        Form _startingForm;
        NameValueCollection _col;

        public Visual(Form f)
        {
            InitializeComponent();
            _startingForm = f;

            _col = check_amount();

            if (_col.Count == 1)
            {
                tbdesc.Text = _col.Keys[0];
                tbdestination.Text = _col[_col.Keys[0]];                
                ReadfromFile(tbdestination.Text);
            }
            else
            {
                for (int i = 0; i < _col.Count; i++)
                {
                    if (tbdesc.Text == "")
                    {
                        tbdesc.Text = _col.Keys[i];
                    }
                    else
                    {
                        tbdesc.Text = tbdesc.Text + ", " + _col.Keys[i];
                        tbdestination.Text = "More than one sensor selected - no data displayed";
                    }
                }
            }
        }

        // count amount of checked data
        private NameValueCollection check_amount()
        {
            Int16 count = 0;

            NameValueCollection col = new NameValueCollection();

            foreach (ListViewItem i in ((Start)_startingForm).lvdata.Items)
            {
                if (i.Checked == true)
                {
                    col.Add(i.Text, i.SubItems[2].Text);
                    count++;
                }
            }

            return col;
        }

        // open visualization
        private void btshow_Click(object sender, EventArgs e)
        {
            _col = check_amount();

            if (tbdestination.Text == "Loading Failure - please try again!")
            {
                MessageBox.Show("Loading Failure - Please check input values!");
                return;
            }

            if (_col.Count == 0)
            {
                MessageBox.Show("No item selected!");
                return;
            }

            if (rbvisual1.Checked == true)
            {
                Graph mygraph = new Graph(this, _col, "curve");
                mygraph.ShowDialog();
            }
            else if (rbpiechart.Checked == true)
            {
                Graph mygraph = new Graph(this, _col, "pie");
                mygraph.ShowDialog();
            }
            else if (rbbars.Checked == true)
            {
                Graph mygraph = new Graph(this, _col, "bar");
                mygraph.ShowDialog();
            }
        }

        // read file
        private void ReadfromFile(String dest)
        {
            String text = "";
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
            if (tbdestination.Text != "More than one sensor selected - no data displayed" &&
                tbdestination.Text != "Loading Failure - please try again!")
            {
                ReadfromFile(tbdestination.Text);
            }
        }

        private void Visual_Load(object sender, EventArgs e)
        {

        }

        private void btsave_Click(object sender, EventArgs e)
        {
            // open new dialog
            _col = check_amount();
            Save saveFrm = new Save(tbdesc.Text, _col, _startingForm);
            saveFrm.ShowDialog();
        }

        private void btload_Click(object sender, EventArgs e)
        {
            // open new dialog
            Load loadFrm = new Load(_startingForm, this);
            loadFrm.ShowDialog();
            btrefresh_Click(sender, e);

            //tbdestination.Text
        }

        private void tbdestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvdata_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btcancel_Click(object sender, EventArgs e)
        {

        }
    }
}
