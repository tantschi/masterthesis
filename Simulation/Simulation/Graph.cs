using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.Collections.Specialized;
using System.IO;

// library: http://www.codeproject.com/Articles/5431/A-flexible-charting-library-for-NET
namespace Simulation
{
    public partial class Graph : Form
    {
        Form startingForm;
        NameValueCollection _col;
        String _type;

        public Graph(Form f, NameValueCollection col, String type)
        {
            InitializeComponent();
            startingForm = f;
            _col = col;
            _type = type;
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            // Setup the graph
            if (_type == "curve")
            {
                this.Text = "Curve"; // set window title
                CreateLineGraph(zedGraphControl1);    
            }
            else if (_type == "pie")
            {
                this.Text = "Pie"; 
                CreatePieGraph(zedGraphControl1);  
            }
            else if (_type == "bar")
            {
                this.Text = "Bars"; 
                CreateBarGraph(zedGraphControl1);
            }
            
            // Size the control to fill the form with a margin
            SetSize();
        }

        // read from file
        private NameValueCollection ReadfromFile(String dest)
        {
            String text;
            NameValueCollection col = new NameValueCollection();

            using (StreamReader sr = new StreamReader(dest))
            {
                while (sr.Peek() >= 0)
                {
                    text = sr.ReadLine();
                    String[] split = text.Split(';');
                    col.Add(split[0], split[1]);
                }
                sr.Close();
            }

            return col;
        }

        // Build the Curve
        private void CreateLineGraph(ZedGraphControl zgc)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;
            DateTime datefrom = new DateTime(9999, 1, 1);
            DateTime dateto = new DateTime(1900, 1, 1);
            Random randonGen = new Random();

            // for each sensor stream
            for (int i = 0; i < _col.Count; i++)
            {
                PointPairList list1 = new PointPairList();
                String desc = _col.Keys[i];
                NameValueCollection col_data = ReadfromFile(_col[_col.Keys[i]]);

                // for each timestamp
                for (int k = 0; k < col_data.Count; k++)
                {
                    double data = Convert.ToDouble(col_data[col_data.Keys[k]]);
                    list1.Add(k, data);

                    // store description
                    DateTime test = Convert.ToDateTime(col_data.Keys[k]);

                    if (test < datefrom)
                    {
                        datefrom = test;
                    }

                    if (test > dateto)
                    {
                        dateto = test;
                    }     
                }

                // Create Curve
                Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),randonGen.Next(255));
                LineItem myCurve = myPane.AddCurve(desc, list1, randomColor, SymbolType.Diamond);
            }

            // Set the Titles
            myPane.Title.Text = ((Visual)startingForm).tbdesc.Text + " over Time";
            myPane.XAxis.Title.Text = "Time [" + datefrom.ToString() + " to " + dateto.ToString() + "]";
            myPane.YAxis.Title.Text = ((Visual)startingForm).tbdesc.Text;            

            // Tell ZedGraph to refigure the axes since the data have changed
            zgc.AxisChange();
        }

        // Sort a NameValueCollection according to the key
        private NameValueCollection sortList(NameValueCollection col)
        {
            NameValueCollection optionInfoListSorted = new NameValueCollection();
            String[] sortedKeys = col.AllKeys;
            Array.Sort(sortedKeys);

            foreach (String key in sortedKeys)
            {
                optionInfoListSorted.Add(key, col[key]);
            }

            return optionInfoListSorted;
        }

        // Build the Pie Graph
        private void CreatePieGraph(ZedGraphControl zgc)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;
            DateTime datefrom = new DateTime(9999, 1, 1);
            DateTime dateto = new DateTime(1900, 1, 1);
            Random randonGen = new Random();
            NameValueCollection list1 = new NameValueCollection();
            Boolean flag;

            // for each sensor stream
            for (int i = 0; i < _col.Count; i++)
            { 
                String desc = _col.Keys[i];

                // import data
                NameValueCollection col_data = ReadfromFile(_col[_col.Keys[i]]);

                // for each timestamp
                for (int k = 0; k < col_data.Count; k++)
                {
                    flag = false;
                    string data = col_data[col_data.Keys[k]];

                    // store amount of each value in list1 for pie
                    for (int m = 0; m < list1.Count; m++)
                    {
                        if (list1.Keys[m].Contains(data) == true)
                        {
                            String temp1 = list1[list1.Keys[m]];
                            int temp = Convert.ToInt32(temp1);
                            temp++;
                            list1[list1.Keys[m]] = temp.ToString();
                            flag = true;
                            break;
                        }
                    }

                    if (flag == false)
                    {
                        list1.Add(data, "1");
                    }

                    // store description
                    DateTime test = Convert.ToDateTime(col_data.Keys[k]);

                    if (test < datefrom)
                    {
                        datefrom = test;
                    }

                    if (test > dateto)
                    {
                        dateto = test;
                    }   
                }
            }

            // Sort List
            NameValueCollection list1_sorted = sortList(list1);

            // Make Pies
            for (int k = 0; k < list1.Count; k++)
            {
                Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
                PieItem myPie = myPane.AddPieSlice(Convert.ToInt32(list1_sorted[list1_sorted.Keys[k]]), randomColor, 0, list1_sorted.Keys[k]);
            }

            // Set the Titles
            myPane.Title.Text = ((Visual)startingForm).tbdesc.Text;

            // Tell ZedGraph to refigure the axes since the data have changed
            zgc.AxisChange();
        }

        // Build the Bar Graph
        private void CreateBarGraph(ZedGraphControl zgc)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;
            DateTime datefrom = new DateTime(9999, 1, 1);
            DateTime dateto = new DateTime(1900, 1, 1);
            Random randonGen = new Random();
            List<double> data = new List<double>();

            // for each sensor stream
            for (int i = 0; i < _col.Count; i++)
            {
                String desc = _col.Keys[i];

                // import data
                NameValueCollection col_data = ReadfromFile(_col[_col.Keys[i]]);

                // for each timestamp
                for (int k = 0; k < col_data.Count; k++)
                {
                    data.Add(Convert.ToDouble(col_data[col_data.Keys[k]]));

                    // store description
                    DateTime test = Convert.ToDateTime(col_data.Keys[k]);

                    if (test < datefrom)
                    {
                        datefrom = test;
                    }

                    if (test > dateto)
                    {
                        dateto = test;
                    }
                }
                
                // Set the Bar
                double[] data2 = data.ToArray();
                Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
                BarItem myPie = myPane.AddBar(desc, null, data2, randomColor);
            }

            // Set the Titles
            myPane.Title.Text = ((Visual)startingForm).tbdesc.Text + " over Time";
            myPane.XAxis.Title.Text = "Time [" + datefrom.ToString() + " to " + dateto.ToString() + "]";
            myPane.YAxis.Title.Text = ((Visual)startingForm).tbdesc.Text;

            // Tell ZedGraph to refigure the axes since the data have changed
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
