using _69_Passing_ObjectsTo_Methods;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Jessi", 30);
        Console.WriteLine("{0},{1}", p1.Name, p1.Age);

        ChangePerson(p1 );
        Console.WriteLine("{0},{1}",p1.Name, p1.Age);


        static void ChangePerson(Person p1)
        {
            p1.Name = "Jeff";
            p1.Age = 67;
        }
    }
}