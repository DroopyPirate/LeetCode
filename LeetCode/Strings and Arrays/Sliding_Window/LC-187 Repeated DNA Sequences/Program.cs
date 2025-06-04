using System;
using System.Collections.Generic;

class LC187 {
    public static List<string> findRepeatedDnaSequences(string s) {
        // Dictionary<string, int> map = new Dictionary<string, int>();
        // List<string> result = new List<string>();

        // for(int i = 10; i <= s.Length; i++){
        //     string currentString = s.Substring(i - 10, 10);

        //     map[currentString] = map.GetValueOrDefault(currentString, 0) + 1;
        // }

        // foreach(string key in map.Keys){
        //     if(map[key] > 1){
        //         result.Add(key);
        //     }
        // }

        // return result;

        HashSet<string> set = new HashSet<string>();
        List<string> result = new List<string>();

        for(int i = 10; i <= s.Length; i++){
            string currentString = s.Substring(i - 10, 10);

            if(!set.Add(currentString)){
                if(!result.Contains(currentString)){
                    result.Add(currentString);
                }
            }
        }

        return result;
    }

    public static void Main(string[] args) {
        string s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT";
        List<string> result = findRepeatedDnaSequences(s);
        Console.WriteLine($"[{string.Join(", ", result)}]"); // Output: [AAAAACCCCC, CCCCCAAAAA]
    }
}
