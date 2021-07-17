using System;

namespace MultiplesOf3Or5
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 20;
            int sum = 0;

            for (int i = 1; i < value; i++)
            {
                if (i%3 == 0)
                {
                    sum += i;
                    continue;
                }
                if (i % 5 == 0)
                {
                    sum += i;
                    continue;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
