//write a C# program to use dynamic variable.
using System;

class dynamic_var
{
    public static void Main()
    {
        // Console.Write("Please enter any value:");
        // dynamic var = Console.ReadLine();
        // var=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("You entered: " +var);
        dynamic str ="Hello C#";
        Console.WriteLine(str);
        Console.Write("Please enter any value:");
        str=Console.ReadLine();
        Console.WriteLine(str);
    }
}
