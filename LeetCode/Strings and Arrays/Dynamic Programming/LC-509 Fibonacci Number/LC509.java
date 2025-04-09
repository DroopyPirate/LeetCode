class LC509 {
    public static int fib(int n) {
        // if (n == 0) return 0;
        // if (n==1) return 1;
        // return fib(n-1) + fib(n-2);

        //Or by dynamic

        if(n==0 || n==1)
            return n;
        
        int[] dp = new int[n+1];
        dp[0] = 0;
        dp[1] = 1;

        for(int i = 2; i<=n; i++){
            dp[i] = dp[i-1] +  dp[i-2];
        }
        return dp[n];
    }

    public static void main(String[] args) {
        System.out.println(fib(4)); // Output: 3
        System.out.println(fib(5)); // Output: 5
        System.out.println(fib(6)); // Output: 8
        System.out.println(fib(7)); // Output: 13
    }
}