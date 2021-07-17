using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rot13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdefghijklmnopqrstuvwxyz";
            Kata kata = new Kata();
            Console.WriteLine(kata.Rot13(s));


        }

        public class Kata
        {
            public string Rot13(string message)
            {
                int asciiCode = 0;
                char[] wordChars = message.ToCharArray();
                string wordCyphered = "";

                for (int i = 0; i < wordChars.Length; i++)
                {
                    if (Char.IsLetter(wordChars[i]))
                    {
                        if ((wordChars[i] >= 77 && wordChars[i] < 90) || wordChars[i] > 109)
                        {
                            asciiCode = Convert.ToInt32(wordChars[i]) - 13;
                            wordChars[i] = Convert.ToChar(asciiCode);
                        }
                        else
                        {
                            asciiCode = Convert.ToInt32(wordChars[i]) + 13;
                            wordChars[i] = Convert.ToChar(asciiCode);
                        }
                    }
                }
                wordCyphered = new string(wordChars);
                return wordCyphered;
            }
        }
    }
}

