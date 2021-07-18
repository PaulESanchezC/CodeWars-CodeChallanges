using System;
using System.Threading;
using System.Threading.Channels;

namespace Binary_Search_Tree_from_scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree bst = new Tree();
            bst.Insert(7);
            bst.Insert(4);
            bst.Insert(9);
            bst.Insert(1);
            bst.Insert(6);
            bst.Insert(8);
            bst.Insert(10);
            Console.WriteLine(bst.ValidateBST());

            Tree test = new Tree();
            test.Insert(7);
            test.Insert(4);
            test.Insert(9);
            test.Insert(2);
            test.Insert(6);
            test.Insert(8);
            test.Insert(10);

            Console.WriteLine(bst.EqualsTo(test));
            
        }
    }
}
