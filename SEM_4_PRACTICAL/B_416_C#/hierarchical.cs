//Write a C# program to perform hierarchical Inheritance
using System;
public class parent
{
        public int num1,num2;
    public virtual void fun()
    {
        Console.WriteLine("Hello From Parent class.!");
    }
    public parent(int n1,int n2)
    {
        num1=n1;
        num2=n2;
    }
}
public class child : parent
{
    public child(int n1,int n2) : base(n1,n2){}
    public override void fun()
    {
        Console.WriteLine("Hello From child class.!\nValue of num1 is:"+num1+"\nValue of num2 is:"+num2);
    }
}
public class subchild : parent
{ 
    public subchild(int n1,int n2) : base(n1,n2){}
    public override void fun()
    {
        Console.WriteLine("Hello From sub child class.!\nValue of num1 is:"+num1+"\nValue of num2 is:"+num2);
    }
}
public class hierarchical
{
    public static void Main()
    {
        parent objp = new parent(0,0); 
        parent objc = new child(1,2); 
        parent objsc = new subchild(10,20);

        objp.fun();
        objc.fun();
        objsc.fun();
    }
}