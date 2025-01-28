import java.util.HashMap;
class LC567 {
    public static boolean checkInclusion(String s1, String s2) {
        HashMap<Character, Integer> s1Map = new HashMap<Character, Integer>();
        HashMap<Character, Integer> s2Map = new HashMap<Character, Integer>();
        int right = 0, left = 0, targetCount = 0, s1Length = s1.length(), s2Length = s2.length();

        for(int i = 0; i < s1Length; i++){
            Character currentChar = s1.charAt(i);
            s1Map.put(currentChar, s1Map.getOrDefault(currentChar, 0) + 1);
        }

        while(right < s2Length){
            //Get current character
            Character currentChar = s2.charAt(right);

            //Update s2 HashMap
            s2Map.put(currentChar, s2Map.getOrDefault(currentChar, 0) + 1);

            if(s1Map.containsKey(currentChar) && s1Map.get(currentChar).intValue() >= s2Map.get(currentChar).intValue()){
                targetCount++;
            }

            //Shrink window when window length is of length s1
            if(right - left + 1 == s1Length){
                //Check if target and length is matched
                if(targetCount == s1Length)
                    return true;
                //Before shrinking update s2 HashMap
                Character leftChar = s2.charAt(left);
                s2Map.put(leftChar, s2Map.get(leftChar) - 1);

                //Also decreament targetCount if leftChar was in s1 and its count is less than s1
                if(s1Map.containsKey(leftChar) && s2Map.get(leftChar).intValue() < s1Map.get(leftChar).intValue())
                    targetCount--;

                left++;
            }

            //Expand the window
            right++;
        }

        return false;
    }

    public static void main(String[] args){
        System.out.println(checkInclusion("ab", "eidbaooo"));
        System.out.println(checkInclusion("ad   ", "eidbaooo"));
    }
}