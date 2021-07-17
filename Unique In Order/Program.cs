using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique_In_Order
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var value in Kata.UniqueInOrder("AAAABBBCCDAABBB"))
            {
                Console.WriteLine(value);
            }
        }
    }

    public static class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            T previous = default(T);

            foreach (T current in iterable)
            {
                if (!current.Equals(previous))
                {
                    previous = current;
                    yield return current;
                }
            }
            
        }
    }
}
