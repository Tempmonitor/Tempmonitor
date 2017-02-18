namespace TempmonitorHost
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_connection = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_update = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_notifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_Disp1Data = new System.Windows.Forms.ComboBox();
            this.label_Disp1Num = new System.Windows.Forms.Label();
            this.label_Disp2Num = new System.Windows.Forms.Label();
            this.comboBox_Disp2Data = new System.Windows.Forms.ComboBox();
            this.label_Disp3Num = new System.Windows.Forms.Label();
            this.comboBox_Disp3Data = new System.Windows.Forms.ComboBox();
            this.label_Disp4Num = new System.Windows.Forms.Label();
            this.comboBox_Disp4Data = new System.Windows.Forms.ComboBox();
            this.checkBox_Autostart = new System.Windows.Forms.CheckBox();
            this.label_Disp1Value = new System.Windows.Forms.Label();
            this.label_Disp2Value = new System.Windows.Forms.Label();
            this.label_Disp3Value = new System.Windows.Forms.Label();
            this.label_Disp4Value = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox_ToggleDisplay = new System.Windows.Forms.CheckBox();
            this.slider_Brightness = new System.Windows.Forms.TrackBar();
            this.label_Brightness = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip_notifyIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Brightness)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_connection});
            this.statusStrip.Location = new System.Drawing.Point(0, 256);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(232, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_connection
            // 
            this.toolStripStatusLabel_connection.Name = "toolStripStatusLabel_connection";
            this.toolStripStatusLabel_connection.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel_connection.Text = "Disconnected";
            // 
            // timer_update
            // 
            this.timer_update.Enabled = true;
            this.timer_update.Interval = 1000;
            this.timer_update.Tick += new System.EventHandler(this.timer_update_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip_notifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Temp monitor";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip_notifyIcon
            // 
            this.contextMenuStrip_notifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHideToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip_notifyIcon.Name = "contextMenuStrip_notifyIcon";
            this.contextMenuStrip_notifyIcon.Size = new System.Drawing.Size(134, 54);
            // 
            // openHideToolStripMenuItem
            // 
            this.openHideToolStripMenuItem.Name = "openHideToolStripMenuItem";
            this.openHideToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openHideToolStripMenuItem.Text = "Open/Hide";
            this.openHideToolStripMenuItem.Click += new System.EventHandler(this.openHideToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // comboBox_Disp1Data
            // 
            this.comboBox_Disp1Data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Disp1Data.FormattingEnabled = true;
            this.comboBox_Disp1Data.Items.AddRange(new object[] {
            "CPU temp",
            "CPU load",
            "GPU load",
            "GPU temp",
            "RAM usage",
            "Disc usage",
            "Fan speed",
            "Battery"});
            this.comboBox_Disp1Data.Location = new System.Drawing.Point(61, 22);
            this.comboBox_Disp1Data.Name = "comboBox_Disp1Data";
            this.comboBox_Disp1Data.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Disp1Data.TabIndex = 1;
            // 
            // label_Disp1Num
            // 
            this.label_Disp1Num.AutoSize = true;
            this.label_Disp1Num.Location = new System.Drawing.Point(9, 26);
            this.label_Disp1Num.Name = "label_Disp1Num";
            this.label_Disp1Num.Size = new System.Drawing.Size(50, 13);
            this.label_Disp1Num.TabIndex = 2;
            this.label_Disp1Num.Text = "Display 1";
            // 
            // label_Disp2Num
            // 
            this.label_Disp2Num.AutoSize = true;
            this.label_Disp2Num.Location = new System.Drawing.Point(9, 53);
            this.label_Disp2Num.Name = "label_Disp2Num";
            this.label_Disp2Num.Size = new System.Drawing.Size(50, 13);
            this.label_Disp2Num.TabIndex = 5;
            this.label_Disp2Num.Text = "Display 2";
            // 
            // comboBox_Disp2Data
            // 
            this.comboBox_Disp2Data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Disp2Data.FormattingEnabled = true;
            this.comboBox_Disp2Data.Items.AddRange(new object[] {
            "CPU temp",
            "CPU load",
            "GPU load",
            "GPU temp",
            "RAM usage",
            "Disc usage",
            "Fan speed",
            "Battery"});
            this.comboBox_Disp2Data.Location = new System.Drawing.Point(61, 49);
            this.comboBox_Disp2Data.Name = "comboBox_Disp2Data";
            this.comboBox_Disp2Data.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Disp2Data.TabIndex = 4;
            // 
            // label_Disp3Num
            // 
            this.label_Disp3Num.AutoSize = true;
            this.label_Disp3Num.Location = new System.Drawing.Point(9, 80);
            this.label_Disp3Num.Name = "label_Disp3Num";
            this.label_Disp3Num.Size = new System.Drawing.Size(50, 13);
            this.label_Disp3Num.TabIndex = 8;
            this.label_Disp3Num.Text = "Display 3";
            // 
            // comboBox_Disp3Data
            // 
            this.comboBox_Disp3Data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Disp3Data.FormattingEnabled = true;
            this.comboBox_Disp3Data.Items.AddRange(new object[] {
            "CPU temp",
            "CPU load",
            "GPU load",
            "GPU temp",
            "RAM usage",
            "Disc usage",
            "Fan speed",
            "Battery"});
            this.comboBox_Disp3Data.Location = new System.Drawing.Point(61, 76);
            this.comboBox_Disp3Data.Name = "comboBox_Disp3Data";
            this.comboBox_Disp3Data.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Disp3Data.TabIndex = 7;
            // 
            // label_Disp4Num
            // 
            this.label_Disp4Num.AutoSize = true;
            this.label_Disp4Num.Location = new System.Drawing.Point(9, 107);
            this.label_Disp4Num.Name = "label_Disp4Num";
            this.label_Disp4Num.Size = new System.Drawing.Size(50, 13);
            this.label_Disp4Num.TabIndex = 11;
            this.label_Disp4Num.Text = "Display 4";
            // 
            // comboBox_Disp4Data
            // 
            this.comboBox_Disp4Data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Disp4Data.FormattingEnabled = true;
            this.comboBox_Disp4Data.Items.AddRange(new object[] {
            "CPU temp",
            "CPU load",
            "GPU load",
            "GPU temp",
            "RAM usage",
            "Disc usage",
            "Fan speed",
            "Battery"});
            this.comboBox_Disp4Data.Location = new System.Drawing.Point(61, 103);
            this.comboBox_Disp4Data.Name = "comboBox_Disp4Data";
            this.comboBox_Disp4Data.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Disp4Data.TabIndex = 10;
            // 
            // checkBox_Autostart
            // 
            this.checkBox_Autostart.AutoSize = true;
            this.checkBox_Autostart.Location = new System.Drawing.Point(12, 174);
            this.checkBox_Autostart.Name = "checkBox_Autostart";
            this.checkBox_Autostart.Size = new System.Drawing.Size(68, 17);
            this.checkBox_Autostart.TabIndex = 14;
            this.checkBox_Autostart.Text = "Autostart";
            this.checkBox_Autostart.UseVisualStyleBackColor = true;
            this.checkBox_Autostart.CheckedChanged += new System.EventHandler(this.checkBox_Autostart_CheckedChanged);
            // 
            // label_Disp1Value
            // 
            this.label_Disp1Value.AutoSize = true;
            this.label_Disp1Value.Location = new System.Drawing.Point(199, 34);
            this.label_Disp1Value.Name = "label_Disp1Value";
            this.label_Disp1Value.Size = new System.Drawing.Size(13, 13);
            this.label_Disp1Value.TabIndex = 16;
            this.label_Disp1Value.Text = "0";
            // 
            // label_Disp2Value
            // 
            this.label_Disp2Value.AutoSize = true;
            this.label_Disp2Value.Location = new System.Drawing.Point(199, 58);
            this.label_Disp2Value.Name = "label_Disp2Value";
            this.label_Disp2Value.Size = new System.Drawing.Size(13, 13);
            this.label_Disp2Value.TabIndex = 17;
            this.label_Disp2Value.Text = "0";
            // 
            // label_Disp3Value
            // 
            this.label_Disp3Value.AutoSize = true;
            this.label_Disp3Value.Location = new System.Drawing.Point(199, 85);
            this.label_Disp3Value.Name = "label_Disp3Value";
            this.label_Disp3Value.Size = new System.Drawing.Size(13, 13);
            this.label_Disp3Value.TabIndex = 18;
            this.label_Disp3Value.Text = "0";
            // 
            // label_Disp4Value
            // 
            this.label_Disp4Value.AutoSize = true;
            this.label_Disp4Value.Location = new System.Drawing.Point(199, 111);
            this.label_Disp4Value.Name = "label_Disp4Value";
            this.label_Disp4Value.Size = new System.Drawing.Size(13, 13);
            this.label_Disp4Value.TabIndex = 19;
            this.label_Disp4Value.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Value";
            // 
            // checkBox_ToggleDisplay
            // 
            this.checkBox_ToggleDisplay.AutoSize = true;
            this.checkBox_ToggleDisplay.Location = new System.Drawing.Point(12, 143);
            this.checkBox_ToggleDisplay.Name = "checkBox_ToggleDisplay";
            this.checkBox_ToggleDisplay.Size = new System.Drawing.Size(110, 17);
            this.checkBox_ToggleDisplay.TabIndex = 21;
            this.checkBox_ToggleDisplay.Text = "Display ON / OFF";
            this.checkBox_ToggleDisplay.UseVisualStyleBackColor = true;
            // 
            // slider_Brightness
            // 
            this.slider_Brightness.BackColor = System.Drawing.SystemColors.Control;
            this.slider_Brightness.LargeChange = 1;
            this.slider_Brightness.Location = new System.Drawing.Point(71, 197);
            this.slider_Brightness.Maximum = 250;
            this.slider_Brightness.Minimum = 5;
            this.slider_Brightness.Name = "slider_Brightness";
            this.slider_Brightness.Size = new System.Drawing.Size(104, 45);
            this.slider_Brightness.TabIndex = 23;
            this.slider_Brightness.TickFrequency = 25;
            this.slider_Brightness.Value = 5;
            // 
            // label_Brightness
            // 
            this.label_Brightness.AutoSize = true;
            this.label_Brightness.Location = new System.Drawing.Point(9, 204);
            this.label_Brightness.Name = "label_Brightness";
            this.label_Brightness.Size = new System.Drawing.Size(56, 13);
            this.label_Brightness.TabIndex = 24;
            this.label_Brightness.Text = "Brightness";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 278);
            this.Controls.Add(this.label_Brightness);
            this.Controls.Add(this.slider_Brightness);
            this.Controls.Add(this.checkBox_ToggleDisplay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_Disp4Value);
            this.Controls.Add(this.label_Disp3Value);
            this.Controls.Add(this.label_Disp2Value);
            this.Controls.Add(this.label_Disp1Value);
            this.Controls.Add(this.checkBox_Autostart);
            this.Controls.Add(this.label_Disp4Num);
            this.Controls.Add(this.comboBox_Disp4Data);
            this.Controls.Add(this.label_Disp3Num);
            this.Controls.Add(this.comboBox_Disp3Data);
            this.Controls.Add(this.label_Disp2Num);
            this.Controls.Add(this.comboBox_Disp2Data);
            this.Controls.Add(this.label_Disp1Num);
            this.Controls.Add(this.comboBox_Disp1Data);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainform";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Temp monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip_notifyIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slider_Brightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Timer timer_update;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem openHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_connection;
        private System.Windows.Forms.ComboBox comboBox_Disp1Data;
        private System.Windows.Forms.Label label_Disp1Num;
        private System.Windows.Forms.Label label_Disp2Num;
        private System.Windows.Forms.ComboBox comboBox_Disp2Data;
        private System.Windows.Forms.Label label_Disp3Num;
        private System.Windows.Forms.ComboBox comboBox_Disp3Data;
        private System.Windows.Forms.Label label_Disp4Num;
        private System.Windows.Forms.ComboBox comboBox_Disp4Data;
        private System.Windows.Forms.CheckBox checkBox_Autostart;
        private System.Windows.Forms.Label label_Disp1Value;
        private System.Windows.Forms.Label label_Disp2Value;
        private System.Windows.Forms.Label label_Disp3Value;
        private System.Windows.Forms.Label label_Disp4Value;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox_ToggleDisplay;
        private System.Windows.Forms.TrackBar slider_Brightness;
        private System.Windows.Forms.Label label_Brightness;
    }
}