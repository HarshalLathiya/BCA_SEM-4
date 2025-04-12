//Write a C# program to perform Sealed class
using System;
class Parent
{
    public virtual void Fun()
    {
        Console.WriteLine("Harshal");
    }
}

 sealed class Child : Parent // it cannot be inherited
{
    public override void Fun()  // Override method
    {
        Console.WriteLine("Lathiya");
    }
}
/*class subchild : Child 
{
        public override void fun()
        {
            Console.WriteLine("Hello form subchild.!");
        }
}*/
class SealedCls
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from Main!");

        Parent objp = new Parent();
        Child objc = new Child();
        //subchild objs = new subchild();
        //objs.fun();
        objp.Fun();
        objc.Fun();
    }
}
