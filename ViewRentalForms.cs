using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagmentSystem;

namespace LibraryManagementSystem
{
    public partial class ViewRentalForm : Form
    {
        public ViewRentalForm()
        {
            InitializeComponent();
        }

        private void ViewRentalForm_Load(object sender, EventArgs e)
        {
            LoadRentals();
        }

        private void LoadRentals()
        {
            try
            {
                string query = "CALL sp_GetAllRentals()";
                DataTable rentalsTable = DatabaseManager.ExecuteQuery(query);
                if (rentalsTable != null)
                {
                    dataGridViewRentals.DataSource = rentalsTable;
                    FormatDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rentals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            dataGridViewRentals.Columns["RentalDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            dataGridViewRentals.Columns["DueDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            dataGridViewRentals.Columns["ReturnDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            dataGridViewRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRentals();
        }
    }
}
