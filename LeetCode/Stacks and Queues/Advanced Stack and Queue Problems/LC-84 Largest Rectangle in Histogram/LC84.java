import java.util.Stack;

class LC84 {
    public static int largestRectangleArea(int[] heights) {
        int n = heights.length;
        int maxArea = 0;
        Stack<Integer> stack = new Stack<Integer>();
        
        for(int i=0; i<n; i++){
            while(!stack.isEmpty() && heights[stack.peek()] > heights[i]){
                int poppedElementIndex = stack.pop();
                int rightSmallerElementIndex = i;
                int leftSmallerElementIndex = stack.isEmpty() ? -1 : stack.peek();
                int multiplyFactor = rightSmallerElementIndex - leftSmallerElementIndex - 1;
                maxArea = Math.max(maxArea, heights[poppedElementIndex] * multiplyFactor);
            }
            stack.push(i);
        }

        while(!stack.isEmpty()){
            int poppedElementIndex = stack.pop();
            int rightSmallerElementIndex = n;
            int leftSmallerElementIndex = stack.isEmpty() ? -1 : stack.peek();
            int multiplyFactor = rightSmallerElementIndex - leftSmallerElementIndex - 1;
            maxArea = Math.max(maxArea, heights[poppedElementIndex] * multiplyFactor);
        }

        return maxArea;
    }

    public static void main(String[] args) {
        int[] heights = {2, 1, 5, 6, 2, 3};
        System.out.println(largestRectangleArea(heights)); // Output: 10
    }
}