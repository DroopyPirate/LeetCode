class LC387 {
    public static int firstUniqChar(String s) {
        //HashMap - 35 ms solution
        // HashMap<Character, Integer> map = new HashMap<>();
        // char[] charArray = s.toCharArray();
        // for(char currentChar: charArray){
        //     map.put(currentChar, map.getOrDefault(currentChar, 0) + 1);
        // }

        // for(int i = 0; i < charArray.length; i++){
        //     if(map.get(charArray[i]) == 1)
        //         return i;
        // }
        // return -1;

        //Queue - 17 ms solution
        // int[] frequencyArray = new int[26];
        // Queue<Integer> queue = new LinkedList<>();

        // for(char currentChar: s.toCharArray()){
        //     int index = currentChar - 'a';
        //     frequencyArray[index]++;
        //     queue.offer(index);
        // }

        // for(int i = 0; i < s.length(); i++){
        //     if(!queue.isEmpty() && frequencyArray[s.charAt(i) - 'a'] == 1){
        //         return i;
        //     }
        //     queue.poll();
        // }
        // return -1;


        // Array - 4ms solution
        int[] frequencyArray = new int[26];
        char[] charArray = s.toCharArray();

        for (char currentChar: charArray)
        {
            frequencyArray[currentChar - 'a']++;
        }

        for (int i=0; i < charArray.length; i++)
        {
            if (frequencyArray[charArray[i]-'a'] == 1)
            {
                return i;
            }
        }
        return -1;
    }

    public static void main(String[] args) {
        String s = "leetcode";
        System.out.println(firstUniqChar(s)); // Output: 0
        s = "loveleetcode";
        System.out.println(firstUniqChar(s)); // Output: 2
        s = "aabb";
        System.out.println(firstUniqChar(s)); // Output: -1
    }
}