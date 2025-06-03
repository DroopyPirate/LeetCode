import java.util.ArrayList;
import java.util.Deque;
import java.util.LinkedList;
import java.util.List;

class LC239 {
    public static int[] maxSlidingWindow(int[] nums, int k) {
        List<Integer> result = new ArrayList<>();
        Deque<Integer> deque = new LinkedList<>();
        
        for(int index = 0; index < nums.length; index++){
            int num = nums[index];

            while(!deque.isEmpty() && deque.getLast() < num){
                deque.pollLast();
            }

            deque.addLast(num);

            if(index >= k && nums[index - k] == deque.getFirst()){
                deque.pollFirst();
            }

            if(index >= k-1){
                result.add(deque.getFirst());
            }
        }

        return result.stream().mapToInt(i -> i).toArray();
    }

    public static void main(String[] args) {
        int[] nums = {1, 3, -1, -3, 5, 3, 6, 7};
        int k = 3;
        int[] result = maxSlidingWindow(nums, k);
        for (int num : result) {
            System.out.print(num + " ");
        }
    }
}