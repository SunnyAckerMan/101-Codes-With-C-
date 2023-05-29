class Bsearch
{
    static void Main(string[] args)
    {
        Console.WriteLine("Binary Search-----");
        int[] a = {10,14,16,20,18,25};
        int num = int.Parse(Console.ReadLine());

        int answer = Array.BinarySearch(a,num);

        if(answer < 0 )
        {
            Console.WriteLine("Number Does not exist!");
        }
        else
        {
            Console.WriteLine("The number is in the array number {0}", answer);
        }
    }
}