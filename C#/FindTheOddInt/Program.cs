using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;

namespace FindTheOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sq = new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5,-1,-1 };
            Kata kata = new Kata();
            Console.WriteLine(kata.find_it(sq));
        }
    }

    class Kata
    {
        public int find_it(int[] seq)
        {
            Dictionary<string, int> oddNumber = new Dictionary<string, int>();
            int theNumber=0;
            foreach (var x in seq)
            {
                if (oddNumber.ContainsKey(x.ToString()))
                {
                    oddNumber[x.ToString()]++;
                }
                else
                {
                    oddNumber.Add(x.ToString(), 1);
                }
            }

            foreach (var x in oddNumber)
            {
                if (x.Value %2 != 0)
                {
                    theNumber = Int32.Parse(x.Key);
                }   
            }

            return theNumber;
        }
    }

}