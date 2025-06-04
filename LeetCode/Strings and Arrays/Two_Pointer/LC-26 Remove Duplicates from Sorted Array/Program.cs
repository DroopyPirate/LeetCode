using System;
using System.Collections.Generic;

class LC26 {
    public static int removeDuplicates(int[] nums) {
        // int length = nums.Length, result = 1, currentNum = nums[0];
        // List<int> list = new List<int>();
        
        // for(int i=1; i < length; i++){
        //     if(nums[i] != currentNum){
        //         result++;
        //         currentNum = nums[i];
        //         list.Add(nums[i]);
        //     }
        // }

        // int i=1;
        // foreach(int num in list){
        //     nums[i] = num;
        //     i++;
        // }
        // return result;
        int i = 0;
        for(int j = 1; j < nums.Length; j++){
            if(nums[i] != nums[j]){
                i++;
                nums[i] = nums[j];
            }
        }
        return i + 1;
    }

    public static void Main(string[] args) {
        int[] nums = {1, 1, 2};
        int length = removeDuplicates(nums);
        Console.WriteLine("Length of array after removing duplicates: " + length);
        for(int i = 0; i < length; i++){
            Console.Write(nums[i] + " ");
        }
    }
}
