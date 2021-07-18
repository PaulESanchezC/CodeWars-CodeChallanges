using System;
using System.Diagnostics.Tracing;
using System.Globalization;

namespace Moving_Zeros_To_The_End
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            foreach (var values in Kata.MoveZeroes(arr))
            {
                Console.WriteLine(values);
            }
        }
    }
    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            int a = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                a = arr[i];
                if (a == 0)
                {
                    int counter = i;
                    while (a == 0 && counter < arr.Length)
                        a = arr[counter++];
                    arr[i] = a;
                    for (int j = i + 1; j < counter; j++)
                        arr[j] = 0;
                }
            }

            return arr;
        }
    }
}
