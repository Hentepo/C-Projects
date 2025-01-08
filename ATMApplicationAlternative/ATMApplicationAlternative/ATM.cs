using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

public class ATM
{
    Client client;
    public ATM(Client client)
    {
        this.client = client;
    }

    public void PrintBalance()
    {
        Console.WriteLine(client.Balance);    
    }

    public void Deposit(double deposit)
    {
        this.client.Balance += deposit;
    }

    public void Withdraw(double withdrawal)
    {
        this.client.Balance -= withdrawal;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, {client.FirstName} {client.LastName}! What would you like to do?");
    }

    public async void Interest()
    {
        using PeriodicTimer timer = new(TimeSpan.FromMilliseconds(2000));
        var i = 0;

        while (await timer.WaitForNextTickAsync() && i < 1000)
        {
            this.client.Balance += 1;
            i++;
        }
        Console.WriteLine("Timer done");
    }

    public void RichMessage()
    {
        if (client.Balance >= 1000)
            Console.WriteLine("Wow, you are super rich!");
        else if (client.Balance <= 10)
            Console.WriteLine("Dude, you are pretty poor");
        else
            Console.WriteLine("You are not rich and not poor");
    }
}