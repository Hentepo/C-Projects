// See https://aka.ms/new-console-template for more information
using MetalMusicQuiz;

//Initial values
string userName = null;
string filePath = "data.txt";
string score;
//string[] lines = File.ReadAllLines(filePath);

int questionCount = 1;

int question;




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
            questionCount = 1;
            Utility.list.Clear();

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

                else if (question == 6)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question6();
                    Utility.PressEnterToContinue();
                    questionCount++;
                }

                else if (question == 7)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question7();
                    Utility.PressEnterToContinue();
                    questionCount++;
                }

                else if (question == 8)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question8();
                    Utility.PressEnterToContinue();
                    questionCount++;
                }

                else if (question == 9)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question9();
                    Utility.PressEnterToContinue();
                    questionCount++;
                }

                else if (question == 10)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Question " + Convert.ToString(questionCount));
                    Database.Question10();
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
                File.AppendAllText(filePath,"\n" + userName + ": " + Database.correctAnswerCount + " points");
            }
            continue;
        }
        else if (option == 2)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                if (line.EndsWith("5 points"))
                {
                    Console.WriteLine(line);
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("4 points"))
                {
                    Console.WriteLine(line);
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("3 points"))
                {
                    Console.WriteLine(line);
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("2 points"))
                {
                    Console.WriteLine(line);
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("1 points"))
                {
                    Console.WriteLine(line);
                }
            }
            Utility.PressEnterToContinue();
            continue;
        }
        if (option == 3)
        {
            if (userName != null)
            {
                Console.WriteLine("See you next time! " + userName);
                break;
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