using System.Drawing;
using System.Text;

namespace DSA.Queues
{
    class CustomQueueLinkedList
    {
        private class Node
        {
            public Node(int value, Node? next)
            {
                Value = value;
                Next = next;
            }

            public int Value { get; }
            public Node? Next { get; set; }
        }

        Node? first, last;

        public int Size = 0;

        //enqueue
        public void Enqueue(int item)
        {
            var newNode = new Node(item, null);
            if (first == null)
            {
                first = last = newNode;
                Size++;
                return;
            }

            last.Next = newNode;
            last = newNode;
            Size++;
        }

        //dequeue
        public int Dequeue()
        {
            if (first == null)
                throw new InvalidOperationException();

            int value;
            if (first.Next == null)
            {
                value = first.Value;
                first = last = null;
                Size = 0;
                return value;
            }

            Node it = first;
            while (it.Next.Next != null)
                it = it.Next;

            value = it.Next.Value;
            it.Next = null;
            last = it;
            Size--;
            return value;
        }

        //peek
        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            return last.Value;
        }


        //isEmpty
        public bool IsEmpty()
        {
            return first == null;
        }

        public override string ToString()
        {
            //TODO interation
            var sb = new StringBuilder();
            Node? it = first;
            while (it != null)
            {
                sb.Append("-->" + it.Value);
                it = it.Next;
            }
            return sb.ToString();
        }
    }
}