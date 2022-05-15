using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        //delegate that allows method ....(setText) to be called in the thread that creates and maintaines the GUI
        //delegate is a function that can be attached and executed in a thread other than the main thread
        delegate void SetTextCallback(string text);
        private TcpListener listener;
        private TcpClient client;
        //The NetworkStream class provides methods for sending and receiving data over Stream sockets in blocking mode
        private NetworkStream ns;
        private Thread t = null;
        private bool verifikimi;
        private byte[] bytesNenshkrimi;
        private byte[] kerkesaKlienti;
        private byte[] nenshkrimi;

        private string konvertimi = "";
        private RSACryptoServiceProvider objRsaClient = new RSACryptoServiceProvider();
        private X509Certificate2 serverCertificate;

        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            // Set the MaximizeBox to false to remove the maximize box.
            MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            MinimizeBox = false;

            InitializeComponent();
            listener = new TcpListener(4545);
            listener.Start();
            client = listener.AcceptTcpClient();
            ns = client.GetStream();
            t = new Thread(DoWork);
            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public void DoWork()
        {
            byte[] bytesKerkesa = new byte[1024];
            while (true)
            {
                int lenKerkesa = ns.Read(bytesKerkesa, 0, bytesKerkesa.Length);
                SetText(Encoding.ASCII.GetString(bytesKerkesa, 0, lenKerkesa));

                //pe kthejme ne char
                for (int i = 0; i < lenKerkesa; i++)
                {
                    konvertimi += Convert.ToChar(bytesKerkesa[i]);
                }
                string[] varguKerkeseNenshkrim;
                //pe ndajme stringun
                varguKerkeseNenshkrim = konvertimi.Split('#');
                //pe kthejme ne byte array
                kerkesaKlienti = System.Convert.FromBase64String(varguKerkeseNenshkrim[0]);
                nenshkrimi = System.Convert.FromBase64String(varguKerkeseNenshkrim[1]);
            }

        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.'
            var kerkesa = text.ToLower();
            if (txtKerkesaNenshkruar.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                var kerkesaEnkriptuarKlientit = text;
                txtKerkesaNenshkruar.Text = text;
            }
        }

        private void btnCertifikata_Click(object sender, EventArgs e)
        {
            X509Store objStore = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            objStore.Open(OpenFlags.ReadOnly);
            X509Certificate2Collection certCollection = 
                X509Certificate2UI.SelectFromCollection(objStore.Certificates, "Zgjedh certifikaten per nenshkrim", "Zgjedh certifikaten", X509SelectionFlag.SingleSelection);

            try
            {
                serverCertificate = certCollection[0];
                if (serverCertificate.HasPrivateKey)
                {
                    MessageBox.Show("Certifikata permbane cels privat!");

                    var strContent = "";
                    strContent += "Subject: " + serverCertificate.Subject + "\n";
                    strContent += "Issuer: " + serverCertificate.Issuer + "\n";
                    strContent += "Thumbprint: " + serverCertificate.Thumbprint;
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
                string path = opf.FileName;
                StreamReader sr = new StreamReader(path);
                string strPrivateParameteres = sr.ReadToEnd();
                sr.Close();
                try
                {
                    //Pja jepum celesin publik per me bo verifikm na vyn
                    objRsaClient.FromXmlString(strPrivateParameteres);
                }
                catch
                {
                    MessageBox.Show("Gabim ne zgjedhje te file!");
                }
            }
            verifikimi = objRsaClient.VerifyData(kerkesaKlienti, new SHA1CryptoServiceProvider(), nenshkrimi);
            if (verifikimi)
            {
                MessageBox.Show("Kerkesa eshte valide!");
            }
            else
            {
                MessageBox.Show("Kerkesa nuk eshte valide dhe eshte ndryshuar");
            }

        }

        //dekriptimi i kerkeses duke marr paramater kerkesaEnrkiptuar
        private string dekriptoKerkesen(string kerkesaEnkriptuar)
        {
            RSACryptoServiceProvider privateKeyProvider = (RSACryptoServiceProvider)serverCertificate.PrivateKey;
            byte[] bytesEncryptedS = Convert.FromBase64String(kerkesaEnkriptuar);
            var bytesDecrypted = privateKeyProvider.Decrypt(bytesEncryptedS, true);
            return Encoding.UTF8.GetString(bytesDecrypted);
        }

        //dekriptimim i kerkeses se enkriptuar te marre nga klienti
        private void btnDekripto_Click(object sender, EventArgs e)
        {
            txtKerkesaDekriptuar.Text = dekriptoKerkesen(txtKerkesaNenshkruar.Text.Split('#')[0]);
        }

        //pe dergojme pergjigjen qe  e kemi marre pas enkirpitimit
        private void btnDergo_Click(object sender, EventArgs e)
        {
            //dergimi i pergjigjes
            string pergjigja = txtPergjigjaEnkriptuar.Text + "#" +
            Convert.ToBase64String(bytesNenshkrimi);
            byte[] dergesa = Encoding.ASCII.GetBytes(pergjigja);
            ns.Write(dergesa, 0, dergesa.Length);
        }

        //enkriptimi i pergjigjes se serverit
        private void btnEnkripto_Click(object sender, EventArgs e)
        {
            try
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
                        //Pja jepum celesin publik per me bo verifikm na vyn
                        objRsaClient.FromXmlString(strPrivateParameteres);
                    }
                    catch
                    {
                        MessageBox.Show("Gabim ne zgjedhje te file!");
                    }
                }
                byte[] bytesData = Encoding.UTF8.GetBytes(txtPergjigjaDekriptuar.Text);
                byte[] bytesEncrypted = objRsaClient.Encrypt(bytesData, true);
                txtPergjigjaEnkriptuar.Text = Convert.ToBase64String(bytesEncrypted);
            }
            catch
            {
                MessageBox.Show("Ju lutem zgjedhni certifikaten!");
            }
        }

        private void btnNenshkruaj_Click(object sender, EventArgs e)
        {
            string pergjigja = txtPergjigjaEnkriptuar.Text;
            RSACryptoServiceProvider privateKeyProvider = (RSACryptoServiceProvider)serverCertificate.PrivateKey;
            byte[] bytesData = Convert.FromBase64String(pergjigja);
            bytesNenshkrimi = privateKeyProvider.SignData(bytesData, new SHA1CryptoServiceProvider());
        }

        private void txtKerkesaNenshkruar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
