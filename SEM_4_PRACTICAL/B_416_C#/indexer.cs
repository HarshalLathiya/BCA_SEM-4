using System;

class MyArray
{
    // Declare an array to store values
    private int[] arr = new int[5];

    // Define the indexer property to access elements of the array using the index
    public int this[int index]
    {
        // Get the value at the specified index
        get
        {
            if (index >= 0 && index < arr.Length)
            {
                return arr[index];
            }
            else
            {
                Console.WriteLine("Index out of bounds!");
                return -1; // Return -1 if the index is out of range
            }
        }

        // Set the value at the specified index
        set
        {
            if (index >= 0 && index < arr.Length)
            {
                arr[index] = value;
            }
            else
            {
                Console.WriteLine("Index out of bounds!");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the MyArray class
        MyArray myArray = new MyArray();

        // Using the indexer to set values at specific indices
        myArray[0] = 10;
        myArray[1] = 20;
        myArray[2] = 30;
        myArray[3] = 40;
        myArray[4] = 50;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Value at index " + i + ": " + myArray[i]);
        }

        // Attempting to access an invalid index (this will be handled inside the indexer)
        Console.WriteLine("Value at index 5: " + myArray[5]);
    }
}
