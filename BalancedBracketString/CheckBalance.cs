using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks
{
    public class CheckBalance
    {
        private Stack<char> brackets;
        private readonly char[] openingBrackets;
        private  readonly char[] closingBrackets;

        public CheckBalance(string test)
        {
            brackets = new Stack<char>();
            openingBrackets = new char[] {'(','{','[','<'};
            closingBrackets = new char[] { ')', '}', ']', '>' };

            foreach (var c in test)
                IsBracket(c);

            if (brackets.Count > 0)
            {
                Console.WriteLine("Not Balanced");
                Environment.Exit(0);
            }

            Console.WriteLine("BALANCED");
        }

        public void IsBracket(char c)
        {
            if (openingBrackets.Contains(c))
                brackets.Push(c);

            if (closingBrackets.Contains(c))
                IsBalance(c);
        }

        //Main Methods
        public void IsBalance(char c)
        {
            if (brackets.Count == 0)
            {
                Console.WriteLine("Not Balanced");
                Environment.Exit(0);
            }

            var x = brackets.Pop();
            if (x != c)
            {
                Console.WriteLine("Not Balanced");
                Environment.Exit(0);
            }
        }
    }
}