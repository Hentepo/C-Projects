
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Welcome to MyTaskList!");

Console.WriteLine("Your current tasks are: ");


List<string> list = new List<string>();
list.Add("Test1");
list.Add("Test2");
list.Add("Test3");


foreach (string item in list)
    Console.WriteLine(item);