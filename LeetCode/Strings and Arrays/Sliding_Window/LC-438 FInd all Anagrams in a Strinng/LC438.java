import java.util.*;
class LC438 {
    public static List<Integer> findAnagrams(String s, String p) {
        List<Integer> result = new ArrayList<>();
        HashMap<Character, Integer> pMap = new HashMap<Character, Integer>();
        HashMap<Character, Integer> sMap = new HashMap<Character, Integer>();
        int right = 0, left = 0, current = 0, required = p.length();

        //Create HashMap for String p and record frequency
        for(Character c: p.toCharArray()){
            pMap.put(c, pMap.getOrDefault(c, 0) + 1);
        }

        //Iterate String s
        while(right < s.length()){
            //Access current character
            Character currentChar = s.charAt(right);

            //Add to map
            sMap.put(currentChar, sMap.getOrDefault(currentChar, 0) + 1);

            //Check frequency and update current count
            if(pMap.containsKey(currentChar) && sMap.getOrDefault(currentChar, 0).intValue() <= pMap.get(currentChar).intValue()){
                current++;
            }

            if(right - left + 1 == required){
                //Condition matched
                if(current == required){
                    result.add(left);
                }

                //Access left character
                Character leftChar = s.charAt(left);

                //Update current count
                if(pMap.containsKey(leftChar) && sMap.getOrDefault(leftChar, 0).intValue() <= pMap.get(leftChar).intValue()){
                    current--;
                }

                //Shrink window from left and update frequency
                sMap.put(leftChar, sMap.get(leftChar) - 1);
                left++;
            }
            //Expand the window
            right++;
        }

        return result;
    }

    public static void main(String[] args) {
        System.out.println(findAnagrams("cbaebabacd", "abc")); // [0, 6]
        System.out.println(findAnagrams("abab", "ab")); // [0, 1, 2]
        System.out.println(findAnagrams("aaaaaaaaaa", "aaaaaaaaaaaaa")); // []
    }
}