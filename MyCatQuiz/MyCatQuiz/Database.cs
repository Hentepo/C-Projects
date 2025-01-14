using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCatQuiz
{
    public class Database
    {
        public static int correctAnswerCount { get; set; }
        internal static string answer { get; set; }

        public static void Question1()
        {
            while (true)
            {
                Console.WriteLine("Mikä on maailman pienimmän kissarodun nimi?");
                Console.WriteLine("");
                Console.WriteLine("a) Bengal");
                Console.WriteLine("b) Maine Coon");
                Console.WriteLine("c) Singapura");
                Console.WriteLine("d) Abessinialainen");
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
        public static void Question2()
        {
            while (true)
            {
                Console.WriteLine("Mikä suuri kissaeläin on tunnettu siitä, ettei se osaa kehrätä?");
                Console.WriteLine("");
                Console.WriteLine("a) Tiikeri");
                Console.WriteLine("b) Leijona");
                Console.WriteLine("c) Pantteri");
                Console.WriteLine("d) Gepardi");
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
                    if (answer == "d" || answer == "D")
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
                Console.WriteLine("Minkä antiikin kansan jumala Bastet kuvattiin usein kissan tai kissamaisen olennon muodossa?");
                Console.WriteLine("");
                Console.WriteLine("a) Roomalaiset");
                Console.WriteLine("b) Egyptiläiset");
                Console.WriteLine("c) Kreikkalaiset");
                Console.WriteLine("d) Mesopotamialaiset");
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

        public static void Question4()
        {
            while (true)
            {
                Console.WriteLine("Kuinka monta varvasta kissalla on yleensä etutassuissaan?");
                Console.WriteLine("");
                Console.WriteLine("a) 4");
                Console.WriteLine("b) 5");
                Console.WriteLine("c) 6");
                Console.WriteLine("d) 7");
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
                Console.WriteLine("Mikä seuraavista kissoista on tunnettu lyhyestä hännästään tai sen puuttumisesta kokonaan?");
                Console.WriteLine("");
                Console.WriteLine("a) Siamilainen");
                Console.WriteLine("b) Manx");
                Console.WriteLine("c) Persialainen");
                Console.WriteLine("d) Ragdoll");
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
                Console.WriteLine("Minkä värinen turkki on kissalla, joka tunnetaan nimellä ''kalikokissa''?");
                Console.WriteLine("");
                Console.WriteLine("a) Valkoinen ja musta");
                Console.WriteLine("b) Musta, valkoinen ja oranssi");
                Console.WriteLine("c) Harmaa ja valkoinen");
                Console.WriteLine("d) Ruskea ja musta");
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
                Console.WriteLine("Mikä tekee erikoisen ''Scottish Fold'' -kissan ulkonäöstä?");
                Console.WriteLine("");
                Console.WriteLine("a) Suorat korvat");
                Console.WriteLine("b) Pystyssä olevat viikset");
                Console.WriteLine("c) Lommollaan olevat korvat");
                Console.WriteLine("d) Suuret, pyöreät silmät");
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
        public static void Question8()
        {
            while (true)
            {
                Console.WriteLine("Mikä on kissojen tieteellinen nimi?");
                Console.WriteLine("");
                Console.WriteLine("a) Panthera leo");
                Console.WriteLine("b) Felis catus");
                Console.WriteLine("c) Lynx lynx");
                Console.WriteLine("d) Felis silvestris");
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

        public static void Question9()
        {
            while (true)
            {
                Console.WriteLine("Mikä on maailman nopein kotikissa?");
                Console.WriteLine("");
                Console.WriteLine("a) Bengal");
                Console.WriteLine("b) Abyssinialainen");
                Console.WriteLine("c) Egyptian Mau");
                Console.WriteLine("d) Siamilainen");
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

        public static void Question10()
        {
            while (true)
            {
                Console.WriteLine("Mikä näistä kissoista ei ole luonnollisesti syntynyt rotu, vaan luotu risteytyksillä?");
                Console.WriteLine("");
                Console.WriteLine("a) Maine Coon");
                Console.WriteLine("b) Savannah");
                Console.WriteLine("c) Norjalainen metsäkissa");
                Console.WriteLine("d) Sfinx");
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

        public static void Question11()
        {
            while (true)
            {
                Console.WriteLine("Mikä aistielin kissalla on erityisesti tarkoitettu hajujen analysointiin?");
                Console.WriteLine("");
                Console.WriteLine("a) Jacobsonin elin");
                Console.WriteLine("b) Hypotalamus");
                Console.WriteLine("c) Limbinen järjestelmä");
                Console.WriteLine("d) Reseptorikieli");
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

        public static void Question12()
        {
            while (true)
            {
                Console.WriteLine("Mikä villikissa on levinneisyydeltään maailman laajin?");
                Console.WriteLine("");
                Console.WriteLine("a) Lumileopardi");
                Console.WriteLine("b) Ilves");
                Console.WriteLine("c) Pantteri");
                Console.WriteLine("d) Leopardikissa");
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

        public static void Question13()
        {
            while (true)
            {
                Console.WriteLine("Minkä vuoksi kissojen silmät kiiltävät pimeässä?");
                Console.WriteLine("");
                Console.WriteLine("a) Niissä on erityisiä valoherkkiä soluja");
                Console.WriteLine("b) Silmien takana on heijastava kerros nimeltä tapetum lucidum");
                Console.WriteLine("c) Niiden pupillit laajenevat täysin");
                Console.WriteLine("d) Se on heijastus verkkokalvon nesteestä");
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

        public static void Question14()
        {
            while (true)
            {
                Console.WriteLine("Mikä kissarotu tunnetaan myös ''koiramaisena kissana''?");
                Console.WriteLine("");
                Console.WriteLine("a) Maine Coon");
                Console.WriteLine("b) Siamilainen");
                Console.WriteLine("c) Ragdoll");
                Console.WriteLine("d) Abessinialainen");
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
    }
}
