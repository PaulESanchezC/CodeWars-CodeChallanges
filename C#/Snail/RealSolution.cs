using System.Collections.Generic;


namespace Snail
{
    public class RealSolution
    {
        //Variables
        private readonly int range;
        private int length;
        private List<int> snail;
        private List<int> nwArr;
        private int[][] newArray;

        //Constructor
        public RealSolution(int[][] array)
        {
            snail = new List<int>();
            range = array.Length * array.Length;
        }
        
        //Public Methods
        public int[] GetSnailSolution(int[][] array)
        {
            length = array[0].Length;
            if (IsEmpty())
                return snail.ToArray();

            //Going Right / Top Row
            for (int i = 0; i < length; i++)
                snail.Add(array[0][i]);

            //Going Down / Right Column
            for (int i = 1; i < length; i++)
                snail.Add(array[i][length - 1]);

            //Going Left / Bottom Row
            for (int i = length - 2; i >= 0; i--)
                snail.Add(array[length - 1][i]);

            //Going Up / Left Column
            for (int i = length - 2; i >= 1; i--)
                snail.Add(array[i][0]);

            if (snail.Count != range)
                ResizeArray(array);
            return snail.ToArray();
        }
        
        //Private Methods
        private void ResizeArray(int[][] array)
        {
            newArray = new int[length][];
            for (int i = 0; i < length - 2; i++)
            {
                nwArr = new List<int>();
                for (int j = 0; j < length - 2; j++)
                {
                    nwArr.Add(array[i + 1][j + 1]);
                }

                newArray[i] = nwArr.ToArray();
            }

            GetSnailSolution(newArray);
        }
        private bool IsEmpty()
        {
            return length == 0;
        }
    }
}