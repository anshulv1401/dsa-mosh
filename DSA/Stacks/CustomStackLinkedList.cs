using System.Text;

namespace DSA.Stacks
{
    public class CustomStackLinkedList
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

        private Node? first;

        //Push
        public void Push(int item)
        {
            var newNode = new Node(item, null);
            if (first == null)
                first = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }

        //Pop
        public int Pop()
        {
            if (first == null)
                throw new IndexOutOfRangeException();

            var lastItem = first;
            first = first.Next;
            return lastItem.Value;
        }

        //Peek

        public int Peek()
        {
            if (first == null)
                throw new IndexOutOfRangeException();

            return first.Value;
        }

        //IsEmpty

        public bool IsEmpty()
        {
            return first == null;
        }

        public override string ToString()
        {
            //TODO interation
            StringBuilder sb = new StringBuilder();
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
