namespace StringUtils
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "qwerty";
            Console.WriteLine(StringUtils.ReverseString(word));
            string whitespaces = "Removing White Spaces \n and stuff";
            Console.WriteLine(StringUtils.RemoveWhitespaces(whitespaces));
            Console.WriteLine(StringUtils.CountOccurences("abfdssasabsebsefab", "ab"));
        }
    }
}
