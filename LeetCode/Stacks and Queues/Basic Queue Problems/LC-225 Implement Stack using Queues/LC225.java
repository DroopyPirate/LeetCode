import java.util.LinkedList;
import java.util.Queue;

class LC225 {

    static Queue<Integer> queue1 = new LinkedList<>();
    static Queue<Integer> queue2 = new LinkedList<>();

    public LC225() {
        
    }
    
    public static void push(int x) {
        queue1.offer(x);
    }
    
    public static int pop() {
        while(queue1.size() > 1){
            queue2.offer(queue1.poll());
        }
        int topElement = queue1.poll();
        swapQueues();
        return topElement;
    }
    
    public static int top() {
        while(queue1.size() > 1){
            queue2.offer(queue1.poll());
        }
        int topElement = queue1.peek();
        queue2.offer(queue1.poll());
        swapQueues();
        return topElement;
    }
    
    public static boolean empty() {
        return queue1.isEmpty();
    }

    public static void swapQueues(){
        Queue<Integer> temp = queue1;
        queue1 = queue2;
        queue2 = temp;
    }

    public static void main(String[] args) {
        LC225.push(1);
        LC225.push(2);
        System.out.println(LC225.top()); // returns 2
        System.out.println(LC225.pop()); // returns 2
        System.out.println(LC225.empty()); // returns false
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.push(x);
 * int param_2 = obj.pop();
 * int param_3 = obj.top();
 * boolean param_4 = obj.empty();
 */