class StaticNonStatic {
    static void staticMethod() {
        System.out.println("Static method called.");
    }

    void nonStaticMethod() {
        System.out.println("Non-static method called.");
    }

    public static void main(String[] args) {
        staticMethod(); // Calling static method
        
        StaticNonStatic obj = new StaticNonStatic();
        obj.nonStaticMethod(); // Calling non-static method
    }
}
