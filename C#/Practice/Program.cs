using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[][]
            {
                new[] {1, 2, 3},
                new[] {4, 5, 6},
                new[] {7, 8, 9},
                new[] {7, 8, 9}
            };
            array[0] = new int[0];

        }
    }
}
