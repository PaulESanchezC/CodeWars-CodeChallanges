using System;

namespace Count_Negative_Numbers_in_a_Sorted_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] imput = new int[4][] ;
            imput[0] = new int[] {4, 3, 2, -1};
            imput[1] = new int[] {3, 2, 1, -1};
            imput[2] = new int[] {1, 1, -1, -2};
            imput[3] = new int[] { -1, -1, -2, -3 };

            Solution solution = new Solution();
            Console.WriteLine(solution.CountNegatives(imput));
        }
    }
    public class Solution
    {
        public int CountNegatives(int[][] grid)
        {
            int counter = 0;
            foreach (var imputArray in grid)
            {
                foreach (var value in imputArray)
                {
                    if (value<0)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
