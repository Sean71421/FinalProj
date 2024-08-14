namespace LibraryManagementSystem
{
    partial class CreateUserForm
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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblLibraryCardNumber = new Label();
            txtLibraryCardNumber = new TextBox();
            btnCreateUser = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(27, 31);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(187, 31);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(265, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(27, 77);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(187, 77);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(265, 27);
            txtLastName.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(27, 123);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(187, 123);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 27);
            txtEmail.TabIndex = 5;
            // 
            // lblLibraryCardNumber
            // 
            lblLibraryCardNumber.AutoSize = true;
            lblLibraryCardNumber.Location = new Point(27, 169);
            lblLibraryCardNumber.Margin = new Padding(4, 0, 4, 0);
            lblLibraryCardNumber.Name = "lblLibraryCardNumber";
            lblLibraryCardNumber.Size = new Size(150, 20);
            lblLibraryCardNumber.TabIndex = 6;
            lblLibraryCardNumber.Text = "Library Card Number:";
            // 
            // txtLibraryCardNumber
            // 
            txtLibraryCardNumber.Location = new Point(187, 169);
            txtLibraryCardNumber.Margin = new Padding(4, 5, 4, 5);
            txtLibraryCardNumber.Name = "txtLibraryCardNumber";
            txtLibraryCardNumber.Size = new Size(265, 27);
            txtLibraryCardNumber.TabIndex = 7;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(187, 231);
            btnCreateUser.Margin = new Padding(4, 5, 4, 5);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(133, 46);
            btnCreateUser.TabIndex = 8;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 309);
            Controls.Add(btnCreateUser);
            Controls.Add(txtLibraryCardNumber);
            Controls.Add(lblLibraryCardNumber);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CreateUserForm";
            Text = "Create User";
            Load += CreateUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLibraryCardNumber;
        private System.Windows.Forms.TextBox txtLibraryCardNumber;
        private System.Windows.Forms.Button btnCreateUser;
    }
}