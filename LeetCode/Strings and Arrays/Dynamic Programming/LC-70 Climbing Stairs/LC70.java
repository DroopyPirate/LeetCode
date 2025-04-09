class LC70 {
    public static int climbStairs(int n) {
        // 1 - 1
        // 2 - 2 [2, 1 2]
        // 3 - 3 [3, 1 3, 2 3]
        // 4 - 5 [2 4, 2 3 4, 1 3 4, 1 2 3 4, 1 2 4]
        // 5 - 8 [1 2 3 4 5, 1 3 4 5, 1 3 5, 1 2 4 5, 1 2 3 5, 2 3 4 5, 2 4 5, 2 3 5]
        // Looks like fibonacci sequennce. and till n=3 answer is 3

        if(n<=3)
            return n;

        int current = 3, previous = 2;

        for(int i = 4; i <=n; i++){
            int temp = current;
            current += previous;
            previous = temp;
        }
        return current;
    }

    public static void main(String[] args) {
        System.out.println(climbStairs(5)); // Output: 8
        System.out.println(climbStairs(6)); // Output: 13
        System.out.println(climbStairs(7)); // Output: 21
    }
    // Time complexity: O(n)
}