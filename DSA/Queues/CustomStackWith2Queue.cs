namespace DSA.Queues
{
    class CustomStackWith2Queue
    {
        Queue<int> queue1 = new();
        Queue<int> queue2 = new();

        //enqueue
        public void Push(int item)
        {
            if (queue1.Count == 0)
            {
                queue1.Enqueue(item);
                while (queue2.Count > 0)
                    queue1.Enqueue(queue2.Dequeue());

            }
            else
            {
                queue2.Enqueue(item);
                while (queue1.Count > 0)
                    queue2.Enqueue(queue1.Dequeue());

            }
        }

        //dequeue
        public int Pop()
        {
            if (queue1.Count == 0 && queue2.Count == 0)
                throw new InvalidOperationException();

            if (queue1.Count == 0)
                return queue2.Dequeue();

            else
                return queue1.Dequeue();
        }

        //peek
        public int Peek()
        {
            if (queue1.Count == 0 && queue2.Count == 0)
                throw new InvalidOperationException();

            if (queue1.Count == 0)
                return queue2.Peek();

            else
                return queue1.Peek();
        }

        //isEmpty
        public bool IsEmpty()
        {
            return queue1.Count + queue2.Count == 0;
        }

        public int Size()
        {
            return queue1.Count + queue2.Count;
        }

        public override string ToString()
        {
            if (queue1.Count == 0)
            {
                return string.Join(',', queue2);
            }
            else
            {
                return string.Join(',', queue1);
            }
        }
    }
}