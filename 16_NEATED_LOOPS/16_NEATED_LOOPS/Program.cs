Console.Write("How Many Rows?: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("How Many Colums?: ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.Write("What Symbol?: ");
String symbol = Console.ReadLine();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}