//write a C# program to demonstrate single inheritance using constructor and method overriding.
using System;

public class parent
{
    public int num1;

    public virtual void fun()
    {
        Console.WriteLine("Hello From Parent class.!");
    }

    public parent(int n1) // Constructor of parent class
    {
        num1 = n1;
    }
}

public class child : parent
{
    public int num2;

    public override void fun()
    {
        Console.WriteLine("Hello From Child class.!");
        Console.WriteLine($"Values: num1 = {num1}, num2 = {num2}");
    }

    // Constructor of child class
    public child(int n1, int n2) : base(n1)
    {
        num2 = n2;
    }
}

public class single_inheritance
{
    public static void Main()
    {
        parent objc = new child(10, 20);
        objc.fun(); // Calls overridden method in child class
    }
}
