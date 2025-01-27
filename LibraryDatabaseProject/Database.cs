using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
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
            string query = "Select * from BooksNew";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                string idTemp = "Id: " + reader.GetValue(0);
                string bookTemp = "Book: " + reader.GetValue(1);
                string authorTemp = "Author: " + reader.GetValue(2);
                string yearTemp = "Year: " + reader.GetValue(3);
                Console.WriteLine(idTemp);
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
                    string query = "INSERT INTO BooksNew (Book, Author, Year) VALUES (@Book, @Author, @Year)";

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
                        Console.WriteLine($"{rowsAffected} Book added successfully.");
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
        public static void DeleteFromDatabase()
        {
            string connectionString = "Data Source=DESKTOP-G83IEC9;Initial Catalog=LibraryDatabase;Integrated Security=true;Encrypt=False";

            // Collect user inputs
            int bookId = Utilities.GetNumericInput("enter the book id to delete: ");


            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM BooksNew where Id = @Id";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@Id", bookId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string bookTemp = reader.GetString(1);
                        string authorTemp = reader.GetString(2);
                        int yearTemp = Convert.ToInt32(reader.GetDecimal(3));

                        reader.Close();

                        string query1 = "DELETE FROM BooksNew WHERE Id = @Id AND Book = @Book AND Author = @Author AND Year = @Year";

                        using (SqlCommand deleteCommand = new SqlCommand(query1, con))
                        {
                            deleteCommand.Parameters.AddWithValue("@Id", bookId);
                            deleteCommand.Parameters.AddWithValue("@Book", bookTemp);
                            deleteCommand.Parameters.AddWithValue("@Author", authorTemp);
                            deleteCommand.Parameters.AddWithValue("@Year", yearTemp);

                            // execute the query
                            int rowsaffected = deleteCommand.ExecuteNonQuery();
                            if (rowsaffected > 0)
                            {
                                Console.WriteLine("Book deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Book not found!");
                            }
                        }
                    }
                }

            }
        }


        //public static void DeleteFromdatabase()
        //{
        //    string connectionstring = "data source=desktop-g83iec9;initial catalog=librarydatabase;integrated security=true;encrypt=false";

        //    try
        //    {
        //        using (sqlconnection connection = new sqlconnection(connectionstring))
        //        {
        //            connection.open();
        //            string query = "delete from books where book = @book and author = @author and year = @year";

        //            using (sqlcommand command = new sqlcommand(query, connection))
        //            {
        //                // collect user inputs
        //                string bookname = utilities.getuserinput("enter book id to delete: ");
        //                string authorname = utilities.getuserinput("enter author name to delete: ");
        //                int year = utilities.getnumericinput("enter the year to delete: ");

        //                // add parameters to the query
        //                command.parameters.addwithvalue("@book", bookname);
        //                command.parameters.addwithvalue("@author", authorname);
        //                command.parameters.addwithvalue("@year", year);

        //                // execute the query
        //                int rowsaffected = command.executenonquery();
        //                if (rowsaffected > 0)
        //                {
        //                    console.writeline("book deleted successfully");
        //                }
        //                else
        //                {
        //                    console.writeline("invalid input, book not found!");
        //                }
        //            }
        //        }
        //    }
        //    catch (sqlexception ex)
        //    {
        //        console.writeline($"database error: {ex.message}");
        //    }
        //    catch (exception ex)
        //    {
        //        console.writeline($"an unexpected error occurred: {ex.message}");
        //    }
        //}




    }
}
