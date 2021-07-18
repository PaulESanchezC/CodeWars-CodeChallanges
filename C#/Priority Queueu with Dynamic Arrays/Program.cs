using System;

namespace Priority_Queueu_with_Dynamic_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue queue = new PriorityQueue();
            queue.Enqueue(8);
            queue.Enqueue(4);
            queue.Enqueue(6);
            queue.Enqueue(1);
            queue.Enqueue(10);

            Console.WriteLine(queue.Length);
        }
    }
}
