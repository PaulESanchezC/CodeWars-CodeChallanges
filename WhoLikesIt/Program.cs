using System;
using System.Collections.Generic;

namespace WhoLikesIt
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] name = new string[]
            {
                "paul",
                "mimi",
                "carlos",
                "diego"
            };

            switch (name.Length)
            {
                case 0:
                    Console.WriteLine("empty");
                    break;
                case 1:
                    Console.WriteLine(name[0] + " Likes this");
                    break;
                case 2:
                    Console.WriteLine(name[0] + " and " + name[1] + "like this");
                    break;
                case 3:
                    Console.WriteLine(name[0] + ",  " + name[1] + " and "  + name[2] + " like this");
                    break;
                default:
                    Console.WriteLine(name[0] + "," + name[1] + " and " +  name.Length + " others like this" );
                    break;
            }

        }
    }
}
