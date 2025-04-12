//write a C# Program to perform Static_constructor
using System;
class Static_constructor
{
    static int num; // Data member

    // Static constructor (without parameters)
    static Static_constructor()
    {
        num = 10;
        Console.WriteLine("Hello from static constructor");
    }

    void display()
    {
        Console.WriteLine("Hello from display function:" + num);
    }

    public static void Main(string[] args)
    {
        // Create objects, but the static constructor is only called once
        Static_constructor obj1 = new Static_constructor();
        Static_constructor obj2 = new Static_constructor();

        // Call display method on both objects
        Console.WriteLine("\nobj1");
        obj1.display();

        Console.WriteLine("\nobj2");
        obj2.display();
    }
}
