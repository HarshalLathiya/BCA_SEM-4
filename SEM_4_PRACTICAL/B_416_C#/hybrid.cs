//Write a C# Program to perform Hybrid Inheritance
using System;

class BaseClass
{
    public void DisplayBase()
    {
        Console.WriteLine("This is the Base Class.");
    }
}

class DerivedClass1 : BaseClass
{
    public void DisplayDerived1()
    {
        Console.WriteLine("This is Derived Class 1.");
    }
}

class DerivedClass2 : BaseClass
{
    public void DisplayDerived2()
    {
        Console.WriteLine("This is Derived Class 2.");
    }
}

class HybridClass : DerivedClass1
{
    public void DisplayHybrid()
    {
        Console.WriteLine("This is the Hybrid Class.");
    }

    public void ShowCombined()
    {
        Console.WriteLine("Hybrid Class can access functionality from both DerivedClass1 and DerivedClass2.");
    }
}

class Program
{
    static void Main()
    {
        HybridClass hybrid = new HybridClass();

        hybrid.DisplayBase();          // Access BaseClass method
        hybrid.DisplayDerived1();      // Access DerivedClass1 method
        hybrid.DisplayHybrid();        // Access HybridClass method

        DerivedClass2 derived2 = new DerivedClass2();
        derived2.DisplayBase();        // Access BaseClass method
        derived2.DisplayDerived2();    // Access DerivedClass2 method
        
        hybrid.ShowCombined();  // HybridClass specific method
    }
}
