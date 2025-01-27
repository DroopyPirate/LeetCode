using System.Text;

public class LC151
{
    public static string ReverseWords(string s)
    {
        // Split the string by one or more whitespace characters
        string[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder reverse = new StringBuilder();

        for (int i = words.Length - 1; i >= 0; i--)
        {
            reverse.Append(words[i] + " ");
        }

        return reverse.ToString().Trim();
    }

    public static void Main(string[] args)
    {
        string s = "  hello world!  ";
        Console.WriteLine(ReverseWords(s));
    }
}