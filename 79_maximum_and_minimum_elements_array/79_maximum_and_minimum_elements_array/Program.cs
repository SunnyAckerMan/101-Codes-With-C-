Console.WriteLine($"Enter Array Size: ");
string sizeInput = Console.ReadLine();
int  size = Convert.ToInt32( sizeInput );

object[] arr = new object[size];

for ( int i = 0; i < size; i++ )
{
    Console.WriteLine($"Enter Element for Position {i}: ");
    string userInput = Console.ReadLine();
    arr[i] = Convert.ToInt32( userInput );
}

int max = Convert.ToInt32(arr[0]);
int min = Convert.ToInt32(arr[0]);


for (int i = 1; i < size; i++)
{
    int currentValue = Convert.ToInt32(arr[i]);

    if(currentValue > max)
    {
       max = currentValue;
    }
    else if(currentValue < min)
    {
        min = currentValue;
    }
}

Console.WriteLine($"Maximum Value is: {max}");
Console.WriteLine($"Minimum Value is {min}");