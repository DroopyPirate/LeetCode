using System;

class LC27 {
    public static int removeElement(int[] nums, int val) {
        int i = nums.Length - 1;
        for (int j = i; j >= 0; j--) {
            if (nums[j] == val) {
                int temp = nums[j];
                nums[j] = nums[i];
                nums[i] = temp;
                i--;
            }
        }
        return i + 1;
    }

    public static void Main(string[] args) {
        int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;
        int newLength = removeElement(nums, val);
        Console.WriteLine("New length: " + newLength);
        for (int i = 0; i < newLength; i++) {
            Console.Write(nums[i] + " ");
        }
    }
}
