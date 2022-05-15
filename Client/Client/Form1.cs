using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    public partial class Form1 : Form
    {
        private const int portNum = 4545;
        //delegate that allows method ....(setText) to be called in the thread that creates and maintaines the GUI
        //delegate is a function that can be attached and executed in a thread other than the main thread
        delegate void SetTextCallback(string text);
        readonly TcpClient client;

        //The NetworkStream class provides methods for sending and receiving data over Stream sockets in blocking mode
        readonly NetworkStream ns;
        readonly Thread t = null;

        private bool verifikimi;
        private const string hostName = "localhost";
        private byte[] bytesNenshkrimi;
        private string[] varguKerkeseNenshkrim;
        private byte[] pergjigjaServeri;
        private byte[] nenshkrimi;

        X509Certificate2 clientCertificate;
        readonly RSACryptoServiceProvider objRsaClient = new RSACryptoServiceProvider();

        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            // Set the MaximizeBox to false to remove the maximize box.
            MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            MinimizeBox = false;

            InitializeComponent();
            client = new TcpClient(hostName, portNum);
            ns = client.GetStream();

            t = new Thread(DoWork);
            t.Start();

        }

        public void DoWork()
        {
            byte[] bytesPergjigja = new byte[1024];
            while (true)
            {
                int lenPergjigja = ns.Read(bytesPergjigja, 0, bytesPergjigja.Length);

                SetText(Encoding.ASCII.GetString(bytesPergjigja, 0, lenPergjigja));

                string konvertimi = "";
                //pe kthejme ne char
                for (int i = 0; i < lenPergjigja; i++)
                {
                    konvertimi += Convert.ToChar(bytesPergjigja[i]);
                }
                //pe ndajme stringun
                varguKerkeseNenshkrim = konvertimi.Split('#');
                //pe kthejme ne byte array
                pergjigjaServeri = Convert.FromBase64String(varguKerkeseNenshkrim[0]);
                nenshkrimi = Convert.FromBase64String(varguKerkeseNenshkrim[1]);
            }
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtKerkesa.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                //Ja jepim tekstin e dekriptuar 
                txtPergjigjaEnkriptuar.Text = text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKerkesa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            X509Store objStore = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            objStore.Open(OpenFlags.ReadOnly);

            X509Certificate2Collection certCollection =
                X509Certificate2UI.SelectFromCollection(objStore.Certificates, "Zgjedh certifikaten per nenshkrim", "Zgjedh certifikaten", X509SelectionFlag.SingleSelection);

            try
            {
                clientCertificate = certCollection[0];
                if (clientCertificate.HasPrivateKey)
                {
                    MessageBox.Show("Certifikata permbane cels privat!");

                    var strContent = "";
                    strContent += "Subject: " + clientCertificate.Subject + "\n";
                    strContent += "Issuer: " + clientCertificate.Issuer + "\n";
                    strContent += "Thumbprint: " + clientCertificate.Thumbprint;
                    MessageBox.Show("Te dhenat e certifikates:\n\n" + strContent);
                }
            }
            catch
            {
                MessageBox.Show("Certifikata ne indeksin 0 nuk ekziston!");
            }

        }

        private void btnVerifiko_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            if (opf.ShowDialog() == DialogResult.OK)
            {
                var path = opf.FileName;
                StreamReader sr = new StreamReader(path);
                var strPrivateParameteres = sr.ReadToEnd();
                sr.Close();

                try
                {
                    // Ja japim celesin publik per me bo verifikimin
                    objRsaClient.FromXmlString(strPrivateParameteres);
                }
                catch
                {
                    MessageBox.Show("Gabim ne zgjedhje te file!");
                }
            }

            verifikimi = objRsaClient.VerifyData(pergjigjaServeri, new SHA1CryptoServiceProvider(), nenshkrimi);
            if (verifikimi)
            {
                MessageBox.Show("Kerkesa eshte valide!");
            }
            else
            {
                MessageBox.Show("Kerkesa nuk eshte valide dhe eshte ndryshuar");
            }
        }

        private void CreateKeys()
        {
            try
            {
                RSACryptoServiceProvider objRSA = new RSACryptoServiceProvider();
                string PrivateKey = objRSA.ToXmlString(true);
                string PublicKey = objRSA.ToXmlString(false);
                using (StreamWriter sw = new StreamWriter("C:\\Users\\Toni PC\\Desktop\\IDEJA-CERT\\certs\\created\\PrivateKey_test.xml"))
                {
                    sw.Write(PrivateKey);
                }
                using (StreamWriter sw = new StreamWriter("C:\\Users\\Toni PC\\Desktop\\IDEJA-CERT\\certs\\created\\PublicKey_test.xml"))
                {
                    sw.Write(PublicKey);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnkripto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    var path = opf.FileName;
                    var strPrivateParameteres = "";

                    StreamReader sr = new StreamReader(path);
                    strPrivateParameteres = sr.ReadToEnd();
                    sr.Close();

                    try
                    {
                        // Ja japim celesin publik per me bo verifikimin
                        objRsaClient.FromXmlString(strPrivateParameteres);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Gabim ne zgjedhje te file!");
                    }
                }
                byte[] byteKerkesa = Encoding.UTF8.GetBytes(txtKerkesa.Text);
                byte[] bytesEncrypted = objRsaClient.Encrypt(byteKerkesa, true);

                txtKerkesaEnkriptuar.Text = Convert.ToBase64String(bytesEncrypted);
            }
            catch
            {
                MessageBox.Show("Ju lutem zgjedhni certifikaten!");
            }
        }

        private void btnDergo_Click(object sender, EventArgs e)
        {
            var kerkesa = txtKerkesaEnkriptuar.Text + "#" + System.Convert.ToBase64String(bytesNenshkrimi);

            byte[] dergesa = Encoding.ASCII.GetBytes(kerkesa);
            ns.Write(dergesa, 0, dergesa.Length);
            txtKerkesa.Text = ""; // pastroje field
        }

        private string decrypt(string encrypted)
        {
            RSACryptoServiceProvider csp = (RSACryptoServiceProvider)clientCertificate.PrivateKey;
            byte[] bytesEncrypted = Convert.FromBase64String(encrypted);
            byte[] bytesDecrypted = csp.Decrypt(bytesEncrypted, true);

            return Encoding.UTF8.GetString(bytesDecrypted);
        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            var dekriptuar = decrypt(txtPergjigjaEnkriptuar.Text.Split('#')[0]);
            txtPergjigjaDekriptuar.Text = dekriptuar;
        }

        private void txtPergjigja_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNenshkruaj_Click(object sender, EventArgs e)
        {
            if(clientCertificate.PrivateKey != null)
            {
                var kerkesa = txtKerkesaEnkriptuar.Text;
                RSACryptoServiceProvider privateKeyProvider = (RSACryptoServiceProvider)clientCertificate.PrivateKey;
                byte[] bytesData = Convert.FromBase64String(kerkesa);
                bytesNenshkrimi = privateKeyProvider.SignData(bytesData, new SHA1CryptoServiceProvider());
            }
            else
            {
                MessageBox.Show("Kjo certificate nuk ka private key.");
            }
        }

    }
}
