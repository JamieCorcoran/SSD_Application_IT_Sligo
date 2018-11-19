using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSD_CRUD_APP
{
    public partial class LoginForm : Form
    {
        String _currentDir = Directory.GetCurrentDirectory();
        public LoginForm()
        {
            InitializeComponent();
            CheckFile();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CheckFile()
        {
            var fileToFind = "LoginDetails.csv";
            var result = Directory
                .EnumerateFiles(_currentDir, fileToFind, SearchOption.AllDirectories)
                .FirstOrDefault();

            if (result != _currentDir + "\\LoginDetails.csv")
            {
                using (var myFile = File.Create(_currentDir + "\\LoginDetails.csv"))
                {
                    myFile.Close();
                    AddLogin();
                }
            }
        }
        private void AddLogin()
        {
            using (var w = new StreamWriter(_currentDir + "\\LoginDetails.csv", append: true))
            {
                var line = string.Format("Admin" + "," + "password");
                w.WriteLine(line);
                w.Flush();
                w.Close();
                this.Close();
            }
        }
        private void ValidateLoginDetails()
        {
            using (StreamReader reader = new StreamReader(_currentDir + "\\LoginDetails.csv"))
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            ValidateLoginDetails();
        }
    }
}
