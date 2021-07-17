using System;
using System.Security.Cryptography.X509Certificates;

namespace ExesAndOhs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool xo = true;
            int exes = 0, ohs =0;
            string input = "xoox";
            foreach (var c in input)
            {
                if (c=='x' || c=='X')
                {
                    exes += 1;
                }

                if (c == 'o' || c == 'O')
                {
                    ohs += 1;
                }
            }

            if (exes==ohs)
            {
                xo = true;
            }
           return xo;
        }
    }
}
