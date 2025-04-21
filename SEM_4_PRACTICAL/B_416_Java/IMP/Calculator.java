
import java.util.Scanner;

public class Calculator {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter first number: ");
        double a = sc.nextDouble();
        System.out.print("Enter second number: ");
        double b = sc.nextDouble();

        System.out.println("Choose operation: 1) Add 2) Subtract 3) Multiply 4) Divide");
        int choice = sc.nextInt();

        switch (choice) {
            case 1: System.out.println("Sum = " + (a + b)); break;
            case 2: System.out.println("Difference = " + (a - b)); break;
            case 3: System.out.println("Product = " + (a * b)); break;
            case 4:
                if (b != 0)
                    System.out.println("Quotient = " + (a / b));
                else
                    System.out.println("Cannot divide by zero.");
                break;
            default: System.out.println("Invalid choice");
        }
    }
}
