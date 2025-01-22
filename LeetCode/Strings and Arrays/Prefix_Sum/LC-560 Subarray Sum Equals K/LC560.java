class LC560 {
    static int[] prefix_sum;
    public static int subarraySum(int[] nums, int k) {
        prefix_sum = nums;
        int result = 0;
        for(int i = 1; i < prefix_sum.length; i++)
            prefix_sum[i] += prefix_sum[i-1];
        for(int i = 0; i < prefix_sum.length; i++){
            for(int j = i; j < prefix_sum.length; j++){
                if(prefixSum(i, j) == k)
                    result++;
            }
        }
        return result;
    }

    public static int prefixSum(int left, int right){
        if(left == 0)
            return prefix_sum[right];
        return prefix_sum[right] - prefix_sum[left-1];
    }

    public static void main(String[] args){
        int[] nums = {1, 1, 1};
        int k = 2;

        System.out.println(subarraySum(nums, k)); // Expected: 2
    }
}