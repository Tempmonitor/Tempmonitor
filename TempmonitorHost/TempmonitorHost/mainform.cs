using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempmonitorHost
{

    public partial class mainform : Form
    {
           
        public mainform()
        {
            InitializeComponent();

            userSettingsLoad();            
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(5000, "Temp monitor", "Temp monitor is running.", ToolTipIcon.Info);
            
            //Load user data
            //Connect to display
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void openHideToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.Visible)
            {
                this.Hide();
                notifyIcon.ShowBalloonTip(5000, "Temp monitor", "Temp monitor is running in background.", ToolTipIcon.Info); 
            }
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
            
        }

        private void userSettingsLoad()
        {
            checkBox_Autostart.Checked = Properties.Settings.Default.AutoRun;
            checkBox_Disp1Ena.Checked = Properties.Settings.Default.EnableDisp1;
            checkBox_Disp2Ena.Checked = Properties.Settings.Default.EnableDisp2;
            checkBox_Disp3Ena.Checked = Properties.Settings.Default.EnableDisp3;
            checkBox_Disp4Ena.Checked = Properties.Settings.Default.EnableDisp4;
            checkBox_ToggleDisplay.Checked = Properties.Settings.Default.DispOn;

            comboBox_Disp1Data.Text = Properties.Settings.Default.Disp1Data;
            comboBox_Disp2Data.Text = Properties.Settings.Default.Disp2Data;
            comboBox_Disp3Data.Text = Properties.Settings.Default.Disp3Data;
            comboBox_Disp4Data.Text = Properties.Settings.Default.Disp4Data;
        }

        private void userSettingsWrite()
        {
            Properties.Settings.Default.AutoRun = checkBox_Autostart.Checked;
            Properties.Settings.Default.EnableDisp1 = checkBox_Disp1Ena.Checked;
            Properties.Settings.Default.EnableDisp2 = checkBox_Disp2Ena.Checked;
            Properties.Settings.Default.EnableDisp3 = checkBox_Disp3Ena.Checked;
            Properties.Settings.Default.EnableDisp4 = checkBox_Disp4Ena.Checked;
            Properties.Settings.Default.DispOn = checkBox_ToggleDisplay.Checked;

            Properties.Settings.Default.Disp1Data = comboBox_Disp1Data.Text;
            Properties.Settings.Default.Disp2Data = comboBox_Disp2Data.Text;
            Properties.Settings.Default.Disp3Data = comboBox_Disp3Data.Text;
            Properties.Settings.Default.Disp4Data = comboBox_Disp4Data.Text;

            Properties.Settings.Default.Save();
        }

        private void button_RestoreDefaults_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            userSettingsLoad();
        }
    }
}