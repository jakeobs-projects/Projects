using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakesCryptography
{
    public partial class Form1 : Form
    {
        private string encrypt_file_name;
        private string decrypt_file_name;
        Point lastPoint;
        private bool isWorking = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Start();
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OD = new OpenFileDialog();
                OD.Filter = "All Files|*";
                if (OD.ShowDialog() == DialogResult.OK)
                {
                    encrypt_file_name = OD.FileName;
                    label1.ForeColor = Color.FromArgb(0, 255, 0);
                    label1.Text = "File Loaded";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);
                }
            }

            return data;
        }
        private void FileEncrypt(string inputFile, string password)
        {
            byte[] salt = GenerateRandomSalt();
            FileStream fsCrypt = new FileStream(inputFile + ".FlipEncrypt", FileMode.Create);
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Mode = CipherMode.CFB;
            fsCrypt.Write(salt, 0, salt.Length);
            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);
            FileStream fsIn = new FileStream(inputFile, FileMode.Open);
            byte[] buffer = new byte[1048576];
            int read;
            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    cs.Write(buffer, 0, read);
                }
                fsIn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }

        }
        private void FileDecrypt(string inputFile, string outputFile, string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                MessageBox.Show("CryptographicException error: " + ex_CryptographicException.Message + "\n\nProbably Wrong Password Key");
                isWorking = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "No File Selected")
            {
                MessageBox.Show("No File Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter A Password", "Error");
            }
            else
            {
                FileEncrypt(encrypt_file_name, textBox1.Text);
                string a = textBox1.Text + ".FlipEncrypt";
                if (File.Exists(a))
                {
                    File.Move(a, Path.GetFileNameWithoutExtension(textBox1.Text) + ".FlipEncrypt");
                }
                string delold = encrypt_file_name;
                try
                {
                    File.Delete(delold);
                }
                catch
                {

                }
                MessageBox.Show("File: " + encrypt_file_name + " Is Now Encrypted\n\n", "FlipEncrypt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OD = new OpenFileDialog();
                OD.Filter = "All Files|*";
                if (OD.ShowDialog() == DialogResult.OK)
                {
                    decrypt_file_name = OD.FileName;
                    label5.ForeColor = Color.FromArgb(0,255,0);
                    label5.Text = "File Loaded";
                }
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            if (label5.Text == "No File Selected")
            {
                MessageBox.Show("No File Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Enter A Output Name", "Error");
            }
            else if(string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Enter The Password", "Error");
            }
            else
            {
                FileDecrypt(decrypt_file_name, textBox3.Text, textBox2.Text);
                if (isWorking == false)
                {

                }
                else
                {
                    if (File.Exists(textBox3.Text))
                    {
                        try
                        {
                            File.Delete(decrypt_file_name);
                        }
                        catch
                        {

                        }
                    }
                    MessageBox.Show("File: " + decrypt_file_name + " Is Now Decrypted" + "\n\nNew Path: " + strWorkPath + "", "FlipEncrypt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
