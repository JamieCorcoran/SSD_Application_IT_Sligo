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
        KeyClass keyClass = new KeyClass();
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
            byte[] key =  Convert.FromBase64String(keyClass.GetKey("x"));
            byte[] iv = Convert.FromBase64String(keyClass.GetIV("x"));
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
                                    BookControl bookControl = new BookControl(_aesEncrypt);
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
            Application.Exit();
        }
    }
}
