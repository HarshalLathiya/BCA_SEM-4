//Write a C# program to use two dimensional array and get it's size ,element form user print sum of each row in tabular format.
using System;
class TD_array
{
    public static void Main()
    {
        Console.Write("Enter Row of Array.");
            int row=Convert.ToInt32(Console.ReadLine());
			
        Console.Write("Enter Column of Array.");
            int column=Convert.ToInt32(Console.ReadLine());

        int [ , ]arr = new int[row,column];//creation of Two dimensional Array variable
        
        for (int i=0;i<row;i++)//loop for get data from user 
        {
            for(int j=0;j<column;j++)
            {
                Console.Write("Enter value for index:"+i+j+":");
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
		int sum=0;//creation of Sum variable
     
        for (int i=0;i<row;i++)//loop for print data from user 
        {
			sum=0;//Reinitialization of Sum variable
            for(int j=0;j<column;j++)
            {
                Console.Write(arr[i,j]+"\t");
				sum += arr[i,j];//it will perform sum of each row 
            }
			Console.WriteLine("Sum is "+sum);
        }
                    Console.Write("\n");
    }
}