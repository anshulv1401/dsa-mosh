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

        public void Reverse()
        {
            if (first == null)
            {
                throw new Exception("Linked list is empty");
            }

            var current = first;
            Node<T>? prev = null;
            while (current != null)
            {
                var next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            (last, first) = (first, last);
        }

        //If we don't know the size and last pointer
        public T FindKthNodeFromEnd(int k)
        {
            if (first == null)
            {
                throw new Exception("Linked list is empty");
            }

            Node<T>? current = first;

            for (int i = 0; i < k - 1; i++)
            {
                current = current.Next;
                if (current == null)
                    throw new Exception("invalid value of K");
            }

            Node<T>? target = first;
            while (current.Next != null)
            {
                target = target.Next;
                current = current.Next;
            }

            return target.Value;
        }

        //If we don't know the size
        public T FindMiddle()
        {
            if (first == null)
            {
                throw new Exception("Linked list is empty");
            }

            if (first.Next == null)
            {
                return first.Value;
            }

            Node<T>? fast = first;
            Node<T>? slow = first;
            while (fast.Next != null)
            {
                fast = fast.Next.Next;
                if (fast == null)
                    break;

                slow = slow.Next;
            }

            return slow.Value;
        }

        //If we don't know the size
        public bool CheckForLoop()
        {
            if (first == null)
            {
                throw new Exception("Linked list is empty");
            }

            Node<T>? fast = first;
            Node<T>? slow = first;
            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
                if (fast == slow)
                {
                    return true;
                }
            }

            return false;
        }


        //If we don't know the size
        public void CreateLoop()
        {
            if (first == null || first.Next == null)
            {
                throw new Exception("Can not create loop");
            }

            Node<T>? fast = first;
            Node<T>? slow = first;
            while (fast != last && fast.Next != last)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            fast.Next = slow;
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