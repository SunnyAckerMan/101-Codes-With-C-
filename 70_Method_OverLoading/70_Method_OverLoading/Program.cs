using _70_Method_OverLoading;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Method Overloading");

        MethodOverloading calculator = new MethodOverloading();
        calculator.Add();

        Console.WriteLine("The Next Result of Overloading: " + calculator.Add(10, 20));
        Console.WriteLine("The Next Result of Overloading with String: " + calculator.Add("Ahmed"," Sunny"));
        Console.WriteLine("The Next Result of Overloading with three Parameters: " + calculator.Add(30, 40, 50));


        
    }
}