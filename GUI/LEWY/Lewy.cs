using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Clicker.GUI.LEWY
{
    public partial class Lewy : Form
    {
        #region dlls
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        #endregion
        public Lewy()
        {
            InitializeComponent();
        }

        private void tbMin_Scroll(object sender, EventArgs e)
        {
            label1.Text = $"{tbMin.Value}";
        }
        IntPtr hWnd;
        public string getActiveWindowName()
        {
            try
            {
                var activateHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (activateHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;
                        return processName;
                    }
                }
            }
            catch { }
            return null;
        }
        private async void Ltimer_Tick(object sender, EventArgs e)
        {
            try
            {
                Ltimer.Interval = 1000 / tbMin.Value;
            }
            catch { }
            if (checkBox1.Text.Contains("Enabled"))
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach(Process process in processes)
                {
                    hWnd = FindWindow(null, process.MainWindowTitle);
                }
                string currentwindow = getActiveWindowName();
                if (currentwindow == null)
                {
                    return;
                }
                if (currentwindow.Contains("javaw"))
                {
                    if(MouseButtons == MouseButtons.Left)
                    {
                        PostMessage(hWnd, 0x0201, 0, 0);
                        await Task.Delay(30);
                        PostMessage(hWnd, 0x0202, 0, 0);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Enabled";
            }
            else
            {
                checkBox1.Text = "Disabled";
            }
        }

        private void bBind_Click_1(object sender, EventArgs e)
        {
            if (bBind.Text == "brak")
            {
                bBind.Text = "***";
            }
            else
            {
                bBind.Text = "***";
            }
        }

        private void bBind_KeyUp(object sender, KeyEventArgs e)
        {
            if (bBind.Text == "***")
            {
                
                if (GetAsyncKeyState(Keys.Escape) < 0)
                {
                    bBind.Text = "brak";
                }
                else { bBind.Text = e.KeyData.ToString(); }
            }
        }
        KeysConverter Key = new KeysConverter();

        private void tBind_Tick(object sender, EventArgs e)
        {
            if(bBind.Text != "brak")
            {
                if(bBind.Text != "***")
                {
                    Keys key = (Keys)Key.ConvertFromString(bBind.Text);
                    if(GetAsyncKeyState(key) < 0)
                    {
                        checkBox1.Checked = !checkBox1.Checked;
                    }
                }
            }
        }
    }
}
