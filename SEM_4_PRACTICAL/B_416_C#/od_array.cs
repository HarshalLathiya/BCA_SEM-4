//Write a C# program to use Array Variable.
using System;
class OD_array
{
    public static void Main()
    {
        Console.Write("Enter Size of Array.");
            int size=Convert.ToInt32(Console.ReadLine());
            int []arr = new int[size];//creation of Array variable
        //loop for get data from user 
        for (int i=0;i<arr.Length;i++)
        {
            Console.Write("Enter value for index:"+i+":");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        //loop for print data you have Entered
        for (int i=0;i<arr.Length;i++)
        {
          Console.WriteLine("Entered value is:"+arr[i]);
        }
    }
}