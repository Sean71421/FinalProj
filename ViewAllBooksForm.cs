using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LibraryManagmentSystem;

namespace LibraryManagementSystem
{
    public partial class ViewAllBooksForm : Form
    {
        public ViewAllBooksForm()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                using (var connection = DatabaseManager.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM vw_AvailableBooks";
                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        System.Data.DataTable dataTable = new System.Data.DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewBooks.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }

}
