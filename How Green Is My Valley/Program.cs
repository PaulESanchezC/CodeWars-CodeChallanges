using System;

namespace How_Green_Is_My_Valley
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 17, 15, 8, 7, 4, 1, 4, 5, 7, 14, 17 };
            foreach (var value in Valley.MakeValley(a))
                Console.WriteLine(value);
        }
    }
    public class Valley
    {

        public static int[] MakeValley(int[] arr)
        {
            ValleyBalance valley = new ValleyBalance();
            return valley.Balance(arr);
        }
    }
}
