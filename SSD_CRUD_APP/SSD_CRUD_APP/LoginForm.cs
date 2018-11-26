using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSD_CRUD_APP
{
    public partial class LoginForm : Form
    {
        AesCryptoServiceProvider _aesEncrypt = new AesCryptoServiceProvider();
        private string tempDir = Path.GetTempPath();
        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(AesCryptoServiceProvider aseEcrypt)
        {
            InitializeComponent();
            _aesEncrypt = aseEcrypt;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ValidateLoginDetails()
        {
            byte[] key =  Convert.FromBase64String(GetKey());
            byte[] iv = Convert.FromBase64String(GetIV());
            using (FileStream fStream = new FileStream(tempDir + "LoginDetails.csv", FileMode.Open))
            {
                using (CryptoStream cStream = new CryptoStream(fStream, new AesManaged().CreateDecryptor(key, iv), CryptoStreamMode.Read))
                {
                    using (StreamReader reader = new StreamReader(cStream))
                    {
                        String line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains(","))
                            {
                                String[] split = line.Split(',');
                                if (split[0] == usernameTextBox.Text && split[1] == passwordTextBox.Text)
                                {
                                    BookControl bookControl = new BookControl();
                                    bookControl.Show();
                                    this.Hide();
                                }
                                else
                                    MessageBox.Show("Invaild Please enter details again", "Error", MessageBoxButtons.OK);

                            }
                        }
                    }
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ValidateLoginDetails();
        }
        private void LoginForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            File.Delete(tempDir + "LoginDetails.csv");
            File.Delete(tempDir + "UserDetails.csv");
            Application.Exit();
        }
        private string GetKey()
        {
            List<long> seqKey = new List<long>(new long[] { 1, 8, 2, 3, 9, 0, 6, 5, 4, 7, 10 });
            string value = "";
            string key = "";
            List<string> keyBreakUp = new List<string>();
            using (var reader = new StreamReader(tempDir + "Keys.csv"))
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                value = values[0];
            }
            keyBreakUp = BreakUpValues(value);
            foreach (long number in seqKey)
            {
                key = key + keyBreakUp[Convert.ToInt32(number)];
            }
            return key;
        }
        private string GetIV()
        {
            List<long> seqIV = new List<long>(new long[] { 0, 4, 3, 2, 5, 1 });
            string value = "";
            string iv = "";
            List<string> ivBreakUp = new List<string>();
            using (var reader = new StreamReader(tempDir + "Keys.csv"))
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                value = values[1];
            }
            ivBreakUp = BreakUpValues(value);
            foreach (long number in seqIV)
            {
                iv = iv + ivBreakUp[Convert.ToInt32(number)];
            }
            return iv;
        }
        private List<string> BreakUpValues(string value)
        {
            List<string> newValue = new List<string>();
            int count = 0;
            while (!string.IsNullOrEmpty(value))
            {
                newValue.Add(value.Substring(0, 4));
                value = value.Remove(0, 4);
                count++;
            }
            return newValue;
        }
    }
}
