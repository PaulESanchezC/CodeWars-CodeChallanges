using System;
using System.Collections.Generic;

namespace CodeChallangeIsogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "asdfghjkl";
            bool iso = false;
            List<char> letter = new List<char>();
            char testLetter;

            letter.AddRange(str);
            testLetter = str[0];
            for (int i = 1; i < letter.Count; i++)
            {
                if (testLetter == letter[i])
                {
                    
                }
            }
            {
                
            }
        }
    }
}
