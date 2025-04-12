//write a C# program to perform property
using System;

class prop
{
    int num1; // Declare a private integer variable num1 to hold the value
    public int pro
    {
        // Set method: Assigns the value passed to the property to the private num1 variable
        set
        {
            num1 = value;
        }

        // Get method: Returns the value of the private num1 variable
        get
        {
            return num1;
        }
    }
}

class property
{
    static void Main(string[] args)
    {
        prop obj = new prop();
        Console.Write("Enter value of Private DM:");
        obj.pro=Convert.ToInt32(Console.ReadLine());
        // Print the value of 'pro' (which retrieves the value of num1) to the console
        Console.WriteLine("Return Value of num1 is: " + obj.pro);
    }
}
