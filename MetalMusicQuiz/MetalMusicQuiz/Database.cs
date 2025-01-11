using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalMusicQuiz
{
    public class Database
    {
        public static int correctAnswerCount {  get; set; }

        public static void Question1()
        {
            Console.WriteLine("What year Metallica's debut album ''Kill Em All'' came out?");
            Console.WriteLine("");
            Console.WriteLine("1: 1986");
            Console.WriteLine("2: 1983");
            Console.WriteLine("3: 1984");
            Console.WriteLine("");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ForegroundColor = ConsoleColor.White;        
                correctAnswerCount += 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void Question2()
        {
            Console.WriteLine("How many records have Finnish band ''Children of Bodom'' recorded?");
            Console.WriteLine("");
            Console.WriteLine("1: 10");
            Console.WriteLine("2: 11");
            Console.WriteLine("3: 12");
            Console.WriteLine("");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ForegroundColor = ConsoleColor.White;
                correctAnswerCount += 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}
