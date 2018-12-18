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
    public partial class UpdateBook : Form
    {
        KeyClass keyClass = new KeyClass();
        private string tempDir = Path.GetTempPath();
        BookControl _bookControl = new BookControl();
        AesCryptoServiceProvider _aesEncrypt = new AesCryptoServiceProvider();
        ListViewItem _itemId;
        public UpdateBook()
        {
            InitializeComponent();
        }
        public UpdateBook(ListViewItem item, BookControl bookCtrl, AesCryptoServiceProvider aesEncrypt)
        {
            InitializeComponent();
            _bookControl = bookCtrl;
            _aesEncrypt = aesEncrypt;
            _itemId = item;
            PopulateFields();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateBookChanged();
        }
        private void UpdateBookChanged()
        {
            int id = int.Parse(_itemId.SubItems[0].Text); 
            List<String> lines = new List<String>();
            byte[] key = keyClass.GetPrivateKey(_aesEncrypt);
            byte[] iv = keyClass.GetIV(_aesEncrypt);
            Book newBook = new Book(id, nameTextBox.Text, authorTextBox.Text, publisherTextBox.Text, datePublishedPicker.Value);
            if (CheckForNullorEmpty(newBook))
            {
                using (FileStream fStream = new FileStream(tempDir + "BookDetails.csv", FileMode.Open))
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
                                    if (split[0].Contains(_itemId.SubItems[0].Text))
                                        line = string.Format(newBook.Id.ToString() + "," + newBook.Name + "," + newBook.Author + "," + newBook.Publisher + "," + newBook.DatePublished.ToString() + "," + newBook.DatetimeInserted.ToString());
                                }
                                lines.Add(line);
                            }
                        }
                    }
                }
                using (FileStream fStream = new FileStream(tempDir + "BookDetails.csv", FileMode.Open))
                {
                    using (CryptoStream cStream = new CryptoStream(fStream, new AesManaged().CreateEncryptor(key, iv), CryptoStreamMode.Write))
                    {
                        using (StreamWriter w = new StreamWriter(cStream))
                        {
                            foreach (String line in lines)
                                w.WriteLine(line);
                        }
                    }
                }
                _bookControl.ReadInBooks();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invaild Please make sure all fields are filled", "Error", MessageBoxButtons.OK);
            }
        }
        private void PopulateFields()
        {
            nameTextBox.Text = _itemId.SubItems[1].Text;
            authorTextBox.Text = _itemId.SubItems[2].Text;
            publisherTextBox.Text = _itemId.SubItems[3].Text;
            datePublishedPicker.Text = _itemId.SubItems[4].Text;
        }
        private bool CheckForNullorEmpty(Book newBook)
        {
            if (string.IsNullOrEmpty(newBook.Id.ToString()))
                return false;
            else if (string.IsNullOrEmpty(newBook.Name))
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
    }
}
