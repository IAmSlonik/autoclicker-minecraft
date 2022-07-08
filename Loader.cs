using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{

    public partial class Loader : Form
    {
        //IDK
        Point Pos;
        bool mDown = false;
        public Loader()
        {
            InitializeComponent();
            Timer();
        }
        //ChildForm
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelOp.Controls.Add(childForm);
            panelOp.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Opening childForms
        private void bLewy_Click(object sender, EventArgs e)
        {
            openChildForm(new GUI.LEWY.Lewy());
        }
        private void bPrawy_Click_1(object sender, EventArgs e)
        {
            openChildForm(new GUI.PRAWY.Prawy());
        }
        private void bKop_Click_1(object sender, EventArgs e)
        {
            openChildForm(new GUI.KOPANIE.Kopanie());
        }
        //Exit & Minimize
        private void bExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Check if mc is running then change text in label
        void Timer()
        {
            timer1.Interval =10000;
            timer1.Tick += new EventHandler(timer);
            timer1.Start();
            void timer(object sender, EventArgs e)
            {
                CheckProc();
            }
        }
        void CheckProc()
        {
            Process[] prc = Process.GetProcessesByName("javaw");
            if (prc.Length > 0)
            {
                lProc.Text = "Active";
            }
            else { lProc.Text = "N/A"; }
        }
        //Move app
        private void pTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            Pos.X = e.X;
            Pos.Y = e.Y;
            mDown = true;
        }

        private void pTitlebar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mDown)
            {
                Point currPos = PointToScreen(e.Location);
                Location = new Point(currPos.X - Pos.X, currPos.Y - Pos.Y);
            }
        }

        private void pTitlebar_MouseUp(object sender, MouseEventArgs e)
        {
            mDown = false;
        }
    }
}
