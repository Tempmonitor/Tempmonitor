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
            this.checkBox_Disp1Ena = new System.Windows.Forms.CheckBox();
            this.checkBox_Disp2Ena = new System.Windows.Forms.CheckBox();
            this.label_Disp2Num = new System.Windows.Forms.Label();
            this.comboBox_Disp2Data = new System.Windows.Forms.ComboBox();
            this.checkBox_Disp3Ena = new System.Windows.Forms.CheckBox();
            this.label_Disp3Num = new System.Windows.Forms.Label();
            this.comboBox_Disp3Data = new System.Windows.Forms.ComboBox();
            this.checkBox_Disp4Ena = new System.Windows.Forms.CheckBox();
            this.label_Disp4Num = new System.Windows.Forms.Label();
            this.comboBox_Disp4Data = new System.Windows.Forms.ComboBox();
            this.button_RestoreDefaults = new System.Windows.Forms.Button();
            this.checkBox_Autostart = new System.Windows.Forms.CheckBox();
            this.label_Disp1Value = new System.Windows.Forms.Label();
            this.label_Disp2Value = new System.Windows.Forms.Label();
            this.label_Disp3Value = new System.Windows.Forms.Label();
            this.label_Disp4Value = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox_ToggleDisplay = new System.Windows.Forms.CheckBox();
            this.button_about = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip_notifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_connection});
            this.statusStrip.Location = new System.Drawing.Point(0, 240);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(328, 22);
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
            this.timer_update.Interval = 1000;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip_notifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
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
            this.comboBox_Disp1Data.FormattingEnabled = true;
            this.comboBox_Disp1Data.Items.AddRange(new object[] {
            "CPU temp",
            "CPU load",
            "GPU load",
            "GPU temp",
            "RAM usage",
            "Disc usage",
            "Fan speed"});
            this.comboBox_Disp1Data.Location = new System.Drawing.Point(61, 39);
            this.comboBox_Disp1Data.Name = "comboBox_Disp1Data";
            this.comboBox_Disp1Data.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Disp1Data.TabIndex = 1;
            // 
            // label_Disp1Num
            // 
            this.label_Disp1Num.AutoSize = true;
            this.label_Disp1Num.Location = new System.Drawing.Point(9, 43);
            this.label_Disp1Num.Name = "label_Disp1Num";
            this.label_Disp1Num.Size = new System.Drawing.Size(50, 13);
            this.label_Disp1Num.TabIndex = 2;
            this.label_Disp1Num.Text = "Display 1";
            // 
            // checkBox_Disp1Ena
            // 
            this.checkBox_Disp1Ena.AutoSize = true;
            this.checkBox_Disp1Ena.Location = new System.Drawing.Point(199, 42);
            this.checkBox_Disp1Ena.Name = "checkBox_Disp1Ena";
            this.checkBox_Disp1Ena.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Disp1Ena.TabIndex = 3;
            this.checkBox_Disp1Ena.Text = "Enable";
            this.checkBox_Disp1Ena.UseVisualStyleBackColor = true;
            // 
            // checkBox_Disp2Ena
            // 
            this.checkBox_Disp2Ena.AutoSize = true;
            this.checkBox_Disp2Ena.Location = new System.Drawing.Point(199, 69);
            this.checkBox_Disp2Ena.Name = "checkBox_Disp2Ena";
            this.checkBox_Disp2Ena.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Disp2Ena.TabIndex = 6;
            this.checkBox_Disp2Ena.Text = "Enable";
            this.checkBox_Disp2Ena.UseVisualStyleBackColor = true;
            // 
            // label_Disp2Num
            // 
            this.label_Disp2Num.AutoSize = true;
            this.label_Disp2Num.Location = new System.Drawing.Point(9, 70);
            this.label_Disp2Num.Name = "label_Disp2Num";
            this.label_Disp2Num.Size = new System.Drawing.Size(50, 13);
            this.label_Disp2Num.TabIndex = 5;
            this.label_Disp2Num.Text = "Display 2";
            // 
            // comboBox_Disp2Data
            // 
            this.comboBox_Disp2Data.FormattingEnabled = true;
            this.comboBox_Disp2Data.Items.AddRange(new object[] {
            "CPU temp",
            "CPU load",
            "GPU load",
            "GPU temp",
            "RAM usage",
            "Disc usage",
            "Fan speed"});
            this.comboBox_Disp2Data.Location = new System.Drawing.Point(61, 66);
            this.comboBox_Disp2Data.Name = "comboBox_Disp2Data";
            this.comboBox_Disp2Data.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Disp2Data.TabIndex = 4;
            // 
            // checkBox_Disp3Ena
            // 
            this.checkBox_Disp3Ena.AutoSize = true;
            this.checkBox_Disp3Ena.Location = new System.Drawing.Point(199, 96);
            this.checkBox_Disp3Ena.Name = "checkBox_Disp3Ena";
            this.checkBox_Disp3Ena.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Disp3Ena.TabIndex = 9;
            this.checkBox_Disp3Ena.Text = "Enable";
            this.checkBox_Disp3Ena.UseVisualStyleBackColor = true;
            // 
            // label_Disp3Num
            // 
            this.label_Disp3Num.AutoSize = true;
            this.label_Disp3Num.Location = new System.Drawing.Point(9, 97);
            this.label_Disp3Num.Name = "label_Disp3Num";
            this.label_Disp3Num.Size = new System.Drawing.Size(50, 13);
            this.label_Disp3Num.TabIndex = 8;
            this.label_Disp3Num.Text = "Display 3";
            // 
            // comboBox_Disp3Data
            // 
            this.comboBox_Disp3Data.FormattingEnabled = true;
            this.comboBox_Disp3Data.Items.AddRange(new object[] {
            "CPU temp",
            "CPU load",
            "GPU load",
            "GPU temp",
            "RAM usage",
            "Disc usage",
            "Fan speed"});
            this.comboBox_Disp3Data.Location = new System.Drawing.Point(61, 93);
            this.comboBox_Disp3Data.Name = "comboBox_Disp3Data";
            this.comboBox_Disp3Data.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Disp3Data.TabIndex = 7;
            // 
            // checkBox_Disp4Ena
            // 
            this.checkBox_Disp4Ena.AutoSize = true;
            this.checkBox_Disp4Ena.Location = new System.Drawing.Point(199, 123);
            this.checkBox_Disp4Ena.Name = "checkBox_Disp4Ena";
            this.checkBox_Disp4Ena.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Disp4Ena.TabIndex = 12;
            this.checkBox_Disp4Ena.Text = "Enable";
            this.checkBox_Disp4Ena.UseVisualStyleBackColor = true;
            // 
            // label_Disp4Num
            // 
            this.label_Disp4Num.AutoSize = true;
            this.label_Disp4Num.Location = new System.Drawing.Point(9, 124);
            this.label_Disp4Num.Name = "label_Disp4Num";
            this.label_Disp4Num.Size = new System.Drawing.Size(50, 13);
            this.label_Disp4Num.TabIndex = 11;
            this.label_Disp4Num.Text = "Display 4";
            // 
            // comboBox_Disp4Data
            // 
            this.comboBox_Disp4Data.FormattingEnabled = true;
            this.comboBox_Disp4Data.Items.AddRange(new object[] {
            "CPU temp",
            "CPU load",
            "GPU load",
            "GPU temp",
            "RAM usage",
            "Disc usage",
            "Fan speed"});
            this.comboBox_Disp4Data.Location = new System.Drawing.Point(61, 120);
            this.comboBox_Disp4Data.Name = "comboBox_Disp4Data";
            this.comboBox_Disp4Data.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Disp4Data.TabIndex = 10;
            // 
            // button_RestoreDefaults
            // 
            this.button_RestoreDefaults.Location = new System.Drawing.Point(12, 172);
            this.button_RestoreDefaults.Name = "button_RestoreDefaults";
            this.button_RestoreDefaults.Size = new System.Drawing.Size(75, 23);
            this.button_RestoreDefaults.TabIndex = 13;
            this.button_RestoreDefaults.Text = "Defaults";
            this.button_RestoreDefaults.UseVisualStyleBackColor = true;
            this.button_RestoreDefaults.Click += new System.EventHandler(this.button_RestoreDefaults_Click);
            // 
            // checkBox_Autostart
            // 
            this.checkBox_Autostart.AutoSize = true;
            this.checkBox_Autostart.Location = new System.Drawing.Point(122, 208);
            this.checkBox_Autostart.Name = "checkBox_Autostart";
            this.checkBox_Autostart.Size = new System.Drawing.Size(68, 17);
            this.checkBox_Autostart.TabIndex = 14;
            this.checkBox_Autostart.Text = "Autostart";
            this.checkBox_Autostart.UseVisualStyleBackColor = true;
            // 
            // label_Disp1Value
            // 
            this.label_Disp1Value.AutoSize = true;
            this.label_Disp1Value.Location = new System.Drawing.Point(282, 46);
            this.label_Disp1Value.Name = "label_Disp1Value";
            this.label_Disp1Value.Size = new System.Drawing.Size(13, 13);
            this.label_Disp1Value.TabIndex = 16;
            this.label_Disp1Value.Text = "0";
            // 
            // label_Disp2Value
            // 
            this.label_Disp2Value.AutoSize = true;
            this.label_Disp2Value.Location = new System.Drawing.Point(282, 70);
            this.label_Disp2Value.Name = "label_Disp2Value";
            this.label_Disp2Value.Size = new System.Drawing.Size(13, 13);
            this.label_Disp2Value.TabIndex = 17;
            this.label_Disp2Value.Text = "0";
            // 
            // label_Disp3Value
            // 
            this.label_Disp3Value.AutoSize = true;
            this.label_Disp3Value.Location = new System.Drawing.Point(282, 97);
            this.label_Disp3Value.Name = "label_Disp3Value";
            this.label_Disp3Value.Size = new System.Drawing.Size(13, 13);
            this.label_Disp3Value.TabIndex = 18;
            this.label_Disp3Value.Text = "0";
            // 
            // label_Disp4Value
            // 
            this.label_Disp4Value.AutoSize = true;
            this.label_Disp4Value.Location = new System.Drawing.Point(282, 123);
            this.label_Disp4Value.Name = "label_Disp4Value";
            this.label_Disp4Value.Size = new System.Drawing.Size(13, 13);
            this.label_Disp4Value.TabIndex = 19;
            this.label_Disp4Value.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Value";
            // 
            // checkBox_ToggleDisplay
            // 
            this.checkBox_ToggleDisplay.AutoSize = true;
            this.checkBox_ToggleDisplay.Location = new System.Drawing.Point(122, 177);
            this.checkBox_ToggleDisplay.Name = "checkBox_ToggleDisplay";
            this.checkBox_ToggleDisplay.Size = new System.Drawing.Size(110, 17);
            this.checkBox_ToggleDisplay.TabIndex = 21;
            this.checkBox_ToggleDisplay.Text = "Display ON / OFF";
            this.checkBox_ToggleDisplay.UseVisualStyleBackColor = true;
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(12, 204);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(75, 23);
            this.button_about.TabIndex = 22;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 262);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.checkBox_ToggleDisplay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_Disp4Value);
            this.Controls.Add(this.label_Disp3Value);
            this.Controls.Add(this.label_Disp2Value);
            this.Controls.Add(this.label_Disp1Value);
            this.Controls.Add(this.checkBox_Autostart);
            this.Controls.Add(this.button_RestoreDefaults);
            this.Controls.Add(this.checkBox_Disp4Ena);
            this.Controls.Add(this.label_Disp4Num);
            this.Controls.Add(this.comboBox_Disp4Data);
            this.Controls.Add(this.checkBox_Disp3Ena);
            this.Controls.Add(this.label_Disp3Num);
            this.Controls.Add(this.comboBox_Disp3Data);
            this.Controls.Add(this.checkBox_Disp2Ena);
            this.Controls.Add(this.label_Disp2Num);
            this.Controls.Add(this.comboBox_Disp2Data);
            this.Controls.Add(this.checkBox_Disp1Ena);
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
        private System.Windows.Forms.CheckBox checkBox_Disp1Ena;
        private System.Windows.Forms.CheckBox checkBox_Disp2Ena;
        private System.Windows.Forms.Label label_Disp2Num;
        private System.Windows.Forms.ComboBox comboBox_Disp2Data;
        private System.Windows.Forms.CheckBox checkBox_Disp3Ena;
        private System.Windows.Forms.Label label_Disp3Num;
        private System.Windows.Forms.ComboBox comboBox_Disp3Data;
        private System.Windows.Forms.CheckBox checkBox_Disp4Ena;
        private System.Windows.Forms.Label label_Disp4Num;
        private System.Windows.Forms.ComboBox comboBox_Disp4Data;
        private System.Windows.Forms.Button button_RestoreDefaults;
        private System.Windows.Forms.CheckBox checkBox_Autostart;
        private System.Windows.Forms.Label label_Disp1Value;
        private System.Windows.Forms.Label label_Disp2Value;
        private System.Windows.Forms.Label label_Disp3Value;
        private System.Windows.Forms.Label label_Disp4Value;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox_ToggleDisplay;
        private System.Windows.Forms.Button button_about;
    }
}