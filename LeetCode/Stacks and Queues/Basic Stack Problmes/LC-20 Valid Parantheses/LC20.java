import java.util.Stack;

class LC20 {
    public static boolean isValid(String s) {
        char[] stringArray = s.toCharArray();
        Stack<Character> stack = new Stack<>();
        stack.push('X');
        for (char c: stringArray) {
            if (c == '(' || c == '{' || c == '[') {
                stack.push(c);
            }
            else {
                char top = stack.peek();
                switch(c) {
                    case ')':
                        if (top == '(')
                            stack.pop();
                        else
                            return false;
                        break;
                    case '}':
                        if (top == '{')
                            stack.pop();
                        else
                            return false;
                        break;
                    case ']':
                        if (top == '[')
                            stack.pop();
                        else
                            return false;
                        break;
                    default:
                        return false;
                }

            }
        }

        return stack.peek() == 'X';
    }

    public static void main(String[] args) {
        String s = "()";
        System.out.println(isValid(s));
        s = "()[]{}";
        System.out.println(isValid(s));
        s = "([)]";
        System.out.println(isValid(s));
    }
}