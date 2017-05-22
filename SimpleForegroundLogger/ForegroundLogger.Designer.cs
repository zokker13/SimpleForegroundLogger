namespace SimpleForegroundLogger
{
    partial class ForegroundLogger
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForegroundLogger));
            this.tmrMainTick = new System.Windows.Forms.Timer(this.components);
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.msMainStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.msiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.msiShowLogfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msiTruncateLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msiKillMe = new System.Windows.Forms.ToolStripMenuItem();
            this.pcbKillMe = new System.Windows.Forms.PictureBox();
            this.msMainStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKillMe)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMainTick
            // 
            this.tmrMainTick.Interval = 1000;
            this.tmrMainTick.Tick += new System.EventHandler(this.tmrMainTick_Tick);
            // 
            // niMain
            // 
            this.niMain.ContextMenuStrip = this.msMainStrip;
            this.niMain.Icon = ((System.Drawing.Icon)(resources.GetObject("niMain.Icon")));
            this.niMain.Text = "Mr. Foreground Logger";
            this.niMain.Visible = true;
            // 
            // msMainStrip
            // 
            this.msMainStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.msMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiShow,
            this.msiShowLogfile,
            this.toolStripSeparator1,
            this.msiTruncateLog,
            this.toolStripSeparator2,
            this.msiKillMe});
            this.msMainStrip.Name = "msMainStrip";
            this.msMainStrip.ShowImageMargin = false;
            this.msMainStrip.Size = new System.Drawing.Size(136, 126);
            // 
            // msiShow
            // 
            this.msiShow.Name = "msiShow";
            this.msiShow.Size = new System.Drawing.Size(135, 22);
            this.msiShow.Text = "Show";
            this.msiShow.Click += new System.EventHandler(this.msiShow_Click);
            // 
            // msiShowLogfile
            // 
            this.msiShowLogfile.Name = "msiShowLogfile";
            this.msiShowLogfile.Size = new System.Drawing.Size(135, 22);
            this.msiShowLogfile.Text = "Show Logfile";
            this.msiShowLogfile.Click += new System.EventHandler(this.msiShowLogfile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // msiTruncateLog
            // 
            this.msiTruncateLog.Name = "msiTruncateLog";
            this.msiTruncateLog.Size = new System.Drawing.Size(135, 22);
            this.msiTruncateLog.Text = "Truncate Logfile";
            this.msiTruncateLog.Click += new System.EventHandler(this.msiTruncateLog_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // msiKillMe
            // 
            this.msiKillMe.Name = "msiKillMe";
            this.msiKillMe.Size = new System.Drawing.Size(135, 22);
            this.msiKillMe.Text = "Kill Me";
            this.msiKillMe.Click += new System.EventHandler(this.msiKillMe_Click);
            // 
            // pcbKillMe
            // 
            this.pcbKillMe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbKillMe.Image = ((System.Drawing.Image)(resources.GetObject("pcbKillMe.Image")));
            this.pcbKillMe.Location = new System.Drawing.Point(12, 12);
            this.pcbKillMe.Name = "pcbKillMe";
            this.pcbKillMe.Size = new System.Drawing.Size(230, 230);
            this.pcbKillMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbKillMe.TabIndex = 1;
            this.pcbKillMe.TabStop = false;
            // 
            // ForegroundLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 254);
            this.Controls.Add(this.pcbKillMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ForegroundLogger";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mr. Foreground Logger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.ForegroundLogger_Resize);
            this.msMainStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbKillMe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrMainTick;
        private System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.ContextMenuStrip msMainStrip;
        private System.Windows.Forms.ToolStripMenuItem msiKillMe;
        private System.Windows.Forms.ToolStripMenuItem msiTruncateLog;
        private System.Windows.Forms.ToolStripMenuItem msiShowLogfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem msiShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox pcbKillMe;
    }
}

