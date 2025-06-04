class LC26 {
    public static int removeDuplicates(int[] nums) {
        // int length = nums.length, result = 1, currentNum = nums[0];
        // List<Integer> list = new ArrayList<>();
        
        // for(int i=1; i < length; i++){
        //     if(nums[i] != currentNum){
        //         result++;
        //         currentNum = nums[i];
        //         list.add(nums[i]);
        //     }
        // }

        // int i=1;
        // for(Integer num: list){
        //     nums[i] = num;
        //     i++;
        // }
        // return result;
        int i = 0;
        for(int j=1; j<nums.length; j++){
            if(nums[i] != nums[j]){
                i++;
                nums[i] = nums[j];
            }
        }
        return i+1;
    }

    public static void main(String[] args) {
        int[] nums = {1, 1, 2};
        int length = removeDuplicates(nums);
        System.out.println("Length of array after removing duplicates: " + length);
        for(int i=0; i<length; i++){
            System.out.print(nums[i] + " ");
        }
    }
}