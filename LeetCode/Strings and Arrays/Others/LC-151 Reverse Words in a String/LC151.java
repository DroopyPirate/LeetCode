class LC151 {
    public static String reverseWords(String s) {
        String[] words = s.split("\\s+"); //(\\s) means whitespace and + means more than one whitespace
        StringBuilder reverse = new StringBuilder();

        for(int i = words.length-1; i>=0; i--){
            reverse.append(words[i] + " ");
        }

        return reverse.toString().trim();
    }

    public static void main(String[] args){
        String s = "  hello world!  ";
        System.out.println(reverseWords(s));
    }
}