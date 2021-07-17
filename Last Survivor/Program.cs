﻿using System;
using System.Linq;
using System.Text;

namespace Last_Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coords = new int[] { 8, 59, 52, 93, 21, 40, 88, 85, 59, 10, 82, 18, 74, 59, 51, 47, 75, 49, 23, 56, 1, 33, 39, 33, 34, 44, 25, 0, 51, 25, 36, 32, 57, 10, 57, 12, 51, 55, 24, 55, 31, 49, 6, 15, 10, 48, 27, 29, 38, 30, 35, 42, 23, 32, 9, 39, 39, 36, 8, 29, 2, 33, 14, 3, 13, 25, 9, 25, 18, 10, 1, 2, 20, 8, 2, 11, 5, 7, 0, 10, 10, 8, 12, 3, 5, 1, 7, 7, 5, 1, 4, 0, 4, 0, 0, 1 };
            string str = "foiflxtpicahhkqjswjuyhmypkrdbwnmwbrrvdycqespfvdviucjoyvskltqaqirtjqulprjjoaiagobpftywabqjdmiofpsr";
            Console.WriteLine(Kata.last_survivor(str , coords));
        }
    }

    public class Kata
    {
        public static string last_survivor(string letters, int[] coords)
        {
            //StringBuilder letterless = new StringBuilder().Append(letters);
            //foreach (var value in coords)
            //{
            //   letterless = letterless.Remove(value,1);
            //}

            foreach (var index in coords)
            {
                letters = letters.Remove(index, 1);
            }
            return letters;
        }
    }
}
