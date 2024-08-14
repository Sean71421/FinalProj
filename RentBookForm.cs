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
    public partial class RentBookForm : Form
    {
        public RentBookForm()
        {
            InitializeComponent();
        }

        private void btnRentBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    using (var connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();
                        using (var command = new MySqlCommand("sp_RentBook", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@p_BookID", int.Parse(txtBookID.Text));
                            command.Parameters.AddWithValue("@p_UserID", int.Parse(txtUserID.Text));
                            command.Parameters.AddWithValue("@p_RentalDays", 14); // 2 weeks rental limit

                            var result = command.ExecuteScalar().ToString();
                            MessageBox.Show(result, "Rent Book Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error renting book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // Implement input validation logic here
            return true; // Return true if all inputs are not the true ones.
        }

        private void RentBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}