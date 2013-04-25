using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

using SharpSvn;

namespace SharpSvnExample
{
    /// <summary>
    /// Simple example of using SharpSvn to populate a very simple
    /// Subversion log viewer.
    /// </summary>
    public partial class LogViewerDialog : Form
    {
        private List<string> tooltips = new List<string>();
        Queue<SvnLogEventArgs> logItems = new Queue<SvnLogEventArgs>();
        readonly object instanceLock = new object();
        private delegate void LogRetriever();
        delegate void PopulateHandler();

        /// <summary>
        /// Constructor.
        /// </summary>
        public LogViewerDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the "Clear" button click.
        /// </summary>
        /// <para>Clears the contents of the Path text box.</para>
        private void clearButton_Click(object sender, EventArgs e)
        {
            pathTextBox.Clear();
        }

        /// <summary>
        /// Handles the text changed event for the Path text box.
        /// </summary>
        /// <para>Enables/disables the "Clear" and "Retrieve" buttons
        /// based on whether or not there is content in the text box.</para>
        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {
            toggleButtons();
        }

        /// <summary>
        /// Handles the "Retrieve" button click.
        /// </summary>
        /// <para>Asyncronously retrieves the log entries and renders them
        /// in the DataGridView.</para>
        private void retrieveButton_Click(object sender, EventArgs e)
        {
            clearButton.Enabled = false;
            retrieveButton.Enabled = false;

            LogRetriever retriever = new LogRetriever(retrieveAndRenderLog);


            retriever.BeginInvoke(new AsyncCallback(LogDone), null);
            
        }

        /// <summary>
        /// Handles the tooltips for all cells
        /// </summary>
        /// <para>Mimics the effect of having a tooltip per row but really
        /// sets the tooltip for each cell that gets moused over.</para>
        private void logGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewCell col = logGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (string.IsNullOrEmpty(col.ToolTipText))
                    col.ToolTipText = tooltips[e.RowIndex];
            }
        }

        /// <summary>
        /// Toggles the "Clear" and "Retrieve" buttons based on the
        /// contents of the Path text box.
        /// </summary>
        public void toggleButtons()
        {
            /// Handle the clear button
            if (pathTextBox.Text.Length > 0)
            {
                clearButton.Enabled = true;
            }
            else
            {
                clearButton.Enabled = false;
            }

            /// Handle the retrieve button
            if (clearButton.Enabled)
            {
                retrieveButton.Enabled = true;
            }
            else
            {
                retrieveButton.Enabled = false;
            }
        }

        /// <summary>
        /// Asynchronous callback.
        /// </summary>
        void LogDone(IAsyncResult rslt)
        {
            InvokePopulateGrid();
        }

        /// <summary>
        /// Decides whether to populate the DataGridView on the current thread
        /// or by invoking another thread.
        /// </summary>
        void InvokePopulateGrid()
        {
            if (InvokeRequired) // this is not the UI thread, and needs invoking
                Invoke(new PopulateHandler(PopulateProcessGrid));
            else // this is the UI thread, call directly
                PopulateProcessGrid();
        }

        /// <summary>
        /// Populates the DataGridView with the Subversion log entries.
        /// </summary>
        void PopulateProcessGrid()
        {
            lock (instanceLock) // Queue isn't thread-safe, let's lock
            {
                while (logItems.Count > 0)
                {
                    SvnLogEventArgs le = logItems.Dequeue();
                    string[] row = new string[4];

                    row[0] = le.Revision.ToString();
                    row[1] = le.Time.ToLocalTime().ToShortDateString();
                    row[2] = le.Author.ToString();
                    row[3] = le.LogMessage.ToString();

                    logGridView.Rows.Add(row);
                }
            }

            toggleButtons();
        }

        /// <summary>
        /// Retrieves the Subversion log entries and potentially updates the
        /// DataGridView in a streaming fashion.
        /// </summary>
        private void retrieveAndRenderLog()
        {
            string targetPath = pathTextBox.Text;
            SvnTarget target;

            if (string.IsNullOrEmpty(targetPath) ||
                !SvnTarget.TryParse(targetPath, out target))
            {
                MessageBox.Show(this, "The path you've specified is not valid.  " +
                    "Please provide a valid URL or filesystem path pointing to " +
                    "a Subversion resource.",
                    "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                logGridView.Rows.Clear();

                // SvnClient is disposable, using makes sure it's disposed every time
                using (SvnClient client = new SvnClient())
                {
                    SharpSvn.UI.SharpSvnUI.Bind(client, this);

                    try
                    {
                        client.Log(target,
                        delegate(object lSender, SvnLogEventArgs le)
                        {
                            le.Detach(); // detach from client
                            lock (instanceLock) // Queue isn't thread-safe, let's lock
                            {
                                logItems.Enqueue(le);
                            }

                            // Optionally add items in a streaming way on the other thread
                            InvokePopulateGrid();

                            StringBuilder tooltip = new StringBuilder();

                            tooltip.AppendLine("Changed Paths:");

                            foreach (SvnChangeItem path in le.ChangedPaths)
                            {
                                tooltip.AppendLine("");
                                tooltip.Append(path.Action + " " + path.Path);

                                if (path.CopyFromRevision != -1)
                                    tooltip.Append(" (" + path.CopyFromPath +
                                        "[" + path.CopyFromRevision + "])");
                            }

                            tooltips.Add(tooltip.ToString());
                        });
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(this, exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}