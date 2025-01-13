using System.Text.RegularExpressions;

namespace RegexApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string pattern = @"(\d+)";
        Regex regex = new Regex(pattern);

        string text = "Hi there, ny number is 12314";
        
        MatchCollection matches = regex.Matches(text);
        
        Console.WriteLine($"Matches count: {matches.Count}");

        foreach (Match match in matches)
        {
            GroupCollection groups = match.Groups;
            Console.WriteLine(groups[0].Value);
        }
    }
}