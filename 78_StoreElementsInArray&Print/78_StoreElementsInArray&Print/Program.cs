object[] arr = new object[10];

for(int i = 0; i < arr.Length; i++)
{
    Console.Write($"Enter Element {i}: ");
    string userInput = Console.ReadLine();
    arr[i] = userInput;
}

Console.WriteLine();
Console.WriteLine("___________Elements in the Index___________");
Console.WriteLine();

int index = 0;
foreach (object element in arr)
{
    Console.WriteLine($"Element {index}: {element}");
    index++;
}
