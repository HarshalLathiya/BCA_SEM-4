
import java.util.Scanner;

public class StudentMarks {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int total = 0;
        System.out.println("Enter marks for 5 subjects:");
        for (int i = 1; i <= 5; i++) {
            System.out.print("Subject " + i + ": ");
            total += sc.nextInt();
        }
        double average = total / 5.0;
        System.out.println("Total = " + total);
        System.out.println("Average = " + average);
    }
}
