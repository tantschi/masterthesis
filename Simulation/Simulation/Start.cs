﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.Collections.Specialized;

namespace Simulation
{
    public partial class Start : Form
    {

        // store default values
        string _config = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\Simulation\\Simulation\\bin\\Debug\\Simulation.exe";
        public string repo = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\Github\\codegoogle_thesis_svn"; 
        public string install = "D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructService\\MetaConstructService\\bin\\Debug\\Install.cmd";
        public string uninstall="D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructService\\MetaConstructService\\bin\\Debug\\Uninstall.cmd";
        public string config="D:\\04_Semester\\Masterarbeit_Hawaii_Stuff\\Praxis\\C#Workspace\\MetaConstructService\\MetaConstructService\\bin\\Debug\\MetaConstructService.exe";

        public Start()
        {
            InitializeComponent();
            LoadConfigurationValue();
        }

        // ad a new sensor
        private void btadd_Click(object sender, EventArgs e)
        {
            // open new dialoge
            Add addFrm = new Add(this);
            addFrm.ShowDialog();
        }

        // close application
        private void btclose_Click(object sender, EventArgs e)
        {
            save_settings();
            Application.Exit();
        }

        // save settings for next restart
        private void save_settings()
        {
            // delete old data
            DeleteConfigurationValue();

            // store settings in configuration file
            foreach (ListViewItem i in lvdata.Items)
            {
                if (i.SubItems[1].Text.Contains("Sensor"))
                {
                    AddConfigurationValue("Config_Sensor_" + i.Text, i.SubItems[2].Text);

                }
                else
                {
                    AddConfigurationValue("Config_Construct_" + i.Text, i.SubItems[2].Text);
                }
            }
        }

        // add configuration
        private void AddConfigurationValue(String key, String value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(_config);

            // check if key already exists
            foreach (String loopkey in config.AppSettings.Settings.AllKeys)
            {
                if (loopkey.Contains(key))
                {
                    config.AppSettings.Settings.Remove(loopkey);
                }
            }

            config.AppSettings.Settings.Add(key, value);
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        // Delete configuration for Service
        private void DeleteConfigurationValue()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(_config);

            foreach (String key in configuration.AppSettings.Settings.AllKeys)
            {
                if (key.Contains("Config_"))
                {
                    configuration.AppSettings.Settings.Remove(key);
                }
            }

            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        // load configuration (on startup)
        private void LoadConfigurationValue()
        {            
            NameValueCollection col = ConfigurationManager.AppSettings;
            for (int i = 0; i < col.Count; i++)
            {

                if (col.Keys[i].Contains("Config_"))
                {
                    ListViewItem item = new ListViewItem();
                    item.Checked = false;
                    String key = col.Keys[i].Remove(0,7);

                    if (key.Contains("Sensor"))
                    {
                        item.Text = key.Remove(0, 7);
                        item.SubItems.Add("Sensor");
                        item.SubItems.Add(col[col.Keys[i]]);
                        lvdata.Items.Add(item);
                    }
                    else
                    {
                        item.Text = key.Remove(0, 10);
                        item.SubItems.Add("Construct");
                        item.SubItems.Add(col[col.Keys[i]]);
                        lvdata.Items.Add(item);
                    }
                }
            }
        }

        // check if at least one list view item is checked
        private bool controlchecked()
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

            return ischecked;
        }

        // link sensors or constructs
        private void btlink_Click(object sender, EventArgs e)
        {
            bool ischecked = controlchecked();
            if (ischecked == false)
            {
                MessageBox.Show("Please check an sensor or construct for linking!", "Check item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
          
            // open new dialoge
            Link linkFrm = new Link(this);
            linkFrm.ShowDialog();
        }

        // start visualization
        private void btvisual_Click(object sender, EventArgs e)
        {
            bool ischecked = controlchecked();
            if (ischecked == false)
            {
                MessageBox.Show("Please check at least one sensor or construct to show!", "Check item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // open new dialoge
            Visual linkFrm = new Visual(this);
            linkFrm.ShowDialog();
        }

        // delete checked constructs or sensors
        private void btdelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvdata.Items)
            {
                if (i.Checked == true)
                {
                    // if a construct is deleted, the windows service has to be stopped too!
                    if (i.SubItems[1].Text == "Construct")
                    {
                        MyService ms = new MyService(repo, install, uninstall, config);
                        ms.stopService("Simulation" + lbvcs.Text + "_" + i.SubItems[0].Text);
                    }
                    i.Remove();
                }
            }
        }

        // change settings of system (selected VCS)
        private void btsettings_Click(object sender, EventArgs e)
        {
            // open new dialog
            Settings settingsFrm = new Settings(this);
            settingsFrm.ShowDialog();
        }

        // store settings if form is closed
        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            save_settings();
        }

        // edit a sensor (description or path)
        private void btedit_Click(object sender, EventArgs e)
        {
            if (lvdata.CheckedItems.Count != 1)
            {
                MessageBox.Show("Please select one item to edit!", "Check only one item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (ListViewItem i in lvdata.Items)
            {
                if (i.Checked == true)
                {
                    // It is not allowed to edit constructs, because 
                    // of the windows service in the background
                    if (i.SubItems[2].Text.Contains("Construct"))
                    {
                        MessageBox.Show("Only Sensors (not constructs) can be edited!", "Check a sensor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // open new dialog
                    Edit editFrm = new Edit(this, i.SubItems[2].Text, i.Text);
                    editFrm.ShowDialog();
                    break;
                }
            }
        }
    }
}
