//write a Java program to perform call by value.
public class CallByValue {
    public static void main(String[] args) {
        System.out.println("Hello Main.!");
        int num1,num2;
        InnerCallByValue obj = new InnerCallByValue();
        obj.sum(10,30);
    }
}

class InnerCallByValue {

    public void sum(int n1, int n2)
    {
        int sum=n1+n2;
        System.out.println("Num1 + Num2:"+sum);
    }
}