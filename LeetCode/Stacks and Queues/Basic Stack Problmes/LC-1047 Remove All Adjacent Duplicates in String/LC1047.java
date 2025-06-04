class LC1047 {
    public static String removeDuplicates(String s) {
        // Stack<Character> stack = new Stack<Character>();
        // for(int i=0; i<s.length(); i++){
        //     if(!stack.isEmpty() && stack.peek() == s.charAt(i)){
        //         stack.pop();
        //         continue;
        //     }
        //     stack.push(s.charAt(i));
        // }
        // StringBuilder sb = new StringBuilder();
        // while(!stack.isEmpty()){
        //     sb.append(stack.pop());
        // }
        // return sb.reverse().toString();
        int length = s.length();
        char[] stack = new char[length];
        int top = -1;

        for(int i = 0; i < length; i++){
            char c = s.charAt(i);
            if(top >= 0 && stack[top] == c){
                top--;           // pop
            } else {
                stack[++top] = c; // push
            }
        }
        return new String(stack, 0, top + 1);
    }

    public static void main(String[] args) {
        String s = "abbaca";
        System.out.println(removeDuplicates(s)); // Output: "ca"
    }
}