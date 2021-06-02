using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jakes_VPN
{
    public partial class Form1 : Form
    {
        private string host = "";
        private string username = "vpnbook";
        private string password = "k8VBRa6";
        private string oldip;
        private string externalip;
        Point lastPoint;
        private static string FolderPath => string.Concat(Directory.GetCurrentDirectory(),
            "\\VPN");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter A Host");
            }
            else
            {
                try
                {
                    label2.Text = "Status: Connecting...";
                    oldip = new WebClient().DownloadString("https://icanhazip.com");
                    if (!Directory.Exists(FolderPath))
                        Directory.CreateDirectory(FolderPath);

                    var sb = new StringBuilder();
                    sb.AppendLine("[VPN]");
                    sb.AppendLine("MEDIA=rastapi");
                    sb.AppendLine("Port=VPN2-0");
                    sb.AppendLine("Device=WAN Miniport (IKEv2)");
                    sb.AppendLine("DEVICE=vpn");
                    sb.AppendLine("PhoneNumber=" + host);

                    File.WriteAllText(FolderPath + "\\VpnConnection.pbk", sb.ToString());

                    sb = new StringBuilder();
                    sb.AppendLine("rasdial \"VPN\" " + username + " " + password + " /phonebook:\"" + FolderPath +
                                  "\\VpnConnection.pbk\"");

                    File.WriteAllText(FolderPath + "\\VpnConnection.bat", sb.ToString());

                    var newProcess = new Process
                    {
                        StartInfo =
                    {
                        FileName = FolderPath + "\\VpnConnection.bat",
                        WindowStyle = ProcessWindowStyle.Hidden
                    }
                    };

                    newProcess.Start();
                    newProcess.WaitForExit();
                    externalip = new WebClient().DownloadString("https://icanhazip.com");
                    if (oldip != externalip)
                    {
                        notifyIcon1.Icon = SystemIcons.Application;
                        notifyIcon1.BalloonTipText = "VPN Connected";
                        notifyIcon1.BalloonTipTitle = "VPN";
                        ShowIcon = false;
                        notifyIcon1.Visible = true;
                        notifyIcon1.ShowBalloonTip(1000);
                        label2.Text = "Status: Connected";
                    }
                    else
                    {
                        notifyIcon1.Icon = SystemIcons.Application;
                        notifyIcon1.BalloonTipText = "Failed to Connect.\nTry again";
                        notifyIcon1.BalloonTipTitle = "Error";
                        ShowIcon = false;
                        notifyIcon1.Visible = true;
                        notifyIcon1.ShowBalloonTip(1000);
                        label2.Text = "Status: Failed to connect";
                    }
                    button2.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(FolderPath + "\\VpnDisconnect.bat", "rasdial /d");

                var newProcess = new Process
                {
                    StartInfo =
                {
                    FileName = FolderPath + "\\VpnDisconnect.bat",
                    WindowStyle = ProcessWindowStyle.Hidden
                }
                };

                newProcess.Start();
                newProcess.WaitForExit();
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Disconnected";
                notifyIcon1.BalloonTipTitle = "VPN";
                ShowIcon = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
                label2.Text = "Disconnected";
            }
            catch
            {
                MessageBox.Show("Something went wrong", "Error");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity == 0)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity == 0)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Opacity = 1;
                this.timer2.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            this.Opacity = 0.0;
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.10;
            if (this.Opacity == 1)
            {
                timer3.Stop();
            }
        }
    }
}
