class LC303 {

    int[] sum_prefix;

    public LC303(int[] nums) {
        sum_prefix = nums;
        for(int i = 1; i < sum_prefix.length; i++){
            sum_prefix[i] += sum_prefix[i-1];
        }
    }
    
    public int sumRange(int left, int right) {
        if(left == 0)
            return sum_prefix[right];
        return sum_prefix[right] - sum_prefix[left-1];
    }

    public static void main(String[] args){
        int[] nums = {-2, 0, 3, -5, 2, -1};

        // Initialize NumArray
        LC303 obj = new LC303(nums);

        // Call sumRange for the given ranges
        System.out.println(obj.sumRange(0, 2)); // Expected: 1
        System.out.println(obj.sumRange(2, 5)); // Expected: -1
        System.out.println(obj.sumRange(0, 5)); // Expected: -3
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.sumRange(left,right);
 */