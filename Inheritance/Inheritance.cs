using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

class Program
{
    static void Main()
    {
        new Animal().MakeSound();
    }
}
 