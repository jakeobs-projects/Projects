using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakesCrosshairs
{
    public partial class Form1 : Form
    {
        Point lastPoint;
        public Color a;
        private string newline = Environment.NewLine;
        private bool bobby = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                a = colorDialog1.Color;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string a_0 = newline + "Color" + newline + numericUpDown1.Value + newline + numericUpDown2.Value + newline + numericUpDown3.Value + newline + numericUpDown4.Value + newline;
                MessageBox.Show(a_0, "Crosshair Format", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Crosshair File (.Crosshair)|*.Crosshair";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        var line1 = File.ReadLines(filePath).Skip(0).Take(1).First();
                        var line2 = File.ReadLines(filePath).Skip(1).Take(1).First();
                        var line3 = File.ReadLines(filePath).Skip(2).Take(1).First();
                        var line4 = File.ReadLines(filePath).Skip(3).Take(1).First();
                        var line_1 = decimal.Parse(line1);
                        var line_2 = decimal.Parse(line2);
                        var line_3 = decimal.Parse(line3);
                        var line_4 = decimal.Parse(line4);
                        numericUpDown1.Value = line_1;
                        numericUpDown2.Value = line_2;
                        numericUpDown3.Value = line_3;
                        numericUpDown4.Value = line_4;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probably not the correct format" + newline + newline + ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Crosshair File (.Crosshair)|*.Crosshair";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string filepath_1 = sfd.FileName;
                        using (var tw = new StreamWriter(filepath_1, true))
                        {
                            tw.WriteLine(numericUpDown1.Value);
                            tw.WriteLine(numericUpDown2.Value);
                            tw.WriteLine(numericUpDown3.Value);
                            tw.WriteLine(numericUpDown4.Value);
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Crosshair cross_frm = new Crosshair((int)numericUpDown1.Value, (int)numericUpDown2.Value, a, (int)numericUpDown3.Value, (int)numericUpDown4.Value);
                cross_frm.Show();
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.10;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                Application.Exit();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity == 0)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Opacity = 1;
                this.timer3.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}