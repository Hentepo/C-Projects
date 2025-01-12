using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalMusicQuiz
{



    public class Utility
    {

        internal static int rndnum;

        internal static List<int> list = new List<int>();
        internal static Random rnd = new Random();

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
        public static void PrintMessage(string msg, bool success)
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
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
            PressEnterToContinue();
        }

        public static int generateNumber()
        {
            do
            {
                rndnum = rnd.Next(1, 11);
            }
            while (list.Contains(rndnum));

            list.Add(rndnum);

            return rndnum;
        }
    }
}

