//Write a C# program to perform multi-level Inheritance
using System;
public class parent
{
    public int num1;
    public virtual void fun()
    {
        Console.WriteLine("Hello From Parent class.!");
    }
    public parent(int n1)//constructor of parent class
    {
        num1 =n1;
    }
}
public class child : parent
{
    public int num2;
    public override void fun()
    {
        Console.WriteLine("Hello From child class.!");
    }
    //constructor of child class
    public child(int n1,int n2) : base(n1)
    {
        num2 =n2;
    }
}
public class subchild : child
{
    public int num3;
    public override void fun()
    {
        Console.WriteLine("Hello From sub child class.!");
        Console.WriteLine("Value of all inherited Data Member is"+" num1: "+num1+" num2: "+num2+" num3: "+num3);
    }
    //constructor of subchild class
    public subchild(int n1,int n2,int n3) : base(n1,n2)
    {
        num3 =n3;
    }
}
public class multi_level
{
    public static void Main()
    {
        parent objp = new parent(0); 
        parent objc = new child(0,0);
        parent objsc = new subchild(10,20,30);

        objp.fun();
        objc.fun();
        objsc.fun();
    }
}