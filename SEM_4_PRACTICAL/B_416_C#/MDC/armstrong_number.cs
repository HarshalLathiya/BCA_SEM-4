//write a C# program to check number is armstrong or not.
using System;
class armstrong
{
    public static void Main()
    {
        int num, sum = 0, r, temp;
        Console.Write("Enter the Number= ");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while (num > 0)
        {
            r = num % 10;
            sum = sum + (r * r * r);
            num = num / 10;
        }
        if (temp == sum)
        {
            Console.Write("Armstrong Number.");
        }
        else
        {
            Console.Write("Not Armstrong Number.");
        }
    }
}