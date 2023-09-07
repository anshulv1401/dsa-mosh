namespace DSA.Queues
{
    class QueuesPratice
    {

        public string ReverseQueue(Queue<int> queue)
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
    }
}