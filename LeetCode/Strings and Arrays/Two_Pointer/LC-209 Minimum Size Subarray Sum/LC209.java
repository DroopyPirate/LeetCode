class LC209 {
    public static int minSubArrayLen(int target, int[] nums) {
        int minLength = Integer.MAX_VALUE, right = 0, left = 0, sum = 0;

        while(right < nums.length){
            //Add the current element
            sum += nums[right];

            //Check is condition matches
            while(sum >= target){
                minLength = Math.min(minLength, right - left + 1);
                //Shrink the window
                sum -= nums[left++];
            }

            //Increament the loop
            right++;
        }

        return minLength == Integer.MAX_VALUE ? 0 : minLength;
    }

    public static void main(String[] args) {
        int[] nums = {2,3,1,2,4,3};
        int target = 7;
        System.out.println(minSubArrayLen(target, nums));
    }
}