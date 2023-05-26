using System;

class GenericClass<T>
{
    private T value;

    public GenericClass(T value)
    {
        this.value = value;
    }

    public T GetValue()
    {
        return value;
    }
}

class Program
{
    static void Main()
    {
        GenericClass<int> intObject = new GenericClass<int>(10);
        int intValue = intObject.GetValue();
        Console.WriteLine("Integer value: " + intValue);

        GenericClass<string> stringObject = new GenericClass<string>("Hello");
        string stringValue = stringObject.GetValue();
        Console.WriteLine("String value: " + stringValue);

        Console.ReadLine();
    }
}
