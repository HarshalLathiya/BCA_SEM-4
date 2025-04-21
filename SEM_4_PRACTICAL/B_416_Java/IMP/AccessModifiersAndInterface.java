
interface Playable {
    void play();
}

class Guitar implements Playable {
    public void play() {
        System.out.println("Playing Guitar");
    }
}

class Piano implements Playable {
    public void play() {
        System.out.println("Playing Piano");
    }
}

class AccessExample {
    private int privateVar = 1;
    protected int protectedVar = 2;
    public int publicVar = 3;

    public void show() {
        System.out.println("Private: " + privateVar + ", Protected: " + protectedVar + ", Public: " + publicVar);
    }
}

class SubClass extends AccessExample {
    public void accessMembers() {
        System.out.println("Protected: " + protectedVar);
        System.out.println("Public: " + publicVar);
    }
}
