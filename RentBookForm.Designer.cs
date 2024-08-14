namespace LibraryManagementSystem
{
    partial class RentBookForm
    {
        /// <summary>
        /// Required designing variable.
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
            lblBookID = new Label();
            txtBookID = new TextBox();
            lblUserID = new Label();
            txtUserID = new TextBox();
            lblRentalDays = new Label();
            txtRentalDays = new TextBox();
            btnRentBook = new Button();
            SuspendLayout();
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Location = new Point(27, 31);
            lblBookID.Margin = new Padding(4, 0, 4, 0);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(65, 20);
            lblBookID.TabIndex = 0;
            lblBookID.Text = "Book ID:";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(160, 31);
            txtBookID.Margin = new Padding(4, 5, 4, 5);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(265, 27);
            txtBookID.TabIndex = 1;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(27, 77);
            lblUserID.Margin = new Padding(4, 0, 4, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(60, 20);
            lblUserID.TabIndex = 2;
            lblUserID.Text = "User ID:";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(160, 77);
            txtUserID.Margin = new Padding(4, 5, 4, 5);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(265, 27);
            txtUserID.TabIndex = 3;
            // 
            // lblRentalDays
            // 
            lblRentalDays.AutoSize = true;
            lblRentalDays.Location = new Point(27, 123);
            lblRentalDays.Margin = new Padding(4, 0, 4, 0);
            lblRentalDays.Name = "lblRentalDays";
            lblRentalDays.Size = new Size(90, 20);
            lblRentalDays.TabIndex = 4;
            lblRentalDays.Text = "Rental Days:";
            // 
            // txtRentalDays
            // 
            txtRentalDays.Location = new Point(160, 123);
            txtRentalDays.Margin = new Padding(4, 5, 4, 5);
            txtRentalDays.Name = "txtRentalDays";
            txtRentalDays.Size = new Size(265, 27);
            txtRentalDays.TabIndex = 5;
            // 
            // btnRentBook
            // 
            btnRentBook.Location = new Point(160, 185);
            btnRentBook.Margin = new Padding(4, 5, 4, 5);
            btnRentBook.Name = "btnRentBook";
            btnRentBook.Size = new Size(133, 46);
            btnRentBook.TabIndex = 6;
            btnRentBook.Text = "Rent Book";
            btnRentBook.UseVisualStyleBackColor = true;
            btnRentBook.Click += btnRentBook_Click;
            // 
            // RentBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 263);
            Controls.Add(btnRentBook);
            Controls.Add(txtRentalDays);
            Controls.Add(lblRentalDays);
            Controls.Add(txtUserID);
            Controls.Add(lblUserID);
            Controls.Add(txtBookID);
            Controls.Add(lblBookID);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RentBookForm";
            Text = "Rent Book";
            Load += RentBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblRentalDays;
        private System.Windows.Forms.TextBox txtRentalDays;
        private System.Windows.Forms.Button btnRentBook;
    }
}