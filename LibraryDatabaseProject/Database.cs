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
            string connstring = "Data Source=DESKTOP-G83IEC9;Initial Catalog=LibraryDatabase;Integrated Security=true;Encrypt=False";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string query = "Select * from Books";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                Console.WriteLine();
                string bookTemp = "Book: " + reader.GetValue(0);
                string authorTemp = "Author: " + reader.GetValue(1);
                string yearTemp = "Author: " + reader.GetValue(2);
                Console.WriteLine(bookTemp);
                Console.WriteLine(authorTemp);
                Console.WriteLine(yearTemp);
                Console.WriteLine();
            }
        }

        public static void WriteToDatabase()
        {

            string connstring = "Data Source=DESKTOP-G83IEC9;Initial Catalog=LibraryDatabase;Integrated Security=true;Encrypt=False";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string query = "INSERT INTO Books(Book,Author,Year) VALUES(@param1,@param2,@param3)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = "Pekka ja patka";
                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = "No Pekka ite";
                cmd.Parameters.Add("@param3", SqlDbType.Int).Value = 2000;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
