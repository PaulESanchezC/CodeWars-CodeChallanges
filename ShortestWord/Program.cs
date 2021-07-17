using System;
using System.Collections.Generic;

namespace ShortestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            Console.WriteLine(kata.FindShort("estas son palabras para probar"));
            
        }
    }

    class Kata
    {
        public int FindShort(string s)
        {
            List<string> words = new List<string>();
            int lengthOfShortestWords;
            words.AddRange(s.Split(' '));
            lengthOfShortestWords = words[0].Length;
            foreach (var word in words)
            {
                if (word.Length < lengthOfShortestWords)
                {
                    lengthOfShortestWords = word.Length;
                }
            }
            return lengthOfShortestWords;
        }
    }
}
