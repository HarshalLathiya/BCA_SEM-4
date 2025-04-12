using System;

class PointerExample
{
    static unsafe void Main(string[] args)
    {
        int num = 10;
        int* ptr = &num; // Pointer stores address of num

        Console.WriteLine("Value of num is: " + num);
        Console.WriteLine("Value at ptr is: " + *ptr); // Dereferencing pointer
    }
}
