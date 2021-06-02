using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixxie
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String SAppName);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        private string newline = Environment.NewLine;
        Point lastPoint;
        private string gamewindow = "";
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern int GetWindowRect(IntPtr hwnd, out Rectangle rect);




        public Form1()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.10;
            if(this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            label2.Visible = false;
            checkforauth();
        }
        private void checkforauth()
        {
            try
            {
                IntPtr thisWindow = FindWindow(null, gamewindow);
                CheckForIllegalCrossThreadCalls = false;
                timer1.Start();
            }
            catch
            {

            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                Application.Exit();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if(this.Opacity == 0)
            {
                timer3.Stop();
                WindowState = FormWindowState.Minimized;
                this.Opacity = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                timer2.Start();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                timer3.Start();
            }
            catch
            {

            }
        }
        public enum fsModifiers
        {
            Alt = 0x0001,
            Control = 0x0002,
            Shift = 0x0004,
            Window = 0x0008
        }
        protected override void WndProc(ref Message keyPressed)
        {
            if (keyPressed.Msg == 0x0312)
            {
                int id = keyPressed.WParam.ToInt32();
                if (id == 1)
                {
                    KeybindMethod1();
                }
            }
            base.WndProc(ref keyPressed);
        }
        private void KeybindMethod1()
        {
            try
            {
                timer4.Stop();
                button3.Enabled = true;
                label2.Visible = false;
            }
            catch
            {

            }
        }
        Color GetPixel(Point position)
        {
            
            using (var bitmap = new Bitmap(1, 1))
            {
                using( var graphics = Graphics.FromImage(bitmap))
                {

                    graphics.CopyFromScreen(position, new Point(0, 0), new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            timer4.Start();
            IntPtr thisWindow = FindWindow(null, "Pixxie");
            RegisterHotKey(thisWindow, 1, (int)fsModifiers.Shift, (int)Keys.O);
            button3.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);

            var c = GetColorAt(cursor);
            textBox1.AppendText("RGB: "+c.R.ToString()+","+c.G.ToString()+","+c.B.ToString()+newline);
            panel1.BackColor = Color.FromArgb(c.R,c.G,c.B);
            string hex = c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            textBox1.AppendText("HEX: "+"0x"+hex+newline+newline);
            if (c.R == c.G && c.G < 64 && c.B > 128)
            {
                textBox1.AppendText("Blue");
            }
        }

        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               IntPtr thisWindow = FindWindow(null, "Pixxie");
               UnregisterHotKey(thisWindow, 1);
            }
            catch
            {

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
