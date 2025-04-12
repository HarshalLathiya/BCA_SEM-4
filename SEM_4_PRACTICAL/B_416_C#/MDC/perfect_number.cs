//write a C# program to check given numbr is perfect number or not
using System;
class perfect_number
{
    public static void Main()
    {
        int num, sum = 0;
        Console.Write("Enter the Number= ");
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum = sum + i;
            }
        }
        if (sum == num)
        {
            Console.Write("Perfect Number.");
        }
        else
        {
            Console.Write("Not Perfect Number.");
        }
    }
}