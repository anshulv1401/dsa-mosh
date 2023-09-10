using System.Drawing;
using System.Text;

namespace DSA.Part1.Queues
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

            int value = first.Value;
            first = first.Next;

            if (first == null)
                last = null;
            Size--;
            return value;
        }

        //peek
        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            return first.Value;
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