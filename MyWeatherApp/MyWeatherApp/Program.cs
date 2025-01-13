using MyWeatherApp;

Console.ForegroundColor = ConsoleColor.White;

Utility.Welcome();
Utility.PressEnterToContinue();

while (true)
{
    Utility.DisplayMenu();

    try
    {
        int option = Convert.ToInt32(Console.ReadLine());

        if (option == 2)
        {
            Console.WriteLine("See you next time!");
            break;
        }
    }
    catch 
    {
        continue;
    }
}