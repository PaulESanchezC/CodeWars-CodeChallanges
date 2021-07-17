using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Isograms
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aba";
            Kata kata = new Kata();
            Console.WriteLine(kata.IsIsogram(str));
        }
    }
    public class Kata
    {
        public bool IsIsogram(string str)
        {
            char[] letters = str.ToLower().ToCharArray();
            if (letters.Length != letters.Distinct().Count())
            {
                return false;
            }

            return true;
        }
    }
}
