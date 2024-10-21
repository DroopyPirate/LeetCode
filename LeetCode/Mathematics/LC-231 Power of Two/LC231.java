class LC231 {

    public static boolean isPowerOfTwoAlternativeSolution(int n) {
        // Check if n is greater than 0 and if n AND (n-1) is 0
        return n > 0 && (n & (n - 1)) == 0;
        //This method works because a power of two has exactly one bit set to 1 in its binary representation, 
        //and n & (n - 1) will clear that bit if n is a power of two, resulting in 0.
    }

    public static boolean isPowerOfTwo(int n) {
        if(n<=0)
            return false;
        
        while(n%2 == 0){
            n /= 2;
        }

        if(n==1)
            return true;
        
        return false;
    }

    public static void main(String[] args){
        System.out.println(isPowerOfTwo(1));
        System.out.println(isPowerOfTwo(16));
        System.out.println(isPowerOfTwo(3));
        System.out.println(isPowerOfTwo(0));

        System.out.println(isPowerOfTwoAlternativeSolution(1));
        System.out.println(isPowerOfTwoAlternativeSolution(16));
        System.out.println(isPowerOfTwoAlternativeSolution(3));
        System.out.println(isPowerOfTwoAlternativeSolution(0));

    }
}