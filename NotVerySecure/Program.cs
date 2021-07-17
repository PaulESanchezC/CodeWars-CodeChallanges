using System;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace NotVerySecure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Alphanumeric("AoBVxa1c8Y8kNTjCJv!3!HdCMcqCKN"));
        }
    }
    public class Kata
    {
        public static bool Alphanumeric(string str)
        {
            Console.WriteLine(str);
            if (String.IsNullOrEmpty(str) || (str.Length < 1)) return false;
            if (Regex.IsMatch(str, "[^\\S]")) return false;
            if (Regex.IsMatch(str, "_")) return false;


            foreach (var c in str)
            {
                if (char.IsLetterOrDigit(c)) continue;
                else return false;
            }

            return true;
        }
    }
}
