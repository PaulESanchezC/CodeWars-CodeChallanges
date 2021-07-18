using System;
using System.Collections.Generic;
using System.Linq;


namespace WhereMyAnagramsAt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "vj", "jv", "jb" };


            List<string> result = Kata.Anagrams("jv", words);
            foreach (var value in result)
            {
                Console.WriteLine(value);
            } 
        }
    }

    public static class Kata
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> resultList = new List<string>() { };
            List<char> mainWordCharacters = new List<char>();
            List<char> listedWordCharacters = new List<char>();

            //Word into characters list
            foreach (var value in word)
            {
                mainWordCharacters.Add(value);
            }
            mainWordCharacters.Sort();  


            //Words: word. each into characters list to compare to Word characters list
            foreach (var wordValue in words)
            {
                foreach (var character in wordValue)
                {
                    listedWordCharacters.Add(character);
                }
                listedWordCharacters.Sort();

                //Comparison 
                if (mainWordCharacters.SequenceEqual(listedWordCharacters))
                {
                    resultList.Add(wordValue);
                }
                listedWordCharacters.Clear();
            }
            return resultList;
        }
}
}

