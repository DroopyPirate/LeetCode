class LC647 {
    public static int countSubstrings(String s) {
        int length = s.length();
        int count = length;
        boolean[][] dp = new boolean[length][length];

        //Create dynamic programming table
        dp[0][0] = true;
        for(int i=1; i<length; i++){
            dp[i][i] = true;
            if(s.charAt(i) == s.charAt(i-1)){
                dp[i-1][i] = true;
                count++;
            }
        }

        for(int diff=2; diff<length; diff++){
            for(int i=0; i<length-diff; i++){
                int j = i+diff;
                if(s.charAt(i) == s.charAt(j) && dp[i+1][j-1] == true){
                    count++;
                    dp[i][j] = true;
                }
            }
        }

        return count;
    }

    public static void main(String[] args){
        System.out.println(countSubstrings("abc"));
    }
}