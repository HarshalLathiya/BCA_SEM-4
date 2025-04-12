using System;

class Demo
{
    // Method demonstrating ref and out parameters
    public void Fun(ref int n1, out int n2)
    {
        n1 = 15;  // Modifying ref parameter
        n2 = 20;  // Assigning value to out parameter
    }
}

class RefOutExample
{
    static void Main(string[] args)
    {
        int num1 = 10, num2; // num2 is uninitialized
        Demo obj = new Demo();

        Console.WriteLine("Value of num1 before function call: " + num1);
        
        // Calling function with ref and out parameters
        obj.Fun(ref num1, out num2);

        Console.WriteLine("\nValue of num1 after function call: " + num1);
        Console.WriteLine("Value of num2 after function call: " + num2);
    }
}
