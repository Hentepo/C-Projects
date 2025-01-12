using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalMusicQuiz
{
    public class Database
    {
        public static int correctAnswerCount {  get; set; }
        internal static string answer {  get; set; }

        public static void Question1()
        {
            while (true) 
            {
                Console.WriteLine("What year Metallica's debut album ''Kill Em All'' came out?");
                Console.WriteLine("");
                Console.WriteLine("a) 1986");
                Console.WriteLine("b) 1983");
                Console.WriteLine("c) 1984");
                Console.WriteLine("d) 1985");
                Console.WriteLine("");

                answer = Console.ReadLine();

                if (answer != "a" && answer != "b" && answer != "c" && answer != "d" && answer != "A" && answer != "B" && answer != "C" && answer != "D")
                {
                    Console.WriteLine("Invalid input! Please, choose ''a'', ''b'', ''c'' or ''d'' ");
                    continue;
                }
                else
                {
                    //Correct answer
                    if (answer == "b" || answer == "B")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor = ConsoleColor.White;
                        correctAnswerCount += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }
        }
        public static void Question2()
        {
            while (true)
            {
                Console.WriteLine("How many records have Finnish band ''Children of Bodom'' recorded?");
                Console.WriteLine("");
                Console.WriteLine("a) 10");
                Console.WriteLine("b) 11");
                Console.WriteLine("c) 12");
                Console.WriteLine("d) 13");
                Console.WriteLine("");

                answer = Console.ReadLine();

                if (answer != "a" && answer != "b" && answer != "c" && answer != "d" && answer != "A" && answer != "B" && answer != "C" && answer != "D")
                {
                    Console.WriteLine("Invalid input! Please, choose ''a'', ''b'', ''c'' or ''d'' ");
                    continue;
                }
                else
                {
                    //Correct answer
                    if (answer == "a" || answer == "A")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor = ConsoleColor.White;
                        correctAnswerCount += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }
        }
        public static void Question3()
        {
            while (true)
            {
                Console.WriteLine("Which 1980s thrash metal band released the influential album Bonded by Blood, often cited as one of the defining records of the genre?");
                Console.WriteLine("");
                Console.WriteLine("a) Metallica");
                Console.WriteLine("b) Slayer");
                Console.WriteLine("c) Exodus");
                Console.WriteLine("d) Testament");
                Console.WriteLine("");

                answer = Console.ReadLine();

                if (answer != "a" && answer != "b" && answer != "c" && answer != "d" && answer != "A" && answer != "B" && answer != "C" && answer != "D")
                {
                    Console.WriteLine("Invalid input! Please, choose ''a'', ''b'', ''c'' or ''d'' ");
                    continue;
                }
                else
                {
                    //Correct answer
                    if (answer == "c" || answer == "C")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor = ConsoleColor.White;
                        correctAnswerCount += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }
        }

        public static void Question4()
        {
            while (true)
            {
                Console.WriteLine("Which Swedish melodic death metal band is often credited with pioneering the ''Gothenburg sound'' with their 1995 album The Gallery ?");
                Console.WriteLine("");
                Console.WriteLine("a) In Flames");
                Console.WriteLine("b) Dark Tranquillity");
                Console.WriteLine("c) At the Gates");
                Console.WriteLine("d) Arch Enemy");
                Console.WriteLine("");

                answer = Console.ReadLine();

                if (answer != "a" && answer != "b" && answer != "c" && answer != "d" && answer != "A" && answer != "B" && answer != "C" && answer != "D")
                {
                    Console.WriteLine("Invalid input! Please, choose ''a'', ''b'', ''c'' or ''d'' ");
                    continue;
                }
                else
                {
                    //Correct answer
                    if (answer == "b" || answer == "B")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor = ConsoleColor.White;
                        correctAnswerCount += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }
        }

        public static void Question5()
        {
            while (true)
            {
                Console.WriteLine("Which Norwegian black metal band is known for their 1994 album De Mysteriis Dom Sathanas, a landmark release in the second wave of black metal?");
                Console.WriteLine("");
                Console.WriteLine("a) Emperor");
                Console.WriteLine("b) Mayhem");
                Console.WriteLine("c) Burzum");
                Console.WriteLine("d) Darkthrone");
                Console.WriteLine("");

                answer = Console.ReadLine();

                if (answer != "a" && answer != "b" && answer != "c" && answer != "d" && answer != "A" && answer != "B" && answer != "C" && answer != "D")
                {
                    Console.WriteLine("Invalid input! Please, choose ''a'', ''b'', ''c'' or ''d'' ");
                    continue;
                }
                else
                {
                    //Correct answer
                    if (answer == "b" || answer == "B")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor = ConsoleColor.White;
                        correctAnswerCount += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }
        }

        public static void Question6()
        {
            while (true)
            {
                Console.WriteLine("Which Finnish folk metal band, known for incorporating traditional Finnish instruments like the kantele, released the album Spirit of the Forest in 2003?");
                Console.WriteLine("");
                Console.WriteLine("a) Ensiferum");
                Console.WriteLine("b) Korpiklaani");
                Console.WriteLine("c) Finntroll");
                Console.WriteLine("d) Moonsorrow");
                Console.WriteLine("");

                answer = Console.ReadLine();

                if (answer != "a" && answer != "b" && answer != "c" && answer != "d" && answer != "A" && answer != "B" && answer != "C" && answer != "D")
                {
                    Console.WriteLine("Invalid input! Please, choose ''a'', ''b'', ''c'' or ''d'' ");
                    continue;
                }
                else
                {
                    //Correct answer
                    if (answer == "b" || answer == "B")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor = ConsoleColor.White;
                        correctAnswerCount += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }
        }

        public static void Question7()
        {
            while (true)
            {
                Console.WriteLine("Which early death metal band released the groundbreaking album Seven Churches in 1985, widely regarded as one of the first death metal albums?");
                Console.WriteLine("");
                Console.WriteLine("a) Death");
                Console.WriteLine("b) Possessed");
                Console.WriteLine("c) Morbid Angel");
                Console.WriteLine("d) Obituary");
                Console.WriteLine("");

                answer = Console.ReadLine();

                if (answer != "a" && answer != "b" && answer != "c" && answer != "d" && answer != "A" && answer != "B" && answer != "C" && answer != "D")
                {
                    Console.WriteLine("Invalid input! Please, choose ''a'', ''b'', ''c'' or ''d'' ");
                    continue;
                }
                else
                {
                    //Correct answer
                    if (answer == "b" || answer == "B")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor = ConsoleColor.White;
                        correctAnswerCount += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }
        }
        public static void Question8()
        {
            while (true)
            {
                Console.WriteLine("Which 1990 album by the thrash metal band Megadeth features politically charged tracks like \"Holy Wars... The Punishment Due\" and \"Hangar 18\"?");
                Console.WriteLine("");
                Console.WriteLine("a) Death");
                Console.WriteLine("b) Possessed");
                Console.WriteLine("c) Morbid Angel");
                Console.WriteLine("d) Obituary");
                Console.WriteLine("");

                answer = Console.ReadLine();

                if (answer != "a" && answer != "b" && answer != "c" && answer != "d" && answer != "A" && answer != "B" && answer != "C" && answer != "D")
                {
                    Console.WriteLine("Invalid input! Please, choose ''a'', ''b'', ''c'' or ''d'' ");
                    continue;
                }
                else
                {
                    //Correct answer
                    if (answer == "a" || answer == "A")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor = ConsoleColor.White;
                        correctAnswerCount += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }
        }

        public static void Question9()
        {
            while (true)
            {
                Console.WriteLine("Which Norwegian black metal band, led by Ihsahn, released the iconic album In the Nightside Eclipse in 1994?");
                Console.WriteLine("");
                Console.WriteLine("a) Mayhem");
                Console.WriteLine("b) Emperor");
                Console.WriteLine("c) Immortal");
                Console.WriteLine("d) Gorgoroth");
                Console.WriteLine("");

                answer = Console.ReadLine();

                if (answer != "a" && answer != "b" && answer != "c" && answer != "d" && answer != "A" && answer != "B" && answer != "C" && answer != "D")
                {
                    Console.WriteLine("Invalid input! Please, choose ''a'', ''b'', ''c'' or ''d'' ");
                    continue;
                }
                else
                {
                    //Correct answer
                    if (answer == "b" || answer == "B")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor = ConsoleColor.White;
                        correctAnswerCount += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }
        }

        public static void Question10()
        {
            while (true)
            {
                Console.WriteLine("Which folk metal band from Northern Europe is known for their 2007 album Victory Songs, featuring epic themes and the use of traditional folk melodies?");
                Console.WriteLine("");
                Console.WriteLine("a) Eluveitie");
                Console.WriteLine("b) Turisas");
                Console.WriteLine("c) Ensiferum");
                Console.WriteLine("d) Heidevolk");
                Console.WriteLine("");

                answer = Console.ReadLine();

                if (answer != "a" && answer != "b" && answer != "c" && answer != "d" && answer != "A" && answer != "B" && answer != "C" && answer != "D")
                {
                    Console.WriteLine("Invalid input! Please, choose ''a'', ''b'', ''c'' or ''d'' ");
                    continue;
                }
                else
                {
                    //Correct answer
                    if (answer == "c" || answer == "C")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor = ConsoleColor.White;
                        correctAnswerCount += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
            }
        }

    }
}
