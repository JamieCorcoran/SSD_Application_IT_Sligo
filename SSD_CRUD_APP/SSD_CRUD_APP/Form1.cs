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
        String _currentDir = Directory.GetCurrentDirectory();
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
            ReadInBooks();
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {

        }
        private void CheckForFile()
        {
            var fileToFind = "UserDetails.csv";
            var result = Directory
                .EnumerateFiles(_currentDir, fileToFind, SearchOption.AllDirectories)
                .FirstOrDefault();

            if (result != _currentDir + "\\UserDetails.csv")
            {
                using (var myFile = File.Create(_currentDir + "\\UserDetails.csv"))
                {
                    myFile.Close();
                }
            }
        }
        private void ReadInBooks()
        {
            booksListView.Items.Clear();
            try
            {
                using (var reader = new StreamReader(_currentDir + "\\UserDetails.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        ListViewItem  itm = new ListViewItem(values);
                        booksListView.Items.Add(itm);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private void WriteToCSV()
        {
            using (StreamWriter file = new StreamWriter(_currentDir + "\\UserDetails.csv"))
            {
                file.WriteLine();
            }
        }
        private void CreateBook()
        {

        }
    }
}
