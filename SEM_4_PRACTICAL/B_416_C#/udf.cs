/* write a C# program to create UDF with two parameter and it should call from "Main" 
and get value from user and print the sum of two parameter in udf */
using System;
    class UDF{
    public void fun(int n1,int n2)//udf
    {
        int sum= n1 + n2;//sum of two value
        Console.WriteLine("\nsum of Num1 & Num2:"+sum);
    }
    	public static void Main(String[] args)
	{
        Console.Write("Enter value of Num1:");
            int num1=Convert.ToInt32(Console.ReadLine());
			
        Console.Write("Enter value of Num1:");
            int num2=Convert.ToInt32(Console.ReadLine());

		UDF obj = new UDF();//object creation

		obj.fun(num1,num2);//function calling
        Console.ReadLine();
    }
}
