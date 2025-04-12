using System;
class Arrofstring
{
    static void Main()
    {
        Console.WriteLine("Enter size of Array");
        int size = Convert.ToInt32(Console.ReadLine());

        string[] str = new string[size]; 
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter Array Element");
            str[i] = Console.ReadLine();
        }
        Console.WriteLine("You have Entered this elements:");
        foreach (string temp in str)
        {
            Console.WriteLine(temp);
        }
    }
}
