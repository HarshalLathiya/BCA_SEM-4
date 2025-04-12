import java.util.Scanner;

public class MaxOfThree {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.print("Enter three numbers: ");
        int a = scan.nextInt();
        int b = scan.nextInt();
        int c = scan.nextInt();

        int max;
        if (a > b) {
            if (a > c)
                max = a;
            else
                max = c;
        } else {
            if (b > c)
                max = b;
            else
                max = c;
        }

        System.out.println("Maximum number: " + max);
        scan.close();
    }
}
