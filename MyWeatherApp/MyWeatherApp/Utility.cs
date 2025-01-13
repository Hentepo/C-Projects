using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeatherApp
{
    public static class Utility
    {
        public static void Welcome()
        {
            Console.WriteLine("--------MyWeatherApp--------");
            Console.WriteLine("Welcome to MyWeatherApp!");
            Console.WriteLine();
        }

        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("--------MyWeatherApp--------");
            Console.WriteLine("1. Check Weather            :");
            Console.WriteLine("2. Exit                     :");
        }

        public static void PressEnterToContinue()
        {
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }


    }
}