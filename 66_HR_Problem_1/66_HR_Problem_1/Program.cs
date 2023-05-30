class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32 (Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); //Take inputs in a array format

        int postitive = 0;
        int negetive = 0;
        int zero = 0;

        foreach (int i in arr) //Check all inputs in the array and icress tham
        {
            if (i > 0)
            {
                postitive++;
            }
            else if (i < 0)
            {
                negetive++;
            }
            else 
                zero++;
        }

        decimal positiveRatio = (decimal)postitive / n;
        decimal negetiveCount = (decimal)negetive / n;
        decimal zeroCount = (decimal)zero /n;

        Console.WriteLine(positiveRatio.ToString("F6"));
        Console.WriteLine(negetiveCount.ToString("F6"));
        Console.WriteLine(zeroCount.ToString("F6"));
    }
}