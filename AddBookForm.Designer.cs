namespace LibraryManagementSystem
{
    partial class AddBookForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblPublicationYear = new Label();
            txtPublicationYear = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblGenre = new Label();
            cmbGenre = new ComboBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblAuthorIDs = new Label();
            txtAuthorIDs = new TextBox();
            btnAddBook = new Button();
            SuspendLayout();
            // 
            // LbTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(27, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";

            txtTitle.Location = new Point(160, 31);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(265, 27);
            txtTitle.TabIndex = 1;
 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(27, 77);
            lblISBN.Margin = new Padding(4, 0, 4, 0);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(44, 20);
            lblISBN.TabIndex = 2;
            lblISBN.Text = "ISBN:";

            txtISBN.Location = new Point(160, 77);
            txtISBN.Margin = new Padding(4, 5, 4, 5);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(265, 27);
            txtISBN.TabIndex = 3;

            lblPublicationYear.AutoSize = true;
            lblPublicationYear.Location = new Point(27, 123);
            lblPublicationYear.Margin = new Padding(4, 0, 4, 0);
            lblPublicationYear.Name = "lblPublicationYear";
            lblPublicationYear.Size = new Size(118, 20);
            lblPublicationYear.TabIndex = 4;
            lblPublicationYear.Text = "Publication Year:";
 
            txtPublicationYear.Location = new Point(160, 123);
            txtPublicationYear.Margin = new Padding(4, 5, 4, 5);
            txtPublicationYear.Name = "txtPublicationYear";
            txtPublicationYear.Size = new Size(265, 27);
            txtPublicationYear.TabIndex = 5;
 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(27, 169);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";
 
            txtDescription.Location = new Point(160, 169);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(265, 90);
            txtDescription.TabIndex = 7;

            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(27, 277);
            lblGenre.Margin = new Padding(4, 0, 4, 0);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(51, 20);
            lblGenre.TabIndex = 8;
            lblGenre.Text = "Genre:";

            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(160, 277);
            cmbGenre.Margin = new Padding(4, 5, 4, 5);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(265, 28);
            cmbGenre.TabIndex = 9;

            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(27, 323);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity:";

            txtQuantity.Location = new Point(160, 323);
            txtQuantity.Margin = new Padding(4, 5, 4, 5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(265, 27);
            txtQuantity.TabIndex = 11;
 
            lblAuthorIDs.AutoSize = true;
            lblAuthorIDs.Location = new Point(27, 369);
            lblAuthorIDs.Margin = new Padding(4, 0, 4, 0);
            lblAuthorIDs.Name = "lblAuthorIDs";
            lblAuthorIDs.Size = new Size(82, 20);
            lblAuthorIDs.TabIndex = 12;
            lblAuthorIDs.Text = "Author IDs:";
            txtAuthorIDs.Location = new Point(160, 369);
            txtAuthorIDs.Margin = new Padding(4, 5, 4, 5);
            txtAuthorIDs.Name = "txtAuthorIDs";
            txtAuthorIDs.Size = new Size(265, 27);
            txtAuthorIDs.TabIndex = 13;

            btnAddBook.Location = new Point(160, 431);
            btnAddBook.Margin = new Padding(4, 5, 4, 5);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(133, 46);
            btnAddBook.TabIndex = 14;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 509);
            Controls.Add(btnAddBook);
            Controls.Add(txtAuthorIDs);
            Controls.Add(lblAuthorIDs);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cmbGenre);
            Controls.Add(lblGenre);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtPublicationYear);
            Controls.Add(lblPublicationYear);
            Controls.Add(txtISBN);
            Controls.Add(lblISBN);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddBookForm";
            Text = "Add Book";
            Load += AddBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblPublicationYear;
        private System.Windows.Forms.TextBox txtPublicationYear;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblAuthorIDs;
        private System.Windows.Forms.TextBox txtAuthorIDs;
        private System.Windows.Forms.Button btnAddBook;
    }
}