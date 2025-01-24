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
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static int GetNumericInput(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

        public static int ChooseOptionInput()
        {
            while (true)
            {
                Console.WriteLine();

                AppScreen.Menu();

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
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
