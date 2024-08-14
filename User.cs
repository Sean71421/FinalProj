using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using MySql.Data.MySqlClient;


namespace LibraryManagmentSystem
{

    /// <summary>
    /// Represents a single user in the library system
    /// </summary>
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string LibraryCardNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// Creates more new user in the library system.
        /// </summary>
        public void Create()
        {
            using (var connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new MySqlCommand("sp_CreateUser", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_FirstName", FirstName);
                        command.Parameters.AddWithValue("@p_LastName", LastName);
                        command.Parameters.AddWithValue("@p_Email", Email);
                        command.Parameters.AddWithValue("@p_LibraryCardNumber", LibraryCardNumber);

                        var result = command.ExecuteScalar().ToString();
                        Console.WriteLine(result);
                    }
                }
                catch (MySqlException ex)
                {
                    throw new LibraryException("Error creating user: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Removes the user's library card (remove suer from database)
        /// </summary>
        public void RemoveLibraryCard()
        {
            using (var connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new MySqlCommand("sp_RemoveLibraryCard", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_UserID", UserID);

                        var result = command.ExecuteScalar().ToString();
                        Console.WriteLine(result);
                    }
                }
                catch (MySqlException ex)
                {
                    throw new LibraryException("Error removing library card: " + ex.Message);
                }
            }
        }
    }
}
