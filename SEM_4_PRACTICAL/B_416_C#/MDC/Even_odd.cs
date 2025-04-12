/*Write a C# program to print  Even odd number up to number entered by user
Even numbers are integers that are exactly divisible by 2, meaning they leave no remainder when divided by 2. 
Examples: 0, 2, 4, 6, 8, 10, 12, and so on. 
Odd numbers are integers that are not exactly divisible by 2, meaning they leave a remainder of 1 when divided by 2. 
Examples: 1, 3, 5, 7, 9, 11, 13, and so on. */
using System;
class even_odd
{
    public static void Main()
    {
        int num;
        Console.Write("Enter the number:");
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i<=num; i++)
        {
            if(i%2==0)
            {
                Console.WriteLine(i+" is Even number");
            }
            else
            {
                Console.WriteLine(i+" is Odd number");
            }
        }
    }
}