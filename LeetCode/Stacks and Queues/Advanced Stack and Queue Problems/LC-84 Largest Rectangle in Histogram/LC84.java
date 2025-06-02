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

/*

215623
012345


// poped = 2, maxArea = 2, maxArea = 6, maxArea = 10

poped = 2, maxArea = (2, 0)
poped = 6 maxArea = (6, 2)
poped = 5 maxArea = (10, 6)


      6       3
    5 5 5   2 2
2 1 1 1 1 1 1 1


remaining stack

poped = 3, maxArea = (10, 3),
poped = 2, maxArea = (10, 8),
poped = 1, maxArea = (10, 6)

2
1 1

 */