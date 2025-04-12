public class AreaSquare {
    public static void main(String[] args) {
        final double pi = 3.14;
        assert pi == 3.14 : "Pi value incorrect!";
        
        int side = 5;
        double area = side * side;
        System.out.println("Area of square: " + area);
    }
}
