using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace Range_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 0,1,2,3,4,5,11,6,7,8,9};
            Console.WriteLine(RangeExtraction.Extract(numbers));
        }
    }

    public class RangeExtraction
    {
        public static string Extract(int[] args)
        {
            List<string> range = new List<string>();
            var maxIndex = 0;

            for (int i = 0; i < args.Length-2; i++)
            {
                Console.WriteLine("i: " + i);
                if ((args[i + 1] == args[i] + 1) && (args[i + 2] == args[i] + 2))
                {
                    maxIndex = 2;
                    while (args[maxIndex + 1] == args[maxIndex] + 1)
                    {
                        if (maxIndex + i >= args.Length)
                            maxIndex--;
                            break;
                        maxIndex++;
                    }

                    range.Add(args[i] + "-" + args[i + maxIndex]);
                    i += maxIndex;
                } else range.Add(Convert.ToString(args[i]));

            }

            var theExtraction = "";
            foreach (var value in range)
            {
                theExtraction += " ," + value;
            }

            return theExtraction;
        }
    }
}
