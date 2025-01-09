using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    public class AppScreen

    {
        internal static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("----------My Tasklist----------");
            Console.WriteLine();
            Console.WriteLine(":1. Check Tasks                        :");
            Console.WriteLine(":2. Add Task                           :");
            Console.WriteLine(":3. Remove Task                        :");
        }
        internal static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("----------My Tasklist App----------");
            Console.WriteLine("Welcome to My Tasklist App!");
        }


    }
}
