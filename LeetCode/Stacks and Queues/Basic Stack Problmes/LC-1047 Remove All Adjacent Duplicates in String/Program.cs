class LC1047
{
    public static string RemoveDuplicates(string s)
    {
        // Stack<char> stack = new Stack<char>();
        // for (int i = 0; i < s.Length; i++)
        // {
        //     if (stack.Count > 0 && stack.Peek() == s[i])
        //     {
        //         stack.Pop();
        //         continue;
        //     }
        //     stack.Push(s[i]);
        // }
        // StringBuilder sb = new StringBuilder();
        // while (stack.Count > 0)
        // {
        //     sb.Append(stack.Pop());
        // }
        // return new string(sb.ToString().Reverse().ToArray());

        int length = s.Length;
        char[] stack = new char[length];
        int top = -1;

        for (int i = 0; i < length; i++)
        {
            char c = s[i];
            if (top >= 0 && stack[top] == c)
            {
                top--;            // pop
            }
            else
            {
                stack[++top] = c;  // push
            }
        }
        return new string(stack, 0, top + 1);
    }

    public static void Main(string[] args)
    {
        string s = "abbaca";
        Console.WriteLine(RemoveDuplicates(s));  // Output: "ca"
    }
}
