import java.util.Stack;

class LC42 {
    public static int trap(int[] height) {
        int length = height.length;
        int area = 0;
        Stack<Integer> stack = new Stack<Integer>();

        for(int currentIndex = 0; currentIndex<length; currentIndex++){
            while(!stack.isEmpty() && height[stack.peek()] < height[currentIndex]){
                int middleElementIndex = stack.pop();

                if(stack.isEmpty())
                    break;
                
                int leftElementIndex = stack.peek();
                int uncalculatedHeight = Math.min(height[currentIndex] - height[middleElementIndex], height[leftElementIndex] - height[middleElementIndex]);
                int spaceBetweenLeftAndCurrent = currentIndex - leftElementIndex - 1;

                area += spaceBetweenLeftAndCurrent * uncalculatedHeight;
            }
            stack.push(currentIndex);
        }

        return area;
    }

    public static void main(String[] args) {
        int[] height = {0,1,0,2,1,0,1,3,2,1,2,1};
        System.out.println("Trapped rainwater: " + trap(height)); // Output: 6
    }
}

/*

01021013212 1
01234567891011

e = 1 pop = 0 total = 0
e = 2 pop = 0 total = 1
e = 1 pop = 0 total = 2
e = 3 pop = 1 total = 2
e = 3 pop = 1 total = 5
e = 2 pop = 1 total = 6



                        1   1
          0   1       2 2 2 2
        1 1 1 1 1   3 3 3 3 3
  0   2 2 2 2 2 2 2 2 2 2 2 2
0 1 1 1 1 1 1 1 1 1 1 1 1 1 1 

*/
// Output: 6