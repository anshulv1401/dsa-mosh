namespace DSA.Queues
{
    class CustomPriorityQueues
    {
        int size = 0;
        int[] array = new int[10];

        //enqueue
        public void Enqueue(int item)
        {
            if (IsFull())
                throw new StackOverflowException();

            int index = ShiftItemsToInsert(item);
            array[index] = item;
            size++;
        }

        public int ShiftItemsToInsert(int item)
        {
            int shiftingIt = size - 1;
            while (shiftingIt >= 0)
            {
                if (array[shiftingIt] < item)
                    array[shiftingIt + 1] = array[shiftingIt];
                else
                    break;
                shiftingIt--;
            }

            return shiftingIt + 1;
        }

        //dequeue
        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            return array[--size];
        }

        //peek
        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            return array[size - 1];
        }

        //isEmpty
        public bool IsEmpty()
        {
            return size == 0;
        }

        //isFull
        public bool IsFull()
        {
            return size == array.Length;
        }

        public override string ToString()
        {
            var newArray = new int[size];
            Array.Copy(array, 0, newArray, 0, size);
            return string.Join(',', newArray);
        }
    }
}