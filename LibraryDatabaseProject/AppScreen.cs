using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDatabaseProject
{
    internal class AppScreen
    {
        static public void Welcome()
        {
            Console.WriteLine("---------------MyLibrary---------------");
            Console.WriteLine("Welcome to MyLibrary!");
            Console.WriteLine();
        }

        static public void Menu()
        {
            Console.WriteLine("---------------MyLibrary---------------");
            Console.WriteLine("1. Show My Books                      :");
            Console.WriteLine("2. Add Book                           :");
            Console.WriteLine("3. Delete Book                        :");
            Console.WriteLine("4. Exit                               :");
            Console.WriteLine();
        }
    }
}
