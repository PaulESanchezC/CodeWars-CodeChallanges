using System;
using System.Linq;

namespace Richest_Customer_Wealth

{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] imput = new int[3][];
            imput[0] = new int[] { 2, 8, 7 };
            imput[1] = new int[] { 7, 1, 3 };
            imput[2] = new int[] { 1, 9, 5 };

            Solution solution = new Solution();
            Console.WriteLine(solution.MaximumWealth(imput));
        }
    }
    public class Solution
    {
        public int MaximumWealth(int[][] accounts)
        {
            int theRichest = 0;
            foreach (var imputArray in accounts)
            {
                if (imputArray.Sum() > theRichest)
                    theRichest = imputArray.Sum();
            }
            return theRichest;
        }
    }
}
