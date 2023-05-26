using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create a new thread and specify the method to be executed
        Thread thread = new Thread(CountNumbers);

        // Start the thread
        thread.Start();

        // Main thread continues execution
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Main thread: " + i);
            Thread.Sleep(500);  // Introduce a delay
        }

        // Wait for the thread to complete
        thread.Join();

        Console.WriteLine("Main thread completed.");

        Console.ReadLine();
    }

    static void CountNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Child thread: " + i);
            Thread.Sleep(500);  // Introduce a delay
        }

        Console.WriteLine("Child thread completed.");
    }
}
