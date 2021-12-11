using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClickerVer1._0
{
    public partial class Form1 : Form
    {
        #region DllIMports
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        #endregion

        int min;
        int max;
        IntPtr menu;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void TrckbarLeftClick_Scroll(object sender, ScrollEventArgs e)
        {
            lblClickCounter.Text = "CPS: " + trckbarLeftClick.Value.ToString();
        }

        private void BtnToggle_Click(object sender, EventArgs e)
        {
            Random.Start();
            if (btnToggle.Text.Contains("Disable Toggle"))
            {
                btnToggle.ForeColor = Color.FromArgb(193, 200, 207);
                btnToggle.FillColor = Color.FromArgb(160, 113, 255);
                btnToggle.BorderColor = Color.FromArgb(193, 200, 207);
                btnToggle.Text = "Toggle";
                Random.Stop();
            }
            else if (btnToggle.Text.Contains("Toggle"))
            {
                btnToggle.ForeColor = Color.FromArgb(160, 113, 255);
                btnToggle.FillColor = Color.FromArgb(193, 200, 207);
                btnToggle.BorderColor = Color.FromArgb(160, 113, 255);
                btnToggle.Text = "Disable Toggle";
            }
        }

        private void BtnToggle_TextChanged(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("Disable Toggle"))
            {
                AutoClicker.Start();
            }
            else 
            {
                AutoClicker.Stop();
            }
        }
        public string GetActiveWindowName() 
        {
            try
            {
                var activeHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsprocesses in processes)
                {
                    if (activeHandle == clsprocesses.MainWindowHandle)
                    {
                        string processName = clsprocesses.ProcessName;
                        return processName;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

            return null;
        }
        private void Random_Tick(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("Disable Toggle"))
            {
                min = trckbarLeftClick.Value - 6;
                max = trckbarLeftClick.Value + 6;
                trckbarRandom.Value = rand.Next(min, max);
            }
        }

        private void AutoClicker_Tick(object sender, EventArgs e)
        {
            try
            {
                AutoClicker.Interval = 1000 / trckbarRandom.Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

            if (btnToggle.Text.Contains("Disable Toggle"))
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process process in processes)
                {
                    menu = FindWindow(null, process.MainWindowTitle);
                }

                string currentWindow = GetActiveWindowName();
                if (currentWindow == null)
                {
                    return;
                }
                if (currentWindow.Contains("javaw"))
                {
                    PostMessage(menu, 0x0201, 0, 0);
                    Thread.Sleep(10 / trckbarLeftClick.Value);
                }
            }
        }
    }
}
