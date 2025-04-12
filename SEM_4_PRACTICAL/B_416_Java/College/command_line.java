// Write a Java program to perform Commandline argument
class CommandLine {
    public static void main(String[] args) {
        int count = args.length;
        int i = 0;

        System.out.println("Number of arguments = " + count);

        if (count == 0) {
            System.out.println("No arguments were provided!");
        }

        while (i < count) {
            String str = args[i];
            i = i + 1;
            System.out.println(i + " : " + "Java is " + str + "!");
        }
    }
}
