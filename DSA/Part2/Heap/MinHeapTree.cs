namespace DSA.Part2.Heap
{

    public class MinHeapTree
    {
        readonly KeyValuePair<int, string>[] heap;

        int lastIndex = -1;
        public MinHeapTree(int size)
        {
            heap = new KeyValuePair<int, string>[size];
        }

        //insert(int) 
        // O(log n)
        public void Insert(int key, string value)
        {
            if (IsFull())
                throw new InvalidOperationException("Heap is full");

            heap[++lastIndex] = KeyValuePair.Create(key, value);
            BubbleUp();
        }

        //remove()
        //O(1)
        public string Remove()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Heap is Empty");

            var rootNode = heap[0];
            heap[0] = heap[lastIndex];

            BubbleDown();

            lastIndex--;
            return rootNode.Value;
        }

        public KeyValuePair<int, string> MinPriority()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Heap is Empty");
            return heap[0];
        }


        private int GetSmallerChildIndex(int index)
        {
            if (!HasLeftChild(index))
                return index;

            if (!HasRightChild(index))
                return GetLeftChildIndex(index);

            return LeftChild(index).Key < RightChild(index).Key ? GetLeftChildIndex(index) : GetRightChildIndex(index);
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

            var isValid = heap[index].Key <= LeftChild(index).Key;

            if (HasRightChild(index))
                isValid &= heap[index].Key <= RightChild(index).Key;

            return isValid;
        }

        private KeyValuePair<int, string> LeftChild(int index)
        {
            return heap[GetLeftChildIndex(index)];
        }


        private KeyValuePair<int, string> RightChild(int index)
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

            while (indexOfNewNode > 0 && heap[indexOfNewNode].Key < heap[indexOfParent].Key)
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
                var smallerChildIndex = GetSmallerChildIndex(indexOfNewNode);
                Swap(smallerChildIndex, indexOfNewNode);
                indexOfNewNode = smallerChildIndex;
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
            var newHeap = new KeyValuePair<int, string>[lastIndex + 1];
            Array.Copy(heap, 0, newHeap, 0, lastIndex + 1);
            Console.WriteLine(string.Join(",", newHeap));
        }
    }
}