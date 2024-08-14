namespace LibraryManagementSystem
{
    partial class ReturnBookForm
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

        #region 

        private void InitializeComponent()
        {
            this.lblRentalID = new System.Windows.Forms.Label();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.btnReturnBook = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Location = new System.Drawing.Point(20, 20);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(55, 13);
            this.lblRentalID.TabIndex = 0;
            this.lblRentalID.Text = "Rental ID:";
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(120, 20);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(200, 20);
            this.txtRentalID.TabIndex = 1;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(120, 60);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(100, 30);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 111);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.lblRentalID);
            this.Name = "ReturnBookForm";
            this.Text = "Return Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Button btnReturnBook;
    }
}