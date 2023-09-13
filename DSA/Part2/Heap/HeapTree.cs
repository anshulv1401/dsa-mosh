namespace DSA.Part2.Heap
{

    public class HeapTree
    {
        readonly int[] heap;

        int lastIndex = -1;
        public HeapTree(int size)
        {
            heap = new int[size];
        }

        //insert(int)
        public void Insert(int value)
        {
            if (IsFull())
                throw new InvalidOperationException("Heap is full");

            heap[++lastIndex] = value;
            BubbleUp();
        }

        //remove()
        public int Remove()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Heap is Empty");

            int rootValue = heap[0];
            heap[0] = heap[lastIndex];

            BubbleDown();

            lastIndex--;
            return rootValue;
        }

        private int GetLargerChildIndex(int index)
        {
            if (!HasLeftChild(index))
                return index;

            if (!HasRightChild(index))
                return GetLeftChildIndex(index);

            return LeftChild(index) > RightChild(index) ? GetLeftChildIndex(index) : GetRightChildIndex(index);
        }

        private bool HasLeftChild(int index)
        {
            return GetLeftChildIndex(index) <= lastIndex;
        }

        private bool HasRightChild(int index)
        {
            return GetRightChildIndex(index) <= lastIndex;
        }

        private bool IsValidParent(int index)
        {
            if (!HasLeftChild(index))
                return true;

            var isValid = heap[index] >= LeftChild(index);

            if (HasRightChild(index))
                isValid &= heap[index] >= RightChild(index);

            return isValid;
        }

        public int LeftChild(int index)
        {
            return heap[GetLeftChildIndex(index)];
        }


        public int RightChild(int index)
        {
            return heap[GetRightChildIndex(index)];
        }


        private void Swap(int index1, int index2)
        {
            (heap[index2], heap[index1]) = (heap[index1], heap[index2]);
        }

        public bool IsFull()
        {
            return lastIndex + 1 == heap.Length;
        }

        public bool IsEmpty()
        {
            return lastIndex == -1;
        }

        private void BubbleUp()
        {
            int indexOfNewNode = lastIndex;
            int indexOfParent = GetParentIndex(indexOfNewNode);

            while (indexOfNewNode > 0 && heap[indexOfNewNode] > heap[indexOfParent])
            {
                Swap(indexOfParent, indexOfNewNode);
                indexOfNewNode = indexOfParent;
                indexOfParent = GetParentIndex(indexOfNewNode);
            }
        }

        private void BubbleDown()
        {
            int indexOfNewNode = 0;
            while (indexOfNewNode <= lastIndex && !IsValidParent(indexOfNewNode))
            {
                var largerChildIndex = GetLargerChildIndex(indexOfNewNode);
                Swap(largerChildIndex, indexOfNewNode);
                indexOfNewNode = largerChildIndex;
            }
        }

        private static int GetParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        private static int GetLeftChildIndex(int index)
        {
            return index * 2 + 1;
        }

        private static int GetRightChildIndex(int index)
        {
            return index * 2 + 2;
        }

        public void PrintTree()
        {
            var newHeap = new int[lastIndex + 1];
            Array.Copy(heap, 0, newHeap, 0, lastIndex + 1);
            Console.WriteLine(string.Join(",", newHeap));
        }
    }
}