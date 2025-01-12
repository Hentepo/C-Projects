// See https://aka.ms/new-console-template for more information
using MetalMusicQuiz;

//Initial values
string userName = null;
int questionCount = 1;

int question;

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

        while (questionCount <6) 
        {

            question = Utility.generateNumber();

            if (question == 1)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Question " + Convert.ToString(questionCount));
                Database.Question1();
                Utility.PressEnterToContinue();
                questionCount ++;
            }

            else if (question == 2)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Question " + Convert.ToString(questionCount));
                Database.Question2();
                Utility.PressEnterToContinue();
                questionCount++;
            }

            else if (question == 3)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Question " + Convert.ToString(questionCount));
                Database.Question3();
                Utility.PressEnterToContinue();
                questionCount++;
            }

            else if (question == 4)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Question " + Convert.ToString(questionCount));
                Database.Question4();
                Utility.PressEnterToContinue();
                questionCount++;
            }

            else if (question == 5)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Question " + Convert.ToString(questionCount));
                Database.Question5();
                Utility.PressEnterToContinue();
                questionCount++;
            }
        }

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