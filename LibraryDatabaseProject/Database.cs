using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LibraryDatabaseProject
{
    public class Database
    {
        public static void ReadFromDatabase()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Your books: ");
            Console.WriteLine("---------------");
            string connstring = "Data Source=DESKTOP-G83IEC9;Initial Catalog=LibraryDatabase;Integrated Security=true;Encrypt=False";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string query = "Select * from Books";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                string bookTemp = "Book: " + reader.GetValue(0);
                string authorTemp = "Author: " + reader.GetValue(1);
                string yearTemp = "Author: " + reader.GetValue(2);
                Console.WriteLine(bookTemp);
                Console.WriteLine(authorTemp);
                Console.WriteLine(yearTemp);
                Console.WriteLine("---------------");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void WriteToDatabase()
        {
            string connectionString = "Data Source=DESKTOP-G83IEC9;Initial Catalog=LibraryDatabase;Integrated Security=true;Encrypt=False";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Books (Book, Author, Year) VALUES (@Book, @Author, @Year)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Collect user inputs
                        string bookName = Utilities.GetUserInput("Add book name: ");
                        string authorName = Utilities.GetUserInput("Add author name: ");
                        int year = Utilities.GetNumericInput("Add year: ");

                        // Add parameters to the query
                        command.Parameters.AddWithValue("@Book", bookName);
                        command.Parameters.AddWithValue("@Author", authorName);
                        command.Parameters.AddWithValue("@Year", year);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
