namespace DSA.Part2.Heap
{
    public class PriorityQueueWithHeap
    {
        HeapTree heap = new(10);
        public void Add(int item)
        {
            heap.Insert(item);
        }

        public int Remove()
        {
            return heap.Remove();
        }

        public bool IsEmpty()
        {
            return heap.IsEmpty();
        }
    }
}