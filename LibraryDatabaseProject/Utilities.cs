using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDatabaseProject
{
    internal class Utilities
    {
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }

        public static void PressEnterToContinue()
        {
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }

        public static void DisplayMessage(string message, bool success)
        {
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine();
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            PressEnterToContinue();
        }
    }
}
