using System;
using System.Text;

namespace Make_my_numbers_formatted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.f(123456789));
        }
    }
    public class Kata
    {
        public static string f(long n)
        {
            return n.ToString("N0");
        }
    }
}
