using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "( 1 +2<)(>)";

            CheckBalance checkBalance = new CheckBalance(test);
        }
    }
}