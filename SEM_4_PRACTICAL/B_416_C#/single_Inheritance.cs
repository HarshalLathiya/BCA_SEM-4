//Write a C# program to perform Single Inheritance
using System;
public class parent
{
    public int num1;
    public void fun()
    {
        Console.WriteLine("Hello From Parent class.!");
    }
}
public class child : parent
{
    public int num2;
    public void show()
    {
        Console.WriteLine("Hello From child class.!");
                Console.WriteLine("Value of num1 :"+num1);
                                Console.WriteLine("Value of num2 :"+num2);
    }
}
public class Single_Inheritance
{
    public static void Main()
    {
        child obj = new child();
        obj.num1=10;
        obj.num2=10;
        obj.fun();
        obj.show();
    }
}