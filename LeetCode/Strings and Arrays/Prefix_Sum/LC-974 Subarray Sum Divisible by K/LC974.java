class LC974 {
    public static int subarraysDivByK(int[] nums, int k) {
        int[] prefix_sum = new int[nums.length];
        prefix_sum[0] = nums[0];
        for(int i = 1; i < nums.length; i++){
            prefix_sum[i] = prefix_sum[i - 1] + nums[i];
        }

        int subArrayCount = 0;

        for(int i = 0; i < nums.length; i++){
            for(int j = i; j < nums.length; j++){
                if(subArraySum(prefix_sum, i, j) % k == 0){
                    //System.out.println("i: " + i + " j: " + j);
                    subArrayCount++;
                }
            }
        }

        return subArrayCount;
    }

    public static int subArraySum(int[] prefix_sum, int start, int end){
        if(start == 0)
            return prefix_sum[end];
        else
            return prefix_sum[end] - prefix_sum[start - 1];
    }

    public static void main(String[] args){
        int[] nums = {4,5,0,-2,-3,1};
        int k = 5;
        System.out.println(subarraysDivByK(nums, k));
    }
}