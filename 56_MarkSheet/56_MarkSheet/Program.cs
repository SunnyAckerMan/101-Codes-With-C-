using System;

class MarksheetProgram
{
    static void Main()
    {
        Console.WriteLine("Student Marksheet Generator");

        // Get input from the user
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter roll number: ");
        string rollNumber = Console.ReadLine();

        Console.Write("Enter marks obtained in CSE 101: ");
        double cse101Marks = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks obtained in CSE 102: ");
        double cse102Marks = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks obtained in CSE 103: ");
        double cse103Marks = Convert.ToDouble(Console.ReadLine());

        // Calculate total marks and average
        double totalMarks = cse101Marks + cse102Marks + cse103Marks;
        double averageMarks = totalMarks / 3;

        // Determine grade based on average marks
        string grade;
        if (averageMarks >= 80)
        {
            grade = "A";
        }
        else if (averageMarks >= 60)
        {
            grade = "B";
        }
        else if (averageMarks >= 40)
        {
            grade = "C";
        }
        else
        {
            grade = "F";
        }

        // Print the mark sheet
        Console.WriteLine("\nStudent Marksheet");
        Console.WriteLine("=================");
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Roll Number: {0}", rollNumber);
        Console.WriteLine("Subject 1 Marks: {0}", cse101Marks);
        Console.WriteLine("Subject 2 Marks: {0}", cse102Marks);
        Console.WriteLine("Subject 3 Marks: {0}", cse103Marks);
        Console.WriteLine("Total Marks: {0}", totalMarks);
        Console.WriteLine("Average Marks: {0}", averageMarks);
        Console.WriteLine("Grade: {0}", grade);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
