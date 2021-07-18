using System;
using System.Collections.Generic;

namespace How_Green_Is_My_Valley
{
    public class ValleyBalance
    {
        //Variables
        private List<int> rightW;
        private List<int> leftW;
        private int length;

        public ValleyBalance()
        {
            length = 0;
            leftW = new List<int>();
            rightW = new List<int>();
        }

        public int[] Balance(int[] array)
        {
            length = array.Length;
            if (IsEmpty())
                return array;
            
            Array.Sort(array);
            Array.Reverse(array);
            for (int i = 0; i < length ; i++)
            {
                if (i % 2 == 0)
                    leftW.Add(array[i]);
                else rightW.Add(array[i]);
            }

            rightW.Reverse();
            leftW.AddRange(rightW);
            return leftW.ToArray();
        }
       
        private bool IsEmpty()
        {
            return length == 0;
        }
    }
}