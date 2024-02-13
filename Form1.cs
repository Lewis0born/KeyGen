
using System;
using System.Windows.Forms;
using AppSoftware.LicenceEngine.Common;
using KeyGen.KeyGenerator;

namespace KeyGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += GenerateKey_Click;
        }

        private void GenerateKey_Click(object sender, EventArgs e)
        {
            // Get the input data from the user
            string userID = userIDBox.Text;

            // Generate the license key
            string licenseKey = GenerateLicenseKey(userID);

            // Display the generated license key
            keyGen.Text = licenseKey;
        }

        private string GenerateLicenseKey(string userID)
        {
            // Define your key byte sets
            var keyByteSets = new[]
            {
                new KeyByteSet(keyByteNumber: 1, keyByteA: 58, keyByteB: 6, keyByteC: 97),
                new KeyByteSet(keyByteNumber: 2, keyByteA: 96, keyByteB: 254, keyByteC: 23),
                new KeyByteSet(keyByteNumber: 3, keyByteA: 11, keyByteB: 185, keyByteC: 69),
                new KeyByteSet(keyByteNumber: 4, keyByteA: 2, keyByteB: 93, keyByteC: 41),
                new KeyByteSet(keyByteNumber: 5, keyByteA: 62, keyByteB: 4, keyByteC: 234),
                new KeyByteSet(keyByteNumber: 6, keyByteA: 200, keyByteB: 56, keyByteC: 49),
                new KeyByteSet(keyByteNumber: 7, keyByteA: 89, keyByteB: 45, keyByteC: 142),
                new KeyByteSet(keyByteNumber: 8, keyByteA: 6, keyByteB: 88, keyByteC: 32)
            };

            // Calculate expiry date (e.g. 1 months from today)
            //DateTime expiryDate = DateTime.Now.AddMonths(1);

            // expire in 1 day for test
            DateTime expiryDate = DateTime.Now.AddDays(1);
            String expiryString = expiryDate.ToString("yyyyMMdd");
           // MessageBox.Show(expiryDate.ToString());

            // Convert expiry date to a format suitable for encoding in the license key
            //string expiryString = expiryDate.ToString("yyyyMMdd");
            //MessageBox.Show(expiryString);

            // Concatenate the user ID and expiry date to form the seed
            string seed = userID;
            MessageBox.Show(seed);

            // Generate the license key
            var pkvKeyGenerator = new PkvKeyGenerator();
            return pkvKeyGenerator.MakeKey(seed.GetHashCode(), keyByteSets, expiryString);

        }
    }
}
