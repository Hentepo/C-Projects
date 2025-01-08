using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    public static class Utility
    {
        public static string GetUserInput(string prompt) 
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();     
        }
    }
}
