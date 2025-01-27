class LC5 {
    public static String longestPalindrome(String s) {
        int length = s.length();
        boolean[][] dp = new boolean[length][length];
        int[] ans = new int[]{0,0};

        for(int i = 0; i < length-1; i++){
            dp[i][i] = true;
            if(s.charAt(i) == s.charAt(i+1)){
                dp[i][i+1] = true;
                ans[0] = i;
                ans[1] = i+1;
            }
        }
        dp[length-1][length-1] = true;

        for(int diff = 2; diff < length; diff++){
            for(int i = 0; i < length - diff; i++){
                int j = i + diff;
                if(s.charAt(i) == s.charAt(j) && dp[i+1][j-1]){
                    dp[i][j] = true;
                    ans[0] = i;
                    ans[1] = j;
                }
            }
        }

        return s.substring(ans[0], ans[1] + 1);
    }

    public static void main(String[] args){
        String s = "babad";
        System.out.println(longestPalindrome(s));
    }
}