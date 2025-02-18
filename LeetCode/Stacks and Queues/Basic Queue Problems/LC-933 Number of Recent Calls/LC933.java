import java.util.LinkedList;
import java.util.Queue;

class LC933 {
    Queue<Integer> queue;

    public LC933() {
        queue = new LinkedList<>();
    }
    
    public int ping(int t) {
        queue.offer(t);
        int lowerRange = t - 3000;
        while(queue.peek() < lowerRange){
            queue.poll();
        }
        return queue.size();
    }

    public static void main(String[] args) {
        LC933 obj = new LC933();
        System.out.println(obj.ping(1)); // Output: 1
        System.out.println(obj.ping(100)); // Output: 2
        System.out.println(obj.ping(3001)); // Output: 3
        System.out.println(obj.ping(3002)); // Output: 3
        System.out.println(obj.ping(6000)); // Output: 4
    }
}
