import java.util.Stack;

class LC232 {

    static Stack<Integer> inputStack = new Stack<>();   
    static Stack<Integer> outputStack = new Stack<>();

    public LC232() {
    }
    
    public static void push(int x) {
        inputStack.push(x);
    }
    
    public static int pop() {
        if(outputStack.isEmpty()){
            while(!inputStack.isEmpty()){
                outputStack.push(inputStack.pop());
            }
        }
        return outputStack.pop();
    }
    
    public static int peek() {
        if(outputStack.isEmpty()){
            while(!inputStack.isEmpty()){
                outputStack.push(inputStack.pop());
            }
        }
        return outputStack.peek();
    }
    
    public static boolean empty() {
        return outputStack.isEmpty() && inputStack.isEmpty();
    }

    public static void main(String[] args) {
        LC232.push(1);
        LC232.push(2);
        System.out.println(LC232.peek()); // returns 1
        System.out.println(LC232.pop());  // returns 1
        System.out.println(LC232.empty()); // returns false
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.push(x);
 * int param_2 = obj.pop();
 * int param_3 = obj.peek();
 * boolean param_4 = obj.empty();
 */