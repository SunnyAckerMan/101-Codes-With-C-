using OOP;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(19, "Sunny", 89); //Class Instance Creation
        student.setName("Kaiser");
        Console.WriteLine(student.getName());

        student.setGrade(69);
        Console.WriteLine(student.getGrade());
       


    }
}