class LC198 {
    public static int rob(int[] nums) {
        int n = nums.length;
        if(n==1) return nums[0];
        int max = nums[0];
        for(int i=2; i<n; i++){
            nums[i] += max;
            max = Math.max(nums[i-1], nums[i-2]);
        }
        return Math.max(nums[n-1], nums[n-2]);
    }

    public static void main(String[] args) {
        int[] nums = {2, 7, 9, 3, 1};
        System.out.println(rob(nums)); // Output: 12
    }
}