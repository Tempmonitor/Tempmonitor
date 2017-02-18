using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HidLibrary;

namespace TempmonitorHost
{

    public partial class mainform : Form
    {
        // ID ---
        private const int VendorId = 0x1209;
        private const int productId = 0x3452;
        // ID ---

        private ComputerInfo computer = new ComputerInfo();

        HidDevice device;

        public mainform()
        {
            InitializeComponent();

            userSettingsLoad();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void openHideToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.Visible)
                this.Hide();
            else
                this.Show();
        }

        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Do you want to only hide the form?", "Form closing", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    e.Cancel = true;
                    Hide();

                    //Return so that userSettings isn't written
                    return;
                }
            }

            userSettingsWrite();
            Application.Exit();
        }

        private void userSettingsLoad()
        {
            checkBox_Autostart.Checked = Properties.Settings.Default.AutoRun;;
            checkBox_ToggleDisplay.Checked = Properties.Settings.Default.DispOn;
            slider_Brightness.Value = Properties.Settings.Default.Brightness;

            comboBox_Disp1Data.Text = Properties.Settings.Default.Disp1Data;
            comboBox_Disp2Data.Text = Properties.Settings.Default.Disp2Data;
            comboBox_Disp3Data.Text = Properties.Settings.Default.Disp3Data;
            comboBox_Disp4Data.Text = Properties.Settings.Default.Disp4Data;
        }

        private void userSettingsWrite()
        {
            Properties.Settings.Default.AutoRun = checkBox_Autostart.Checked;
            Properties.Settings.Default.DispOn = checkBox_ToggleDisplay.Checked;
            Properties.Settings.Default.Brightness = slider_Brightness.Value;


            Properties.Settings.Default.Disp1Data = comboBox_Disp1Data.Text;
            Properties.Settings.Default.Disp2Data = comboBox_Disp2Data.Text;
            Properties.Settings.Default.Disp3Data = comboBox_Disp3Data.Text;
            Properties.Settings.Default.Disp4Data = comboBox_Disp4Data.Text;

            Properties.Settings.Default.Save();
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {
            computer.Update();

            // Display sensor values in UI
            label_Disp1Value.Text = ((int) computer.get_value(comboBox_Disp1Data.Text, 1)).ToString();
            label_Disp2Value.Text = ((int) computer.get_value(comboBox_Disp2Data.Text, 1)).ToString();
            label_Disp3Value.Text = ((int) computer.get_value(comboBox_Disp3Data.Text, 1)).ToString();
            label_Disp4Value.Text = ((int) computer.get_value(comboBox_Disp4Data.Text, 1)).ToString();

            if (device == null || device.IsConnected == false)    // If no connection
            {
                toolStripStatusLabel_connection.Text = "Disconnected";
                notifyIcon.Text = "Disconnected";

                device = HidDevices.Enumerate(VendorId, productId).FirstOrDefault();   // Retry connection

                if (device != null && device.IsConnected != false)  // If reconnection successful
                {
                    device.OpenDevice();
                    toolStripStatusLabel_connection.Text = "Connected";
                    notifyIcon.Text = "Connected";
                }
            }

            else   // Actual execution
            {
                byte[] outdata = new byte[8];

                // Send data
                outdata[2] = (byte) slider_Brightness.Value;
                outdata[3] = (byte) computer.get_value(comboBox_Disp1Data.Text, 1);
                outdata[4] = (byte) computer.get_value(comboBox_Disp2Data.Text, 1);
                outdata[5] = (byte) computer.get_value(comboBox_Disp3Data.Text, 1);
                outdata[6] = (byte) computer.get_value(comboBox_Disp4Data.Text, 1);
               
                // Can't send zeros, convert these to 255 instead 
                for(int x = 0; x != 8; x++)
                {
                    if(outdata[x] == 0)
                    {
                        outdata[x] = 255;
                    }
                }

                if(!checkBox_ToggleDisplay.Checked)
                {
                    outdata[2] = 5;
                }

                HidReport report = new HidReport(8, new HidDeviceData(outdata, HidDeviceData.ReadStatus.NotConnected));
                device.WriteFeatureData(outdata);
            }
        }

        private void checkBox_Autostart_CheckedChanged(object sender, EventArgs e)
        {
            Autostart start = new Autostart();

            if (checkBox_Autostart.Checked)
            {
                start.CreateTask();
            }
            else
            {
                start.RemoveTask();
            }
        }
    }
}