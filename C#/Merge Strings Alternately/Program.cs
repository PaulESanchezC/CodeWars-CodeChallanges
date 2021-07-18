using System;
using System.Linq;
using System.Text;

namespace Merge_Strings_Alternately
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.MergeAlternately("abcd", "pq"));
        }
    }

    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var result = new StringBuilder();


            if (word1.Length == word2.Length)
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    result.Append(word1[i]); result.Append(word2[i]);
                }
                return result.ToString();
            }


            if (word1.Length > word2.Length)
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    result.Append(word1[i]); result.Append(word2[i]);
                }

                for (int i = word2.Length; i < word1.Length; i++)
                {
                    result.Append(word1[i]);
                }
                return result.ToString();
            }


            else
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    result.Append(word1[i]); result.Append(word2[i]);
                }
                
                for (int i = word1.Length; i < word2.Length; i++)
                {
                    result.Append(word2[i]);
                }

                return result.ToString();
            }
        }
    }
}

