import java.util.Scanner;

public class GradeNestedIf {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.print("Enter percentage: ");
        double percentage = scan.nextDouble();
        String grade;
        
        if (percentage >= 90) {
            grade = "A+";
        } 
        else if (percentage >= 80) 
        {
            grade = "A";
        } 
        else if (percentage >= 70) 
        {
            grade = "B";
        } 
        else if (percentage >= 60)
         {
            grade = "C";
        } 
        else if (percentage >= 50) 
        {
            grade = "D";
        } 
        else
         {
            grade = "Fail";
        }

        System.out.println("Grade: " + grade);
        scan.close();
    }
}
