using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JakesChatapp
{
    public partial class Form1 : Form
    {
        private TcpListener _listener;
        private TcpClient client_x = new TcpClient();
        private TcpClient client;
        public Form1()
        {
            InitializeComponent();
        }
        private void serbuh()
        {
            _listener = new TcpListener(IPAddress.Parse(textBox1.Text), (int)numericUpDown1.Value);
            _listener.Start();
            button1.Enabled = false;
            while (true)
            {
                client = _listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                Task.Run(() =>
                {
                    while (true)
                    {
                        if (stream.DataAvailable)
                        {
                            byte[] receivedBytes = ReadToEnd(stream);
                            var test_b = Encoding.UTF8.GetString(receivedBytes);
                            var test_c = DecryptString(test_b, "GFRF57!NKSUSVC!R");
                            textBox5.AppendText("Received data: " + test_c + "\r\n");
                        }
                        else
                        {
                            Thread.Sleep(1);
                        }
                    }
                });
            }
        }
        public static byte[] GetRandomBytes()
        {
            int saltLength = GetSaltLength();
            byte[] ba = new byte[saltLength];
            RNGCryptoServiceProvider.Create().GetBytes(ba);
            return ba;
        }

        public static int GetSaltLength()
        {
            return 8;
        }
        public string EncryptString(string text, string password)
        {
            byte[] baPwd = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            byte[] baPwdHash = SHA256Managed.Create().ComputeHash(baPwd);

            byte[] baText = Encoding.UTF8.GetBytes(text);

            byte[] baSalt = GetRandomBytes();
            byte[] baEncrypted = new byte[baSalt.Length + baText.Length];

            // Combine Salt + Text
            for (int i = 0; i < baSalt.Length; i++)
                baEncrypted[i] = baSalt[i];
            for (int i = 0; i < baText.Length; i++)
                baEncrypted[i + baSalt.Length] = baText[i];

            baEncrypted = AES_Encrypt(baEncrypted, baPwdHash);

            string result = Convert.ToBase64String(baEncrypted);
            return result;
        }
        public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }
        public string DecryptString(string text, string password)
        {
            byte[] baPwd = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            byte[] baPwdHash = SHA256Managed.Create().ComputeHash(baPwd);

            byte[] baText = Convert.FromBase64String(text);

            byte[] baDecrypted = AES_Decrypt(baText, baPwdHash);

            // Remove salt
            int saltLength = GetSaltLength();
            byte[] baResult = new byte[baDecrypted.Length - saltLength];
            for (int i = 0; i < baResult.Length; i++)
                baResult[i] = baDecrypted[i + saltLength];

            string result = Encoding.UTF8.GetString(baResult);
            return result;
        }
        private void Write(NetworkStream stream, byte[] data)
        {
            stream.Write(data, 0, data.Length);
        }
        private byte[] ReadToEnd(NetworkStream stream)
        {
            List<byte> receivedBytes = new List<byte>();
            while (stream.DataAvailable)
            {
                byte[] buffer = new byte[1024];
                stream.Read(buffer, 0, buffer.Length);
                receivedBytes.AddRange(buffer);
            }
            receivedBytes.RemoveAll(b => b == 0);
            return receivedBytes.ToArray();
        }
        public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread serth1 = new Thread(new ThreadStart(serbuh));
            serth1.IsBackground = true;
            serth1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread serth21 = new Thread(new ThreadStart(cliyent));
            serth21.IsBackground = true;
            serth21.Start();
        }
        private void starthandler(NetworkStream stream)
        {
            while (true)
            {
                if (stream.DataAvailable)
                {
                    byte[] data = ReadToEnd(stream);
                    textBox5.AppendText("Received data: " + DecryptString(Encoding.UTF8.GetString(data), "GFRF57!NKSUSVC!R") + "\r\n");
                }
                else
                {
                    Thread.Sleep(1);
                }
            }
        }
        private void cliyent()
        {
            client_x.Connect(textBox3.Text, (int)numericUpDown2.Value);
            if (client_x.Connected)
            {
                textBox5.AppendText("Connected To: " + textBox3.Text + ":" + numericUpDown2.Value + "\r\n");
                var headache1 = EncryptString("User Connected", "GFRF57!NKSUSVC!R");
                var headache = Encoding.UTF8.GetBytes(headache1);
                Write(client_x.GetStream(), headache);
                starthandler(client_x.GetStream());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var ginga = EncryptString(textBox4.Text, "GFRF57!NKSUSVC!R");
                Write(client_x.GetStream(), Encoding.UTF8.GetBytes(ginga));
                textBox5.AppendText("Me: " + textBox4.Text + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                var ginga = EncryptString(textBox2.Text, "GFRF57!NKSUSVC!R");
                Write(stream, Encoding.UTF8.GetBytes(ginga));
                textBox5.AppendText("Me: " + textBox2.Text + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}