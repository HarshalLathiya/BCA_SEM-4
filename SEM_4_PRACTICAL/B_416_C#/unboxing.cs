using System;
class UnboxingExample
{
    static void Main(string[] args)
    {
        Console.Write("Enter Any Value because datatype of obj is Object: ");
        object obj = Convert.ToInt32(Console.ReadLine()); // get the value from user
        Console.WriteLine("Value of obj Before Converting into value type is: " + obj);
        int num=(int)obj;
        if (num>0)
        {
            Console.WriteLine("Value of obj After Converting into value type is: " + num);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        Console.ReadKey();
    }
}
