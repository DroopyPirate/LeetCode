class LC238 {
    public int[] productExceptSelf(int[] nums) {
        int[] prefix_product = new int[nums.length];
        for(int i = 0; i < nums.length; i++)
            prefix_product[i] = 1;
        int right_temp = 1;
        for(int i = 0; i < nums.length; i++){
            prefix_product[i] *= right_temp;
            right_temp *= nums[i];
        }
        int left_temp = 1;
        for(int i = nums.length - 1; i >= 0; i--){
            prefix_product[i] *= left_temp;
            left_temp *= nums[i];
        }
        return prefix_product;
    }

    public static void main(String[] args) {
        LC238 lc238 = new LC238();
        int[] nums = {1, 2, 3, 4};
        int[] result = lc238.productExceptSelf(nums);
        for(int i = 0; i < result.length; i++)
            System.out.print(result[i] + " "); // Expected: 24 12 8 6
    }
}