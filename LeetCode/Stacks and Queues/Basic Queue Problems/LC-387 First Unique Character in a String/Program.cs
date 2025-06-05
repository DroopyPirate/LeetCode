using System;
using System.Collections.Generic;

class LC387
{
    public static int firstUniqChar(string s)
    {
        //Dictionary – 35 ms solution
        // Dictionary<char, int> map = new Dictionary<char, int>();
        // char[] charArray = s.ToCharArray();
        // foreach (char currentChar in charArray)
        // {
        //     map[currentChar] = map.GetValueOrDefault(currentChar, 0) + 1;
        // }
        //
        // for (int i = 0; i < charArray.Length; i++)
        // {
        //     if (map[charArray[i]] == 1)
        //         return i;
        // }
        // return -1;
        //

        
        //Queue – 17 ms solution
        int[] frequencyArray = new int[26];
        Queue<int> queue = new Queue<int>();
        
        foreach (char currentChar in s)
        {
            int index = currentChar - 'a';
            frequencyArray[index]++;
            queue.Enqueue(index);
        }
        
        for (int i = 0; i < s.Length; i++)
        {
            if (queue.Count > 0 && frequencyArray[s[i] - 'a'] == 1)
            {
                return i;
            }
            queue.Dequeue();
        }
        return -1;
        


        //Array – 4 ms solution
        // int[] frequencyArray = new int[26];
        // char[] charArray = s.ToCharArray();

        // foreach (char currentChar in charArray)
        // {
        //     frequencyArray[currentChar - 'a']++;
        // }

        // for (int i = 0; i < charArray.Length; i++)
        // {
        //     if (frequencyArray[charArray[i] - 'a'] == 1)
        //         return i;
        // }
        // return -1;
    }

    public static void Main(string[] args)
    {
        string s = "leetcode";
        Console.WriteLine(firstUniqChar(s)); // Output: 0
        s = "loveleetcode";
        Console.WriteLine(firstUniqChar(s)); // Output: 2
        s = "aabb";
        Console.WriteLine(firstUniqChar(s)); // Output: -1
    }
}

/*
 * Your LC387 object will be instantiated and called as such:
 * LC387 obj = new LC387();
 * int param_1 = LC387.firstUniqChar(s);
 */
