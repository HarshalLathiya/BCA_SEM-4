//write a C# program to perform interface
using System;
interface iface1
{
    void fun1();//abstract function
}
interface iface2
{
    void fun2();
}
class ifacecontainer
{
    public void fun1() 
    {
        Console.WriteLine("Hello From fun1!");
    }
    public void fun2()
    {
        Console.WriteLine("Hello From fun2!");
    }
}
class child : ifacecontainer, iface1,iface2
{
    public void fun3()
    {
        Console.WriteLine("Hello From child!");
    }
}
class interfacemain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello From Main!");
        // ifacecontainer obj = new ifacecontainer();
        // obj.fun1();
        // obj.fun2();
        child obj = new child();
        obj.fun1();
        obj.fun2();
        obj.fun3();
    }
}