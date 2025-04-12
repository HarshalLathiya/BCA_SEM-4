//write a C# Program to perform default_constructor
using System;
class default_constructor
{
    public default_constructor()
    {
        Console.WriteLine("You are in Constructor!");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Main");
        default_constructor obj = new default_constructor();
    }
}