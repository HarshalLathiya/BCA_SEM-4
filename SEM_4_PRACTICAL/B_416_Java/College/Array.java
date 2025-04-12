//write a Java program to perform Array variable
public class Array{
    public static void main(String[] args) {
        // Creating an array of strings
        String[] fruits = new String[5];

        fruits[0] = "Apple";
        fruits[1] = "Banana";
        fruits[2] = "Orange";
        fruits[3] = "Grape";
        fruits[4] = "Mango";

        System.out.println("Fruits in the array:");
        for (int i = 0; i < fruits.length; i++) {
            System.out.println(fruits[i]);
        }

        System.out.println("\nFruits using for-each loop:");
        for (String fruit : fruits) {
            System.out.println(fruit);
        }

        System.out.println("\nTotal number of fruits in the array: " + fruits.length);

        System.out.println("\nThe fruit at index 2 is: " + fruits[2]);

        fruits[2] = "Pineapple";
        System.out.println("\nAfter modification, the fruit at index 2 is: " + fruits[2]);
    }
}
