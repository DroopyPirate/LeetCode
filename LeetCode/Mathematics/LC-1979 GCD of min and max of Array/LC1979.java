class LC1979 {
    public static int findGCD(int[] nums) {
        int min = Integer.MAX_VALUE;
        int max = 0;
        for(int i=0; i<nums.length; i++){
            if(nums[i] <= min)
                min = nums[i];
            if(nums[i] > max)
                max = nums[i];
        }

        for(int j = (min+max)/2; j>0; j--){
            if(min%j==0 && max%j==0)
                return j;
        }
        return 1;
    }
    
    public static void main(String[] args){
        System.out.println(findGCD(new int[]{2,5,6,9,10}));
    }
}