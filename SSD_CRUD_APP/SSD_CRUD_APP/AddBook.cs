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
    public partial class AddBook : Form
    {
        BookControl _bookControl = new BookControl();
        public AddBook()
        {
            InitializeComponent();
        }
        public AddBook(BookControl bookCtrl)
        {
            InitializeComponent();
            _bookControl = bookCtrl;
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
            int id = GetIdValue();
            Book newBook = new Book(id, nameTextBox.Text, authorTextBox.Text, publisherTextBox.Text, dateTimePickerPublished.Value);
            if (CheckForNullorEmpty(newBook))
            {
                using (var w = new StreamWriter(Path.GetTempPath() + "BookDetails.csv", append: true))
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
                using (var reader = new StreamReader(Path.GetTempPath() + "BookDetails.csv"))
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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return max;
        }
    }
}
