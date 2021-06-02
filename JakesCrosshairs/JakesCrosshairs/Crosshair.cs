using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakesCrosshairs
{
    public partial class Crosshair : Form
    {
        Graphics g;
        Color Color_a;
        RECT rect;
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
        public int Width_a;
        public int Size_a;
        public Color color_a;
        public int alpha_a;
        public int gapBetween_a;
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        public Crosshair(int Width_1, int Size_1, Color color_1, int alpha_1, int gapBetween_1)
        {
            InitializeComponent();
            Width_a = Width_1;
            Size_a = Size_1;
            color_a = color_1;
            alpha_a = alpha_1;
            gapBetween_a = gapBetween_1;
        }
        public struct RECT
        {
            public int left, top, right, bottom;
        }
        private void Crosshair_Load(object sender, EventArgs e)
        {
            try
            {
                getitstarted();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Something Bad Happened", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Close();
        }
        private void getitstarted()
        {
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Top = rect.top;
            this.Left = rect.left;
            this.WindowState = FormWindowState.Maximized;




            IntPtr thisWindow = FindWindow(null, "Crosshair");
            RegisterHotKey(thisWindow, 1, (int)fsModifiers.Shift, (int)Keys.P);
        }
        private void Crosshair_Paint_1(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Lime);
            myPen.Color = color_a;
            g = e.Graphics;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            myPen.Width = Width_a;
            myPen.Color = Color.FromArgb(alpha_a, color_a);
            int gapBetween_y;
            gapBetween_y = gapBetween_a * -1;
            g.DrawLine(myPen, screenWidth / 2 + gapBetween_a, screenHeight / 2, screenWidth / 2 + Size_a, screenHeight / 2);
            g.DrawLine(myPen, screenWidth / 2, screenHeight / 2 + gapBetween_y, screenWidth / 2, screenHeight / 2 - Size_a);
            g.DrawLine(myPen, screenWidth / 2, screenHeight / 2 + Size_a, screenWidth / 2, screenHeight / 2 + gapBetween_a);
            g.DrawLine(myPen, screenWidth / 2 - Size_a, screenHeight / 2, screenWidth / 2 + gapBetween_y, screenHeight / 2);
        }
    }
}
