using System;

class StudentNames {
    private string[] names = new string[5];

    // Define an indexer
    public string this[int index]
    {
        get
        {
            return names[index];
        }
        set
        {
            names[index] = value;
        }
    }
}

class Program {
    static void Main() {
        StudentNames students = new StudentNames();

        // Using indexer to set values
        students[0] = "Mihir";
        students[1] = "Harshal";
        students[2] = "Varshil";

        // Using indexer to get values
        Console.WriteLine("Student at index 0: " + students[0]);
        Console.WriteLine("Student at index 1: " + students[1]);
    }
}
