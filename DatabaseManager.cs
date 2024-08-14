using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagmentSystem
{
    /// <summary>
    /// Manages Database Connections And operations for the Library Management System.
    /// </summary>
    public static class DatabaseManager
    {
        private static string connectionString = "server=localhost;port=3306;user=root;password=qazwsx123;database=library_managment_system;";
        /// <summary>
        /// Gets a new MySqlConnection object with the configured connection string.
        /// </summary>
        /// <returns>A MySqlConnection object.</returns>
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        /// <summary>
        /// executes a SQL query and returns the result as a Dataable.
        /// </summary>
        /// <param name="query">The SQL query to execute.</param>
        /// <returns>A DataTable containing the query results.</returns>
        public static DataTable ExecuteQuery(string query)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
                catch (MySqlException ex)
                {
                    throw new LibraryException("Database error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Executes a SQL command that doesn't return a result set
        /// </summary>
        /// <param name="query">The SQL command to execute.</param>
        /// <returns>The number of rows affected.</returns>
        public static int ExecuteNonQuery(string query)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        return command.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    throw new LibraryException("Database error: " + ex.Message);
                }
            }
      
        }

        public static DataTable ExecuteStoredProcedure(string procedureName)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new MySqlCommand(procedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing stored procedure: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }


    }
}