using GuessNumberGame;
using System;

// See https://aka.ms/new-console-template for more information

int input;

Console.WriteLine("Welcome to MyGuessingGame!");

while (true)
{
    try
    {
        input = Convert.ToInt32(Utility.GetUserInput("a number between 1-10"));

        if (input == 0)
        {
         
            Console.WriteLine("Please, input a number greater than zero.");
            Console.WriteLine("");
        }
        else if (input > 10)
        {
            Console.WriteLine("Please, input a number lower than 10.");
            Console.WriteLine("");
        }
        else
        {
            if (input < Numbers.GenerateNumber())
            {
                Console.WriteLine("Your guess is too low");
                Console.WriteLine("Please, try again!");
            }
            else if (input > Numbers.GenerateNumber())
            {
                Console.WriteLine("Your guess is too high");
                Console.WriteLine("Please, try again!");
            }
            else
            {
                Console.WriteLine($"You have guessed correct");
                Console.WriteLine($"You are the master of the universe!");
                break;
            }
        }
    }
    catch
    {
        Console.WriteLine($"Input a numberic value");
        Console.WriteLine("Please, try again");
        Console.WriteLine("Test");
        Console.WriteLine("");
    }
}



