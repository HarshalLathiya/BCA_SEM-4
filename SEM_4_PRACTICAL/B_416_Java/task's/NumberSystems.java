public class NumberSystems {
    public static void main(String[] args) {
        int binary1 = 0b1010, binary2 = 0b1100;
        int decimal1 = 10, decimal2 = 20;
        int hex1 = 0xA, hex2 = 0xF;
        int octal1 = 012, octal2 = 015;

        System.out.println("Binary Addition: " + (binary1 + binary2));
        System.out.println("Decimal Multiplication: " + (decimal1 * decimal2));
        System.out.println("Hexadecimal Subtraction: " + (hex1 - hex2));
        System.out.println("Octal Division: " + (octal1 / octal2));
    }
}
