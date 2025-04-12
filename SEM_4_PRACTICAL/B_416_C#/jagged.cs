//write a C# Program to perform jagged array
using System;

class Program
{
    public static void Main()
    {
        // Declare a jagged array
        int[][] jaggedArray = new int[3][];

        // Initialize the rows of the jagged array
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Display the elements of the jagged array
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row " + (i + 1) + ": ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
