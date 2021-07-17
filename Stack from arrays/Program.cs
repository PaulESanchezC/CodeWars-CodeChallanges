using System;

namespace Stack_from_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            StackWithArray stack = new StackWithArray(4);
            stack.Push(4);
            stack.Push(1);
            stack.Push(7);
            stack.Push(10);

            Console.WriteLine(stack.Pop());

        }
    }
}
