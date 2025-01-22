import java.util.HashMap;
class LC76 {
    public static String minWindow(String s, String t) {
        //Return in following case
        if(s.length() < t.length())
            return "";

        int right = 0, left = 0;

        //Count of character and frequency for t string
        HashMap<Character, Integer> tMap = new HashMap<>();

        //Insert key and count for t string
        for(char c: t.toCharArray()){
            tMap.put(c, tMap.getOrDefault(c, 0) + 1);
        }

        //Count of character and frequency for window string
        HashMap<Character, Integer> windowMap = new HashMap<>();
        int current = 0, required = t.length(), minLength = Integer.MAX_VALUE, minLeft = 0;

        //Implement sliding window
        while(right < s.length()){
            //Access
            char currentChar = s.charAt(right);

            //Input in window
            windowMap.put(currentChar, windowMap.getOrDefault(currentChar, 0) + 1);

            //Check key and frequency, update required and current
            if(tMap.getOrDefault(currentChar, 0).intValue() >= windowMap.get(currentChar).intValue()){
                //current += windowMap.get(currentChar).intValue();
                current++;
            }

            //if current equals required
            while(current == required ){
                //Update minimum length and record minimum left
                if (right - left + 1 < minLength) {
                    minLength = right - left + 1;
                    minLeft = left;
                }

                //Access left character
                Character leftChar = s.charAt(left);

                //Remove left character from window
                windowMap.put(leftChar, windowMap.get(leftChar) - 1);

                //If left character is target character, decreament required
                if(tMap.containsKey(leftChar) && windowMap.get(leftChar).intValue() < tMap.get(leftChar).intValue()){
                    current--;
                }

                //Loop increament
                left++;
            }

            //Loop increament
            right++;
        }

        //Return mminimum result string
        return minLength == Integer.MAX_VALUE ? "" : s.substring(minLeft, minLeft + minLength);
    }

    public static void main(String[] args) {
        System.out.println(minWindow("ADOBECODEBANC", "ABC")); // BANC
        System.out.println(minWindow("a", "a")); // a
        System.out.println(minWindow("a", "aa")); // ""
        System.out.println(minWindow("a", "b")); // ""
    }
}