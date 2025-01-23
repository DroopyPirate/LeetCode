import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
class LC15 {
    public static List<List<Integer>> threeSum(int[] nums) {
        //Sort the array
        Arrays.sort(nums);

        List<List<Integer>> list = new ArrayList<>();

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
                if(sum == 0){
                    list.add(new ArrayList<Integer>(Arrays.asList(nums[i], nums[right], nums[left])));
                    //Skip duplicate values
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    left++;
                    right--;
                }
                else if(sum > 0){
                    right--;
                }
                else{
                    left++;
                }
            }
        }

        return list;
    }

    public static void main(String[] args) {
        int[] nums = {-1,0,1,2,-1,-4};
        List<List<Integer>> list = threeSum(nums);
        for(List<Integer> l : list){
            System.out.println(l);
        }
    }
}