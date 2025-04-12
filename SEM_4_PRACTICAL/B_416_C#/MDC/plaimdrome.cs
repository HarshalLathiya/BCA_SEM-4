//write a C# program to check given number is palimdrome or not
using System;
class palindrome
{
    public static void Main()
    {
        int num, rem, sum = 0, temp;
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while (num > 0)
        {
            rem = num % 10;
            num = num / 10;
            sum = sum * 10 + rem;
        }
        if (temp == sum)
        {
            Console.WriteLine("Number is Palindrome.");
        }
        else
        {
            Console.WriteLine("Number is not Palindrome.");
        }
    }
}