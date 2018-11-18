namespace SSD_CRUD_APP
{
    partial class BookControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Heading = new System.Windows.Forms.Label();
            this.deleteBook = new System.Windows.Forms.Button();
            this.updateBook = new System.Windows.Forms.Button();
            this.viewBooks = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.booksListView = new System.Windows.Forms.ListView();
            this.idColumnn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorColumnn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisherColumnn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datePublishedColumnn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.Color.White;
            this.Heading.Location = new System.Drawing.Point(399, 98);
            this.Heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(206, 34);
            this.Heading.TabIndex = 11;
            this.Heading.Text = "Book Control";
            // 
            // deleteBook
            // 
            this.deleteBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBook.BackColor = System.Drawing.Color.White;
            this.deleteBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.deleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBook.ForeColor = System.Drawing.Color.Black;
            this.deleteBook.Location = new System.Drawing.Point(845, 206);
            this.deleteBook.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(151, 46);
            this.deleteBook.TabIndex = 10;
            this.deleteBook.Text = "Delete Book";
            this.deleteBook.UseVisualStyleBackColor = false;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // updateBook
            // 
            this.updateBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBook.BackColor = System.Drawing.Color.White;
            this.updateBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.updateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBook.ForeColor = System.Drawing.Color.Black;
            this.updateBook.Location = new System.Drawing.Point(685, 206);
            this.updateBook.Margin = new System.Windows.Forms.Padding(4);
            this.updateBook.Name = "updateBook";
            this.updateBook.Size = new System.Drawing.Size(151, 46);
            this.updateBook.TabIndex = 9;
            this.updateBook.Text = "Update Book";
            this.updateBook.UseVisualStyleBackColor = false;
            this.updateBook.Click += new System.EventHandler(this.updateBook_Click);
            // 
            // viewBooks
            // 
            this.viewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewBooks.BackColor = System.Drawing.Color.White;
            this.viewBooks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.viewBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.viewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBooks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBooks.ForeColor = System.Drawing.Color.Black;
            this.viewBooks.Location = new System.Drawing.Point(16, 206);
            this.viewBooks.Margin = new System.Windows.Forms.Padding(4);
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(151, 46);
            this.viewBooks.TabIndex = 8;
            this.viewBooks.Text = "View Books";
            this.viewBooks.UseVisualStyleBackColor = false;
            this.viewBooks.Click += new System.EventHandler(this.viewBooks_Click);
            // 
            // addBook
            // 
            this.addBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBook.BackColor = System.Drawing.Color.White;
            this.addBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.addBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook.ForeColor = System.Drawing.Color.Black;
            this.addBook.Location = new System.Drawing.Point(525, 206);
            this.addBook.Margin = new System.Windows.Forms.Padding(4);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(151, 46);
            this.addBook.TabIndex = 7;
            this.addBook.Text = "Add Book";
            this.addBook.UseVisualStyleBackColor = false;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(397, 39);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(210, 43);
            this.Title.TabIndex = 6;
            this.Title.Text = "Main Menu";
            // 
            // booksListView
            // 
            this.booksListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnn,
            this.nameColumnn,
            this.authorColumnn,
            this.publisherColumnn,
            this.datePublishedColumnn});
            this.booksListView.FullRowSelect = true;
            this.booksListView.Location = new System.Drawing.Point(16, 258);
            this.booksListView.Margin = new System.Windows.Forms.Padding(4);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(979, 312);
            this.booksListView.TabIndex = 12;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
            // 
            // idColumnn
            // 
            this.idColumnn.Text = "Id";
            this.idColumnn.Width = 29;
            // 
            // nameColumnn
            // 
            this.nameColumnn.Text = "Name";
            this.nameColumnn.Width = 209;
            // 
            // authorColumnn
            // 
            this.authorColumnn.Text = "Author";
            this.authorColumnn.Width = 148;
            // 
            // publisherColumnn
            // 
            this.publisherColumnn.Text = "Publisher";
            this.publisherColumnn.Width = 207;
            // 
            // datePublishedColumnn
            // 
            this.datePublishedColumnn.Text = "Date Published";
            this.datePublishedColumnn.Width = 131;
            // 
            // BookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1012, 586);
            this.Controls.Add(this.booksListView);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.deleteBook);
            this.Controls.Add(this.updateBook);
            this.Controls.Add(this.viewBooks);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookControl";
            this.Text = "Book Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.Button updateBook;
        private System.Windows.Forms.Button viewBooks;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListView booksListView;
        private System.Windows.Forms.ColumnHeader idColumnn;
        private System.Windows.Forms.ColumnHeader nameColumnn;
        private System.Windows.Forms.ColumnHeader authorColumnn;
        private System.Windows.Forms.ColumnHeader publisherColumnn;
        private System.Windows.Forms.ColumnHeader datePublishedColumnn;
    }
}

