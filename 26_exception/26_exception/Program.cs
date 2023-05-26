using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = DivideNumbers(num1, num2);
            Console.WriteLine("Result: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        Console.ReadLine();
    }

    static int DivideNumbers(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException();
        }
        return dividend / divisor;
    }
}
