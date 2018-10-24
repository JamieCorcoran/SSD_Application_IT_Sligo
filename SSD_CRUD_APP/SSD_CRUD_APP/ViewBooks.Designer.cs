namespace SSD_CRUD_APP
{
    partial class ViewBooks
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.header = new System.Windows.Forms.Label();
            this.idColumnn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorColumnn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisherColumnn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datePublishedColumnn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumnn,
            this.nameColumnn,
            this.authorColumnn,
            this.publisherColumnn,
            this.datePublishedColumnn});
            this.listView1.Location = new System.Drawing.Point(12, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(590, 254);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(217, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(181, 33);
            this.header.TabIndex = 8;
            this.header.Text = "View Books";
            // 
            // idColumnn
            // 
            this.idColumnn.Text = "Id";
            this.idColumnn.Width = 29;
            // 
            // nameColumnn
            // 
            this.nameColumnn.Text = "Name";
            this.nameColumnn.Width = 180;
            // 
            // authorColumnn
            // 
            this.authorColumnn.Text = "Author";
            this.authorColumnn.Width = 130;
            // 
            // publisherColumnn
            // 
            this.publisherColumnn.Text = "Publisher";
            this.publisherColumnn.Width = 141;
            // 
            // datePublishedColumnn
            // 
            this.datePublishedColumnn.Text = "Date Published";
            this.datePublishedColumnn.Width = 98;
            // 
            // ViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(614, 341);
            this.Controls.Add(this.header);
            this.Controls.Add(this.listView1);
            this.Name = "ViewBooks";
            this.Text = "View Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idColumnn;
        private System.Windows.Forms.ColumnHeader nameColumnn;
        private System.Windows.Forms.ColumnHeader authorColumnn;
        private System.Windows.Forms.ColumnHeader publisherColumnn;
        private System.Windows.Forms.ColumnHeader datePublishedColumnn;
        private System.Windows.Forms.Label header;
    }
}