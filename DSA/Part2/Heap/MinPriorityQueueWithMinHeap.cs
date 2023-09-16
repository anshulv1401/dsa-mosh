namespace DSA.Part2.Heap
{
    public class MinPriorityQueueWithMinHeap
    {
        MinHeapTree minHeap = new(10);
        public void Add(string item, int priority)
        {
            minHeap.Insert(priority, item);
        }

        public string Remove()
        {
            return minHeap.Remove();
        }

        public bool IsEmpty()
        {
            return minHeap.IsEmpty();
        }
    }
}