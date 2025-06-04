import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;

class LC187 {
    public static List<String> findRepeatedDnaSequences(String s) {
        // HashMap<String, Integer> map = new HashMap<String, Integer>();
        // List<String> result = new ArrayList<>();

        // for(int i = 10; i <= s.length(); i++){
        //     String currentString = s.substring(i-10, i);

        //     map.put(currentString, map.getOrDefault(currentString, 0) + 1);
        // }

        // for(String key: map.keySet()){
        //     if(map.get(key).intValue() > 1){
        //         result.add(key);
        //     }
        // }

        // return result;

        HashSet<String> set = new HashSet<>();
        List<String> result = new ArrayList<>();

        for(int i = 10; i <= s.length(); i++){
            String currentString = s.substring(i-10, i);

            if(!set.add(currentString)){
                if(!result.contains(currentString)){
                    result.add(currentString);
                }
            }
        }

        return result;
    }

    public static void main(String[] args) {
        String s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT";
        List<String> result = findRepeatedDnaSequences(s);
        System.out.println(result); // Output: [AAAAACCCCC, CCCCCAAAAA]
    }
}