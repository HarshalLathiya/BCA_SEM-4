//Write a C# Program to perform Three dimensional Array
using System;
class td_array
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Size Of Array Variable:");
        int size = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter row Of Array Variable:");
        int row = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter col Of Array Variable:");
        int col = Convert.ToInt32(Console.ReadLine());

        int [,,]arr = new int [size,row,col];//create 3DArray variable 

        //this part is for get the data from user 
        for(int i=0; i<size; i++)
        {
            for(int j=0; j<row; j++)
            {
                for(int k=0; k<col; k++)
                {
                    Console.WriteLine("Enter value of Index [{0}:{1}:{2}]", i, j, k);
                    arr[i,j,k]=Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        //this part is for print entered data 
        for(int i=0; i<size; i++)
        {
            for(int j=0; j<row; j++)
            {
                for(int k=0; k<col; k++)
                {
                    Console.WriteLine("Entered value at [{0}:{1}:{2}] is: {3}", i, j, k, arr[i, j, k]);
                }
            }
        }
    }
}