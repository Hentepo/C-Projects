using System;
using System.Globalization;
using TaskList;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

string tempString1;
string tempString2;
string tempString3;

DateTime parsedDate;

int tempInt1;
int tempInt2;
int tempInt3;

DateAndTime date;

string filePath = "data.txt";

Console.ForegroundColor = ConsoleColor.White;
AppScreen.Welcome();
Utility.PressEnterToContinue();

List<Tasks> tasks = ParseTasks(filePath);

static List<Tasks> ParseTasks(string filePath)
{
    List<Tasks> tasks = new List<Tasks>();

    // Read all lines from the text file
    string[] lines = File.ReadAllLines(filePath);

    string taskName = string.Empty;
    string taskDescription = string.Empty;
    DateTime dueDate = DateTime.MinValue;

    foreach (var line in lines)
    {
        if (string.IsNullOrWhiteSpace(line)) continue;

        if (line.Contains("----------")) continue;

        if (line.StartsWith("Task"))
        {
            // If there is already a task in progress, save it before starting a new one
            if (!string.IsNullOrEmpty(taskName) && !string.IsNullOrEmpty(taskDescription))
            {
                tasks.Add(new Tasks(taskName, taskDescription, dueDate));
            }

            // Start parsing a new task
            taskName = line.Trim();
            taskDescription = string.Empty; // Reset the description
            dueDate = DateTime.MinValue;    // Reset the due date
        }
        else if (line.Contains("."))
        {
            // Parse due date
            if (DateTime.TryParse(line, out DateTime parsedDate))
            {
                dueDate = parsedDate;
            }
        }
        else
        {
            // Parse task description
            taskDescription = line.Trim();
        }
    }

    // Add the last task after the loop ends
    if (!string.IsNullOrEmpty(taskName) && !string.IsNullOrEmpty(taskDescription))
    {
        tasks.Add(new Tasks(taskName, taskDescription, dueDate));
    }

    return tasks;
}

static void WriteTasksToFile(List<Tasks> tasks, string filePath)
{
    using (StreamWriter writer = new StreamWriter(filePath))
    {
        foreach (var task in tasks)
        {
            writer.WriteLine(task.TaskName);
            writer.WriteLine(task.TaskDescription);
            writer.WriteLine(task.DueDate.ToShortDateString());
            writer.WriteLine(new string('-', 10)); // Separator
        }
    }
}

while (true)
{
    AppScreen.DisplayMenu();
    int option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("You have no tasks! Have a nice day!");
            Utility.PressEnterToContinue();
            continue;
        }
        else 
        {

            Console.WriteLine();
            Console.WriteLine("Your current tasks are: ");
            Console.WriteLine("--------------------------------------------");

            foreach (Tasks item in tasks)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{item.TaskName}");
                Console.WriteLine();
                Console.WriteLine($"{item.TaskDescription}");
                Console.WriteLine();
                Console.WriteLine($"{item.DueDate}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------------------------");
            }
            Utility.PressEnterToContinue();
            continue;
        }

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

        tasks.Add(new Tasks(tempString1, tempString2, parsedDate));

        WriteTasksToFile(tasks, filePath);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine($"Added {tempString1} to MyTaskList!");
        Console.ForegroundColor = ConsoleColor.White;
        Utility.PressEnterToContinue();
        continue;
    }

    if (option == 3)
    {
        Console.WriteLine($"What task you would like to remove?");

        foreach (Tasks item in tasks)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{item.TaskName}");
            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.White;

        tempString1 = Console.ReadLine();

        foreach (var (value,i) in tasks.Select((value, i) => (value, i)))
        {
            if (tempString1 == tasks[i].TaskName)
                {
                    tasks.Remove(tasks[i]);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine($"Removed {tempString1} from MyTaskList!");
                    Console.ForegroundColor = ConsoleColor.White;
                    WriteTasksToFile(tasks, filePath);
                    Utility.PressEnterToContinue();
                    break;
                }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Task not found!");
                Console.ForegroundColor = ConsoleColor.White;
                Utility.PressEnterToContinue();
                break;
            }
        }
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





