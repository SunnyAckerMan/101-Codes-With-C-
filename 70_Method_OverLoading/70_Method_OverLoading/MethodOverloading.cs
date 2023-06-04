using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _70_Method_OverLoading
{
    public class MethodOverloading
    {
       public void Add()
        {
            Console.Write("Enter First Number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Sum is: {a+b}");

        }

        public int Add(int x, int y)
        {
            return x+y;
        }

        public string Add(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public int Add(int a, int b, int c)
        {
            return a+b+c;
        }
    }
}
