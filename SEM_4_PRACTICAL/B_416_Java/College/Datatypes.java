//write a Java program to perform all datatypes
public class Datatypes{
    public static void main(String[] args) {  
        // Integer types
        byte byteVar = 127; // 1 byte
        short shortVar = 32767; // 2 bytes
        int intVar = 123456; // 4 bytes
        long longVar = 123456789L; // 8 bytes
        
        // Floating point types
        float floatVar = 3.14f; // 4 bytes
        double doubleVar = 3.14159; // 8 bytes
        
        // Character type
        char charVar = 'A'; // 2 bytes
        
        // Boolean type
        boolean booleanVar = true; // 1 byte (size can vary)
        
        // String type (Reference type)
        String stringVar = "Hello, Java!"; // Reference type
        
        // Printing the values of each variable
        System.out.println("Byte value: " + byteVar);
        System.out.println("Short value: " + shortVar);
        System.out.println("Integer value: " + intVar);
        System.out.println("Long value: " + longVar);
        System.out.println("Float value: " + floatVar);
        System.out.println("Double value: " + doubleVar);
        System.out.println("Char value: " + charVar);
        System.out.println("Boolean value: " + booleanVar);
        System.out.println("String value: " + stringVar);
    }
}
