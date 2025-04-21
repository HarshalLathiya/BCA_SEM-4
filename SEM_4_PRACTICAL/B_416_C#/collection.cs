using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> sub = new List<string>();  // Create a string list

        // Add items
        sub.Add("C");
        sub.Add("CPP");
        sub.Add("CSharp");

        // Access using index
        Console.WriteLine("First items : " + sub[0]);

        // Loop through all items
        Console.WriteLine("All Subject:");
        foreach (string newvar in sub) {
            Console.WriteLine(newvar);
        }
    }
}
