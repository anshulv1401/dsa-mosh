namespace DSA.Queues
{
    class CustomStackWith1Queue
    {
        Queue<int> queue = new();

        //enqueue
        public void Push(int item)
        {
            queue.Enqueue(item);

            for (int i = 0; i < queue.Count - 1; i++)
                queue.Enqueue(queue.Dequeue());
        }

        //dequeue
        public int Pop()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException();

            return queue.Dequeue();
        }

        //peek
        public int Peek()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException();

            return queue.Peek();
        }

        //isEmpty
        public bool IsEmpty()
        {
            return queue.Count == 0;
        }

        public int Size()
        {
            return queue.Count;
        }

        public override string ToString()
        {
            return string.Join(',', queue);
        }
    }
}