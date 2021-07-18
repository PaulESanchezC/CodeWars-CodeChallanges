using System;

namespace Queue_with_Linked_List
{
    public class Queues
    {
        //Nodes
        private class Node
        {
            public Node(int value)
            {
                this.Value = value;
            }
            public int Value;
            public Node Next;
        }

        //Objects
        private Node first;
        private Node last;
        private Node node;

        //Variables
        public int Length { get; set; }
        private int tmp;

        //Constructor
        public Queues()
        {
            first = null;
            last = null;
            node = null;
            Length = 0;
        }

        public void Enqueue(int value)
        {
            node = new Node(value);
            if (IsEmpty())
                first = last = node;
            else
            {
                last.Next = node;
                last = node;
            }

            Length++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                return 0;

            tmp = first.Value;
            node = first.Next;
            first.Next = null;
            first = node;
            Length--;
            return tmp;
        }

        public bool IsEmpty()
        {
            return Length == 0;
        }
    }
}