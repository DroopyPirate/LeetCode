import java.util.Arrays;

class LC62 {
    public static int uniquePaths(int m, int n) {
        if (m == 1 || n == 1)
            return 1;
        
        int[] aboveRow = new int[n];
        Arrays.fill(aboveRow, 1);

        for(int row=1; row<m; row++){
            int[] currentRow = new int[n];
            currentRow[0] = 1;
            for(int col=1; col < n; col++){
                currentRow[col] = currentRow[col-1] + aboveRow[col];
            }
            aboveRow = currentRow;
        }
        return aboveRow[n-1];
    }

    public static void main(String[] args) {
        System.out.println(uniquePaths(3, 7)); // Output: 28
        System.out.println(uniquePaths(3, 2)); // Output: 3
        System.out.println(uniquePaths(7, 3)); // Output: 28
        System.out.println(uniquePaths(3, 3)); // Output: 6
    }
}