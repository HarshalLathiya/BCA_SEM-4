//Write a C# program to print prime number up to the number entered by the user.
using System;
class prime_number
{
    public static void Main()
    {
        int num, i, m, flag;
        Console.Write("Enter the Number to check Prime:");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prime Numbers are: ");
        for (i = 2; i <= num; i++)
        {
            flag = 0;
            for (m = 2; m <= i / 2; m++)
            {
                if (i % m == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine(i);
        }
    }
}