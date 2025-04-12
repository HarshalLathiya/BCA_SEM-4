import java.util.Scanner;

public class GradeSwitch {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter percentage: ");
        int percentage = scanner.nextInt();
        String grade;

        switch (percentage / 10) {
            case 10:
            case 9:
                grade = "A+";
                break;
            case 8:
                grade = "A";
                break;
            case 7:
                grade = "B";
                break;
            case 6:
                grade = "C";
                break;
            case 5:
                grade = "D";
                break;
            default:
                grade = "Fail";
        }

        System.out.println("Grade: " + grade);
        scanner.close();
    }
}
