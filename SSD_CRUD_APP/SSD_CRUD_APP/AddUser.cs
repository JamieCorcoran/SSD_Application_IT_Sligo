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
        KeyClass keyClass = new KeyClass();
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
            keyClass.StoreKey(_aesEncrypt, "x");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddLoginDetails();
        }
        private void AddLoginDetails()
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
            this.Close();
        }
        private void AddUser_FormClosing(Object sender, FormClosingEventArgs e)
        {
            File.Delete(tempDir + "LoginDetails.csv");
            Application.Exit();
        }
    }
}
