namespace SSD_CRUD_APP
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.Color.White;
            this.Heading.Location = new System.Drawing.Point(207, 104);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(163, 28);
            this.Heading.TabIndex = 11;
            this.Heading.Text = "Book Control";
            // 
            // deleteBook
            // 
            this.deleteBook.BackColor = System.Drawing.Color.White;
            this.deleteBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.deleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBook.ForeColor = System.Drawing.Color.Black;
            this.deleteBook.Location = new System.Drawing.Point(297, 232);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(124, 78);
            this.deleteBook.TabIndex = 10;
            this.deleteBook.Text = "Delete Book";
            this.deleteBook.UseVisualStyleBackColor = false;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // updateBook
            // 
            this.updateBook.BackColor = System.Drawing.Color.White;
            this.updateBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.updateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBook.ForeColor = System.Drawing.Color.Black;
            this.updateBook.Location = new System.Drawing.Point(297, 148);
            this.updateBook.Name = "updateBook";
            this.updateBook.Size = new System.Drawing.Size(124, 78);
            this.updateBook.TabIndex = 9;
            this.updateBook.Text = "Update Book";
            this.updateBook.UseVisualStyleBackColor = false;
            this.updateBook.Click += new System.EventHandler(this.updateBook_Click);
            // 
            // viewBooks
            // 
            this.viewBooks.BackColor = System.Drawing.Color.White;
            this.viewBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.viewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBooks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBooks.ForeColor = System.Drawing.Color.Black;
            this.viewBooks.Location = new System.Drawing.Point(167, 232);
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(124, 78);
            this.viewBooks.TabIndex = 8;
            this.viewBooks.Text = "View Book";
            this.viewBooks.UseVisualStyleBackColor = false;
            this.viewBooks.Click += new System.EventHandler(this.viewBooks_Click);
            // 
            // addBook
            // 
            this.addBook.BackColor = System.Drawing.Color.White;
            this.addBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.addBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook.ForeColor = System.Drawing.Color.Black;
            this.addBook.Location = new System.Drawing.Point(167, 148);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(124, 78);
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
            this.Title.Location = new System.Drawing.Point(206, 56);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(166, 33);
            this.Title.TabIndex = 6;
            this.Title.Text = "Main Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(594, 401);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.deleteBook);
            this.Controls.Add(this.updateBook);
            this.Controls.Add(this.viewBooks);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

