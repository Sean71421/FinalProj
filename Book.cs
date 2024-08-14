using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    using System;
    using MySql.Data.MySqlClient;

    /// <summary>
    /// Represents a book in the library system.
    /// </summary>
    public class Book : LibraryItem, ILoanable
    {
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
        public string Description { get; set; }
        public string GenreName { get; set; }
        public int AvailableQuantity { get; set; }

        /// <summary>
        /// Displays information about the book.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine($"Book: {Title} (ISBN: {ISBN})");
            Console.WriteLine($"Published: {PublicationYear}, Genre: {GenreName}");
            Console.WriteLine($"Available Quantity: {AvailableQuantity}");
            Console.WriteLine($"Description: {Description}");
        }

        /// <summary>
        /// Checks out the book to a user.
        /// </summary>
        /// <param name="userID">The ID of the user checking out the book.</param>
        public void Checkout(int userID)
        {
            using (var connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new MySqlCommand("sp_RentBook", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_BookID", ID);
                        command.Parameters.AddWithValue("@p_UserID", userID);
                        command.Parameters.AddWithValue("@p_RentalDays", 14); // 2 weeks rental period

                        var result = command.ExecuteScalar().ToString();
                        Console.WriteLine(result);
                    }
                }
                catch (MySqlException ex)
                {
                    throw new LibraryException("Error checking out book: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Returns the book to the library.
        /// </summary>
        public void Return()
        {
            using (var connection = DatabaseManager.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new MySqlCommand("sp_ReturnBook", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_RentalID", ID); // Assuming RentalID is stored in the ID property

                        var result = command.ExecuteScalar().ToString();
                        Console.WriteLine(result);
                    }
                }
                catch (MySqlException ex)
                {
                    throw new LibraryException("Error returning book: " + ex.Message);
                }
            }
        }
    }

}