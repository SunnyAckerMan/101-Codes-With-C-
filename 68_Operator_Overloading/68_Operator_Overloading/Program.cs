using _68_Operator_Overloading;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        BankAccount bank1 = new BankAccount(180,"Sunny");
        BankAccount bank2 = new BankAccount(220,"Naim");

        BankAccount bank3 = bank1 + bank2;
        Console.WriteLine(bank3.Owner);
        Console.WriteLine(bank3.Cash);
    }
}