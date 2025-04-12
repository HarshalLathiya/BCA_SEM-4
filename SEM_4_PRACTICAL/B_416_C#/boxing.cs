//Write a C# program to perform Boxing processes.
using System;
class boxing
{
    static void Main(string[] args)
    {
        int num = 100;
        Console.WriteLine("Value of Num Before Converting into reference type is :"+num);

        object obj = num;//Boxing
        Console.WriteLine("Value of Num After Converting into Reference type is :"+num);

        Console.ReadKey();

    }
}