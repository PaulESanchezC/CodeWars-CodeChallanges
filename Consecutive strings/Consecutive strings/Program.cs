using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace Consecutive_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "tree", "foling", "trashy", "blue", "abcdef", "uvwxyz" };

            var challange = new LongestConsecutives();
            Console.WriteLine(challange.LongestConsec(array, 2));
        }
    }
    public class LongestConsecutives
    {
        public String LongestConsec(string[] strarr, int k)
        {
            var l = strarr.Length;
            if (!IsValid(l, k))
            {
                return "";
            }

            l = GetLongestString(strarr, l, k);
            return ResponseBuilder(strarr, k,l);
        }

        private bool IsValid(int l, int k)
        {
            return l > 0 && k > 0 && l >= k;
        }

        private int GetLongestString(string[] strings,int l, int k)
        {
            var iterations = l - k + 1;
            int[] lengths = new int[iterations];
            var lengthIndex = 0;

            for (int i = 0; i < iterations; i++)
            {
                for (int j = i; j < i + k; j++)
                {
                    lengths[i] += strings[j].Length;
                }
            }

            lengthIndex = Array.IndexOf(lengths, lengths.Max());
            return lengthIndex;
        }

        private string ResponseBuilder(string[] strarr, int k, int index)
        {
            StringBuilder response = new StringBuilder();
            for (int i = index; i < index + k; i++)
            {
                response.Append(strarr[i]);
            }

            return response.ToString();
        }
    }
}