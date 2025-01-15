using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCatQuiz
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

//--------------------------------------------------------------------

        static public string Question1()
        {
            return "Mikä on maailman pienimmän kissarodun nimi?";
        }

        static public string Question1a()
        {
            return "a) Bengal";
        }
        static public string Question1b()
        {
            return "b) Maine Coon";
        }

        static public string Question1c()
        {
            return "c) Singapura";
        }

        static public string Question1d()
        {
            return "d) Abessinialainen";
        }

        //--------------------------------------------------------------------

        static public string Question2()
        {
            return "Mikä suuri kissaeläin on tunnettu siitä, ettei se osaa kehrätä?";
        }

        static public string Question2a()
        {
            return "a) Tiikeri";
        }
        static public string Question2b()
        {
            return "b) Leijona";
        }

        static public string Question2c()
        {
            return "c) Pantteri";
        }

        static public string Question2d()
        {
            return "d) Gepardi";
        }

        //--------------------------------------------------------------------

        static public string Question3()
        {
            return "Minkä antiikin kansan jumala Bastet kuvattiin usein kissan tai kissamaisen olennon muodossa?";
        }

        static public string Question3a()
        {
            return "a) Roomalaiset";
        }
        static public string Question3b()
        {
            return "b) Egyptiläiset";
        }

        static public string Question3c()
        {
            return "c) Kreikkalaiset";
        }

        static public string Question3d()
        {
            return "d) Mesopotamialaiset";
        }

        //--------------------------------------------------------------------

        static public string Question4()
        {
            return "Kuinka monta varvasta kissalla on yleensä etutassuissaan?";
        }

        static public string Question4a()
        {
            return "a) 4";
        }
        static public string Question4b()
        {
            return "b) 5";
        }

        static public string Question4c()
        {
            return "c) 6";
        }

        static public string Question4d()
        {
            return "d) 7";
        }

        //--------------------------------------------------------------------

        static public string Question5()
        {
            return "Mikä seuraavista kissoista on tunnettu lyhyestä hännästään tai sen puuttumisesta kokonaan?";
        }

        static public string Question5a()
        {
            return "a) Siamilainen";
        }
        static public string Question5b()
        {
            return "b) Manx";
        }

        static public string Question5c()
        {
            return "c) Persialainen";
        }

        static public string Question5d()
        {
            return "d) Ragdoll";
        }

        //--------------------------------------------------------------------

        static public string Question6()
        {
            return "Minkä värinen turkki on kissalla, joka tunnetaan nimellä ''kalikokissa''?";
        }
        static public string Question6a()
        {
            return "a) Valkoinen ja musta";
        }
        static public string Question6b()
        {
            return "b) Musta, valkoinen ja oranssi";
        }

        static public string Question6c()
        {
            return "c) Harmaa ja valkoinen";
        }

        static public string Question6d()
        {
            return "d) Ruskea ja musta";
        }

        //--------------------------------------------------------------------

        static public string Question7()
        {
            return "Mikä tekee erikoisen ''Scottish Fold'' -kissan ulkonäöstä?";
        }
        static public string Question7a()
        {
            return "a) Suorat korvat";
        }
        static public string Question7b()
        {
            return "b) Pystyssä olevat viikset";
        }

        static public string Question7c()
        {
            return "c) Lommollaan olevat korvat";
        }

        static public string Question7d()
        {
            return "d) Suuret, pyöreät silmät";
        }

        //--------------------------------------------------------------------

        static public string Question8()
        {
            return "Mikä on kissojen tieteellinen nimi?";
        }
        static public string Question8a()
        {
            return "a) Panthera leo";
        }
        static public string Question8b()
        {
            return "b) Felis catus";
        }

        static public string Question8c()
        {
            return "c) Lynx lynx";
        }

        static public string Question8d()
        {
            return "d) Felis silvestris";
        }

        //--------------------------------------------------------------------

        static public string Question9()
        {
            return "Mikä on maailman nopein kotikissa?";
        }
        static public string Question9a()
        {
            return "a) Bengal";
        }
        static public string Question9b()
        {
            return "b) Abyssinialainen";
        }

        static public string Question9c()
        {
            return "c) Egyptian Mau";
        }

        static public string Question9d()
        {
            return "d) Siamilainen";
        }

        //--------------------------------------------------------------------

        static public string Question10()
        {
            return "Mikä näistä kissoista ei ole luonnollisesti syntynyt rotu, vaan luotu risteytyksillä?";
        }
        static public string Question10a()
        {
            return "a) Maine Coon";
        }
        static public string Question10b()
        {
            return "b) Savannah";
        }

        static public string Question10c()
        {
            return "c) Norjalainen metsäkissa";
        }

        static public string Question10d()
        {
            return "d) Sfinx";
        }
    }
}