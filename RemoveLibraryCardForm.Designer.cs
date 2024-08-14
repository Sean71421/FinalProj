namespace LibraryManagementSystem
{
    partial class RemoveLibraryCardForm
    {
        /// <summary>
        /// Required desiging variable.
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
            lblUserID = new Label();
            txtUserID = new TextBox();
            btnRemoveLibraryCard = new Button();
            SuspendLayout();
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(27, 31);
            lblUserID.Margin = new Padding(4, 0, 4, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(60, 20);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "User ID:";
            // 
            // TesxUserID
            // 
            txtUserID.Location = new Point(160, 31);
            txtUserID.Margin = new Padding(4, 5, 4, 5);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(265, 27);
            txtUserID.TabIndex = 1;
            // 
            // btnRemoveLibraryCard
            // 
            btnRemoveLibraryCard.Location = new Point(160, 92);
            btnRemoveLibraryCard.Margin = new Padding(4, 5, 4, 5);
            btnRemoveLibraryCard.Name = "btnRemoveLibraryCard";
            btnRemoveLibraryCard.Size = new Size(200, 46);
            btnRemoveLibraryCard.TabIndex = 2;
            btnRemoveLibraryCard.Text = "Remove Library Card";
            btnRemoveLibraryCard.UseVisualStyleBackColor = true;
            btnRemoveLibraryCard.Click += btnRemoveLibraryCard_Click;
            // 
            // RemoveLibraryCardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 171);
            Controls.Add(btnRemoveLibraryCard);
            Controls.Add(txtUserID);
            Controls.Add(lblUserID);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RemoveLibraryCardForm";
            Text = "Remove Library Card";
            Load += RemoveLibraryCardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnRemoveLibraryCard;
    }
}