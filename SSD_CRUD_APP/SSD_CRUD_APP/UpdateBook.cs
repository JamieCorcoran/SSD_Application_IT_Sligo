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
    public partial class UpdateBook : Form
    {
        String _currentDir = Directory.GetCurrentDirectory();
        BookControl _bookControl = new BookControl();
        ListViewItem _itemId;
        public UpdateBook()
        {
            InitializeComponent();
        }
        public UpdateBook(ListViewItem item)
        {
            InitializeComponent();
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
            int id = GetIdValue();
            Book newBook = new Book(id, nameTextBox.Text, authorTextBox.Text, publisherTextBox.Text, datePublishedPicker.Value);
            if (CheckForNullorEmpty(newBook))
            {
                using (var w = new StreamWriter(_currentDir + "\\UserDetails.csv", append: true))
                {
                    var line = string.Format(newBook.Id.ToString() + "," + newBook.Name + "," + newBook.Author + "," + newBook.Publisher + "," + newBook.DatePublished.ToString() + "," + newBook.DatetimeInserted.ToString());
                    w.WriteLine(line);
                    w.Flush();
                    w.Close();
                    _bookControl.ReadInBooks();
                    this.Close();
                }
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
        private int GetIdValue()
        {
            int count = 1;
            try
            {
                string oldId = _itemId.SubItems[0].Text;
                using (var reader = new StreamReader(_currentDir + "\\UserDetails.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        var id = line.Split(',');
                        if (id[0] == oldId)
                            return count;
                        if (string.IsNullOrEmpty(line))
                            break;
                        count++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return count;
        }
    }
}
