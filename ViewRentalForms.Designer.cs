namespace LibraryManagementSystem
{
    partial class ViewRentalForm
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
            this.dataGridViewRentals = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRentals
            // 
            this.dataGridViewRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentals.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewRentals.Name = "dataGridViewRentals";
            this.dataGridViewRentals.Size = new System.Drawing.Size(776, 349);
            this.dataGridViewRentals.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(713, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "View Rentals";
            // 
            // ViewRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewRentals);
            this.Name = "ViewRentalForm";
            this.Text = "View Rentals";
            this.Load += new System.EventHandler(this.ViewRentalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRentals;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitle;
    }
}