using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

// library: http://www.codeproject.com/Articles/5431/A-flexible-charting-library-for-NET
namespace Simulation
{
    public partial class Graph : Form
    {
        Form startingForm;

        public Graph(Form f)
        {
            InitializeComponent();
            startingForm = f;
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            // Setup the graph
            CreateGraph(zedGraphControl1);
            // Size the control to fill the form with a margin
            SetSize();

        }

        // Build the Chart
        private void CreateGraph(ZedGraphControl zgc)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;
            String from = "";
            String to = "";
            String desc = ((Visual)startingForm).tbdesc.Text;
            double x = 0;
            PointPairList list1 = new PointPairList();

            foreach (ListViewItem i in ((Visual)startingForm).lvdata.Items)
            {
                double data = Convert.ToDouble(i.SubItems[1].Text);
                list1.Add(x, data);
                if (x == 0)
                {
                    from = i.Text;
                }
                to = i.Text;
                x += 1;
            }

            // Set the Titles
            myPane.Title.Text = desc + " over Time";
            myPane.XAxis.Title.Text = "Time [" + from + " to " + to + "]";
            myPane.YAxis.Title.Text = desc;

            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            LineItem myCurve = myPane.AddCurve(desc,list1, Color.Red, SymbolType.Diamond);

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zgc.AxisChange();
        }

        private void Graph_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        // SetSize() is separate from Resize() so we can 
        // call it independently from the Form1_Load() method
        // This leaves a 10 px margin around the outside of the control
        // Customize this to fit your needs
        private void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zedGraphControl1.Size = new Size(ClientRectangle.Width - 20,
                                    ClientRectangle.Height - 20);
        }
    }
}
