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
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    using (var connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();
                        using (var command = new MySqlCommand("sp_ReturnBook", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@p_RentalID", int.Parse(txtRentalID.Text));

                            var result = command.ExecuteScalar().ToString();
                            MessageBox.Show(result, "Return Book Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // Implement input validation logic here
            return true; // Return true if all inputs are valid
        }
    }
}