//write a C# Program to perform copy_constructor
using System;
class copy_constructor
{
    int num;//data member
    public copy_constructor(){}//empty constructor
    public copy_constructor(copy_constructor cpy)//copy_constructor
    {
        Console.WriteLine("Hello copy_constructor");
        num=cpy.num;
    }
    void show()
    {
        Console.WriteLine("Hello function "+num);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Main");
        copy_constructor obj1 = new copy_constructor();//first object creation
        Console.Write("Enter Value : ");
        obj1.num=Convert.ToInt32(Console.ReadLine());
        copy_constructor obj2 = new copy_constructor(obj1);//second object creation
        obj1.show();//function call
        obj2.show();//function call
    }
}