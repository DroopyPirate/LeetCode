import java.util.Stack;

class LC503 {
    public static int[] nextGreaterElements(int[] nums) {
        Stack<Integer> stack = new Stack<>();
        int capacity = nums.length;
        int[] answer = new int[capacity];
        for(int i = 0; i < capacity; i++){
            answer[i] = -1;
        }
        for(int i = 0; i < capacity*2; i++){
            while(!stack.isEmpty() && nums[stack.peek()] < nums[i%capacity]){
                answer[stack.pop()] = nums[i%capacity];
            }
            if(i < capacity)
                stack.push(i);
        }
        return answer;
    }

    public static void main(String[] args) {
        int[] nums = {1, 2, 1};
        int[] result = nextGreaterElements(nums);
        for (int num : result) {
            System.out.print(num + " ");
        }
    }
}