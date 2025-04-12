using System;
class Pyramid
{
    static void Main(string[] args)
    {
        int num;
        do
        {
            Console.Write("Enter The number of rows:");
            num = Convert.ToInt32(Console.ReadLine());
        if(num<=3)
        {
            Console.WriteLine("Number is invalid! enter valid number:");
        }
        }while(num<=3);
        if(num%2==0)
        {
            num++;
            Console.WriteLine("Entered Number is even,Converting it to odd:"+num);
        }
        int mid = num / 2 + 1;
        for(int row = 1; row <= num; row++)
        {
            for(int col = 1; col <= num; col++)
            {
                if(row==mid || col==mid || (row==1 && col>=mid) || 
                ( row==num && col<=mid ) || ( col==1 && row<=mid ) ||
                 (col==num && row>=mid))
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}
