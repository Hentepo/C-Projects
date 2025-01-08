
public class Program
{
    public static void Main(string[] args)
    {
        //Check for account number
        //Check for pin
        //Greet
        //Present with options
        List<Client> clients = new List<Client>();
        clients.Add(new Client("Rachel", "Green", 123456789, 1234, 100));
        clients.Add(new Client("Ross", "Geller", 123456789, 1234, 200));
        clients.Add(new Client("Chanlder", "Bing", 123456789, 1234, 300));
        clients.Add(new Client("Monica", "Geller", 123456789, 1234, 400));
        clients.Add(new Client("Phoebe", "Buffay", 123456789, 1234, 400));


        Console.WriteLine("Welcome! Please enter your account number: ");

        Client client;
        int AccountNumber;

        while (true)
        {
            AccountNumber = int.Parse(Console.ReadLine());
            client = clients.FirstOrDefault(client => client.AccountNumber == AccountNumber);
            if (client != null) { break; }
            else { Console.WriteLine("Incorrect account number, please try again "); }
        }

        Console.WriteLine("Please enter your pin: ");

        int pin = 0;

        while (true)
        {
            pin = int.Parse(Console.ReadLine());
            if (client.Pin == pin) { break; }
            else { Console.WriteLine("Incorrect pin. Please try again: "); }
        }

        ATM atm = new ATM(client);

        atm.Interest();

        atm.Greet();
        int option = 0;

        while (true)
        {
            atm.RichMessage();
            Console.WriteLine();
            PrintATMOptions();
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine();
                Console.WriteLine($"Current balance is {client.Balance}");
                Console.WriteLine();
                Console.WriteLine("How much would you like to deposit?");
                double deposit = double.Parse(Console.ReadLine());
                atm.Deposit(deposit);
                Console.WriteLine($"Thank you! Your money has been deposited to your account");
                Console.WriteLine($"Your new balance is {client.Balance}");
            }
            else if (option == 2)
            {
                Console.WriteLine();
                Console.WriteLine($"Current balance is {client.Balance}");
                Console.WriteLine("How much would you like to withdraw?");
                double withdraw = double.Parse(Console.ReadLine());
                if (withdraw > client.Balance || client.Balance - withdraw < 0 )
                {
                    Console.WriteLine("Insuffient funds!");
                }
                else
                {
                    atm.Withdraw(withdraw);
                    Console.WriteLine($"Thank you! {withdraw} $ has been withdrawn from your account");
                    Console.WriteLine($"Your new balance is {client.Balance}");
                }               
            }
            else if (option == 3)
            {
                atm.PrintBalance();
                //Console.WriteLine();
                //Console.WriteLine("Your current balance is " + client.Balance);
            }
            else if (option == 4)
            {
                Console.WriteLine("Until next time!");
                break; 
            }
            else 
            {
                option = 0;
                Console.WriteLine();
                Console.WriteLine("Option not recognized");
                Console.WriteLine("Please choose from 1-4");
            }
        }

    }


    public static void PrintATMOptions()
    {
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Check balance");
        Console.WriteLine("4. Exit");
    }
}
