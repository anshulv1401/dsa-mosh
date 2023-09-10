namespace DSA.Part1.Queues
{
    class CustomQueueWith2Stack
    {
        Stack<int> pushStack = new();
        Stack<int> popStack = new();

        //enqueue
        public void Enqueue(int item)
        {
            pushStack.Push(item);
        }

        //dequeue
        public int Dequeue()
        {
            ReverseStack();
            if (popStack.Count == 0)
                throw new InvalidOperationException();

            return popStack.Pop();
        }

        //peek
        public int Peek()
        {
            ReverseStack();
            if (popStack.Count == 0)
                throw new InvalidOperationException();

            return popStack.Peek();
        }

        //isEmpty
        public bool IsEmpty()
        {
            return popStack.Count + pushStack.Count == 0;
        }

        public override string ToString()
        {
            ReverseStack();
            return string.Join(',', popStack) + ":" + string.Join(',', pushStack);
        }

        private void ReverseStack()
        {
            if (popStack.Count == 0)
                while (pushStack.Count > 0)
                    popStack.Push(pushStack.Pop());
        }
    }
}