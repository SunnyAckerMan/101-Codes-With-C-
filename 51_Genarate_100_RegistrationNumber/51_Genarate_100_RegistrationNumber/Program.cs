using System;

class Student
{
    private string name;
    private string registerNumber;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string RegisterNumber
    {
        get { return registerNumber; }
    }

    private static int count = 1000;

    static Student ()
    {
        Console.WriteLine("Generating register numbers...");
    }

    public Student(string name)
    {
        this.name = name;
        count++;
        registerNumber = "R" + count.ToString();
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[100];

        for (int i = 0; i < students.Length; i++)
        {
            students[i] = new Student("Student " + (i + 1));
        }
        Console.WriteLine("Register number Generated successfully");

        foreach (Student student in students)
        {
            Console.WriteLine("Name: " + student.Name + "\tRegister Number: " + student.RegisterNumber);
        }

        Console.WriteLine();
    }
}