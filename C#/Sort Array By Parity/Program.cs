using System;
using System.Collections.Generic;

namespace Sort_Array_By_Parity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {2, 4, 3, 1};
            Solution solution = new Solution();
            foreach (var values in solution.SortArrayByParity(nums))
            {
                Console.WriteLine(values);
            }
        }
    }
    public class Solution
    {
        public int[] SortArrayByParity(int[] nums)
        {
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            int[] resultArray;

            foreach (var value in nums)
            {
                if (value % 2 == 0) evens.Add(value);
                else odds.Add(value);
            }
            evens.AddRange(odds);
            resultArray = evens.ToArray();

            return resultArray;
        }
    }
}
