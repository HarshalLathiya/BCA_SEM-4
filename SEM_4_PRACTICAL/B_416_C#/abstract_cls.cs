//write a C# program to use abstract class
using System;
abstract class parent
{
    public int num1;
    public abstract void fun();
}
class child : parent
{
    public int num2;
    public child()
    {
        num1=10;
        num2=20;
    }
     public override void fun()
    {
        Console.WriteLine("Hello fun of abstract class.!");
    }
    public void show()
    {
        Console.WriteLine("Value of Num1: "+num1+"\nValue of num2: "+num2);
    }
}
class abstract_cls
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello main");
        child obj = new child();
        obj.fun();
        obj.show();
    }
}