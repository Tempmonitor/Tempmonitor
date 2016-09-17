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
    }
}
