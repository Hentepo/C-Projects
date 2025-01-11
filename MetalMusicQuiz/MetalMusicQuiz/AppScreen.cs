using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalMusicQuiz
{
    public class AppScreen
    {
        static public void Welcome()
        {
            Console.WriteLine("--------Metal Music Quiz--------");
            Console.WriteLine("Welcome to Metal Music Quiz!");
            Console.WriteLine();
        }
        static public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("--------Metal Music Quiz--------");
            Console.WriteLine("1. Start Quiz                  :");
            Console.WriteLine("2. Check Scoreboard            :");
            Console.WriteLine("3. Exit                        :");
        }



    }
}
