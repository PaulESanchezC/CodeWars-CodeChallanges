using System;

namespace IsANumberPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            Console.WriteLine(kata.IsPrime(-2));
        }
    }
    public class Kata
    {
        public bool IsPrime(int n)
        {
            bool primerOrNot = true;
            //if (n == 2)
            //    return true;

            if (n <= 1)
                return false;

            var divider = Math.Sqrt(n);
            for (int i = 2; i < divider+1; i++)
            {
                if (n % i == 0)
                {
                    primerOrNot = false;
                }
            }

            return primerOrNot;
        }
    }
}
