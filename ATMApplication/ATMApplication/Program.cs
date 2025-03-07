﻿// See https://aka.ms/new-console-template for more information
//using ATMApplication;
using System;
using System.Linq.Expressions;

public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
    public string getCardNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setNum(string newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setpin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(string[] args)
    {
        void printOption()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser) 
        {
            Console.WriteLine("How much money would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you! Your new balance is " + currentUser.getBalance());
        }

        void withraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withraw: ");
            double withrawal = Double.Parse(Console.ReadLine());
            //Check if user has enough money
            if(currentUser.getBalance() < withrawal)         
            {
                Console.WriteLine("Insifficient balance :");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withrawal);
                Console.WriteLine("Thank you!");
            }
        }


        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }


        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("123", 123, "Pekka", "Takalo", 150));
        cardHolders.Add(new cardHolder("234", 234, "Seppo", "Taalasmaa", 150));
        cardHolders.Add(new cardHolder("345", 345, "Mikko", "Makinen", 150));
        cardHolders.Add(new cardHolder("456", 456, "Keijo", "Kontiola", 150));
        cardHolders.Add(new cardHolder("567", 567, "Ulla", "Kinnula", 150));


        //Promt user
        Console.WriteLine("Welcome!");
        Console.WriteLine("Please insert your depit card: ");
        String depitCardNum = "";
        cardHolder currentUser;

        while(true) 
        {
            try
            {
                depitCardNum = Console.ReadLine();
                // Check against our db
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == depitCardNum);
                if (currentUser != null)
                { break; }
                else
                { Console.WriteLine("Card not recognized. Please try again"); }
            }
            catch
            {
                Console.WriteLine("Card not recognized. Please try again");
            }
        }


        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin)
                { break; }
                else
                { Console.WriteLine("Incorrect pin. Please try again"); }
            }
            catch
            {
                Console.WriteLine("Card not recognized. Please try again");
            }
        }

        Console.WriteLine("Welcome " + currentUser.getFirstName() + " " + currentUser.getLastName());
        int option = 0;
        do
        {
            printOption();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch {}
            if(option == 1) { deposit(currentUser); }
            else if (option == 2) { withraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else {option = 0;}
        }
        while (option != 4);
        Console.WriteLine("Thank you! Have a nice day");

    }

}


