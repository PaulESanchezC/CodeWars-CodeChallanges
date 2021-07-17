using System;
using System.Collections.Generic;

namespace Factorial_decomposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
        }
    }

    public class Kata
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            
            int lastStopPassangers = 0;
            
            for (int i = 0; i < peopleListInOut.Count; i++)
            {
                lastStopPassangers += peopleListInOut[i][0] - peopleListInOut[i][1];
            }
            
            return lastStopPassangers;
        }
    }
}
