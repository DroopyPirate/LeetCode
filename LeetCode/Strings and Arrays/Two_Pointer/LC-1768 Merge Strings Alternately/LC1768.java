class LC1768 {
    public static String mergeAlternately(String word1, String word2) {
        int m = word1.length(), n = word2.length();
        char[] merged = new char[m + n];

        int i = 0, j = 0, k = 0;
        while (i < m || j < n) {
            if (i < m) merged[k++] = word1.charAt(i++);
            if (j < n) merged[k++] = word2.charAt(j++);
        }
        return new String(merged);
    }

    public static void main(String[] args) {
        String word1 = "abc", word2 = "pqr";
        System.out.println(mergeAlternately(word1, word2)); // Output: "apbqcr"
        System.out.println(mergeAlternately("ab", "pqrs")); // Output: "apbqrs"
        System.out.println(mergeAlternately("abcd", "pq")); // Output: "apbqcd"
    }
}