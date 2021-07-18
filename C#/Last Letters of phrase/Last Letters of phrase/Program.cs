using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Last_Letters_of_phrase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringTransformation.GetLastLetters("  a  b   c  "));
        }
    }
    public static class StringTransformation
    {
        public static string GetLastLetters(string input)
        {
            Regex rgx = new Regex("[_,]");
            var response = new StringBuilder();
            var word = rgx.Replace(input, "").Split().ToList();


            foreach (var w in word.Where(w =>
                w != "")
                .Where(w =>
                char.IsLetter(w.Last()) &&
                !char.IsWhiteSpace(w.Last())))
            {
                response.Append(w.Last());
            }



            return response.ToString();
        }
    }
}

