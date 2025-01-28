class LC796
{
    public static bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length)
        {
            return false;
        }
        string doubled = s + s;
        
        return doubled.Contains(goal);
    }

    public static void Main(string[] args)
    {
        string s = "abcde";
        string goal = "cdeab";
        Console.WriteLine(RotateString(s, goal)); // Output: True
    }
}
