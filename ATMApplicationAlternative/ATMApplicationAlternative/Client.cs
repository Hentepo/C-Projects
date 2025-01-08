using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Client
{
    public String FirstName { get; set; }  
    public String LastName { get; set; }
    public int AccountNumber { get; set; }
    public int Pin { get; set; }
    public double Balance { get; set; }

     public Client(String firstName, String lastName, int accountNumber, int pin, double balance)
    {
        FirstName = firstName;
        LastName = lastName;
        AccountNumber = accountNumber;
        Pin = pin;
        Balance = balance;
    }
}
