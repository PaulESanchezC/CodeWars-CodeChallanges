using System;

namespace RunSum1dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 3, 4};
            Solution solution = new Solution();

            solution.RunningSum(nums);
            foreach (var value in solution.RunningSum(nums))
            {
                Console.Write(value + ", ");
            }
        }
    }
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            int[] runSum = new int[nums.Length];

            runSum[0] = nums[0];
            for (int i = 1; i < runSum.Length; i++)
            {
                runSum[i] = runSum[i - 1] + nums[i];
            }

            return runSum;
        }
    }
}
