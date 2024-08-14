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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    using (var connection = DatabaseManager.GetConnection())
                    {
                        connection.Open();
                        using (var command = new MySqlCommand("sp_AddNewBook", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@p_Title", txtTitle.Text);
                            command.Parameters.AddWithValue("@p_ISBN", txtISBN.Text);
                            command.Parameters.AddWithValue("@p_PublicationYear", int.Parse(txtPublicationYear.Text));
                            command.Parameters.AddWithValue("@p_Description", txtDescription.Text);
                            command.Parameters.AddWithValue("@p_GenreID", cmbGenre.SelectedValue);
                            command.Parameters.AddWithValue("@p_Quantity", int.Parse(txtQuantity.Text));
                            command.Parameters.AddWithValue("@p_AuthorIDs", txtAuthorIDs.Text);

                            var result = command.ExecuteScalar().ToString();
                            MessageBox.Show(result, "Add Book Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // Implement input validation logic here
            return true; // Return true if all inputs are valid
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}