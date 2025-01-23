import java.util.Arrays;
class LC16 {
    public static int threeSumClosest(int[] nums, int target) {
        //Sort the  array
        Arrays.sort(nums);
        int result = 0, difference = Integer.MAX_VALUE;

        //Iterate the array
        for(int i=0; i<nums.length-2; i++){
            //Take the remaining right side of array
            int left = i+1, right = nums.length-1;

            //Skip duplicate values
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            while(left < right){
                int sum = nums[i] + nums[right] + nums[left];
                int tempDifference = target - sum;
                tempDifference = tempDifference < 0 ? -tempDifference : tempDifference;
                if(tempDifference < difference){
                    result = sum;
                    difference = tempDifference;
                }
                else if(sum > target){
                    right--;
                }
                else{
                    left++;
                }
            }
        }

        return result;
    }

    public static void main(String[] args) {
        int[] nums = {-1, 2, 1, -4};
        int target = 1;
        System.out.println(threeSumClosest(nums, target));
    }
}