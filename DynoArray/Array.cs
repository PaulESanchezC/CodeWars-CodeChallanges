using System;
using System.Linq;

namespace DynoArray
{
    public class Array
    {
        private int[] items;
        private int[] newItems;
        private int count;
        public Array(int length)
        {
            items = new int[length];
            items[0] = 10;
            count = 0;
        }
        public void Insert(int value)
        {
            if (count == items.Length)
            {
                newItems = new int[count + 1];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }

            items[count++] = value;            
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException("RemoveAt(index). index is out of range");
            }
            
            for (int i = index; i < count-1; i++)
            {
                items[i] = items[i + 1];
            }

            items[count - 1] = 0;
            count--;
        }

        public int IndexOf(int value)
        {
            if (items.Contains(value))
            {
                return System.Array.IndexOf(items, value);
            }

            return -1;
        }

        public string Print()
        {
            return String.Join(',', items);
        }
    }
}