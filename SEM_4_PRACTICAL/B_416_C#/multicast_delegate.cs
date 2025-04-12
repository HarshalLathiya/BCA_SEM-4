//Write a C# program to perform multicast delegate
using System;

public delegate void del(int n1, int n2);

class del_cls
{
    public void sum(int num1, int num2)
    {
        Console.WriteLine("Addition is: " + (num1 + num2));
    }

    public void sub(int num1, int num2)
    {
        Console.WriteLine("Subtraction is: " + (num1 - num2));
    }

    public void mul(int num1, int num2)
    {
        Console.WriteLine("Multiplication is: " + (num1 * num2));
    }
}

class multicast_delegate
{
    static void Main(string[] args)
    {
        // Create an object of the del_cls class
        del_cls obj = new del_cls();

        // Create multicast delegate and assign methods to it
        del del_obj = null;

        // Adding methods to the delegate
        del_obj += obj.sum;
        del_obj += obj.sub;
        del_obj += obj.mul;

        del_obj(10,10);

        Console.ReadLine();
    }
}
