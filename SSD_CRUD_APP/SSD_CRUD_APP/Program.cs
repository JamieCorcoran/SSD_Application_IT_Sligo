using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSD_CRUD_APP
{
    static class Program
    {
        private static String _currentDir = Directory.GetCurrentDirectory();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var fileToFind = "LoginDetails.csv";
            var result = Directory
                .EnumerateFiles(_currentDir, fileToFind, SearchOption.AllDirectories)
                .FirstOrDefault();

            if (result != _currentDir + "\\LoginDetails.csv")
            {
                DialogResult messageResult = MessageBox.Show("There is no user found, would you like to create one?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (messageResult == DialogResult.Yes)
                {
                    using (var myFile = File.Create(_currentDir + "\\LoginDetails.csv"))
                    {
                        myFile.Close();
                    }
                    Application.Run(new AddUser());
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {

                Application.Run(new LoginForm());
            }
        }
    }
}
