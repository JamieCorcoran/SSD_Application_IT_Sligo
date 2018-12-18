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
    public partial class BookControl : Form
    {
        KeyClass keyClass = new KeyClass();
        private string tempDir = Path.GetTempPath();
        AesCryptoServiceProvider _aesEncrypt = new AesCryptoServiceProvider();
        public BookControl()
        {
            InitializeComponent();
            CheckForFile();
        }
        public BookControl(AesCryptoServiceProvider aesEncrypt)
        {
            InitializeComponent();
            CheckForFile();
            _aesEncrypt = aesEncrypt;
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            AddBook addBookForm = new AddBook(this, _aesEncrypt);
            addBookForm.Show();
        }

        private void updateBook_Click(object sender, EventArgs e)
        {
            if (booksListView.SelectedItems.Count == 1)
            {
                UpdateBook updateBookForm = new UpdateBook(booksListView.SelectedItems[0], this, _aesEncrypt);
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
            var fileToFind = "BookDetails.csv";
            var result = Directory
                .EnumerateFiles(tempDir, fileToFind, SearchOption.AllDirectories)
                .FirstOrDefault();

            if (result != (tempDir + "BookDetails.csv"))
            {
                using (var myFile = File.Create(tempDir + "BookDetails.csv"))
                {
                    myFile.Close();
                }
            }
        }
        public void ReadInBooks()
        {
            booksListView.Items.Clear();
            if (File.Exists(tempDir + "BookDetails.csv"))
            {
                try
                {
                    byte[] key = keyClass.GetPrivateKey(_aesEncrypt);
                    byte[] iv = keyClass.GetIV(_aesEncrypt);
                    using (FileStream fStream = new FileStream(tempDir + "BookDetails.csv", FileMode.Open))
                    {
                        if (fStream.Length > 0)
                        {
                            using (CryptoStream cStream = new CryptoStream(fStream, new AesManaged().CreateDecryptor(key, iv), CryptoStreamMode.Read))
                            {
                                using (StreamReader reader = new StreamReader(cStream))
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
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        private void WriteToCSV()
        {
            using (StreamWriter file = new StreamWriter(tempDir + "BookDetails.csv"))
            {
                file.WriteLine();
            }
        }
        private void DeleteBook()
        {
            byte[] key = keyClass.GetPrivateKey(_aesEncrypt);
            byte[] iv = keyClass.GetIV(_aesEncrypt);
            List<string> allBooks = GetBooks();
            string addBooksBack = "";
            string bookToRemove="";

            foreach(string value in allBooks)
            {
                if (value.Contains(booksListView.SelectedItems[0].SubItems[0].Text+","))
                {
                    bookToRemove = value;
                }
            }
            allBooks.Remove(bookToRemove);
            foreach (string value in allBooks)
            {
                addBooksBack = addBooksBack + value + "\r\n";
            }
            if(allBooks.Count > 0)
            {
                addBooksBack = addBooksBack.Substring(0, addBooksBack.Length - 2);
            }
            if (allBooks.Count == 0)
            {
                File.Delete(tempDir + "BookDetails.csv");
            }
            else
            {
                try
                {
                    using (FileStream fStream = new FileStream(tempDir + "BookDetails.csv", FileMode.Open))
                    {
                        fStream.SetLength(0);
                    }
                    using (FileStream fStream = new FileStream(tempDir + "BookDetails.csv", FileMode.Open))
                    {
                        using (CryptoStream cStream = new CryptoStream(fStream, new AesManaged().CreateEncryptor(key, iv), CryptoStreamMode.Write))
                        {
                            using (StreamWriter w = new StreamWriter(cStream))
                            {
                                w.WriteLine(addBooksBack);
                                w.Flush();
                                w.Close();
                            }
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            ReadInBooks();
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private List<string> GetBooks()
        {
            byte[] key = keyClass.GetPrivateKey(_aesEncrypt);
            byte[] iv = keyClass.GetIV(_aesEncrypt);
            List<string> allBooks = new List<string>();
            if (File.Exists(tempDir + "BookDetails.csv"))
            {
                try
                {
                    using (FileStream fStream = new FileStream(tempDir + "BookDetails.csv", FileMode.Open))
                    {
                        using (CryptoStream cStream = new CryptoStream(fStream, new AesManaged().CreateDecryptor(key, iv), CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cStream))
                            {
                                while (!reader.EndOfStream)
                                {
                                    var line = reader.ReadLine();
                                    allBooks.Add(line);
                                }
                                reader.Close();
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return allBooks;
        }
    }
}
