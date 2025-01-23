using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDatabaseProject
{
    public class AppScreen
    {
        static public String? bookTemp;

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

        static public void PrintBooks()
        {
            Console.WriteLine();
            Console.WriteLine("Current books: ");
            Console.WriteLine();
            Utilities.PressEnterToContinue();
        }

        static public void AddBook()
        {
            Console.WriteLine("");
            Console.WriteLine("Insert Book to Add");
            bookTemp = Console.ReadLine();
            Console.WriteLine(bookTemp + " added!");
            Console.WriteLine();
            Utilities.PressEnterToContinue();
        }

        static public void DeleteBook()
        {
            Console.WriteLine("");
            Console.WriteLine("Current books: ");
            Console.WriteLine("");
            Console.WriteLine("Which book to delete?");
            bookTemp = Console.ReadLine();
            Console.WriteLine(bookTemp + " deleted!");
            Console.WriteLine();
            Utilities.PressEnterToContinue();
        }



        static public void Options()
        {
            while (true)
            {
                Menu();

                try
                {
                    int option = Convert.ToInt16(Console.ReadLine());

                    if (option == 1)
                    {
                        PrintBooks();
                    }
                    else if (option == 2)
                    {
                        AddBook();
                    }
                    else if (option == 3)
                    {
                        DeleteBook();
                    }
                    else if (option == 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please, choose option 1, 2, 3 or 4");
                        Utilities.PressEnterToContinue();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please, choose option 1, 2, 3 or 4");
                    Utilities.PressEnterToContinue();
                    continue;
                }
            }
        }
    }
}
