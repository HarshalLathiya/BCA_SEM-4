/*Write a C# program to use non static member function */
using System;
class nonstatic
{
    int id;
    string name;
    public void display()
    {
        Console.WriteLine(id);
        Console.WriteLine(name);   
    }
    public static void Main(string[] args)
    {
        nonstatic obj1 = new nonstatic();
        nonstatic obj2 = new nonstatic();
        obj1.id=10;
        obj1.name="Harshal";
        obj2.id=20;
        obj2.name="Harsh";
        obj1.display();
        obj2.display();
    }
}