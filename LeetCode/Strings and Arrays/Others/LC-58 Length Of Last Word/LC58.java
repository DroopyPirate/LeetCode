class LC58 {
    public static int lengthOfLastWord(String s) {
        s = s.trim();
        int lastIndex = s.lastIndexOf(" ");
        return s.substring(lastIndex+1).length();
    }

    public static void main(String[] args) {
        String s = "Hello World";
        System.out.println(lengthOfLastWord(s));
    }
}