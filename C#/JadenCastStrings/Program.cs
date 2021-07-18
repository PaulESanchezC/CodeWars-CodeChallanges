using System;
using System.Collections.Generic;

namespace JadenCastStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string jadenCased = "";
            string phrase = "How can mirrors be real if our eyes aren't real";
            words.AddRange(phrase.Split(' '));
            
            foreach (var w in words)
            {
                jadenCased += char.ToUpper(w[0]) + w.ToLower().Substring(1) + ' ';
            }

            Console.WriteLine(jadenCased.Trim());
        }
    }
}
