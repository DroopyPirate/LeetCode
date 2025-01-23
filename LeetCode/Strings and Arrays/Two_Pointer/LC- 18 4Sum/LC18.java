import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
class LC18 {
    public List<List<Integer>> fourSum(int[] nums, int target) {
        //Sort the array
        Arrays.sort(nums);

        List<List<Integer>> list = new ArrayList<>();

        //Loop for fixing one element
        for(int i=0; i<nums.length-3; i++){

            //Skip duplicates
            if(i>0 && nums[i] == nums[i-1]) continue;

            //Loop for fixing second element
            for(int j=i+1; j<nums.length-2; j++){

                //Skip duplicates
                if(j>i+1 && nums[j] == nums[j-1]) continue;

                //Take reamining subarray for two poimter approach
                int left=j+1, right=nums.length-1;

                //Two pointer approach
                while(left < right){
                    long sum = (long) nums[i] + nums[j] + nums[left] + nums[right];
                    if(sum == target){
                        list.add(new ArrayList<Integer>(Arrays.asList(nums[i], nums[j], nums[left], nums[right])));

                        //Skip duplicates
                        while(left<right && nums[left] == nums[left+1]) left++;
                        while(left<right && nums[right] == nums[right-1]) right--;

                        right--;
                        left++;
                    }
                    else if(sum > target){
                        right--;
                    }
                    else{
                        left++;
                    }
                }
            }
        }

        return list;
    }

    public static void main(String[] args) {
        LC18 lc18 = new LC18();
        int[] nums = {1, 0, -1, 0, -2, 2};
        int target = 0;
        List<List<Integer>> list = lc18.fourSum(nums, target);
        for(List<Integer> l : list){
            System.out.println(l);
        }
    }
}