using System;
using System.Text;

namespace Defanging_an_IP_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.DefangIPaddr("1.1.1.1"));
        }
    }
    public class Solution
    {
        public string DefangIPaddr(string address)
        {
            StringBuilder replacer = new StringBuilder(address);
            replacer.Replace(".", "[.]");

            return replacer.ToString();
        }
    }
}
