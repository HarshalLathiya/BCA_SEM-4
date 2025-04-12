//Write a C# Program to perform Method_overriding 
using System;
class Parent
{
    // Base class method
    public virtual void Fun()
    {
        Console.WriteLine("Hello from parent!");
    }
}

class Child : Parent
{
    public override void Fun()
    {
        Console.WriteLine("Hello from child!");
    }
}

class SubChild : Parent
{
    public override void Fun()
    {
        Console.WriteLine("Hello from subchild!");
    }
}

class MethodOverriding
{
    static void Main()
    {
        Parent objp = new Parent();
        Parent objc = new Child();
        Parent objsc = new SubChild();


        // Calling the overridden methods
        objp.Fun();
        objc.Fun();
        objsc.Fun();
    }
}
