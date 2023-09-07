using System.Text;

namespace DSA.LinkedList
{
    class CustomLinkedList<T> where T : struct
    {
        private class Node<T> where T : struct
        {
            public Node(T value, Node<T>? next)
            {
                Value = value;
                Next = next;
            }

            public T Value { get; }
            public Node<T>? Next { get; set; }
        }

        private Node<T>? first;
        private Node<T>? last;
        private int size;
        //AddFirst

        public void AddFirst(T value)
        {
            var newNode = new Node<T>(value, null);
            if (first == null)
                first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
            size++;
        }


        //AddLast

        public void AddLast(T value)
        {
            var newNode = new Node<T>(value, null);
            if (first == null)
                first = last = newNode;
            else
            {
                last.Next = newNode;
                last = newNode;
            }
            size++;
        }

        //DeleteFirst

        public T DeleteFirst()
        {
            if (first == null)
            {
                throw new Exception("Linked list is empty");
            }

            if (first == last)
            {
                var temp1 = first;
                first = last = null;
                size--;
                return temp1.Value;
            }

            var temp = first;
            first = first.Next;
            temp.Next = null;
            size--;
            return temp.Value;
        }


        //DeleteLast
        public T DeleteLast()
        {
            if (first == null)
            {
                throw new Exception("Linked list is empty");
            }

            if (first == last)
            {
                var temp = first;
                first = last = null;
                size--;
                return temp.Value;
            }

            var secondLastNode = GetPrevious(last);
            var lastNode = secondLastNode.Next;
            secondLastNode.Next = null;
            last = secondLastNode;
            size--;
            return lastNode.Value;
        }

        //Contains

        public bool Constains(T value)
        {
            return IndexOf(value) != 1;
        }

        //IndexOf

        public int IndexOf(T value)
        {
            int index = 0;
            var it = first;
            while (it != null)
            {
                if (it.Value.Equals(value)) return index;
                it = it.Next;
                index++;
            }
            return -1;
        }


        public override string ToString()
        {
            //TODO interation
            StringBuilder sb = new StringBuilder();
            Node<T>? it = first;
            while (it != null)
            {
                sb.Append("-->" + it.Value);
                it = it.Next;
            }
            return sb.ToString();
        }

        private Node<T>? GetPrevious(Node<T>? node)
        {
            var it = first;
            while (it != null)
            {
                if (it.Next == node) return it;
                it = it.Next;
            }
            return null;
        }
        public int Lenght()
        {
            return size;
        }
    }
}