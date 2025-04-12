using System;
class swap_num
{
	public static void Main()
	{
		int num1=10;
		int num2=5;
		Console.WriteLine("Value of num1:"+num1);
		Console.WriteLine("Value of num2:"+num2);
		
		num1=num1^num2;
		num2=num1^num2;
		num1=num1^num2;
		
		Console.WriteLine("Value of num1:"+num1);
		Console.WriteLine("Value of num2:"+num2);
		
	}
}