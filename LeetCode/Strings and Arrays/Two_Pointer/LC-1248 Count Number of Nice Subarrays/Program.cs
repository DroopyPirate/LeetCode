class LC1248 {
    public static int NumberOfSubarrays(int[] nums, int k) {
        int currentOdds = 0, left = 0, right = 0, result = 0, numsLength = nums.Length, evenBeforeLeft = 0;

        while (right < numsLength) {
            // If odd then increase Odds count and reset evenBeforeLeft
            if (nums[right] % 2 == 1) {
                currentOdds++;
                evenBeforeLeft = 0;
            }

            // While k odds are found, increase left pointer and decrease Odds count
            // Also increase evenBeforeLeft if left pointer is even
            while (currentOdds == k) {
                evenBeforeLeft++;
                if (nums[left] % 2 == 1) currentOdds--;
                left++;
            }

            // Add evenBeforeLeft to result for each right pointer even number found
            result += evenBeforeLeft;
            right++;
        }
        return result;
    }

    public static void Main() {
        int[] nums = { 1, 1, 2, 1, 1 };
        int k = 3;
        Console.WriteLine(NumberOfSubarrays(nums, k));
    }
}
