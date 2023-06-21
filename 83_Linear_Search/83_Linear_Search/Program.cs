Console.WriteLine("Enter the elements of the array:");
int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

Console.Write("Enter the target value to search: ");
int target = int.Parse(Console.ReadLine());

for(int i = 0; i < array.Length; i++)
{
    if (array[i] == target) 
    {
        Console.WriteLine($"{target} is inthe index number {i}");
    }
}


