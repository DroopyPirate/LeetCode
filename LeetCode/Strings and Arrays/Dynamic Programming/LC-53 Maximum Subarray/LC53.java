class LC53 {
    public static int maxSubArray(int[] nums) {
        int n = nums.length;
        int dp []=  new int[n];
        int max  =  nums[0];
        dp[0] =  nums[0];

        for( int i=1; i<n; i++){
            dp[i] =  Math.max(dp[i-1] + nums[i] ,  nums[i]);
            if(dp[i]>max)
                max = dp[i];
        }
        return max;
    }

    public static void main(String[] args) {
        int[] nums = {-2,1,-3,4,-1,2,1,-5,4};
        System.out.println(maxSubArray(nums)); // Output: 6
    }
}