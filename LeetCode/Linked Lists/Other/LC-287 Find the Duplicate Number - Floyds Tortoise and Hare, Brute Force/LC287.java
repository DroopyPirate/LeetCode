class LC287 {
    //Floyds Tortoise and Hare algorithm
    public static int findDuplicateByFloydTortoiseAndHare(int[] nums) {
        int slow = nums[0], fast = nums[0];

        while(true){
            slow = nums[slow];
            fast = nums[nums[fast]];
            if(slow == fast)
                break;
        }

        int slow2 = nums[0];

        while(slow != slow2){
            slow = nums[slow];
            slow2 = nums[slow2];
        }
        return slow;
    }

    //brute force by boolean array
    public static int findDuplicateByBooleanBruteForce(int[] nums){
        int n = nums.length;
        boolean[] check = new boolean[n+1];
        for(int i: nums){
            if(check[i]) return i;
            else check[i] = true;
        }
        return -1;
    }

    public static void main(String[] args) {
        int[] nums = {1,3,4,2,2};
        System.out.println(findDuplicateByFloydTortoiseAndHare(nums));
        System.out.println(findDuplicateByBooleanBruteForce(nums));
    }
}