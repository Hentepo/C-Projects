// See https://aka.ms/new-console-template for more information
using MetalMusicQuiz;

//Initial values
string userName;

//Start program
Console.ForegroundColor = ConsoleColor.White;

AppScreen.Welcome();
Utility.PressEnterToContinue();

while (true)
{
    AppScreen.DisplayMenu();

    int option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)
    {
        userName = Utility.GetUserInput("Username");
        Console.WriteLine("Welcome " + userName + "!");
        Utility.PressEnterToContinue();
        break;
    }
    else
    {
        Utility.PrintMessage("Invalid input", false);
    }
}