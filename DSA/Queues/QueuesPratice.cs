namespace DSA.Queues
{
    class QueuesPratice
    {

        public static string ReverseQueue(Queue<int> queue)
        {
            //using only
            //add
            //remove
            //isEmpty
            Stack<int> stack = new();
            while (queue.Count > 0)
                stack.Push(queue.Dequeue());

            while (stack.Count > 0)
                queue.Enqueue(stack.Pop());

            return string.Join(',', queue);
        }

        // Given an integer K and a queue of integers, write code to reverse the order of the first K elements of the queue.
        // Using 1 stack and without using adding queue
        public static void QueueReverser(Queue<int> queue, int k)
        {
            Stack<int> tempStack = new();
            for (int i = 0; i < k; i++)
                tempStack.Push(queue.Dequeue());

            while (tempStack.Count > 0)
                queue.Enqueue(tempStack.Pop());

            for (int i = 0; i < queue.Count - k; i++)
                queue.Enqueue(queue.Dequeue());
        }

        public static void ReverseQueueWithRecursion(Queue<int> queue)
        {
            if (queue.Count == 0)
                return;

            int first = queue.Dequeue();
            ReverseQueue(queue);
            queue.Enqueue(first);
        }

        public static string GetQueueString(Queue<int> queue)
        {
            return string.Join(",", queue);
        }
    }
}