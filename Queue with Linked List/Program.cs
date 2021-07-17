using System;

namespace Queue_with_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Queues queue = new Queues();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Length);
            
        }
    }
}
