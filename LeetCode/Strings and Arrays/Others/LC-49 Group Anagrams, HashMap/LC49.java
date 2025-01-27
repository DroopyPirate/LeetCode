import java.util.HashMap;
import java.util.List;
import java.util.ArrayList; 
import java.util.Arrays;
class LC49 {
    public static List<List<String>> groupAnagrams(String[] strs) {
        HashMap<String, List<String>> map = new HashMap<String, List<String>>();
        //HashMap<String, List<Integer>> mapInteger = new HashMap<String, List<Integer>>();
        for(int i=0; i<strs.length; i++){
            char[] charArray = strs[i].toCharArray();
            Arrays.sort(charArray);
            String sortedString = new String(charArray);

            // if(mapInteger.containsKey(sortedString)){
            //     mapInteger.get(sortedString).add(i);
            // }
            // else{
            //     List<Integer> list = new ArrayList<>();
            //     list.add(i);
            //     mapInteger.put(sortedString, list);
            // }
            //can be done as
            map.putIfAbsent(sortedString, new ArrayList<>());
            map.get(sortedString).add(strs[i]);
        }

        //List<List<String>> result = new ArrayList<>();
        // for(List<Integer> value: map.values()){
        //     List<String> anagramList = new ArrayList<>();
        //     for(Integer index: value){
        //         anagramList.add(strs[index]);
        //     }
        //     result.add(anagramList);
        // }
        // return result
        //can be done as
        return new ArrayList<List<String>>(map.values());
    }

    public static void main(String[] args){
        String[] strs = {"eat","tea","tan","ate","nat","bat"};
        List<List<String>> result = groupAnagrams(strs);
        for(List<String> list: result){
            for(String str: list){
                System.out.print(str + " ");
            }
            System.out.println();
        }
    }
}