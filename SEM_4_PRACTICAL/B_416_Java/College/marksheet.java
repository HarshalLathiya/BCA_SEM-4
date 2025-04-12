import java.util.Scanner;

class Marksheet {

    public static void main(String[] args) 
    {
        Scanner scanner = new Scanner(System.in);

        // Ask for the number of subjects
        System.out.print("Enter the number of subjects: ");
        int totalSubjects = scanner.nextInt();
        scanner.nextLine(); // Consume newline left by nextInt()

        // Ask for the total marks per subject
        System.out.print("Enter the total marks per subject: ");
        int totalMarksPerSubject = scanner.nextInt();
        scanner.nextLine(); // Consume newline left by nextInt()

        // Declare arrays based on user input
        String[] subjects = new String[totalSubjects];
        int[] marks = new int[totalSubjects];

        // Input subjects and marks
        for (int i = 0; i < totalSubjects; i++) {
            System.out.print("Enter the name of subject " + (i + 1) + ": ");
            subjects[i] = scanner.nextLine();

            System.out.print("Enter the marks for " + subjects[i] + ": ");
            marks[i] = scanner.nextInt();
            scanner.nextLine(); // Consume newline left by nextInt()
        }

        // Initialize variable for total marks
        int totalMarksObtained = 0;

        // Loop to calculate total marks and check for failure
        for (int i = 0; i < totalSubjects; i++) {
            totalMarksObtained += marks[i]; // Add marks to total

            // Check if any subject has marks less than 40, and if so, print "Fail" and exit the loop
            if (marks[i] < 40) {
                System.out.println("\nMarksheet:");
                for (int j = 0; j < totalSubjects; j++) {
                    System.out.printf("%s: %d/%d%n", subjects[j], marks[j], totalMarksPerSubject);
                }
                System.out.println("Total Marks Obtained: " + totalMarksObtained + "/" + (totalMarksPerSubject * totalSubjects));
                System.out.printf("Percentage: %.2f%%%n", (double) totalMarksObtained / (totalMarksPerSubject * totalSubjects) * 100);
                System.out.println("Result: Fail");
                return; // Exit if student fails
            }
        }

        // If the loop completes without finding a failing mark, the student passes
        System.out.println("\nMarksheet:");
        for (int i = 0; i < totalSubjects; i++) {
            System.out.printf("%s: %d/%d%n", subjects[i], marks[i], totalMarksPerSubject);
        }
        System.out.println("Total Marks Obtained: " + totalMarksObtained + "/" + (totalMarksPerSubject * totalSubjects));
        System.out.printf("Percentage: %.2f%%%n", (double) totalMarksObtained / (totalMarksPerSubject * totalSubjects) * 100);
        System.out.println("Result: Pass");

        scanner.close(); // Close the scanner to free up resources
    }
}
