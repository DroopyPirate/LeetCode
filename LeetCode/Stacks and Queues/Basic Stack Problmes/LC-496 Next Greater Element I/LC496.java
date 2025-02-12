import java.util.Hashtable;
import java.util.Stack;
class LC496 {
    public static int[] nextGreaterElement(int[] nums1, int[] nums2) {
        Hashtable<Integer, Integer> table = new Hashtable<>();
        Stack<Integer> stack = new Stack<>();

        for(int num: nums2){
            while(!stack.isEmpty() && stack.peek() < num){
                table.put(stack.pop(), num);
            }
            stack.push(num);
        }

        while(!stack.isEmpty()){
            table.put(stack.pop(), -1);
        }

        for (int i = 0; i < nums1.length; i++) {
            nums1[i] = table.get(nums1[i]);
        }
        return nums1;
    }

    public static void main(String[] args) {
        int[] nums1 = {4, 1, 2};
        int[] nums2 = {1, 3, 4, 2};
        int[] result = nextGreaterElement(nums1, nums2);
        for (int num : result) {
            System.out.print(num + " ");
        }
    }
}