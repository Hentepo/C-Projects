// See https://aka.ms/new-console-template for more information
using MetalMusicQuiz;

//Initial values
string userName = null;
int questionCount = 1;

int question;

bool question1 = false;
bool question2 = false;
bool question3 = false;
bool question4 = false;
bool question5 = false;
bool question6 = false;
bool question7 = false;
bool question8 = false;
bool question9 = false;
bool question10 = false;

//Start program
Console.ForegroundColor = ConsoleColor.White;

AppScreen.Welcome();
Utility.PressEnterToContinue();

while (true)
{
    AppScreen.DisplayMenu();


    try
    {

        int option = Convert.ToInt32(Console.ReadLine());

        if (option == 1)
        {
            userName = Utility.GetUserInput("Username");
            Console.WriteLine("");
            Console.WriteLine("Welcome " + userName + "!");
            Utility.PressEnterToContinue();
            Database.correctAnswerCount = 0;

            while (questionCount < 6)
            {

                question = Utility.generateNumber();

                if (question == 1)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question1();
                    Utility.PressEnterToContinue();
                    questionCount++;
                    question1 = true;
                }

                else if (question == 2)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question2();
                    Utility.PressEnterToContinue();
                    questionCount++;
                    question2 = true;
                }

                else if (question == 3)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question3();
                    Utility.PressEnterToContinue();
                    questionCount++;
                    question3 = true;
                }

                else if (question == 4)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question4();
                    Utility.PressEnterToContinue();
                    questionCount++;
                    question4 = true;
                }

                else if (question == 5)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question5();
                    Utility.PressEnterToContinue();
                    questionCount++;
                    question5 = true;
                }

                else if (question == 6)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question6();
                    Utility.PressEnterToContinue();
                    questionCount++;
                    question6 = true;
                }

                else if (question == 7)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question7();
                    Utility.PressEnterToContinue();
                    questionCount++;
                    question7 = true;
                }

                else if (question == 8)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question8();
                    Utility.PressEnterToContinue();
                    questionCount++;
                    question8 = true;
                }

                else if (question == 9)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question9();
                    Utility.PressEnterToContinue();
                    questionCount++;
                    question9 = true;
                }

                else if (question == 10)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question10();
                    Utility.PressEnterToContinue();
                    questionCount++;
                    question10 = true;
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

    catch (Exception ex)
    {
        continue;
    }
}