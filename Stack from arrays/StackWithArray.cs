using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Stack_from_arrays
{
    class StackWithArray
    {
        public int[] Stack { get; set; }
        public int Length { get; set; }
        private int top;
        private int bottom;
        private int counter;

        public StackWithArray(int lenght)
        {
            Stack = new int[lenght];
            Length = lenght;
            top = 0;
            bottom = 0;
            counter = 0;
        }

        public void Push(int value)
        {
            if (IsEmpty())
            {
                Stack[top++] = value;
                return;
            }

            if (IsFull())
                throw new Exception("Stack is Full!");

            Stack[top++] = value;
        }

        public int Pop()
        {
            if (IsEmpty())
                return 0;
            return Stack[--top];
        }

        public int Peek(int value)
        {
            if (IsEmpty())
                return 0;
            return Stack[top];
        }

        public bool Contains(int value)
        {
            if (IsEmpty())
                return false;
            for (int i = bottom; i < top; i++)
                if (Stack[i] == value)
                    return true;
            return false;
        }

        public bool IsEmpty()
        {
            return bottom == top;
        }

        public bool IsFull()
        {
            return top == Stack.Length;
        }
        public void Clear()
        {
            Stack = new int[Length];
        }

    }
}