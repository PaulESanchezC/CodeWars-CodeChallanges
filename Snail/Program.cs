using System;

namespace Snail
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[][] {};
            foreach (var value in SnailSolution.Snail(array))
            {
                Console.WriteLine(value);   
            }
        }
        public class SnailSolution
        {
            public static int[] Snail(int[][] array)
            {
                RealSolution solution = new RealSolution(array);
                return solution.GetSnailSolution(array);
            }
        }

        
    }
}

