﻿//https://www.codewars.com/kata/545cedaa9943f7fe7b000048/train/csharp

//A pangram is a sentence that contains every single letter of the alphabet at least once. For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).
//Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.


using System;
using System.Linq;

namespace Detect_Pangram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.PanagramSumValue());
            Console.WriteLine(Kata.IsPangram("The quick brown fox jumps over the lazy dog."));
        }
    }
    public static class Kata
    {
        public static int PanagramSumValue()
        {
            var panagramSum = 0;
            for(int i = 97; i <= 122; i++)            
                panagramSum += i;
            
            return panagramSum;
        }

        public static bool IsPangram(string str)
        {
            var charactersList = str.ToLower().ToCharArray().Distinct().ToList();
            var sumOfCharacters = 0;

            charactersList.ForEach(character =>
            {
                if(Char.IsLetter(character))
                    sumOfCharacters += (int)character;
            });
            return (sumOfCharacters == PanagramSumValue());
        }
    }
}