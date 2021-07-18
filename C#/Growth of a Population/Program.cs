using System;

namespace Growth_of_a_Population
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Arge.NbYear(1000, 2, 50, 1200));
        }
    }
    class Arge
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int counter = 0;
            while (p0 < p)
            {
                p0 = p0 + ((int) (p0 * percent / 100)) + aug;
                counter++;
                Console.WriteLine(p0);
            }
            return counter;
        }
    }
}
