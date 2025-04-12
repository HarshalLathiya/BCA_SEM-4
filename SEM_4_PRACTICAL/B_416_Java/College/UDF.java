//write a Java program to perform udf
public class UDF{

    // Non-static method
    public void printNS() {
        System.out.println("Hello from Non-Static Method!");
    }

    // Static method
    public static void printS() {
        System.out.println("Hello from Static Method!");
    }

	//main part
    	public static void main(String[] args)
	{
		//static function call using class name
	    //im_class.printS();
		UDF obj = new UDF();
        obj.printNS();
		obj.printS();
    }
}
