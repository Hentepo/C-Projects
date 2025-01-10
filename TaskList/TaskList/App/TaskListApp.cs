using System;
using System.Globalization;
using TaskList;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;

string tempString1;
string tempString2;
string tempString3;

DateTime parsedDate;

int tempInt1;
int tempInt2;
int tempInt3;

DateAndTime date;

List<Tasks> list = new List<Tasks>
{
    new Tasks { TaskName = "Task1", DueDate = new DateTime(2024, 12, 12), TaskDescription = "DoTask1" },
    new Tasks { TaskName = "Task2", DueDate = new DateTime(2024, 12, 13), TaskDescription = "DoTask2" },
    new Tasks { TaskName = "Task3", DueDate = new DateTime(2024, 12, 14), TaskDescription = "DoTask3" },
};

Console.ForegroundColor = ConsoleColor.White;
AppScreen.Welcome();
Utility.PressEnterToContinue();   


while (true)
{
    AppScreen.DisplayMenu();
    int option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)
    {
        Console.WriteLine();
        Console.WriteLine("Your current tasks are: ");
        Console.WriteLine("--------------------------------------------");
        foreach (Tasks item in list)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Task Name: {item.TaskName}");
            Console.WriteLine();
            Console.WriteLine($"Due date: {item.DueDate}");
            Console.WriteLine();
            Console.WriteLine($"Task Description: {item.TaskDescription}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------");
        }
    Utility.PressEnterToContinue();
    }

    if (option == 2)
    {

            Console.WriteLine("Add task name: ");
            tempString1 = Console.ReadLine();

            Console.WriteLine("Add task description: ");
            tempString2 = Console.ReadLine();

        while (true)
        {

            Console.WriteLine($"Add due date: ");
            tempString3 = Console.ReadLine();

            bool successfullyParsed = DateTime.TryParse(tempString3, out parsedDate);
            if (successfullyParsed == false)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!");
                Console.WriteLine("Input in datetime format XX/XX/XXXX");
            }
            else
            {
                break;
            }
        }

        list.Add(new Tasks()
        {
            TaskName = tempString1,
            DueDate = parsedDate,
            TaskDescription = tempString2
        });

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine($"Added {tempString1} to MyTaskList!");
        Console.ForegroundColor = ConsoleColor.White;
        Utility.PressEnterToContinue();
    }

    if (option == 3)
    {
        Console.WriteLine($"What task you would like to remove?");
        tempString1 = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine($"Added {tempString1} to MyTaskList!");
        Console.ForegroundColor = ConsoleColor.White;
        Utility.PressEnterToContinue();
    }



    else if (option == 4)
    {
        Console.WriteLine("See you next time!");
        break;
    }

    else
    {
        Console.WriteLine("Invalid option");
        Utility.PressEnterToContinue();
    }
}




//int option = Convert.ToInt32(Console.ReadLine());

//while (true)
//{
//    if (option == 1)
//    {
//        Console.WriteLine($"Add task name: ");
//        tempstring1 = Console.ReadLine();

//        Console.WriteLine($"Add task description: ");
//        tempstring2 = Console.ReadLine();

//        Console.WriteLine($"Added task");

//        list.Add(new Tasks()
//        {
//            TaskName = tempstring1,
//            DueDate = new DateTime(2024, 12, 17),
//            TaskDescription = tempstring2
//        });
//    };

//    Console.WriteLine("Updated task list is: ");


//    };

//};





