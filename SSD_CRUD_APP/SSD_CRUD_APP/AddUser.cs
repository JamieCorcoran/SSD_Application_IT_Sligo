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
    public partial class AddUser : Form
    {
        String _currentDir = Directory.GetCurrentDirectory();

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddUserDetails();
        }
        private void AddUserDetails()
        {
            if (CheckForNullorEmpty())
            {
                using (var w = new StreamWriter(_currentDir + "\\LoginDetails.csv", append: true))
                {
                    var line = string.Format(usernameTextBox.Text + "," + passwordTextBox.Text);
                    w.WriteLine(line);
                    w.Flush();
                    w.Close();
                    Application.Restart();
                }
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
            File.Delete(_currentDir + "\\LoginDetails.csv");
            this.Close();
        }
    }
}
