using System.Runtime.InteropServices.ComTypes;

namespace Priority_Queueu_with_Dynamic_Arrays
{
    public class PriorityQueue
    {
        //Variables
        private int[] queueArray;
        private int[] newQueueArray;
        private int front;
        private int rear;
        private int tmp;
        public int Length { get; set; }

        //Constructor
        public PriorityQueue()
        {
            queueArray = new int[3];
            newQueueArray = null;
            front = 0;
            rear = 0;
            Length = 0;
        }

        //Implementation Methods
        public void Enqueue(int value)
        {
            if (IsEmpty())
            {
                queueArray[rear++] = value;
                Length++;
                return;
            }

            if (IsFull())
                queueArray = ResizeQueueArray(queueArray);

            for (int i = rear - 1; i >= front ; i--)
            {
                if (value >= queueArray[i])
                {
                    queueArray[i+1] = value;
                    rear++;
                    Length++;
                    return;
                }
                queueArray[i+1] = queueArray[i];
                queueArray[i] = value;
            }
            rear++;
            Length++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                return 0;
            Length--;
            return queueArray[front++];
        }

        public bool IsEmpty()
        {
            return front == rear;
        }

        //Private Methods
        private bool IsFull()
        {
            return rear == queueArray.Length;
        }

        private int[] ResizeQueueArray(int[] queue)
        {
            newQueueArray = new int[queueArray.Length + 2];
            for (int i = 0; i < rear; i++)
                newQueueArray[i] = queueArray[i];
            return newQueueArray;
        }
    }
}