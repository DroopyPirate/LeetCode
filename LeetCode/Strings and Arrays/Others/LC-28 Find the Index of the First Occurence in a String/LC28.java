class LC28 {
    public static int strStr(String haystack, String needle) {
        if(needle.length() > haystack.length())
            return -1;

        int right = needle.length(), left = 0;
        while(right <= haystack.length()){
            if(haystack.substring(left, right).equals(needle))
                return left;
            left++;
            right++;
        }

        return -1;
    }

    public static void main(String[] args){
        System.out.println(strStr("hello", "ll"));
        System.out.println(strStr("aaaaa", "bba"));
        System.out.println(strStr("", ""));
        System.out.println(strStr("a", "a"));
        System.out.println(strStr("mississippi", "issip"));
    }
}