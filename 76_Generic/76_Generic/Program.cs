using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating a generic class instance with type parameter as int
        MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
        int intValue = intGenericClass.GenericMethod(5);
        Console.WriteLine("Returned value: " + intValue);

        // Creating a generic class instance with type parameter as string
        MyGenericClass<string> stringGenericClass = new MyGenericClass<string>("Hello");
        string stringValue = stringGenericClass.GenericMethod("World");
        Console.WriteLine("Returned value: " + stringValue);
    }
}

public class MyGenericClass<T>
{
    private T genericMemberVariable;

    public MyGenericClass(T value)
    {
        genericMemberVariable = value;
    }

    public T GenericMethod(T genericParameter)
    {
        Console.WriteLine("Parameter type: " + typeof(T).ToString());
        Console.WriteLine("Parameter value: " + genericParameter);

        T returnValue = genericMemberVariable;
        Console.WriteLine("Generic member variable value: " + returnValue);

        return returnValue;
    }
}
