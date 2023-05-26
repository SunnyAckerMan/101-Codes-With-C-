using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Program
{
    static void Main()
    {
        Animal animal1 = new Animal();
        Animal animal2 = new Dog();
        Animal animal3 = new Cat();

        animal1.MakeSound();
        animal2.MakeSound();
        animal3.MakeSound();

        Console.ReadLine();
    }
}
