//Write a C# program to use two dimensional Jagged array and get it's size ,element form user print sum of each row in tabular format.
using System;

class jagged_task
{
    public static void Main()
    {
        Console.Write("Enter number of rows in the array: ");
        int row = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[row][]; // Creating a jagged array for rows

        // Create jagged array with dynamic columns for each row
        for (int i = 0; i < row; i++) // Loop through rows
        {
            Console.Write("Enter number of columns for row ({0}): ", i);
            int column = Convert.ToInt32(Console.ReadLine());

            arr[i] = new int[column]; // Dynamic number of columns for each row
        }

        // Input values for each row
        for (int i = 0; i < row; i++) 
        {
            for (int j = 0; j < arr[i].Length; j++) // Loop through columns for each row
            {
                Console.Write("Enter value for index ({0},{1}): ", i, j);
                arr[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Print array and sum of each row
        Console.WriteLine("\nArray and sum of each row:");
        for (int i = 0; i < row; i++) // Loop through rows
        {
            int sum = 0;
            for (int j = 0; j < arr[i].Length; j++) // Loop through columns for each row
            {
                Console.Write(arr[i][j] + "\t");
                sum += arr[i][j]; // Sum the elements in the row
            }
            Console.WriteLine("\tSum = " + sum);
        }
    }
}
