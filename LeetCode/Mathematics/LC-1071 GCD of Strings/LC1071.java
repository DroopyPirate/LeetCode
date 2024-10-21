class LC1071 {
    public static String gcdOfStrings(String str1, String str2) {
        if(!(str1 + str2).equals(str2 + str1))
            return "";
            
        int gcd = findGcd(str1.length(), str2.length());

        return str1.substring(0, gcd);
    }

    public static int findGcd(int a, int b) {
        return b == 0 ? a : findGcd(b, a%b);
    }

    public static void main(String[] args){
        System.out.println(gcdOfStrings("ABCABC", "ABC"));
        System.out.println(gcdOfStrings("ABABAB", "ABAB"));
        System.out.println(gcdOfStrings("LEET", "CODE"));
    }
}
