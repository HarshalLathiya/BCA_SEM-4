//Write a C# Program to perform Method_overloading 
using System;
class Method_overloading
{
    // Method to add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }
    // Overloaded method to handle a string input
    public string Add(string n)
    {
        return n;
    }
    static void Main()
    {
        Method_overloading obj = new Method_overloading(); // Object creation

        Console.WriteLine("Enter value of num1:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value of num2:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum1 = obj.Add(num1, num2);
        Console.WriteLine("Sum of num1 and num2 (int): " + sum1); // Print sum of integers

        Console.WriteLine("Enter a name:");
        string n1 = Console.ReadLine();
        
        string result = obj.Add(n1);
        Console.WriteLine("Entered name is: " + result); // Print the name entered
    }
}
