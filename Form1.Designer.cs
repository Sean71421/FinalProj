namespace LibraryManagementSystem
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnAddBook = new Button();
            btnRentBook = new Button();
            btnReturnBook = new Button();
            btnCreateUser = new Button();
            btnRemoveLibraryCard = new Button();
            btnViewAllBooks = new Button();
            btnViewUsers = new Button();
            btnViewRentals = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(67, 154);
            btnAddBook.Margin = new Padding(4, 5, 4, 5);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(267, 62);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnRentBook
            // 
            btnRentBook.Location = new Point(67, 231);
            btnRentBook.Margin = new Padding(4, 5, 4, 5);
            btnRentBook.Name = "btnRentBook";
            btnRentBook.Size = new Size(267, 62);
            btnRentBook.TabIndex = 1;
            btnRentBook.Text = "Rent Book";
            btnRentBook.UseVisualStyleBackColor = true;
            btnRentBook.Click += btnRentBook_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.Location = new Point(67, 308);
            btnReturnBook.Margin = new Padding(4, 5, 4, 5);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(267, 62);
            btnReturnBook.TabIndex = 2;
            btnReturnBook.Text = "Return Book";
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(67, 385);
            btnCreateUser.Margin = new Padding(4, 5, 4, 5);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(267, 62);
            btnCreateUser.TabIndex = 3;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // btnRemoveLibraryCard
            // 
            btnRemoveLibraryCard.Location = new Point(67, 462);
            btnRemoveLibraryCard.Margin = new Padding(4, 5, 4, 5);
            btnRemoveLibraryCard.Name = "btnRemoveLibraryCard";
            btnRemoveLibraryCard.Size = new Size(267, 62);
            btnRemoveLibraryCard.TabIndex = 4;
            btnRemoveLibraryCard.Text = "Remove Library Card";
            btnRemoveLibraryCard.UseVisualStyleBackColor = true;
            btnRemoveLibraryCard.Click += btnRemoveLibraryCard_Click;
            // 
            // btnViewAllBooks
            // 
            btnViewAllBooks.Location = new Point(67, 538);
            btnViewAllBooks.Margin = new Padding(4, 5, 4, 5);
            btnViewAllBooks.Name = "btnViewAllBooks";
            btnViewAllBooks.Size = new Size(267, 62);
            btnViewAllBooks.TabIndex = 5;
            btnViewAllBooks.Text = "View All Books";
            btnViewAllBooks.UseVisualStyleBackColor = true;
            btnViewAllBooks.Click += btnViewAllBooks_Click;
            // 
            // btnViewUsers
            // 
            btnViewUsers.Location = new Point(67, 615);
            btnViewUsers.Margin = new Padding(4, 5, 4, 5);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(267, 62);
            btnViewUsers.TabIndex = 6;
            btnViewUsers.Text = "View Users";
            btnViewUsers.UseVisualStyleBackColor = true;
            btnViewUsers.Click += btnViewUsers_Click;
            // 
            // btnViewRentals
            // 
            btnViewRentals.Location = new Point(67, 692);
            btnViewRentals.Margin = new Padding(4, 5, 4, 5);
            btnViewRentals.Name = "btnViewRentals";
            btnViewRentals.Size = new Size(267, 62);
            btnViewRentals.TabIndex = 7;
            btnViewRentals.Text = "View Rentals";
            btnViewRentals.UseVisualStyleBackColor = true;
            btnViewRentals.Click += btnViewRentals_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 31);
            label1.TabIndex = 8;
            label1.Text = "Library Management";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 770);
            Controls.Add(label1);
            Controls.Add(btnViewRentals);
            Controls.Add(btnViewUsers);
            Controls.Add(btnViewAllBooks);
            Controls.Add(btnRemoveLibraryCard);
            Controls.Add(btnCreateUser);
            Controls.Add(btnReturnBook);
            Controls.Add(btnRentBook);
            Controls.Add(btnAddBook);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Library Management System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRentBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnRemoveLibraryCard;
        private System.Windows.Forms.Button btnViewAllBooks;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnViewRentals;
        private System.Windows.Forms.Label label1;
    }
}