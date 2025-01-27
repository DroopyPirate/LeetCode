using System;
using System.Collections.Generic;

class LC49 {
    public static List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        // Dictionary<string, List<int>> mapInteger = new Dictionary<string, List<int>>();
        for (int i = 0; i < strs.Length; i++) {
            char[] charArray = strs[i].ToCharArray();
            Array.Sort(charArray);
            string sortedString = new string(charArray);

            // if(mapInteger.ContainsKey(sortedString)){
            //     mapInteger[sortedString].Add(i);
            // }
            // else{
            //     List<int> list = new List<int>();
            //     list.Add(i);
            //     mapInteger[sortedString] = list;
            // }
            // can be done as
            if (!map.ContainsKey(sortedString)) {
                map[sortedString] = new List<string>();
            }
            map[sortedString].Add(strs[i]);
        }

        // List<List<string>> result = new List<List<string>>();
        // for (List<int> value : map.Values){
        //     List<string> anagramList = new List<string>();
        //     for (int index : value) {
        //         anagramList.Add(strs[index]);
        //     }
        //     result.Add(anagramList);
        // }
        // return result
        // can be done as
        return new List<List<string>>(map.Values);
    }

    public static void Main(string[] args) {
        string[] strs = {"eat", "tea", "tan", "ate", "nat", "bat"};
        List<List<string>> result = GroupAnagrams(strs);
        foreach (List<string> list in result) {
            foreach (string str in list) {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
    }
}
