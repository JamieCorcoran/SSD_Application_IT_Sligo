namespace SSD_CRUD_APP
{
    partial class AddBook
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
            this.header = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.datePublishedLabel = new System.Windows.Forms.Label();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePickerPublished = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(233, 62);
            this.header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(193, 43);
            this.header.TabIndex = 7;
            this.header.Text = "Add Book";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(345, 411);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(212, 43);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(125, 411);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(212, 43);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Book";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.nameTextBox.Location = new System.Drawing.Point(241, 156);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(333, 30);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(141, 156);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 28);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name:";
            // 
            // datePublishedLabel
            // 
            this.datePublishedLabel.AutoSize = true;
            this.datePublishedLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePublishedLabel.ForeColor = System.Drawing.Color.White;
            this.datePublishedLabel.Location = new System.Drawing.Point(28, 314);
            this.datePublishedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datePublishedLabel.Name = "datePublishedLabel";
            this.datePublishedLabel.Size = new System.Drawing.Size(195, 28);
            this.datePublishedLabel.TabIndex = 15;
            this.datePublishedLabel.Text = "Date Published:";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publisherTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.publisherTextBox.Location = new System.Drawing.Point(241, 260);
            this.publisherTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(333, 30);
            this.publisherTextBox.TabIndex = 3;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.ForeColor = System.Drawing.Color.White;
            this.publisherLabel.Location = new System.Drawing.Point(97, 260);
            this.publisherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(131, 28);
            this.publisherLabel.TabIndex = 17;
            this.publisherLabel.Text = "Publisher:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.White;
            this.AuthorLabel.Location = new System.Drawing.Point(129, 209);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(98, 28);
            this.AuthorLabel.TabIndex = 19;
            this.AuthorLabel.Text = "Author:";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.authorTextBox.Location = new System.Drawing.Point(241, 209);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(333, 30);
            this.authorTextBox.TabIndex = 2;
            // 
            // dateTimePickerPublished
            // 
            this.dateTimePickerPublished.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerPublished.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPublished.Location = new System.Drawing.Point(241, 315);
            this.dateTimePickerPublished.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerPublished.Name = "dateTimePickerPublished";
            this.dateTimePickerPublished.Size = new System.Drawing.Size(333, 30);
            this.dateTimePickerPublished.TabIndex = 4;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(657, 518);
            this.Controls.Add(this.dateTimePickerPublished);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.datePublishedLabel);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.header);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label datePublishedLabel;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerPublished;
    }
}