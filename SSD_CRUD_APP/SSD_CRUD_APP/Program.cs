using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSD_CRUD_APP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                string tempDir = Path.GetTempPath();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var fileToFind = "LoginDetails.csv";
                var result = Directory
                    .EnumerateFiles(tempDir, fileToFind, SearchOption.AllDirectories)
                    .FirstOrDefault();

                if (result != (tempDir + "LoginDetails.csv"))
                {
                    DialogResult messageResult = MessageBox.Show("There is no user found, would you like to create one?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (messageResult == DialogResult.Yes)
                    {
                        using (var myFile = File.Create(tempDir + "LoginDetails.csv"))
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
