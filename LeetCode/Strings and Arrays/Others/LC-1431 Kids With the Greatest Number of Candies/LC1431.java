import java.util.ArrayList;
import java.util.List;

class LC1431 {
    public static List<Boolean> kidsWithCandies(int[] candies, int extraCandies) {
        List<Boolean> result = new ArrayList<>();
        int max = 0;
        for(int candy: candies){
            if(candy >= max){
                max = candy;
            }
        }
        for(int candy: candies){
            result.add(candy + extraCandies >= max);
        }
        return result;
    }
    
    public static void main(String[] args) {
        int[] candies = {2, 3, 5, 1, 3};
        int extraCandies = 3;
        List<Boolean> result = kidsWithCandies(candies, extraCandies);
        System.out.println(result); // Output: [true, true, true, false, true]
    }
}