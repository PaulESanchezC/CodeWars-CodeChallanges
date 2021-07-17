using System.Xml;

namespace Stacks_with_LinkedList
{
    class Stack
    {

        //Objects
        private Node first;            
        private Node last;    
        private Node node;   

        //Variables
        public int Length { get; set; }
        private int tmp;  

        //Nodes
        private class Node
        {
            public int Value;
            public Node Next;
            
            public Node(int value)
            {
                this.Value = value;
            }
        }

        //Constructor
        public Stack()
        {
            first = null;
            last = null;
            Length = 0;
            tmp = 0;
        }


        //Stack Methods 
        public void Push(int value)
        {
            node = new Node(value);
            if (IsEmpty())
                first = last = node;
            else
            {
                node.Next = first;
                first = node;
            }

            Length++;
        }
        public int Pop()
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
        public int Peek()
        {
            return first.Value;
        }
        public int Count()
        {
            return Length;
        }
        public bool IsEmpty()
        {
            return Length == 0;
        }
    }
}