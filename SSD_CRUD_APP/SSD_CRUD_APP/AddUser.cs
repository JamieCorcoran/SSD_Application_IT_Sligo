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

namespace SSD_CRUD_APP
{
    public partial class AddUser : Form
    {
        AesCryptoServiceProvider _aesEncrypt = new AesCryptoServiceProvider();
        private string tempDir = Path.GetTempPath();
        public AddUser()
        {
            InitializeComponent();
        }
        public AddUser(AesCryptoServiceProvider aseEcrypt)
        {
            InitializeComponent();
            _aesEncrypt = aseEcrypt;
            StoreKey();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddUserDetails();
        }
        private void AddUserDetails()
        {
            if (CheckForNullorEmpty())
            {
                using (FileStream fStream = new FileStream(tempDir + "LoginDetails.csv", FileMode.Open))
                {
                    using (CryptoStream cStream = new CryptoStream(fStream, new AesManaged().CreateEncryptor(_aesEncrypt.Key, _aesEncrypt.IV), CryptoStreamMode.Write))
                    {
                        using (StreamWriter w = new StreamWriter(cStream))
                        {
                            var line = string.Format(usernameTextBox.Text + "," + passwordTextBox.Text);
                            w.WriteLine(line);
                            w.Flush();
                            w.Close();
                            this.Hide();
                            LoginForm login = new LoginForm(_aesEncrypt);
                            login.Show();
                        }
                    }
                }
                File.SetAttributes(tempDir + "LoginDetails.csv", FileAttributes.Hidden);
            }
            else
                MessageBox.Show("Invaild Please enter details", "Error", MessageBoxButtons.OK);
        }
        private bool CheckForNullorEmpty()
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text))
                return false;
            else if (string.IsNullOrEmpty(passwordTextBox.Text))
                return false;
            else
                return true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            File.Delete(tempDir + "LoginDetails.csv");
            File.Delete(tempDir + "UserDetails.csv");
            File.Delete(tempDir + "Keys.csv");
            this.Close();
        }
        private void AddUser_FormClosing(Object sender, FormClosingEventArgs e)
        {
            File.Delete(tempDir + "LoginDetails.csv");
            File.Delete(tempDir + "UserDetails.csv");
            File.Delete(tempDir + "Keys.csv");
            Application.Exit();
        }
        private void StoreKey()
        {
            if (CheckForFile() == (tempDir + "Keys.csv"))
            {
                string keyStored;
                string ivStored;
                List<string> keyBreakUp = new List<string>();
                List<string> ivBreakUp = new List<string>();

                keyBreakUp = BreakUpValues(Convert.ToBase64String(_aesEncrypt.Key));
                ivBreakUp = BreakUpValues(Convert.ToBase64String(_aesEncrypt.IV));
                keyStored = newEncyptValues(keyBreakUp);
                ivStored = newEncyptValues(ivBreakUp);

                using (StreamWriter w = new StreamWriter(tempDir + "Keys.csv"))
                {
                    var line = string.Format(keyStored + "," + ivStored);
                    w.WriteLine(line);
                    w.Flush();
                    w.Close();
                }
                File.SetAttributes(tempDir + "Keys.csv", FileAttributes.Hidden);
            }
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
        private string newEncyptValues(List<string> oldValues)
        {
            List<long> seqKey = new List<long>(new long[] { 5,0,2,3,8,7,6,9,1,4,10 });
            List<long> seqIV = new List<long>(new long[] { 0,5,3,2,1,4 });
            string newValue = "";
            if(oldValues.Count == 11)
            {
                foreach(long value in seqKey)
                {
                    newValue = newValue + oldValues[Convert.ToInt32(value)];
                }
            }
            else
            {
                foreach (long value in seqIV)
                {
                    newValue = newValue + oldValues[Convert.ToInt32(value)];
                }
            }

            return newValue;
        }
        private string CheckForFile()
        {
            var fileToFind = "Keys.csv";
            var result = Directory
                .EnumerateFiles(tempDir, fileToFind, SearchOption.AllDirectories)
                .FirstOrDefault();

            return result;
        }
    }
}
