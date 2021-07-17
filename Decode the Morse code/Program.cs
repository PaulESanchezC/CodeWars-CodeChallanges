using System;
using System.Collections.Generic;
using System.Text;

namespace Decode_the_Morse_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MorseCodeDecoder.Decode("     E E"));
        }
    }
    class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            bool spacer = false;
            List<string> codedList = new List<string>();
            StringBuilder resultString = new StringBuilder();

            codedList.AddRange(morseCode.Trim().Split());
            

            foreach (var value in codedList)
            {
                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    if (!spacer) spacer = true;
                    else
                    {
                        resultString.Append(' ');
                        spacer = false;
                    }
                }
                else
                {
                    resultString.Append(value.Trim());
                    spacer = false;
                }
            }

            return resultString.ToString();
        }   
    }
}
