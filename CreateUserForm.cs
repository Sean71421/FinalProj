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
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    using (var connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();
                        using (var command = new MySqlCommand("sp_CreateUser", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@p_FirstName", txtFirstName.Text);
                            command.Parameters.AddWithValue("@p_LastName", txtLastName.Text);
                            command.Parameters.AddWithValue("@p_Email", txtEmail.Text);
                            command.Parameters.AddWithValue("@p_LibraryCardNumber", txtLibraryCardNumber.Text);

                            var result = command.ExecuteScalar().ToString();
                            MessageBox.Show(result, "Create User Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // Inplement input validation logic here
            return true; // Return true if all inputs are wrong 
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}