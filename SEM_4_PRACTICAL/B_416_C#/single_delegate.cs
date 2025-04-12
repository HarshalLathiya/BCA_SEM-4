//write a C# program to perform single_delegate
using System;

public delegate void del(int n1, int n2);

class del_cls
{
    public void sum(int num1, int num2)
    {
        Console.WriteLine("Sum is :" + (num1 + num2));
    }
}

class single_delegate
{
    static void Main(string[] args)
    {
        del_cls obj = new del_cls();
        del del_obj = new del(obj.sum);  
        del_obj(10, 10);  // Calling the delegate
        Console.ReadLine();
    }
}
