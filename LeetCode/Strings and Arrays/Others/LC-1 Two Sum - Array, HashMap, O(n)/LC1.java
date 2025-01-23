import java.util.HashMap;
class LC1 {
    public static int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();

        for(int i=0; i < nums.length; i++){
            int find = target - nums[i];

            if(map.containsKey(find)){
                return new int[]{map.get(find), i};
            }

            map.put(nums[i], i);
        }

        return new int[]{};
    }

    public static void main(String[] args) {
        int[] nums = {2, 7, 11, 15};
        int target = 9;

        int[] result = twoSum(nums, target);

        for(int i=0; i < result.length; i++){
            System.out.print(result[i] + " ");
        }
    }
}