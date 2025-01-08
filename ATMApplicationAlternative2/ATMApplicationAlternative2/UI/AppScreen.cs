using ATMApplicationAlternative2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApplicationAlternative2.UI
{
    public class AppScreen
    {
        internal const string Cur = "$ ";
        internal static void Welcome()
        {
            //Clears the console screen
            Console.Clear();
            //Sets the title of the console window
            Console.Title = "My ATM App";
            //Sets the text color or foreground color to white
            Console.ForegroundColor = ConsoleColor.White;

            //Sets the welcome message
            Console.WriteLine("\n\n--------------Welcome to My ATM App--------------");
            //Prompt the user to insert atm card
            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("Note: Actual ATM machine will accept and validate " +
                "a physical ATM card, read the card number and validate it");

            Utility.PressEnterToContinue();
        }

        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validator.Convert<long>("your card number");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card PIN"));
            return tempUserAccount;
        }

        internal static void LoginProgress()
        {
            Console.WriteLine("\nChecking card number and PIN...");
            Utility.PrintDotAnimation();

        }

        internal static void PrintLockScreen()
        {
            Console.Clear();
            Utility.PrintMessage("Your account is locked. Please go to the nearest branch " +
                "to unlock your account. Thank you.", true);
            Environment.Exit(1);
        }
        internal static void WelcomeCustomer(string fullName)
        {
            Console.WriteLine($"Welcome back, {fullName}");
            Utility.PressEnterToContinue();
        }

        internal static void DisplayAppMenu()
        {
            Console.Clear();
            Console.WriteLine("--------My ATM App Menu---------");
            Console.WriteLine(":                              :");
            Console.WriteLine("1. Account Balance             :");
            Console.WriteLine("2. Cash Deposit                :");
            Console.WriteLine("3. Withdrawal                  :");
            Console.WriteLine("4. Transfer                    :");
            Console.WriteLine("5. Transactions                :");
            Console.WriteLine("6. Logout                      :");
        }

        internal static void LogOutProgress()
        {
            Console.WriteLine("Thank you for using My ATM App.");
            Utility.PrintDotAnimation();
            Console.Clear();
        }

        internal static int SelectAmount()
        {
            Console.WriteLine("");
            Console.WriteLine(":1.{0}500                 5.{0}10,000", Cur);
            Console.WriteLine(":2.{0}1000                6.{0}15,000", Cur);
            Console.WriteLine(":3.{0}2000                7.{0}20,000", Cur);
            Console.WriteLine(":4.{0}5000                8.{0}40,000", Cur);
            Console.WriteLine(":0.Other");
            Console.WriteLine("");

            int selectedAmount = Validator.Convert<int>("option:");
            switch (selectedAmount)
            {
                case 1:
                    return 500;
                    break;
                case 2:
                    return 1000;
                    break;
                case 3:
                    return 2000;
                    break;
                case 4:
                    return 5000;
                    break;
                case 5:
                    return 10000;
                    break;
                case 6:
                    return 15000;
                    break;
                case 8:
                    return 40000;
                    break;
                case 0:
                    return 0;
                    break;
                default:
                    Utility.PrintMessage("Invalid input. Try again.", false);
                    return -1;
                    break;
            }
        }
    internal InternalTransfer InternalTrasnferForm()
        {
            var internalTransfer = new InternalTransfer();
            internalTransfer.RecipientBankAccountNumber = Validator.Convert<long>("Recipient's account number:");
            internalTransfer.TransferAmount = Validator.Convert<decimal>($"Amount {Cur}");
            internalTransfer.RecipientBankAccountName = Utility.GetUserInput("Recipient's name:");
            return internalTransfer;
        }

    }

}
