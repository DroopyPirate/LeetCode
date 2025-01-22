import java.util.*;
class LC424 {
    public int characterReplacement(String s, int k) {
        HashMap<Character, Integer> map = new HashMap<Character, Integer>();
        int right = 0, left = 0, result = 0;

        while(right < s.length()){
            //Access the current character
            Character currentChar = s.charAt(right);

            //Update the hashmap, record frequency
            map.put(currentChar, map.getOrDefault(currentChar, 0) + 1);

            //get max frequency
            int maxValue = Collections.max(map.values());

            //Condition value
            int condition = right - left + 1 - maxValue;

            //Match the condition
            if(condition == k){
                result = right - left + 1;
            }

            //Access left character
            Character leftChar = s.charAt(left);

            //If condition exceeds k, shrink the window
            if(condition > k){
                map.put(leftChar, map.get(leftChar) - 1);
                left++;
            }

            //Increament the loop
            right++;
        }
        //Return result
        return result == 0 ? s.length() : result;
    }

    public static void main(String[] args) {
        LC424 obj = new LC424();
        System.out.println(obj.characterReplacement("ABAB", 2)); // 4
        System.out.println(obj.characterReplacement("AABABBA", 1)); // 4
    }
}