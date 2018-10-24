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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForFile();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            AddBook addBookForm = new AddBook();
            addBookForm.Show();
        }

        private void updateBook_Click(object sender, EventArgs e)
        {
            UpdateBook updateBookForm = new UpdateBook();
            updateBookForm.Show();
        }

        private void viewBooks_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooksForm = new ViewBooks();
            viewBooksForm.Show();
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {

        }
        private void CheckForFile()
        {
            String currentDir = Directory.GetCurrentDirectory();

            var fileToFind = "UserDetails.csv";

            var result = Directory
                .EnumerateFiles(currentDir, fileToFind, SearchOption.AllDirectories)
                .FirstOrDefault();
            if (result != currentDir + "\\UserDetails.csv")
            {
                File.Create(currentDir + "\\UserDetails.csv");
            }
        }
    }
}
