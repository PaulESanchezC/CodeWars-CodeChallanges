using System;
using System.Collections.Generic;
using System.Linq;

namespace Delete_Columns_to_Make_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "zyx", "wvu", "tsr" };
            Solution sol = new Solution();
            Console.WriteLine(sol.MinDeletionSize(strs));
        }
    }

    public class Solution
    {
        public int MinDeletionSize(string[] strs)
        {
            List<char> letters = new List<char>();
            int counter = 0;

            for (int i = 0; i < strs[0].Length; i++)
            {
                foreach (var value in strs)
                {
                    letters.Add(value[i]);
                }

                for (int j = 1; j < letters.Count; j++)
                {
                    if (letters[j - 1] > letters[j])
                    {
                        counter++;
                        break;
                    }
                }
                letters.Clear();
            }

            return counter;
        }
    }
}
