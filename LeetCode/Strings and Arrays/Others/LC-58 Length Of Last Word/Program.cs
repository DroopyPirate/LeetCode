class LC58 {
    public static int LengthOfLastWord(string s) {
        s = s.Trim();
        int lastIndex = s.LastIndexOf(" ");
        return s.Substring(lastIndex + 1).Length;
    }

    public static void Main(string[] args) {
        string s = "Hello World";
        Console.WriteLine(LengthOfLastWord(s));
    }
}
