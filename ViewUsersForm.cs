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
    public partial class ViewUsersForm : Form
    {
        public ViewUsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            var dataTable = DatabaseManager.ExecuteStoredProcedure("sp_GetAllUsers");
            if (dataTable != null)
            {
                dataGridViewUsers.DataSource = dataTable;
                FormatDataGridView();
            }
        }

        private void FormatDataGridView()
        {
            dataGridViewUsers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewUsers.Columns["TotalFines"].DefaultCellStyle.Format = "C2";
            dataGridViewUsers.Columns["RegistrationDate"].DefaultCellStyle.Format = "d";
            dataGridViewUsers.Columns["IsActive"].DefaultCellStyle.Format = "Yes;No;";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}