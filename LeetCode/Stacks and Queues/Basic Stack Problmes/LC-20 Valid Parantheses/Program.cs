class LC20
{
    public static bool IsValid(string s)
    {
        char[] stringArray = s.ToCharArray();
        Stack<char> stack = new Stack<char>();
        stack.Push('X');

        foreach (char c in stringArray)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                char top = stack.Peek();
                switch (c)
                {
                    case ')':
                        if (top == '(')
                            stack.Pop();
                        else
                            return false;
                        break;
                    case '}':
                        if (top == '{')
                            stack.Pop();
                        else
                            return false;
                        break;
                    case ']':
                        if (top == '[')
                            stack.Pop();
                        else
                            return false;
                        break;
                    default:
                        return false;
                }
            }
        }

        return stack.Peek() == 'X';
    }

    public static void Main()
    {
        string s = "()";
        Console.WriteLine(IsValid(s));  // Output: True
        s = "()[]{}";
        Console.WriteLine(IsValid(s));  // Output: True
        s = "([)]";
        Console.WriteLine(IsValid(s));  // Output: False
    }
}