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
    public partial class AddBook : Form
    {
        KeyClass keyClass = new KeyClass();
        BookControl _bookControl = new BookControl();
        AesCryptoServiceProvider _aesEncrypt = new AesCryptoServiceProvider();
        private string tempDir = Path.GetTempPath();
        private byte[] _key;
        private byte[] _iv;
        public AddBook()
        {
            InitializeComponent();
        }
        public AddBook(BookControl bookCtrl, AesCryptoServiceProvider aesEncrypt)
        {
            InitializeComponent();
            _bookControl = bookCtrl;
            _aesEncrypt = aesEncrypt;
            _key = keyClass.GetPrivateKey(_aesEncrypt);
            _iv = keyClass.GetIV(_aesEncrypt);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CreateBook();
        }
        private void CreateBook()
        {
            string allBooks = GetBooks();
            int id = GetIdValue();
            Book newBook = new Book(id, nameTextBox.Text, authorTextBox.Text, publisherTextBox.Text, dateTimePickerPublished.Value);
            if (CheckForNullorEmpty(newBook))
            {
                using (FileStream fStream = new FileStream(tempDir + "BookDetails.csv", FileMode.Open))
                {
                    using (CryptoStream cStream = new CryptoStream(fStream , new AesManaged().CreateEncryptor(_key, _iv), CryptoStreamMode.Write))
                    {
                        using (StreamWriter w = new StreamWriter(cStream))
                        {
                            var line = string.Format(newBook.Id.ToString() + "," + newBook.Name + "," + newBook.Author + "," + newBook.Publisher + "," + newBook.DatePublished.ToString() + "," + newBook.DatetimeInserted.ToString());
                            allBooks = allBooks + line;
                            w.WriteLine(allBooks);
                            w.Flush();
                            w.Close();
                            _bookControl.ReadInBooks();
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invaild Please make sure all fields are filled", "Error", MessageBoxButtons.OK);
            }
        }

        private bool CheckForNullorEmpty(Book newBook)
        {
            if (string.IsNullOrEmpty(newBook.Id.ToString()))
                return false;
            else if(string.IsNullOrEmpty(newBook.Name))
                return false;
            else if (string.IsNullOrEmpty(newBook.Author))
                return false;
            else if (string.IsNullOrEmpty(newBook.Publisher))
                return false;
            else if (string.IsNullOrEmpty(newBook.DatePublished.ToString()))
                return false;
            else
                return true;
        }
        private int GetIdValue()
        {
            int max = 1;
            try
            {
                using (FileStream fStream = new FileStream(tempDir + "BookDetails.csv", FileMode.Open))
                {
                    using (CryptoStream cStream = new CryptoStream(fStream, new AesManaged().CreateDecryptor(_key, _iv), CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cStream))
                        {
                            while (!reader.EndOfStream)
                            {
                                string line = reader.ReadLine();
                                var values = line.Split(',');
                                if (string.IsNullOrEmpty(line))
                                    break;
                                if (int.Parse(values[0]) >= max)
                                {
                                    max = int.Parse(values[0]) + 1;
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
            return max;
        }
        private string GetBooks()
        {
            string allBooks = "";
            try
            {
                using (FileStream fStream = new FileStream(tempDir + "BookDetails.csv", FileMode.Open))
                {
                    using (CryptoStream cStream = new CryptoStream(fStream, new AesManaged().CreateDecryptor(_key, _iv), CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cStream))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                allBooks = allBooks + line + "\r\n";
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return allBooks;
        }
    }
}
