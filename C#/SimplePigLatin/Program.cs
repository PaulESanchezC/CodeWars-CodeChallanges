using System;
using System.Collections.Generic;
using System.Linq;

namespace SimplePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            Console.WriteLine(kata.PigIt("hello ! world!"));
        }
    }
    public class Kata
    {
        public string PigIt(string str)
        {
            List<string> pigLatinStringList = new List<string>();
            string pigLatinWord = null;
            List<string> words = new List<string>();

            words.AddRange(str.Split());
            foreach (var word in words)
            {
                if (char.IsPunctuation(word[word.Length - 1]) && word.Length > 2)
                {
                    pigLatinStringList.Add(word.Substring(1, word.Length - 2) + word[0] + "ay" + word[word.Length - 1]);
                    continue;
                }
                if (char.IsPunctuation(word[word.Length - 1]) && word.Length < 2)
                {
                    pigLatinStringList.Add( word);
                    continue;
                }
                pigLatinStringList.Add(word.Substring(1) + word[0] + "ay");
            }

            foreach (var word in pigLatinStringList)
            {
                pigLatinWord += word + ' ';
            }

            return pigLatinWord.Trim();
        }
    }
}
