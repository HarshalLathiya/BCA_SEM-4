using System;

public class GrossSalary
{
    public static void Main()
    {
        Console.WriteLine("Enter basic salary: ");
        double bs = Convert.ToDouble(Console.ReadLine());

        double ta = 0;
        double da = 0;
        double hna = 0;
        double pf = 0;
        double totalSalary = 0;

        if (bs < 35000)
        {
            ta = bs * 0.09;
            da = bs * 0.12;
            hna = bs * 0.20;
            pf = bs * 0.085;
        }
        else if (bs >= 35000 && bs <= 45000)
        {
            ta = bs * 0.05;
            da = bs * 0.05;
            hna = bs * 0.15;
            pf = bs * 0.085;
        }

        totalSalary = (bs + ta + da + hna) - pf;
        Console.WriteLine("Total Salary = " + totalSalary);
        Console.ReadLine();
    }
}
