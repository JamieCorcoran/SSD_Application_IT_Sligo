﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSD_CRUD_APP
{
    public partial class UpdateBook : Form
    {
        string _itemId;
        public UpdateBook()
        {
            InitializeComponent();
        }
        public UpdateBook(ListViewItem id)
        {
            InitializeComponent();
            _itemId = id.Text;
            PopulateFields();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
        private void PopulateFields()
        {

        }
    }
}
