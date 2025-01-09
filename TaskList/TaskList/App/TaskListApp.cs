using System;
using System.Globalization;
using TaskList;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

Console.ForegroundColor = ConsoleColor.White;
AppScreen.Welcome();
Utility.PressEnterToContinue();   



while (true)
{
    AppScreen.DisplayMenu();
    int option = Convert.ToInt32(Console.ReadLine());


    if (option == 1)
    {
        Console.WriteLine("You have selected 1");
        break;
    }
    else 
    {
        break;
    }
}


//List<Tasks> list = new List<Tasks>
//{
//    new Tasks { TaskName = "Task1", DueDate = new DateTime(2024, 12, 12), TaskDescription = "DoTask1" },
//    new Tasks { TaskName = "Task2", DueDate = new DateTime(2024, 12, 13), TaskDescription = "DoTask2" },
//    new Tasks { TaskName = "Task3", DueDate = new DateTime(2024, 12, 14), TaskDescription = "DoTask3" },
//    new Tasks { TaskName = "Task4", DueDate = new DateTime(2024, 12, 15), TaskDescription = "DoTask4" },
//};


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

//    foreach (Tasks item in list)
//    {
//        Console.WriteLine($"Task Name: {item.TaskName}");
//        Console.WriteLine();
//        Console.WriteLine($"Due date: {item.DueDate}");
//        Console.WriteLine();
//        Console.WriteLine($"Task Description: {item.TaskDescription}");
//        Console.WriteLine("--------------------------------------------");

//    };

//};





