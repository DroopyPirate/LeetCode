import java.util.ArrayList;

public class LC60 {
    public static String getPermutation(int n, int k) {
        ArrayList<Integer> list=new ArrayList<>();
        for (int i = 1; i <= n; i++) {
            list.add(i);
        }
        String returnString = "";
        k--;
        while(n>0){
            int factorialValue = factorial(n-1);
            int x = k / factorialValue;
            returnString += list.get(x);
            list.remove(x);
            n--;
            k %= factorialValue;
        }
        return returnString;
    }

    public static int factorial(int n){
        if (n==1 || n==0)
            return 1;
        return n * factorial(n-1);
    }

    public static void main(String[] args){
        System.out.println(getPermutation(3,3));
        System.out.println(getPermutation(4,9));
        System.out.println(getPermutation(3,1));
    }
}
