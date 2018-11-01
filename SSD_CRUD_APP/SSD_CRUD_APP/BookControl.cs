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
    public partial class BookControl : Form
    {
        String _currentDir = Directory.GetCurrentDirectory();
        public BookControl()
        {
            InitializeComponent();
            CheckForFile();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            AddBook addBookForm = new AddBook(this);
            addBookForm.Show();
        }

        private void updateBook_Click(object sender, EventArgs e)
        {
            if (booksListView.SelectedItems.Count == 1)
            {
                UpdateBook updateBookForm = new UpdateBook(booksListView.SelectedItems[0], this);
                updateBookForm.Show();
            }
            else
                MessageBox.Show("Invaild Please select one item", "Error", MessageBoxButtons.OK);
        }

        private void viewBooks_Click(object sender, EventArgs e)
        {
            ReadInBooks();
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {
            if (booksListView.SelectedItems.Count == 1)
            {
                DeleteBook();
            }
            else
                MessageBox.Show("Invaild Please select one item", "Error", MessageBoxButtons.OK);
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
        public void ReadInBooks()
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
        private void DeleteBook()
        {
            int id = int.Parse(booksListView.SelectedItems[0].SubItems[0].Text);
            List<String> lines = new List<String>();
            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader(_currentDir + "\\UserDetails.csv"))
            {
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(","))
                    {
                        String[] split = line.Split(',');
                        if (split[0].Contains(booksListView.SelectedItems[0].SubItems[0].Text))
                            line = "";
                    }
                    lines.Add(line);
                }
            }
            using (StreamWriter writer = new StreamWriter(_currentDir + "\\UserDetails.csv", false))
            {
                foreach (String line in lines)
                    writer.WriteLine(line);
            }
            using (StreamReader reader = new StreamReader(_currentDir + "\\UserDetails.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                        list.Add(line);
                }
            }
            using (StreamWriter writer = new StreamWriter(_currentDir + "\\UserDetails.csv", false))
            {
                foreach (String line in list)
                    writer.WriteLine(line);
            }
            ReadInBooks();
        }
        private void UpdateBook()
        {
            using (var reader = new StreamReader(_currentDir + "\\UserDetails.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    ListViewItem itm = new ListViewItem(values);
                    booksListView.Items.Add(itm);
                }
            }
        }
    }
}
