// See https://aka.ms/new-console-template for more information
using MetalMusicQuiz;

//Initial values
string userName = null;
int questionCount = 1;

string question;




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
        Console.WriteLine("");
        Console.WriteLine("Welcome " + userName + "!");
        Utility.PressEnterToContinue();
        Database.correctAnswerCount = 0;
        Console.WriteLine("-------------------------");
        Console.WriteLine("Question " + Convert.ToString(questionCount));
        Database.Question1();
        Utility.PressEnterToContinue();
        Database.Question2();

        if (Database.correctAnswerCount == 0)
        {
            Utility.PrintMessage("Your score is " + Convert.ToString(Database.correctAnswerCount), false);
        }
        else 
        {
            Utility.PrintMessage("Your score is " + Convert.ToString(Database.correctAnswerCount), true);
        }
        break;
    }
    if (option == 3)
    {
        if (userName != null)               
        {
            Console.WriteLine("See you next time!" + userName);
        }
        else
        {
            Console.WriteLine("See you next time!");
            break;
        }
    }
    else
    {
        Utility.PrintMessage("Invalid input", false);
    }
}