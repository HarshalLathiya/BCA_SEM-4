//write a C# Program to perform parameterized_constructor
using System;
class parameterized_constructor
{
    int num1,num2,sum;//data member
    public parameterized_constructor(int n1,int n2)//parameterized_constructor
    {
        Console.WriteLine("Hello constructor\n");
        num1=n1;//value initialization
        num2=n2;
    }
    void show()
    {
        Console.WriteLine("Hello function");
        Console.WriteLine("Value of num1 is:"+num1);
        Console.WriteLine("Value of num2 is:"+num2+"\n");
        sum=num1+num2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Main\n");
        parameterized_constructor obj = new parameterized_constructor(100,200);//object creation
        obj.show();//function call
        Console.WriteLine("Hello Main");
        Console.WriteLine("sum of num1 + num2:"+obj.sum);
    }
}