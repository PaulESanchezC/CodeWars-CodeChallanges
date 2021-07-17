using System;
using System.Text;

namespace Smallest_Permutation
{
    public class Kata
    {
        private StringBuilder _minP;
        private char[] _numbers;
        public int MinPermutation(int n)
        {
            _minP = new StringBuilder();
            _numbers = n.ToString().ToCharArray();

            Array.Sort(_numbers);

            if (_numbers[0] == '-')
                return LeadingNegative(_numbers, true);

            if (_numbers[0] == '0')
                return LeadingZero(_numbers, false);

            //!n.contains(0)
            return Resolver(_numbers, false);
        }

        private int LeadingNegative(char[] numbers, bool negative)
        {
            char[] newNumbers = new char[numbers.Length - 1];

            for (int i = 0; i < numbers.Length - 1; i++)
                newNumbers[i] = numbers[i + 1];
            numbers = newNumbers;

            return numbers[0] == '0' ? LeadingZero(numbers, negative) : Resolver(numbers, true);
        }

        private int LeadingZero(char[] numbers, bool negative)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != '0')
                {
                    numbers[0] = numbers[i];
                    numbers[i] = '0';
                    break;
                }
            }
            return Resolver(numbers, negative);
        }

        private int Resolver(char[] numbers, bool negative)
        {
            if (negative)
                _minP.Insert(0, '-');
            _minP.Append(numbers);
            return Convert.ToInt32(_minP.ToString());
        }
    }
}