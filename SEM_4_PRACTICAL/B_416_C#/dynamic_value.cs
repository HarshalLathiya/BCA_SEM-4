//write a C# program to get value from user side
using System;

class dynamic_value
{
    static void Main()
    {
        Console.Write("Please enter your name:");
            string name = Console.ReadLine();

        Console.Write("Please enter your rollno:");
            int rollno = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("You entered: " + name);
        Console.WriteLine("You entered: " + rollno);
    }
}
