namespace DSA.Queues
{
    class CustomQueueArray
    {
        int front, rear, size = 0;
        int[] array = new int[10];

        //enqueue
        public void Enqueue(int item)
        {
            if (IsFull())
                throw new StackOverflowException();

            array[rear] = item;
            //rear = rear == array.Length - 1 ? 0 : rear + 1;
            rear = (rear + 1) % array.Length;
            size++;
        }

        //dequeue
        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            var item = array[front];
            // front = front == array.Length - 1 ? 0 : front + 1;
            front = (front + 1) % array.Length;
            size--;
            return item;
        }

        //peek
        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            return array[front];
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
            Array.Copy(array, front, newArray, 0, size);
            return string.Join(',', newArray);
        }
    }
}