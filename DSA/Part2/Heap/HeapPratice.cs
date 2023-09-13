using DSA.Part2;

namespace DSA.Part2.Heap
{

    public class HeapPratice
    {
        public static void SortArrayUsingHeap()
        {
            int[] numbers = new int[] { 5, 3, 10, 1, 4, 2 };
            var heap = new HeapTree(numbers.Length);
            foreach (var num in numbers)
                heap.Insert(num);

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = heap.Remove();

            Console.WriteLine("asc: " + string.Join(",", numbers));


            numbers = new int[] { 5, 3, 10, 1, 4, 2 };
            foreach (var num in numbers)
                heap.Insert(num);

            for (int i = numbers.Length - 1; i >= 0; i--)
                numbers[i] = heap.Remove();

            Console.WriteLine("dsc: " + string.Join(",", numbers));
        }
    }
}