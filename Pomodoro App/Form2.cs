using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pomodoro_App
{
    public partial class Form2 : Form
    {
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        private bool mouseDown;
        private Point lastLocation;
        private int timeLeft;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public Form2(int timeLeft)
        {
            InitializeComponent();
            this.timeLeft = timeLeft;
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            if (timeLeft > 0)
            {
                background_time.Start();
            }
            MouseDown += Form2_MouseDown;
            MouseMove += Form2_MouseMove;
            MouseUp += Form2_MouseUp;
            Form1 form1 = Application.OpenForms.OfType<Form1>().SingleOrDefault();
            form1.Resize += Form1_Resize;
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void background_time_Tick(object sender, EventArgs e)
        {
            label1.Text = timeLeft--.ToString();
            int minutes = timeLeft / 60;
            string convertedMInutes = minutes < 10 ? "0" + minutes.ToString() : minutes.ToString();
            int secondsLeft = timeLeft - (minutes * 60);
            string convertedSeconds = secondsLeft < 10 ? "0" + secondsLeft.ToString() : secondsLeft.ToString();
            label1.Text = String.Format("{0}:{1}:{2}", "00", convertedMInutes, convertedSeconds);

            if(timeLeft == 0)
            {
                background_time.Stop();
                this.Close();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
