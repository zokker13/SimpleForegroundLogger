using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SimpleForegroundLogger
{
    struct Report
    {
        public string Message;
        public DateTime Time;

        public Report(string message)
        {
            Message = message;
            Time = DateTime.Now;
        }
    }

    public partial class ForegroundLogger : Form
    {
        private readonly Queue<Report> _messages = new Queue<Report>();
        private readonly ForegroundWatcher _foregroundWatcher = new ForegroundWatcher();
        private const string FILE_LOG = "foreground_log.txt";
        
        public ForegroundLogger()
        {
            InitializeComponent();
        }

        private void _foregroundWatcher_ForegroundChanged(object sender, ForegroundArgs e)
        {
            string text = $"{e.Process.ProcessName.Truncate(16),20}";
            _messages.Enqueue(new Report($"{text}   \"{e.Process.MainWindowTitle}\""));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrMainTick.Enabled = true;

            _foregroundWatcher.Hook();
            _foregroundWatcher.ForegroundChanged += _foregroundWatcher_ForegroundChanged;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FlushQueue(_messages);
        }


        private async void WriteTextAsync(string text)
        {
            byte[] encodedText = Encoding.UTF8.GetBytes(text);

            using (FileStream fs = new FileStream(
                FILE_LOG
                , FileMode.Append
                , FileAccess.Write
                , FileShare.None
                , 4096
                , true
            ))
            {
               await fs.WriteAsync(encodedText, 0, encodedText.Length);
            }
        }

        private void FlushQueue(Queue<Report> queue)
        {
            string text = "";

            while (queue.Count > 0)
            {
                Report message = queue.Dequeue();
                text = $"{text}[{message.Time.ToString("s")}]   {message.Message}\n";
            }
            
            WriteTextAsync(text);
        }

        private void tmrMainTick_Tick(object sender, EventArgs e)
        {
            FlushQueue(_messages);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _foregroundWatcher.Unhook();
            niMain.Visible = false;
            tmrMainTick.Enabled = false;   
        }

        private void msiKillMe_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void msiTruncateLog_Click(object sender, EventArgs e)
        {
            File.Delete(FILE_LOG);
        }

        private void msiShowLogfile_Click(object sender, EventArgs e)
        {
            Process.Start(FILE_LOG);
        }

        private void msiShow_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void ForegroundLogger_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }
    }

    public static class ExtensionMethods
    {
        /// <summary>
        /// Adds nice dots after the function exceeds the defined amount of letters.
        /// Shamelessly stolen from: https://stackoverflow.com/a/6724896/2670428
        /// </summary>
        /// <param name="value">Our string to be truncated.</param>
        /// <param name="maxChars">The amount of letters we want to have (max.)</param>
        /// <returns>Returns the truncated string with proper dots at the end.</returns>
        public static string Truncate(this string value, int maxChars)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + " ...";
        }
    }

}
